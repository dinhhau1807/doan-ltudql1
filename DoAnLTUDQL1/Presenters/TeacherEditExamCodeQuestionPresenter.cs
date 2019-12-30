using DoAnLTUDQL1.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class TeacherEditExamCodeQuestionPresenter
    {
        ITeacherEditExamCodeQuestionsView view;

        public TeacherEditExamCodeQuestionPresenter(ITeacherEditExamCodeQuestionsView editExamCodeQuestiosView)
        {
            view = editExamCodeQuestiosView;
            Inititalizer();
        }

        private void Inititalizer()
        {
            try
            {
                view.QuestionsAdded = new List<Question>();

                using (var context = new QLThiTracNghiemDataContext())
                {
                    context.DeferredLoadingEnabled = false;

                    // Load list questions added
                    foreach (var id in view.ExamCodeQuestionIds)
                    {
                        var question = context.Questions.First(q => q.QuestionId == id);
                        view.QuestionsAdded.Add(question);
                    }

                    bool isPractice = view.ExamCode.IsPracticeExam.GetValueOrDefault(false);
                    // Load list questions
                    view.Questions = (from q in context.Questions
                                      join s in context.Subjects on new { q.SubjectId, q.GradeId } equals new { s.SubjectId, s.GradeId }
                                      join t in context.Teaches on new { s.SubjectId, s.GradeId } equals new { t.SubjectId, t.GradeId }
                                      let isDistributed = q.IsDistributed.GetValueOrDefault(false)
                                      where t.TeacherId == view.TeacherId
                                      && (isPractice == false ? isDistributed == false : isDistributed == false || isDistributed == true)
                                      && s.SubjectId == view.ExamCode.SubjectId && s.GradeId == view.ExamCode.GradeId
                                      select q).ToList();

                    foreach (var qa in view.QuestionsAdded)
                    {
                        view.Questions.Remove(qa);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Events
            view.ReloadListExamCodeQuestionIds += ReloadListExamCodeQuestionIds;
            view.AddQuestion += AddQuestion;
            view.DeleteQuestion += DeleteQuestion;
        }

        private void DeleteQuestion(object sender, EventArgs e)
        {
            if (view.QuestionsAdded.Count > 0)
            {
                var question = sender as Question;
                view.QuestionsAdded.Remove(question);
                view.Questions.Add(question);

                view.DeleteQuestionMessage = "Succeed";
            }
            else
            {
                view.DeleteQuestionMessage = "Failed";
            }
        }

        private void AddQuestion(object sender, EventArgs e)
        {
            if (view.QuestionsAdded.Count == view.ExamCode.NumberOfQuestions)
            {
                view.AddQuestionMessage = "Maximized";
                return;
            }

            if (view.Questions.Count > 0)
            {
                var question = sender as Question;
                view.QuestionsAdded.Add(question);
                view.Questions.Remove(question);

                view.AddQuestionMessage = "Succeed";
            }
            else
            {
                view.AddQuestionMessage = "Failed";
            }
        }

        private void ReloadListExamCodeQuestionIds(object sender, EventArgs e)
        {
            view.ExamCodeQuestionIds.Clear();
            foreach (var qa in view.QuestionsAdded)
            {
                view.ExamCodeQuestionIds.Add(qa.QuestionId);
            }
        }
    }
}
