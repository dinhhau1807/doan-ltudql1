using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface ITeacherExamCodeView
    {
        // Get user infomation
        Teacher CurrentUser { get; set; }
        User CurrentUserInfo { get; set; }

        // Load list ExamCode
        IList<ExamCodeListViewModel> ExamCodes { get; set; }

        // Delete ExamCode
        string DeleteExamCodeMessage { set; }

        // Edit ExamCode
        IList<Subject> Subjects { get; set; }
        IList<int> EditExamCodeQuestionIds { get; set; }
        string SaveEditExamCodeMessage { set; }

        // Add ExamCode
        IList<int> AddExamCodeQuestionIds { get; set; }
        string AddExamCodeMessage { set; }

        // Events
        event EventHandler ReloadListExamCode;
        event EventHandler DeleteExamCode;
        event EventHandler SaveEditExamCode;
        event EventHandler GetEditExamCodeQuestionIds;
        event EventHandler AddExamCode;
    }
}
