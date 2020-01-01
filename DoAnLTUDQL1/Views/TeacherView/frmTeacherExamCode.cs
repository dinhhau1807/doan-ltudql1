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
    public partial class frmTeacherExamCode : MetroFramework.Forms.MetroForm, ITeacherExamCodeView
    {
        TeacherExamCodePresenter presenter;
        BindingSource bsListExamCode;


        public frmTeacherExamCode(Teacher teacher, User user)
        {
            CurrentUser = teacher;
            CurrentUserInfo = user;
            InitializeComponent();
            Load += FrmExamCode_Load;
        }


        #region Events
        private void FrmExamCode_Load(object sender, EventArgs e)
        {
            presenter = new TeacherExamCodePresenter(this);

            // Set grid view
            bsListExamCode = new BindingSource();
            bsListExamCode.DataSource = ExamCodes;
            mGridListExamCode.DataSource = bsListExamCode;
            SetHeaderMGridListExamCode();

            // Set data bindings
            SetDataBinding();

            // Load combobox Subject edit ExamCode
            mCbbEditExamCodeSubject.DisplayMember = "SubjectName";
            mCbbEditExamCodeSubject.DataSource = Subjects;

            // Load combobox Subject add ExamCode 
            mCbbAddExamCodeSubject.DisplayMember = "SubjectName";
            mCbbAddExamCodeSubject.DataSource = Subjects;

            // Register events
            // List
            mTabExamCode.SelectedIndexChanged += MTabExamCode_SelectedIndexChanged;
            mBtnReloadListExamCode.Click += MBtnReloadListExamCode_Click;
            // Deltete
            mBtnDeleteExamCode.Click += MBtnDeleteExamCode_Click;
            // Edit
            mCbbEditExamCodeSubject.SelectedIndexChanged += MCbbEditExamCodeSubject_SelectedIndexChanged;
            mTxtEditExamCodeNumberOfQuestions.KeyPress += MTxtEditExamCodeNumberOfQuestions_KeyPress;
            mBtnSaveEditExamCode.Click += MBtnSaveEditExamCode_Click;
            mBtnEditExamCodeQuestions.Click += MBtnEditExamCodeQuestions_Click;
            mToggleEditExamCodeIsPracticeExam.CheckedChanged += MToggleEditExamCodeIsPracticeExam_CheckedChanged;
            mGridListExamCode.SelectionChanged += MGridListExamCode_SelectionChanged;
            // Add
            mCbbAddExamCodeSubject.SelectedIndexChanged += MCbbAddExamCodeSubject_SelectedIndexChanged;
            mTxtAddExamCodeNumberOfQuestions.KeyPress += MTxtEditExamCodeNumberOfQuestions_KeyPress;
            mToggleAddExamCodeIsPracticeExam.CheckedChanged += MToggleAddExamCodeIsPracticeExam_CheckedChanged;
            mBtnAddExamCodeQuestions.Click += MBtnAddExamCodeQuestions_Click;
            mBtnAddExamCode.Click += MBtnAddExamCode_Click;

            // Startup
            mTabExamCode.SelectTab(0);
            if (bsListExamCode.Count > 0)
            {
                mGridListExamCode.Rows[0].Selected = true;
            }
            if (mCbbAddExamCodeSubject.Items.Count > 0)
            {
                var subject = mCbbAddExamCodeSubject.SelectedItem as Subject;
                mTxtAddExamCodeSubjectId.Text = subject.SubjectId.ToString();
                mTxtAddExamCodeGradeId.Text = subject.GradeId.ToString();
            }
        }


        // Add ExamCode
        private void MCbbAddExamCodeSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCbbAddExamCodeSubject.SelectedItem != null)
            {
                if (mTabExamCode.SelectedTab == mTabAddExamCode)
                {
                    MessageBox.Show("Danh sách câu hỏi đã có sẽ được xoá để cập nhật lại theo đúng môn học!", "Thay đổi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    AddExamCodeQuestionIds.Clear();
                }

                var subject = mCbbAddExamCodeSubject.SelectedItem as Subject;
                mTxtAddExamCodeSubjectId.Text = subject.SubjectId.ToString();
                mTxtAddExamCodeGradeId.Text = subject.GradeId.ToString();
            }
        }

        private void MToggleAddExamCodeIsPracticeExam_CheckedChanged(object sender, EventArgs e)
        {
            if (mTabExamCode.SelectedTab == mTabAddExamCode && mToggleAddExamCodeIsPracticeExam.Checked == false)
            {
                MessageBox.Show("Danh sách câu hỏi đã có sẽ được xoá để cập nhật lại câu hỏi theo đúng đề thi thật!", "Thay đổi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddExamCodeQuestionIds.Clear();
            }
        }

        private void MBtnAddExamCode_Click(object sender, EventArgs e)
        {
            if (mCbbAddExamCodeSubject.SelectedItem != null && !string.IsNullOrWhiteSpace(mTxtAddExamCodeNumberOfQuestions.Text))
            {
                var examCode = new ExamCodeListViewModel
                {
                    NumberOfQuestions = int.Parse(mTxtAddExamCodeNumberOfQuestions.Text),
                    SubjectId = mTxtAddExamCodeSubjectId.Text,
                    GradeId = int.Parse(mTxtAddExamCodeGradeId.Text),
                    IsPracticeExam = mToggleAddExamCodeIsPracticeExam.Checked
                };

                if (examCode.NumberOfQuestions == AddExamCodeQuestionIds.Count())
                {
                    AddExamCode?.Invoke(examCode, null);
                }
                else
                {
                    MessageBox.Show("Số lượng câu hỏi phải đúng với số câu hỏi đã quy định!");
                }
            }
            else
            {
                MessageBox.Show("Chưa đủ dữ liệu!");
            }
        }

        private void MBtnAddExamCodeQuestions_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mTxtAddExamCodeNumberOfQuestions.Text))
            {
                var examCode = new ExamCodeListViewModel
                {
                    NumberOfQuestions = int.Parse(mTxtAddExamCodeNumberOfQuestions.Text),
                    SubjectId = mTxtAddExamCodeSubjectId.Text,
                    GradeId = int.Parse(mTxtAddExamCodeGradeId.Text),
                    IsPracticeExam = mToggleAddExamCodeIsPracticeExam.Checked
                };

                var frmEditExamCodeQuestions = new frmTeacherEditExamCodeQuestions(CurrentUser.TeacherId, examCode, AddExamCodeQuestionIds);
                frmEditExamCodeQuestions.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa đủ dữ liệu!");
            }
        }

        // Edit ExamCode
        private void MBtnSaveEditExamCode_Click(object sender, EventArgs e)
        {
            if (bsListExamCode.Count > 0)
            {
                var examCode = (ExamCodeListViewModel)mGridListExamCode.SelectedRows[0].DataBoundItem;
                if (examCode.NumberOfQuestions == EditExamCodeQuestionIds.Count())
                {
                    SaveEditExamCode?.Invoke(examCode, null);
                }
                else
                {
                    MessageBox.Show("Số lượng câu hỏi phải đúng với số câu hỏi đã quy định!");
                }
            }
        }

        private void MBtnEditExamCodeQuestions_Click(object sender, EventArgs e)
        {
            if (bsListExamCode.Count > 0)
            {
                var examCode = (ExamCodeListViewModel)mGridListExamCode.SelectedRows[0].DataBoundItem;
                var frmEditExamCodeQuestions = new frmTeacherEditExamCodeQuestions(CurrentUser.TeacherId, examCode, EditExamCodeQuestionIds);
                frmEditExamCodeQuestions.ShowDialog();
            }
        }

        private void MTxtEditExamCodeNumberOfQuestions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void MCbbEditExamCodeSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCbbEditExamCodeSubject.SelectedItem != null)
            {
                if (mTabExamCode.SelectedTab == mTabEditExamCode)
                {
                    MessageBox.Show("Danh sách câu hỏi đã có sẽ được xoá để cập nhật lại theo đúng môn học!", "Thay đổi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EditExamCodeQuestionIds.Clear();
                }

                var subject = mCbbEditExamCodeSubject.SelectedItem as Subject;
                mTxtEditExamCodeSubjectId.Text = subject.SubjectId.ToString();
                mTxtEditExamCodeGradeId.Text = subject.GradeId.ToString();
            }
        }

        private void MToggleEditExamCodeIsPracticeExam_CheckedChanged(object sender, EventArgs e)
        {
            if (bsListExamCode.Count > 0 && mTabExamCode.SelectedTab == mTabEditExamCode && mToggleEditExamCodeIsPracticeExam.Checked == false)
            {
                MessageBox.Show("Danh sách câu hỏi đã có sẽ được xoá để cập nhật lại câu hỏi theo đúng đề thi thật!", "Thay đổi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EditExamCodeQuestionIds.Clear();
            }
        }

        private void MGridListExamCode_SelectionChanged(object sender, EventArgs e)
        {
            if (mGridListExamCode.SelectedRows.Count > 0)
            {
                if (mCbbEditExamCodeSubject.SelectedItem != null)
                {
                    var subject = Subjects.FirstOrDefault(s => s.SubjectId == mTxtEditExamCodeSubjectId.Text && s.GradeId == int.Parse(mTxtEditExamCodeGradeId.Text));
                    if (subject != null)
                    {
                        mCbbEditExamCodeSubject.SelectedItem = subject;
                    }
                }

                if (bsListExamCode.Count > 0)
                {
                    var examCode = (ExamCodeListViewModel)mGridListExamCode.SelectedRows[0].DataBoundItem;
                    GetEditExamCodeQuestionIds?.Invoke(examCode, null);
                }
            }
        }

        // List ExamCode
        private void MBtnReloadListExamCode_Click(object sender, EventArgs e)
        {
            ReloadListExamCode?.Invoke(this, null);
            bsListExamCode.DataSource = ExamCodes;
        }

        private void MBtnDeleteExamCode_Click(object sender, EventArgs e)
        {
            if (bsListExamCode.Count > 0)
            {
                var examCodeId = (string)mGridListExamCode.SelectedRows[0].Cells[0].Value;
                DeleteExamCode?.Invoke(examCodeId, null);
            }
        }

        private void MTabExamCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mTabExamCode.SelectedTab == mTabListExamCode)
            {
                mBtnReloadListExamCode.PerformClick();
            }
        }
        #endregion


        #region IExamCodeView implementations
        // Events
        public event EventHandler ReloadListExamCode;
        public event EventHandler DeleteExamCode;
        public event EventHandler SaveEditExamCode;
        public event EventHandler GetEditExamCodeQuestionIds;
        public event EventHandler AddExamCode;

        // Get user information
        public Teacher CurrentUser { get; set; }
        public User CurrentUserInfo { get; set; }

        // List examCode
        public IList<ExamCodeListViewModel> ExamCodes { get; set; }

        // Delete ExamCode
        public string DeleteExamCodeMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã xoá đề thi!");
                }
                else if (value == "Used")
                {
                    MessageBox.Show("Đề thi đã được sử dụng nên không thể xoá!");
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi xoá đề thi!");
                }
                mBtnReloadListExamCode.PerformClick();
            }
        }

        // Edit ExamCode
        public IList<Subject> Subjects { get; set; }
        public IList<int> EditExamCodeQuestionIds { get; set; }
        public string SaveEditExamCodeMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã sửa đề thi!");
                }
                else if (value == "Used")
                {
                    MessageBox.Show("Đề thi đã được sử dụng nên không thể sửa!");
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi sửa đề thi!");
                }
                ReloadListExamCode?.Invoke(this, null);
                bsListExamCode.DataSource = ExamCodes;
            }
        }

        // Add ExamCode
        public IList<int> AddExamCodeQuestionIds { get; set; }
        public string AddExamCodeMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã tạo đề thi!");
                    mTxtAddExamCodeNumberOfQuestions.ResetText();
                    mCbbAddExamCodeSubject.SelectedIndex = 0;
                    AddExamCodeQuestionIds.Clear();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi thêm đề thi!");
                }
            }
        }

        #endregion


        #region Utilities
        private void SetHeaderMGridListExamCode()
        {
            // Show header for mGridListExamCode
            mGridListExamCode.AutoGenerateColumns = false;

            mGridListExamCode.Columns[0].HeaderText = "Mã đề";
            mGridListExamCode.Columns[0].DataPropertyName = "ExamCodeId";

            mGridListExamCode.Columns[1].HeaderText = "Số câu hỏi";
            mGridListExamCode.Columns[1].DataPropertyName = "NumberOfQuestions";

            mGridListExamCode.Columns[2].HeaderText = "Mã môn học";
            mGridListExamCode.Columns[2].DataPropertyName = "SubjectId";

            mGridListExamCode.Columns[3].HeaderText = "Khối lớp";
            mGridListExamCode.Columns[3].DataPropertyName = "GradeId";

            mGridListExamCode.Columns[4].HeaderText = "Tên môn học";
            mGridListExamCode.Columns[4].DataPropertyName = "SubjectName";

            mGridListExamCode.Columns[5].HeaderText = "Đề thi thử";
            mGridListExamCode.Columns[5].DataPropertyName = "IsPracticeExam";

            foreach (DataGridViewColumn col in mGridListExamCode.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetDataBinding()
        {
            mTxtEditExamCodeId.DataBindings.Add("Text", bsListExamCode, "ExamCodeId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditExamCodeSubjectId.DataBindings.Add("Text", bsListExamCode, "SubjectId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditExamCodeGradeId.DataBindings.Add("Text", bsListExamCode, "GradeId", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditExamCodeNumberOfQuestions.DataBindings.Add("Text", bsListExamCode, "NumberOfQuestions", true, DataSourceUpdateMode.OnPropertyChanged);
            mToggleEditExamCodeIsPracticeExam.DataBindings.Add("Checked", bsListExamCode, "IsPracticeExam", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion
    }
}
