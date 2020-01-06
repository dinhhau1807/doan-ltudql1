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
    public partial class frmTeacherEditExamCodeQuestions : MetroFramework.Forms.MetroForm, ITeacherEditExamCodeQuestionsView
    {
        TeacherEditExamCodeQuestionPresenter presenter;
        BindingSource bsListQuestions;
        BindingSource bsListQuestionsAdded;

        public frmTeacherEditExamCodeQuestions(string teacherId, ExamCodeListViewModel examCode, IList<int> examCodeQuestionIds)
        {
            TeacherId = teacherId;
            ExamCode = examCode;
            ExamCodeQuestionIds = examCodeQuestionIds;
            InitializeComponent();
            Load += FrmEditExamCodeQuestions_Load;
            FormClosing += FrmEditExamCodeQuestions_FormClosing;
        }


        #region Events
        private void FrmEditExamCodeQuestions_Load(object sender, EventArgs e)
        {
            presenter = new TeacherEditExamCodeQuestionPresenter(this);
            Text = $"Đề thi {ExamCode.ExamCodeId}";

            bsListQuestions = new BindingSource();
            bsListQuestions.DataSource = Questions;
            bsListQuestionsAdded = new BindingSource();
            bsListQuestionsAdded.DataSource = QuestionsAdded;

            // Set data source
            mGridListQuestions.DataSource = bsListQuestions;
            mGridListQuestionsAdded.DataSource = bsListQuestionsAdded;

            // Set header
            SetHeaderMGridListQuestions();
            SetHeaderMGridListQuestionsAdded();

            // Register events
            mBtnAddQuestion.Click += MBtnAddQuestion_Click;
            mBtnDeleteQuestion.Click += MBtnDeleteQuestion_Click;

            // Startup
            mTabEditExamCodeQuestions.SelectTab(1);
        }

        private void MBtnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (QuestionsAdded.Count > 0)
            {
                var question = (Question)mGridListQuestionsAdded.SelectedRows[0].DataBoundItem;
                DeleteQuestion.Invoke(question, null);
            }
        }

        private void MBtnAddQuestion_Click(object sender, EventArgs e)
        {
            if (Questions.Count > 0)
            {
                var question = (Question)mGridListQuestions.SelectedRows[0].DataBoundItem;
                AddQuestion?.Invoke(question, null);
            }
        }

       
        private void FrmEditExamCodeQuestions_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReloadListExamCodeQuestionIds?.Invoke(this, null);
        }
        #endregion


        #region IEditExamCodeQuestionsView implementations
        public event EventHandler ReloadListExamCodeQuestionIds;
        public event EventHandler AddQuestion;
        public event EventHandler DeleteQuestion;

        public string TeacherId { get; set; }
        public ExamCodeListViewModel ExamCode { get; set; }
        public IList<int> ExamCodeQuestionIds { get; set; }
        public IList<Question> Questions { get; set; }
        public IList<Question> QuestionsAdded { get; set; }
        public string AddQuestionMessage {
            set
            {
                if (value == "Succeed")
                {
                    ReloadList();
                }
                if (value == "Maximized")
                {
                    MessageBox.Show("Số lượng câu hỏi đã đạt mức tối đa");
                }
                if (value == "Failed")
                {
                    MessageBox.Show("Không có câu hỏi để thêm");
                }
            }
        }
        public string DeleteQuestionMessage {
            set
            {
                if (value == "Succeed")
                {
                    ReloadList();
                }
                if (value == "Failed")
                {
                    MessageBox.Show("Không có câu hỏi để xoá");
                }
            }
        }
        #endregion


        #region Ultilities
        private void SetHeaderMGridListQuestions()
        {
            // Show header for mGridListQuestion
            mGridListQuestions.AutoGenerateColumns = false;

            mGridListQuestions.Columns[0].HeaderText = "Mã câu hỏi";
            mGridListQuestions.Columns[0].DataPropertyName = "QuestionId";

            mGridListQuestions.Columns[1].HeaderText = "Nội dung";
            mGridListQuestions.Columns[1].DataPropertyName = "Content";

            mGridListQuestions.Columns[2].Visible = false;

            mGridListQuestions.Columns[3].HeaderText = "Mã môn học";
            mGridListQuestions.Columns[3].DataPropertyName = "SubjectId";

            mGridListQuestions.Columns[4].HeaderText = "Khối lớp";
            mGridListQuestions.Columns[4].DataPropertyName = "GradeId";

            mGridListQuestions.Columns[5].HeaderText = "Độ khó";
            mGridListQuestions.Columns[5].DataPropertyName = "DifficultLevel";

            mGridListQuestions.Columns[6].HeaderText = "Câu hỏi được đóng góp";
            mGridListQuestions.Columns[6].DataPropertyName = "IsDistributed";

            mGridListQuestions.Columns[7].Visible = false;
            mGridListQuestions.Columns[8].Visible = false;
            mGridListQuestions.Columns[9].Visible = false;

            foreach (DataGridViewColumn col in mGridListQuestions.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetHeaderMGridListQuestionsAdded()
        {
            // Show header for mGridListQuestion
            mGridListQuestionsAdded.AutoGenerateColumns = false;

            mGridListQuestionsAdded.Columns[0].HeaderText = "Mã câu hỏi";
            mGridListQuestionsAdded.Columns[0].DataPropertyName = "QuestionId";

            mGridListQuestionsAdded.Columns[1].HeaderText = "Nội dung";
            mGridListQuestionsAdded.Columns[1].DataPropertyName = "Content";

            mGridListQuestionsAdded.Columns[2].Visible = false;

            mGridListQuestionsAdded.Columns[3].HeaderText = "Mã môn học";
            mGridListQuestionsAdded.Columns[3].DataPropertyName = "SubjectId";

            mGridListQuestionsAdded.Columns[4].HeaderText = "Khối lớp";
            mGridListQuestionsAdded.Columns[4].DataPropertyName = "GradeId";

            mGridListQuestionsAdded.Columns[5].HeaderText = "Độ khó";
            mGridListQuestionsAdded.Columns[5].DataPropertyName = "DifficultLevel";

            mGridListQuestionsAdded.Columns[6].HeaderText = "Câu hỏi được đóng góp";
            mGridListQuestionsAdded.Columns[6].DataPropertyName = "IsDistributed";

            mGridListQuestionsAdded.Columns[7].Visible = false;
            mGridListQuestionsAdded.Columns[8].Visible = false;
            mGridListQuestionsAdded.Columns[9].Visible = false;

            foreach (DataGridViewColumn col in mGridListQuestionsAdded.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ReloadList()
        {
            bsListQuestions.CurrencyManager.Refresh();
            bsListQuestionsAdded.CurrencyManager.Refresh();

            mGridListQuestionsAdded.DataSource = null;
            mGridListQuestionsAdded.DataSource = bsListQuestionsAdded;

            mGridListQuestions.DataSource = null;
            mGridListQuestions.DataSource = bsListQuestions;
        }
        #endregion
    }
}
