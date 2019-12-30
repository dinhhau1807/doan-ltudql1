using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface IPracticeExamView
    {
        // Get user infomation
        Teacher CurrentUser { get; set; }
        User CurrentUserInfo { get; set; }

        // List Exam
        IList<PracticeExamListViewModel> PracticeExams { get; set; }

        // Delete Exam
        string DeletePracticeExamMessage { set; }

        // Edit Exam
        IList<Subject> Subjects { get; set; }
        string SaveEditPracticeExamMessage { set; }

        // Add Exam
        string AddPracticeExamMessage { set; }

        // Events
        event EventHandler ReloadListPracticeExam;
        event EventHandler DeletePracticeExam;
        event EventHandler SaveEditPracticeExam;
        event EventHandler AddPracticeExam;
    }
}
