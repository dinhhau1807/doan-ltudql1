using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface ITeacherPracticeExamView
    {
        // Get user infomation
        Teacher CurrentUser { get; set; }
        User CurrentUserInfo { get; set; }

        // List Exam
        IList<DoAnLTUDQL1.Exam> PracticeExams { get; set; }
        IList<ExamListViewModel> ExamDetails { get; set; }

        // Delete Exam
        string DeletePracticeExamMessage { set; }

        // Edit Exam
        IList<Subject> Subjects { get; set; }
        IList<ExamDetail> ExamDetailsEdited { get; set; }
        string SaveEditPracticeExamMessage { set; }

        // Add Exam
        IList<ExamDetail> ExamDetailsAdded { get; set; }
        string AddPracticeExamMessage { set; }

        // Update mark
        string UpdateStudentMarkMessage { set; }

        // Events
        event EventHandler ReloadListPracticeExam;
        event EventHandler ReloadListExamDetail;
        event EventHandler DeletePracticeExam;
        event EventHandler SaveEditPracticeExam;
        event EventHandler AddPracticeExam;
        event EventHandler UpdateStudentMark;
    }
}
