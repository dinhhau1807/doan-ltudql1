namespace DoAnLTUDQL1.Views.TeacherView
{
    partial class frmEditAnswer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mTabAnswer = new MetroFramework.Controls.MetroTabControl();
            this.mTabListAnswer = new MetroFramework.Controls.MetroTabPage();
            this.mGridListAnswer = new MetroFramework.Controls.MetroGrid();
            this.mTabEditAnswer = new MetroFramework.Controls.MetroTabPage();
            this.mTabAddAnswer = new MetroFramework.Controls.MetroTabPage();
            this.mTileListAnswer = new MetroFramework.Controls.MetroTile();
            this.mBtnReloadListAnswer = new MetroFramework.Controls.MetroButton();
            this.mTileEditAnswer = new MetroFramework.Controls.MetroTile();
            this.mTxtEditAnswerContent = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditAsnwerContent = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditAnswerQuestionId = new MetroFramework.Controls.MetroTextBox();
            this.mLblEditAnswerQuestionId = new MetroFramework.Controls.MetroLabel();
            this.mLblEditAnswerId = new MetroFramework.Controls.MetroLabel();
            this.mTxtEditAnswerId = new MetroFramework.Controls.MetroTextBox();
            this.mToggleEditAnswerIsCorrect = new MetroFramework.Controls.MetroToggle();
            this.mLblEdtiAnswerIsCorrect = new MetroFramework.Controls.MetroLabel();
            this.mBtnSaveEditAnswer = new MetroFramework.Controls.MetroButton();
            this.mBtnDeleteAnswer = new MetroFramework.Controls.MetroButton();
            this.mBtnAddAnswer = new MetroFramework.Controls.MetroButton();
            this.mToggleAddAnswerIsCorrect = new MetroFramework.Controls.MetroToggle();
            this.mLblAddAnswerIsCorrect = new MetroFramework.Controls.MetroLabel();
            this.mTxtAddAnswer = new MetroFramework.Controls.MetroTextBox();
            this.mLblAddAnswer = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mTabAnswer.SuspendLayout();
            this.mTabListAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridListAnswer)).BeginInit();
            this.mTabEditAnswer.SuspendLayout();
            this.mTabAddAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabAnswer
            // 
            this.mTabAnswer.Controls.Add(this.mTabListAnswer);
            this.mTabAnswer.Controls.Add(this.mTabEditAnswer);
            this.mTabAnswer.Controls.Add(this.mTabAddAnswer);
            this.mTabAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabAnswer.Location = new System.Drawing.Point(20, 60);
            this.mTabAnswer.Name = "mTabAnswer";
            this.mTabAnswer.SelectedIndex = 1;
            this.mTabAnswer.Size = new System.Drawing.Size(760, 370);
            this.mTabAnswer.TabIndex = 0;
            this.mTabAnswer.UseSelectable = true;
            // 
            // mTabListAnswer
            // 
            this.mTabListAnswer.Controls.Add(this.mBtnDeleteAnswer);
            this.mTabListAnswer.Controls.Add(this.mBtnReloadListAnswer);
            this.mTabListAnswer.Controls.Add(this.mTileListAnswer);
            this.mTabListAnswer.Controls.Add(this.mGridListAnswer);
            this.mTabListAnswer.HorizontalScrollbarBarColor = true;
            this.mTabListAnswer.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabListAnswer.HorizontalScrollbarSize = 10;
            this.mTabListAnswer.Location = new System.Drawing.Point(4, 38);
            this.mTabListAnswer.Name = "mTabListAnswer";
            this.mTabListAnswer.Size = new System.Drawing.Size(752, 328);
            this.mTabListAnswer.TabIndex = 0;
            this.mTabListAnswer.Text = "Danh sách câu trả lời";
            this.mTabListAnswer.VerticalScrollbarBarColor = true;
            this.mTabListAnswer.VerticalScrollbarHighlightOnWheel = false;
            this.mTabListAnswer.VerticalScrollbarSize = 10;
            // 
            // mGridListAnswer
            // 
            this.mGridListAnswer.AllowUserToAddRows = false;
            this.mGridListAnswer.AllowUserToDeleteRows = false;
            this.mGridListAnswer.AllowUserToResizeRows = false;
            this.mGridListAnswer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mGridListAnswer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridListAnswer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridListAnswer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListAnswer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.mGridListAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridListAnswer.DefaultCellStyle = dataGridViewCellStyle11;
            this.mGridListAnswer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mGridListAnswer.EnableHeadersVisualStyles = false;
            this.mGridListAnswer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridListAnswer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mGridListAnswer.Location = new System.Drawing.Point(0, 48);
            this.mGridListAnswer.Name = "mGridListAnswer";
            this.mGridListAnswer.ReadOnly = true;
            this.mGridListAnswer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridListAnswer.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.mGridListAnswer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridListAnswer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridListAnswer.Size = new System.Drawing.Size(752, 280);
            this.mGridListAnswer.TabIndex = 2;
            // 
            // mTabEditAnswer
            // 
            this.mTabEditAnswer.Controls.Add(this.mBtnSaveEditAnswer);
            this.mTabEditAnswer.Controls.Add(this.mToggleEditAnswerIsCorrect);
            this.mTabEditAnswer.Controls.Add(this.mLblEdtiAnswerIsCorrect);
            this.mTabEditAnswer.Controls.Add(this.mTxtEditAnswerId);
            this.mTabEditAnswer.Controls.Add(this.mLblEditAnswerId);
            this.mTabEditAnswer.Controls.Add(this.mTxtEditAnswerQuestionId);
            this.mTabEditAnswer.Controls.Add(this.mLblEditAnswerQuestionId);
            this.mTabEditAnswer.Controls.Add(this.mTxtEditAnswerContent);
            this.mTabEditAnswer.Controls.Add(this.mLblEditAsnwerContent);
            this.mTabEditAnswer.Controls.Add(this.mTileEditAnswer);
            this.mTabEditAnswer.HorizontalScrollbarBarColor = true;
            this.mTabEditAnswer.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabEditAnswer.HorizontalScrollbarSize = 10;
            this.mTabEditAnswer.Location = new System.Drawing.Point(4, 38);
            this.mTabEditAnswer.Name = "mTabEditAnswer";
            this.mTabEditAnswer.Size = new System.Drawing.Size(752, 328);
            this.mTabEditAnswer.TabIndex = 1;
            this.mTabEditAnswer.Text = "Chỉnh sửa câu trả lời";
            this.mTabEditAnswer.VerticalScrollbarBarColor = true;
            this.mTabEditAnswer.VerticalScrollbarHighlightOnWheel = false;
            this.mTabEditAnswer.VerticalScrollbarSize = 10;
            // 
            // mTabAddAnswer
            // 
            this.mTabAddAnswer.Controls.Add(this.mBtnAddAnswer);
            this.mTabAddAnswer.Controls.Add(this.mToggleAddAnswerIsCorrect);
            this.mTabAddAnswer.Controls.Add(this.mLblAddAnswerIsCorrect);
            this.mTabAddAnswer.Controls.Add(this.mTxtAddAnswer);
            this.mTabAddAnswer.Controls.Add(this.mLblAddAnswer);
            this.mTabAddAnswer.Controls.Add(this.metroTile1);
            this.mTabAddAnswer.HorizontalScrollbarBarColor = true;
            this.mTabAddAnswer.HorizontalScrollbarHighlightOnWheel = false;
            this.mTabAddAnswer.HorizontalScrollbarSize = 10;
            this.mTabAddAnswer.Location = new System.Drawing.Point(4, 38);
            this.mTabAddAnswer.Name = "mTabAddAnswer";
            this.mTabAddAnswer.Size = new System.Drawing.Size(752, 328);
            this.mTabAddAnswer.TabIndex = 2;
            this.mTabAddAnswer.Text = "Thêm câu trả lời";
            this.mTabAddAnswer.VerticalScrollbarBarColor = true;
            this.mTabAddAnswer.VerticalScrollbarHighlightOnWheel = false;
            this.mTabAddAnswer.VerticalScrollbarSize = 10;
            // 
            // mTileListAnswer
            // 
            this.mTileListAnswer.ActiveControl = null;
            this.mTileListAnswer.Location = new System.Drawing.Point(0, 3);
            this.mTileListAnswer.Name = "mTileListAnswer";
            this.mTileListAnswer.Size = new System.Drawing.Size(296, 40);
            this.mTileListAnswer.TabIndex = 4;
            this.mTileListAnswer.Text = "Danh sách câu trả lời";
            this.mTileListAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileListAnswer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileListAnswer.UseSelectable = true;
            // 
            // mBtnReloadListAnswer
            // 
            this.mBtnReloadListAnswer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnReloadListAnswer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnReloadListAnswer.Location = new System.Drawing.Point(530, 3);
            this.mBtnReloadListAnswer.Name = "mBtnReloadListAnswer";
            this.mBtnReloadListAnswer.Size = new System.Drawing.Size(222, 40);
            this.mBtnReloadListAnswer.TabIndex = 5;
            this.mBtnReloadListAnswer.Text = "Tải lại danh sách";
            this.mBtnReloadListAnswer.UseSelectable = true;
            // 
            // mTileEditAnswer
            // 
            this.mTileEditAnswer.ActiveControl = null;
            this.mTileEditAnswer.Location = new System.Drawing.Point(0, 3);
            this.mTileEditAnswer.Name = "mTileEditAnswer";
            this.mTileEditAnswer.Size = new System.Drawing.Size(524, 40);
            this.mTileEditAnswer.TabIndex = 5;
            this.mTileEditAnswer.Text = "Chỉnh sửa câu trả lời";
            this.mTileEditAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mTileEditAnswer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mTileEditAnswer.UseSelectable = true;
            // 
            // mTxtEditAnswerContent
            // 
            // 
            // 
            // 
            this.mTxtEditAnswerContent.CustomButton.Image = null;
            this.mTxtEditAnswerContent.CustomButton.Location = new System.Drawing.Point(392, 1);
            this.mTxtEditAnswerContent.CustomButton.Name = "";
            this.mTxtEditAnswerContent.CustomButton.Size = new System.Drawing.Size(185, 185);
            this.mTxtEditAnswerContent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditAnswerContent.CustomButton.TabIndex = 1;
            this.mTxtEditAnswerContent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditAnswerContent.CustomButton.UseSelectable = true;
            this.mTxtEditAnswerContent.CustomButton.Visible = false;
            this.mTxtEditAnswerContent.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditAnswerContent.Lines = new string[0];
            this.mTxtEditAnswerContent.Location = new System.Drawing.Point(174, 49);
            this.mTxtEditAnswerContent.MaxLength = 32767;
            this.mTxtEditAnswerContent.Multiline = true;
            this.mTxtEditAnswerContent.Name = "mTxtEditAnswerContent";
            this.mTxtEditAnswerContent.PasswordChar = '\0';
            this.mTxtEditAnswerContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mTxtEditAnswerContent.SelectedText = "";
            this.mTxtEditAnswerContent.SelectionLength = 0;
            this.mTxtEditAnswerContent.SelectionStart = 0;
            this.mTxtEditAnswerContent.ShortcutsEnabled = true;
            this.mTxtEditAnswerContent.Size = new System.Drawing.Size(578, 187);
            this.mTxtEditAnswerContent.TabIndex = 9;
            this.mTxtEditAnswerContent.UseSelectable = true;
            this.mTxtEditAnswerContent.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditAnswerContent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditAsnwerContent
            // 
            this.mLblEditAsnwerContent.AutoSize = true;
            this.mLblEditAsnwerContent.Location = new System.Drawing.Point(0, 49);
            this.mLblEditAsnwerContent.Name = "mLblEditAsnwerContent";
            this.mLblEditAsnwerContent.Size = new System.Drawing.Size(126, 19);
            this.mLblEditAsnwerContent.TabIndex = 8;
            this.mLblEditAsnwerContent.Text = "Nội dung câu trả lời";
            // 
            // mTxtEditAnswerQuestionId
            // 
            // 
            // 
            // 
            this.mTxtEditAnswerQuestionId.CustomButton.Image = null;
            this.mTxtEditAnswerQuestionId.CustomButton.Location = new System.Drawing.Point(310, 1);
            this.mTxtEditAnswerQuestionId.CustomButton.Name = "";
            this.mTxtEditAnswerQuestionId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditAnswerQuestionId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditAnswerQuestionId.CustomButton.TabIndex = 1;
            this.mTxtEditAnswerQuestionId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditAnswerQuestionId.CustomButton.UseSelectable = true;
            this.mTxtEditAnswerQuestionId.CustomButton.Visible = false;
            this.mTxtEditAnswerQuestionId.Enabled = false;
            this.mTxtEditAnswerQuestionId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditAnswerQuestionId.Lines = new string[0];
            this.mTxtEditAnswerQuestionId.Location = new System.Drawing.Point(174, 242);
            this.mTxtEditAnswerQuestionId.MaxLength = 32767;
            this.mTxtEditAnswerQuestionId.Name = "mTxtEditAnswerQuestionId";
            this.mTxtEditAnswerQuestionId.PasswordChar = '\0';
            this.mTxtEditAnswerQuestionId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditAnswerQuestionId.SelectedText = "";
            this.mTxtEditAnswerQuestionId.SelectionLength = 0;
            this.mTxtEditAnswerQuestionId.SelectionStart = 0;
            this.mTxtEditAnswerQuestionId.ShortcutsEnabled = true;
            this.mTxtEditAnswerQuestionId.Size = new System.Drawing.Size(334, 25);
            this.mTxtEditAnswerQuestionId.TabIndex = 11;
            this.mTxtEditAnswerQuestionId.UseSelectable = true;
            this.mTxtEditAnswerQuestionId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditAnswerQuestionId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblEditAnswerQuestionId
            // 
            this.mLblEditAnswerQuestionId.AutoSize = true;
            this.mLblEditAnswerQuestionId.Location = new System.Drawing.Point(3, 242);
            this.mLblEditAnswerQuestionId.Name = "mLblEditAnswerQuestionId";
            this.mLblEditAnswerQuestionId.Size = new System.Drawing.Size(74, 19);
            this.mLblEditAnswerQuestionId.TabIndex = 10;
            this.mLblEditAnswerQuestionId.Text = "Mã câu hỏi";
            // 
            // mLblEditAnswerId
            // 
            this.mLblEditAnswerId.AutoSize = true;
            this.mLblEditAnswerId.Location = new System.Drawing.Point(3, 273);
            this.mLblEditAnswerId.Name = "mLblEditAnswerId";
            this.mLblEditAnswerId.Size = new System.Drawing.Size(90, 19);
            this.mLblEditAnswerId.TabIndex = 10;
            this.mLblEditAnswerId.Text = "Mã câu trả lời";
            // 
            // mTxtEditAnswerId
            // 
            // 
            // 
            // 
            this.mTxtEditAnswerId.CustomButton.Image = null;
            this.mTxtEditAnswerId.CustomButton.Location = new System.Drawing.Point(310, 1);
            this.mTxtEditAnswerId.CustomButton.Name = "";
            this.mTxtEditAnswerId.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mTxtEditAnswerId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtEditAnswerId.CustomButton.TabIndex = 1;
            this.mTxtEditAnswerId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtEditAnswerId.CustomButton.UseSelectable = true;
            this.mTxtEditAnswerId.CustomButton.Visible = false;
            this.mTxtEditAnswerId.Enabled = false;
            this.mTxtEditAnswerId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtEditAnswerId.Lines = new string[0];
            this.mTxtEditAnswerId.Location = new System.Drawing.Point(174, 273);
            this.mTxtEditAnswerId.MaxLength = 32767;
            this.mTxtEditAnswerId.Name = "mTxtEditAnswerId";
            this.mTxtEditAnswerId.PasswordChar = '\0';
            this.mTxtEditAnswerId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtEditAnswerId.SelectedText = "";
            this.mTxtEditAnswerId.SelectionLength = 0;
            this.mTxtEditAnswerId.SelectionStart = 0;
            this.mTxtEditAnswerId.ShortcutsEnabled = true;
            this.mTxtEditAnswerId.Size = new System.Drawing.Size(334, 25);
            this.mTxtEditAnswerId.TabIndex = 11;
            this.mTxtEditAnswerId.UseSelectable = true;
            this.mTxtEditAnswerId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtEditAnswerId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mToggleEditAnswerIsCorrect
            // 
            this.mToggleEditAnswerIsCorrect.AutoSize = true;
            this.mToggleEditAnswerIsCorrect.DisplayStatus = false;
            this.mToggleEditAnswerIsCorrect.Location = new System.Drawing.Point(174, 306);
            this.mToggleEditAnswerIsCorrect.Name = "mToggleEditAnswerIsCorrect";
            this.mToggleEditAnswerIsCorrect.Size = new System.Drawing.Size(50, 17);
            this.mToggleEditAnswerIsCorrect.TabIndex = 13;
            this.mToggleEditAnswerIsCorrect.Text = "Off";
            this.mToggleEditAnswerIsCorrect.UseSelectable = true;
            // 
            // mLblEdtiAnswerIsCorrect
            // 
            this.mLblEdtiAnswerIsCorrect.AutoSize = true;
            this.mLblEdtiAnswerIsCorrect.Location = new System.Drawing.Point(3, 304);
            this.mLblEdtiAnswerIsCorrect.Name = "mLblEdtiAnswerIsCorrect";
            this.mLblEdtiAnswerIsCorrect.Size = new System.Drawing.Size(128, 19);
            this.mLblEdtiAnswerIsCorrect.TabIndex = 12;
            this.mLblEdtiAnswerIsCorrect.Text = "Là câu trả lời đúng ?";
            // 
            // mBtnSaveEditAnswer
            // 
            this.mBtnSaveEditAnswer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnSaveEditAnswer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnSaveEditAnswer.Location = new System.Drawing.Point(530, 3);
            this.mBtnSaveEditAnswer.Name = "mBtnSaveEditAnswer";
            this.mBtnSaveEditAnswer.Size = new System.Drawing.Size(222, 40);
            this.mBtnSaveEditAnswer.TabIndex = 14;
            this.mBtnSaveEditAnswer.Text = "Lưu chỉnh sửa";
            this.mBtnSaveEditAnswer.UseSelectable = true;
            // 
            // mBtnDeleteAnswer
            // 
            this.mBtnDeleteAnswer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnDeleteAnswer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnDeleteAnswer.Location = new System.Drawing.Point(302, 3);
            this.mBtnDeleteAnswer.Name = "mBtnDeleteAnswer";
            this.mBtnDeleteAnswer.Size = new System.Drawing.Size(222, 40);
            this.mBtnDeleteAnswer.TabIndex = 5;
            this.mBtnDeleteAnswer.Text = "Xoá câu trả lời";
            this.mBtnDeleteAnswer.UseSelectable = true;
            // 
            // mBtnAddAnswer
            // 
            this.mBtnAddAnswer.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mBtnAddAnswer.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mBtnAddAnswer.Location = new System.Drawing.Point(530, 3);
            this.mBtnAddAnswer.Name = "mBtnAddAnswer";
            this.mBtnAddAnswer.Size = new System.Drawing.Size(222, 40);
            this.mBtnAddAnswer.TabIndex = 24;
            this.mBtnAddAnswer.Text = "Thêm mới";
            this.mBtnAddAnswer.UseSelectable = true;
            // 
            // mToggleAddAnswerIsCorrect
            // 
            this.mToggleAddAnswerIsCorrect.AutoSize = true;
            this.mToggleAddAnswerIsCorrect.DisplayStatus = false;
            this.mToggleAddAnswerIsCorrect.Location = new System.Drawing.Point(174, 242);
            this.mToggleAddAnswerIsCorrect.Name = "mToggleAddAnswerIsCorrect";
            this.mToggleAddAnswerIsCorrect.Size = new System.Drawing.Size(50, 17);
            this.mToggleAddAnswerIsCorrect.TabIndex = 23;
            this.mToggleAddAnswerIsCorrect.Text = "Off";
            this.mToggleAddAnswerIsCorrect.UseSelectable = true;
            // 
            // mLblAddAnswerIsCorrect
            // 
            this.mLblAddAnswerIsCorrect.AutoSize = true;
            this.mLblAddAnswerIsCorrect.Location = new System.Drawing.Point(3, 240);
            this.mLblAddAnswerIsCorrect.Name = "mLblAddAnswerIsCorrect";
            this.mLblAddAnswerIsCorrect.Size = new System.Drawing.Size(128, 19);
            this.mLblAddAnswerIsCorrect.TabIndex = 22;
            this.mLblAddAnswerIsCorrect.Text = "Là câu trả lời đúng ?";
            // 
            // mTxtAddAnswer
            // 
            // 
            // 
            // 
            this.mTxtAddAnswer.CustomButton.Image = null;
            this.mTxtAddAnswer.CustomButton.Location = new System.Drawing.Point(392, 1);
            this.mTxtAddAnswer.CustomButton.Name = "";
            this.mTxtAddAnswer.CustomButton.Size = new System.Drawing.Size(185, 185);
            this.mTxtAddAnswer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtAddAnswer.CustomButton.TabIndex = 1;
            this.mTxtAddAnswer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtAddAnswer.CustomButton.UseSelectable = true;
            this.mTxtAddAnswer.CustomButton.Visible = false;
            this.mTxtAddAnswer.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mTxtAddAnswer.Lines = new string[0];
            this.mTxtAddAnswer.Location = new System.Drawing.Point(174, 49);
            this.mTxtAddAnswer.MaxLength = 32767;
            this.mTxtAddAnswer.Multiline = true;
            this.mTxtAddAnswer.Name = "mTxtAddAnswer";
            this.mTxtAddAnswer.PasswordChar = '\0';
            this.mTxtAddAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mTxtAddAnswer.SelectedText = "";
            this.mTxtAddAnswer.SelectionLength = 0;
            this.mTxtAddAnswer.SelectionStart = 0;
            this.mTxtAddAnswer.ShortcutsEnabled = true;
            this.mTxtAddAnswer.Size = new System.Drawing.Size(578, 187);
            this.mTxtAddAnswer.TabIndex = 17;
            this.mTxtAddAnswer.UseSelectable = true;
            this.mTxtAddAnswer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtAddAnswer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblAddAnswer
            // 
            this.mLblAddAnswer.AutoSize = true;
            this.mLblAddAnswer.Location = new System.Drawing.Point(0, 49);
            this.mLblAddAnswer.Name = "mLblAddAnswer";
            this.mLblAddAnswer.Size = new System.Drawing.Size(126, 19);
            this.mLblAddAnswer.TabIndex = 16;
            this.mLblAddAnswer.Text = "Nội dung câu trả lời";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(0, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(524, 40);
            this.metroTile1.TabIndex = 15;
            this.metroTile1.Text = "Thêm câu trả lời";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            // 
            // frmEditAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mTabAnswer);
            this.Name = "frmEditAnswer";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "frmEditAnswer";
            this.mTabAnswer.ResumeLayout(false);
            this.mTabListAnswer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridListAnswer)).EndInit();
            this.mTabEditAnswer.ResumeLayout(false);
            this.mTabEditAnswer.PerformLayout();
            this.mTabAddAnswer.ResumeLayout(false);
            this.mTabAddAnswer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabAnswer;
        private MetroFramework.Controls.MetroTabPage mTabListAnswer;
        private MetroFramework.Controls.MetroTabPage mTabEditAnswer;
        private MetroFramework.Controls.MetroGrid mGridListAnswer;
        private MetroFramework.Controls.MetroTabPage mTabAddAnswer;
        private MetroFramework.Controls.MetroTile mTileListAnswer;
        private MetroFramework.Controls.MetroButton mBtnReloadListAnswer;
        private MetroFramework.Controls.MetroTile mTileEditAnswer;
        private MetroFramework.Controls.MetroTextBox mTxtEditAnswerContent;
        private MetroFramework.Controls.MetroLabel mLblEditAsnwerContent;
        private MetroFramework.Controls.MetroTextBox mTxtEditAnswerQuestionId;
        private MetroFramework.Controls.MetroLabel mLblEditAnswerQuestionId;
        private MetroFramework.Controls.MetroTextBox mTxtEditAnswerId;
        private MetroFramework.Controls.MetroLabel mLblEditAnswerId;
        private MetroFramework.Controls.MetroToggle mToggleEditAnswerIsCorrect;
        private MetroFramework.Controls.MetroLabel mLblEdtiAnswerIsCorrect;
        private MetroFramework.Controls.MetroButton mBtnSaveEditAnswer;
        private MetroFramework.Controls.MetroButton mBtnDeleteAnswer;
        private MetroFramework.Controls.MetroButton mBtnAddAnswer;
        private MetroFramework.Controls.MetroToggle mToggleAddAnswerIsCorrect;
        private MetroFramework.Controls.MetroLabel mLblAddAnswerIsCorrect;
        private MetroFramework.Controls.MetroTextBox mTxtAddAnswer;
        private MetroFramework.Controls.MetroLabel mLblAddAnswer;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}