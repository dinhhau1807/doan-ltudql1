using DoAnLTUDQL1.Presenters;
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
	public partial class frmExam : MetroFramework.Forms.MetroForm, IExamView
	{
		public event EventHandler formClosed;

		ExamPresenter presenter;

		List<ucAnswers> ucAnswersList;

		bool isShowKey;
		bool isTurnInTheExam;

		private long _seconds;
		public long Seconds
		{
			get { return _seconds; }
			set
			{
				_seconds = value;
				mlblTime.Text = convertDurationToExamTime(_seconds);
			}
		}
		public frmExam(string examDetailId, string username)
		{
			InitializeComponent();

			presenter = new ExamPresenter(this, examDetailId, username);

			isShowKey = false;
			isTurnInTheExam = false;

			this.Width = 1211;
			this.Load += FrmExam_Load;
			this.FormClosing += FrmExam_FormClosing;
		}

		private dynamic _studentInfo;
		public dynamic StudentInfo
		{
			get { return _studentInfo; }
			set
			{
				_studentInfo = value;
				if (_studentInfo != null)
				{
					mlblStudentId.Text = _studentInfo.StudentId;
					mlblStudentName.Text = _studentInfo.Name;
					mlblDob.Text = _studentInfo.Dob.ToString("dd/MM/yyyy");
					mlblPhone.Text = _studentInfo.Phone;
				}
			}
		}
		private ExamDetail _examDetail;
		public ExamDetail ExamDetail
		{
			get { return _examDetail; }
			set
			{
				_examDetail = value;
				if (_examDetail != null)
				{
					DateTime now = DateTime.Now;
					DateTime examTime = ExamDetail.StartTime.Value.AddMinutes(ExamDetail.Duration.Value);

					TimeSpan ts = examTime - now;

					Seconds = Convert.ToInt64(Math.Round(ts.TotalSeconds));

					mlblStatus.Text = _examDetail.Duration != 0 ? "Đang thi" : "Hoàn thành";
					mlblDuration.Text = _examDetail.Duration.ToString() + " phút";
				}
			}
		}

		private Question _question;
		public Question Question
		{
			get { return _question; }
			set
			{
				_question = value;
				if (_question != null)
				{
					lblQuestion.Text = _question.Content;

					//set color to specific uc 
					foreach (var item in ucAnswersList)
					{
						if ((item.Tag as Question).QuestionId == _question.QuestionId)
						{
							item.IsActive = true;
						}
						else
						{
							item.IsActive = false;
						}
					}
				}
				else
				{
					lblQuestion.Text = "Có lỗi";
				}
			}
		}
		private List<Answer> _answerList;
		public List<Answer> AnswerList
		{
			get { return _answerList; }
			set
			{
				_answerList = value;

				pnlAnswers.Controls.Clear();
				if (_answerList != null && _answerList.Count > 0)
				{
					int length = _answerList.Count;
					for (int i = 0, c = 65; i < length; i++)
					{
						Label answer = new Label();
						answer.MaximumSize = new Size(800, 0);
						answer.AutoSize = true;
						answer.ForeColor = Color.Black;
						answer.Font = new Font(answer.Font.FontFamily, 12);
						answer.Dock = DockStyle.Top;
						answer.Padding = new Padding(0, 0, 0, 10);
						answer.Text = $"{(char)c}. {_answerList[i].Content}";

						if (isShowKey && _answerList[i].IsCorrect.Value)
						{
							answer.ForeColor = Color.Red;
						}
						else
						{
							answer.ForeColor = Color.Black;
						}

						pnlAnswers.Controls.Add(answer);
						pnlAnswers.Controls.SetChildIndex(answer, 0);

						c++;
					}
				}
			}
		}
		private List<Question> _questionList;
		public List<Question> QuestionList
		{
			get { return _questionList; }
			set
			{
				_questionList = value;
				ucAnswersList = new List<ucAnswers>();
				gbAnswers.Controls.Clear();

				int i = 1;
				foreach (var item in _questionList)
				{
					ucAnswers uc = new ucAnswers(i, item.Answers.ToList());
					uc.Tag = item; //store the question
					uc.Dock = DockStyle.Top;
					uc.ChangeQuestion += Uc_ChangeQuestion;
					gbAnswers.Controls.Add(uc);
					gbAnswers.Controls.SetChildIndex(uc, 0);

					ucAnswersList.Add(uc);
					i++;
				}
			}
		}
		private ExamCode _examCode;
		public ExamCode ExamCode 
		{ 
			get { return _examCode; }  
			set 
			{ 
				_examCode = value;
				this.Text = "Mã đề: " + _examCode.ExamCodeId;
			} 
		}

		private void Uc_ChangeQuestion(object sender, EventArgs e)
		{
			isShowKey = false;
			//e: questionId
			changeQuestion?.Invoke(int.Parse(sender.ToString()), null);
		}

		public event Func<bool> createExamAttendance;
		public event EventHandler prevQuestion;
		public event EventHandler nextQuestion;
		public event EventHandler showKeyQuestion;
		public event EventHandler turnInTheExam;
		public event EventHandler changeQuestion;
		public event EventHandler setExamCode;
		public event Func<bool, List<ExamCode>> getExamCodeList;

		string convertDurationToExamTime(long milliseconds)
		{
			long h = 0, m = 0, s = 0;
			string sh = "", sm = "", ss = "";
			h = milliseconds / 3600;
			milliseconds = milliseconds % 3600;
			m = milliseconds / 60;
			s = milliseconds % 60;

			sh = h < 10 ? $"0{h}" : h.ToString();
			sm = m < 10 ? $"0{m}" : m.ToString();
			ss = s < 10 ? $"0{s}" : s.ToString();
			return $"{sh}:{sm}:{ss}";
		}

		void startExamination(bool isPracticeExam)
		{
			var examCodeList = getExamCodeList?.Invoke(isPracticeExam);
			if (examCodeList.Count == 0)
			{
				MessageBox.Show("Chưa có mã đề thi nào!");
				this.Close();
			}
			else
			{
				if (isPracticeExam)
				{
					using (frmGetExamCode frm = new frmGetExamCode(examCodeList))
					{
						frm.ChooseExamCode += Frm_ChooseExamCode;
						frm.ShowDialog();
					}
				}
				else
				{
					//the exam code will be randomed
					setExamCode?.Invoke("", null);
				}
			}
		}

		void endExamination()
		{
			//disable controls
			gbAnswers.Enabled = false;
			mlblStatus.Text = "Hoàn thành";
			mbtnTurnIn.Enabled = false;
			timer1.Stop();

			List<dynamic> checkedAnswers = new List<dynamic>();
			foreach (var uc in ucAnswersList)
			{
				dynamic checkedAnswer = new
				{
					(uc.Tag as Question).QuestionId,
					Answers = uc.CheckboxList
									.Where(chk => chk.Checked)
									.Select(s => s.Tag as Answer).ToList()
				};

				checkedAnswers.Add(checkedAnswer);
			}

			turnInTheExam?.Invoke(checkedAnswers, null);

			isTurnInTheExam = true;
		}

		private void Frm_ChooseExamCode(object sender, EventArgs e)
		{
			//sender: examCodeId
			setExamCode?.Invoke(sender, null);
		}

		private void FrmExam_Load(object sender, EventArgs e)
		{
			var isPracticeExam = ExamDetail.Exam.IsPacticeExam.Value;
			if (isPracticeExam)
			{
				mbtnKey.Visible = true;
			}
			else
			{
				mbtnKey.Visible = false;
			}

			lblQuestion.Text = "";
			lblQuestion.Dock = DockStyle.Top;
			lblQuestion.AutoSize = true;
			lblQuestion.MaximumSize = new Size(800, 0);
			lblQuestion.Padding = new Padding(10, 20, 10, 20);

			pnlAnswers.Dock = DockStyle.Top;
			pnlAnswers.Padding = new Padding(10, 0, 10, 0);
			pnlAnswers.AutoSize = true;

			//set order control
			//0: sends control to the bottom of the parent control
			gbQuestion.Controls.SetChildIndex(pnlAnswers, 0);

			var isCreated = createExamAttendance?.Invoke();
			if (!isCreated.Value)
			{
				MessageBox.Show("Có lỗi khi tham gia thi!");
				isTurnInTheExam = true;
				this.Close();
			}
			else
			{
				startExamination(isPracticeExam);

				timer1.Interval = 1000;
				timer1.Enabled = true;
				timer1.Start();
			}			
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Seconds = Seconds - 1;

			if (Seconds == 0)
			{				
				endExamination();
				MessageBox.Show("Hết thời gian làm bài!");
			}
		}

		private void mbtnPrev_Click(object sender, EventArgs e)
		{
			isShowKey = false;
			prevQuestion?.Invoke(this, null);
		}

		private void mbtnNext_Click(object sender, EventArgs e)
		{
			isShowKey = false;
			nextQuestion?.Invoke(this, null);
		}

		//nop bai
		private void mbtnTurnIn_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Bạn có chắc chắn nộp bài ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				return;
			}

			endExamination();
		}

		private void mbtnKey_Click(object sender, EventArgs e)
		{
			if (!isShowKey)
			{
				isShowKey = true;
				showKeyQuestion?.Invoke(this, null);
			}
		}

		private void FrmExam_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!isTurnInTheExam)
			{
				MessageBox.Show("Bạn chưa nộp bài!");
				e.Cancel = true;
			}

			if (formClosed != null)
			{
				formClosed(this, null);
			}
		}
	}
}
