using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public interface ITeacherView
    {
        // Get user infomation
        Teacher CurrentUser { get; set; }
        User CurrentUserInfo { get; set; }

        // Change password
        string OldPassword { get; set; }
        string NewPassword { get; set; }
        string ConfirmNewPassword { get; set; }
        string ChangePasswordMessage { set; }

        // Events
        event EventHandler ChangePassword;
        event EventHandler SaveInfo;
    }
}
