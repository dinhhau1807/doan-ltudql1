using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnLTUDQL1.Presenters;

namespace DoAnLTUDQL1.Views.Teacher
{
    public partial class frmTeacher : MetroFramework.Forms.MetroForm
    {
        TeacherPresenter teacherPresenter;
        User CurrentUser;
        int NumOfQuestion = 0;
        List<int> listLevel;
        public frmTeacher(User user)
        {
            CurrentUser = user;
            
            InitializeComponent();
            LoadListExamCode();
            btnSaveData.Enabled = false;

        }

        private void frmTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void LoadListExamCode()
        {
            gvListExamCode.Rows.Clear();
            teacherPresenter = new TeacherPresenter(CurrentUser);
            var listExamCode = teacherPresenter.LoadListExamCode(-1);
            foreach (usp_LoadListExamCodeResult item in listExamCode)
            {
                gvListExamCode.Rows.Add(item.ExamCodeId, item.SubjectName, item.NumberOfQuestions.ToString(), item.IsPracticeExam.Value ? "Thi thử" : "Thi thật",item.GradeId.ToString(),item.SubjectId);
            }
            LoadQuestion(0);

        }
       
        private void gvListExamCode_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                LoadQuestion(index);
            }
        }
        private void LoadQuestion(int index)
        {
            btnSaveData.Enabled = false;
            listLevel = new List<int>();
            teacherPresenter = new TeacherPresenter(CurrentUser);

            gvListQuestion.DataSource = null;
            gvListQuestion.Rows.Clear();
            var ExamCodeID = gvListExamCode.Rows[index].Cells[0].Value.ToString();
            NumOfQuestion = Convert.ToInt32(gvListExamCode.Rows[index].Cells[2].Value);
            int GradeID = Convert.ToInt32(gvListExamCode.Rows[index].Cells[4].Value.ToString());
            string SubjectID = gvListExamCode.Rows[index].Cells[5].Value.ToString();

            var listQuestion = teacherPresenter.GetListQuestion(SubjectID, GradeID);
            var listExamQuestion = teacherPresenter.GetListExamQuestionByExamCode(ExamCodeID);
            foreach (Question item in listQuestion)
            {
                if (!listLevel.Any(i => i == item.DifficultLevel))
                    listLevel.Add(item.DifficultLevel.Value);
                bool isMap = listExamQuestion.Any(i => i.QuestionId == item.QuestionId);
                gvListQuestion.Rows.Add(isMap, item.QuestionId, item.Content, item.DifficultLevel, item.IsMultiSelect);
            }

         
        }
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        private void ClearQuestion()
        {
            for (int i = 0; i < gvListQuestion.Rows.Count; i++)
                gvListQuestion.Rows[i].Cells[0].Value = false;
        }
        private void btnRandQuestion_Click(object sender, EventArgs e)
        {
            ClearQuestion();
            btnSaveData.Enabled = true;
           
            List<int> rdQuestion = new List<int>();
            List<int> rdLevel = new List<int>();
            while (rdQuestion.Count() < NumOfQuestion)
            {
                int i = RandomNumber(0, gvListQuestion.Rows.Count);
                if (!rdQuestion.Any(k => k == i))
                {
                    int level = Convert.ToInt32(gvListQuestion.Rows[i].Cells[3].Value);
                    if (!rdLevel.Any(k => k == level))
                    {
                        rdLevel.Add(level);
                        rdQuestion.Add(i);
                        gvListQuestion.Rows[i].Cells[0].Value = true;
                    }
                    if (rdLevel.Count == listLevel.Count)
                        rdLevel = new List<int>();
                    
                }
                   
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListExamCode();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            DataGridViewRow drExamCode = gvListExamCode.SelectedRows[0];
            string ExamCodeID = drExamCode.Cells[0].Value.ToString();
           
            List<int> listQuestionID = new List<int>();
            foreach (DataGridViewRow dr in gvListQuestion.Rows)
            {
                if(Convert.ToBoolean(dr.Cells[0].Value))
                {
                    listQuestionID.Add(Convert.ToInt32(dr.Cells[1].Value));
                }
            }
            if (listQuestionID.Count > NumOfQuestion)
                MessageBox.Show("Không thể chọn vượt quá số lượng câu hỏi quy định.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                teacherPresenter = new TeacherPresenter(CurrentUser);
                if (teacherPresenter.InsertExamQuestion(listQuestionID, ExamCodeID))
                {
                    MessageBox.Show("Lưu thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListExamCode();
                }
                else
                    MessageBox.Show("Lưu thất bại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
