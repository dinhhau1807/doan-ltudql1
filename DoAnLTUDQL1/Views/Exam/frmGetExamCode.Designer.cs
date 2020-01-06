namespace DoAnLTUDQL1.Views.Exam
{
	partial class frmGetExamCode
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
			this.mcmbExamCode = new MetroFramework.Controls.MetroComboBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.btnChoose = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// mcmbExamCode
			// 
			this.mcmbExamCode.FormattingEnabled = true;
			this.mcmbExamCode.ItemHeight = 24;
			this.mcmbExamCode.Location = new System.Drawing.Point(20, 105);
			this.mcmbExamCode.Name = "mcmbExamCode";
			this.mcmbExamCode.Size = new System.Drawing.Size(187, 30);
			this.mcmbExamCode.TabIndex = 0;
			this.mcmbExamCode.UseSelectable = true;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.metroLabel1.Location = new System.Drawing.Point(20, 60);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(146, 20);
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Vui lòng chọn mã đề";
			// 
			// btnChoose
			// 
			this.btnChoose.FontSize = MetroFramework.MetroButtonSize.Medium;
			this.btnChoose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.btnChoose.Location = new System.Drawing.Point(20, 172);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(187, 36);
			this.btnChoose.TabIndex = 2;
			this.btnChoose.Text = "Chọn";
			this.btnChoose.UseSelectable = true;
			this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
			// 
			// frmGetExamCode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(229, 247);
			this.Controls.Add(this.btnChoose);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.mcmbExamCode);
			this.Name = "frmGetExamCode";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.TransparencyKey = System.Drawing.Color.LightSteelBlue;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroComboBox mcmbExamCode;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroButton btnChoose;
	}
}