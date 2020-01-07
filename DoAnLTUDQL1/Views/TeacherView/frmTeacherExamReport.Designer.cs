namespace DoAnLTUDQL1.Views.TeacherView
{
    partial class frmTeacherExamReport
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
            this.mTabReport = new MetroFramework.Controls.MetroTabPage();
            this.mbtnExamRS = new MetroFramework.Controls.MetroButton();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mcbExamRV = new MetroFramework.Controls.MetroComboBox();
            this.rpvExamRS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mTabExam.SuspendLayout();
            this.mTabReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // mTabExam
            // 
            this.mTabExam.Controls.Add(this.mTabReport);
            this.mTabExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabExam.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mTabExam.Location = new System.Drawing.Point(20, 60);
            this.mTabExam.Name = "mTabExam";
            this.mTabExam.SelectedIndex = 0;
            this.mTabExam.Size = new System.Drawing.Size(1113, 517);
            this.mTabExam.TabIndex = 2;
            this.mTabExam.UseSelectable = true;
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
            this.mTabReport.Size = new System.Drawing.Size(1105, 475);
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
            this.mbtnExamRS.Size = new System.Drawing.Size(163, 40);
            this.mbtnExamRS.TabIndex = 52;
            this.mbtnExamRS.Text = "Xem kết quả";
            this.mbtnExamRS.UseSelectable = true;
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
            this.rpvExamRS.Size = new System.Drawing.Size(1099, 414);
            this.rpvExamRS.TabIndex = 2;
            // 
            // frmTeacherExamReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 597);
            this.Controls.Add(this.mTabExam);
            this.MaximizeBox = false;
            this.Name = "frmTeacherExamReport";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "frmTeacherExamReport";
            this.mTabExam.ResumeLayout(false);
            this.mTabReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mTabExam;
        private MetroFramework.Controls.MetroTabPage mTabReport;
        private MetroFramework.Controls.MetroButton mbtnExamRS;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroComboBox mcbExamRV;
        private Microsoft.Reporting.WinForms.ReportViewer rpvExamRS;
    }
}