namespace DoAnLTUDQL1.Views.TeacherView
{
    partial class frmTeacherExamCode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mTabExamCode = new MetroFramework.Controls.MetroTabControl();
            this.mTabListExamCode = new MetroFramework.Controls.MetroTabPage();
            this.mBtnDeleteExamCode = new MetroFramework.Controls.MetroButton();
            this.mBtnReloadListExamCode = new MetroFramework.Controls.MetroButton();
            this.mTileListExamCode = new MetroFramework.Controls.MetroTile();
            this.mGridListExamCode = new MetroFramework.Controls.MetroGrid();
            this.mTabEditExamCode = new MetroFramework.Controls.MetroTabPage();
            this.mToggleEditExamCodeIsPracticeExam = new MetroFramework.Controls.MetroToggle();
            this.mLblEditExamCodeIsPracticeExam = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditExamCodeGradeId = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditExamCodeGradeId = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditExamCodeSubjectId = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditExamCodeSubjectId = new MetroFramework.Controls.MetroLabel();
            this.mCbbEditExamCodeSubject = new MetroFramework.Controls.MetroComboBox();
            this.mLblEditExamCodeSubject = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditExamCodeNumberOfQuestions = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditExamCodeNumberOfQuestions = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditExamCodeId = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditExamCodeId = new MetroFramework.Controls.MetroLabel();
            this.mBtnEditExamCodeQuestions = new MetroFramework.Controls.MetroButton();
            this.mBtnSaveEditExamCode = new MetroFramework.Controls.MetroButton();
            this.mTileEditExamCode = new MetroFramework.Controls.MetroTile();
            this.mTabAddExamCode = new MetroFramework.Controls.MetroTabPage();
            this.mToggleAddExamCodeIsPracticeExam = new MetroFramework.Controls.MetroToggle();
            this.mLblAddExamCodeIsPracticeExam = new MetroFramework.Controls.MetroLabel();
            this.mTxtAddExamCodeGradeId = new MetroFramework.Controls.MetroTextBox();
            this.mLblAddExamCodeGradeId = new MetroFramework.Controls.MetroLabel();
            this.mTxtAddExamCodeSubjectId = new MetroFramework.Controls.MetroTextBox();
            this.mLblAddExamCodeSubjectId = new MetroFramework.Controls.MetroLabel();
            this.mCbbAddExamCodeSubject = new MetroFramework.Controls.MetroComboBox();
            this.mLblAddExamCodeSubject = new MetroFramework.Controls.MetroLabel();
            this.mTxtAddExamCodeNumberOfQuestions = new MetroFramework.Controls.MetroTextBox();
            this.mLblAddExamCodeNumberOfQuestions = new MetroFramework.Controls.MetroLabel();
            this.mBtnAddExamCodeQuestions = new MetroFramework.Controls.MetroButton();
            this.mBtnAddExamCode = new MetroFramework.Controls.MetroButton();
            this.mTileAddExamCode = new MetroFramework.Controls.MetroTile();
            this.mTabExamCode.SuspendLayout();
            this.mTabListExamCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridListExamCode)).BeginInit();
            this.mTabEditExamCode.SuspendLayout();
            this.mTabAddExamCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabExamCode
            // 
            this.mTabExamCode.Controls.Add(this.mTabListExamCode);
            this.mTabExamCode.Controls.Add(this.mTabEditExamCode);
            this.mTabExamCode.Controls.Add(this.mTabAddExamCode);
            this.mTabExamCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabExamCode.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mTabExamCode.Location = new System.Drawing.Point(20, 60);
            this.mTabExamCode.Name = "mTabExamCode";
            this.mTabExamCode.SelectedIndex = 2;
            this.mTabExamCode.Size = new System.Drawing.Size(1151, 578);
            this.mTabExamCode.TabIndex = 0;
            this.mTabExamCode.UseSelectable = true;
            // 
            // mTabListExamCode
            // 
            this.mTabListExamCode.Controls.Add(this.mBtnDeleteExamCode);
            this.mTabListExamCode.Controls.Add(this.mBtnReloadListExamCode);
            this.mTabListExamCode.Controls.Add(this.mTileListExamCode);
            this.mTabListExamCode.Controls.Add(this.mGridListExamCode);
            this.mTabListExamCode.HorizontalScrollbarBarColor = true;
            this.mTabListExamCode.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabListExamCode.HorizontalScrollbarSize = 10;
            this.mTabListExamCode.Location = new System.Drawing.Point(4, 38);
            this.mTabListExamCode.Name = "mTabListExamCode";
            this.mTabListExamCode.Size = new System.Drawing.Size(1143, 536);
            this.mTabListExamCode.TabIndex = 0;
            this.mTabListExamCode.Text = "Danh sách đề thi";
            this.mTabListExamCode.VerticalScrollbarBarColor = true;
            this.mTabListExamCode.VerticalScrollbarHighlightOnWheel = false;
            this.mTabListExamCode.VerticalScrollbarSize = 10;
            // 
            // mBtnDeleteExamCode
            // 
            this.mBtnDeleteExamCode.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnDeleteExamCode.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnDeleteExamCode.Location = new System.Drawing.Point(693, 3);
            this.mBtnDeleteExamCode.Name = "mBtnDeleteExamCode";
            this.mBtnDeleteExamCode.Size = new System.Drawing.Size(222, 40);
            this.mBtnDeleteExamCode.TabIndex = 6;
            this.mBtnDeleteExamCode.Text = "Xoá đề thi";
            this.mBtnDeleteExamCode.UseSelectable = true;
            // 
            // mBtnReloadListExamCode
            // 
            this.mBtnReloadListExamCode.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnReloadListExamCode.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnReloadListExamCode.Location = new System.Drawing.Point(921, 3);
            this.mBtnReloadListExamCode.Name = "mBtnReloadListExamCode";
            this.mBtnReloadListExamCode.Size = new System.Drawing.Size(222, 40);
            this.mBtnReloadListExamCode.TabIndex = 6;
            this.mBtnReloadListExamCode.Text = "Tải lại danh sách";
            this.mBtnReloadListExamCode.UseSelectable = true;
            // 
            // mTileListExamCode
            // 
            this.mTileListExamCode.ActiveControl = null;
            this.mTileListExamCode.Location = new System.Drawing.Point(0, 3);
            this.mTileListExamCode.Name = "mTileListExamCode";
            this.mTileListExamCode.Size = new System.Drawing.Size(687, 40);
            this.mTileListExamCode.TabIndex = 5;
            this.mTileListExamCode.Text = "Danh sách đề thi";
            this.mTileListExamCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileListExamCode.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileListExamCode.UseSelectable = true;
            // 
            // mGridListExamCode
            // 
            this.mGridListExamCode.AllowUserToAddRows = false;
            this.mGridListExamCode.AllowUserToDeleteRows = false;
            this.mGridListExamCode.AllowUserToResizeRows = false;
            this.mGridListExamCode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mGridListExamCode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListExamCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridListExamCode.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridListExamCode.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListExamCode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mGridListExamCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridListExamCode.DefaultCellStyle = dataGridViewCellStyle8;
            this.mGridListExamCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mGridListExamCode.EnableHeadersVisualStyles = false;
            this.mGridListExamCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridListExamCode.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListExamCode.Location = new System.Drawing.Point(0, 49);
            this.mGridListExamCode.Name = "mGridListExamCode";
            this.mGridListExamCode.ReadOnly = true;
            this.mGridListExamCode.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListExamCode.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mGridListExamCode.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridListExamCode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridListExamCode.Size = new System.Drawing.Size(1143, 487);
            this.mGridListExamCode.TabIndex = 2;
            // 
            // mTabEditExamCode
            // 
            this.mTabEditExamCode.Controls.Add(this.mToggleEditExamCodeIsPracticeExam);
            this.mTabEditExamCode.Controls.Add(this.mLblEditExamCodeIsPracticeExam);
            this.mTabEditExamCode.Controls.Add(this.mTxtEditExamCodeGradeId);
            this.mTabEditExamCode.Controls.Add(this.mLblEditExamCodeGradeId);
            this.mTabEditExamCode.Controls.Add(this.mTxtEditExamCodeSubjectId);
            this.mTabEditExamCode.Controls.Add(this.mLblEditExamCodeSubjectId);
            this.mTabEditExamCode.Controls.Add(this.mCbbEditExamCodeSubject);
            this.mTabEditExamCode.Controls.Add(this.mLblEditExamCodeSubject);
            this.mTabEditExamCode.Controls.Add(this.mTxtEditExamCodeNumberOfQuestions);
            this.mTabEditExamCode.Controls.Add(this.mLblEditExamCodeNumberOfQuestions);
            this.mTabEditExamCode.Controls.Add(this.mTxtEditExamCodeId);
            this.mTabEditExamCode.Controls.Add(this.mLblEditExamCodeId);
            this.mTabEditExamCode.Controls.Add(this.mBtnEditExamCodeQuestions);
            this.mTabEditExamCode.Controls.Add(this.mBtnSaveEditExamCode);
            this.mTabEditExamCode.Controls.Add(this.mTileEditExamCode);
            this.mTabEditExamCode.HorizontalScrollbarBarColor = true;
            this.mTabEditExamCode.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabEditExamCode.HorizontalScrollbarSize = 10;
            this.mTabEditExamCode.Location = new System.Drawing.Point(4, 38);
            this.mTabEditExamCode.Name = "mTabEditExamCode";
            this.mTabEditExamCode.Size = new System.Drawing.Size(1143, 536);
            this.mTabEditExamCode.TabIndex = 1;
            this.mTabEditExamCode.Text = "Chỉnh sửa đề thi";
            this.mTabEditExamCode.VerticalScrollbarBarColor = true;
            this.mTabEditExamCode.VerticalScrollbarHighlightOnWheel = false;
            this.mTabEditExamCode.VerticalScrollbarSize = 10;
            // 
            // mToggleEditExamCodeIsPracticeExam
            // 
            this.mToggleEditExamCodeIsPracticeExam.AutoSize = true;
            this.mToggleEditExamCodeIsPracticeExam.DisplayStatus = false;
            this.mToggleEditExamCodeIsPracticeExam.Location = new System.Drawing.Point(139, 132);
            this.mToggleEditExamCodeIsPracticeExam.Name = "mToggleEditExamCodeIsPracticeExam";
            this.mToggleEditExamCodeIsPracticeExam.Size = new System.Drawing.Size(50, 17);
            this.mToggleEditExamCodeIsPracticeExam.TabIndex = 49;
            this.mToggleEditExamCodeIsPracticeExam.Text = "Off";
            this.mToggleEditExamCodeIsPracticeExam.UseSelectable = true;
            // 
            // mLblEditExamCodeIsPracticeExam
            // 
            this.mLblEditExamCodeIsPracticeExam.AutoSize = true;
            this.mLblEditExamCodeIsPracticeExam.Location = new System.Drawing.Point(0, 130);
            this.mLblEditExamCodeIsPracticeExam.Name = "mLblEditExamCodeIsPracticeExam";
            this.mLblEditExamCodeIsPracticeExam.Size = new System.Drawing.Size(92, 19);
            this.mLblEditExamCodeIsPracticeExam.TabIndex = 48;
            this.mLblEditExamCodeIsPracticeExam.Text = "Là đề thi thử ?";
            // 
            // mTxtEditExamCodeGradeId
            // 
            // 
            // 
            // 
            this.mTxtEditExamCodeGradeId.CustomButton.Image = null;
            this.mTxtEditExamCodeGradeId.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtEditExamCodeGradeId.CustomButton.Name = "";
            this.mTxtEditExamCodeGradeId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditExamCodeGradeId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditExamCodeGradeId.CustomButton.TabIndex = 1;
            this.mTxtEditExamCodeGradeId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditExamCodeGradeId.CustomButton.UseSelectable = true;
            this.mTxtEditExamCodeGradeId.CustomButton.Visible = false;
            this.mTxtEditExamCodeGradeId.Enabled = false;
            this.mTxtEditExamCodeGradeId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditExamCodeGradeId.Lines = new string[0];
            this.mTxtEditExamCodeGradeId.Location = new System.Drawing.Point(717, 124);
            this.mTxtEditExamCodeGradeId.MaxLength = 32767;
            this.mTxtEditExamCodeGradeId.Name = "mTxtEditExamCodeGradeId";
            this.mTxtEditExamCodeGradeId.PasswordChar = '\0';
            this.mTxtEditExamCodeGradeId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditExamCodeGradeId.SelectedText = "";
            this.mTxtEditExamCodeGradeId.SelectionLength = 0;
            this.mTxtEditExamCodeGradeId.SelectionStart = 0;
            this.mTxtEditExamCodeGradeId.ShortcutsEnabled = true;
            this.mTxtEditExamCodeGradeId.Size = new System.Drawing.Size(426, 25);
            this.mTxtEditExamCodeGradeId.TabIndex = 46;
            this.mTxtEditExamCodeGradeId.UseSelectable = true;
            this.mTxtEditExamCodeGradeId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditExamCodeGradeId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditExamCodeGradeId
            // 
            this.mLblEditExamCodeGradeId.AutoSize = true;
            this.mLblEditExamCodeGradeId.Location = new System.Drawing.Point(578, 124);
            this.mLblEditExamCodeGradeId.Name = "mLblEditExamCodeGradeId";
            this.mLblEditExamCodeGradeId.Size = new System.Drawing.Size(57, 19);
            this.mLblEditExamCodeGradeId.TabIndex = 44;
            this.mLblEditExamCodeGradeId.Text = "Khối lớp";
            // 
            // mTxtEditExamCodeSubjectId
            // 
            // 
            // 
            // 
            this.mTxtEditExamCodeSubjectId.CustomButton.Image = null;
            this.mTxtEditExamCodeSubjectId.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtEditExamCodeSubjectId.CustomButton.Name = "";
            this.mTxtEditExamCodeSubjectId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditExamCodeSubjectId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditExamCodeSubjectId.CustomButton.TabIndex = 1;
            this.mTxtEditExamCodeSubjectId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditExamCodeSubjectId.CustomButton.UseSelectable = true;
            this.mTxtEditExamCodeSubjectId.CustomButton.Visible = false;
            this.mTxtEditExamCodeSubjectId.Enabled = false;
            this.mTxtEditExamCodeSubjectId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditExamCodeSubjectId.Lines = new string[0];
            this.mTxtEditExamCodeSubjectId.Location = new System.Drawing.Point(717, 93);
            this.mTxtEditExamCodeSubjectId.MaxLength = 32767;
            this.mTxtEditExamCodeSubjectId.Name = "mTxtEditExamCodeSubjectId";
            this.mTxtEditExamCodeSubjectId.PasswordChar = '\0';
            this.mTxtEditExamCodeSubjectId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditExamCodeSubjectId.SelectedText = "";
            this.mTxtEditExamCodeSubjectId.SelectionLength = 0;
            this.mTxtEditExamCodeSubjectId.SelectionStart = 0;
            this.mTxtEditExamCodeSubjectId.ShortcutsEnabled = true;
            this.mTxtEditExamCodeSubjectId.Size = new System.Drawing.Size(426, 25);
            this.mTxtEditExamCodeSubjectId.TabIndex = 47;
            this.mTxtEditExamCodeSubjectId.UseSelectable = true;
            this.mTxtEditExamCodeSubjectId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditExamCodeSubjectId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditExamCodeSubjectId
            // 
            this.mLblEditExamCodeSubjectId.AutoSize = true;
            this.mLblEditExamCodeSubjectId.Location = new System.Drawing.Point(578, 93);
            this.mLblEditExamCodeSubjectId.Name = "mLblEditExamCodeSubjectId";
            this.mLblEditExamCodeSubjectId.Size = new System.Drawing.Size(84, 19);
            this.mLblEditExamCodeSubjectId.TabIndex = 45;
            this.mLblEditExamCodeSubjectId.Text = "Mã môn học";
            // 
            // mCbbEditExamCodeSubject
            // 
            this.mCbbEditExamCodeSubject.FormattingEnabled = true;
            this.mCbbEditExamCodeSubject.ItemHeight = 23;
            this.mCbbEditExamCodeSubject.Location = new System.Drawing.Point(717, 58);
            this.mCbbEditExamCodeSubject.Name = "mCbbEditExamCodeSubject";
            this.mCbbEditExamCodeSubject.Size = new System.Drawing.Size(426, 29);
            this.mCbbEditExamCodeSubject.TabIndex = 43;
            this.mCbbEditExamCodeSubject.UseSelectable = true;
            // 
            // mLblEditExamCodeSubject
            // 
            this.mLblEditExamCodeSubject.AutoSize = true;
            this.mLblEditExamCodeSubject.Location = new System.Drawing.Point(578, 58);
            this.mLblEditExamCodeSubject.Name = "mLblEditExamCodeSubject";
            this.mLblEditExamCodeSubject.Size = new System.Drawing.Size(61, 19);
            this.mLblEditExamCodeSubject.TabIndex = 42;
            this.mLblEditExamCodeSubject.Text = "Môn học";
            // 
            // mTxtEditExamCodeNumberOfQuestions
            // 
            // 
            // 
            // 
            this.mTxtEditExamCodeNumberOfQuestions.CustomButton.Image = null;
            this.mTxtEditExamCodeNumberOfQuestions.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtEditExamCodeNumberOfQuestions.CustomButton.Name = "";
            this.mTxtEditExamCodeNumberOfQuestions.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditExamCodeNumberOfQuestions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditExamCodeNumberOfQuestions.CustomButton.TabIndex = 1;
            this.mTxtEditExamCodeNumberOfQuestions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditExamCodeNumberOfQuestions.CustomButton.UseSelectable = true;
            this.mTxtEditExamCodeNumberOfQuestions.CustomButton.Visible = false;
            this.mTxtEditExamCodeNumberOfQuestions.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditExamCodeNumberOfQuestions.Lines = new string[0];
            this.mTxtEditExamCodeNumberOfQuestions.Location = new System.Drawing.Point(139, 93);
            this.mTxtEditExamCodeNumberOfQuestions.MaxLength = 32767;
            this.mTxtEditExamCodeNumberOfQuestions.Name = "mTxtEditExamCodeNumberOfQuestions";
            this.mTxtEditExamCodeNumberOfQuestions.PasswordChar = '\0';
            this.mTxtEditExamCodeNumberOfQuestions.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditExamCodeNumberOfQuestions.SelectedText = "";
            this.mTxtEditExamCodeNumberOfQuestions.SelectionLength = 0;
            this.mTxtEditExamCodeNumberOfQuestions.SelectionStart = 0;
            this.mTxtEditExamCodeNumberOfQuestions.ShortcutsEnabled = true;
            this.mTxtEditExamCodeNumberOfQuestions.Size = new System.Drawing.Size(426, 25);
            this.mTxtEditExamCodeNumberOfQuestions.TabIndex = 41;
            this.mTxtEditExamCodeNumberOfQuestions.UseSelectable = true;
            this.mTxtEditExamCodeNumberOfQuestions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditExamCodeNumberOfQuestions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditExamCodeNumberOfQuestions
            // 
            this.mLblEditExamCodeNumberOfQuestions.AutoSize = true;
            this.mLblEditExamCodeNumberOfQuestions.Location = new System.Drawing.Point(0, 93);
            this.mLblEditExamCodeNumberOfQuestions.Name = "mLblEditExamCodeNumberOfQuestions";
            this.mLblEditExamCodeNumberOfQuestions.Size = new System.Drawing.Size(108, 19);
            this.mLblEditExamCodeNumberOfQuestions.TabIndex = 40;
            this.mLblEditExamCodeNumberOfQuestions.Text = "Số lượng câu hỏi";
            // 
            // mTxtEditExamCodeId
            // 
            // 
            // 
            // 
            this.mTxtEditExamCodeId.CustomButton.Image = null;
            this.mTxtEditExamCodeId.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtEditExamCodeId.CustomButton.Name = "";
            this.mTxtEditExamCodeId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditExamCodeId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditExamCodeId.CustomButton.TabIndex = 1;
            this.mTxtEditExamCodeId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditExamCodeId.CustomButton.UseSelectable = true;
            this.mTxtEditExamCodeId.CustomButton.Visible = false;
            this.mTxtEditExamCodeId.Enabled = false;
            this.mTxtEditExamCodeId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditExamCodeId.Lines = new string[0];
            this.mTxtEditExamCodeId.Location = new System.Drawing.Point(139, 58);
            this.mTxtEditExamCodeId.MaxLength = 32767;
            this.mTxtEditExamCodeId.Name = "mTxtEditExamCodeId";
            this.mTxtEditExamCodeId.PasswordChar = '\0';
            this.mTxtEditExamCodeId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditExamCodeId.SelectedText = "";
            this.mTxtEditExamCodeId.SelectionLength = 0;
            this.mTxtEditExamCodeId.SelectionStart = 0;
            this.mTxtEditExamCodeId.ShortcutsEnabled = true;
            this.mTxtEditExamCodeId.Size = new System.Drawing.Size(426, 25);
            this.mTxtEditExamCodeId.TabIndex = 41;
            this.mTxtEditExamCodeId.UseSelectable = true;
            this.mTxtEditExamCodeId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditExamCodeId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditExamCodeId
            // 
            this.mLblEditExamCodeId.AutoSize = true;
            this.mLblEditExamCodeId.Location = new System.Drawing.Point(0, 58);
            this.mLblEditExamCodeId.Name = "mLblEditExamCodeId";
            this.mLblEditExamCodeId.Size = new System.Drawing.Size(65, 19);
            this.mLblEditExamCodeId.TabIndex = 40;
            this.mLblEditExamCodeId.Text = "Mã đề thi";
            // 
            // mBtnEditExamCodeQuestions
            // 
            this.mBtnEditExamCodeQuestions.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnEditExamCodeQuestions.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnEditExamCodeQuestions.Location = new System.Drawing.Point(693, 3);
            this.mBtnEditExamCodeQuestions.Name = "mBtnEditExamCodeQuestions";
            this.mBtnEditExamCodeQuestions.Size = new System.Drawing.Size(222, 40);
            this.mBtnEditExamCodeQuestions.TabIndex = 7;
            this.mBtnEditExamCodeQuestions.Text = "Chỉnh sửa câu hỏi";
            this.mBtnEditExamCodeQuestions.UseSelectable = true;
            // 
            // mBtnSaveEditExamCode
            // 
            this.mBtnSaveEditExamCode.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnSaveEditExamCode.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnSaveEditExamCode.Location = new System.Drawing.Point(921, 3);
            this.mBtnSaveEditExamCode.Name = "mBtnSaveEditExamCode";
            this.mBtnSaveEditExamCode.Size = new System.Drawing.Size(222, 40);
            this.mBtnSaveEditExamCode.TabIndex = 7;
            this.mBtnSaveEditExamCode.Text = "Lưu chỉnh sửa";
            this.mBtnSaveEditExamCode.UseSelectable = true;
            // 
            // mTileEditExamCode
            // 
            this.mTileEditExamCode.ActiveControl = null;
            this.mTileEditExamCode.Location = new System.Drawing.Point(0, 3);
            this.mTileEditExamCode.Name = "mTileEditExamCode";
            this.mTileEditExamCode.Size = new System.Drawing.Size(687, 40);
            this.mTileEditExamCode.TabIndex = 6;
            this.mTileEditExamCode.Text = "Chỉnh sửa đề thi";
            this.mTileEditExamCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileEditExamCode.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileEditExamCode.UseSelectable = true;
            // 
            // mTabAddExamCode
            // 
            this.mTabAddExamCode.Controls.Add(this.mToggleAddExamCodeIsPracticeExam);
            this.mTabAddExamCode.Controls.Add(this.mLblAddExamCodeIsPracticeExam);
            this.mTabAddExamCode.Controls.Add(this.mTxtAddExamCodeGradeId);
            this.mTabAddExamCode.Controls.Add(this.mLblAddExamCodeGradeId);
            this.mTabAddExamCode.Controls.Add(this.mTxtAddExamCodeSubjectId);
            this.mTabAddExamCode.Controls.Add(this.mLblAddExamCodeSubjectId);
            this.mTabAddExamCode.Controls.Add(this.mCbbAddExamCodeSubject);
            this.mTabAddExamCode.Controls.Add(this.mLblAddExamCodeSubject);
            this.mTabAddExamCode.Controls.Add(this.mTxtAddExamCodeNumberOfQuestions);
            this.mTabAddExamCode.Controls.Add(this.mLblAddExamCodeNumberOfQuestions);
            this.mTabAddExamCode.Controls.Add(this.mBtnAddExamCodeQuestions);
            this.mTabAddExamCode.Controls.Add(this.mBtnAddExamCode);
            this.mTabAddExamCode.Controls.Add(this.mTileAddExamCode);
            this.mTabAddExamCode.HorizontalScrollbarBarColor = true;
            this.mTabAddExamCode.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabAddExamCode.HorizontalScrollbarSize = 10;
            this.mTabAddExamCode.Location = new System.Drawing.Point(4, 38);
            this.mTabAddExamCode.Name = "mTabAddExamCode";
            this.mTabAddExamCode.Size = new System.Drawing.Size(1143, 536);
            this.mTabAddExamCode.TabIndex = 2;
            this.mTabAddExamCode.Text = "Tạo đề thi";
            this.mTabAddExamCode.VerticalScrollbarBarColor = true;
            this.mTabAddExamCode.VerticalScrollbarHighlightOnWheel = false;
            this.mTabAddExamCode.VerticalScrollbarSize = 10;
            // 
            // mToggleAddExamCodeIsPracticeExam
            // 
            this.mToggleAddExamCodeIsPracticeExam.AutoSize = true;
            this.mToggleAddExamCodeIsPracticeExam.DisplayStatus = false;
            this.mToggleAddExamCodeIsPracticeExam.Location = new System.Drawing.Point(136, 97);
            this.mToggleAddExamCodeIsPracticeExam.Name = "mToggleAddExamCodeIsPracticeExam";
            this.mToggleAddExamCodeIsPracticeExam.Size = new System.Drawing.Size(50, 17);
            this.mToggleAddExamCodeIsPracticeExam.TabIndex = 64;
            this.mToggleAddExamCodeIsPracticeExam.Text = "Off";
            this.mToggleAddExamCodeIsPracticeExam.UseSelectable = true;
            // 
            // mLblAddExamCodeIsPracticeExam
            // 
            this.mLblAddExamCodeIsPracticeExam.AutoSize = true;
            this.mLblAddExamCodeIsPracticeExam.Location = new System.Drawing.Point(-3, 95);
            this.mLblAddExamCodeIsPracticeExam.Name = "mLblAddExamCodeIsPracticeExam";
            this.mLblAddExamCodeIsPracticeExam.Size = new System.Drawing.Size(92, 19);
            this.mLblAddExamCodeIsPracticeExam.TabIndex = 63;
            this.mLblAddExamCodeIsPracticeExam.Text = "Là đề thi thử ?";
            // 
            // mTxtAddExamCodeGradeId
            // 
            // 
            // 
            // 
            this.mTxtAddExamCodeGradeId.CustomButton.Image = null;
            this.mTxtAddExamCodeGradeId.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtAddExamCodeGradeId.CustomButton.Name = "";
            this.mTxtAddExamCodeGradeId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtAddExamCodeGradeId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtAddExamCodeGradeId.CustomButton.TabIndex = 1;
            this.mTxtAddExamCodeGradeId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtAddExamCodeGradeId.CustomButton.UseSelectable = true;
            this.mTxtAddExamCodeGradeId.CustomButton.Visible = false;
            this.mTxtAddExamCodeGradeId.Enabled = false;
            this.mTxtAddExamCodeGradeId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtAddExamCodeGradeId.Lines = new string[0];
            this.mTxtAddExamCodeGradeId.Location = new System.Drawing.Point(717, 124);
            this.mTxtAddExamCodeGradeId.MaxLength = 32767;
            this.mTxtAddExamCodeGradeId.Name = "mTxtAddExamCodeGradeId";
            this.mTxtAddExamCodeGradeId.PasswordChar = '\0';
            this.mTxtAddExamCodeGradeId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtAddExamCodeGradeId.SelectedText = "";
            this.mTxtAddExamCodeGradeId.SelectionLength = 0;
            this.mTxtAddExamCodeGradeId.SelectionStart = 0;
            this.mTxtAddExamCodeGradeId.ShortcutsEnabled = true;
            this.mTxtAddExamCodeGradeId.Size = new System.Drawing.Size(426, 25);
            this.mTxtAddExamCodeGradeId.TabIndex = 61;
            this.mTxtAddExamCodeGradeId.UseSelectable = true;
            this.mTxtAddExamCodeGradeId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtAddExamCodeGradeId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblAddExamCodeGradeId
            // 
            this.mLblAddExamCodeGradeId.AutoSize = true;
            this.mLblAddExamCodeGradeId.Location = new System.Drawing.Point(578, 124);
            this.mLblAddExamCodeGradeId.Name = "mLblAddExamCodeGradeId";
            this.mLblAddExamCodeGradeId.Size = new System.Drawing.Size(57, 19);
            this.mLblAddExamCodeGradeId.TabIndex = 59;
            this.mLblAddExamCodeGradeId.Text = "Khối lớp";
            // 
            // mTxtAddExamCodeSubjectId
            // 
            // 
            // 
            // 
            this.mTxtAddExamCodeSubjectId.CustomButton.Image = null;
            this.mTxtAddExamCodeSubjectId.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtAddExamCodeSubjectId.CustomButton.Name = "";
            this.mTxtAddExamCodeSubjectId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtAddExamCodeSubjectId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtAddExamCodeSubjectId.CustomButton.TabIndex = 1;
            this.mTxtAddExamCodeSubjectId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtAddExamCodeSubjectId.CustomButton.UseSelectable = true;
            this.mTxtAddExamCodeSubjectId.CustomButton.Visible = false;
            this.mTxtAddExamCodeSubjectId.Enabled = false;
            this.mTxtAddExamCodeSubjectId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtAddExamCodeSubjectId.Lines = new string[0];
            this.mTxtAddExamCodeSubjectId.Location = new System.Drawing.Point(717, 93);
            this.mTxtAddExamCodeSubjectId.MaxLength = 32767;
            this.mTxtAddExamCodeSubjectId.Name = "mTxtAddExamCodeSubjectId";
            this.mTxtAddExamCodeSubjectId.PasswordChar = '\0';
            this.mTxtAddExamCodeSubjectId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtAddExamCodeSubjectId.SelectedText = "";
            this.mTxtAddExamCodeSubjectId.SelectionLength = 0;
            this.mTxtAddExamCodeSubjectId.SelectionStart = 0;
            this.mTxtAddExamCodeSubjectId.ShortcutsEnabled = true;
            this.mTxtAddExamCodeSubjectId.Size = new System.Drawing.Size(426, 25);
            this.mTxtAddExamCodeSubjectId.TabIndex = 62;
            this.mTxtAddExamCodeSubjectId.UseSelectable = true;
            this.mTxtAddExamCodeSubjectId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtAddExamCodeSubjectId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblAddExamCodeSubjectId
            // 
            this.mLblAddExamCodeSubjectId.AutoSize = true;
            this.mLblAddExamCodeSubjectId.Location = new System.Drawing.Point(578, 93);
            this.mLblAddExamCodeSubjectId.Name = "mLblAddExamCodeSubjectId";
            this.mLblAddExamCodeSubjectId.Size = new System.Drawing.Size(84, 19);
            this.mLblAddExamCodeSubjectId.TabIndex = 60;
            this.mLblAddExamCodeSubjectId.Text = "Mã môn học";
            // 
            // mCbbAddExamCodeSubject
            // 
            this.mCbbAddExamCodeSubject.FormattingEnabled = true;
            this.mCbbAddExamCodeSubject.ItemHeight = 23;
            this.mCbbAddExamCodeSubject.Location = new System.Drawing.Point(717, 58);
            this.mCbbAddExamCodeSubject.Name = "mCbbAddExamCodeSubject";
            this.mCbbAddExamCodeSubject.Size = new System.Drawing.Size(426, 29);
            this.mCbbAddExamCodeSubject.TabIndex = 58;
            this.mCbbAddExamCodeSubject.UseSelectable = true;
            // 
            // mLblAddExamCodeSubject
            // 
            this.mLblAddExamCodeSubject.AutoSize = true;
            this.mLblAddExamCodeSubject.Location = new System.Drawing.Point(578, 58);
            this.mLblAddExamCodeSubject.Name = "mLblAddExamCodeSubject";
            this.mLblAddExamCodeSubject.Size = new System.Drawing.Size(61, 19);
            this.mLblAddExamCodeSubject.TabIndex = 57;
            this.mLblAddExamCodeSubject.Text = "Môn học";
            // 
            // mTxtAddExamCodeNumberOfQuestions
            // 
            // 
            // 
            // 
            this.mTxtAddExamCodeNumberOfQuestions.CustomButton.Image = null;
            this.mTxtAddExamCodeNumberOfQuestions.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtAddExamCodeNumberOfQuestions.CustomButton.Name = "";
            this.mTxtAddExamCodeNumberOfQuestions.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtAddExamCodeNumberOfQuestions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtAddExamCodeNumberOfQuestions.CustomButton.TabIndex = 1;
            this.mTxtAddExamCodeNumberOfQuestions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtAddExamCodeNumberOfQuestions.CustomButton.UseSelectable = true;
            this.mTxtAddExamCodeNumberOfQuestions.CustomButton.Visible = false;
            this.mTxtAddExamCodeNumberOfQuestions.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtAddExamCodeNumberOfQuestions.Lines = new string[0];
            this.mTxtAddExamCodeNumberOfQuestions.Location = new System.Drawing.Point(136, 58);
            this.mTxtAddExamCodeNumberOfQuestions.MaxLength = 32767;
            this.mTxtAddExamCodeNumberOfQuestions.Name = "mTxtAddExamCodeNumberOfQuestions";
            this.mTxtAddExamCodeNumberOfQuestions.PasswordChar = '\0';
            this.mTxtAddExamCodeNumberOfQuestions.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtAddExamCodeNumberOfQuestions.SelectedText = "";
            this.mTxtAddExamCodeNumberOfQuestions.SelectionLength = 0;
            this.mTxtAddExamCodeNumberOfQuestions.SelectionStart = 0;
            this.mTxtAddExamCodeNumberOfQuestions.ShortcutsEnabled = true;
            this.mTxtAddExamCodeNumberOfQuestions.Size = new System.Drawing.Size(426, 25);
            this.mTxtAddExamCodeNumberOfQuestions.TabIndex = 55;
            this.mTxtAddExamCodeNumberOfQuestions.UseSelectable = true;
            this.mTxtAddExamCodeNumberOfQuestions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtAddExamCodeNumberOfQuestions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblAddExamCodeNumberOfQuestions
            // 
            this.mLblAddExamCodeNumberOfQuestions.AutoSize = true;
            this.mLblAddExamCodeNumberOfQuestions.Location = new System.Drawing.Point(-3, 58);
            this.mLblAddExamCodeNumberOfQuestions.Name = "mLblAddExamCodeNumberOfQuestions";
            this.mLblAddExamCodeNumberOfQuestions.Size = new System.Drawing.Size(108, 19);
            this.mLblAddExamCodeNumberOfQuestions.TabIndex = 53;
            this.mLblAddExamCodeNumberOfQuestions.Text = "Số lượng câu hỏi";
            // 
            // mBtnAddExamCodeQuestions
            // 
            this.mBtnAddExamCodeQuestions.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnAddExamCodeQuestions.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnAddExamCodeQuestions.Location = new System.Drawing.Point(693, 3);
            this.mBtnAddExamCodeQuestions.Name = "mBtnAddExamCodeQuestions";
            this.mBtnAddExamCodeQuestions.Size = new System.Drawing.Size(222, 40);
            this.mBtnAddExamCodeQuestions.TabIndex = 51;
            this.mBtnAddExamCodeQuestions.Text = "Chỉnh sửa câu hỏi";
            this.mBtnAddExamCodeQuestions.UseSelectable = true;
            // 
            // mBtnAddExamCode
            // 
            this.mBtnAddExamCode.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnAddExamCode.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnAddExamCode.Location = new System.Drawing.Point(921, 3);
            this.mBtnAddExamCode.Name = "mBtnAddExamCode";
            this.mBtnAddExamCode.Size = new System.Drawing.Size(222, 40);
            this.mBtnAddExamCode.TabIndex = 52;
            this.mBtnAddExamCode.Text = "Tạo đề thi";
            this.mBtnAddExamCode.UseSelectable = true;
            // 
            // mTileAddExamCode
            // 
            this.mTileAddExamCode.ActiveControl = null;
            this.mTileAddExamCode.Location = new System.Drawing.Point(0, 3);
            this.mTileAddExamCode.Name = "mTileAddExamCode";
            this.mTileAddExamCode.Size = new System.Drawing.Size(687, 40);
            this.mTileAddExamCode.TabIndex = 50;
            this.mTileAddExamCode.Text = "Tạo đề thi mới";
            this.mTileAddExamCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileAddExamCode.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileAddExamCode.UseSelectable = true;
            // 
            // frmExamCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 658);
            this.Controls.Add(this.mTabExamCode);
            this.Name = "frmExamCode";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Quản lí đề thi";
            this.mTabExamCode.ResumeLayout(false);
            this.mTabListExamCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridListExamCode)).EndInit();
            this.mTabEditExamCode.ResumeLayout(false);
            this.mTabEditExamCode.PerformLayout();
            this.mTabAddExamCode.ResumeLayout(false);
            this.mTabAddExamCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabExamCode;
        private MetroFramework.Controls.MetroTabPage mTabListExamCode;
        private MetroFramework.Controls.MetroTabPage mTabEditExamCode;
        private MetroFramework.Controls.MetroTabPage mTabAddExamCode;
        private MetroFramework.Controls.MetroGrid mGridListExamCode;
        private MetroFramework.Controls.MetroButton mBtnReloadListExamCode;
        private MetroFramework.Controls.MetroTile mTileListExamCode;
        private MetroFramework.Controls.MetroButton mBtnDeleteExamCode;
        private MetroFramework.Controls.MetroTile mTileEditExamCode;
        private MetroFramework.Controls.MetroButton mBtnSaveEditExamCode;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamCodeGradeId;
        private MetroFramework.Controls.MetroLabel mLblEditExamCodeGradeId;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamCodeSubjectId;
        private MetroFramework.Controls.MetroLabel mLblEditExamCodeSubjectId;
        private MetroFramework.Controls.MetroComboBox mCbbEditExamCodeSubject;
        private MetroFramework.Controls.MetroLabel mLblEditExamCodeSubject;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamCodeId;
        private MetroFramework.Controls.MetroLabel mLblEditExamCodeId;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamCodeNumberOfQuestions;
        private MetroFramework.Controls.MetroLabel mLblEditExamCodeNumberOfQuestions;
        private MetroFramework.Controls.MetroButton mBtnEditExamCodeQuestions;
        private MetroFramework.Controls.MetroToggle mToggleEditExamCodeIsPracticeExam;
        private MetroFramework.Controls.MetroLabel mLblEditExamCodeIsPracticeExam;
        private MetroFramework.Controls.MetroToggle mToggleAddExamCodeIsPracticeExam;
        private MetroFramework.Controls.MetroLabel mLblAddExamCodeIsPracticeExam;
        private MetroFramework.Controls.MetroTextBox mTxtAddExamCodeGradeId;
        private MetroFramework.Controls.MetroLabel mLblAddExamCodeGradeId;
        private MetroFramework.Controls.MetroTextBox mTxtAddExamCodeSubjectId;
        private MetroFramework.Controls.MetroLabel mLblAddExamCodeSubjectId;
        private MetroFramework.Controls.MetroComboBox mCbbAddExamCodeSubject;
        private MetroFramework.Controls.MetroLabel mLblAddExamCodeSubject;
        private MetroFramework.Controls.MetroTextBox mTxtAddExamCodeNumberOfQuestions;
        private MetroFramework.Controls.MetroLabel mLblAddExamCodeNumberOfQuestions;
        private MetroFramework.Controls.MetroButton mBtnAddExamCodeQuestions;
        private MetroFramework.Controls.MetroButton mBtnAddExamCode;
        private MetroFramework.Controls.MetroTile mTileAddExamCode;
    }
}