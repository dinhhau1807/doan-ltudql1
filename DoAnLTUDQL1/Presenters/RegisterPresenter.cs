using DoAnLTUDQL1.Views.Register;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class RegisterPresenter
    {
        IRegisterView view;
        IEnumerable<RoleType> roleTypes;

        public RegisterPresenter(IRegisterView registerView)
        {
            view = registerView;
            Initializer();
        }

        private void Initializer()
        {
            view.Register += Register;

            using (var context = new QLThiTracNghiemDataContext())
            {
                roleTypes = context.RoleTypes.Where(r => r.RoleName != "Admin").ToList();
            }
            view.RoleTypes = roleTypes;
        }

        private void Register(object sender, EventArgs e)
        {
            using (var context = new QLThiTracNghiemDataContext())
            {
                // Check if user is existed
                var user = context.Users.FirstOrDefault(u => u.Username == view.Username);
                if (user != null)
                {
                    view.Message = "User existed";
                    return;
                }

                var newUser = new User
                {
                    Username = view.Username,
                    Password = Common.HashPassword(view.Password),
                    FirstName = view.FirstName,
                    LastName = view.LastName,
                    Dob = view.Dob,
                    Phone = view.Phone,
                    CreatedDate = DateTime.Now,
                    Status = true,
                    RoleTypeId = view.RoleTypeId
                };

                context.Users.InsertOnSubmit(newUser);
                context.SubmitChanges(ConflictMode.FailOnFirstConflict);
            }

            view.Message = "Success";
        }
    }
}
