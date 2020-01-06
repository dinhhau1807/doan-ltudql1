using DoAnLTUDQL1.Presenters;
using DoAnLTUDQL1.ViewModels;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
        BindingSource studentStatisticBS, examStatisticBS, questionStatisticBS;
        ReportDataSource studentStatisticRPDS, examStatisticRPDS, questionStatisticRPDS;
        const string rpdsName = "StudentStatistic";
        const string rpdsNameE = "ExamStatistic";
        const string rpdsNameQ = "QuestionStatistic";

        public event EventHandler ViewResult;
        public event EventHandler ViewResultE;
        public event EventHandler ViewResultQ;

        public frmTeacherStudent(Teacher teacher, User user)
        {
            CurrentUser = teacher;
            CurrentUserInfo = user;
            InitializeComponent();
            Load += FrmTeacherStudent_Load;

            mbtnStudentResult.Click += mbtnStudentResult_Click;
            mbtnExamResult.Click += mbtnExamResult_Click;
            mbtnQuestionResult.Click += mbtnQuestionResult_Click;
        }

        private void mbtnQuestionResult_Click(object sender, EventArgs e)
        {
            ViewResultQ?.Invoke(sender, e);
        }

        private void mbtnExamResult_Click(object sender, EventArgs e)
        {
            ViewResultE?.Invoke(sender, e);
        }

        private void mbtnStudentResult_Click(object sender, EventArgs e)
        {
            ViewResult?.Invoke(sender, e);
        }



        #region Events
        private void FrmTeacherStudent_Load(object sender, EventArgs e)
        {
            presenter = new TeacherStudentPresenter(this);

            // TODO: report student

            // Events 
            // -- Register events here
            LoadDataToComboBox();

            rpvStudent.LocalReport.DataSources.Clear();
            studentStatisticBS = new BindingSource();
            studentStatisticRPDS = new ReportDataSource(rpdsName);
            studentStatisticRPDS.Value = studentStatisticBS;
            rpvStudent.LocalReport.DataSources.Add(studentStatisticRPDS);
            this.rpvStudent.RefreshReport();
            

            rpvExam.LocalReport.DataSources.Clear();
            examStatisticBS = new BindingSource();
            examStatisticRPDS = new ReportDataSource(rpdsNameE);
            examStatisticRPDS.Value = examStatisticBS;
            rpvExam.LocalReport.DataSources.Add(examStatisticRPDS);
            this.rpvExam.RefreshReport();

            rpvQuestion.LocalReport.DataSources.Clear();
            questionStatisticBS = new BindingSource();
            questionStatisticRPDS = new ReportDataSource(rpdsNameQ);
            questionStatisticRPDS.Value = questionStatisticBS;
            rpvQuestion.LocalReport.DataSources.Add(questionStatisticRPDS);
            this.rpvQuestion.RefreshReport();
        }

        void LoadDataToComboBox()
        {
            using (var qlttn = new QLThiTracNghiemDataContext())
            {
                var listTeach = qlttn.Teaches.ToList<Teach>();
                var listStudent = qlttn.Students.ToList<Student>();
                var listExamResult = qlttn.ExamResults.ToList<ExamResult>();
                var listExamDetail = qlttn.ExamDetails.ToList<ExamDetail>();
                var listQuestion = qlttn.Questions.ToList<Question>();
                var listSubject = qlttn.Subjects.ToList<Subject>();



                var getStudentId = from ls in listStudent
                                   join lt in listTeach on ls.ClassroomId equals lt.ClassroomId
                                   where lt.TeacherId == CurrentUser.TeacherId
                                   select new { IdS = ls.StudentId };
                var getExamId = from ler in listExamResult
                                join led in listExamDetail on ler.ExamDetailId equals led.ExamDetailId
                                join ex in qlttn.Exams on led.ExamId equals ex.ExamId
                                join ls in listStudent on ler.StudentId equals ls.StudentId
                                join lt in listTeach on ls.ClassroomId equals lt.ClassroomId
                                where lt.TeacherId == CurrentUser.TeacherId
                                select new { IdE = ler.ExamDetailId, NameE = ex.ExamName };
                var getQuestionId = from lq in listQuestion
                                    join lss in listSubject on lq.SubjectId equals lss.SubjectId
                                    join lt in listTeach on lss.SubjectId equals lt.SubjectId
                                    where lt.TeacherId == CurrentUser.TeacherId
                                    select new { IdQ = lq.QuestionId };

                mcbStudentId.DataSource = getStudentId.ToList();
                mcbStudentId.DisplayMember = "IdS";
                mcbStudentId.ValueMember = "IdS";

                mcbExamId.DataSource = getExamId.ToList();
                mcbExamId.DisplayMember = "IdE";
                mcbExamId.ValueMember = "IdE";

                mcbQuestionId.DataSource = getQuestionId.ToList();
                mcbQuestionId.DisplayMember = "IdQ";
                mcbQuestionId.ValueMember = "IdQ";


            }
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
        public IList<StudentStatisticViewModel> DataSource
        {
            get => studentStatisticBS.DataSource as IList<StudentStatisticViewModel>;
            set
            {
                studentStatisticBS.DataSource = value;
                rpvStudent.RefreshReport();
            }
        }

        public string StudentId
        {
            get => mcbStudentId.Text;
        }
        public string StudentIdRP
        {
            set
            {
                mcbStudentId.Text = value.ToString();
                var rpParam = new ReportParameter("StudentId", value.ToString());
                rpvStudent.LocalReport.SetParameters(rpParam);
            }
        }

        public string ExamDetailId
        {
            get => mcbExamId.Text;
        }

        public string ExamDetailIdRP
        {
            set
            {
                mcbExamId.Text = value.ToString();
                var rpParam = new ReportParameter("ExamDetailId", value.ToString());
                rpvExam.LocalReport.SetParameters(rpParam);
            }
        }
        public IList<ExamStatisticViewModel> DataSourceE
        {
            get => examStatisticBS.DataSource as IList<ExamStatisticViewModel>;
            set
            {
                examStatisticBS.DataSource = value;
                rpvExam.RefreshReport();
            }
        }


        public IList<QuestionStatisticViewModel> DataSourceQ
        {
            get => questionStatisticBS.DataSource as IList<QuestionStatisticViewModel>;
            set
            {
                questionStatisticBS.DataSource = value;
                rpvQuestion.RefreshReport();
            }
        }

        int ITeacherStudentView.QuestionId
        { 
            get => Convert.ToInt32(mcbQuestionId.SelectedValue);
        }

        int ITeacherStudentView.QuestionIdRP
        {
            set
            {
                mcbQuestionId.Text = value.ToString();
                var rpParam = new ReportParameter("QuestionId", value.ToString());
                rpvQuestion.LocalReport.SetParameters(rpParam);
            }
        }


        //
        #endregion

        #region Utilities
        // For utilities
        #endregion

    }
}
