using DoAnLTUDQL1.Views.Register;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace DoAnLTUDQL1.Presenters
{
    public class RegisterPresenter
    {
        private IRegisterView view;

        public RegisterPresenter(IRegisterView registerView)
        {
            view = registerView;
            Initializer();
        }

        private void Initializer()
        {
            view.Register += Register;

            IEnumerable<RoleType> roleTypes;
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

                // Add user to student table
                if (view.RoleTypeId == 1)
                {
                    long studentId;
                    if (context.Students.Count() == 0)
                    {
                        studentId = 0;
                    }
                    else
                    {
                        var studentIds = context.Students.Select(s => s.StudentId).ToList();
                        studentId = studentIds.Select(id => long.Parse(id.Substring(2))).Max();
                    }
                    studentId++;

                    var student = new Student
                    {
                        StudentId = $"HS{studentId:D7}",
                        Username = view.Username,
                        ClassroomId = null
                    };

                    context.Students.InsertOnSubmit(student);
                }

                // Add user to teacher table
                if (view.RoleTypeId == 2)
                {
                    long teacherId;
                    if (context.Teachers.Count() == 0)
                    {
                        teacherId = 0;
                    }
                    else
                    {
                        var teacherIds = context.Teachers.Select(s => s.TeacherId).ToList();
                        teacherId = teacherIds.Select(id => long.Parse(id.Substring(2))).Max();
                    }
                    teacherId++;

                    var teacher = new Teacher
                    {
                        TeacherId = $"GV{teacherId:D7}",
                        Username = view.Username,
                    };

                    context.Teachers.InsertOnSubmit(teacher);
                }

                context.Users.InsertOnSubmit(newUser);
                context.SubmitChanges(ConflictMode.FailOnFirstConflict);
            }

            view.Message = "Success";
        }
    }
}