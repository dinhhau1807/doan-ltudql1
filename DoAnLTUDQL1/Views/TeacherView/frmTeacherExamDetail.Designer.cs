namespace DoAnLTUDQL1.Views.TeacherView
{
    partial class frmTeacherExamDetail
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
			this.mTabExamDetail = new MetroFramework.Controls.MetroTabControl();
			this.mTabListExamDetail = new MetroFramework.Controls.MetroTabPage();
			this.mGridListExamDetail = new MetroFramework.Controls.MetroGrid();
			this.mBtnDeleteExamDetail = new MetroFramework.Controls.MetroButton();
			this.mBtnReloadListExamDetail = new MetroFramework.Controls.MetroButton();
			this.mTileListExamDetail = new MetroFramework.Controls.MetroTile();
			this.mTabEditExamDetail = new MetroFramework.Controls.MetroTabPage();
			this.dateTimeEditTimeStart = new System.Windows.Forms.DateTimePicker();
			this.mDateTimeEditDateStart = new MetroFramework.Controls.MetroDateTime();
			this.mTxtEditDuration = new MetroFramework.Controls.MetroTextBox();
			this.mLblEditDuration = new MetroFramework.Controls.MetroLabel();
			this.mLblEditStartTime = new MetroFramework.Controls.MetroLabel();
			this.mTxtEditExamDetailGradeId = new MetroFramework.Controls.MetroTextBox();
			this.mLblEditExamDetailGradeId = new MetroFramework.Controls.MetroLabel();
			this.mTxtEditExamDetailSubjectId = new MetroFramework.Controls.MetroTextBox();
			this.mLblEditExamDetailSubjectId = new MetroFramework.Controls.MetroLabel();
			this.mCbbEditExamDetailSubject = new MetroFramework.Controls.MetroComboBox();
			this.mLblEditExamDetailSubject = new MetroFramework.Controls.MetroLabel();
			this.mBtnSaveEditExamDetail = new MetroFramework.Controls.MetroButton();
			this.mTileEditExamDetail = new MetroFramework.Controls.MetroTile();
			this.mTabAddExamDetail = new MetroFramework.Controls.MetroTabPage();
			this.dateTimeAddTimeStart = new System.Windows.Forms.DateTimePicker();
			this.mDateTimeAddDateStart = new MetroFramework.Controls.MetroDateTime();
			this.mTxtAddDuration = new MetroFramework.Controls.MetroTextBox();
			this.mLblAddDuration = new MetroFramework.Controls.MetroLabel();
			this.mLblAddStartTime = new MetroFramework.Controls.MetroLabel();
			this.mTxtAddExamDetailGradeId = new MetroFramework.Controls.MetroTextBox();
			this.mLblAddExamDetailGradeId = new MetroFramework.Controls.MetroLabel();
			this.mTxtAddExamDetailSubjectId = new MetroFramework.Controls.MetroTextBox();
			this.mLblAddExamDetailSubjectId = new MetroFramework.Controls.MetroLabel();
			this.mCbbAddExamDetailSubject = new MetroFramework.Controls.MetroComboBox();
			this.mLblAddExamDetailSubject = new MetroFramework.Controls.MetroLabel();
			this.mBtnAddExamDetail = new MetroFramework.Controls.MetroButton();
			this.mTileAddExamDetail = new MetroFramework.Controls.MetroTile();
			this.mTabExamDetail.SuspendLayout();
			this.mTabListExamDetail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mGridListExamDetail)).BeginInit();
			this.mTabEditExamDetail.SuspendLayout();
			this.mTabAddExamDetail.SuspendLayout();
			this.SuspendLayout();
			// 
			// mTabExamDetail
			// 
			this.mTabExamDetail.Controls.Add(this.mTabListExamDetail);
			this.mTabExamDetail.Controls.Add(this.mTabEditExamDetail);
			this.mTabExamDetail.Controls.Add(this.mTabAddExamDetail);
			this.mTabExamDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mTabExamDetail.Location = new System.Drawing.Point(27, 74);
			this.mTabExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTabExamDetail.Name = "mTabExamDetail";
			this.mTabExamDetail.SelectedIndex = 0;
			this.mTabExamDetail.Size = new System.Drawing.Size(1233, 601);
			this.mTabExamDetail.TabIndex = 0;
			this.mTabExamDetail.UseSelectable = true;
			// 
			// mTabListExamDetail
			// 
			this.mTabListExamDetail.Controls.Add(this.mGridListExamDetail);
			this.mTabListExamDetail.Controls.Add(this.mBtnDeleteExamDetail);
			this.mTabListExamDetail.Controls.Add(this.mBtnReloadListExamDetail);
			this.mTabListExamDetail.Controls.Add(this.mTileListExamDetail);
			this.mTabListExamDetail.HorizontalScrollbarBarColor = true;
			this.mTabListExamDetail.HorizontalScrollbarHighlightOnWheel = false;
			this.mTabListExamDetail.HorizontalScrollbarSize = 12;
			this.mTabListExamDetail.Location = new System.Drawing.Point(4, 38);
			this.mTabListExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTabListExamDetail.Name = "mTabListExamDetail";
			this.mTabListExamDetail.Size = new System.Drawing.Size(1225, 559);
			this.mTabListExamDetail.TabIndex = 0;
			this.mTabListExamDetail.Text = "Danh sách môn thi";
			this.mTabListExamDetail.VerticalScrollbarBarColor = true;
			this.mTabListExamDetail.VerticalScrollbarHighlightOnWheel = false;
			this.mTabListExamDetail.VerticalScrollbarSize = 13;
			// 
			// mGridListExamDetail
			// 
			this.mGridListExamDetail.AllowUserToAddRows = false;
			this.mGridListExamDetail.AllowUserToDeleteRows = false;
			this.mGridListExamDetail.AllowUserToResizeRows = false;
			this.mGridListExamDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.mGridListExamDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mGridListExamDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mGridListExamDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.mGridListExamDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.mGridListExamDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.mGridListExamDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.mGridListExamDetail.DefaultCellStyle = dataGridViewCellStyle2;
			this.mGridListExamDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mGridListExamDetail.EnableHeadersVisualStyles = false;
			this.mGridListExamDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.mGridListExamDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.mGridListExamDetail.Location = new System.Drawing.Point(0, 69);
			this.mGridListExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mGridListExamDetail.Name = "mGridListExamDetail";
			this.mGridListExamDetail.ReadOnly = true;
			this.mGridListExamDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.mGridListExamDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.mGridListExamDetail.RowHeadersWidth = 51;
			this.mGridListExamDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.mGridListExamDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.mGridListExamDetail.Size = new System.Drawing.Size(1225, 490);
			this.mGridListExamDetail.TabIndex = 54;
			// 
			// mBtnDeleteExamDetail
			// 
			this.mBtnDeleteExamDetail.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mBtnDeleteExamDetail.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mBtnDeleteExamDetail.Location = new System.Drawing.Point(623, 4);
			this.mBtnDeleteExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mBtnDeleteExamDetail.Name = "mBtnDeleteExamDetail";
			this.mBtnDeleteExamDetail.Size = new System.Drawing.Size(296, 49);
			this.mBtnDeleteExamDetail.TabIndex = 52;
			this.mBtnDeleteExamDetail.Text = "Xoá môn thi";
			this.mBtnDeleteExamDetail.UseSelectable = true;
			// 
			// mBtnReloadListExamDetail
			// 
			this.mBtnReloadListExamDetail.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mBtnReloadListExamDetail.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mBtnReloadListExamDetail.Location = new System.Drawing.Point(927, 4);
			this.mBtnReloadListExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mBtnReloadListExamDetail.Name = "mBtnReloadListExamDetail";
			this.mBtnReloadListExamDetail.Size = new System.Drawing.Size(296, 49);
			this.mBtnReloadListExamDetail.TabIndex = 53;
			this.mBtnReloadListExamDetail.Text = "Tải lại danh sách";
			this.mBtnReloadListExamDetail.UseSelectable = true;
			// 
			// mTileListExamDetail
			// 
			this.mTileListExamDetail.ActiveControl = null;
			this.mTileListExamDetail.Location = new System.Drawing.Point(0, 4);
			this.mTileListExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTileListExamDetail.Name = "mTileListExamDetail";
			this.mTileListExamDetail.Size = new System.Drawing.Size(615, 49);
			this.mTileListExamDetail.TabIndex = 51;
			this.mTileListExamDetail.Text = "Danh sách môn thi";
			this.mTileListExamDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mTileListExamDetail.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.mTileListExamDetail.UseSelectable = true;
			// 
			// mTabEditExamDetail
			// 
			this.mTabEditExamDetail.Controls.Add(this.dateTimeEditTimeStart);
			this.mTabEditExamDetail.Controls.Add(this.mDateTimeEditDateStart);
			this.mTabEditExamDetail.Controls.Add(this.mTxtEditDuration);
			this.mTabEditExamDetail.Controls.Add(this.mLblEditDuration);
			this.mTabEditExamDetail.Controls.Add(this.mLblEditStartTime);
			this.mTabEditExamDetail.Controls.Add(this.mTxtEditExamDetailGradeId);
			this.mTabEditExamDetail.Controls.Add(this.mLblEditExamDetailGradeId);
			this.mTabEditExamDetail.Controls.Add(this.mTxtEditExamDetailSubjectId);
			this.mTabEditExamDetail.Controls.Add(this.mLblEditExamDetailSubjectId);
			this.mTabEditExamDetail.Controls.Add(this.mCbbEditExamDetailSubject);
			this.mTabEditExamDetail.Controls.Add(this.mLblEditExamDetailSubject);
			this.mTabEditExamDetail.Controls.Add(this.mBtnSaveEditExamDetail);
			this.mTabEditExamDetail.Controls.Add(this.mTileEditExamDetail);
			this.mTabEditExamDetail.HorizontalScrollbarBarColor = true;
			this.mTabEditExamDetail.HorizontalScrollbarHighlightOnWheel = false;
			this.mTabEditExamDetail.HorizontalScrollbarSize = 12;
			this.mTabEditExamDetail.Location = new System.Drawing.Point(4, 38);
			this.mTabEditExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTabEditExamDetail.Name = "mTabEditExamDetail";
			this.mTabEditExamDetail.Size = new System.Drawing.Size(1225, 559);
			this.mTabEditExamDetail.TabIndex = 1;
			this.mTabEditExamDetail.Text = "Chỉnh sửa môn thi";
			this.mTabEditExamDetail.VerticalScrollbarBarColor = true;
			this.mTabEditExamDetail.VerticalScrollbarHighlightOnWheel = false;
			this.mTabEditExamDetail.VerticalScrollbarSize = 13;
			// 
			// dateTimeEditTimeStart
			// 
			this.dateTimeEditTimeStart.CustomFormat = " HH : mm";
			this.dateTimeEditTimeStart.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeEditTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimeEditTimeStart.Location = new System.Drawing.Point(864, 192);
			this.dateTimeEditTimeStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimeEditTimeStart.Name = "dateTimeEditTimeStart";
			this.dateTimeEditTimeStart.ShowUpDown = true;
			this.dateTimeEditTimeStart.Size = new System.Drawing.Size(135, 33);
			this.dateTimeEditTimeStart.TabIndex = 82;
			// 
			// mDateTimeEditDateStart
			// 
			this.mDateTimeEditDateStart.CustomFormat = "dd/MM/yyyy";
			this.mDateTimeEditDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.mDateTimeEditDateStart.Location = new System.Drawing.Point(433, 192);
			this.mDateTimeEditDateStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mDateTimeEditDateStart.MinimumSize = new System.Drawing.Size(0, 30);
			this.mDateTimeEditDateStart.Name = "mDateTimeEditDateStart";
			this.mDateTimeEditDateStart.Size = new System.Drawing.Size(421, 30);
			this.mDateTimeEditDateStart.TabIndex = 81;
			// 
			// mTxtEditDuration
			// 
			// 
			// 
			// 
			this.mTxtEditDuration.CustomButton.Image = null;
			this.mTxtEditDuration.CustomButton.Location = new System.Drawing.Point(717, 1);
			this.mTxtEditDuration.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.mTxtEditDuration.CustomButton.Name = "";
			this.mTxtEditDuration.CustomButton.Size = new System.Drawing.Size(39, 36);
			this.mTxtEditDuration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mTxtEditDuration.CustomButton.TabIndex = 1;
			this.mTxtEditDuration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mTxtEditDuration.CustomButton.UseSelectable = true;
			this.mTxtEditDuration.CustomButton.Visible = false;
			this.mTxtEditDuration.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mTxtEditDuration.Lines = new string[0];
			this.mTxtEditDuration.Location = new System.Drawing.Point(433, 235);
			this.mTxtEditDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTxtEditDuration.MaxLength = 32767;
			this.mTxtEditDuration.Name = "mTxtEditDuration";
			this.mTxtEditDuration.PasswordChar = '\0';
			this.mTxtEditDuration.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mTxtEditDuration.SelectedText = "";
			this.mTxtEditDuration.SelectionLength = 0;
			this.mTxtEditDuration.SelectionStart = 0;
			this.mTxtEditDuration.ShortcutsEnabled = true;
			this.mTxtEditDuration.Size = new System.Drawing.Size(568, 31);
			this.mTxtEditDuration.TabIndex = 80;
			this.mTxtEditDuration.UseSelectable = true;
			this.mTxtEditDuration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mTxtEditDuration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mLblEditDuration
			// 
			this.mLblEditDuration.AutoSize = true;
			this.mLblEditDuration.Location = new System.Drawing.Point(220, 235);
			this.mLblEditDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mLblEditDuration.Name = "mLblEditDuration";
			this.mLblEditDuration.Size = new System.Drawing.Size(154, 20);
			this.mLblEditDuration.TabIndex = 78;
			this.mLblEditDuration.Text = "Thời gian làm bài (phút)";
			// 
			// mLblEditStartTime
			// 
			this.mLblEditStartTime.AutoSize = true;
			this.mLblEditStartTime.Location = new System.Drawing.Point(220, 192);
			this.mLblEditStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mLblEditStartTime.Name = "mLblEditStartTime";
			this.mLblEditStartTime.Size = new System.Drawing.Size(115, 20);
			this.mLblEditStartTime.TabIndex = 79;
			this.mLblEditStartTime.Text = "Ngày giờ bắt đầu";
			// 
			// mTxtEditExamDetailGradeId
			// 
			// 
			// 
			// 
			this.mTxtEditExamDetailGradeId.CustomButton.Image = null;
			this.mTxtEditExamDetailGradeId.CustomButton.Location = new System.Drawing.Point(717, 1);
			this.mTxtEditExamDetailGradeId.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.mTxtEditExamDetailGradeId.CustomButton.Name = "";
			this.mTxtEditExamDetailGradeId.CustomButton.Size = new System.Drawing.Size(39, 36);
			this.mTxtEditExamDetailGradeId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mTxtEditExamDetailGradeId.CustomButton.TabIndex = 1;
			this.mTxtEditExamDetailGradeId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mTxtEditExamDetailGradeId.CustomButton.UseSelectable = true;
			this.mTxtEditExamDetailGradeId.CustomButton.Visible = false;
			this.mTxtEditExamDetailGradeId.Enabled = false;
			this.mTxtEditExamDetailGradeId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mTxtEditExamDetailGradeId.Lines = new string[0];
			this.mTxtEditExamDetailGradeId.Location = new System.Drawing.Point(433, 154);
			this.mTxtEditExamDetailGradeId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTxtEditExamDetailGradeId.MaxLength = 32767;
			this.mTxtEditExamDetailGradeId.Name = "mTxtEditExamDetailGradeId";
			this.mTxtEditExamDetailGradeId.PasswordChar = '\0';
			this.mTxtEditExamDetailGradeId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mTxtEditExamDetailGradeId.SelectedText = "";
			this.mTxtEditExamDetailGradeId.SelectionLength = 0;
			this.mTxtEditExamDetailGradeId.SelectionStart = 0;
			this.mTxtEditExamDetailGradeId.ShortcutsEnabled = true;
			this.mTxtEditExamDetailGradeId.Size = new System.Drawing.Size(568, 31);
			this.mTxtEditExamDetailGradeId.TabIndex = 76;
			this.mTxtEditExamDetailGradeId.UseSelectable = true;
			this.mTxtEditExamDetailGradeId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mTxtEditExamDetailGradeId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mLblEditExamDetailGradeId
			// 
			this.mLblEditExamDetailGradeId.AutoSize = true;
			this.mLblEditExamDetailGradeId.Location = new System.Drawing.Point(220, 154);
			this.mLblEditExamDetailGradeId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mLblEditExamDetailGradeId.Name = "mLblEditExamDetailGradeId";
			this.mLblEditExamDetailGradeId.Size = new System.Drawing.Size(59, 20);
			this.mLblEditExamDetailGradeId.TabIndex = 74;
			this.mLblEditExamDetailGradeId.Text = "Khối lớp";
			// 
			// mTxtEditExamDetailSubjectId
			// 
			// 
			// 
			// 
			this.mTxtEditExamDetailSubjectId.CustomButton.Image = null;
			this.mTxtEditExamDetailSubjectId.CustomButton.Location = new System.Drawing.Point(717, 1);
			this.mTxtEditExamDetailSubjectId.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.mTxtEditExamDetailSubjectId.CustomButton.Name = "";
			this.mTxtEditExamDetailSubjectId.CustomButton.Size = new System.Drawing.Size(39, 36);
			this.mTxtEditExamDetailSubjectId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mTxtEditExamDetailSubjectId.CustomButton.TabIndex = 1;
			this.mTxtEditExamDetailSubjectId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mTxtEditExamDetailSubjectId.CustomButton.UseSelectable = true;
			this.mTxtEditExamDetailSubjectId.CustomButton.Visible = false;
			this.mTxtEditExamDetailSubjectId.Enabled = false;
			this.mTxtEditExamDetailSubjectId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mTxtEditExamDetailSubjectId.Lines = new string[0];
			this.mTxtEditExamDetailSubjectId.Location = new System.Drawing.Point(433, 116);
			this.mTxtEditExamDetailSubjectId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTxtEditExamDetailSubjectId.MaxLength = 32767;
			this.mTxtEditExamDetailSubjectId.Name = "mTxtEditExamDetailSubjectId";
			this.mTxtEditExamDetailSubjectId.PasswordChar = '\0';
			this.mTxtEditExamDetailSubjectId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mTxtEditExamDetailSubjectId.SelectedText = "";
			this.mTxtEditExamDetailSubjectId.SelectionLength = 0;
			this.mTxtEditExamDetailSubjectId.SelectionStart = 0;
			this.mTxtEditExamDetailSubjectId.ShortcutsEnabled = true;
			this.mTxtEditExamDetailSubjectId.Size = new System.Drawing.Size(568, 31);
			this.mTxtEditExamDetailSubjectId.TabIndex = 77;
			this.mTxtEditExamDetailSubjectId.UseSelectable = true;
			this.mTxtEditExamDetailSubjectId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mTxtEditExamDetailSubjectId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mLblEditExamDetailSubjectId
			// 
			this.mLblEditExamDetailSubjectId.AutoSize = true;
			this.mLblEditExamDetailSubjectId.Location = new System.Drawing.Point(220, 116);
			this.mLblEditExamDetailSubjectId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mLblEditExamDetailSubjectId.Name = "mLblEditExamDetailSubjectId";
			this.mLblEditExamDetailSubjectId.Size = new System.Drawing.Size(87, 20);
			this.mLblEditExamDetailSubjectId.TabIndex = 75;
			this.mLblEditExamDetailSubjectId.Text = "Mã môn học";
			// 
			// mCbbEditExamDetailSubject
			// 
			this.mCbbEditExamDetailSubject.FormattingEnabled = true;
			this.mCbbEditExamDetailSubject.ItemHeight = 24;
			this.mCbbEditExamDetailSubject.Location = new System.Drawing.Point(433, 73);
			this.mCbbEditExamDetailSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mCbbEditExamDetailSubject.Name = "mCbbEditExamDetailSubject";
			this.mCbbEditExamDetailSubject.Size = new System.Drawing.Size(567, 30);
			this.mCbbEditExamDetailSubject.TabIndex = 73;
			this.mCbbEditExamDetailSubject.UseSelectable = true;
			// 
			// mLblEditExamDetailSubject
			// 
			this.mLblEditExamDetailSubject.AutoSize = true;
			this.mLblEditExamDetailSubject.Location = new System.Drawing.Point(220, 73);
			this.mLblEditExamDetailSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mLblEditExamDetailSubject.Name = "mLblEditExamDetailSubject";
			this.mLblEditExamDetailSubject.Size = new System.Drawing.Size(64, 20);
			this.mLblEditExamDetailSubject.TabIndex = 72;
			this.mLblEditExamDetailSubject.Text = "Môn học";
			// 
			// mBtnSaveEditExamDetail
			// 
			this.mBtnSaveEditExamDetail.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mBtnSaveEditExamDetail.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mBtnSaveEditExamDetail.Location = new System.Drawing.Point(927, 4);
			this.mBtnSaveEditExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mBtnSaveEditExamDetail.Name = "mBtnSaveEditExamDetail";
			this.mBtnSaveEditExamDetail.Size = new System.Drawing.Size(296, 49);
			this.mBtnSaveEditExamDetail.TabIndex = 71;
			this.mBtnSaveEditExamDetail.Text = "Lưu chỉnh sửa";
			this.mBtnSaveEditExamDetail.UseSelectable = true;
			// 
			// mTileEditExamDetail
			// 
			this.mTileEditExamDetail.ActiveControl = null;
			this.mTileEditExamDetail.Location = new System.Drawing.Point(0, 4);
			this.mTileEditExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTileEditExamDetail.Name = "mTileEditExamDetail";
			this.mTileEditExamDetail.Size = new System.Drawing.Size(919, 49);
			this.mTileEditExamDetail.TabIndex = 70;
			this.mTileEditExamDetail.Text = "Chỉnh sửa môn thi";
			this.mTileEditExamDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mTileEditExamDetail.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.mTileEditExamDetail.UseSelectable = true;
			// 
			// mTabAddExamDetail
			// 
			this.mTabAddExamDetail.Controls.Add(this.dateTimeAddTimeStart);
			this.mTabAddExamDetail.Controls.Add(this.mDateTimeAddDateStart);
			this.mTabAddExamDetail.Controls.Add(this.mTxtAddDuration);
			this.mTabAddExamDetail.Controls.Add(this.mLblAddDuration);
			this.mTabAddExamDetail.Controls.Add(this.mLblAddStartTime);
			this.mTabAddExamDetail.Controls.Add(this.mTxtAddExamDetailGradeId);
			this.mTabAddExamDetail.Controls.Add(this.mLblAddExamDetailGradeId);
			this.mTabAddExamDetail.Controls.Add(this.mTxtAddExamDetailSubjectId);
			this.mTabAddExamDetail.Controls.Add(this.mLblAddExamDetailSubjectId);
			this.mTabAddExamDetail.Controls.Add(this.mCbbAddExamDetailSubject);
			this.mTabAddExamDetail.Controls.Add(this.mLblAddExamDetailSubject);
			this.mTabAddExamDetail.Controls.Add(this.mBtnAddExamDetail);
			this.mTabAddExamDetail.Controls.Add(this.mTileAddExamDetail);
			this.mTabAddExamDetail.HorizontalScrollbarBarColor = true;
			this.mTabAddExamDetail.HorizontalScrollbarHighlightOnWheel = false;
			this.mTabAddExamDetail.HorizontalScrollbarSize = 12;
			this.mTabAddExamDetail.Location = new System.Drawing.Point(4, 38);
			this.mTabAddExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTabAddExamDetail.Name = "mTabAddExamDetail";
			this.mTabAddExamDetail.Size = new System.Drawing.Size(1225, 559);
			this.mTabAddExamDetail.TabIndex = 2;
			this.mTabAddExamDetail.Text = "Thêm môn thi";
			this.mTabAddExamDetail.VerticalScrollbarBarColor = true;
			this.mTabAddExamDetail.VerticalScrollbarHighlightOnWheel = false;
			this.mTabAddExamDetail.VerticalScrollbarSize = 13;
			// 
			// dateTimeAddTimeStart
			// 
			this.dateTimeAddTimeStart.CustomFormat = " HH : mm";
			this.dateTimeAddTimeStart.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimeAddTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimeAddTimeStart.Location = new System.Drawing.Point(864, 192);
			this.dateTimeAddTimeStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimeAddTimeStart.Name = "dateTimeAddTimeStart";
			this.dateTimeAddTimeStart.ShowUpDown = true;
			this.dateTimeAddTimeStart.Size = new System.Drawing.Size(135, 33);
			this.dateTimeAddTimeStart.TabIndex = 95;
			// 
			// mDateTimeAddDateStart
			// 
			this.mDateTimeAddDateStart.CustomFormat = "dd/MM/yyyy";
			this.mDateTimeAddDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.mDateTimeAddDateStart.Location = new System.Drawing.Point(433, 192);
			this.mDateTimeAddDateStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mDateTimeAddDateStart.MinimumSize = new System.Drawing.Size(0, 30);
			this.mDateTimeAddDateStart.Name = "mDateTimeAddDateStart";
			this.mDateTimeAddDateStart.Size = new System.Drawing.Size(421, 30);
			this.mDateTimeAddDateStart.TabIndex = 94;
			// 
			// mTxtAddDuration
			// 
			// 
			// 
			// 
			this.mTxtAddDuration.CustomButton.Image = null;
			this.mTxtAddDuration.CustomButton.Location = new System.Drawing.Point(717, 1);
			this.mTxtAddDuration.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.mTxtAddDuration.CustomButton.Name = "";
			this.mTxtAddDuration.CustomButton.Size = new System.Drawing.Size(39, 36);
			this.mTxtAddDuration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mTxtAddDuration.CustomButton.TabIndex = 1;
			this.mTxtAddDuration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mTxtAddDuration.CustomButton.UseSelectable = true;
			this.mTxtAddDuration.CustomButton.Visible = false;
			this.mTxtAddDuration.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mTxtAddDuration.Lines = new string[0];
			this.mTxtAddDuration.Location = new System.Drawing.Point(433, 235);
			this.mTxtAddDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTxtAddDuration.MaxLength = 32767;
			this.mTxtAddDuration.Name = "mTxtAddDuration";
			this.mTxtAddDuration.PasswordChar = '\0';
			this.mTxtAddDuration.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mTxtAddDuration.SelectedText = "";
			this.mTxtAddDuration.SelectionLength = 0;
			this.mTxtAddDuration.SelectionStart = 0;
			this.mTxtAddDuration.ShortcutsEnabled = true;
			this.mTxtAddDuration.Size = new System.Drawing.Size(568, 31);
			this.mTxtAddDuration.TabIndex = 93;
			this.mTxtAddDuration.UseSelectable = true;
			this.mTxtAddDuration.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mTxtAddDuration.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mLblAddDuration
			// 
			this.mLblAddDuration.AutoSize = true;
			this.mLblAddDuration.Location = new System.Drawing.Point(220, 235);
			this.mLblAddDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mLblAddDuration.Name = "mLblAddDuration";
			this.mLblAddDuration.Size = new System.Drawing.Size(154, 20);
			this.mLblAddDuration.TabIndex = 91;
			this.mLblAddDuration.Text = "Thời gian làm bài (phút)";
			// 
			// mLblAddStartTime
			// 
			this.mLblAddStartTime.AutoSize = true;
			this.mLblAddStartTime.Location = new System.Drawing.Point(220, 192);
			this.mLblAddStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mLblAddStartTime.Name = "mLblAddStartTime";
			this.mLblAddStartTime.Size = new System.Drawing.Size(115, 20);
			this.mLblAddStartTime.TabIndex = 92;
			this.mLblAddStartTime.Text = "Ngày giờ bắt đầu";
			// 
			// mTxtAddExamDetailGradeId
			// 
			// 
			// 
			// 
			this.mTxtAddExamDetailGradeId.CustomButton.Image = null;
			this.mTxtAddExamDetailGradeId.CustomButton.Location = new System.Drawing.Point(717, 1);
			this.mTxtAddExamDetailGradeId.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.mTxtAddExamDetailGradeId.CustomButton.Name = "";
			this.mTxtAddExamDetailGradeId.CustomButton.Size = new System.Drawing.Size(39, 36);
			this.mTxtAddExamDetailGradeId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mTxtAddExamDetailGradeId.CustomButton.TabIndex = 1;
			this.mTxtAddExamDetailGradeId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mTxtAddExamDetailGradeId.CustomButton.UseSelectable = true;
			this.mTxtAddExamDetailGradeId.CustomButton.Visible = false;
			this.mTxtAddExamDetailGradeId.Enabled = false;
			this.mTxtAddExamDetailGradeId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mTxtAddExamDetailGradeId.Lines = new string[0];
			this.mTxtAddExamDetailGradeId.Location = new System.Drawing.Point(433, 154);
			this.mTxtAddExamDetailGradeId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTxtAddExamDetailGradeId.MaxLength = 32767;
			this.mTxtAddExamDetailGradeId.Name = "mTxtAddExamDetailGradeId";
			this.mTxtAddExamDetailGradeId.PasswordChar = '\0';
			this.mTxtAddExamDetailGradeId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mTxtAddExamDetailGradeId.SelectedText = "";
			this.mTxtAddExamDetailGradeId.SelectionLength = 0;
			this.mTxtAddExamDetailGradeId.SelectionStart = 0;
			this.mTxtAddExamDetailGradeId.ShortcutsEnabled = true;
			this.mTxtAddExamDetailGradeId.Size = new System.Drawing.Size(568, 31);
			this.mTxtAddExamDetailGradeId.TabIndex = 89;
			this.mTxtAddExamDetailGradeId.UseSelectable = true;
			this.mTxtAddExamDetailGradeId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mTxtAddExamDetailGradeId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mLblAddExamDetailGradeId
			// 
			this.mLblAddExamDetailGradeId.AutoSize = true;
			this.mLblAddExamDetailGradeId.Location = new System.Drawing.Point(220, 154);
			this.mLblAddExamDetailGradeId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mLblAddExamDetailGradeId.Name = "mLblAddExamDetailGradeId";
			this.mLblAddExamDetailGradeId.Size = new System.Drawing.Size(59, 20);
			this.mLblAddExamDetailGradeId.TabIndex = 87;
			this.mLblAddExamDetailGradeId.Text = "Khối lớp";
			// 
			// mTxtAddExamDetailSubjectId
			// 
			// 
			// 
			// 
			this.mTxtAddExamDetailSubjectId.CustomButton.Image = null;
			this.mTxtAddExamDetailSubjectId.CustomButton.Location = new System.Drawing.Point(717, 1);
			this.mTxtAddExamDetailSubjectId.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.mTxtAddExamDetailSubjectId.CustomButton.Name = "";
			this.mTxtAddExamDetailSubjectId.CustomButton.Size = new System.Drawing.Size(39, 36);
			this.mTxtAddExamDetailSubjectId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.mTxtAddExamDetailSubjectId.CustomButton.TabIndex = 1;
			this.mTxtAddExamDetailSubjectId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.mTxtAddExamDetailSubjectId.CustomButton.UseSelectable = true;
			this.mTxtAddExamDetailSubjectId.CustomButton.Visible = false;
			this.mTxtAddExamDetailSubjectId.Enabled = false;
			this.mTxtAddExamDetailSubjectId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
			this.mTxtAddExamDetailSubjectId.Lines = new string[0];
			this.mTxtAddExamDetailSubjectId.Location = new System.Drawing.Point(433, 116);
			this.mTxtAddExamDetailSubjectId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTxtAddExamDetailSubjectId.MaxLength = 32767;
			this.mTxtAddExamDetailSubjectId.Name = "mTxtAddExamDetailSubjectId";
			this.mTxtAddExamDetailSubjectId.PasswordChar = '\0';
			this.mTxtAddExamDetailSubjectId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.mTxtAddExamDetailSubjectId.SelectedText = "";
			this.mTxtAddExamDetailSubjectId.SelectionLength = 0;
			this.mTxtAddExamDetailSubjectId.SelectionStart = 0;
			this.mTxtAddExamDetailSubjectId.ShortcutsEnabled = true;
			this.mTxtAddExamDetailSubjectId.Size = new System.Drawing.Size(568, 31);
			this.mTxtAddExamDetailSubjectId.TabIndex = 90;
			this.mTxtAddExamDetailSubjectId.UseSelectable = true;
			this.mTxtAddExamDetailSubjectId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.mTxtAddExamDetailSubjectId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// mLblAddExamDetailSubjectId
			// 
			this.mLblAddExamDetailSubjectId.AutoSize = true;
			this.mLblAddExamDetailSubjectId.Location = new System.Drawing.Point(220, 116);
			this.mLblAddExamDetailSubjectId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mLblAddExamDetailSubjectId.Name = "mLblAddExamDetailSubjectId";
			this.mLblAddExamDetailSubjectId.Size = new System.Drawing.Size(87, 20);
			this.mLblAddExamDetailSubjectId.TabIndex = 88;
			this.mLblAddExamDetailSubjectId.Text = "Mã môn học";
			// 
			// mCbbAddExamDetailSubject
			// 
			this.mCbbAddExamDetailSubject.FormattingEnabled = true;
			this.mCbbAddExamDetailSubject.ItemHeight = 24;
			this.mCbbAddExamDetailSubject.Location = new System.Drawing.Point(433, 73);
			this.mCbbAddExamDetailSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mCbbAddExamDetailSubject.Name = "mCbbAddExamDetailSubject";
			this.mCbbAddExamDetailSubject.Size = new System.Drawing.Size(567, 30);
			this.mCbbAddExamDetailSubject.TabIndex = 86;
			this.mCbbAddExamDetailSubject.UseSelectable = true;
			// 
			// mLblAddExamDetailSubject
			// 
			this.mLblAddExamDetailSubject.AutoSize = true;
			this.mLblAddExamDetailSubject.Location = new System.Drawing.Point(220, 73);
			this.mLblAddExamDetailSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.mLblAddExamDetailSubject.Name = "mLblAddExamDetailSubject";
			this.mLblAddExamDetailSubject.Size = new System.Drawing.Size(64, 20);
			this.mLblAddExamDetailSubject.TabIndex = 85;
			this.mLblAddExamDetailSubject.Text = "Môn học";
			// 
			// mBtnAddExamDetail
			// 
			this.mBtnAddExamDetail.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.mBtnAddExamDetail.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mBtnAddExamDetail.Location = new System.Drawing.Point(927, 4);
			this.mBtnAddExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mBtnAddExamDetail.Name = "mBtnAddExamDetail";
			this.mBtnAddExamDetail.Size = new System.Drawing.Size(296, 49);
			this.mBtnAddExamDetail.TabIndex = 84;
			this.mBtnAddExamDetail.Text = "Thêm";
			this.mBtnAddExamDetail.UseSelectable = true;
			// 
			// mTileAddExamDetail
			// 
			this.mTileAddExamDetail.ActiveControl = null;
			this.mTileAddExamDetail.Location = new System.Drawing.Point(0, 4);
			this.mTileAddExamDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.mTileAddExamDetail.Name = "mTileAddExamDetail";
			this.mTileAddExamDetail.Size = new System.Drawing.Size(919, 49);
			this.mTileAddExamDetail.TabIndex = 83;
			this.mTileAddExamDetail.Text = "Thêm môn thi";
			this.mTileAddExamDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.mTileAddExamDetail.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
			this.mTileAddExamDetail.UseSelectable = true;
			// 
			// frmTeacherExamDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1287, 700);
			this.Controls.Add(this.mTabExamDetail);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "frmTeacherExamDetail";
			this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
			this.Resizable = false;
			this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
			this.Text = "frmTeacherExamDetail";
			this.mTabExamDetail.ResumeLayout(false);
			this.mTabListExamDetail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mGridListExamDetail)).EndInit();
			this.mTabEditExamDetail.ResumeLayout(false);
			this.mTabEditExamDetail.PerformLayout();
			this.mTabAddExamDetail.ResumeLayout(false);
			this.mTabAddExamDetail.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabExamDetail;
        private MetroFramework.Controls.MetroTabPage mTabListExamDetail;
        private MetroFramework.Controls.MetroTabPage mTabEditExamDetail;
        private MetroFramework.Controls.MetroTabPage mTabAddExamDetail;
        private MetroFramework.Controls.MetroTile mTileListExamDetail;
        private MetroFramework.Controls.MetroButton mBtnDeleteExamDetail;
        private MetroFramework.Controls.MetroButton mBtnReloadListExamDetail;
        private MetroFramework.Controls.MetroGrid mGridListExamDetail;
        private MetroFramework.Controls.MetroTile mTileEditExamDetail;
        private MetroFramework.Controls.MetroButton mBtnSaveEditExamDetail;
        private System.Windows.Forms.DateTimePicker dateTimeEditTimeStart;
        private MetroFramework.Controls.MetroDateTime mDateTimeEditDateStart;
        private MetroFramework.Controls.MetroTextBox mTxtEditDuration;
        private MetroFramework.Controls.MetroLabel mLblEditDuration;
        private MetroFramework.Controls.MetroLabel mLblEditStartTime;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamDetailGradeId;
        private MetroFramework.Controls.MetroLabel mLblEditExamDetailGradeId;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamDetailSubjectId;
        private MetroFramework.Controls.MetroLabel mLblEditExamDetailSubjectId;
        private MetroFramework.Controls.MetroComboBox mCbbEditExamDetailSubject;
        private MetroFramework.Controls.MetroLabel mLblEditExamDetailSubject;
        private System.Windows.Forms.DateTimePicker dateTimeAddTimeStart;
        private MetroFramework.Controls.MetroDateTime mDateTimeAddDateStart;
        private MetroFramework.Controls.MetroTextBox mTxtAddDuration;
        private MetroFramework.Controls.MetroLabel mLblAddDuration;
        private MetroFramework.Controls.MetroLabel mLblAddStartTime;
        private MetroFramework.Controls.MetroTextBox mTxtAddExamDetailGradeId;
        private MetroFramework.Controls.MetroLabel mLblAddExamDetailGradeId;
        private MetroFramework.Controls.MetroTextBox mTxtAddExamDetailSubjectId;
        private MetroFramework.Controls.MetroLabel mLblAddExamDetailSubjectId;
        private MetroFramework.Controls.MetroComboBox mCbbAddExamDetailSubject;
        private MetroFramework.Controls.MetroLabel mLblAddExamDetailSubject;
        private MetroFramework.Controls.MetroButton mBtnAddExamDetail;
        private MetroFramework.Controls.MetroTile mTileAddExamDetail;
    }
}