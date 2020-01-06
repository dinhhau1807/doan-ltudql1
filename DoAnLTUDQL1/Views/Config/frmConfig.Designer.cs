namespace DoAnLTUDQL1.Views.Config
{
    partial class frmConfig
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
            this.mBtnConfigTestConnection = new MetroFramework.Controls.MetroButton();
            this.mBtnConfigSaveConnectionString = new MetroFramework.Controls.MetroButton();
            this.mTxtConfigConnectionString = new MetroFramework.Controls.MetroTextBox();
            this.mLblConnectionString = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mBtnConfigTestConnection
            // 
            this.mBtnConfigTestConnection.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtnConfigTestConnection.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mBtnConfigTestConnection.Location = new System.Drawing.Point(856, 156);
            this.mBtnConfigTestConnection.Name = "mBtnConfigTestConnection";
            this.mBtnConfigTestConnection.Size = new System.Drawing.Size(154, 44);
            this.mBtnConfigTestConnection.TabIndex = 13;
            this.mBtnConfigTestConnection.Text = "Kiểm tra kết nối";
            this.mBtnConfigTestConnection.UseSelectable = true;
            // 
            // mBtnConfigSaveConnectionString
            // 
            this.mBtnConfigSaveConnectionString.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtnConfigSaveConnectionString.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mBtnConfigSaveConnectionString.Location = new System.Drawing.Point(1016, 156);
            this.mBtnConfigSaveConnectionString.Name = "mBtnConfigSaveConnectionString";
            this.mBtnConfigSaveConnectionString.Size = new System.Drawing.Size(154, 44);
            this.mBtnConfigSaveConnectionString.TabIndex = 14;
            this.mBtnConfigSaveConnectionString.Text = "Lưu cấu hình";
            this.mBtnConfigSaveConnectionString.UseSelectable = true;
            // 
            // mTxtConfigConnectionString
            // 
            // 
            // 
            // 
            this.mTxtConfigConnectionString.CustomButton.Image = null;
            this.mTxtConfigConnectionString.CustomButton.Location = new System.Drawing.Point(934, 1);
            this.mTxtConfigConnectionString.CustomButton.Name = "";
            this.mTxtConfigConnectionString.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.mTxtConfigConnectionString.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtConfigConnectionString.CustomButton.TabIndex = 1;
            this.mTxtConfigConnectionString.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtConfigConnectionString.CustomButton.UseSelectable = true;
            this.mTxtConfigConnectionString.CustomButton.Visible = false;
            this.mTxtConfigConnectionString.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mTxtConfigConnectionString.Lines = new string[0];
            this.mTxtConfigConnectionString.Location = new System.Drawing.Point(206, 117);
            this.mTxtConfigConnectionString.MaxLength = 32767;
            this.mTxtConfigConnectionString.Name = "mTxtConfigConnectionString";
            this.mTxtConfigConnectionString.PasswordChar = '\0';
            this.mTxtConfigConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtConfigConnectionString.SelectedText = "";
            this.mTxtConfigConnectionString.SelectionLength = 0;
            this.mTxtConfigConnectionString.SelectionStart = 0;
            this.mTxtConfigConnectionString.ShortcutsEnabled = true;
            this.mTxtConfigConnectionString.Size = new System.Drawing.Size(966, 33);
            this.mTxtConfigConnectionString.TabIndex = 12;
            this.mTxtConfigConnectionString.UseSelectable = true;
            this.mTxtConfigConnectionString.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtConfigConnectionString.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mLblConnectionString
            // 
            this.mLblConnectionString.AutoSize = true;
            this.mLblConnectionString.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mLblConnectionString.Location = new System.Drawing.Point(34, 117);
            this.mLblConnectionString.Name = "mLblConnectionString";
            this.mLblConnectionString.Size = new System.Drawing.Size(166, 25);
            this.mLblConnectionString.TabIndex = 11;
            this.mLblConnectionString.Text = "Cổng kết nối dữ liệu";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 224);
            this.Controls.Add(this.mBtnConfigTestConnection);
            this.Controls.Add(this.mBtnConfigSaveConnectionString);
            this.Controls.Add(this.mTxtConfigConnectionString);
            this.Controls.Add(this.mLblConnectionString);
            this.MaximizeBox = false;
            this.Name = "frmConfig";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Cấu hình kết nối";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnConfigTestConnection;
        private MetroFramework.Controls.MetroButton mBtnConfigSaveConnectionString;
        private MetroFramework.Controls.MetroTextBox mTxtConfigConnectionString;
        private MetroFramework.Controls.MetroLabel mLblConnectionString;
    }
}