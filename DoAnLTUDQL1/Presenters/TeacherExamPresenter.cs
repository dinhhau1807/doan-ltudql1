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
    public class TeacherExamPresenter
    {
        ITeacherExamView view;

        public TeacherExamPresenter(ITeacherExamView examView)
        {
            view = examView;
            Initializer();
        }

        private void Initializer()
        {
            // Load list exam
            ReloadListExam(view, null);

            // Get list subject
            GetListSubject();

            // Events
            view.ReloadListExam += ReloadListExam;
            view.ReloadListExamDetail += ReloadListExamDetail;
            view.DeleteExam += DeleteExam;
            view.SaveEditExam += SaveEditExam;
            view.AddExam += AddExam;
        }

        private void AddExam(object sender, EventArgs e)
        {
            try
            {
                var examAdded = sender as DoAnLTUDQL1.Exam;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    // Get examId
                    var examIds = context.Exams.Select(ec => ec.ExamId.Substring(2)).ToList();
                    var examId = examIds.Select(id => int.Parse(id)).Max() + 1;
                    examAdded.ExamId = $"CT{examId:D6}";

                    context.Exams.InsertOnSubmit(examAdded);
                    context.SubmitChanges();

                    foreach (var examDetail in view.ExamDetailsAdded)
                    {
                        // Get examDetailId
                        var examDetailIds = context.ExamDetails.Select(ed => ed.ExamDetailId.Substring(2)).ToList();
                        var examDetailId = examDetailIds.Select(id => int.Parse(id)).Max() + 1;
                        examDetail.ExamDetailId = $"KT{examDetailId:D6}";
                        examDetail.ExamId = examAdded.ExamId;

                        context.ExamDetails.InsertOnSubmit(examDetail);
                        context.SubmitChanges();
                    }
                }

                view.AddExamMessage = "Succeed";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.AddExamMessage = "Failed";
            }
        }

        private void SaveEditExam(object sender, EventArgs e)
        {
            try
            {
                var examEdited = sender as DoAnLTUDQL1.Exam;

                bool checkUsed = false;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var examDb = context.Exams.Single(ex => ex.ExamId == examEdited.ExamId);
                    var examDetailsDb = context.ExamDetails.Where(ed => ed.ExamId == examDb.ExamId);

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
                        examDb.ExamName = examEdited.ExamName;
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

                if (!checkUsed)
                {
                    view.SaveEditExamMessage = "Succeed";
                }
                else
                {
                    view.SaveEditExamMessage = "Used";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.SaveEditExamMessage = "Failed";
            }
        }

        private void DeleteExam(object sender, EventArgs e)
        {
            try
            {
                var examId = (string)sender;

                bool check = false;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var examDetail = context.ExamDetails.First(ed => ed.ExamId == examId);
                    var countUsed = context.ExamTakes.Where(et => et.ExamDetailId == examDetail.ExamDetailId).Count();

                    if (countUsed <= 0)
                    {
                        var exam = context.Exams.First(ex => ex.ExamId == examId);

                        context.ExamDetails.DeleteOnSubmit(examDetail);
                        context.Exams.DeleteOnSubmit(exam);

                        context.SubmitChanges();

                        check = true;
                    }
                }

                if (check)
                {
                    view.DeleteExamMessage = "Succeed";
                }
                else
                {
                    view.DeleteExamMessage = "Used";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.DeleteExamMessage = "Failed";
            }
        }

        private void ReloadListExam(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                view.Exams =
                    (from ex in context.Exams
                     join ed in context.ExamDetails on ex.ExamId equals ed.ExamId
                     join s in context.Subjects on new { ed.SubjectId, ed.GradeId } equals new { s.SubjectId, s.GradeId }
                     join t in context.Teaches on new { s.SubjectId, s.GradeId } equals new { t.SubjectId, t.GradeId }
                     where t.TeacherId == view.CurrentUser.TeacherId && ex.IsPacticeExam.GetValueOrDefault(false) == false
                     select ex).Distinct().ToList();

                var examNotListed = context.Exams.Where(ex => !context.ExamDetails.Any(ed => ed.ExamId == ex.ExamId) && ex.IsPacticeExam == false).ToList();

                foreach (var exam in examNotListed)
                {
                    view.Exams.Add(exam);
                }
            }
        }

        private void ReloadListExamDetail(object sender, EventArgs e)
        {
            var examId = sender as string;
            if (examId != null || !string.IsNullOrEmpty(examId))
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    view.ExamDetails = (from ex in context.Exams
                                        where ex.ExamId == examId
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
