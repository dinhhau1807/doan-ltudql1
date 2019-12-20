namespace DoAnLTUDQL1.Views.Teacher
{
    partial class frmTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btnRandQuestion = new MetroFramework.Controls.MetroButton();
            this.gvListQuestion = new MetroFramework.Controls.MetroGrid();
            this.gvListExamCode = new MetroFramework.Controls.MetroGrid();
            this.ExamCodeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumofQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPracticeExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckChoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifficultLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsMultiSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSaveData = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvListQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListExamCode)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(2, 19);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(908, 491);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btnSaveData);
            this.metroTabPage1.Controls.Add(this.btnRefresh);
            this.metroTabPage1.Controls.Add(this.btnRandQuestion);
            this.metroTabPage1.Controls.Add(this.gvListQuestion);
            this.metroTabPage1.Controls.Add(this.gvListExamCode);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(900, 449);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Soạn đề thi";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // btnRandQuestion
            // 
            this.btnRandQuestion.Location = new System.Drawing.Point(510, 21);
            this.btnRandQuestion.Name = "btnRandQuestion";
            this.btnRandQuestion.Size = new System.Drawing.Size(125, 57);
            this.btnRandQuestion.TabIndex = 5;
            this.btnRandQuestion.Text = "Chọn tự động";
            this.btnRandQuestion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRandQuestion.UseSelectable = true;
            this.btnRandQuestion.Click += new System.EventHandler(this.btnRandQuestion_Click);
            // 
            // gvListQuestion
            // 
            this.gvListQuestion.AllowUserToAddRows = false;
            this.gvListQuestion.AllowUserToDeleteRows = false;
            this.gvListQuestion.AllowUserToResizeRows = false;
            this.gvListQuestion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvListQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvListQuestion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvListQuestion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvListQuestion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.gvListQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ckChoice,
            this.QuestionID,
            this.QuestionContent,
            this.DifficultLevel,
            this.IsMultiSelect});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvListQuestion.DefaultCellStyle = dataGridViewCellStyle20;
            this.gvListQuestion.EnableHeadersVisualStyles = false;
            this.gvListQuestion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvListQuestion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvListQuestion.Location = new System.Drawing.Point(17, 162);
            this.gvListQuestion.MultiSelect = false;
            this.gvListQuestion.Name = "gvListQuestion";
            this.gvListQuestion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvListQuestion.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.gvListQuestion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvListQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvListQuestion.Size = new System.Drawing.Size(812, 284);
            this.gvListQuestion.TabIndex = 4;
            // 
            // gvListExamCode
            // 
            this.gvListExamCode.AllowUserToAddRows = false;
            this.gvListExamCode.AllowUserToDeleteRows = false;
            this.gvListExamCode.AllowUserToResizeRows = false;
            this.gvListExamCode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvListExamCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvListExamCode.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvListExamCode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvListExamCode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.gvListExamCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvListExamCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExamCodeID,
            this.SubjectName,
            this.NumofQuestion,
            this.IsPracticeExam,
            this.GradeID,
            this.SubjectID});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvListExamCode.DefaultCellStyle = dataGridViewCellStyle23;
            this.gvListExamCode.EnableHeadersVisualStyles = false;
            this.gvListExamCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvListExamCode.GridColor = System.Drawing.Color.MintCream;
            this.gvListExamCode.Location = new System.Drawing.Point(17, 6);
            this.gvListExamCode.Name = "gvListExamCode";
            this.gvListExamCode.ReadOnly = true;
            this.gvListExamCode.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvListExamCode.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.gvListExamCode.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvListExamCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvListExamCode.Size = new System.Drawing.Size(469, 150);
            this.gvListExamCode.TabIndex = 3;
            this.gvListExamCode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvListExamCode_CellClick);
            // 
            // ExamCodeID
            // 
            this.ExamCodeID.HeaderText = "Mã đề";
            this.ExamCodeID.Name = "ExamCodeID";
            this.ExamCodeID.ReadOnly = true;
            // 
            // SubjectName
            // 
            this.SubjectName.HeaderText = "Môn";
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.ReadOnly = true;
            // 
            // NumofQuestion
            // 
            this.NumofQuestion.HeaderText = "Số câu hỏi";
            this.NumofQuestion.Name = "NumofQuestion";
            this.NumofQuestion.ReadOnly = true;
            // 
            // IsPracticeExam
            // 
            this.IsPracticeExam.HeaderText = "Loại hình";
            this.IsPracticeExam.Name = "IsPracticeExam";
            this.IsPracticeExam.ReadOnly = true;
            // 
            // GradeID
            // 
            this.GradeID.HeaderText = "GradeID";
            this.GradeID.Name = "GradeID";
            this.GradeID.ReadOnly = true;
            this.GradeID.Visible = false;
            // 
            // SubjectID
            // 
            this.SubjectID.HeaderText = "SubjectID";
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.ReadOnly = true;
            this.SubjectID.Visible = false;
            // 
            // ckChoice
            // 
            this.ckChoice.Frozen = true;
            this.ckChoice.HeaderText = "Chọn";
            this.ckChoice.Name = "ckChoice";
            // 
            // QuestionID
            // 
            this.QuestionID.HeaderText = "QuestionID";
            this.QuestionID.Name = "QuestionID";
            this.QuestionID.ReadOnly = true;
            this.QuestionID.Visible = false;
            // 
            // QuestionContent
            // 
            this.QuestionContent.HeaderText = "Nội dung câu hỏi";
            this.QuestionContent.Name = "QuestionContent";
            this.QuestionContent.ReadOnly = true;
            this.QuestionContent.Width = 400;
            // 
            // DifficultLevel
            // 
            this.DifficultLevel.HeaderText = "Mức độ câu hỏi";
            this.DifficultLevel.Name = "DifficultLevel";
            this.DifficultLevel.ReadOnly = true;
            this.DifficultLevel.Width = 150;
            // 
            // IsMultiSelect
            // 
            this.IsMultiSelect.HeaderText = "Cho chọn nhiều";
            this.IsMultiSelect.Name = "IsMultiSelect";
            this.IsMultiSelect.ReadOnly = true;
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveData.Location = new System.Drawing.Point(510, 84);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(125, 57);
            this.btnSaveData.TabIndex = 5;
            this.btnSaveData.Text = "Lưu";
            this.btnSaveData.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSaveData.UseSelectable = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(641, 58);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 57);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 514);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmTeacher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeacher_FormClosing);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvListQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListExamCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroGrid gvListExamCode;
        private MetroFramework.Controls.MetroGrid gvListQuestion;
        private MetroFramework.Controls.MetroButton btnRandQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamCodeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumofQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPracticeExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ckChoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifficultLevel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsMultiSelect;
        private MetroFramework.Controls.MetroButton btnSaveData;
        private MetroFramework.Controls.MetroButton btnRefresh;
    }
}