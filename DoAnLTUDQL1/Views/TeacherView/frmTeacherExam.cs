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
    public partial class frmTeacherExam : MetroFramework.Forms.MetroForm, ITeacherExamView
    {
        TeacherExamPresenter presenter;
        BindingSource bsListExam;

        public frmTeacherExam(Teacher teacher, User user)
        {
            CurrentUser = teacher;
            CurrentUserInfo = user;
            InitializeComponent();
            Load += FrmExam_Load;
        }



        #region Events
        private void FrmExam_Load(object sender, EventArgs e)
        {
            presenter = new TeacherExamPresenter(this);

            // Set grid view
            bsListExam = new BindingSource();
            bsListExam.DataSource = Exams;
            mGridListExam.DataSource = bsListExam;

            // Set data bindings
            SetDataBinding();

            // Load combobox Subject edit ExamCode
            mCbbEditExamSubject.DisplayMember = "SubjectName";
            mCbbEditExamSubject.ValueMember = "SubjectId";
            mCbbEditExamSubject.DataSource = Subjects;

            // Load combobox Subject add ExamCode 
            mCbbAddExamSubject.DisplayMember = "SubjectName";
            mCbbAddExamSubject.ValueMember = "SubjectId";
            mCbbAddExamSubject.DataSource = Subjects;

            // Register events
            // Load
            mBtnReloadListExam.Click += MBtnReloadListExam_Click;
            mTabExam.SelectedIndexChanged += MTabExam_SelectedIndexChanged;
            // Delete
            mBtnDeleteExam.Click += MBtnDeleteExam_Click;
            // Edit
            mCbbEditExamSubject.SelectedIndexChanged += MCbbEditExamSubject_SelectedIndexChanged;
            mTxtEditDuration.KeyPress += MTxtEditDuration_KeyPress;
            mBtnSaveEditExam.Click += MBtnSaveEditExam_Click;
            // Add
            mCbbAddExamSubject.SelectedIndexChanged += MCbbAddExamSubject_SelectedIndexChanged;
            mTxtAddDuration.KeyPress += MTxtAddDuration_KeyPress;
            mBtnAddExam.Click += MBtnAddExam_Click;

            // Startup
            mTabExam.SelectTab(0);
            if (bsListExam.Count > 0)
            {
                mGridListExam.Rows[0].Selected = true;
            }
            if (mCbbAddExamSubject.Items.Count > 0)
            {
                var subject = mCbbAddExamSubject.SelectedItem as Subject;
                mTxtAddExamSubjectId.Text = subject.SubjectId.ToString();
                mTxtAddExamGradeId.Text = subject.GradeId.ToString();
            }
        }


        // Add exam
        private void MCbbAddExamSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCbbAddExamSubject.SelectedItem != null)
            {
                var subject = mCbbAddExamSubject.SelectedItem as Subject;
                mTxtAddExamSubjectId.Text = subject.SubjectId.ToString();
                mTxtAddExamGradeId.Text = subject.GradeId.ToString();
            }
        }

        private void MTxtAddDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MBtnAddExam_Click(object sender, EventArgs e)
        {
            if (mCbbAddExamSubject.SelectedItem != null)
            {
                var timeStart = dateTimeAddTimeStart.Value.TimeOfDay;
                var startTime = DateTime.Parse(mDateTimeAddDateStart.Value.ToShortDateString()).Add(timeStart);

                var examAdded = new ExamListViewModel
                {
                    ExamName = mTxtAddExamName.Text,
                    StartTime = startTime,
                    Duration = int.Parse(mTxtAddDuration.Text),
                    SubjectId = mTxtAddExamSubjectId.Text,
                    GradeId = int.Parse(mTxtAddExamGradeId.Text)
                };

                AddExam?.Invoke(examAdded, null);
            }
            else
            {
                MessageBox.Show("Chưa đủ dữ liệu!");
            }
        }


        // Edit exam
        private void MTxtEditDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MCbbEditExamSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCbbEditExamSubject.SelectedItem != null)
            {
                var subject = mCbbEditExamSubject.SelectedItem as Subject;
                mTxtEditExamSubjectId.Text = subject.SubjectId.ToString();
                mTxtEditExamGradeId.Text = subject.GradeId.ToString();
            }
        }

        private void MBtnSaveEditExam_Click(object sender, EventArgs e)
        {
            if (bsListExam.Count > 0)
            {
                var exam = (ExamListViewModel)mGridListExam.SelectedRows[0].DataBoundItem;
                SaveEditExam?.Invoke(exam, null);
            }
        }

        // Delete exam
        private void MBtnDeleteExam_Click(object sender, EventArgs e)
        {
            if (bsListExam.Count > 0)
            {
                var examId = (string)mGridListExam.SelectedRows[0].Cells[0].Value;
                DeleteExam?.Invoke(examId, null);
            }
        }

        // Load list exam
        private void MBtnReloadListExam_Click(object sender, EventArgs e)
        {
            ReloadListExam?.Invoke(this, null);
            bsListExam.DataSource = Exams;
        }

        private void MTabExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mTabExam.SelectedTab == mTabListExam)
            {
                mBtnReloadListExam.PerformClick();
            }
        }
        #endregion



        #region IExamView implementations
        // Events
        public event EventHandler ReloadListExam;
        public event EventHandler DeleteExam;
        public event EventHandler SaveEditExam;
        public event EventHandler AddExam;

        // User information
        public Teacher CurrentUser { get; set; }
        public User CurrentUserInfo { get; set; }

        // Reload list exam
        public IList<ExamListViewModel> Exams { get; set; }

        // Delete exam
        public string DeleteExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã xoá kỳ thi!");
                }
                else if (value == "Used")
                {
                    MessageBox.Show("Kỳ thi đã được sử dụng nên không thể xoá!");
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi xoá kỳ thi!");
                }
                mBtnReloadListExam.PerformClick();
            }
        }

        // Edit exam
        public IList<Subject> Subjects { get; set; }
        public string SaveEditExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã sửa kỳ thi!");
                }
                else if (value == "Used")
                {
                    MessageBox.Show("Kỳ thi đã được sử dụng nên không thể sửa!");
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi sửa kỳ thi!");
                }
            }
        }

        // Add exam
        public string AddExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã tạo kỳ thi!");

                    // Refresh form
                    mTxtAddExamName.ResetText();
                    mDateTimeAddDateStart.ResetText();
                    dateTimeAddTimeStart.ResetText();
                    mTxtAddDuration.ResetText();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi tạo kỳ thi!");
                }
            }
        }
        #endregion



        #region Utilities
        private void SetDataBinding()
        {
            mTxtEditExamId.DataBindings.Add("Text", bsListExam, "ExamId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditExamName.DataBindings.Add("Text", bsListExam, "ExamName", true, DataSourceUpdateMode.OnPropertyChanged);
            mDateTimeEditDateStart.DataBindings.Add("Value", bsListExam, "StartTime", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimeEditTimeStart.DataBindings.Add("Value", bsListExam, "StartTime", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditDuration.DataBindings.Add("Text", bsListExam, "Duration", true, DataSourceUpdateMode.OnPropertyChanged);
            mCbbEditExamSubject.DataBindings.Add("SelectedValue", bsListExam, "SubjectId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditExamSubjectId.DataBindings.Add("Text", bsListExam, "SubjectId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditExamGradeId.DataBindings.Add("Text", bsListExam, "GradeId", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion
    }
}
