using DoAnLTUDQL1.Views.Exam;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
	public class ExamPresenter
	{
		IExamView view;
		string examDetailId;
		string username;
		int currentQuestionIndex;

		QLThiTracNghiemDataContext context = new QLThiTracNghiemDataContext();
		public ExamPresenter(IExamView examView, string examDetailId, string username)
		{
			this.view = examView;
			this.examDetailId = examDetailId;
			this.username = username;

			view.getExamCodeList += View_getExamCodeList;
			view.createExamAttendance += View_createExamAttendance;
			view.nextQuestion += View_nextQuestion;
			view.prevQuestion += View_prevQuestion;
			view.changeQuestion += View_changeQuestion;
			view.showKeyQuestion += View_showKeyQuestion;
			view.turnInTheExam += View_turnInTheExam;
			view.setExamCode += View_setExamCode;

			Initializer();
		}

		private List<ExamCode> View_getExamCodeList(bool isPracticeExam)
		{
			if (isPracticeExam)
			{
				return context.ExamCodes.Where(w => w.GradeId == view.ExamDetail.GradeId
											&& w.SubjectId == view.ExamDetail.SubjectId
											&& w.IsPracticeExam == true).ToList();
			}
			return context.ExamCodes.Where(w => w.GradeId == view.ExamDetail.GradeId
											&& w.SubjectId == view.ExamDetail.SubjectId
											&& w.IsPracticeExam == false).ToList();
		}

		private void View_setExamCode(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(sender.ToString()))
			{
				view.ExamCode = context.ExamCodes.SingleOrDefault(s => s.ExamCodeId == sender.ToString());
			}
			else
			{
				view.ExamCode = getExamCodeByRandom();
			}

			//update examcodeid of the exam take
			updateExamTake(view.ExamCode.ExamCodeId,
							view.ExamDetail.ExamDetailId,
							view.StudentInfo.StudentId);

			view.QuestionList = (from examCodeQuestion in context.ExamCode_Questions
								 join ques in context.Questions
								 on examCodeQuestion.QuestionId equals ques.QuestionId
								 where examCodeQuestion.ExamCodeId == view.ExamCode.ExamCodeId
								 select ques).OrderBy(o => o.DifficultLevel).ThenBy(o => o.Content[0]).ToList();

			currentQuestionIndex = 0;

			LoadQuestion();
		}

		private void View_changeQuestion(object sender, EventArgs e)
		{
			if(view.QuestionList != null)
			{
				int questionId = int.Parse(sender.ToString());

				currentQuestionIndex = view.QuestionList.FindIndex(q => q.QuestionId == questionId);

				LoadQuestion();
			}
		}

		private void View_turnInTheExam(object sender, EventArgs e)
		{
			int correct = 0;
			var answerListFromUser = sender as List<dynamic>;

			correct = calculateNumberOfCorrectAnswers(answerListFromUser);

			string studentId = view.StudentInfo.StudentId;
			var examTake = context.ExamTakes
						.SingleOrDefault(s => s.StudentId == studentId
											&& s.ExamDetailId == examDetailId);

			//insert exam result
			var examResult = new ExamResult()
			{
				ExamDetailId = examTake.ExamDetailId,
				StudentId = examTake.StudentId,
				ExamCodeId = examTake.ExamCodeId,
				NumberOfQuestionsAnswered = view.ExamCode.NumberOfQuestions,
				NumberOfCorrectAnswers = correct,
				Mark = ((float)10/view.ExamCode.NumberOfQuestions)*correct
			};
			context.ExamResults.InsertOnSubmit(examResult);
			context.SubmitChanges();
		}

		private void View_showKeyQuestion(object sender, EventArgs e)
		{
			if(view.QuestionList != null)
			{
				LoadQuestion();
			}
		}

		private void View_prevQuestion(object sender, EventArgs e)
		{
			if(view.QuestionList != null)
			{
				if (currentQuestionIndex > 0)
				{
					currentQuestionIndex--;
					LoadQuestion();
				}
			}
		}

		private void View_nextQuestion(object sender, EventArgs e)
		{
			if(view.QuestionList != null)
			{
				if (currentQuestionIndex < view.QuestionList.Count - 1)
				{
					currentQuestionIndex++;
					LoadQuestion();
				}
			}
		}

		private bool View_createExamAttendance()
		{
			var endTime = view.ExamDetail.StartTime.Value;
			var examTake = new ExamTake()
			{
				ExamDetailId = view.ExamDetail.ExamDetailId,
				StudentId = view.StudentInfo.StudentId,
				StartTime = DateTime.Now,
				EndTime = endTime.AddMinutes(view.ExamDetail.Duration.Value),
				ExamCodeId = ""
			};			

			try
			{
				context.ExamTakes.InsertOnSubmit(examTake);
				context.SubmitChanges();
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		int calculateNumberOfCorrectAnswers(List<dynamic> answerListFromUser)
		{
			int correct = 0;
			foreach (var question in view.QuestionList)
			{
				//get correct answers of the question
				var correctAnswers = context.Answers
							.Where(answer => answer.QuestionId == question.QuestionId
									&& answer.IsCorrect == true);

				//get answers of the question from user
				var answerFromUser = answerListFromUser
									.SingleOrDefault(s => s.QuestionId == question.QuestionId);

				if (correctAnswers.Count() == answerFromUser.Answers.Count)
				{
					//get answers
					var Answers = answerFromUser.Answers as List<Answer>;

					var incorrectAnswers = Answers
										.Where(w => !correctAnswers.Any(a => a.AnswerId == w.AnswerId));

					if (incorrectAnswers.Count() == 0)
					{
						correct++;
					}
				}
			}

			return correct;
		}

		private void updateExamTake(string examCodeId, string examDetailId, string studentId)
		{
			try
			{
				var examTake = context.ExamTakes
							.SingleOrDefault(s => s.StudentId == studentId
											&& s.ExamDetailId == examDetailId);

				examTake.ExamCodeId = examCodeId;
				context.SubmitChanges();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		ExamCode getExamCodeByRandom()
		{
			var listExamCode = context.ExamCodes.Where(w => w.GradeId == view.ExamDetail.GradeId
											&& w.SubjectId == view.ExamDetail.SubjectId
											&& w.IsPracticeExam == false).ToList();

			Random rd = new Random();

			return listExamCode[rd.Next(0, listExamCode.Count)];
		}

		void LoadQuestion()
		{
			var question = view.QuestionList[currentQuestionIndex];
			string content = $"Câu {currentQuestionIndex + 1}: {question.Content}";

			EntitySet<Answer> answerList = new EntitySet<Answer>();
			foreach (var item in question.Answers)
			{
				Answer answer = new Answer()
				{
					AnswerId = item.AnswerId,
					QuestionId = item.QuestionId,
					Content = item.Content,
					IsCorrect = item.IsCorrect
				};

				answerList.Add(answer);
			}

			//copy object
			view.Question = new Question()
			{
				QuestionId = question.QuestionId,
				Content = content,
				Hint = question.Hint,
				SubjectId = question.SubjectId,
				GradeId = question.GradeId,
				DifficultLevel = question.DifficultLevel,
				Answers = answerList
			};
			view.AnswerList = context.Answers.Where(w => w.QuestionId == question.QuestionId).ToList();
		}

		void Initializer()
		{
			var currentUser = context.Users.SingleOrDefault(s => s.Username == username);

			view.StudentInfo = context.Students.Where(w => w.Username == currentUser.Username)
								.Select(s => new 
								{
									s.StudentId,
									Name = $"{currentUser.FirstName} {currentUser.LastName}",
									currentUser.Dob,
									currentUser.Phone
								}).FirstOrDefault();

			view.ExamDetail = context.ExamDetails.SingleOrDefault(s => s.ExamDetailId == examDetailId);
		}
	}
}
