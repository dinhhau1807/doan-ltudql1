using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface ITeacherEditExamCodeQuestionsView
    {
        string TeacherId { get; set; }
        ExamCodeListViewModel ExamCode { get; set; }
        IList<int> ExamCodeQuestionIds { get; set; }

        IList<Question> Questions { get; set; }
        IList<Question> QuestionsAdded { get; set; }
        string AddQuestionMessage { set; }
        string DeleteQuestionMessage { set; }


        event EventHandler ReloadListExamCodeQuestionIds;
        event EventHandler AddQuestion;
        event EventHandler DeleteQuestion;
    }
}
