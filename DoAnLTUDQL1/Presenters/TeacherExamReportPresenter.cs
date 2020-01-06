using DoAnLTUDQL1.Views.TeacherView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class TeacherExamReportPresenter
    {
        ITeacherExamReportView view;

        public TeacherExamReportPresenter(ITeacherExamReportView teacherExamReportView)
        {
            view = teacherExamReportView;
            Initializer();
        }

        private void Initializer()
        {

        }
    }
}
