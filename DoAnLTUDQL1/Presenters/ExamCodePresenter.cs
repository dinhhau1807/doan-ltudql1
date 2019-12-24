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
    public class ExamCodePresenter
    {
        IExamCodeView view;

        public ExamCodePresenter(IExamCodeView examCodeView)
        {
            view = examCodeView;
            Initializer();
        }

        private void Initializer()
        {
            // Load list ExamCode
            ReloadListExamCode(view, null);

            // Get list subjects
            GetListSubject();

            // Init AddExamCodeQuestionIds
            view.AddExamCodeQuestionIds = new List<int>();

            // Events
            view.ReloadListExamCode += ReloadListExamCode;
            view.DeleteExamCode += DeleteExamCode;
            view.SaveEditExamCode += SaveEditExamCode;
            view.GetEditExamCodeQuestionIds += GetEditExamCodeQuestionIds;
            view.AddExamCode += AddExamCode;
        }

        private void AddExamCode(object sender, EventArgs e)
        {
            try
            {
                var examCodeAdded = sender as ExamCodeListViewModel;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    // Get examCodeId
                    var examCodeIds = context.ExamCodes.Select(ec => ec.ExamCodeId.Substring(2)).ToList();
                    var examCodeId = examCodeIds.Select(id => int.Parse(id)).Max() + 1;
                    examCodeAdded.ExamCodeId = $"DE{examCodeId:D6}";

                    var examCode = new ExamCode
                    {
                        ExamCodeId = examCodeAdded.ExamCodeId,
                        NumberOfQuestions = examCodeAdded.NumberOfQuestions,
                        SubjectId = examCodeAdded.SubjectId,
                        GradeId = examCodeAdded.GradeId,
                        IsPracticeExam = examCodeAdded.IsPracticeExam
                    };

                    context.ExamCodes.InsertOnSubmit(examCode);
                    context.SubmitChanges();

                    List<ExamCode_Question> examCode_Questions = new List<ExamCode_Question>();
                    foreach (var id in view.AddExamCodeQuestionIds)
                    {
                        var examCode_Question = new ExamCode_Question
                        {
                            ExamCodeId = examCodeAdded.ExamCodeId,
                            QuestionId = id
                        };
                        examCode_Questions.Add(examCode_Question);
                    }
                    context.ExamCode_Questions.InsertAllOnSubmit(examCode_Questions);
                    context.SubmitChanges();
                }

                view.AddExamCodeMessage = "Succeed";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.AddExamCodeMessage = "Failed";
            }
        }

        private void GetEditExamCodeQuestionIds(object sender, EventArgs e)
        {
            try
            {
                view.EditExamCodeQuestionIds = new List<int>();

                var examCodeId = (sender as ExamCodeListViewModel).ExamCodeId;
                using (var context = new QLThiTracNghiemDataContext())
                {
                    context.DeferredLoadingEnabled = false;
                    var examCodeQuestions = context.ExamCode_Questions.Where(ecq => ecq.ExamCodeId == examCodeId).ToList();
                    foreach (var item in examCodeQuestions)
                    {
                        view.EditExamCodeQuestionIds.Add(item.QuestionId);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        private void SaveEditExamCode(object sender, EventArgs e)
        {
            try
            {
                var examCodeEdited = sender as ExamCodeListViewModel;

                bool check = false;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var countUsed = context.ExamTakes.Where(et => et.ExamCodeId == examCodeEdited.ExamCodeId).Count();
                    if (countUsed <= 0)
                    {
                        var examCodeQuestions = context.ExamCode_Questions.Where(ecq => ecq.ExamCodeId == examCodeEdited.ExamCodeId).ToList();
                        var examCodeDb = context.ExamCodes.First(ec => ec.ExamCodeId == examCodeEdited.ExamCodeId);
                        examCodeDb.NumberOfQuestions = examCodeEdited.NumberOfQuestions;
                        examCodeDb.SubjectId = examCodeEdited.SubjectId;
                        examCodeDb.GradeId = examCodeEdited.GradeId;
                        examCodeDb.IsPracticeExam = examCodeEdited.IsPracticeExam;

                        context.ExamCode_Questions.DeleteAllOnSubmit(examCodeQuestions);
                        context.SubmitChanges();

                        List<ExamCode_Question> examCode_Questions = new List<ExamCode_Question>();
                        foreach (var id in view.EditExamCodeQuestionIds)
                        {
                            var examCode_Question = new ExamCode_Question
                            {
                                ExamCodeId = examCodeEdited.ExamCodeId,
                                QuestionId = id
                            };
                            examCode_Questions.Add(examCode_Question);
                        }
                        context.ExamCode_Questions.InsertAllOnSubmit(examCode_Questions);
                        context.SubmitChanges();

                        check = true;
                    }
                }

                if (check)
                {
                    view.SaveEditExamCodeMessage = "Succeed";
                }
                else
                {
                    view.SaveEditExamCodeMessage = "Used";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.SaveEditExamCodeMessage = "Failed";
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

        private void DeleteExamCode(object sender, EventArgs e)
        {
            try
            {
                var examCodeId = (string)sender;

                bool check = false;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var countUsed = context.ExamTakes.Where(et => et.ExamCodeId == examCodeId).Count();
                    if (countUsed <= 0)
                    {
                        var examCodeQuestions = context.ExamCode_Questions.Where(ecq => ecq.ExamCodeId == examCodeId).ToList();
                        var examCode = context.ExamCodes.First(ec => ec.ExamCodeId == examCodeId);

                        context.ExamCode_Questions.DeleteAllOnSubmit(examCodeQuestions);
                        context.ExamCodes.DeleteOnSubmit(examCode);
                        context.SubmitChanges();

                        check = true;
                    }
                }

                if (check)
                {
                    view.DeleteExamCodeMessage = "Succeed";
                }
                else
                {
                    view.DeleteExamCodeMessage = "Used";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.DeleteExamCodeMessage = "Failed";
            }
        }

        private void ReloadListExamCode(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                view.ExamCodes =
                    (from ec in context.ExamCodes
                     join s in context.Subjects on new { ec.SubjectId, ec.GradeId } equals new { s.SubjectId, s.GradeId }
                     join t in context.Teaches on new { s.SubjectId, s.GradeId } equals new { t.SubjectId, t.GradeId }
                     where t.TeacherId == view.CurrentUser.TeacherId
                     select new ExamCodeListViewModel
                     {
                         ExamCodeId = ec.ExamCodeId,
                         NumberOfQuestions = ec.NumberOfQuestions,
                         SubjectId = ec.SubjectId,
                         GradeId = ec.GradeId,
                         SubjectName = s.SubjectName,
                         IsPracticeExam = ec.IsPracticeExam
                     }).ToList();
            }
        }
    }
}
