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
            view.DeletePracticeExam += DeletePracticeExam;
            view.SaveEditPracticeExam += SaveEditPracticeExam;
            view.AddPracticeExam += AddPracticeExam;
        }

        private void AddPracticeExam(object sender, EventArgs e)
        {
            try
            {
                var PracticeExamAdded = sender as PracticeExamListViewModel;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    // Get PracticeExamId
                    var PracticeExamIds = context.Exams.Select(ec => ec.ExamId.Substring(2)).ToList();
                    var PracticeExamId = PracticeExamIds.Select(id => int.Parse(id)).Max() + 1;
                    PracticeExamAdded.ExamId = $"TT{PracticeExamId:D6}";

                    // Get PracticeExamDetailId
                    var PracticeExamDetailIds = context.ExamDetails.Select(ed => ed.ExamDetailId.Substring(2)).ToList();
                    var PracticeExamDetailId = PracticeExamDetailIds.Select(id => int.Parse(id)).Max() + 1;
                    PracticeExamAdded.ExamDetailId = $"KT{PracticeExamDetailId:D6}";

                    var PracticeExam = new Exam
                    {
                        ExamId = PracticeExamAdded.ExamId,
                        ExamName = PracticeExamAdded.ExamName,
                        IsPacticeExam = true
                    };

                    var PracticeExamDetail = new ExamDetail
                    {
                        ExamDetailId = PracticeExamAdded.ExamDetailId,
                        ExamId = PracticeExamAdded.ExamId,
                        StartTime = PracticeExamAdded.StartTime,
                        Duration = PracticeExamAdded.Duration,
                        SubjectId = PracticeExamAdded.SubjectId,
                        GradeId = PracticeExamAdded.GradeId
                    };

                    context.Exams.InsertOnSubmit(PracticeExam);
                    context.ExamDetails.InsertOnSubmit(PracticeExamDetail);

                    context.SubmitChanges();
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
                var practiceExamEdited = sender as PracticeExamListViewModel;

                bool check = false;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var countUsed = context.ExamTakes.Where(et => et.ExamDetailId == practiceExamEdited.ExamDetailId).Count();

                    if (countUsed <= 0)
                    {
                        var practiceExam = context.Exams.First(ex => ex.ExamId == practiceExamEdited.ExamId);
                        var practiceExamDetail = context.ExamDetails.First(ed => ed.ExamDetailId == practiceExamEdited.ExamDetailId);

                        practiceExam.ExamName = practiceExamEdited.ExamName;

                        practiceExamDetail.StartTime = practiceExamEdited.StartTime;
                        practiceExamDetail.Duration = practiceExamEdited.Duration;
                        practiceExamDetail.SubjectId = practiceExamEdited.SubjectId;
                        practiceExamDetail.GradeId = practiceExamEdited.GradeId;

                        context.SubmitChanges();
                        check = true;
                    }
                }

                if (check)
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
                    var PracticeExamDetail = context.ExamDetails.First(ed => ed.ExamId == practiceExamId);
                    var countUsed = context.ExamTakes.Where(et => et.ExamDetailId == PracticeExamDetail.ExamDetailId).Count();

                    if (countUsed <= 0)
                    {
                        var practiceExam = context.Exams.First(ex => ex.ExamId == practiceExamId);

                        context.ExamDetails.DeleteOnSubmit(PracticeExamDetail);
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
                     select new PracticeExamListViewModel
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
