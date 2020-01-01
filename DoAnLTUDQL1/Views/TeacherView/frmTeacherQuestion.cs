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
    public partial class frmTeacherQuestion : MetroFramework.Forms.MetroForm, ITeacherQuestionView
    {
        TeacherQuestionPresenter presenter;
        BindingSource bsQuestionList;
        BindingSource bsDetailQuestionExamCodeList;
        BindingSource bsApproveQuestionList;

        public frmTeacherQuestion(Teacher teacher, User user)
        {
            CurrentUser = teacher;
            CurrentUserInfo = user;
            InitializeComponent();
            Load += FrmQuestion_Load;
        }

        #region Events
        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            presenter = new TeacherQuestionPresenter(this);

            // Tab question
            bsQuestionList = new BindingSource();
            bsQuestionList.DataSource = ListQuestion;
            mGridListQuestion.DataSource = bsQuestionList;
            // --- Load combobox difficultLevel
            var difficulLevels = new List<object>
            {
                new { DifficultLevel=1, Value="Dễ" },
                new { DifficultLevel=2, Value="Trung bình" },
                new { DifficultLevel=3, Value="Khó" },
                new { DifficultLevel=4, Value="Nâng cao" },
            };
            mCbbEditQuestionDifficultLevel.ValueMember = "DifficultLevel";
            mCbbEditQuestionDifficultLevel.DisplayMember = "Value";
            mCbbEditQuestionDifficultLevel.DataSource = difficulLevels;
            // --- Load detail question examcode
            bsDetailQuestionExamCodeList = new BindingSource();
            bsDetailQuestionExamCodeList.DataSource = ListDetailQuestionExamCode;
            mGridDetailQuestionExamCode.DataSource = bsDetailQuestionExamCodeList;
            // --- Approve question
            LoadApproveQuestion?.Invoke(this, null);
            bsApproveQuestionList = new BindingSource();
            bsApproveQuestionList.DataSource = ListQuestionDistributed;
            mGridApproveQuestion.DataSource = bsApproveQuestionList;
            // --- Add question
            mCbbAddQuestionDifficultLevel.ValueMember = "DifficultLevel";
            mCbbAddQuestionDifficultLevel.DisplayMember = "Value";
            mCbbAddQuestionDifficultLevel.DataSource = difficulLevels;

            mCbbAddQuestionSubject.DisplayMember = "SubjectName";
            mCbbAddQuestionSubject.DataSource = Subjects;
            if (mCbbAddQuestionSubject.SelectedItem != null)
            {
                var subject = mCbbAddQuestionSubject.SelectedItem as Subject;
                mTxtAddQuestionSubjectId.Text = subject.SubjectId;
                mTxtAddQuestionGradeId.Text = subject.GradeId.ToString();
            }
            // --- Import/Export question
            // DOIT LATER


            // Set data bindings
            SetHeaderMGridListQuestion();
            SetHeaderMGridApproveQuestion();
            SetDataBinding();


            // Register events
            // --- List question
            mBtnReloadListQuestion.Click += MBtnReloadListQuestion_Click;
            // --- Edit question
            mTileEditAnswer.Click += MTileEditAnswer_Click;
            mBtnSaveEditQuestion.Click += MBtnSaveEditQuestion_Click;
            // --- Detail question
            mTxtDetailQuestionId.TextChanged += MTxtDetailQuestionId_TextChanged;
            // --- Approve question
            mBtnApproveQuestion.Click += MBtnApproveQuestion_Click;
            // --- Add question
            mCbbAddQuestionSubject.SelectedIndexChanged += MCbbAddQuestionSubject_SelectedIndexChanged;
            mBtnAddQuestion.Click += MBtnAddQuestion_Click;
            // --- Import/Export question
            // DOIT LATER


            // Select tab first startup
            mTabQuestion.SelectTab(0);
        }


        // Tab question
        private void MBtnReloadListQuestion_Click(object sender, EventArgs e)
        {
            ReloadListQuestion?.Invoke(this, null);
            bsQuestionList.DataSource = ListQuestion;
        }

        private void MBtnSaveEditQuestion_Click(object sender, EventArgs e)
        {
            if (bsQuestionList.Count > 0)
            {
                EditQuestionId = int.Parse(mTxtEditQuestionId.Text);
                SaveEditQuestion?.Invoke(this, null);
            }
        }

        private void MTileEditAnswer_Click(object sender, EventArgs e)
        {
            if (bsQuestionList.Count > 0)
            {
                EditQuestionId = int.Parse(mTxtEditQuestionId.Text);
                var frmEditAnswer = new frmTeacherEditAnswer(EditQuestionId);
                frmEditAnswer.ShowDialog();
            }
        }

        private void MTxtDetailQuestionId_TextChanged(object sender, EventArgs e)
        {
            if (bsQuestionList.Count > 0)
            {
                EditQuestionId = int.Parse(mTxtDetailQuestionId.Text);
                LoadDetailQuestionExamCode?.Invoke(this, null);
                bsDetailQuestionExamCodeList.DataSource = ListDetailQuestionExamCode;
                SetHeaderMGridDetailQuestionExamCode();
            }
        }

        private void MBtnApproveQuestion_Click(object sender, EventArgs e)
        {
            if (mGridApproveQuestion.Rows.Count > 0)
            {
                ApproveQuestionId = (int)mGridApproveQuestion.SelectedRows[0].Cells[0].Value;
                ApproveQuestion?.Invoke(this, null);
                LoadApproveQuestion?.Invoke(this, null);
                bsApproveQuestionList.DataSource = ListQuestionDistributed;
            }
        }

        private void MCbbAddQuestionSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mCbbAddQuestionSubject.SelectedItem != null)
            {
                var subject = mCbbAddQuestionSubject.SelectedItem as Subject;
                mTxtAddQuestionSubjectId.Text = subject.SubjectId;
                mTxtAddQuestionGradeId.Text = subject.GradeId.ToString();
            }
        }

        private void MBtnAddQuestion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mTxtAddQuestionContent.Text) || mCbbAddQuestionSubject.SelectedItem == null)
            {
                MessageBox.Show("Không thể thêm câu hỏi vì chưa đủ dữ liệu!");
                return;
            }

            Question = new Question
            {
                Content = mTxtAddQuestionContent.Text,
                DifficultLevel = (int)mCbbAddQuestionDifficultLevel.SelectedValue,
                SubjectId = ((Subject)mCbbAddQuestionSubject.SelectedItem).SubjectId,
                GradeId = ((Subject)mCbbAddQuestionSubject.SelectedItem).GradeId,
                IsDistributed = false
            };

            AddQuestion?.Invoke(this, null);
        }
        #endregion

        #region ITeacherView implementations
        // Events
        public event EventHandler ReloadListQuestion;
        public event EventHandler SaveEditQuestion;
        public event EventHandler LoadDetailQuestionExamCode;
        public event EventHandler ApproveQuestion;
        public event EventHandler LoadApproveQuestion;
        public event EventHandler AddQuestion;

        // Get user information
        public Teacher CurrentUser { get; set; }
        public User CurrentUserInfo { get; set; }

        // Tab Question
        public IList<QuestionListViewModel> ListQuestion { get; set; }
        public int EditQuestionId { get; set; }
        public string EditQuestionMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã lưu câu hỏi!");
                }
                else
                {
                    MessageBox.Show("Lưu câu hỏi thất bại!");
                }
            }
        }
        // --- Detail question
        public IList<DetailQuestionExamCodeViewModel> ListDetailQuestionExamCode { get; set; }
        public int DetailQuestionId { get; set; }
        // --- Approve question
        public IList<QuestionDistribute> ListQuestionDistributed { get; set; }
        public int ApproveQuestionId { get; set; }
        public string ApproveQuestionMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã duyệt câu hỏi!");
                }
                else
                {
                    MessageBox.Show("Duyệt câu hỏi thất bại!");
                }
            }
        }
        // --- Add question
        public IList<Subject> Subjects { get; set; }
        public Question Question { get; set; }
        public string AddQuestionMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã thêm câu hỏi!");
                    mTxtAddQuestionContent.ResetText();
                    mCbbAddQuestionDifficultLevel.SelectedIndex = 0;
                    mCbbAddQuestionSubject.SelectedIndex = 0;
                    ReloadListQuestion?.Invoke(this, null);
                    bsQuestionList.DataSource = ListQuestion;
                }
                else
                {
                    MessageBox.Show("Thêm câu hỏi thất bại!");
                }
            }
        }
        // --- Import/Export question
        // DOIT LATER

        #endregion

        #region Utilities
        private void SetHeaderMGridListQuestion()
        {
            // Show header for mGridListQuestion
            mGridListQuestion.AutoGenerateColumns = false;

            mGridListQuestion.Columns[0].HeaderText = "Mã câu hỏi";
            mGridListQuestion.Columns[0].DataPropertyName = "QuestionId";

            mGridListQuestion.Columns[1].HeaderText = "Nội dung";
            mGridListQuestion.Columns[1].DataPropertyName = "Content";

            mGridListQuestion.Columns[2].HeaderText = "Mã môn học";
            mGridListQuestion.Columns[2].DataPropertyName = "SubjectId";

            mGridListQuestion.Columns[3].HeaderText = "Khối lớp";
            mGridListQuestion.Columns[3].DataPropertyName = "GradeId";

            mGridListQuestion.Columns[4].HeaderText = "Tên môn học";
            mGridListQuestion.Columns[4].DataPropertyName = "SubjectName";

            mGridListQuestion.Columns[5].HeaderText = "Độ khó";
            mGridListQuestion.Columns[5].DataPropertyName = "DifficultLevel";

            mGridListQuestion.Columns[6].HeaderText = "Câu hỏi được đóng góp";
            mGridListQuestion.Columns[6].DataPropertyName = "IsDistributed";

            foreach (DataGridViewColumn col in mGridListQuestion.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetHeaderMGridDetailQuestionExamCode()
        {
            // Show header for mGridDetailQuestionExamCode 
            mGridDetailQuestionExamCode.AutoGenerateColumns = false;

            mGridDetailQuestionExamCode.Columns[0].HeaderText = "Mã đề thi";
            mGridDetailQuestionExamCode.Columns[0].DataPropertyName = "ExamCodeId";

            mGridDetailQuestionExamCode.Columns[1].HeaderText = "Số câu hỏi";
            mGridDetailQuestionExamCode.Columns[1].DataPropertyName = "NumberOfQuestions";

            mGridDetailQuestionExamCode.Columns[2].HeaderText = "Mã môn học";
            mGridDetailQuestionExamCode.Columns[2].DataPropertyName = "SubjectId";

            mGridDetailQuestionExamCode.Columns[3].HeaderText = "Khối lớp";
            mGridDetailQuestionExamCode.Columns[3].DataPropertyName = "GradeId";

            mGridDetailQuestionExamCode.Columns[4].HeaderText = "Tên môn học";
            mGridDetailQuestionExamCode.Columns[4].DataPropertyName = "SubjectName";

            mGridDetailQuestionExamCode.Columns[5].HeaderText = "Đề thi thử";
            mGridDetailQuestionExamCode.Columns[5].DataPropertyName = "IsPracticeExam";

            foreach (DataGridViewColumn col in mGridDetailQuestionExamCode.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetHeaderMGridApproveQuestion()
        {
            // Show header for mGridApproveQuestion 
            mGridApproveQuestion.AutoGenerateColumns = false;

            mGridApproveQuestion.Columns[0].HeaderText = "Mã câu hỏi đóng góp";
            mGridApproveQuestion.Columns[0].DataPropertyName = "QuestionDistributeId";

            mGridApproveQuestion.Columns[1].HeaderText = "Mã học sinh";
            mGridApproveQuestion.Columns[1].DataPropertyName = "StudentId";

            mGridApproveQuestion.Columns[2].HeaderText = "Nội dung";
            mGridApproveQuestion.Columns[2].DataPropertyName = "Content";

            mGridApproveQuestion.Columns[3].Visible = false;

            mGridApproveQuestion.Columns[4].HeaderText = "Mã môn học";
            mGridApproveQuestion.Columns[4].DataPropertyName = "SubjectId";

            mGridApproveQuestion.Columns[5].HeaderText = "Khổi lớp";
            mGridApproveQuestion.Columns[5].DataPropertyName = "GradeId";

            mGridApproveQuestion.Columns[6].HeaderText = "Độ khó";
            mGridApproveQuestion.Columns[6].DataPropertyName = "DifficultLevel";

            mGridApproveQuestion.Columns[7].Visible = false;
            mGridApproveQuestion.Columns[8].Visible = false;
            mGridApproveQuestion.Columns[9].Visible = false;

            foreach (DataGridViewColumn col in mGridApproveQuestion.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetDataBinding()
        {
            // Tab Question - EditQuestion
            mTxtEditQuestionContent.DataBindings.Add("Text", bsQuestionList, "Content");
            mTxtEditQuestionId.DataBindings.Add("Text", bsQuestionList, "QuestionId");
            mTxtEditQuestionSubjectId.DataBindings.Add("Text", bsQuestionList, "SubjectId");
            mTxtEditQuestionSubjectName.DataBindings.Add("Text", bsQuestionList, "SubjectName");
            mTxtEditQuestionGradeId.DataBindings.Add("Text", bsQuestionList, "GradeId");
            mCbbEditQuestionDifficultLevel.DataBindings.Add("SelectedValue", bsQuestionList, "DifficultLevel", true, DataSourceUpdateMode.OnPropertyChanged);
            mToggleEditQuestionIsDistributed.DataBindings.Add("Checked", bsQuestionList, "IsDistributed");

            // Tab Question - DetailQuestionExamCode
            mTxtDetailQuestionId.DataBindings.Add("Text", bsQuestionList, "QuestionId");
            mTxtDetailQuestionSubjectId.DataBindings.Add("Text", bsQuestionList, "SubjectId");
            mTxtDetailQuestionSubjectName.DataBindings.Add("Text", bsQuestionList, "SubjectName");
            mTxtDetailQuestionGradeId.DataBindings.Add("Text", bsQuestionList, "GradeId");
        }
        #endregion
    }
}
