using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface IQuestionView
    {
        // Get user infomation
        Teacher CurrentUser { get; set; }
        User CurrentUserInfo { get; set; }

        // Tab question
        // --- List question
        IList<QuestionListViewModel> ListQuestion { get; set; }
        // --- Edit question
        int EditQuestionId { get; set; }
        string EditQuestionMessage { set; }
        // --- Detail question
        IList<DetailQuestionExamCodeViewModel> ListDetailQuestionExamCode { get; set; }
        int DetailQuestionId { get; set; }
        // --- Approve question
        IList<QuestionDistribute> ListQuestionDistributed { get; set; }
        int ApproveQuestionId { get; set; }
        string ApproveQuestionMessage { set; }
        // --- Add question 
        IList<Subject> Subjects { get; set; }
        Question Question { get; set; }
        string AddQuestionMessage { set; }
        // --- Import/Export question
        // DOIT LATER

        // Events
        // Tab question
        // --- List question
        event EventHandler ReloadListQuestion;
        // --- Edit question
        event EventHandler SaveEditQuestion;
        // --- Detail question
        event EventHandler LoadDetailQuestionExamCode;
        // --- Approve question
        event EventHandler LoadApproveQuestion;
        event EventHandler ApproveQuestion;
        // --- Add question
        event EventHandler AddQuestion;
        // --- Import/Export question
        // DOIT LATER
    }
}
