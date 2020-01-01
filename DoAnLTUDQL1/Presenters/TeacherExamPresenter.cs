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
            view.DeleteExam += DeleteExam;
            view.SaveEditExam += SaveEditExam;
            view.AddExam += AddExam;
        }

        private void AddExam(object sender, EventArgs e)
        {
            try
            {
                var examAdded = sender as ExamListViewModel;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    // Get examId
                    var examIds = context.Exams.Select(ec => ec.ExamId.Substring(2)).ToList();
                    var examId = examIds.Select(id => int.Parse(id)).Max() + 1;
                    examAdded.ExamId = $"CT{examId:D6}";

                    // Get examDetailId
                    var examDetailIds = context.ExamDetails.Select(ed => ed.ExamDetailId.Substring(2)).ToList();
                    var examDetailId = examDetailIds.Select(id => int.Parse(id)).Max() + 1;
                    examAdded.ExamDetailId = $"KT{examDetailId:D6}";

                    var exam = new Exam
                    {
                        ExamId = examAdded.ExamId,
                        ExamName = examAdded.ExamName,
                        IsPacticeExam = false
                    };

                    var examDetail = new ExamDetail
                    {
                        ExamDetailId = examAdded.ExamDetailId,
                        ExamId = examAdded.ExamId,
                        StartTime = examAdded.StartTime,
                        Duration = examAdded.Duration,
                        SubjectId = examAdded.SubjectId,
                        GradeId = examAdded.GradeId
                    };

                    context.Exams.InsertOnSubmit(exam);
                    context.ExamDetails.InsertOnSubmit(examDetail);

                    context.SubmitChanges();
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
                var examEdited = sender as ExamListViewModel;

                bool check = false;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var countUsed = context.ExamTakes.Where(et => et.ExamDetailId == examEdited.ExamDetailId).Count();

                    if (countUsed <= 0)
                    {
                        var exam = context.Exams.First(ex => ex.ExamId == examEdited.ExamId);
                        var examDetail = context.ExamDetails.First(ed => ed.ExamDetailId == examEdited.ExamDetailId);

                        exam.ExamName = examEdited.ExamName;

                        examDetail.StartTime = examEdited.StartTime;
                        examDetail.Duration = examEdited.Duration;
                        examDetail.SubjectId = examEdited.SubjectId;
                        examDetail.GradeId = examEdited.GradeId;

                        context.SubmitChanges();
                        check = true;
                    }
                }

                if (check)
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
