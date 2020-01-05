namespace DoAnLTUDQL1.Views.TeacherView
{
    partial class frmTeacherStudent
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
            this.mTabExam = new MetroFramework.Controls.MetroTabControl();
            this.mTabStudentStatistic = new MetroFramework.Controls.MetroTabPage();
            this.mbtnStudentResult = new MetroFramework.Controls.MetroButton();
            this.mcbStudentId = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rpvStudent = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mTabExamStatistic = new System.Windows.Forms.TabPage();
            this.mbtnExamResult = new MetroFramework.Controls.MetroButton();
            this.mcbExamId = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.rpvExam = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mTabQuestionStatistic = new System.Windows.Forms.TabPage();
            this.mbtnQuestionResult = new MetroFramework.Controls.MetroButton();
            this.mcbQuestionId = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.rpvQuestion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mTabExam.SuspendLayout();
            this.mTabStudentStatistic.SuspendLayout();
            this.mTabExamStatistic.SuspendLayout();
            this.mTabQuestionStatistic.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabExam
            // 
            this.mTabExam.Controls.Add(this.mTabStudentStatistic);
            this.mTabExam.Controls.Add(this.mTabExamStatistic);
            this.mTabExam.Controls.Add(this.mTabQuestionStatistic);
            this.mTabExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabExam.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mTabExam.Location = new System.Drawing.Point(20, 60);
            this.mTabExam.Name = "mTabExam";
            this.mTabExam.SelectedIndex = 2;
            this.mTabExam.Size = new System.Drawing.Size(928, 564);
            this.mTabExam.TabIndex = 2;
            this.mTabExam.UseSelectable = true;
            // 
            // mTabStudentStatistic
            // 
            this.mTabStudentStatistic.Controls.Add(this.mbtnStudentResult);
            this.mTabStudentStatistic.Controls.Add(this.mcbStudentId);
            this.mTabStudentStatistic.Controls.Add(this.metroLabel1);
            this.mTabStudentStatistic.Controls.Add(this.rpvStudent);
            this.mTabStudentStatistic.HorizontalScrollbarBarColor = true;
            this.mTabStudentStatistic.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabStudentStatistic.HorizontalScrollbarSize = 10;
            this.mTabStudentStatistic.Location = new System.Drawing.Point(4, 38);
            this.mTabStudentStatistic.Name = "mTabStudentStatistic";
            this.mTabStudentStatistic.Size = new System.Drawing.Size(920, 522);
            this.mTabStudentStatistic.TabIndex = 0;
            this.mTabStudentStatistic.Text = "Thống kê học sinh";
            this.mTabStudentStatistic.VerticalScrollbarBarColor = true;
            this.mTabStudentStatistic.VerticalScrollbarHighlightOnWheel = false;
            this.mTabStudentStatistic.VerticalScrollbarSize = 10;
            // 
            // mbtnStudentResult
            // 
            this.mbtnStudentResult.Location = new System.Drawing.Point(667, 43);
            this.mbtnStudentResult.Name = "mbtnStudentResult";
            this.mbtnStudentResult.Size = new System.Drawing.Size(114, 30);
            this.mbtnStudentResult.TabIndex = 5;
            this.mbtnStudentResult.Text = "Xem kết quả";
            this.mbtnStudentResult.UseSelectable = true;
            // 
            // mcbStudentId
            // 
            this.mcbStudentId.FormattingEnabled = true;
            this.mcbStudentId.ItemHeight = 23;
            this.mcbStudentId.Location = new System.Drawing.Point(290, 44);
            this.mcbStudentId.Name = "mcbStudentId";
            this.mcbStudentId.Size = new System.Drawing.Size(371, 29);
            this.mcbStudentId.TabIndex = 4;
            this.mcbStudentId.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(194, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(82, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Mã học sinh:";
            // 
            // rpvStudent
            // 
            this.rpvStudent.LocalReport.ReportEmbeddedResource = "DoAnLTUDQL1.Reports.StudentRP.rdlc";
            this.rpvStudent.Location = new System.Drawing.Point(101, 89);
            this.rpvStudent.Name = "rpvStudent";
            this.rpvStudent.ServerReport.BearerToken = null;
            this.rpvStudent.Size = new System.Drawing.Size(725, 393);
            this.rpvStudent.TabIndex = 2;
            // 
            // mTabExamStatistic
            // 
            this.mTabExamStatistic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mTabExamStatistic.Controls.Add(this.mbtnExamResult);
            this.mTabExamStatistic.Controls.Add(this.mcbExamId);
            this.mTabExamStatistic.Controls.Add(this.metroLabel2);
            this.mTabExamStatistic.Controls.Add(this.rpvExam);
            this.mTabExamStatistic.Location = new System.Drawing.Point(4, 38);
            this.mTabExamStatistic.Name = "mTabExamStatistic";
            this.mTabExamStatistic.Size = new System.Drawing.Size(920, 522);
            this.mTabExamStatistic.TabIndex = 1;
            this.mTabExamStatistic.Text = "Thống kê kì thi";
            // 
            // mbtnExamResult
            // 
            this.mbtnExamResult.Location = new System.Drawing.Point(676, 38);
            this.mbtnExamResult.Name = "mbtnExamResult";
            this.mbtnExamResult.Size = new System.Drawing.Size(114, 30);
            this.mbtnExamResult.TabIndex = 9;
            this.mbtnExamResult.Text = "Xem kết quả";
            this.mbtnExamResult.UseSelectable = true;
            this.mbtnExamResult.Click += new System.EventHandler(this.mbtnExamResult_Click);
            // 
            // mcbExamId
            // 
            this.mcbExamId.FormattingEnabled = true;
            this.mcbExamId.ItemHeight = 23;
            this.mcbExamId.Location = new System.Drawing.Point(299, 39);
            this.mcbExamId.Name = "mcbExamId";
            this.mcbExamId.Size = new System.Drawing.Size(371, 29);
            this.mcbExamId.TabIndex = 8;
            this.mcbExamId.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(203, 44);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Mã kì thi";
            // 
            // rpvExam
            // 
            this.rpvExam.LocalReport.ReportEmbeddedResource = "DoAnLTUDQL1.Reports.ExamRP.rdlc";
            this.rpvExam.Location = new System.Drawing.Point(130, 74);
            this.rpvExam.Name = "rpvExam";
            this.rpvExam.ServerReport.BearerToken = null;
            this.rpvExam.Size = new System.Drawing.Size(660, 413);
            this.rpvExam.TabIndex = 6;
            // 
            // mTabQuestionStatistic
            // 
            this.mTabQuestionStatistic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mTabQuestionStatistic.Controls.Add(this.mbtnQuestionResult);
            this.mTabQuestionStatistic.Controls.Add(this.mcbQuestionId);
            this.mTabQuestionStatistic.Controls.Add(this.metroLabel3);
            this.mTabQuestionStatistic.Controls.Add(this.rpvQuestion);
            this.mTabQuestionStatistic.Location = new System.Drawing.Point(4, 38);
            this.mTabQuestionStatistic.Name = "mTabQuestionStatistic";
            this.mTabQuestionStatistic.Size = new System.Drawing.Size(920, 522);
            this.mTabQuestionStatistic.TabIndex = 2;
            this.mTabQuestionStatistic.Text = "Thống kê câu hỏi";
            // 
            // mbtnQuestionResult
            // 
            this.mbtnQuestionResult.Location = new System.Drawing.Point(676, 38);
            this.mbtnQuestionResult.Name = "mbtnQuestionResult";
            this.mbtnQuestionResult.Size = new System.Drawing.Size(114, 30);
            this.mbtnQuestionResult.TabIndex = 9;
            this.mbtnQuestionResult.Text = "Xem kết quả";
            this.mbtnQuestionResult.UseSelectable = true;
            // 
            // mcbQuestionId
            // 
            this.mcbQuestionId.FormattingEnabled = true;
            this.mcbQuestionId.ItemHeight = 23;
            this.mcbQuestionId.Location = new System.Drawing.Point(299, 39);
            this.mcbQuestionId.Name = "mcbQuestionId";
            this.mcbQuestionId.Size = new System.Drawing.Size(371, 29);
            this.mcbQuestionId.TabIndex = 8;
            this.mcbQuestionId.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(203, 44);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Mã câu hỏi";
            // 
            // rpvQuestion
            // 
            this.rpvQuestion.LocalReport.ReportEmbeddedResource = "DoAnLTUDQL1.Reports.QuestionRP.rdlc";
            this.rpvQuestion.Location = new System.Drawing.Point(130, 74);
            this.rpvQuestion.Name = "rpvQuestion";
            this.rpvQuestion.ServerReport.BearerToken = null;
            this.rpvQuestion.Size = new System.Drawing.Size(660, 364);
            this.rpvQuestion.TabIndex = 6;
            // 
            // frmTeacherStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 644);
            this.Controls.Add(this.mTabExam);
            this.Name = "frmTeacherStudent";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Quản lý học sinh";
            this.Load += new System.EventHandler(this.FrmTeacherStudent_Load);
            this.mTabExam.ResumeLayout(false);
            this.mTabStudentStatistic.ResumeLayout(false);
            this.mTabStudentStatistic.PerformLayout();
            this.mTabExamStatistic.ResumeLayout(false);
            this.mTabExamStatistic.PerformLayout();
            this.mTabQuestionStatistic.ResumeLayout(false);
            this.mTabQuestionStatistic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabExam;
        private MetroFramework.Controls.MetroTabPage mTabStudentStatistic;
        private System.Windows.Forms.TabPage mTabExamStatistic;
        private System.Windows.Forms.TabPage mTabQuestionStatistic;
        private Microsoft.Reporting.WinForms.ReportViewer rpvStudent;
        private MetroFramework.Controls.MetroButton mbtnStudentResult;
        private MetroFramework.Controls.MetroComboBox mcbStudentId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mbtnExamResult;
        private MetroFramework.Controls.MetroComboBox mcbExamId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvExam;
        private MetroFramework.Controls.MetroButton mbtnQuestionResult;
        private MetroFramework.Controls.MetroComboBox mcbQuestionId;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private Microsoft.Reporting.WinForms.ReportViewer rpvQuestion;
    }
}