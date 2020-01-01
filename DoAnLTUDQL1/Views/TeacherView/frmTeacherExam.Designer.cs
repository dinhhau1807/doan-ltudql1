namespace DoAnLTUDQL1.Views.TeacherView
{
    partial class frmTeacherExam
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
            this.mTabExam = new MetroFramework.Controls.MetroTabControl();
            this.mTabListExam = new MetroFramework.Controls.MetroTabPage();
            this.mBtnDeleteExam = new MetroFramework.Controls.MetroButton();
            this.mBtnReloadListExam = new MetroFramework.Controls.MetroButton();
            this.mTileListExam = new MetroFramework.Controls.MetroTile();
            this.mGridListExam = new MetroFramework.Controls.MetroGrid();
            this.mTabEditExam = new MetroFramework.Controls.MetroTabPage();
            this.dateTimeEditTimeStart = new System.Windows.Forms.DateTimePicker();
            this.mDateTimeEditDateStart = new MetroFramework.Controls.MetroDateTime();
            this.mTxtEditExamGradeId = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditExamGradeId = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditExamSubjectId = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditExamSubjectId = new MetroFramework.Controls.MetroLabel();
            this.mCbbEditExamSubject = new MetroFramework.Controls.MetroComboBox();
            this.mLblEditExamSubject = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditDuration = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditDuration = new MetroFramework.Controls.MetroLabel();
            this.mLblEditStartTime = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditExamName = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditExamName = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditExamId = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditExamId = new MetroFramework.Controls.MetroLabel();
            this.mBtnSaveEditExam = new MetroFramework.Controls.MetroButton();
            this.mTileEditExam = new MetroFramework.Controls.MetroTile();
            this.mTabAddExam = new MetroFramework.Controls.MetroTabPage();
            this.dateTimeAddTimeStart = new System.Windows.Forms.DateTimePicker();
            this.mDateTimeAddDateStart = new MetroFramework.Controls.MetroDateTime();
            this.mTxtAddExamGradeId = new MetroFramework.Controls.MetroTextBox();
            this.mLblAddGradeId = new MetroFramework.Controls.MetroLabel();
            this.mTxtAddExamSubjectId = new MetroFramework.Controls.MetroTextBox();
            this.mLblAddExamSubjectId = new MetroFramework.Controls.MetroLabel();
            this.mCbbAddExamSubject = new MetroFramework.Controls.MetroComboBox();
            this.mLblAddExamSubject = new MetroFramework.Controls.MetroLabel();
            this.mTxtAddDuration = new MetroFramework.Controls.MetroTextBox();
            this.mLblAddDuration = new MetroFramework.Controls.MetroLabel();
            this.mLblAddStartTime = new MetroFramework.Controls.MetroLabel();
            this.mTxtAddExamName = new MetroFramework.Controls.MetroTextBox();
            this.mLblAddExamName = new MetroFramework.Controls.MetroLabel();
            this.mBtnAddExam = new MetroFramework.Controls.MetroButton();
            this.mTileAddExam = new MetroFramework.Controls.MetroTile();
            this.mTabReport = new MetroFramework.Controls.MetroTabPage();
            this.mTabExam.SuspendLayout();
            this.mTabListExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridListExam)).BeginInit();
            this.mTabEditExam.SuspendLayout();
            this.mTabAddExam.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabExam
            // 
            this.mTabExam.Controls.Add(this.mTabListExam);
            this.mTabExam.Controls.Add(this.mTabEditExam);
            this.mTabExam.Controls.Add(this.mTabAddExam);
            this.mTabExam.Controls.Add(this.mTabReport);
            this.mTabExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabExam.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mTabExam.Location = new System.Drawing.Point(20, 60);
            this.mTabExam.Name = "mTabExam";
            this.mTabExam.SelectedIndex = 3;
            this.mTabExam.Size = new System.Drawing.Size(1151, 578);
            this.mTabExam.TabIndex = 1;
            this.mTabExam.UseSelectable = true;
            // 
            // mTabListExam
            // 
            this.mTabListExam.Controls.Add(this.mBtnDeleteExam);
            this.mTabListExam.Controls.Add(this.mBtnReloadListExam);
            this.mTabListExam.Controls.Add(this.mTileListExam);
            this.mTabListExam.Controls.Add(this.mGridListExam);
            this.mTabListExam.HorizontalScrollbarBarColor = true;
            this.mTabListExam.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabListExam.HorizontalScrollbarSize = 10;
            this.mTabListExam.Location = new System.Drawing.Point(4, 38);
            this.mTabListExam.Name = "mTabListExam";
            this.mTabListExam.Size = new System.Drawing.Size(1143, 536);
            this.mTabListExam.TabIndex = 0;
            this.mTabListExam.Text = "Danh sách kỳ thi";
            this.mTabListExam.VerticalScrollbarBarColor = true;
            this.mTabListExam.VerticalScrollbarHighlightOnWheel = false;
            this.mTabListExam.VerticalScrollbarSize = 10;
            // 
            // mBtnDeleteExam
            // 
            this.mBtnDeleteExam.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnDeleteExam.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnDeleteExam.Location = new System.Drawing.Point(693, 3);
            this.mBtnDeleteExam.Name = "mBtnDeleteExam";
            this.mBtnDeleteExam.Size = new System.Drawing.Size(222, 40);
            this.mBtnDeleteExam.TabIndex = 6;
            this.mBtnDeleteExam.Text = "Xoá kỳ thi";
            this.mBtnDeleteExam.UseSelectable = true;
            // 
            // mBtnReloadListExam
            // 
            this.mBtnReloadListExam.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnReloadListExam.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnReloadListExam.Location = new System.Drawing.Point(921, 3);
            this.mBtnReloadListExam.Name = "mBtnReloadListExam";
            this.mBtnReloadListExam.Size = new System.Drawing.Size(222, 40);
            this.mBtnReloadListExam.TabIndex = 6;
            this.mBtnReloadListExam.Text = "Tải lại danh sách";
            this.mBtnReloadListExam.UseSelectable = true;
            // 
            // mTileListExam
            // 
            this.mTileListExam.ActiveControl = null;
            this.mTileListExam.Location = new System.Drawing.Point(0, 3);
            this.mTileListExam.Name = "mTileListExam";
            this.mTileListExam.Size = new System.Drawing.Size(687, 40);
            this.mTileListExam.TabIndex = 5;
            this.mTileListExam.Text = "Danh sách kỳ thi";
            this.mTileListExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileListExam.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileListExam.UseSelectable = true;
            // 
            // mGridListExam
            // 
            this.mGridListExam.AllowUserToAddRows = false;
            this.mGridListExam.AllowUserToDeleteRows = false;
            this.mGridListExam.AllowUserToResizeRows = false;
            this.mGridListExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mGridListExam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListExam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridListExam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridListExam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridListExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridListExam.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridListExam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mGridListExam.EnableHeadersVisualStyles = false;
            this.mGridListExam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridListExam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListExam.Location = new System.Drawing.Point(0, 49);
            this.mGridListExam.Name = "mGridListExam";
            this.mGridListExam.ReadOnly = true;
            this.mGridListExam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListExam.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridListExam.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridListExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridListExam.Size = new System.Drawing.Size(1143, 487);
            this.mGridListExam.TabIndex = 2;
            // 
            // mTabEditExam
            // 
            this.mTabEditExam.Controls.Add(this.dateTimeEditTimeStart);
            this.mTabEditExam.Controls.Add(this.mDateTimeEditDateStart);
            this.mTabEditExam.Controls.Add(this.mTxtEditExamGradeId);
            this.mTabEditExam.Controls.Add(this.mLblEditExamGradeId);
            this.mTabEditExam.Controls.Add(this.mTxtEditExamSubjectId);
            this.mTabEditExam.Controls.Add(this.mLblEditExamSubjectId);
            this.mTabEditExam.Controls.Add(this.mCbbEditExamSubject);
            this.mTabEditExam.Controls.Add(this.mLblEditExamSubject);
            this.mTabEditExam.Controls.Add(this.mTxtEditDuration);
            this.mTabEditExam.Controls.Add(this.mLblEditDuration);
            this.mTabEditExam.Controls.Add(this.mLblEditStartTime);
            this.mTabEditExam.Controls.Add(this.mTxtEditExamName);
            this.mTabEditExam.Controls.Add(this.mLblEditExamName);
            this.mTabEditExam.Controls.Add(this.mTxtEditExamId);
            this.mTabEditExam.Controls.Add(this.mLblEditExamId);
            this.mTabEditExam.Controls.Add(this.mBtnSaveEditExam);
            this.mTabEditExam.Controls.Add(this.mTileEditExam);
            this.mTabEditExam.HorizontalScrollbarBarColor = true;
            this.mTabEditExam.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabEditExam.HorizontalScrollbarSize = 10;
            this.mTabEditExam.Location = new System.Drawing.Point(4, 38);
            this.mTabEditExam.Name = "mTabEditExam";
            this.mTabEditExam.Size = new System.Drawing.Size(1143, 536);
            this.mTabEditExam.TabIndex = 1;
            this.mTabEditExam.Text = "Chỉnh sửa kỳ thi";
            this.mTabEditExam.VerticalScrollbarBarColor = true;
            this.mTabEditExam.VerticalScrollbarHighlightOnWheel = false;
            this.mTabEditExam.VerticalScrollbarSize = 10;
            // 
            // dateTimeEditTimeStart
            // 
            this.dateTimeEditTimeStart.CustomFormat = " HH : mm";
            this.dateTimeEditTimeStart.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEditTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEditTimeStart.Location = new System.Drawing.Point(482, 124);
            this.dateTimeEditTimeStart.Name = "dateTimeEditTimeStart";
            this.dateTimeEditTimeStart.ShowUpDown = true;
            this.dateTimeEditTimeStart.Size = new System.Drawing.Size(102, 28);
            this.dateTimeEditTimeStart.TabIndex = 49;
            // 
            // mDateTimeEditDateStart
            // 
            this.mDateTimeEditDateStart.Location = new System.Drawing.Point(159, 124);
            this.mDateTimeEditDateStart.MinimumSize = new System.Drawing.Size(4, 29);
            this.mDateTimeEditDateStart.Name = "mDateTimeEditDateStart";
            this.mDateTimeEditDateStart.Size = new System.Drawing.Size(317, 29);
            this.mDateTimeEditDateStart.TabIndex = 48;
            // 
            // mTxtEditExamGradeId
            // 
            // 
            // 
            // 
            this.mTxtEditExamGradeId.CustomButton.Image = null;
            this.mTxtEditExamGradeId.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtEditExamGradeId.CustomButton.Name = "";
            this.mTxtEditExamGradeId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditExamGradeId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditExamGradeId.CustomButton.TabIndex = 1;
            this.mTxtEditExamGradeId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditExamGradeId.CustomButton.UseSelectable = true;
            this.mTxtEditExamGradeId.CustomButton.Visible = false;
            this.mTxtEditExamGradeId.Enabled = false;
            this.mTxtEditExamGradeId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditExamGradeId.Lines = new string[0];
            this.mTxtEditExamGradeId.Location = new System.Drawing.Point(717, 124);
            this.mTxtEditExamGradeId.MaxLength = 32767;
            this.mTxtEditExamGradeId.Name = "mTxtEditExamGradeId";
            this.mTxtEditExamGradeId.PasswordChar = '\0';
            this.mTxtEditExamGradeId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditExamGradeId.SelectedText = "";
            this.mTxtEditExamGradeId.SelectionLength = 0;
            this.mTxtEditExamGradeId.SelectionStart = 0;
            this.mTxtEditExamGradeId.ShortcutsEnabled = true;
            this.mTxtEditExamGradeId.Size = new System.Drawing.Size(426, 25);
            this.mTxtEditExamGradeId.TabIndex = 46;
            this.mTxtEditExamGradeId.UseSelectable = true;
            this.mTxtEditExamGradeId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditExamGradeId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditExamGradeId
            // 
            this.mLblEditExamGradeId.AutoSize = true;
            this.mLblEditExamGradeId.Location = new System.Drawing.Point(627, 124);
            this.mLblEditExamGradeId.Name = "mLblEditExamGradeId";
            this.mLblEditExamGradeId.Size = new System.Drawing.Size(57, 19);
            this.mLblEditExamGradeId.TabIndex = 44;
            this.mLblEditExamGradeId.Text = "Khối lớp";
            // 
            // mTxtEditExamSubjectId
            // 
            // 
            // 
            // 
            this.mTxtEditExamSubjectId.CustomButton.Image = null;
            this.mTxtEditExamSubjectId.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtEditExamSubjectId.CustomButton.Name = "";
            this.mTxtEditExamSubjectId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditExamSubjectId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditExamSubjectId.CustomButton.TabIndex = 1;
            this.mTxtEditExamSubjectId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditExamSubjectId.CustomButton.UseSelectable = true;
            this.mTxtEditExamSubjectId.CustomButton.Visible = false;
            this.mTxtEditExamSubjectId.Enabled = false;
            this.mTxtEditExamSubjectId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditExamSubjectId.Lines = new string[0];
            this.mTxtEditExamSubjectId.Location = new System.Drawing.Point(717, 93);
            this.mTxtEditExamSubjectId.MaxLength = 32767;
            this.mTxtEditExamSubjectId.Name = "mTxtEditExamSubjectId";
            this.mTxtEditExamSubjectId.PasswordChar = '\0';
            this.mTxtEditExamSubjectId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditExamSubjectId.SelectedText = "";
            this.mTxtEditExamSubjectId.SelectionLength = 0;
            this.mTxtEditExamSubjectId.SelectionStart = 0;
            this.mTxtEditExamSubjectId.ShortcutsEnabled = true;
            this.mTxtEditExamSubjectId.Size = new System.Drawing.Size(426, 25);
            this.mTxtEditExamSubjectId.TabIndex = 47;
            this.mTxtEditExamSubjectId.UseSelectable = true;
            this.mTxtEditExamSubjectId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditExamSubjectId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditExamSubjectId
            // 
            this.mLblEditExamSubjectId.AutoSize = true;
            this.mLblEditExamSubjectId.Location = new System.Drawing.Point(627, 93);
            this.mLblEditExamSubjectId.Name = "mLblEditExamSubjectId";
            this.mLblEditExamSubjectId.Size = new System.Drawing.Size(84, 19);
            this.mLblEditExamSubjectId.TabIndex = 45;
            this.mLblEditExamSubjectId.Text = "Mã môn học";
            // 
            // mCbbEditExamSubject
            // 
            this.mCbbEditExamSubject.FormattingEnabled = true;
            this.mCbbEditExamSubject.ItemHeight = 23;
            this.mCbbEditExamSubject.Location = new System.Drawing.Point(717, 58);
            this.mCbbEditExamSubject.Name = "mCbbEditExamSubject";
            this.mCbbEditExamSubject.Size = new System.Drawing.Size(426, 29);
            this.mCbbEditExamSubject.TabIndex = 43;
            this.mCbbEditExamSubject.UseSelectable = true;
            // 
            // mLblEditExamSubject
            // 
            this.mLblEditExamSubject.AutoSize = true;
            this.mLblEditExamSubject.Location = new System.Drawing.Point(627, 58);
            this.mLblEditExamSubject.Name = "mLblEditExamSubject";
            this.mLblEditExamSubject.Size = new System.Drawing.Size(61, 19);
            this.mLblEditExamSubject.TabIndex = 42;
            this.mLblEditExamSubject.Text = "Môn học";
            // 
            // mTxtEditDuration
            // 
            // 
            // 
            // 
            this.mTxtEditDuration.CustomButton.Image = null;
            this.mTxtEditDuration.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtEditDuration.CustomButton.Name = "";
            this.mTxtEditDuration.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditDuration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditDuration.CustomButton.TabIndex = 1;
            this.mTxtEditDuration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditDuration.CustomButton.UseSelectable = true;
            this.mTxtEditDuration.CustomButton.Visible = false;
            this.mTxtEditDuration.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditDuration.Lines = new string[0];
            this.mTxtEditDuration.Location = new System.Drawing.Point(159, 159);
            this.mTxtEditDuration.MaxLength = 32767;
            this.mTxtEditDuration.Name = "mTxtEditDuration";
            this.mTxtEditDuration.PasswordChar = '\0';
            this.mTxtEditDuration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditDuration.SelectedText = "";
            this.mTxtEditDuration.SelectionLength = 0;
            this.mTxtEditDuration.SelectionStart = 0;
            this.mTxtEditDuration.ShortcutsEnabled = true;
            this.mTxtEditDuration.Size = new System.Drawing.Size(426, 25);
            this.mTxtEditDuration.TabIndex = 41;
            this.mTxtEditDuration.UseSelectable = true;
            this.mTxtEditDuration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditDuration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditDuration
            // 
            this.mLblEditDuration.AutoSize = true;
            this.mLblEditDuration.Location = new System.Drawing.Point(-1, 159);
            this.mLblEditDuration.Name = "mLblEditDuration";
            this.mLblEditDuration.Size = new System.Drawing.Size(149, 19);
            this.mLblEditDuration.TabIndex = 40;
            this.mLblEditDuration.Text = "Thời gian làm bài (phút)";
            // 
            // mLblEditStartTime
            // 
            this.mLblEditStartTime.AutoSize = true;
            this.mLblEditStartTime.Location = new System.Drawing.Point(-1, 124);
            this.mLblEditStartTime.Name = "mLblEditStartTime";
            this.mLblEditStartTime.Size = new System.Drawing.Size(112, 19);
            this.mLblEditStartTime.TabIndex = 40;
            this.mLblEditStartTime.Text = "Ngày giờ bắt đầu";
            // 
            // mTxtEditExamName
            // 
            // 
            // 
            // 
            this.mTxtEditExamName.CustomButton.Image = null;
            this.mTxtEditExamName.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtEditExamName.CustomButton.Name = "";
            this.mTxtEditExamName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditExamName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditExamName.CustomButton.TabIndex = 1;
            this.mTxtEditExamName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditExamName.CustomButton.UseSelectable = true;
            this.mTxtEditExamName.CustomButton.Visible = false;
            this.mTxtEditExamName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditExamName.Lines = new string[0];
            this.mTxtEditExamName.Location = new System.Drawing.Point(159, 93);
            this.mTxtEditExamName.MaxLength = 32767;
            this.mTxtEditExamName.Name = "mTxtEditExamName";
            this.mTxtEditExamName.PasswordChar = '\0';
            this.mTxtEditExamName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditExamName.SelectedText = "";
            this.mTxtEditExamName.SelectionLength = 0;
            this.mTxtEditExamName.SelectionStart = 0;
            this.mTxtEditExamName.ShortcutsEnabled = true;
            this.mTxtEditExamName.Size = new System.Drawing.Size(426, 25);
            this.mTxtEditExamName.TabIndex = 41;
            this.mTxtEditExamName.UseSelectable = true;
            this.mTxtEditExamName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditExamName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditExamName
            // 
            this.mLblEditExamName.AutoSize = true;
            this.mLblEditExamName.Location = new System.Drawing.Point(0, 93);
            this.mLblEditExamName.Name = "mLblEditExamName";
            this.mLblEditExamName.Size = new System.Drawing.Size(62, 19);
            this.mLblEditExamName.TabIndex = 40;
            this.mLblEditExamName.Text = "Tên kỳ thi";
            // 
            // mTxtEditExamId
            // 
            // 
            // 
            // 
            this.mTxtEditExamId.CustomButton.Image = null;
            this.mTxtEditExamId.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtEditExamId.CustomButton.Name = "";
            this.mTxtEditExamId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditExamId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditExamId.CustomButton.TabIndex = 1;
            this.mTxtEditExamId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditExamId.CustomButton.UseSelectable = true;
            this.mTxtEditExamId.CustomButton.Visible = false;
            this.mTxtEditExamId.Enabled = false;
            this.mTxtEditExamId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditExamId.Lines = new string[0];
            this.mTxtEditExamId.Location = new System.Drawing.Point(159, 58);
            this.mTxtEditExamId.MaxLength = 32767;
            this.mTxtEditExamId.Name = "mTxtEditExamId";
            this.mTxtEditExamId.PasswordChar = '\0';
            this.mTxtEditExamId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditExamId.SelectedText = "";
            this.mTxtEditExamId.SelectionLength = 0;
            this.mTxtEditExamId.SelectionStart = 0;
            this.mTxtEditExamId.ShortcutsEnabled = true;
            this.mTxtEditExamId.Size = new System.Drawing.Size(426, 25);
            this.mTxtEditExamId.TabIndex = 41;
            this.mTxtEditExamId.UseSelectable = true;
            this.mTxtEditExamId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditExamId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditExamId
            // 
            this.mLblEditExamId.AutoSize = true;
            this.mLblEditExamId.Location = new System.Drawing.Point(0, 58);
            this.mLblEditExamId.Name = "mLblEditExamId";
            this.mLblEditExamId.Size = new System.Drawing.Size(62, 19);
            this.mLblEditExamId.TabIndex = 40;
            this.mLblEditExamId.Text = "Mã kỳ thi";
            // 
            // mBtnSaveEditExam
            // 
            this.mBtnSaveEditExam.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnSaveEditExam.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnSaveEditExam.Location = new System.Drawing.Point(921, 3);
            this.mBtnSaveEditExam.Name = "mBtnSaveEditExam";
            this.mBtnSaveEditExam.Size = new System.Drawing.Size(222, 40);
            this.mBtnSaveEditExam.TabIndex = 7;
            this.mBtnSaveEditExam.Text = "Lưu chỉnh sửa";
            this.mBtnSaveEditExam.UseSelectable = true;
            // 
            // mTileEditExam
            // 
            this.mTileEditExam.ActiveControl = null;
            this.mTileEditExam.Location = new System.Drawing.Point(0, 3);
            this.mTileEditExam.Name = "mTileEditExam";
            this.mTileEditExam.Size = new System.Drawing.Size(915, 40);
            this.mTileEditExam.TabIndex = 6;
            this.mTileEditExam.Text = "Chỉnh sửa kỳ thi";
            this.mTileEditExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileEditExam.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileEditExam.UseSelectable = true;
            // 
            // mTabAddExam
            // 
            this.mTabAddExam.Controls.Add(this.dateTimeAddTimeStart);
            this.mTabAddExam.Controls.Add(this.mDateTimeAddDateStart);
            this.mTabAddExam.Controls.Add(this.mTxtAddExamGradeId);
            this.mTabAddExam.Controls.Add(this.mLblAddGradeId);
            this.mTabAddExam.Controls.Add(this.mTxtAddExamSubjectId);
            this.mTabAddExam.Controls.Add(this.mLblAddExamSubjectId);
            this.mTabAddExam.Controls.Add(this.mCbbAddExamSubject);
            this.mTabAddExam.Controls.Add(this.mLblAddExamSubject);
            this.mTabAddExam.Controls.Add(this.mTxtAddDuration);
            this.mTabAddExam.Controls.Add(this.mLblAddDuration);
            this.mTabAddExam.Controls.Add(this.mLblAddStartTime);
            this.mTabAddExam.Controls.Add(this.mTxtAddExamName);
            this.mTabAddExam.Controls.Add(this.mLblAddExamName);
            this.mTabAddExam.Controls.Add(this.mBtnAddExam);
            this.mTabAddExam.Controls.Add(this.mTileAddExam);
            this.mTabAddExam.HorizontalScrollbarBarColor = true;
            this.mTabAddExam.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabAddExam.HorizontalScrollbarSize = 10;
            this.mTabAddExam.Location = new System.Drawing.Point(4, 38);
            this.mTabAddExam.Name = "mTabAddExam";
            this.mTabAddExam.Size = new System.Drawing.Size(1143, 536);
            this.mTabAddExam.TabIndex = 2;
            this.mTabAddExam.Text = "Tạo kỳ thi";
            this.mTabAddExam.VerticalScrollbarBarColor = true;
            this.mTabAddExam.VerticalScrollbarHighlightOnWheel = false;
            this.mTabAddExam.VerticalScrollbarSize = 10;
            // 
            // dateTimeAddTimeStart
            // 
            this.dateTimeAddTimeStart.CustomFormat = " HH : mm";
            this.dateTimeAddTimeStart.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAddTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAddTimeStart.Location = new System.Drawing.Point(482, 89);
            this.dateTimeAddTimeStart.Name = "dateTimeAddTimeStart";
            this.dateTimeAddTimeStart.ShowUpDown = true;
            this.dateTimeAddTimeStart.Size = new System.Drawing.Size(102, 28);
            this.dateTimeAddTimeStart.TabIndex = 67;
            // 
            // mDateTimeAddDateStart
            // 
            this.mDateTimeAddDateStart.Location = new System.Drawing.Point(159, 89);
            this.mDateTimeAddDateStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.mDateTimeAddDateStart.Name = "mDateTimeAddDateStart";
            this.mDateTimeAddDateStart.Size = new System.Drawing.Size(317, 29);
            this.mDateTimeAddDateStart.TabIndex = 66;
            // 
            // mTxtAddExamGradeId
            // 
            // 
            // 
            // 
            this.mTxtAddExamGradeId.CustomButton.Image = null;
            this.mTxtAddExamGradeId.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtAddExamGradeId.CustomButton.Name = "";
            this.mTxtAddExamGradeId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtAddExamGradeId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtAddExamGradeId.CustomButton.TabIndex = 1;
            this.mTxtAddExamGradeId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtAddExamGradeId.CustomButton.UseSelectable = true;
            this.mTxtAddExamGradeId.CustomButton.Visible = false;
            this.mTxtAddExamGradeId.Enabled = false;
            this.mTxtAddExamGradeId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtAddExamGradeId.Lines = new string[0];
            this.mTxtAddExamGradeId.Location = new System.Drawing.Point(717, 124);
            this.mTxtAddExamGradeId.MaxLength = 32767;
            this.mTxtAddExamGradeId.Name = "mTxtAddExamGradeId";
            this.mTxtAddExamGradeId.PasswordChar = '\0';
            this.mTxtAddExamGradeId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtAddExamGradeId.SelectedText = "";
            this.mTxtAddExamGradeId.SelectionLength = 0;
            this.mTxtAddExamGradeId.SelectionStart = 0;
            this.mTxtAddExamGradeId.ShortcutsEnabled = true;
            this.mTxtAddExamGradeId.Size = new System.Drawing.Size(426, 25);
            this.mTxtAddExamGradeId.TabIndex = 64;
            this.mTxtAddExamGradeId.UseSelectable = true;
            this.mTxtAddExamGradeId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtAddExamGradeId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblAddGradeId
            // 
            this.mLblAddGradeId.AutoSize = true;
            this.mLblAddGradeId.Location = new System.Drawing.Point(627, 124);
            this.mLblAddGradeId.Name = "mLblAddGradeId";
            this.mLblAddGradeId.Size = new System.Drawing.Size(57, 19);
            this.mLblAddGradeId.TabIndex = 62;
            this.mLblAddGradeId.Text = "Khối lớp";
            // 
            // mTxtAddExamSubjectId
            // 
            // 
            // 
            // 
            this.mTxtAddExamSubjectId.CustomButton.Image = null;
            this.mTxtAddExamSubjectId.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtAddExamSubjectId.CustomButton.Name = "";
            this.mTxtAddExamSubjectId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtAddExamSubjectId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtAddExamSubjectId.CustomButton.TabIndex = 1;
            this.mTxtAddExamSubjectId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtAddExamSubjectId.CustomButton.UseSelectable = true;
            this.mTxtAddExamSubjectId.CustomButton.Visible = false;
            this.mTxtAddExamSubjectId.Enabled = false;
            this.mTxtAddExamSubjectId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtAddExamSubjectId.Lines = new string[0];
            this.mTxtAddExamSubjectId.Location = new System.Drawing.Point(717, 93);
            this.mTxtAddExamSubjectId.MaxLength = 32767;
            this.mTxtAddExamSubjectId.Name = "mTxtAddExamSubjectId";
            this.mTxtAddExamSubjectId.PasswordChar = '\0';
            this.mTxtAddExamSubjectId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtAddExamSubjectId.SelectedText = "";
            this.mTxtAddExamSubjectId.SelectionLength = 0;
            this.mTxtAddExamSubjectId.SelectionStart = 0;
            this.mTxtAddExamSubjectId.ShortcutsEnabled = true;
            this.mTxtAddExamSubjectId.Size = new System.Drawing.Size(426, 25);
            this.mTxtAddExamSubjectId.TabIndex = 65;
            this.mTxtAddExamSubjectId.UseSelectable = true;
            this.mTxtAddExamSubjectId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtAddExamSubjectId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblAddExamSubjectId
            // 
            this.mLblAddExamSubjectId.AutoSize = true;
            this.mLblAddExamSubjectId.Location = new System.Drawing.Point(627, 93);
            this.mLblAddExamSubjectId.Name = "mLblAddExamSubjectId";
            this.mLblAddExamSubjectId.Size = new System.Drawing.Size(84, 19);
            this.mLblAddExamSubjectId.TabIndex = 63;
            this.mLblAddExamSubjectId.Text = "Mã môn học";
            // 
            // mCbbAddExamSubject
            // 
            this.mCbbAddExamSubject.FormattingEnabled = true;
            this.mCbbAddExamSubject.ItemHeight = 23;
            this.mCbbAddExamSubject.Location = new System.Drawing.Point(717, 58);
            this.mCbbAddExamSubject.Name = "mCbbAddExamSubject";
            this.mCbbAddExamSubject.Size = new System.Drawing.Size(426, 29);
            this.mCbbAddExamSubject.TabIndex = 61;
            this.mCbbAddExamSubject.UseSelectable = true;
            // 
            // mLblAddExamSubject
            // 
            this.mLblAddExamSubject.AutoSize = true;
            this.mLblAddExamSubject.Location = new System.Drawing.Point(627, 58);
            this.mLblAddExamSubject.Name = "mLblAddExamSubject";
            this.mLblAddExamSubject.Size = new System.Drawing.Size(61, 19);
            this.mLblAddExamSubject.TabIndex = 60;
            this.mLblAddExamSubject.Text = "Môn học";
            // 
            // mTxtAddDuration
            // 
            // 
            // 
            // 
            this.mTxtAddDuration.CustomButton.Image = null;
            this.mTxtAddDuration.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtAddDuration.CustomButton.Name = "";
            this.mTxtAddDuration.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtAddDuration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtAddDuration.CustomButton.TabIndex = 1;
            this.mTxtAddDuration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtAddDuration.CustomButton.UseSelectable = true;
            this.mTxtAddDuration.CustomButton.Visible = false;
            this.mTxtAddDuration.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtAddDuration.Lines = new string[0];
            this.mTxtAddDuration.Location = new System.Drawing.Point(159, 124);
            this.mTxtAddDuration.MaxLength = 32767;
            this.mTxtAddDuration.Name = "mTxtAddDuration";
            this.mTxtAddDuration.PasswordChar = '\0';
            this.mTxtAddDuration.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtAddDuration.SelectedText = "";
            this.mTxtAddDuration.SelectionLength = 0;
            this.mTxtAddDuration.SelectionStart = 0;
            this.mTxtAddDuration.ShortcutsEnabled = true;
            this.mTxtAddDuration.Size = new System.Drawing.Size(426, 25);
            this.mTxtAddDuration.TabIndex = 57;
            this.mTxtAddDuration.UseSelectable = true;
            this.mTxtAddDuration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtAddDuration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblAddDuration
            // 
            this.mLblAddDuration.AutoSize = true;
            this.mLblAddDuration.Location = new System.Drawing.Point(-1, 124);
            this.mLblAddDuration.Name = "mLblAddDuration";
            this.mLblAddDuration.Size = new System.Drawing.Size(149, 19);
            this.mLblAddDuration.TabIndex = 53;
            this.mLblAddDuration.Text = "Thời gian làm bài (phút)";
            // 
            // mLblAddStartTime
            // 
            this.mLblAddStartTime.AutoSize = true;
            this.mLblAddStartTime.Location = new System.Drawing.Point(-1, 89);
            this.mLblAddStartTime.Name = "mLblAddStartTime";
            this.mLblAddStartTime.Size = new System.Drawing.Size(112, 19);
            this.mLblAddStartTime.TabIndex = 54;
            this.mLblAddStartTime.Text = "Ngày giờ bắt đầu";
            // 
            // mTxtAddExamName
            // 
            // 
            // 
            // 
            this.mTxtAddExamName.CustomButton.Image = null;
            this.mTxtAddExamName.CustomButton.Location = new System.Drawing.Point(402, 1);
            this.mTxtAddExamName.CustomButton.Name = "";
            this.mTxtAddExamName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtAddExamName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtAddExamName.CustomButton.TabIndex = 1;
            this.mTxtAddExamName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtAddExamName.CustomButton.UseSelectable = true;
            this.mTxtAddExamName.CustomButton.Visible = false;
            this.mTxtAddExamName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtAddExamName.Lines = new string[0];
            this.mTxtAddExamName.Location = new System.Drawing.Point(159, 58);
            this.mTxtAddExamName.MaxLength = 32767;
            this.mTxtAddExamName.Name = "mTxtAddExamName";
            this.mTxtAddExamName.PasswordChar = '\0';
            this.mTxtAddExamName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtAddExamName.SelectedText = "";
            this.mTxtAddExamName.SelectionLength = 0;
            this.mTxtAddExamName.SelectionStart = 0;
            this.mTxtAddExamName.ShortcutsEnabled = true;
            this.mTxtAddExamName.Size = new System.Drawing.Size(426, 25);
            this.mTxtAddExamName.TabIndex = 58;
            this.mTxtAddExamName.UseSelectable = true;
            this.mTxtAddExamName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtAddExamName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblAddExamName
            // 
            this.mLblAddExamName.AutoSize = true;
            this.mLblAddExamName.Location = new System.Drawing.Point(0, 58);
            this.mLblAddExamName.Name = "mLblAddExamName";
            this.mLblAddExamName.Size = new System.Drawing.Size(62, 19);
            this.mLblAddExamName.TabIndex = 55;
            this.mLblAddExamName.Text = "Tên kỳ thi";
            // 
            // mBtnAddExam
            // 
            this.mBtnAddExam.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnAddExam.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnAddExam.Location = new System.Drawing.Point(921, 3);
            this.mBtnAddExam.Name = "mBtnAddExam";
            this.mBtnAddExam.Size = new System.Drawing.Size(222, 40);
            this.mBtnAddExam.TabIndex = 52;
            this.mBtnAddExam.Text = "Tạo kỳ thi";
            this.mBtnAddExam.UseSelectable = true;
            // 
            // mTileAddExam
            // 
            this.mTileAddExam.ActiveControl = null;
            this.mTileAddExam.Location = new System.Drawing.Point(0, 3);
            this.mTileAddExam.Name = "mTileAddExam";
            this.mTileAddExam.Size = new System.Drawing.Size(915, 40);
            this.mTileAddExam.TabIndex = 50;
            this.mTileAddExam.Text = "Tạo kỳ thi mới";
            this.mTileAddExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileAddExam.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileAddExam.UseSelectable = true;
            // 
            // mTabReport
            // 
            this.mTabReport.HorizontalScrollbarBarColor = true;
            this.mTabReport.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabReport.HorizontalScrollbarSize = 10;
            this.mTabReport.Location = new System.Drawing.Point(4, 38);
            this.mTabReport.Name = "mTabReport";
            this.mTabReport.Size = new System.Drawing.Size(1143, 536);
            this.mTabReport.TabIndex = 3;
            this.mTabReport.Text = "Thống kê / In";
            this.mTabReport.VerticalScrollbarBarColor = true;
            this.mTabReport.VerticalScrollbarHighlightOnWheel = false;
            this.mTabReport.VerticalScrollbarSize = 10;
            // 
            // frmExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 658);
            this.Controls.Add(this.mTabExam);
            this.MaximizeBox = false;
            this.Name = "frmExam";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Quản lý kỳ thi";
            this.mTabExam.ResumeLayout(false);
            this.mTabListExam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridListExam)).EndInit();
            this.mTabEditExam.ResumeLayout(false);
            this.mTabEditExam.PerformLayout();
            this.mTabAddExam.ResumeLayout(false);
            this.mTabAddExam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabExam;
        private MetroFramework.Controls.MetroTabPage mTabListExam;
        private MetroFramework.Controls.MetroButton mBtnDeleteExam;
        private MetroFramework.Controls.MetroButton mBtnReloadListExam;
        private MetroFramework.Controls.MetroTile mTileListExam;
        private MetroFramework.Controls.MetroGrid mGridListExam;
        private MetroFramework.Controls.MetroTabPage mTabEditExam;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamGradeId;
        private MetroFramework.Controls.MetroLabel mLblEditExamGradeId;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamSubjectId;
        private MetroFramework.Controls.MetroLabel mLblEditExamSubjectId;
        private MetroFramework.Controls.MetroComboBox mCbbEditExamSubject;
        private MetroFramework.Controls.MetroLabel mLblEditExamSubject;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamName;
        private MetroFramework.Controls.MetroLabel mLblEditExamName;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamId;
        private MetroFramework.Controls.MetroLabel mLblEditExamId;
        private MetroFramework.Controls.MetroButton mBtnSaveEditExam;
        private MetroFramework.Controls.MetroTile mTileEditExam;
        private MetroFramework.Controls.MetroTabPage mTabAddExam;
        private MetroFramework.Controls.MetroButton mBtnAddExam;
        private MetroFramework.Controls.MetroTile mTileAddExam;
        private MetroFramework.Controls.MetroLabel mLblEditStartTime;
        private MetroFramework.Controls.MetroTextBox mTxtEditDuration;
        private MetroFramework.Controls.MetroLabel mLblEditDuration;
        private MetroFramework.Controls.MetroDateTime mDateTimeEditDateStart;
        private System.Windows.Forms.DateTimePicker dateTimeEditTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeAddTimeStart;
        private MetroFramework.Controls.MetroDateTime mDateTimeAddDateStart;
        private MetroFramework.Controls.MetroTextBox mTxtAddExamGradeId;
        private MetroFramework.Controls.MetroLabel mLblAddGradeId;
        private MetroFramework.Controls.MetroTextBox mTxtAddExamSubjectId;
        private MetroFramework.Controls.MetroLabel mLblAddExamSubjectId;
        private MetroFramework.Controls.MetroComboBox mCbbAddExamSubject;
        private MetroFramework.Controls.MetroLabel mLblAddExamSubject;
        private MetroFramework.Controls.MetroTextBox mTxtAddDuration;
        private MetroFramework.Controls.MetroLabel mLblAddDuration;
        private MetroFramework.Controls.MetroLabel mLblAddStartTime;
        private MetroFramework.Controls.MetroTextBox mTxtAddExamName;
        private MetroFramework.Controls.MetroLabel mLblAddExamName;
        private MetroFramework.Controls.MetroTabPage mTabReport;
    }
}