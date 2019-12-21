using DoAnLTUDQL1.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class EditAnswerPresenter
    {
        IEditAnswerView view;

        public EditAnswerPresenter(IEditAnswerView answerView)
        {
            view = answerView;
            Initializer();

            view.ReloadListAnswer += ReloadListAnswer;
            view.SaveEditAnswer += SaveEditAnswer;
            view.DeleteAnswer += DeleteAnswer;
            view.AddAnswer += AddAnswer;
        }

        private void Initializer()
        {
            ReloadListAnswer(view, null);
        }

        private void ReloadListAnswer(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                context.DeferredLoadingEnabled = false;
                view.Answers = context.Answers.Where(a => a.QuestionId == view.QuestionId).ToList();
            }
        }

        private void SaveEditAnswer(object sender, EventArgs e)
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    var answer = context.Answers.First(a => a.QuestionId == view.QuestionId && a.AnswerId == view.Answer.AnswerId);
                    answer.Content = view.Answer.Content;
                    answer.IsCorrect = view.Answer.IsCorrect;
                    context.SubmitChanges();
                }

                view.EditAnswerMessage = "Succeed";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.EditAnswerMessage = "Failed";
            }

        }

        private void DeleteAnswer(object sender, EventArgs e)
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    var answer = context.Answers.First(a => a.QuestionId == view.QuestionId && a.AnswerId == view.DeleteAnswerId);
                    context.Answers.DeleteOnSubmit(answer);
                    context.SubmitChanges();
                }
                view.DeleteAnswerMessage = "Succeed";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.DeleteAnswerMessage = "Failed";
            }
        }

        private void AddAnswer(object sender, EventArgs e)
        {
            try
            {
                using (var context = new QLThiTracNghiemDataContext())
                {
                    var id = context.Answers.Select(a => a.AnswerId).Max();
                    view.Answer.AnswerId = id + 1;

                    context.Answers.InsertOnSubmit(view.Answer);
                    context.SubmitChanges();
                }
                view.AddAnswerMessage = "Succeed";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.AddAnswerMessage = "Failed";
            }
        }
    }
}
