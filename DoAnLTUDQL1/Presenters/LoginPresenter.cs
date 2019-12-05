using DoAnLTUDQL1.Views.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class LoginPresenter
    {
        ILoginView view;
        IList<User> users;

        public LoginPresenter(ILoginView loginView)
        {
            view = loginView;
            Initializer();
        }

        private void Initializer()
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                users = context.Users.ToList();
            }

            view.Login += Login;
        }

        private void Login(object sender, EventArgs e)
        {
            var user = users.FirstOrDefault(u => u.Username == view.Username);

            if (user != null && Common.VerifyPassword(view.Password, user.Password))
            {
                string role;

                using (var context = new QLThiTracNghiemDataContext())
                {
                    var userDb = context.Users.Single(u => u.Username == user.Username);
                    role = userDb.RoleType.RoleName;
                    userDb.LastLoginDate = DateTime.Now;
                    context.SubmitChanges();
                }

                // TODO: Authorization
                if (role == "Admin")
                {
                    view.Message = "Success:Admin";
                    return;
                }

                if (role == "Học sinh")
                {
                    view.Message = "Success:Student";
                    return;
                }

                if (role == "Giáo viên")
                {
                    view.Message = "Success:Teacher";
                    return;
                }
            }
            else if (user != null)
            {
                view.Message = "Password failed";
            }
            else
            {
                view.Message = "User not exists";
            }
        }
    }
}
