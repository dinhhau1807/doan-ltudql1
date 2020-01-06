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
    public partial class frmTeacherExamReport : MetroFramework.Forms.MetroForm, ITeacherExamReportView
    {
        TeacherExamReportPresenter presenter;

        public frmTeacherExamReport(Teacher teacher, User user)
        {
            CurrentUser = teacher;
            CurrentUserInfo = user;
            InitializeComponent();
            Load += FrmTeacherExamReport_Load;
        }
      

        #region Events
        private void FrmTeacherExamReport_Load(object sender, EventArgs e)
        {
            presenter = new TeacherExamReportPresenter(this);


        }
        #endregion


        #region ITeacherExamReportView implementations
        // Get user information
        public Teacher CurrentUser { get; set; }
        public User CurrentUserInfo { get; set; }


        #endregion
    }
}
