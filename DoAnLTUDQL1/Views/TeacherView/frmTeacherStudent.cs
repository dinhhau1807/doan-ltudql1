using DoAnLTUDQL1.Presenters;
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
    public partial class frmTeacherStudent : MetroFramework.Forms.MetroForm, ITeacherStudentView
    {
        TeacherStudentPresenter presenter;

        public frmTeacherStudent(Teacher teacher, User user)
        {
            CurrentUser = teacher;
            CurrentUserInfo = user;
            InitializeComponent();
            Load += FrmTeacherStudent_Load;
        }



        #region Events
        private void FrmTeacherStudent_Load(object sender, EventArgs e)
        {
            presenter = new TeacherStudentPresenter(this);

            // TODO: report student

            // Events 
            // -- Register events here
        }

        // For events 
        #endregion


        // TODO: implement report ITeacherStudentView 
        #region ITeacherStudentView implementations
        // Events
        //

        // User information
        public Teacher CurrentUser { get; set; }
        public User CurrentUserInfo { get; set; }

        //
        #endregion



        #region Utilities
        // For utilities
        #endregion
    }
}
