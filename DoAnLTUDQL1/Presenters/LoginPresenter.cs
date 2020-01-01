using DoAnLTUDQL1.Views.Login;
using System;
using System.Linq;

namespace DoAnLTUDQL1.Presenters
{
    public class LoginPresenter
    {
        private ILoginView view;

        public LoginPresenter(ILoginView loginView)
        {
            view = loginView;
            Initializer();
        }

        private void Initializer()
        {
            view.CheckConnection += CheckConnection;
            view.Login += Login;
        }

        private void CheckConnection(object sender, EventArgs e)
        {
            var connectionString = SqlHelper.GetConnectionString;
            var sqlHelper = new SqlHelper(connectionString);
            if (sqlHelper.IsConnection)
            {
                view.CheckConnectionMessage = "Succeed";
            }
            else
            {
                view.CheckConnectionMessage = "Failed";
            }
        }

        private void Login(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                // temp to test
                //var tempUser = context.Teachers.FirstOrDefault(u => u.Username == "hxvinh");
                //view.User = tempUser;
                //view.Message = "Success:Teacher";
                //return;
                //

                var user = context.Users.FirstOrDefault(u => u.Username == view.Username);

                if (user != null && Common.VerifyPassword(view.Password, user.Password))
                {
                    string role;

                    role = user.RoleType.RoleName.ToLower();
                    user.LastLoginDate = DateTime.Now;
                    context.SubmitChanges();

                    // TODO: Authorization
                    if (role == "admin")
                    {
                        view.User = user;
                        view.Message = "Success:Admin";
                        return;
                    }

                    if (role == "học sinh")
                    {
                        view.User = user;
                        view.Message = "Success:Student";
                        return;
                    }

                    if (role == "giáo viên")
                    {
                        var teacher = context.Teachers.FirstOrDefault(t => t.Username == user.Username);
                        view.User = teacher;
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
}