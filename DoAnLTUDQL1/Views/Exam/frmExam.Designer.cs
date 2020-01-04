namespace DoAnLTUDQL1.Views.Exam
{
	partial class frmExam
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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mbtnTurnIn = new MetroFramework.Controls.MetroButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.mlblDuration = new MetroFramework.Controls.MetroLabel();
			this.mlblTime = new MetroFramework.Controls.MetroLabel();
			this.mlblStatus = new MetroFramework.Controls.MetroLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mlblStudentName = new MetroFramework.Controls.MetroLabel();
			this.mlblStudentId = new MetroFramework.Controls.MetroLabel();
			this.mlblDob = new MetroFramework.Controls.MetroLabel();
			this.mlblPhone = new MetroFramework.Controls.MetroLabel();
			this.gbQuestion = new System.Windows.Forms.GroupBox();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.mbtnNext = new MetroFramework.Controls.MetroButton();
			this.mbtnPrev = new MetroFramework.Controls.MetroButton();
			this.pnlAnswers = new System.Windows.Forms.Panel();
			this.mbtnKey = new MetroFramework.Controls.MetroButton();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.gbAnswers = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gbQuestion.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.mbtnTurnIn);
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.groupBox1.Location = new System.Drawing.Point(22, 63);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(829, 143);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin học sinh";
			// 
			// mbtnTurnIn
			// 
			this.mbtnTurnIn.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnTurnIn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnTurnIn.Location = new System.Drawing.Point(662, 21);
			this.mbtnTurnIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.mbtnTurnIn.Name = "mbtnTurnIn";
			this.mbtnTurnIn.Size = new System.Drawing.Size(163, 117);
			this.mbtnTurnIn.TabIndex = 2;
			this.mbtnTurnIn.Text = "Nộp bài";
			this.mbtnTurnIn.UseSelectable = true;
			this.mbtnTurnIn.Click += new System.EventHandler(this.mbtnTurnIn_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.mlblDuration);
			this.panel2.Controls.Add(this.mlblTime);
			this.panel2.Controls.Add(this.mlblStatus);
			this.panel2.Location = new System.Drawing.Point(414, 21);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(209, 117);
			this.panel2.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 18);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 17);
			this.label8.TabIndex = 11;
			this.label8.Text = "Tình trạng:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(31, 67);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "Còn lại:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 41);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 17);
			this.label6.TabIndex = 9;
			this.label6.Text = "Thời gian:";
			// 
			// mlblDuration
			// 
			this.mlblDuration.AutoSize = true;
			this.mlblDuration.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.mlblDuration.Location = new System.Drawing.Point(92, 41);
			this.mlblDuration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mlblDuration.Name = "mlblDuration";
			this.mlblDuration.Size = new System.Drawing.Size(61, 19);
			this.mlblDuration.TabIndex = 7;
			this.mlblDuration.Text = "duration";
			// 
			// mlblTime
			// 
			this.mlblTime.AutoSize = true;
			this.mlblTime.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.mlblTime.Location = new System.Drawing.Point(92, 67);
			this.mlblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mlblTime.Name = "mlblTime";
			this.mlblTime.Size = new System.Drawing.Size(36, 19);
			this.mlblTime.TabIndex = 8;
			this.mlblTime.Text = "time";
			// 
			// mlblStatus
			// 
			this.mlblStatus.AutoSize = true;
			this.mlblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.mlblStatus.Location = new System.Drawing.Point(92, 18);
			this.mlblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mlblStatus.Name = "mlblStatus";
			this.mlblStatus.Size = new System.Drawing.Size(46, 19);
			this.mlblStatus.TabIndex = 6;
			this.mlblStatus.Text = "status";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.mlblStudentName);
			this.panel1.Controls.Add(this.mlblStudentId);
			this.panel1.Controls.Add(this.mlblDob);
			this.panel1.Controls.Add(this.mlblPhone);
			this.panel1.Location = new System.Drawing.Point(4, 21);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(405, 117);
			this.panel1.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label5.Location = new System.Drawing.Point(26, 91);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 17);
			this.label5.TabIndex = 20;
			this.label5.Text = "Điện thoại:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label4.Location = new System.Drawing.Point(26, 67);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 17);
			this.label4.TabIndex = 19;
			this.label4.Text = "Ngày sinh:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label3.Location = new System.Drawing.Point(44, 41);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 17);
			this.label3.TabIndex = 18;
			this.label3.Text = "Họ tên:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label2.Location = new System.Drawing.Point(20, 18);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 17);
			this.label2.TabIndex = 17;
			this.label2.Text = "Mã thí sinh:";
			// 
			// mlblStudentName
			// 
			this.mlblStudentName.AutoSize = true;
			this.mlblStudentName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.mlblStudentName.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.mlblStudentName.Location = new System.Drawing.Point(97, 41);
			this.mlblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mlblStudentName.Name = "mlblStudentName";
			this.mlblStudentName.Size = new System.Drawing.Size(92, 19);
			this.mlblStudentName.TabIndex = 14;
			this.mlblStudentName.Text = "studentName";
			// 
			// mlblStudentId
			// 
			this.mlblStudentId.AutoSize = true;
			this.mlblStudentId.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.mlblStudentId.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.mlblStudentId.Location = new System.Drawing.Point(97, 18);
			this.mlblStudentId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mlblStudentId.Name = "mlblStudentId";
			this.mlblStudentId.Size = new System.Drawing.Size(68, 19);
			this.mlblStudentId.TabIndex = 13;
			this.mlblStudentId.Text = "studentId";
			// 
			// mlblDob
			// 
			this.mlblDob.AutoSize = true;
			this.mlblDob.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.mlblDob.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.mlblDob.Location = new System.Drawing.Point(97, 67);
			this.mlblDob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mlblDob.Name = "mlblDob";
			this.mlblDob.Size = new System.Drawing.Size(33, 19);
			this.mlblDob.TabIndex = 15;
			this.mlblDob.Text = "dob";
			// 
			// mlblPhone
			// 
			this.mlblPhone.AutoSize = true;
			this.mlblPhone.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.mlblPhone.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.mlblPhone.Location = new System.Drawing.Point(97, 91);
			this.mlblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.mlblPhone.Name = "mlblPhone";
			this.mlblPhone.Size = new System.Drawing.Size(48, 19);
			this.mlblPhone.TabIndex = 16;
			this.mlblPhone.Text = "phone";
			// 
			// gbQuestion
			// 
			this.gbQuestion.Controls.Add(this.lblQuestion);
			this.gbQuestion.Controls.Add(this.mbtnNext);
			this.gbQuestion.Controls.Add(this.mbtnPrev);
			this.gbQuestion.Controls.Add(this.pnlAnswers);
			this.gbQuestion.Controls.Add(this.mbtnKey);
			this.gbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.gbQuestion.Location = new System.Drawing.Point(22, 210);
			this.gbQuestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbQuestion.Name = "gbQuestion";
			this.gbQuestion.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbQuestion.Size = new System.Drawing.Size(829, 498);
			this.gbQuestion.TabIndex = 1;
			this.gbQuestion.TabStop = false;
			this.gbQuestion.Text = "Nội dung câu hỏi";
			// 
			// lblQuestion
			// 
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuestion.Location = new System.Drawing.Point(24, 32);
			this.lblQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(128, 20);
			this.lblQuestion.TabIndex = 6;
			this.lblQuestion.Text = "content question";
			// 
			// mbtnNext
			// 
			this.mbtnNext.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnNext.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnNext.Location = new System.Drawing.Point(471, 462);
			this.mbtnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.mbtnNext.Name = "mbtnNext";
			this.mbtnNext.Size = new System.Drawing.Size(118, 31);
			this.mbtnNext.TabIndex = 5;
			this.mbtnNext.Text = "Sau";
			this.mbtnNext.UseSelectable = true;
			this.mbtnNext.Click += new System.EventHandler(this.mbtnNext_Click);
			// 
			// mbtnPrev
			// 
			this.mbtnPrev.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnPrev.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnPrev.Location = new System.Drawing.Point(346, 462);
			this.mbtnPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.mbtnPrev.Name = "mbtnPrev";
			this.mbtnPrev.Size = new System.Drawing.Size(118, 31);
			this.mbtnPrev.TabIndex = 4;
			this.mbtnPrev.Text = "Trước";
			this.mbtnPrev.UseSelectable = true;
			this.mbtnPrev.Click += new System.EventHandler(this.mbtnPrev_Click);
			// 
			// pnlAnswers
			// 
			this.pnlAnswers.Location = new System.Drawing.Point(28, 63);
			this.pnlAnswers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pnlAnswers.Name = "pnlAnswers";
			this.pnlAnswers.Size = new System.Drawing.Size(791, 327);
			this.pnlAnswers.TabIndex = 3;
			// 
			// mbtnKey
			// 
			this.mbtnKey.FontSize = MetroFramework.MetroButtonSize.Tall;
			this.mbtnKey.FontWeight = MetroFramework.MetroButtonWeight.Regular;
			this.mbtnKey.Location = new System.Drawing.Point(708, 462);
			this.mbtnKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.mbtnKey.Name = "mbtnKey";
			this.mbtnKey.Size = new System.Drawing.Size(116, 31);
			this.mbtnKey.TabIndex = 0;
			this.mbtnKey.Text = "Đáp án";
			this.mbtnKey.UseSelectable = true;
			this.mbtnKey.Click += new System.EventHandler(this.mbtnKey_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// gbAnswers
			// 
			this.gbAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.gbAnswers.Location = new System.Drawing.Point(856, 63);
			this.gbAnswers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbAnswers.Name = "gbAnswers";
			this.gbAnswers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbAnswers.Size = new System.Drawing.Size(358, 646);
			this.gbAnswers.TabIndex = 2;
			this.gbAnswers.TabStop = false;
			this.gbAnswers.Text = "Thông tin câu hỏi";
			// 
			// frmExam
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1236, 731);
			this.Controls.Add(this.gbAnswers);
			this.Controls.Add(this.gbQuestion);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmExam";
			this.groupBox1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gbQuestion.ResumeLayout(false);
			this.gbQuestion.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gbQuestion;
		private MetroFramework.Controls.MetroLabel mlblTime;
		private MetroFramework.Controls.MetroLabel mlblDuration;
		private MetroFramework.Controls.MetroLabel mlblStatus;
		private MetroFramework.Controls.MetroLabel mlblPhone;
		private MetroFramework.Controls.MetroLabel mlblDob;
		private MetroFramework.Controls.MetroLabel mlblStudentName;
		private MetroFramework.Controls.MetroLabel mlblStudentId;
		private MetroFramework.Controls.MetroButton mbtnKey;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel pnlAnswers;
		private MetroFramework.Controls.MetroButton mbtnPrev;
		private MetroFramework.Controls.MetroButton mbtnNext;
		private System.Windows.Forms.Label lblQuestion;
		private MetroFramework.Controls.MetroButton mbtnTurnIn;
		private System.Windows.Forms.GroupBox gbAnswers;
	}
}