namespace DoAnLTUDQL1.Views.TeacherView
{
    partial class frmEditExamCodeQuestions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mTabEditExamCodeQuestions = new MetroFramework.Controls.MetroTabControl();
            this.mTabQuestions = new MetroFramework.Controls.MetroTabPage();
            this.mBtnAddQuestion = new MetroFramework.Controls.MetroButton();
            this.mTileListQuestions = new MetroFramework.Controls.MetroTile();
            this.mGridListQuestions = new MetroFramework.Controls.MetroGrid();
            this.mTabExamCodeQuestions = new MetroFramework.Controls.MetroTabPage();
            this.mGridListQuestionsAdded = new MetroFramework.Controls.MetroGrid();
            this.mBtnDeleteQuestion = new MetroFramework.Controls.MetroButton();
            this.mTileListQuestionsAdded = new MetroFramework.Controls.MetroTile();
            this.mTabEditExamCodeQuestions.SuspendLayout();
            this.mTabQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridListQuestions)).BeginInit();
            this.mTabExamCodeQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridListQuestionsAdded)).BeginInit();
            this.SuspendLayout();
            // 
            // mTabEditExamCodeQuestions
            // 
            this.mTabEditExamCodeQuestions.Controls.Add(this.mTabQuestions);
            this.mTabEditExamCodeQuestions.Controls.Add(this.mTabExamCodeQuestions);
            this.mTabEditExamCodeQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabEditExamCodeQuestions.Location = new System.Drawing.Point(20, 60);
            this.mTabEditExamCodeQuestions.Name = "mTabEditExamCodeQuestions";
            this.mTabEditExamCodeQuestions.SelectedIndex = 0;
            this.mTabEditExamCodeQuestions.Size = new System.Drawing.Size(944, 501);
            this.mTabEditExamCodeQuestions.TabIndex = 0;
            this.mTabEditExamCodeQuestions.UseSelectable = true;
            // 
            // mTabQuestions
            // 
            this.mTabQuestions.Controls.Add(this.mBtnAddQuestion);
            this.mTabQuestions.Controls.Add(this.mTileListQuestions);
            this.mTabQuestions.Controls.Add(this.mGridListQuestions);
            this.mTabQuestions.HorizontalScrollbarBarColor = true;
            this.mTabQuestions.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabQuestions.HorizontalScrollbarSize = 10;
            this.mTabQuestions.Location = new System.Drawing.Point(4, 38);
            this.mTabQuestions.Name = "mTabQuestions";
            this.mTabQuestions.Size = new System.Drawing.Size(936, 459);
            this.mTabQuestions.TabIndex = 0;
            this.mTabQuestions.Text = "Danh sách câu hỏi";
            this.mTabQuestions.VerticalScrollbarBarColor = true;
            this.mTabQuestions.VerticalScrollbarHighlightOnWheel = false;
            this.mTabQuestions.VerticalScrollbarSize = 10;
            // 
            // mBtnAddQuestion
            // 
            this.mBtnAddQuestion.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnAddQuestion.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnAddQuestion.Location = new System.Drawing.Point(714, 3);
            this.mBtnAddQuestion.Name = "mBtnAddQuestion";
            this.mBtnAddQuestion.Size = new System.Drawing.Size(222, 40);
            this.mBtnAddQuestion.TabIndex = 7;
            this.mBtnAddQuestion.Text = "Thêm câu hỏi";
            this.mBtnAddQuestion.UseSelectable = true;
            // 
            // mTileListQuestions
            // 
            this.mTileListQuestions.ActiveControl = null;
            this.mTileListQuestions.Location = new System.Drawing.Point(0, 3);
            this.mTileListQuestions.Name = "mTileListQuestions";
            this.mTileListQuestions.Size = new System.Drawing.Size(710, 40);
            this.mTileListQuestions.TabIndex = 6;
            this.mTileListQuestions.Text = "Danh sách câu hỏi";
            this.mTileListQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileListQuestions.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileListQuestions.UseSelectable = true;
            // 
            // mGridListQuestions
            // 
            this.mGridListQuestions.AllowUserToAddRows = false;
            this.mGridListQuestions.AllowUserToDeleteRows = false;
            this.mGridListQuestions.AllowUserToResizeRows = false;
            this.mGridListQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mGridListQuestions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridListQuestions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridListQuestions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListQuestions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridListQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridListQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridListQuestions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mGridListQuestions.EnableHeadersVisualStyles = false;
            this.mGridListQuestions.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridListQuestions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListQuestions.Location = new System.Drawing.Point(0, 49);
            this.mGridListQuestions.Name = "mGridListQuestions";
            this.mGridListQuestions.ReadOnly = true;
            this.mGridListQuestions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListQuestions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridListQuestions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridListQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridListQuestions.Size = new System.Drawing.Size(936, 410);
            this.mGridListQuestions.TabIndex = 2;
            // 
            // mTabExamCodeQuestions
            // 
            this.mTabExamCodeQuestions.Controls.Add(this.mGridListQuestionsAdded);
            this.mTabExamCodeQuestions.Controls.Add(this.mBtnDeleteQuestion);
            this.mTabExamCodeQuestions.Controls.Add(this.mTileListQuestionsAdded);
            this.mTabExamCodeQuestions.HorizontalScrollbarBarColor = true;
            this.mTabExamCodeQuestions.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabExamCodeQuestions.HorizontalScrollbarSize = 10;
            this.mTabExamCodeQuestions.Location = new System.Drawing.Point(4, 38);
            this.mTabExamCodeQuestions.Name = "mTabExamCodeQuestions";
            this.mTabExamCodeQuestions.Size = new System.Drawing.Size(936, 459);
            this.mTabExamCodeQuestions.TabIndex = 1;
            this.mTabExamCodeQuestions.Text = "Danh sách câu hỏi đã thêm vào đề";
            this.mTabExamCodeQuestions.VerticalScrollbarBarColor = true;
            this.mTabExamCodeQuestions.VerticalScrollbarHighlightOnWheel = false;
            this.mTabExamCodeQuestions.VerticalScrollbarSize = 10;
            // 
            // mGridListQuestionsAdded
            // 
            this.mGridListQuestionsAdded.AllowUserToAddRows = false;
            this.mGridListQuestionsAdded.AllowUserToDeleteRows = false;
            this.mGridListQuestionsAdded.AllowUserToResizeRows = false;
            this.mGridListQuestionsAdded.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mGridListQuestionsAdded.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListQuestionsAdded.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridListQuestionsAdded.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridListQuestionsAdded.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListQuestionsAdded.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mGridListQuestionsAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridListQuestionsAdded.DefaultCellStyle = dataGridViewCellStyle5;
            this.mGridListQuestionsAdded.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mGridListQuestionsAdded.EnableHeadersVisualStyles = false;
            this.mGridListQuestionsAdded.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridListQuestionsAdded.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListQuestionsAdded.Location = new System.Drawing.Point(0, 49);
            this.mGridListQuestionsAdded.Name = "mGridListQuestionsAdded";
            this.mGridListQuestionsAdded.ReadOnly = true;
            this.mGridListQuestionsAdded.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListQuestionsAdded.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mGridListQuestionsAdded.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridListQuestionsAdded.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridListQuestionsAdded.Size = new System.Drawing.Size(936, 410);
            this.mGridListQuestionsAdded.TabIndex = 9;
            // 
            // mBtnDeleteQuestion
            // 
            this.mBtnDeleteQuestion.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnDeleteQuestion.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnDeleteQuestion.Location = new System.Drawing.Point(714, 3);
            this.mBtnDeleteQuestion.Name = "mBtnDeleteQuestion";
            this.mBtnDeleteQuestion.Size = new System.Drawing.Size(222, 40);
            this.mBtnDeleteQuestion.TabIndex = 8;
            this.mBtnDeleteQuestion.Text = "Xoá câu hỏi";
            this.mBtnDeleteQuestion.UseSelectable = true;
            // 
            // mTileListQuestionsAdded
            // 
            this.mTileListQuestionsAdded.ActiveControl = null;
            this.mTileListQuestionsAdded.Location = new System.Drawing.Point(0, 3);
            this.mTileListQuestionsAdded.Name = "mTileListQuestionsAdded";
            this.mTileListQuestionsAdded.Size = new System.Drawing.Size(708, 40);
            this.mTileListQuestionsAdded.TabIndex = 7;
            this.mTileListQuestionsAdded.Text = "Danh sách câu hỏi đã thêm vào đề thi";
            this.mTileListQuestionsAdded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileListQuestionsAdded.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileListQuestionsAdded.UseSelectable = true;
            // 
            // frmEditExamCodeQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.mTabEditExamCodeQuestions);
            this.Name = "frmEditExamCodeQuestions";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "frmEditExamCodeQuestions";
            this.mTabEditExamCodeQuestions.ResumeLayout(false);
            this.mTabQuestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridListQuestions)).EndInit();
            this.mTabExamCodeQuestions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridListQuestionsAdded)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabEditExamCodeQuestions;
        private MetroFramework.Controls.MetroTabPage mTabQuestions;
        private MetroFramework.Controls.MetroTabPage mTabExamCodeQuestions;
        private MetroFramework.Controls.MetroTile mTileListQuestions;
        private MetroFramework.Controls.MetroTile mTileListQuestionsAdded;
        private MetroFramework.Controls.MetroButton mBtnAddQuestion;
        private MetroFramework.Controls.MetroButton mBtnDeleteQuestion;
        private MetroFramework.Controls.MetroGrid mGridListQuestions;
        private MetroFramework.Controls.MetroGrid mGridListQuestionsAdded;
    }
}