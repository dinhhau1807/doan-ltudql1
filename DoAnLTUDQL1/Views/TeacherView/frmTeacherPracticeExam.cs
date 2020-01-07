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
    public partial class frmTeacherPracticeExam : MetroFramework.Forms.MetroForm, ITeacherPracticeExamView
    {
        TeacherPracticeExamPresenter presenter;
        BindingSource bsListPracticeExam;
        List<BaseValidator> AddValidatorList;
        List<BaseValidator> EditValidatorList;

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
            SetHeaderMGridListPracticeExam();

            // Set data bindings
            SetDataBinding();

            // Register events
            // Load
            mBtnReloadListPracticeExam.Click += MBtnReloadListPracticeExam_Click;
            mTabPracticeExam.SelectedIndexChanged += MTabPracticeExam_SelectedIndexChanged;
            // Delete
            mBtnDeletePracticeExam.Click += MBtnDeletePracticeExam_Click;
            // Edit
            mBtnSaveEditPracticeExam.Click += MBtnSaveEditPracticeExam_Click;
            mBtnEditExamDetail.Click += MBtnEditExamDetail_Click;
            // Add
            mBtnAddPracticeExam.Click += MBtnAddPracticeExam_Click;
            mBtnAddExamDetail.Click += MBtnAddExamDetail_Click;
            // Update student mark
            mBtnUpdateStudentMark.Click += MBtnUpdateStudentMark_Click;

            // Startup
            mTabPracticeExam.SelectTab(0);
            if (bsListPracticeExam.Count > 0)
            {
                mGridListPracticeExam.Rows[0].Selected = true;
            }

            EditValidatorList = new List<BaseValidator>();
            AddValidatorList = new List<BaseValidator>();
            RequireValidatingControls();
            RegexValidatingControls();
        }


        // Update student mark
        private void MBtnUpdateStudentMark_Click(object sender, EventArgs e)
        {
            if (mGridListExamDetail.Rows.Count > 0 && mGridListExamDetail.SelectedRows.Count > 0)
            {
                var examDetail = (ExamListViewModel)mGridListExamDetail.SelectedRows[0].DataBoundItem;
                UpdateStudentMark?.Invoke(examDetail, null);
            }
        }


        // Add exam
        private void MBtnAddPracticeExam_Click(object sender, EventArgs e)
        {
            if (!AddValidatorList.All(a => a.IsValid))
            {
                var InvalidValidatingControl = AddValidatorList.First(f => !f.IsValid);
                InvalidValidatingControl.ControlToValidate.Focus();

                return;
            }

            var practiceExamAdded = new DoAnLTUDQL1.Exam
            {
                ExamId = "",
                ExamName = mTxtAddPracticeExamName.Text,
                IsPacticeExam = true
            };

            if (ExamDetailsAdded == null)
            {
                ExamDetailsAdded = new List<ExamDetail>();
            }
            AddPracticeExam?.Invoke(practiceExamAdded, null);
        }

        private void MBtnAddExamDetail_Click(object sender, EventArgs e)
        {
            var practiceExam = new DoAnLTUDQL1.Exam()
            {
                ExamId = "",
                ExamName = mTxtAddPracticeExamName.Text,
                IsPacticeExam = true
            };

            ExamDetailsAdded = new List<ExamDetail>();
            var frmTeacherExamDetail = new frmTeacherExamDetail(practiceExam, Subjects, ExamDetailsAdded);
            frmTeacherExamDetail.ShowDialog();
        }


        // Edit exam
        private void MBtnSaveEditPracticeExam_Click(object sender, EventArgs e)
        {
            if (bsListPracticeExam.Count > 0)
            {
                if (!EditValidatorList.All(a => a.IsValid))
                {
                    var InvalidValidatingControl = EditValidatorList.First(f => !f.IsValid);
                    InvalidValidatingControl.ControlToValidate.Focus();

                    return;
                }

                var practiceExam = (DoAnLTUDQL1.Exam)mGridListPracticeExam.SelectedRows[0].DataBoundItem;
                SaveEditPracticeExam?.Invoke(practiceExam, null);
            }
        }

        private void MBtnEditExamDetail_Click(object sender, EventArgs e)
        {
            if (bsListPracticeExam.Count > 0 && Subjects.Count > 0)
            {
                var practiceExamEdited = new DoAnLTUDQL1.Exam()
                {
                    ExamId = mTxtEditPracticeExamId.Text,
                    ExamName = mTxtEditPracticeExamName.Text,
                    IsPacticeExam = false
                };

                var frmTeacherExamDetail = new frmTeacherExamDetail(practiceExamEdited, Subjects, ExamDetailsEdited);
                frmTeacherExamDetail.ShowDialog();
            }
        }


        // Delete exam
        private void MBtnDeletePracticeExam_Click(object sender, EventArgs e)
        {
            if (bsListPracticeExam.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có thật sự muốn xoá kỳ thi thử?", "Xoá kỳ thi thử", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var practiceExamId = (string)mGridListPracticeExam.SelectedRows[0].Cells[0].Value;
                    DeletePracticeExam?.Invoke(practiceExamId, null);
                }
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

            if (mTabPracticeExam.SelectedTab == mTabExamDetail || mTabPracticeExam.SelectedTab == mTabEditPracticeExam)
            {
                var practiceExam = (DoAnLTUDQL1.Exam)bsListPracticeExam.CurrencyManager.Current;
                ReloadListExamDetail(practiceExam.ExamId, null);
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
        }
        #endregion



        #region IPracticeExamView implementations
        // Events
        public event EventHandler ReloadListPracticeExam;
        public event EventHandler DeletePracticeExam;
        public event EventHandler SaveEditPracticeExam;
        public event EventHandler AddPracticeExam;
        public event EventHandler ReloadListExamDetail;
        public event EventHandler UpdateStudentMark;

        // User information
        public Teacher CurrentUser { get; set; }
        public User CurrentUserInfo { get; set; }

        // Reload list pracitceExam
        public IList<DoAnLTUDQL1.Exam> PracticeExams { get; set; }
        public IList<ExamListViewModel> ExamDetails { get; set; }

        // Delete practiceExam
        public string DeletePracticeExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã xoá kỳ thi thử và toàn bộ môn thi có trong kỳ thi thử!");
                }
                else if (value == "Used")
                {
                    MessageBox.Show("Kỳ thi thử đã có môn thi được sử dụng nên không thể xoá!");
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
        public IList<ExamDetail> ExamDetailsEdited { get; set; }
        public string SaveEditPracticeExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã sửa kỳ thi thử và cập nhật danh sách môn thi!");
                }
                else if (value == "Used")
                {
                    MessageBox.Show("Đã cập nhật lại danh sách môn thi, kỳ thi thử có môn thi được sử dụng nên không thể sửa tên!");
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi sửa kỳ thi thử!");
                }
            }
        }

        // Add practiceExam
        public IList<ExamDetail> ExamDetailsAdded { get; set; }
        public string AddPracticeExamMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã tạo kỳ thi thử và các môn thi!");

                    // Refresh form
                    mTxtAddPracticeExamName.ResetText();
                    ExamDetailsAdded = null;
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi tạo kỳ thi thử!");
                }
            }
        }

        // Update student mark
        public string UpdateStudentMarkMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã cập nhật điểm thi!");
                }

                if (value == "NotYet")
                {
                    MessageBox.Show("Môn thi chưa đến lúc thi!");
                }

                if (value == "Failed")
                {
                    MessageBox.Show("Xảy ra lỗi khi cập nhật điểm thi!");
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

            rqEditExamName.ControlToValidate = mTxtEditPracticeExamName;
            //rqEditDuration.ControlToValidate = mTxtEditPracticeDuration;
            rqAddExamName.ControlToValidate = mTxtAddPracticeExamName;
            //rqAddDuration.ControlToValidate = mTxtAddPracticeDuration;

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

            //rgEditDuration.ControlToValidate = mTxtEditPracticeDuration;
            //rgAddDuration.ControlToValidate = mTxtAddPracticeDuration;

            EditValidatorList.Add(rgEditDuration);

            AddValidatorList.Add(rgAddDuration);

            foreach (var item in AddValidatorList)
            {
                item.IsValid = false;
            }
        }

        private void SetHeaderMGridListPracticeExam()
        {
            // Show header for mGridListExam
            mGridListPracticeExam.AutoGenerateColumns = false;

            mGridListPracticeExam.Columns[0].HeaderText = "Mã kỳ thi";
            mGridListPracticeExam.Columns[0].DataPropertyName = "ExamId";

            mGridListPracticeExam.Columns[1].HeaderText = "Tên kỳ thi";
            mGridListPracticeExam.Columns[1].DataPropertyName = "ExamName";

            mGridListPracticeExam.Columns[2].Visible = false;

            foreach (DataGridViewColumn col in mGridListPracticeExam.Columns)
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
            mTxtEditPracticeExamId.DataBindings.Add("Text", bsListPracticeExam, "ExamId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditPracticeExamName.DataBindings.Add("Text", bsListPracticeExam, "ExamName", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion
    }
}
