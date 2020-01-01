using DoAnLTUDQL1.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class TeacherStudentPresenter
    {
        ITeacherStudentView view;

        public TeacherStudentPresenter(ITeacherStudentView teacherStudetView)
        {
            view = teacherStudetView;
            Initializer();
        }

        private void Initializer()
        {
            // TODO: First load

            // Events
            // -- Register events here
        }
    }
}
