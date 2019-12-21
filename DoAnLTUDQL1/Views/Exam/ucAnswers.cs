using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace DoAnLTUDQL1.Views.Exam
{
	public partial class ucAnswers : MetroUserControl
	{
		public event EventHandler ChangeQuestion;

		private bool _isActice;
		public bool IsActive
		{ 
			get { return _isActice; }
			set
			{
				_isActice = value;
				label.ForeColor = _isActice ? Color.Blue : Color.Black;
			} 
		}
		public List<MetroCheckBox> CheckboxList { get; set; }

		Label label = new Label();
		
		public ucAnswers(int index, List<Answer> answerList)
		{
			InitializeComponent();

			label.Text = $"Câu {index}:";
			label.Dock = DockStyle.Left;
			label.BackColor = Color.White;
			label.ForeColor = Color.Black;
			label.Cursor = Cursors.Hand;
			label.Width = 50;
			label.Padding = new Padding(4, 4, 0, 0);
			label.MouseEnter += Label_MouseEnter;
			label.MouseLeave += Label_MouseLeave;
			label.Click += Label_Click;
			this.Controls.Add(label);

			CheckboxList = new List<MetroCheckBox>();

			int length = answerList.Count;
			for (int i = 0, c = 65; i < length; i++)
			{
				MetroCheckBox chk = new MetroCheckBox();
				chk.Text = $"{(char)c}";
				chk.Dock = DockStyle.Left;
				chk.Width = 30;
				chk.Tag = answerList[i];

				this.Controls.Add(chk);
				this.Controls.SetChildIndex(chk, 0);

				CheckboxList.Add(chk);

				c++;
			}
		}

		private void Label_Click(object sender, EventArgs e)
		{
			if (ChangeQuestion != null)
				ChangeQuestion((this.Tag as Question).QuestionId, null);
		}

		private void Label_MouseLeave(object sender, EventArgs e)
		{
			if (IsActive)
				return;

			this.label.ForeColor = Color.Black;
		}

		private void Label_MouseEnter(object sender, EventArgs e)
		{
			if (IsActive)
				return;

			this.label.ForeColor = Color.Red;
		}
	}
}
