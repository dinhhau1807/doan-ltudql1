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
    public partial class frmEditExamCodeQuestions : MetroFramework.Forms.MetroForm, IEditExamCodeQuestionsView
    {
        EditExamCodeQuestionPresenter presenter;
        BindingSource bsListQuestions;
        BindingSource bsListQuestionsAdded;

        public frmEditExamCodeQuestions(string teacherId, ExamCodeListViewModel examCode, IList<int> examCodeQuestionIds)
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
            presenter = new EditExamCodeQuestionPresenter(this);
            Text = $"Đề thi {ExamCode.ExamCodeId}";

            bsListQuestions = new BindingSource();
            bsListQuestions.DataSource = Questions;
            bsListQuestionsAdded = new BindingSource();
            bsListQuestionsAdded.DataSource = QuestionsAdded;

            mGridListQuestions.DataSource = bsListQuestions;
            mGridListQuestionsAdded.DataSource = bsListQuestionsAdded;

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
