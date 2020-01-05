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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mTabExam = new MetroFramework.Controls.MetroTabControl();
            this.mTabListExam = new MetroFramework.Controls.MetroTabPage();
            this.mBtnDeleteExam = new MetroFramework.Controls.MetroButton();
            this.mBtnReloadListExam = new MetroFramework.Controls.MetroButton();
            this.mTileListExam = new MetroFramework.Controls.MetroTile();
            this.mGridListExam = new MetroFramework.Controls.MetroGrid();
            this.mTabExamDetail = new MetroFramework.Controls.MetroTabPage();
            this.mGridListExamDetail = new MetroFramework.Controls.MetroGrid();
            this.mTileExamDetail = new MetroFramework.Controls.MetroTile();
            this.mTabEditExam = new MetroFramework.Controls.MetroTabPage();
            this.mBtnEditExamDetail = new MetroFramework.Controls.MetroButton();
            this.mTxtEditExamName = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditExamName = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditExamId = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditExamId = new MetroFramework.Controls.MetroLabel();
            this.mBtnSaveEditExam = new MetroFramework.Controls.MetroButton();
            this.mTileEditExam = new MetroFramework.Controls.MetroTile();
            this.mTabAddExam = new MetroFramework.Controls.MetroTabPage();
            this.mTxtAddExamName = new MetroFramework.Controls.MetroTextBox();
            this.mLblAddExamName = new MetroFramework.Controls.MetroLabel();
            this.mBtnAddExamDetail = new MetroFramework.Controls.MetroButton();
            this.mBtnAddExam = new MetroFramework.Controls.MetroButton();
            this.mTileAddExam = new MetroFramework.Controls.MetroTile();
            this.mTabReport = new MetroFramework.Controls.MetroTabPage();
            this.mbtnExamRS = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mcbExamRV = new MetroFramework.Controls.MetroComboBox();
            this.rpvExamRS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mTabExam.SuspendLayout();
            this.mTabListExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridListExam)).BeginInit();
            this.mTabExamDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridListExamDetail)).BeginInit();
            this.mTabEditExam.SuspendLayout();
            this.mTabAddExam.SuspendLayout();
            this.mTabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabExam
            // 
            this.mTabExam.Controls.Add(this.mTabListExam);
            this.mTabExam.Controls.Add(this.mTabExamDetail);
            this.mTabExam.Controls.Add(this.mTabEditExam);
            this.mTabExam.Controls.Add(this.mTabAddExam);
            this.mTabExam.Controls.Add(this.mTabReport);
            this.mTabExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabExam.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mTabExam.Location = new System.Drawing.Point(20, 60);
            this.mTabExam.Name = "mTabExam";
            this.mTabExam.SelectedIndex = 4;
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
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.mGridListExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridListExam.DefaultCellStyle = dataGridViewCellStyle32;
            this.mGridListExam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mGridListExam.EnableHeadersVisualStyles = false;
            this.mGridListExam.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridListExam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListExam.Location = new System.Drawing.Point(0, 49);
            this.mGridListExam.Name = "mGridListExam";
            this.mGridListExam.ReadOnly = true;
            this.mGridListExam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListExam.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.mGridListExam.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridListExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridListExam.Size = new System.Drawing.Size(1143, 487);
            this.mGridListExam.TabIndex = 2;
            // 
            // mTabExamDetail
            // 
            this.mTabExamDetail.Controls.Add(this.mGridListExamDetail);
            this.mTabExamDetail.Controls.Add(this.mTileExamDetail);
            this.mTabExamDetail.HorizontalScrollbarBarColor = true;
            this.mTabExamDetail.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabExamDetail.HorizontalScrollbarSize = 10;
            this.mTabExamDetail.Location = new System.Drawing.Point(4, 38);
            this.mTabExamDetail.Name = "mTabExamDetail";
            this.mTabExamDetail.Size = new System.Drawing.Size(1143, 536);
            this.mTabExamDetail.TabIndex = 4;
            this.mTabExamDetail.Text = "Chi tiết kỳ thi";
            this.mTabExamDetail.VerticalScrollbarBarColor = true;
            this.mTabExamDetail.VerticalScrollbarHighlightOnWheel = false;
            this.mTabExamDetail.VerticalScrollbarSize = 10;
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
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListExamDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.mGridListExamDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridListExamDetail.DefaultCellStyle = dataGridViewCellStyle35;
            this.mGridListExamDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mGridListExamDetail.EnableHeadersVisualStyles = false;
            this.mGridListExamDetail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridListExamDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListExamDetail.Location = new System.Drawing.Point(0, 49);
            this.mGridListExamDetail.Name = "mGridListExamDetail";
            this.mGridListExamDetail.ReadOnly = true;
            this.mGridListExamDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListExamDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.mGridListExamDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridListExamDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridListExamDetail.Size = new System.Drawing.Size(1143, 487);
            this.mGridListExamDetail.TabIndex = 7;
            // 
            // mTileExamDetail
            // 
            this.mTileExamDetail.ActiveControl = null;
            this.mTileExamDetail.Location = new System.Drawing.Point(0, 3);
            this.mTileExamDetail.Name = "mTileExamDetail";
            this.mTileExamDetail.Size = new System.Drawing.Size(1144, 40);
            this.mTileExamDetail.TabIndex = 6;
            this.mTileExamDetail.Text = "Chi tiết kỳ thi";
            this.mTileExamDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileExamDetail.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileExamDetail.UseSelectable = true;
            // 
            // mTabEditExam
            // 
            this.mTabEditExam.Controls.Add(this.mBtnEditExamDetail);
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
            // mBtnEditExamDetail
            // 
            this.mBtnEditExamDetail.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnEditExamDetail.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnEditExamDetail.Location = new System.Drawing.Point(693, 3);
            this.mBtnEditExamDetail.Name = "mBtnEditExamDetail";
            this.mBtnEditExamDetail.Size = new System.Drawing.Size(222, 40);
            this.mBtnEditExamDetail.TabIndex = 53;
            this.mBtnEditExamDetail.Text = "Chỉnh sửa môn thi";
            this.mBtnEditExamDetail.UseSelectable = true;
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
            this.mTileEditExam.Size = new System.Drawing.Size(688, 40);
            this.mTileEditExam.TabIndex = 6;
            this.mTileEditExam.Text = "Chỉnh sửa kỳ thi";
            this.mTileEditExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileEditExam.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileEditExam.UseSelectable = true;
            // 
            // mTabAddExam
            // 
            this.mTabAddExam.Controls.Add(this.mTxtAddExamName);
            this.mTabAddExam.Controls.Add(this.mLblAddExamName);
            this.mTabAddExam.Controls.Add(this.mBtnAddExamDetail);
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
            // mBtnAddExamDetail
            // 
            this.mBtnAddExamDetail.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnAddExamDetail.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnAddExamDetail.Location = new System.Drawing.Point(693, 3);
            this.mBtnAddExamDetail.Name = "mBtnAddExamDetail";
            this.mBtnAddExamDetail.Size = new System.Drawing.Size(222, 40);
            this.mBtnAddExamDetail.TabIndex = 52;
            this.mBtnAddExamDetail.Text = "Tạo môn thi";
            this.mBtnAddExamDetail.UseSelectable = true;
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
            this.mTileAddExam.Size = new System.Drawing.Size(687, 40);
            this.mTileAddExam.TabIndex = 50;
            this.mTileAddExam.Text = "Tạo kỳ thi mới";
            this.mTileAddExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileAddExam.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileAddExam.UseSelectable = true;
            // 
            // mTabReport
            // 
            this.mTabReport.Controls.Add(this.mbtnExamRS);
            this.mTabReport.Controls.Add(this.metroTile1);
            this.mTabReport.Controls.Add(this.mcbExamRV);
            this.mTabReport.Controls.Add(this.rpvExamRS);
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
            // mbtnExamRS
            // 
            this.mbtnExamRS.Location = new System.Drawing.Point(939, 3);
            this.mbtnExamRS.Name = "mbtnExamRS";
            this.mbtnExamRS.Size = new System.Drawing.Size(201, 40);
            this.mbtnExamRS.TabIndex = 52;
            this.mbtnExamRS.Text = "Xem kết quả";
            this.mbtnExamRS.UseSelectable = true;
            this.mbtnExamRS.Click += new System.EventHandler(this.mbtnExamRS_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(596, 40);
            this.metroTile1.TabIndex = 51;
            this.metroTile1.Text = "Thống kê kì thi";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            // 
            // mcbExamRV
            // 
            this.mcbExamRV.FormattingEnabled = true;
            this.mcbExamRV.ItemHeight = 23;
            this.mcbExamRV.Location = new System.Drawing.Point(605, 8);
            this.mcbExamRV.Name = "mcbExamRV";
            this.mcbExamRV.Size = new System.Drawing.Size(328, 29);
            this.mcbExamRV.TabIndex = 3;
            this.mcbExamRV.UseSelectable = true;
            // 
            // rpvExamRS
            // 
            this.rpvExamRS.LocalReport.ReportEmbeddedResource = "DoAnLTUDQL1.Reports.ExamRS.rdlc";
            this.rpvExamRS.Location = new System.Drawing.Point(3, 49);
            this.rpvExamRS.Name = "rpvExamRS";
            this.rpvExamRS.ServerReport.BearerToken = null;
            this.rpvExamRS.Size = new System.Drawing.Size(1137, 414);
            this.rpvExamRS.TabIndex = 2;
            // 
            // frmTeacherExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 658);
            this.Controls.Add(this.mTabExam);
            this.MaximizeBox = false;
            this.Name = "frmTeacherExam";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Quản lý kỳ thi";
            this.Load += new System.EventHandler(this.FrmExam_Load);
            this.mTabExam.ResumeLayout(false);
            this.mTabListExam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridListExam)).EndInit();
            this.mTabExamDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridListExamDetail)).EndInit();
            this.mTabEditExam.ResumeLayout(false);
            this.mTabEditExam.PerformLayout();
            this.mTabAddExam.ResumeLayout(false);
            this.mTabAddExam.PerformLayout();
            this.mTabReport.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroButton mBtnSaveEditExam;
        private MetroFramework.Controls.MetroTile mTileEditExam;
        private MetroFramework.Controls.MetroTabPage mTabAddExam;
        private MetroFramework.Controls.MetroButton mBtnAddExam;
        private MetroFramework.Controls.MetroTile mTileAddExam;
        private MetroFramework.Controls.MetroTabPage mTabReport;
		private MetroFramework.Controls.MetroButton mBtnAddExamDetail;
        private MetroFramework.Controls.MetroButton mBtnEditExamDetail;
        private MetroFramework.Controls.MetroTabPage mTabExamDetail;
        private MetroFramework.Controls.MetroTile mTileExamDetail;
        private MetroFramework.Controls.MetroGrid mGridListExamDetail;
        private MetroFramework.Controls.MetroTextBox mTxtAddExamName;
        private MetroFramework.Controls.MetroLabel mLblAddExamName;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamName;
        private MetroFramework.Controls.MetroLabel mLblEditExamName;
        private MetroFramework.Controls.MetroTextBox mTxtEditExamId;
        private MetroFramework.Controls.MetroLabel mLblEditExamId;
        private Microsoft.Reporting.WinForms.ReportViewer rpvExamRS;
        private MetroFramework.Controls.MetroButton mbtnExamRS;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroComboBox mcbExamRV;
    }
}