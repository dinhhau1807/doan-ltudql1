using DoAnLTUDQL1.ViewModels;
using DoAnLTUDQL1.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class TeacherPracticeExamPresenter
    {
        ITeacherPracticeExamView view;

        public TeacherPracticeExamPresenter(ITeacherPracticeExamView practiceExamView)
        {
            view = practiceExamView;
            Initializer();
        }

        private void Initializer()
        {
            // Load list PracticeExam
            ReloadListPracticeExam(view, null);

            // Get list subject
            GetListSubject();


            // Events
            view.ReloadListPracticeExam += ReloadListPracticeExam;
            view.ReloadListExamDetail += ReloadListExamDetail;
            view.DeletePracticeExam += DeletePracticeExam;
            view.SaveEditPracticeExam += SaveEditPracticeExam;
            view.AddPracticeExam += AddPracticeExam;
            view.UpdateStudentMark += UpdateStudentMark;
        }

        private void UpdateStudentMark(object sender, EventArgs e)
        {
            try
            {
                var examDetail = sender as ExamListViewModel;
                var startTime = examDetail.StartTime.Value + new TimeSpan(0, 0, examDetail.Duration.Value, 0, 0);
                if (startTime < DateTime.Now)
                {
                    using (var context = new QLThiTracNghiemDataContext())
                    {
                        var students = (from s in context.Students
                                        join c in context.Classrooms on s.ClassroomId equals c.ClassroomId
                                        join t in context.Teaches on c.ClassroomId equals t.ClassroomId
                                        where t.SubjectId == examDetail.SubjectId && t.GradeId == examDetail.GradeId
                                        select s).ToList();

                        var examCodes = context.ExamCodes.Where(ec => ec.SubjectId == examDetail.SubjectId && ec.GradeId == ec.GradeId && ec.IsPracticeExam == false).First();

                        foreach (var s in students)
                        {
                            if (!context.ExamTakes.Any(et => et.StudentId == s.StudentId && et.ExamDetailId == examDetail.ExamDetailId))
                            {
                                var examTake = new ExamTake
                                {
                                    ExamDetailId = examDetail.ExamDetailId,
                                    StudentId = s.StudentId,
                                    StartTime = examDetail.StartTime,
                                    EndTime = examDetail.StartTime,
                                    ExamCodeId = examCodes.ExamCodeId
                                };

                                var examResult = new ExamResult
                                {
                                    ExamDetailId = examDetail.ExamDetailId,
                                    StudentId = s.StudentId,
                                    NumberOfCorrectAnswers = 0,
                                    NumberOfQuestionsAnswered = 0,
                                    Mark = 0,
                                    ExamCodeId = examCodes.ExamCodeId
                                };

                                context.ExamTakes.InsertOnSubmit(examTake);
                                context.ExamResults.InsertOnSubmit(examResult);
                            }
                        }

                        context.SubmitChanges();
                    }

                    view.UpdateStudentMarkMessage = "Succeed";
                }
                else
                {
                    view.UpdateStudentMarkMessage = "NotYet";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.UpdateStudentMarkMessage = "Failed";
            }
        }

        private void AddPracticeExam(object sender, EventArgs e)
        {
            try
            {
                var practiceExamAdded = sender as DoAnLTUDQL1.Exam;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    // Get PracticeExamId
                    var practiceExamIds = context.Exams.Select(ec => ec.ExamId.Substring(2)).ToList();
                    var practiceExamId = practiceExamIds.Select(id => int.Parse(id)).Max() + 1;
                    practiceExamAdded.ExamId = $"TT{practiceExamId:D6}";

                    context.Exams.InsertOnSubmit(practiceExamAdded);
                    context.SubmitChanges();

                    foreach (var examDetail in view.ExamDetailsAdded)
                    {
                        // Get PracticeExamDetailId
                        var practiceExamDetailIds = context.ExamDetails.Select(ed => ed.ExamDetailId.Substring(2)).ToList();
                        var practiceExamDetailId = practiceExamDetailIds.Select(id => int.Parse(id)).Max() + 1;
                        examDetail.ExamId = $"KT{practiceExamDetailId:D6}";
                        examDetail.ExamId = practiceExamAdded.ExamId;

                        context.ExamDetails.InsertOnSubmit(examDetail);
                        context.SubmitChanges();
                    }
                }

                view.AddPracticeExamMessage = "Succeed";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.AddPracticeExamMessage = "Failed";
            }
        }

        private void SaveEditPracticeExam(object sender, EventArgs e)
        {
            try
            {
                var practiceExamEdited = sender as DoAnLTUDQL1.Exam;

                bool checkUsed = false;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var practiceExamDb = context.Exams.Single(ex => ex.ExamId == practiceExamEdited.ExamId);
                    var examDetailsDb = context.ExamDetails.Where(ed => ed.ExamId == practiceExamDb.ExamId);

                    // Check used
                    foreach (var examDetailDb in examDetailsDb)
                    {
                        if (context.ExamTakes.Any(et => et.ExamDetailId == examDetailDb.ExamDetailId))
                        {
                            checkUsed = true;
                            break;
                        }
                    }

                    // Update name if not used
                    if (!checkUsed)
                    {
                        practiceExamDb.ExamName = practiceExamEdited.ExamName;
                        context.SubmitChanges();
                    }

                    // Delete
                    foreach (var examDetailDb in examDetailsDb)
                    {
                        if (view.ExamDetailsEdited.Any(ed => ed.ExamDetailId == examDetailDb.ExamDetailId))
                        {
                            // If exists, don't delete
                            continue;
                        }
                        context.ExamDetails.DeleteOnSubmit(examDetailDb);
                    }
                    context.SubmitChanges();

                    foreach (var examDetail in view.ExamDetailsEdited)
                    {
                        // Add
                        if (string.IsNullOrEmpty(examDetail.ExamDetailId))
                        {
                            // Get examDetailId
                            var examDetailIds = context.ExamDetails.Select(ed => ed.ExamDetailId.Substring(2)).ToList();
                            var examDetailId = examDetailIds.Select(id => int.Parse(id)).Max() + 1;
                            examDetail.ExamDetailId = $"KT{examDetailId:D6}";

                            context.ExamDetails.InsertOnSubmit(examDetail);
                        }

                        // Update
                        else
                        {
                            var examDetailDb = examDetailsDb.Single(ed => ed.ExamDetailId == examDetail.ExamDetailId);
                            examDetailDb.Duration = examDetail.Duration;
                            examDetailDb.StartTime = examDetail.StartTime;
                            examDetailDb.SubjectId = examDetail.SubjectId;
                            examDetailDb.GradeId = examDetail.GradeId;
                        }
                        context.SubmitChanges();
                    }
                }

                if (checkUsed)
                {
                    view.SaveEditPracticeExamMessage = "Succeed";
                }
                else
                {
                    view.SaveEditPracticeExamMessage = "Used";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.SaveEditPracticeExamMessage = "Failed";
            }
        }

        private void DeletePracticeExam(object sender, EventArgs e)
        {
            try
            {
                var practiceExamId = (string)sender;

                bool check = false;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var practiceExamDetail = context.ExamDetails.FirstOrDefault(ed => ed.ExamId == practiceExamId);
                    if (practiceExamDetail != null)
                    {
                        var examDetailsCount = context.ExamDetails.Where(ed => ed.ExamId == practiceExamId);
                        var countUsed = context.ExamTakes.Where(et => examDetailsCount.Any(ed => ed.ExamDetailId == et.ExamDetailId)).Count();

                        if (countUsed <= 0)
                        {
                            var practiceExam = context.Exams.First(ex => ex.ExamId == practiceExamId);

                            var examDetails = context.ExamDetails.Where(ed => ed.ExamId == practiceExam.ExamId);
                            context.ExamDetails.DeleteAllOnSubmit(examDetails);
                            context.Exams.DeleteOnSubmit(practiceExam);
                            context.SubmitChanges();

                            check = true;
                        }
                    }
                    else
                    {
                        var practiceExam = context.Exams.First(ex => ex.ExamId == practiceExamId);
                        context.Exams.DeleteOnSubmit(practiceExam);
                        context.SubmitChanges();
                        check = true;
                    }
                }

                if (check)
                {
                    view.DeletePracticeExamMessage = "Succeed";
                }
                else
                {
                    view.DeletePracticeExamMessage = "Used";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.DeletePracticeExamMessage = "Failed";
            }
        }

        private void ReloadListPracticeExam(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                view.PracticeExams =
                    (from ex in context.Exams
                     join ed in context.ExamDetails on ex.ExamId equals ed.ExamId
                     join s in context.Subjects on new { ed.SubjectId, ed.GradeId } equals new { s.SubjectId, s.GradeId }
                     join t in context.Teaches on new { s.SubjectId, s.GradeId } equals new { t.SubjectId, t.GradeId }
                     where t.TeacherId == view.CurrentUser.TeacherId && ex.IsPacticeExam.GetValueOrDefault(false) == true
                     select ex).Distinct().ToList();

                var practiceExamNotListed = context.Exams.Where(ex => !context.ExamDetails.Any(ed => ed.ExamId == ex.ExamId) && ex.IsPacticeExam == true).ToList();

                foreach (var practiceExam in practiceExamNotListed)
                {
                    view.PracticeExams.Add(practiceExam);
                }
            }
        }

        private void ReloadListExamDetail(object sender, EventArgs e)
        {
            var practiceExamId = sender as string;
            if (practiceExamId != null || !string.IsNullOrEmpty(practiceExamId))
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    view.ExamDetails = (from ex in context.Exams
                                        where ex.ExamId == practiceExamId
                                        join ed in context.ExamDetails on ex.ExamId equals ed.ExamId
                                        join s in context.Subjects on new { ed.SubjectId, ed.GradeId } equals new { s.SubjectId, s.GradeId }
                                        select new ExamListViewModel
                                        {
                                            ExamId = ex.ExamId,
                                            ExamName = ex.ExamName,
                                            ExamDetailId = ed.ExamDetailId,
                                            StartTime = ed.StartTime,
                                            Duration = ed.Duration,
                                            SubjectId = ed.SubjectId,
                                            GradeId = ed.GradeId,
                                            SubjectName = s.SubjectName
                                        }).ToList();
                }
            }
        }

        private void GetListSubject()
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    context.DeferredLoadingEnabled = false;
                    view.Subjects = (from s in context.Subjects
                                     join t in context.Teaches on new { s.SubjectId, s.GradeId } equals new { t.SubjectId, t.GradeId }
                                     where t.TeacherId == view.CurrentUser.TeacherId
                                     select s).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }
    }
}
