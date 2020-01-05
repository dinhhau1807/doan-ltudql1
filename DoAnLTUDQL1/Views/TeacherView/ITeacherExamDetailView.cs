using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface ITeacherExamDetailView
    {
        // Get Exam information
        DoAnLTUDQL1.Exam Exam { get; set; }

        // Load list ExamDetail
        IList<ExamDetail> ExamDetails { get; set; }
        IList<Subject> Subjects { get; set; }

        // Add
        string AddExamDetailMessage { set; }

        // Edit 
        ExamDetail ExamDetailEdited { get; set; }
        string EditExamDetailMessage { set; }

        // Delete
        string DeleteExamDetailMessage { set; }

        // Events
        event EventHandler DeleteExamDetail;
        event EventHandler EditExamDetail;
        event EventHandler AddExamDetail;
    }
}
