using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface ITeacherExamView
    {
        // Get user infomation
        Teacher CurrentUser { get; set; }
        User CurrentUserInfo { get; set; }

        // List Exam
        IList<DoAnLTUDQL1.Exam> Exams { get; set; }
        IList<ExamListViewModel> ExamDetails { get; set; }

        // Delete Exam
        string DeleteExamMessage { set; }

        // Edit Exam
        IList<Subject> Subjects { get; set; }
        IList<ExamDetail> ExamDetailsEdited { get; set; }
        string SaveEditExamMessage { set; }

        // Add Exam
        IList<ExamDetail> ExamDetailsAdded { get; set; }
        string AddExamMessage { set; }

        string ExamDetailId { get; }
        string ExamDetailIdRP { set; }
        IList<ExamStatisticViewModel> DataSource { get; set; }

        // Events
        event EventHandler ReloadListExam;
        event EventHandler ReloadListExamDetail;
        event EventHandler DeleteExam;
        event EventHandler SaveEditExam;
        event EventHandler AddExam;
        event EventHandler ViewResult;
    }
}
