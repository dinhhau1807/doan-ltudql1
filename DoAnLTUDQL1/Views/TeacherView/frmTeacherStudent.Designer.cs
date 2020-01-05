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
            this.mTabExamStatistic = new System.Windows.Forms.TabPage();
            this.mTabQuestionStatistic = new System.Windows.Forms.TabPage();
            this.mTabExam.SuspendLayout();
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
            this.mTabExam.SelectedIndex = 1;
            this.mTabExam.Size = new System.Drawing.Size(928, 449);
            this.mTabExam.TabIndex = 2;
            this.mTabExam.UseSelectable = true;
            // 
            // mTabStudentStatistic
            // 
            this.mTabStudentStatistic.HorizontalScrollbarBarColor = true;
            this.mTabStudentStatistic.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabStudentStatistic.HorizontalScrollbarSize = 10;
            this.mTabStudentStatistic.Location = new System.Drawing.Point(4, 38);
            this.mTabStudentStatistic.Name = "mTabStudentStatistic";
            this.mTabStudentStatistic.Size = new System.Drawing.Size(920, 407);
            this.mTabStudentStatistic.TabIndex = 0;
            this.mTabStudentStatistic.Text = "Thống kê học sinh";
            this.mTabStudentStatistic.VerticalScrollbarBarColor = true;
            this.mTabStudentStatistic.VerticalScrollbarHighlightOnWheel = false;
            this.mTabStudentStatistic.VerticalScrollbarSize = 10;
            // 
            // mTabExamStatistic
            // 
            this.mTabExamStatistic.Location = new System.Drawing.Point(4, 38);
            this.mTabExamStatistic.Name = "mTabExamStatistic";
            this.mTabExamStatistic.Size = new System.Drawing.Size(920, 407);
            this.mTabExamStatistic.TabIndex = 1;
            this.mTabExamStatistic.Text = "Thống kê kì thi";
            // 
            // mTabQuestionStatistic
            // 
            this.mTabQuestionStatistic.Location = new System.Drawing.Point(4, 38);
            this.mTabQuestionStatistic.Name = "mTabQuestionStatistic";
            this.mTabQuestionStatistic.Size = new System.Drawing.Size(920, 407);
            this.mTabQuestionStatistic.TabIndex = 2;
            this.mTabQuestionStatistic.Text = "Thống kê câu hỏi";
            // 
            // frmTeacherStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 529);
            this.Controls.Add(this.mTabExam);
            this.Name = "frmTeacherStudent";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Quản lý học sinh";
            this.mTabExam.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabExam;
        private MetroFramework.Controls.MetroTabPage mTabStudentStatistic;
        private System.Windows.Forms.TabPage mTabExamStatistic;
        private System.Windows.Forms.TabPage mTabQuestionStatistic;
    }
}