using DoAnLTUDQL1.Presenters;
using DoAnLTUDQL1.ViewModels;
using Microsoft.Reporting.WinForms;
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

        BindingSource examRSBS;
        ReportDataSource examRPDS;
        const string rpdsName = "ExamRS";

        public frmTeacherExamReport(Teacher teacher, User user)
        {
            CurrentUser = teacher;
            CurrentUserInfo = user;
            InitializeComponent();
            Load += FrmTeacherExamReport_Load;
            mbtnExamRS.Click += mbtnExamRS_Click;
        }

        private void mbtnExamRS_Click(object sender, EventArgs e)
        {
            ViewResult?.Invoke(sender, e);
        }

        #region Events
        private void FrmTeacherExamReport_Load(object sender, EventArgs e)
        {
            presenter = new TeacherExamReportPresenter(this);

            LoadData2ComboBox();
            rpvExamRS.LocalReport.DataSources.Clear();
            examRSBS = new BindingSource();
            examRPDS = new ReportDataSource(rpdsName);
            examRPDS.Value = examRSBS;

            rpvExamRS.LocalReport.DataSources.Add(examRPDS);
            this.rpvExamRS.RefreshReport();
        }
        void LoadData2ComboBox()
        {
            using (var qlttn = new QLThiTracNghiemDataContext())
            {
                var listTeach = qlttn.Teaches.ToList<Teach>();
                var listStudent = qlttn.Students.ToList<Student>();
                var listExamResult = qlttn.ExamResults.ToList<ExamResult>();
                var listExamDetail = qlttn.ExamDetails.ToList<ExamDetail>();

                var getExamId = from ler in listExamResult
                                join led in listExamDetail on ler.ExamDetailId equals led.ExamDetailId
                                join ex in qlttn.Exams on led.ExamId equals ex.ExamId
                                join ls in listStudent on ler.StudentId equals ls.StudentId
                                join lt in listTeach on ls.ClassroomId equals lt.ClassroomId
                                where lt.TeacherId == CurrentUser.TeacherId
                                select new { IdE = ler.ExamDetailId, NameE = ex.ExamName };

                mcbExamRV.DataSource = getExamId.ToList();
                mcbExamRV.DisplayMember = "IdE";
                mcbExamRV.ValueMember = "IdE";
            }
        }
        #endregion


        #region ITeacherExamReportView implementations
        // Get user information
        public Teacher CurrentUser { get; set; }
        public User CurrentUserInfo { get; set; }

        //Event
        public event EventHandler ViewResult;

        public string ExamDetailId
        {
            get => mcbExamRV.Text;
        }

        public string ExamDetailIdRP
        {
            set
            {
                mcbExamRV.Text = value.ToString();
                var rpParam = new ReportParameter("ExamDetailId", value.ToString());
                rpvExamRS.LocalReport.SetParameters(rpParam);
            }
        }
        public IList<ExamStatisticViewModel> DataSource
        {
            get => examRSBS.DataSource as IList<ExamStatisticViewModel>;
            set
            {
                examRSBS.DataSource = value;
                rpvExamRS.RefreshReport();
            }
        }
        #endregion
    }
}
