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
    public partial class frmTeacherEditAnswer : MetroFramework.Forms.MetroForm, ITeacherEditAnswerView
    {
        TeacherEditAnswerPresenter presenter;
        BindingSource bsListAnswer;


        public frmTeacherEditAnswer(int questionId)
        {
            InitializeComponent();
            Load += FrmEditAnswer_Load;
            Text = "Câu hỏi " + questionId;
            QuestionId = questionId;
        }

        #region Events
        private void FrmEditAnswer_Load(object sender, EventArgs e)
        {
            presenter = new TeacherEditAnswerPresenter(this);

            bsListAnswer = new BindingSource();
            bsListAnswer.DataSource = Answers;
            mGridListAnswer.DataSource = bsListAnswer;

            SetDataBinding();

            mTxtAddAnswer.Text = "";

            // Register events
            mBtnReloadListAnswer.Click += MBtnReloadListAnswer_Click;
            mBtnDeleteAnswer.Click += MBtnDeleteAnswer_Click;
            mBtnSaveEditAnswer.Click += MBtnSaveEditAnswer_Click;
            mBtnAddAnswer.Click += MBtnAddAnswer_Click;

            // Startup
            mTabAnswer.SelectTab(0);
        }

        private void MBtnAddAnswer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mTxtAddAnswer.Text))
            {
                Answer = new Answer
                {
                    QuestionId = this.QuestionId,
                    Content = mTxtAddAnswer.Text,
                    IsCorrect = mToggleAddAnswerIsCorrect.Checked
                };
                AddAnswer?.Invoke(this, null);
            }
            ReloadListAnswer?.Invoke(this, null);
            bsListAnswer.DataSource = Answers;
        }

        private void MBtnSaveEditAnswer_Click(object sender, EventArgs e)
        {
            var check = int.TryParse(mTxtEditAnswerId.Text, out int result);
            if (check)
            {
                Answer = new Answer
                {
                    AnswerId = int.Parse(mTxtEditAnswerId.Text),
                    QuestionId = int.Parse(mTxtEditAnswerQuestionId.Text),
                    Content = mTxtEditAnswerContent.Text,
                    IsCorrect = mToggleEditAnswerIsCorrect.Checked
                };

                SaveEditAnswer?.Invoke(this, null);
            }
            ReloadListAnswer?.Invoke(this, null);
            bsListAnswer.DataSource = Answers;
        }

        private void MBtnReloadListAnswer_Click(object sender, EventArgs e)
        {
            ReloadListAnswer?.Invoke(this, null);
            bsListAnswer.DataSource = Answers;
        }

        private void MBtnDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (bsListAnswer.Count > 0)
            {
                DeleteAnswerId = (int)mGridListAnswer.SelectedRows[0].Cells[0].Value;
                DeleteAnswer?.Invoke(this, null);
            }
        }
        #endregion

        #region IEditAnswerView implementations
        public event EventHandler ReloadListAnswer;
        public event EventHandler SaveEditAnswer;
        public event EventHandler DeleteAnswer;
        public event EventHandler AddAnswer;

        public int QuestionId { get; set; }
        public IList<Answer> Answers { get; set; }
        public Answer Answer { get; set; }
        public int DeleteAnswerId { get; set; }
        public string EditAnswerMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã lưu chỉnh sửa!");
                }
                else
                {
                    MessageBox.Show("Lưu chỉnh sửa thất bại!");
                }
            }
        }
        public string DeleteAnswerMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã xoá câu trả lời!");
                    mBtnReloadListAnswer.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại!");
                }
            }
        }

        public string AddAnswerMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã thêm câu trả lời!");
                    mTxtAddAnswer.Text = "";
                    mToggleAddAnswerIsCorrect.Checked = false;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }
        #endregion

        #region Ultilities
        private void SetDataBinding()
        {
            mTxtEditAnswerQuestionId.DataBindings.Add("Text", bsListAnswer, "QuestionId");
            mTxtEditAnswerContent.DataBindings.Add("Text", bsListAnswer, "Content");
            mTxtEditAnswerId.DataBindings.Add("Text", bsListAnswer, "AnswerId");
            mToggleEditAnswerIsCorrect.DataBindings.Add("Checked", bsListAnswer, "IsCorrect", true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #endregion
    }
}
