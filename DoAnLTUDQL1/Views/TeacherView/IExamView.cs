using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface IExamView
    {
        // Get user infomation
        Teacher CurrentUser { get; set; }
        User CurrentUserInfo { get; set; }

        // List Exam
        IList<ExamListViewModel> Exams { get; set; }

        // Delete Exam
        string DeleteExamMessage { set; }

        // Edit Exam
        IList<Subject> Subjects { get; set; }
        string SaveEditExamMessage { set; }

        // Add Exam
        string AddExamMessage { set; }

        // Events
        event EventHandler ReloadListExam;
        event EventHandler DeleteExam;
        event EventHandler SaveEditExam;
        event EventHandler AddExam;
    }
}
