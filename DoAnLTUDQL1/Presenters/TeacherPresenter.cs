using DoAnLTUDQL1.ViewModels;
using DoAnLTUDQL1.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class TeacherPresenter
    {
        ITeacherView view;

        public TeacherPresenter(ITeacherView teacherView)
        {
            view = teacherView;
            Initializer();
        }

        private void Initializer()
        {
            // Get user info
            using (var context = new QLThiTracNghiemDataContext())
            {
                context.DeferredLoadingEnabled = true;
                view.CurrentUserInfo = context.Users.First(u => u.Username == view.CurrentUser.Username);
            }

            // Register events
            view.ChangePassword += ChangePassword;
            view.SaveInfo += SaveInfo;
        }

        private void SaveInfo(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                var user = context.Users.First(u => u.Username == view.CurrentUserInfo.Username);
                user.FirstName = view.CurrentUserInfo.FirstName;
                user.LastName = view.CurrentUserInfo.LastName;
                user.Phone = view.CurrentUserInfo.Phone;
                user.Dob = view.CurrentUserInfo.Dob;

                context.SubmitChanges();
            }
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            if (Common.VerifyPassword(view.OldPassword, view.CurrentUserInfo.Password))
            {
                if (view.NewPassword == view.ConfirmNewPassword)
                {
                    using (var context = new QLThiTracNghiemDataContext())
                    {
                        var user = context.Users.First(u => u.Username == view.CurrentUserInfo.Username);
                        user.Password = Common.HashPassword(view.NewPassword);

                        context.SubmitChanges();
                    }

                    view.ChangePasswordMessage = "Succeed";
                }
                else
                {
                    view.ChangePasswordMessage = "Password confirm not correct";
                }
            }
            else
            {
                view.ChangePasswordMessage = "Password not correct";
            }
        }
    }
}
