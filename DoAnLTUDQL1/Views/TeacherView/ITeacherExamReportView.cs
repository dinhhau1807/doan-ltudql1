using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface ITeacherExamReportView
    {
        // Get user infomation
        Teacher CurrentUser { get; set; }
        User CurrentUserInfo { get; set; }

        string ExamDetailId { get; }
        string ExamDetailIdRP { set; }
        IList<ExamStatisticViewModel> DataSource { get; set; }

        event EventHandler ViewResult;
    }
}
