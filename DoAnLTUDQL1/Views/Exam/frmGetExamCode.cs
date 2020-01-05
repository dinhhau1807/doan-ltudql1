using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTUDQL1.Views.Exam
{
	public partial class frmGetExamCode : MetroFramework.Forms.MetroForm
	{
		public event EventHandler ChooseExamCode;

		private bool isChoose;

		public frmGetExamCode(List<ExamCode> examCodeList)
		{
			InitializeComponent();

			isChoose = false;

			mcmbExamCode.DataSource = examCodeList;
			mcmbExamCode.DisplayMember = "ExamCodeId";
			mcmbExamCode.ValueMember = "ExamCodeId";

			mcmbExamCode.SelectedIndex = 0;

			this.FormClosing += FrmGetExamCode_FormClosing;
		}

		private void FrmGetExamCode_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isChoose)
			{
				if(MessageBox.Show("Tự động chọn mã đề đầu tiên ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					e.Cancel = true;
					return;
				}
			}

			if (ChooseExamCode != null)
				ChooseExamCode(mcmbExamCode.SelectedValue.ToString(), null);
		}

		private void btnChoose_Click(object sender, EventArgs e)
		{
			isChoose = true;

			this.Close();
		}
	}
}
