using DoAnLTUDQL1.Presenters;
using DoAnLTUDQL1.ViewModels;
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
    public partial class frmTeacherPracticeExam : MetroFramework.Forms.MetroForm, ITeacherPracticeExamView
    {
        TeacherPracticeExamPresenter presenter;
        BindingSource bsListPracticeExam;

        public frmTeacherPracticeExam(Teacher teacher, User user)
        {
            CurrentUser = teacher;
            CurrentUserInfo = user;
            InitializeComponent();
            Load += FrmExam_Load;
        }

        #region Events
        private void FrmExam_Load(object sender, EventArgs e)
        {
            presenter = new TeacherPracticeExamPresenter(this);

            // Set grid view
            bsListPracticeExam = new BindingSource();
            bsListPracticeExam.DataSource = PracticeExams;
            mGridListPracticeExam.DataSource = bsListPracticeExam;

            // Set data bindings
            SetDataBinding();

            // Load combobox Subject edit ExamCode
            mCbbEditPracticeExamSubject.DisplayMember = "SubjectName";
            mCbbEditPracticeExamSubject.ValueMember = "SubjectId";
            mCbbEditPracticeExamSubject.DataSource = Subjects;

            // Load combobox Subject add ExamCode 
            mCbbAddPracticeExamSubject.DisplayMember = "SubjectName";
            mCbbAddPracticeExamSubject.ValueMember = "SubjectId";
            mCbbAddPracticeExamSubject.DataSource = Subjects;

            // Register events
            // Load
            mBtnReloadListPracticeExam.Click += MBtnReloadListPracticeExam_Click;
            mTabPracticeExam.SelectedIndexChanged += MTabPracticeExam_SelectedIndexChanged;
            // Delete
            mBtnDeletePracticeExam.Click += MBtnDeletePracticeExam_Click;
            // Edit
            mCbbEditPracticeExamSubject.SelectedIndexChanged += MCbbEditPracticeExamSubject_SelectedIndexChanged;
            mTxtEditPracticeDuration.KeyPress += MTxtEditPracticeDuration_KeyPress;
            mBtnSaveEditPracticeExam.Click += MBtnSaveEditPracticeExam_Click;
            // Add
            mCbbAddPracticeExamSubject.SelectedIndexChanged += MCbbAddPracticeExamSubject_SelectedIndexChanged;
            mTxtAddPracticeDuration.KeyPress += MTxtAddPracticeDuration_KeyPress;
            mBtnAddPracticeExam.Click += MBtnAddPracticeExam_Click;

            // Startup
            mTabPracticeExam.SelectTab(0);
            if (bsListPracticeExam.Count > 0)
            {
                mGridListPracticeExam.Rows[0].Selected = true;
            }
            if (mCbbAddPracticeExamSubject.Items.Count > 0)
            {
                var subject = mCbbAddPracticeExamSubject.SelectedItem as Subject;
                mTxtAddPracticeExamSubjectId.Text = subject.SubjectId.ToString();
                mTxtAddPracticeExamGradeId.Text = subject.GradeId.ToString();
            }
        }


        // Add exam
        private void MCbbAddPracticeExamSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCbbAddPracticeExamSubject.SelectedItem != null)
            {
                var subject = mCbbAddPracticeExamSubject.SelectedItem as Subject;
                mTxtAddPracticeExamSubjectId.Text = subject.SubjectId.ToString();
                mTxtAddPracticeExamGradeId.Text = subject.GradeId.ToString();
            }
        }

        private void MTxtAddPracticeDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MBtnAddPracticeExam_Click(object sender, EventArgs e)
        {
            if (mCbbAddPracticeExamSubject.SelectedItem != null)
            {
                var timeStart = dateTimeAddPracticeTimeStart.Value.TimeOfDay;
                var startTime = DateTime.Parse(mDateTimeAddPracticeDateStart.Value.ToShortDateString()).Add(timeStart);

                var practiceExamAdded = new PracticeExamListViewModel
                {
                    ExamName = mTxtAddPracticeExamName.Text,
                    StartTime = startTime,
                    Duration = int.Parse(mTxtAddPracticeDuration.Text),
                    SubjectId = mTxtAddPracticeExamSubjectId.Text,
                    GradeId = int.Parse(mTxtAddPracticeExamGradeId.Text)
                };

                AddPracticeExam?.Invoke(practiceExamAdded, null);
            }
            else
            {
                MessageBox.Show("Chưa đủ dữ liệu!");
            }
        }


        // Edit exam
        private void MTxtEditPracticeDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MCbbEditPracticeExamSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCbbEditPracticeExamSubject.SelectedItem != null)
            {
                var subject = mCbbEditPracticeExamSubject.SelectedItem as Subject;
                mTxtEditPracticeExamSubjectId.Text = subject.SubjectId.ToString();
                mTxtEditPracticeExamGradeId.Text = subject.GradeId.ToString();
            }
        }

        private void MBtnSaveEditPracticeExam_Click(object sender, EventArgs e)
        {
            if (bsListPracticeExam.Count > 0)
            {
                var practiceExam = (PracticeExamListViewModel)mGridListPracticeExam.SelectedRows[0].DataBoundItem;
                SaveEditPracticeExam?.Invoke(practiceExam, null);
            }
        }

        // Delete exam
        private void MBtnDeletePracticeExam_Click(object sender, EventArgs e)
        {
            if (bsListPracticeExam.Count > 0)
            {
                var practiceExamId = (string)mGridListPracticeExam.SelectedRows[0].Cells[0].Value;
                DeletePracticeExam?.Invoke(practiceExamId, null);
            }
        }

        // Load list exam
        private void MBtnReloadListPracticeExam_Click(object sender, EventArgs e)
        {
            ReloadListPracticeExam?.Invoke(this, null);
            bsListPracticeExam.DataSource = PracticeExams;
        }

        private void MTabPracticeExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mTabPracticeExam.SelectedTab == mTabListPracticeExam)
            {
                mBtnReloadListPracticeExam.PerformClick();
            }
        }
        #endregion



        #region IPracticeExamView implementations
        // Events
        public event EventHandler ReloadListPracticeExam;
        public event EventHandler DeletePracticeExam;
        public event EventHandler SaveEditPracticeExam;
        public event EventHandler AddPracticeExam;

        // User information
        public Teacher CurrentUser { get; set; }
        public User CurrentUserInfo { get; set; }

        // Reload list pracitceExam
        public IList<PracticeExamListViewModel> PracticeExams { get; set; }

        // Delete practiceExam
        public string DeletePracticeExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã xoá kỳ thi thử!");
                }
                else if (value == "Used")
                {
                    MessageBox.Show("Kỳ thi thử đã được sử dụng nên không thể xoá!");
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi xoá kỳ thi thử!");
                }
                mBtnReloadListPracticeExam.PerformClick();
            }
        }

        // Edit practiceExam
        public IList<Subject> Subjects { get; set; }
        public string SaveEditPracticeExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã sửa kỳ thi thử!");
                }
                else if (value == "Used")
                {
                    MessageBox.Show("Kỳ thi thử đã được sử dụng nên không thể sửa!");
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi sửa kỳ thi thử!");
                }
            }
        }

        // Add practiceExam
        public string AddPracticeExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã tạo kỳ thi thử!");

                    // Refresh form
                    mTxtAddPracticeExamName.ResetText();
                    mDateTimeAddPracticeDateStart.ResetText();
                    dateTimeAddPracticeTimeStart.ResetText();
                    mTxtAddPracticeDuration.ResetText();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi tạo kỳ thi thử!");
                }
            }
        }
        #endregion



        #region Utilities
        private void SetDataBinding()
        {
            mTxtEditPracticeExamId.DataBindings.Add("Text", bsListPracticeExam, "ExamId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditPracticeExamName.DataBindings.Add("Text", bsListPracticeExam, "ExamName", true, DataSourceUpdateMode.OnPropertyChanged);
            mDateTimeEditPracticeDateStart.DataBindings.Add("Value", bsListPracticeExam, "StartTime", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimeEditPracticeTimeStart.DataBindings.Add("Value", bsListPracticeExam, "StartTime", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditPracticeDuration.DataBindings.Add("Text", bsListPracticeExam, "Duration", true, DataSourceUpdateMode.OnPropertyChanged);
            mCbbEditPracticeExamSubject.DataBindings.Add("SelectedValue", bsListPracticeExam, "SubjectId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditPracticeExamSubjectId.DataBindings.Add("Text", bsListPracticeExam, "SubjectId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditPracticeExamGradeId.DataBindings.Add("Text", bsListPracticeExam, "GradeId", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion
    }
}
