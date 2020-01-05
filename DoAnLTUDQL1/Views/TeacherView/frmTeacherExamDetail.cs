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
    public partial class frmTeacherExamDetail : MetroFramework.Forms.MetroForm, ITeacherExamDetailView
    {
        TeacherExamDetailPresenter presenter;
        BindingSource bsListExamDetail;

        public frmTeacherExamDetail(DoAnLTUDQL1.Exam exam, IList<Subject> subjects, IList<ExamDetail> examDetails)
        {
            ExamDetails = examDetails;
            Exam = exam;
            Subjects = subjects;
            InitializeComponent();
            Text = $"Kỳ thi - {Exam.ExamName}";
            Load += FrmTeacherExamDetail_Load;
        }



        #region Events
        private void FrmTeacherExamDetail_Load(object sender, EventArgs e)
        {
            presenter = new TeacherExamDetailPresenter(this);

            // Load datasource
            bsListExamDetail = new BindingSource();
            bsListExamDetail.DataSource = ExamDetails;
            mGridListExamDetail.DataSource = bsListExamDetail;

            // Set header
            SetHeaderMGridListExamDetail();

            // Set data bindings
            SetDataBinding();

            // Load combobox Subject edit ExamDetail
            mCbbEditExamDetailSubject.DisplayMember = "SubjectName";
            mCbbEditExamDetailSubject.ValueMember = "SubjectId";
            mCbbEditExamDetailSubject.DataSource = Subjects;

            // Load combobox Subject add ExamDetail
            mCbbAddExamDetailSubject.DisplayMember = "SubjectName";
            mCbbAddExamDetailSubject.ValueMember = "SubjectId";
            mCbbAddExamDetailSubject.DataSource = Subjects;

            // Register events
            // Load
            mBtnReloadListExamDetail.Click += MBtnReloadListExamDetail_Click;
            // Delete
            mBtnDeleteExamDetail.Click += MBtnDeleteExamDetail_Click;
            // Edit
            mCbbEditExamDetailSubject.SelectedIndexChanged += MCbbEditExamDetailSubject_SelectedIndexChanged;
            mTxtEditDuration.KeyPress += MTxtEditDuration_KeyPress;
            mBtnSaveEditExamDetail.Click += MBtnSaveEditExamDetail_Click;
            mTabExamDetail.SelectedIndexChanged += MTabExamDetail_SelectedIndexChanged;
            // Add
            mCbbAddExamDetailSubject.SelectedIndexChanged += MCbbAddExamDetailSubject_SelectedIndexChanged;
            mTxtAddDuration.KeyPress += MTxtAddDuration_KeyPress;
            mBtnAddExamDetail.Click += MBtnAddExamDetail_Click;

            // Startup
            mTabExamDetail.SelectTab(0);
            if (mCbbAddExamDetailSubject.Items.Count > 0)
            {
                var subject = mCbbAddExamDetailSubject.SelectedItem as Subject;
                mTxtAddExamDetailSubjectId.Text = subject.SubjectId.ToString();
                mTxtAddExamDetailGradeId.Text = subject.GradeId.ToString();
            }
        }


        // Add
        private void MCbbAddExamDetailSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCbbAddExamDetailSubject.SelectedItem != null)
            {
                var subject = mCbbAddExamDetailSubject.SelectedItem as Subject;
                mTxtAddExamDetailSubjectId.Text = subject.SubjectId.ToString();
                mTxtAddExamDetailGradeId.Text = subject.GradeId.ToString();
            }
        }

        private void MTxtAddDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MBtnAddExamDetail_Click(object sender, EventArgs e)
        {
            if (mCbbAddExamDetailSubject.SelectedItem != null)
            {
                var timeStart = dateTimeAddTimeStart.Value.TimeOfDay;
                var startTime = DateTime.Parse(mDateTimeAddDateStart.Value.ToShortDateString()).Add(timeStart);
                startTime -= new TimeSpan(0, 0, 0, timeStart.Seconds, timeStart.Milliseconds);

                var examDetail = new ExamDetail
                {
                    ExamDetailId = "",
                    ExamId = Exam.ExamId,
                    StartTime = startTime,
                    Duration = int.Parse(mTxtAddDuration.Text),
                    SubjectId = mTxtAddExamDetailSubjectId.Text,
                    GradeId = int.Parse(mTxtAddExamDetailGradeId.Text)
                };

                AddExamDetail?.Invoke(examDetail, null);
            }
        }

        // Edit
        private void MCbbEditExamDetailSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCbbEditExamDetailSubject.SelectedItem != null)
            {
                var subject = mCbbEditExamDetailSubject.SelectedItem as Subject;
                mTxtEditExamDetailSubjectId.Text = subject.SubjectId.ToString();
                mTxtEditExamDetailGradeId.Text = subject.GradeId.ToString();
            }
        }

        private void MTxtEditDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MBtnSaveEditExamDetail_Click(object sender, EventArgs e)
        {
            if (bsListExamDetail.Count > 0)
            {
                var currentExamDetail = (ExamDetail)bsListExamDetail.CurrencyManager.Current;
                EditExamDetail?.Invoke(currentExamDetail, null);
            }
        }

        private void MTabExamDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mTabExamDetail.SelectedTab == mTabEditExamDetail)
            {
                if (bsListExamDetail.Count > 0)
                {
                    var currentExamDetail = (ExamDetail)bsListExamDetail.CurrencyManager.Current;
                    ExamDetailEdited = new ExamDetail
                    {
                        ExamDetailId = currentExamDetail.ExamDetailId,
                        ExamId = currentExamDetail.ExamId,
                        StartTime = currentExamDetail.StartTime,
                        Duration = currentExamDetail.Duration,
                        SubjectId = currentExamDetail.SubjectId,
                        GradeId = currentExamDetail.GradeId
                    };
                }
            }

            if (mTabExamDetail.SelectedTab != mTabEditExamDetail)
            {
                if (ExamDetailEdited != null && bsListExamDetail.CurrencyManager.Current != null)
                {
                    var currentExamDetail = (ExamDetail)bsListExamDetail.CurrencyManager.Current;
                    currentExamDetail.ExamDetailId = ExamDetailEdited.ExamDetailId;
                    currentExamDetail.ExamId = ExamDetailEdited.ExamId;
                    currentExamDetail.StartTime = ExamDetailEdited.StartTime;
                    currentExamDetail.Duration = ExamDetailEdited.Duration;
                    currentExamDetail.SubjectId = ExamDetailEdited.SubjectId;
                    currentExamDetail.GradeId = ExamDetailEdited.GradeId;
                }
            }
        }

        // Delete
        private void MBtnDeleteExamDetail_Click(object sender, EventArgs e)
        {
            if (bsListExamDetail.Count > 0)
            {
                var examDetail = (ExamDetail)bsListExamDetail.CurrencyManager.Current;
                DeleteExamDetail(examDetail, null);
            }
        }

        // Load list ExamDetail
        private void MBtnReloadListExamDetail_Click(object sender, EventArgs e)
        {
            bsListExamDetail.DataSource = ExamDetails;
            mGridListExamDetail.DataSource = null;
            mGridListExamDetail.DataSource = bsListExamDetail;
        }
        #endregion



        #region ITeacherExamDetailView implementations
        // Events
        public event EventHandler DeleteExamDetail;
        public event EventHandler EditExamDetail;
        public event EventHandler AddExamDetail;

        // Get exam information
        public DoAnLTUDQL1.Exam Exam { get; set; }

        // List ExamDetail
        public IList<ExamDetail> ExamDetails { get; set; }
        public IList<Subject> Subjects { get; set; }

        // Delete 
        public string DeleteExamDetailMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã xoá môn thi khỏi kỳ thi.");
                    bsListExamDetail.CurrencyManager.Refresh();
                }

                if (value == "Used")
                {
                    MessageBox.Show("Môn thi đã được sử dụng nên không thể xoá!", "Không thể xoá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (value == "Failed")
                {
                    MessageBox.Show("Xoá thất bại!", "Không thể xoá", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Edit
        public ExamDetail ExamDetailEdited { get; set; }
        public string EditExamDetailMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã sửa môn thi.");
                }

                if (value == "Used")
                {
                    MessageBox.Show("Môn thi đã được sử dụng nên không thể sửa!", "Không thể sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (value == "Failed")
                {
                    MessageBox.Show("sứa thất bại!", "Không thể sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Add
        public string AddExamDetailMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã thêm môn thi.");
                    bsListExamDetail.DataSource = ExamDetails;
                    mGridListExamDetail.DataSource = null;
                    mGridListExamDetail.DataSource = bsListExamDetail;

                    bsListExamDetail.CurrencyManager.Refresh();

                    // Reset form
                    mDateTimeAddDateStart.ResetText();
                    dateTimeAddTimeStart.ResetText();
                    mTxtAddDuration.ResetText();
                }

                if (value == "Failed")
                {
                    MessageBox.Show("Thêm thất bại!", "Không thể thêm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion



        #region Utilities
        private void SetHeaderMGridListExamDetail()
        {
            // Show header for mGridListExamDetail
            mGridListExamDetail.AutoGenerateColumns = false;

            mGridListExamDetail.Columns[0].HeaderText = "Mã môn thi";
            mGridListExamDetail.Columns[0].DataPropertyName = "ExamDetailId";

            mGridListExamDetail.Columns[1].Visible = false;

            mGridListExamDetail.Columns[2].HeaderText = "Ngày thi";
            mGridListExamDetail.Columns[2].DataPropertyName = "StartTime";

            mGridListExamDetail.Columns[3].HeaderText = "Thời gian thi";
            mGridListExamDetail.Columns[3].DataPropertyName = "Duration";

            mGridListExamDetail.Columns[4].HeaderText = "Mã môn học";
            mGridListExamDetail.Columns[4].DataPropertyName = "SubjectId";

            mGridListExamDetail.Columns[5].HeaderText = "Khối lớp";
            mGridListExamDetail.Columns[5].DataPropertyName = "GradeId";

            mGridListExamDetail.Columns[6].Visible = false;
            mGridListExamDetail.Columns[7].Visible = false;

            foreach (DataGridViewColumn col in mGridListExamDetail.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetDataBinding()
        {
            // Data bindings for mGidListExamDetail
            mDateTimeEditDateStart.DataBindings.Add("Value", bsListExamDetail, "StartTime", true, DataSourceUpdateMode.OnPropertyChanged);
            dateTimeEditTimeStart.DataBindings.Add("Value", bsListExamDetail, "StartTime", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditDuration.DataBindings.Add("Text", bsListExamDetail, "Duration", true, DataSourceUpdateMode.OnPropertyChanged);
            mCbbEditExamDetailSubject.DataBindings.Add("SelectedValue", bsListExamDetail, "SubjectId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditExamDetailSubjectId.DataBindings.Add("Text", bsListExamDetail, "SubjectId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditExamDetailGradeId.DataBindings.Add("Text", bsListExamDetail, "GradeId", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion
    }
}
