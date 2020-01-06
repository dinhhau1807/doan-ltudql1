using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface ITeacherStudentView
    {
        // Get user infomation
        Teacher CurrentUser { get; set; }
        User CurrentUserInfo { get; set; }

        string StudentId { get; }
        string StudentIdRP { set; }
        IList<StudentStatisticViewModel> DataSource { get; set; }
        event EventHandler ViewResult;

        string ExamDetailId { get; }
        string ExamDetailIdRP { set; }
        IList<ExamStatisticViewModel> DataSourceE { get; set; }

        event EventHandler ViewResultE;

        int QuestionId { get; }
        int QuestionIdRP { set; }
        IList<QuestionStatisticViewModel> DataSourceQ { get; set; }

        event EventHandler ViewResultQ;
    }
        
}
