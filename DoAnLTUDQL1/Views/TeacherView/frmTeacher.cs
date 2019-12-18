using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public partial class frmTeacher : MetroFramework.Forms.MetroForm, ITeacherView
    {
        public frmTeacher(Teacher teacher)
        {
            InitializeComponent();
            CurrentUser = teacher;
        }

        #region ITeacherView implementations
        public Teacher CurrentUser { get; set; }
        #endregion
    }
}
