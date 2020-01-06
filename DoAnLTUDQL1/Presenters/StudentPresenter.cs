using DoAnLTUDQL1.Views.StudentView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
	public class StudentPresenter
	{
		IStudentView view;

		//store the current user
		User CurrentUser;
		//store grade of that user
		int gradeId;

		//current context
		QLThiTracNghiemDataContext context = new QLThiTracNghiemDataContext();

		public StudentPresenter(IStudentView studentView, User currentUser)
		{
			this.view = studentView;
			this.CurrentUser = currentUser;

			//view.Logout += View_Logout;
			view.ChangePassword += View_ChangePassword;
			view.ChangeUserProfile += View_ChangeUserProfile;
			view.ExamDetailFilter += View_ExamDetailFilter;
			view.ExamResultFilter += View_ExamResultFilter;
			view.StartExamination += View_StartExamination;

			Initializer();
		}

		private void Initializer()
		{
			Student student;
			student = context.Students.SingleOrDefault(s => s.Username == CurrentUser.Username);

			if (student == null)
				return;

			//get current student's grade
			gradeId = (from classroom in context.Classrooms
					   join grade in context.Grades
					   on classroom.GradeId equals grade.GradeId
					   where classroom.ClassroomId == student.ClassroomId
					   select grade.GradeId).FirstOrDefault();

			//load current user profile
			view.StudentId = student.StudentId;
			view.FirstName = CurrentUser.FirstName;
			view.LastName = CurrentUser.LastName;
			view.Phone = CurrentUser.Phone;
			view.Dob = CurrentUser.Dob;
			view.CreatedDate = CurrentUser.CreatedDate;

			view.ExamDetailList = getExamDetailListByGradeId(gradeId, (int)Enums.TYPE_OF_EXAM.ALL);
			view.ExamResultList = getExamResultListByStudentId(view.StudentId, (int)Enums.TYPE_OF_EXAM.ALL);
		}

		private int View_StartExamination()
		{
			// beforeExamTime ( examTime ) afterExamTime
			//		-1				0			1
			DateTime currentTime = DateTime.Now;
			DateTime startExamTime = view.TheLatestExamDetail.StartTime;
			DateTime endExamTime = view.TheLatestExamDetail.StartTime.AddMinutes(view.TheLatestExamDetail.Duration);

			if(currentTime.CompareTo(startExamTime) < 0)
			{
				view.Message = "Chưa đến thời gian làm bài!";
				return -1;
			}
			else if(currentTime.CompareTo(endExamTime) > 0)
			{
				view.Message = "Đã hết thời gian làm bài!";
				return 1;
			}
			return 0;
		}

		private void View_ExamResultFilter(object sender, EventArgs e)
		{
			int valFilter = int.Parse(sender.ToString());
			view.ExamResultList = getExamResultListByStudentId(view.StudentId, valFilter);
		}

		private void View_ExamDetailFilter(object sender, EventArgs e)
		{
			int valFilter = int.Parse(sender.ToString());
			view.ExamDetailList = getExamDetailListByGradeId(gradeId, valFilter);
		}

		private bool View_ChangeUserProfile()
		{
			User user;
			try
			{
				user = context.Users.SingleOrDefault(s => s.Username == CurrentUser.Username);

				if (user != null)
				{
					user.FirstName = view.FirstName;
					user.LastName = view.LastName;
					user.Phone = view.Phone;
					user.Dob = view.Dob;

					context.SubmitChanges();

					view.Message = "Cập nhật thông tin thành công!";

					return true;
				}
				view.Message = "Cập nhật thông tin thất bại";
				return false;
			}
			catch (Exception)
			{
				return false;
			}
		}

		private User View_Logout()
		{
			return null;
		}

		private User View_ChangePassword()
		{
			if (view.oldPassword != CurrentUser.Password)
			{
				view.Message = "Mật khẩu cũ không đúng!";
				return null;
			}
			else
			{
				if (view.newPassword != view.reNewPassword)
				{
					view.Message = "Xác nhận mật khẩu không đúng!";
					return null;
				}
				else
				{
					try
					{
						User user;
						user = context.Users.Single(s => s.Username == CurrentUser.Username);
						user.Password = view.newPassword;

						context.SubmitChanges();

						CurrentUser = user;
						return CurrentUser;
					}
					catch (Exception)
					{
						return null;
					}
				}
			}
		}

		IEnumerable<dynamic> getExamDetailListByGradeId(int gradeId, int typeOfExamFilter)
		{
			IEnumerable<dynamic> result;
			if(typeOfExamFilter == (int)Enums.TYPE_OF_EXAM.ALL)
			{
				result = (from examDetail in context.ExamDetails
						let currentDatetime = DateTime.Now
						where examDetail.GradeId == gradeId 
						&& DateTime.Compare(currentDatetime, examDetail.StartTime.Value.AddMinutes(examDetail.Duration.Value)) < 0
						join exam in context.Exams
						on examDetail.ExamId equals exam.ExamId
						join subject in context.Subjects
						on examDetail.SubjectId equals subject.SubjectId
						where examDetail.GradeId == subject.GradeId
						join grade in context.Grades
						on examDetail.GradeId equals grade.GradeId
						select new
						{
							examDetail.ExamDetailId,
							exam.ExamName,
							subject.SubjectId,
							subject.SubjectName,
							grade.GradeName,
							examDetail.StartTime,
							examDetail.Duration
						}).OrderBy(o => o.StartTime);
			}
			else
			{
				result = (from examDetail in context.ExamDetails
						let currentDatetime = DateTime.Now
						where examDetail.GradeId == gradeId
						&& DateTime.Compare(currentDatetime, examDetail.StartTime.Value.AddMinutes(examDetail.Duration.Value)) < 0
						join exam in context.Exams
						on examDetail.ExamId equals exam.ExamId
						where exam.IsPacticeExam == (typeOfExamFilter == (int)Enums.TYPE_OF_EXAM.PRACTICE_EXAM)
						join subject in context.Subjects
						on examDetail.SubjectId equals subject.SubjectId
						where examDetail.GradeId == subject.GradeId
						join grade in context.Grades
						on examDetail.GradeId equals grade.GradeId
						select new
						{
							examDetail.ExamDetailId,
							exam.ExamName,
							subject.SubjectId,
							subject.SubjectName,
							grade.GradeName,
							examDetail.StartTime,
							examDetail.Duration
						}).OrderBy(o => o.StartTime);
			}
			//get the lastest exam detail
			view.TheLatestExamDetail = getTheLastestExamDetail(result);

			return result;
		}

		IEnumerable<dynamic> getExamResultListByStudentId(string studentId, int typeOfExamFilter)
		{
			IEnumerable<dynamic> result;
			if(typeOfExamFilter == (int)Enums.TYPE_OF_EXAM.ALL)
			{
				result = (from examResult in context.ExamResults
					   join examDetail in context.ExamDetails
					   on examResult.ExamDetailId equals examDetail.ExamDetailId
					   where examResult.StudentId == studentId
					   join exam in context.Exams
					   on examDetail.ExamId equals exam.ExamId
					   join subject in context.Subjects
					   on examDetail.SubjectId equals subject.SubjectId
					   where examDetail.GradeId == subject.GradeId
					   let examTake = context.ExamTakes.SingleOrDefault(s => s.ExamDetailId == examResult.ExamDetailId
											&& s.StudentId == examResult.StudentId)
						  select new
					   {
						   exam.ExamName,
						   Subject = $"{subject.SubjectId} - {subject.SubjectName}",
						   ExamCodeId = examTake != null ? examTake.ExamCodeId : "",
						   examResult.Mark,
						   examDetail.StartTime,
						   Status = examTake != null ? "Đã tham gia" : "Không tham gia"
					   }).OrderByDescending(o => o.StartTime);
			}
			else
			{
				result = (from examResult in context.ExamResults
					   join examDetail in context.ExamDetails
					   on examResult.ExamDetailId equals examDetail.ExamDetailId
					   where examResult.StudentId == studentId
					   join exam in context.Exams
					   on examDetail.ExamId equals exam.ExamId
					   where exam.IsPacticeExam == (typeOfExamFilter == (int)Enums.TYPE_OF_EXAM.PRACTICE_EXAM)
					   join subject in context.Subjects
					   on examDetail.SubjectId equals subject.SubjectId
					   where examDetail.GradeId == subject.GradeId
						  let examTake = context.ExamTakes.SingleOrDefault(s => s.ExamDetailId == examResult.ExamDetailId
											   && s.StudentId == examResult.StudentId)
						  select new
						  {
							  exam.ExamName,
							  Subject = $"{subject.SubjectId} - {subject.SubjectName}",
							  ExamCodeId = examTake != null ? examTake.ExamCodeId : "",
							  examResult.Mark,
							  examDetail.StartTime,
							  Status = examTake != null ? "Đã tham gia" : "Không tham gia"
						  }).OrderByDescending(o => o.StartTime);
			}
			return result;
		}

		//get the lastest exam detail with exam take has no exists
		dynamic getTheLastestExamDetail(IEnumerable<dynamic> listExamDetail)
		{
			if(listExamDetail.Count() > 0)
			{
				foreach (var examDetail in listExamDetail)
				{
					string examDetailId = examDetail.ExamDetailId;
					var examTake = context.ExamTakes
									.SingleOrDefault(s => s.ExamDetailId == examDetailId 
														&& s.StudentId == view.StudentId);

					if(examTake == null)
					{
						return examDetail;
					}
				}
			}
			return null;
		}
	}
}
