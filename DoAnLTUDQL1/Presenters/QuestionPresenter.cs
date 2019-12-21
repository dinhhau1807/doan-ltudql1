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
    public class QuestionPresenter
    {
        IQuestionView view;

        public QuestionPresenter(IQuestionView questionView)
        {
            view = questionView;
            Initializer();
        }

        private void Initializer()
        {
            // Get question list
            ReloadListQuestion(view, null);

            // Get list subjects
            GetListSubject();

            // Register events
            // --- List question
            view.ReloadListQuestion += ReloadListQuestion;
            // --- Edit question
            view.SaveEditQuestion += SaveEditQuestion;
            // --- Detail question
            view.LoadDetailQuestionExamCode += LoadDetailQuestionExamCode;
            // --- Approve question
            view.LoadApproveQuestion += LoadApproveQuestion;
            view.ApproveQuestion += ApproveQuestion;
            // --- Add question
            view.AddQuestion += AddQuestion;
            // --- Import/Export question
            // DOIT LATER
        }

        private void AddQuestion(object sender, EventArgs e)
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    context.Questions.InsertOnSubmit(view.Question);
                    context.SubmitChanges();
                }

                view.AddQuestionMessage = "Succeed";
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                view.AddQuestionMessage = "Failed";
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

        private void LoadApproveQuestion(object sender, EventArgs e)
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    context.DeferredLoadingEnabled = false;
                    view.ListQuestionDistributed = (from qd in context.QuestionDistributes
                                                    join s in context.Subjects on new { qd.SubjectId, qd.GradeId } equals new { s.SubjectId, s.GradeId }
                                                    join t in context.Teaches on new { s.SubjectId, s.GradeId } equals new { t.SubjectId, t.GradeId }
                                                    where t.TeacherId == view.CurrentUser.TeacherId && qd.IsApproved == false
                                                    select qd).ToList();
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

        private void ApproveQuestion(object sender, EventArgs e)
        {
            try
            {
                Question question;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var questionDistributed = context.QuestionDistributes.First(q => q.QuestionDistributeId == view.ApproveQuestionId);
                    questionDistributed.IsApproved = true;

                    question = new Question
                    {
                        Content = questionDistributed.Content,
                        Hint = questionDistributed.Hint,
                        SubjectId = questionDistributed.SubjectId,
                        GradeId = questionDistributed.GradeId,
                        DifficultLevel = questionDistributed.DifficultLevel,
                        IsDistributed = true
                    };

                    context.Questions.InsertOnSubmit(question);
                    context.SubmitChanges();
                }

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var answerDistributed = context.AnswerDistributes.Where(a => a.QuestionDistributeId == view.ApproveQuestionId).ToList();

                    List<Answer> answers = new List<Answer>();
                    foreach (var a in answerDistributed)
                    {
                        var answer = new Answer
                        {
                            AnswerId = a.AnswerDistributeId,
                            QuestionId = question.QuestionId,
                            Content = a.Content,
                            IsCorrect = a.IsCorrect
                        };
                        answers.Add(answer);
                    }

                    context.Answers.InsertAllOnSubmit(answers);
                    context.SubmitChanges();
                }

                view.ApproveQuestionMessage = "Succeed";
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                view.ApproveQuestionMessage = "Failed";
            }
        }

        private void LoadDetailQuestionExamCode(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                view.ListDetailQuestionExamCode = (from ec in context.ExamCodes
                                                   join exq in context.ExamCode_Questions on ec.ExamCodeId equals exq.ExamCodeId
                                                   join q in context.Questions on exq.QuestionId equals q.QuestionId
                                                   join s in context.Subjects on new { ec.SubjectId, ec.GradeId } equals new { s.SubjectId, s.GradeId }
                                                   where q.QuestionId == view.EditQuestionId
                                                   select new DetailQuestionExamCodeViewModel
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

        private void SaveEditQuestion(object sender, EventArgs e)
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    var question = view.ListQuestion.First(q => q.QuestionId == view.EditQuestionId);
                    var questionDb = context.Questions.First(q => q.QuestionId == view.EditQuestionId);
                    questionDb.Content = question.Content;
                    questionDb.DifficultLevel = question.DifficultLevel;

                    context.SubmitChanges();
                    view.EditQuestionMessage = "Succeed";
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                view.EditQuestionMessage = "Failed";
            }

        }

        private void ReloadListQuestion(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                view.ListQuestion = (from q in context.Questions
                                     join s in context.Subjects on new { q.SubjectId, q.GradeId } equals new { s.SubjectId, s.GradeId }
                                     join t in context.Teaches on new { s.SubjectId, s.GradeId } equals new { t.SubjectId, t.GradeId }
                                     where t.TeacherId == view.CurrentUser.TeacherId
                                     select new QuestionListViewModel
                                     {
                                         QuestionId = q.QuestionId,
                                         Content = q.Content,
                                         SubjectId = q.SubjectId,
                                         GradeId = q.GradeId,
                                         SubjectName = s.SubjectName,
                                         DifficultLevel = q.DifficultLevel,
                                         IsDistributed = q.IsDistributed
                                     }).ToList();
            }
        }
    }
}
