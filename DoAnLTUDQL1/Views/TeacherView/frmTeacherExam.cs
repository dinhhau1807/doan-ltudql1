using DoAnLTUDQL1.Presenters;
using DoAnLTUDQL1.Validators;
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
        List<BaseValidator> AddValidatorList;
        List<BaseValidator> EditValidatorList;

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
            SetHeaderMGridListExam();

            // Set data bindings
            SetDataBinding();

            // Register events
            // Load
            mBtnReloadListExam.Click += MBtnReloadListExam_Click;
            mTabExam.SelectedIndexChanged += MTabExam_SelectedIndexChanged;
            // Delete
            mBtnDeleteExam.Click += MBtnDeleteExam_Click;
            // Edit
            mBtnSaveEditExam.Click += MBtnSaveEditExam_Click;
            mBtnEditExamDetail.Click += MBtnEditExamDetail_Click;
            // Add
            mBtnAddExam.Click += MBtnAddExam_Click;
            mBtnAddExamDetail.Click += MBtnAddExamDetail_Click;

            // Startup
            mTabExam.SelectTab(0);
            if (bsListExam.Count > 0)
            {
                mGridListExam.Rows[0].Selected = true;
            }

            EditValidatorList = new List<BaseValidator>();
            AddValidatorList = new List<BaseValidator>();
            RequireValidatingControls();
            RegexValidatingControls();
        }


        // Add exam
        private void MBtnAddExam_Click(object sender, EventArgs e)
        {
            if (!AddValidatorList.All(a => a.IsValid))
            {
                var InvalidValidatingControl = AddValidatorList.First(f => !f.IsValid);
                InvalidValidatingControl.ControlToValidate.Focus();

                return;
            }

            var examAdded = new DoAnLTUDQL1.Exam
            {
                ExamId = "",
                ExamName = mTxtAddExamName.Text,
                IsPacticeExam = false
            };

            if (ExamDetailsAdded == null)
            {
                ExamDetailsAdded = new List<ExamDetail>();
            }
            AddExam?.Invoke(examAdded, null);
        }

        private void MBtnAddExamDetail_Click(object sender, EventArgs e)
        {
            var exam = new DoAnLTUDQL1.Exam()
            {
                ExamId = "",
                ExamName = mTxtAddExamName.Text,
                IsPacticeExam = false
            };

            ExamDetailsAdded = new List<ExamDetail>();
            var frmTeacherExamDetail = new frmTeacherExamDetail(exam, Subjects, ExamDetailsAdded);
            frmTeacherExamDetail.ShowDialog();
        }


        // Edit exam
        private void MBtnSaveEditExam_Click(object sender, EventArgs e)
        {
            if (bsListExam.Count > 0)
            {
                if (!EditValidatorList.All(a => a.IsValid))
                {
                    var InvalidValidatingControl = EditValidatorList.First(f => !f.IsValid);
                    InvalidValidatingControl.ControlToValidate.Focus();

                    return;
                }

                var exam = (DoAnLTUDQL1.Exam)bsListExam.CurrencyManager.Current;
                SaveEditExam?.Invoke(exam, null);
            }
        }

        private void MBtnEditExamDetail_Click(object sender, EventArgs e)
        {
            if (bsListExam.Count > 0 && Subjects.Count > 0)
            {
                var exam = new DoAnLTUDQL1.Exam()
                {
                    ExamId = mTxtEditExamId.Text,
                    ExamName = mTxtEditExamName.Text,
                    IsPacticeExam = false
                };

                var frmTeacherExamDetail = new frmTeacherExamDetail(exam, Subjects, ExamDetailsEdited);
                frmTeacherExamDetail.ShowDialog();
            }
        }

        // Delete exam
        private void MBtnDeleteExam_Click(object sender, EventArgs e)
        {
            if (bsListExam.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn xoá kỳ thi?", "Xoá kỳ thi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var examId = (string)mGridListExam.SelectedRows[0].Cells[0].Value;
                    DeleteExam?.Invoke(examId, null);
                }
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

            if (mTabExam.SelectedTab == mTabExamDetail || mTabExam.SelectedTab == mTabEditExam)
            {
                var exam = (DoAnLTUDQL1.Exam)bsListExam.CurrencyManager.Current;
                ReloadListExamDetail(exam.ExamId, null);
                mGridListExamDetail.DataSource = ExamDetails;

                // For edited
                ExamDetailsEdited = ExamDetails.Select(ed => new ExamDetail
                {
                    ExamDetailId = ed.ExamDetailId,
                    ExamId = ed.ExamId,
                    StartTime = ed.StartTime,
                    Duration = ed.Duration,
                    SubjectId = ed.SubjectId,
                    GradeId = ed.GradeId
                }).ToList();
                if (ExamDetailsEdited == null)
                {
                    ExamDetailsEdited = new List<ExamDetail>();
                }

                SetHeaderMGridListExamDetail();
            }

            if (mTabExam.SelectedTab == mTabReport)
            {
                var frmTeacherExamReport = new frmTeacherExamReport(CurrentUser, CurrentUserInfo);
                frmTeacherExamReport.ShowDialog();
                mTabExam.SelectTab(0);
            }
        }
        #endregion



        #region IExamView implementations
        // Events
        public event EventHandler ReloadListExam;
        public event EventHandler DeleteExam;
        public event EventHandler SaveEditExam;
        public event EventHandler AddExam;
        public event EventHandler ReloadListExamDetail;

        // User information
        public Teacher CurrentUser { get; set; }
        public User CurrentUserInfo { get; set; }

        // Reload list exam
        public IList<DoAnLTUDQL1.Exam> Exams { get; set; }
        public IList<ExamListViewModel> ExamDetails { get; set; }

        // Delete exam
        public string DeleteExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã xoá kỳ thi và toàn bộ môn thi có trong kỳ thi!");
                }
                else if (value == "Used")
                {
                    MessageBox.Show("Kỳ thi đã có môn thi được sử dụng nên không thể xoá!");
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
        public IList<ExamDetail> ExamDetailsEdited { get; set; }
        public string SaveEditExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã sửa kỳ thi và cập nhật danh sách môn thi!");
                }
                else if (value == "Used")
                {
                    MessageBox.Show("Đã cập nhật lại danh sách môn thi, kỳ thi có môn thi được sử dụng nên không thể sửa tên!");
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi sửa kỳ thi!");
                }
            }
        }

        // Add exam
        public IList<ExamDetail> ExamDetailsAdded { get; set; }
        public string AddExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã tạo kỳ thi và các môn thi!");

                    // Refresh form
                    mTxtAddExamName.ResetText();
                    ExamDetailsAdded = null;
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi tạo kỳ thi!");
                }
            }
        }
        #endregion



        #region Utilities
        void RequireValidatingControls()
        {
            RequiedInputValidator rqEditExamName, rqEditDuration,
                rqAddExamName, rqAddDuration;

            rqEditExamName = new RequiedInputValidator();
            rqEditDuration = new RequiedInputValidator();
            rqAddExamName = new RequiedInputValidator();
            rqAddDuration = new RequiedInputValidator();

            rqEditExamName.ControlToValidate = mTxtEditExamName;
            //rqEditDuration.ControlToValidate = mTxtEditDuration;
            rqAddExamName.ControlToValidate = mTxtAddExamName;
            //rqAddDuration.ControlToValidate = mTxtAddDuration;

            EditValidatorList.Add(rqEditExamName);
            EditValidatorList.Add(rqEditDuration);

            AddValidatorList.Add(rqAddExamName);
            AddValidatorList.Add(rqAddDuration);
        }

        void RegexValidatingControls()
        {
            RegexValidator rgEditDuration, rgAddDuration;

            string errorMessageNumber = "Thời gian làm bài phải lớn hơn 0";

            rgEditDuration = new RegexValidator(RegexPattern.GreaterThanZero);
            rgEditDuration.ErrorMessage = errorMessageNumber;
            rgAddDuration = new RegexValidator(RegexPattern.GreaterThanZero);
            rgAddDuration.ErrorMessage = errorMessageNumber;

            //rgEditDuration.ControlToValidate = mTxtEditDuration;
            //rgAddDuration.ControlToValidate = mTxtAddDuration;

            EditValidatorList.Add(rgEditDuration);

            AddValidatorList.Add(rgAddDuration);

            foreach (var item in AddValidatorList)
            {
                item.IsValid = false;
            }
        }

        private void SetHeaderMGridListExam()
        {
            // Show header for mGridListExam
            mGridListExam.AutoGenerateColumns = false;

            mGridListExam.Columns[0].HeaderText = "Mã kỳ thi";
            mGridListExam.Columns[0].DataPropertyName = "ExamId";

            mGridListExam.Columns[1].HeaderText = "Tên kỳ thi";
            mGridListExam.Columns[1].DataPropertyName = "ExamName";

            mGridListExam.Columns[2].Visible = false;

            foreach (DataGridViewColumn col in mGridListExam.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetHeaderMGridListExamDetail()
        {
            // Show header for mGridListExam
            mGridListExamDetail.AutoGenerateColumns = false;

            mGridListExamDetail.Columns[0].HeaderText = "Mã kỳ thi";
            mGridListExamDetail.Columns[0].DataPropertyName = "ExamId";

            mGridListExamDetail.Columns[1].HeaderText = "Tên kỳ thi";
            mGridListExamDetail.Columns[1].DataPropertyName = "ExamName";

            mGridListExamDetail.Columns[2].Visible = false;

            mGridListExamDetail.Columns[3].HeaderText = "Ngày thi";
            mGridListExamDetail.Columns[3].DataPropertyName = "StartTime";

            mGridListExamDetail.Columns[4].HeaderText = "Thời gian thi";
            mGridListExamDetail.Columns[4].DataPropertyName = "Duration";

            mGridListExamDetail.Columns[5].HeaderText = "Mã môn học";
            mGridListExamDetail.Columns[5].DataPropertyName = "SubjectId";

            mGridListExamDetail.Columns[6].HeaderText = "Khối lớp";
            mGridListExamDetail.Columns[6].DataPropertyName = "GradeId";

            mGridListExamDetail.Columns[7].HeaderText = "Tên môn học";
            mGridListExamDetail.Columns[7].DataPropertyName = "SubjectName";

            foreach (DataGridViewColumn col in mGridListExamDetail.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetDataBinding()
        {
            mTxtEditExamId.DataBindings.Add("Text", bsListExam, "ExamId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditExamName.DataBindings.Add("Text", bsListExam, "ExamName", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion
    }
}
