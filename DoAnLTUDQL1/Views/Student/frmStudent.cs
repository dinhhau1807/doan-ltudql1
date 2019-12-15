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

namespace DoAnLTUDQL1.Views.Student
{
	public partial class frmStudent : MetroFramework.Forms.MetroForm, IStudentView
	{
		#region global variables
		StudentPresenter presenter;
		User CurrentUser;
		private bool _isEditType;
		public bool IsEditType
		{
			get { return _isEditType; }
			set
			{
				if (value)
				{
					EnabledUserControl();
					mbtnChangeProfile.Text = "Xác nhận cập nhật thông tin";
				}
				else
				{
					DisableUserControl();
					mbtnChangeProfile.Text = "Cập nhật thông tin";
				}
				_isEditType = value;				
			}
		}
		IEnumerable<dynamic> typeOfExamList;
		#endregion

		private string _message;
		public string Message
		{
			get	{ return _message; } 
			set { _message = value; } 
		}
		public string StudentId 
		{ 
			get { return mtxtStudentId.Text; } 
			set { mtxtStudentId.Text = value; }
		}
		public string FirstName
		{
			get { return mtxtFirstName.Text; }
			set { mtxtFirstName.Text = value; } 
		}
		public string LastName 
		{ 
			get { return mtxtLastName.Text; }
			set { mtxtLastName.Text = value; } 
		}
		public string Phone
		{ 
			get { return mtxtPhone.Text; }
			set { mtxtPhone.Text = value; } 
		}
		public DateTime? Dob 
		{ 
			get { return DateTime.Parse(mdtDob.Value.ToString()); }
			set { mdtDob.Value = DateTime.Parse(value.Value.ToString("dd/MM/yyyy")); }
		}
		public DateTime? CreatedDate
		{ 
			get { return DateTime.Parse(mdtCreatedDate.Value.ToString()); } 
			set { mdtCreatedDate.Value = DateTime.Parse(value.Value.ToString("dd/MM/yyyy")); } 
		}
		public DateTime? LastLoginDate
		{ 
			get { return DateTime.Parse(mlblLastLoginDate.Text); } 
			set { mlblLastLoginDate.Text = value.Value.ToString("dd/MM/yyyy hh:mm:ss"); } 
		}

		public string oldPassword 
		{
			get { return mtxtOldPassword.Text; } 
			set { mtxtOldPassword.Text = value; }
		}
		public string newPassword 
		{ 
			get { return mtxtNewPassword.Text; }
			set { mtxtNewPassword.Text = value; } 
		}
		public string reNewPassword 
		{ 
			get { return mtxtRenewPassword.Text; }
			set { mtxtRenewPassword.Text = value; } 
		}

		private IEnumerable<dynamic> _examDetailList;
		public IEnumerable<dynamic> ExamDetailList
		{ 
			get { return _examDetailList; } 
			set 
			{ 
				_examDetailList = value;
				mdgExamDetail.DataSource = _examDetailList;
			}
		}
		private IEnumerable<dynamic> _examResultList;
		public IEnumerable<dynamic> ExamResultList
		{ 
			get { return _examResultList; } 
			set 
			{
				_examResultList = value;
				mdgExamResult.DataSource = _examResultList;
			}
		}
		private dynamic _theLastestExamDetail;
		public dynamic TheLatestExamDetail 
		{ 
			get { return _theLastestExamDetail; }
			set 
			{
				_theLastestExamDetail = value;

				if(_theLastestExamDetail != null)
				{
					mpnlExamDetailInfo.Show();
					mlblExamName.Text = _theLastestExamDetail.ExamName;
					mlblSubjectId.Text = _theLastestExamDetail.SubjectId;
					mlblSubjectName.Text = _theLastestExamDetail.SubjectName;
					mlblGradeName.Text = _theLastestExamDetail.GradeName;
					mlblStartTime.Text = _theLastestExamDetail.StartTime.ToString("dd/MM/yyyy - HH:mm");
					mlblDuration.Text = _theLastestExamDetail.Duration.ToString();
				}
				else
				{
					mpnlExamDetailInfo.Hide();
					mlblExamName.Text = "Không có kỳ thi nào";
				}
			}
		}

		public event Func<User> Logout;
		public event Func<User> ChangePassword;
		public event Func<bool> ChangeUserProfile;
		public event EventHandler ExamDetailFilter;
		public event EventHandler ExamResultFilter;
		public event Func<int> StartExamination;

		void EnabledUserControl()
		{
			mtxtFirstName.Enabled = true;
			mtxtLastName.Enabled = true;
			mtxtPhone.Enabled = true;
			mdtDob.Enabled = true;
		}

		void DisableUserControl()
		{
			mtxtFirstName.Enabled = false;
			mtxtLastName.Enabled = false;
			mtxtPhone.Enabled = false;
			mdtDob.Enabled = false;
		}

		void InitExamDetailGridView()
		{
			mdgExamDetail.MultiSelect = false;
			mdgExamDetail.Font = new Font(mdgExamDetail.Font.FontFamily, 10);
		}

		void InitExamResultGridView()
		{
			mdgExamResult.MultiSelect = false;
			mdgExamResult.Font = new Font(mdgExamDetail.Font.FontFamily, 10);
		}

		void InitTypeOfExamComboboxes()
		{
			mcmbExamDetail.DataSource = typeOfExamList.ToList();
			mcmbExamDetail.DisplayMember = "Name";
			mcmbExamDetail.ValueMember = "Value";
			mcmbExamDetail.SelectedIndex = 0;
			mcmbExamDetail.SelectedIndexChanged += McmbExamDetail_SelectedIndexChanged;

			mcmbExamResult.DataSource = typeOfExamList.ToList();
			mcmbExamResult.DisplayMember = "Name";
			mcmbExamResult.ValueMember = "Value";
			mcmbExamResult.SelectedIndex = 0;
			mcmbExamResult.SelectedIndexChanged += McmbExamResult_SelectedIndexChanged;
		}

		public frmStudent(User user)
		{
			InitializeComponent();			

			CurrentUser = user;
			IsEditType = false;
			typeOfExamList = new List<dynamic>
			{
				new { Name = "Tất cả", Value = (int)Enums.TYPE_OF_EXAM.ALL },
				new { Name = "Thi chính thức", Value = (int)Enums.TYPE_OF_EXAM.MAIN_EXAM },
				new { Name = "Thi thử", Value = (int)Enums.TYPE_OF_EXAM.PRACTICE_EXAM },
			};

			presenter = new StudentPresenter(this, user);

			this.Text = CurrentUser != null ? CurrentUser.Username : "";
			this.Load += FrmStudentMainPage_Load;
		}

		private void FrmStudentMainPage_Load(object sender, EventArgs e)
		{
			mtxtStudentId.Enabled = false;
			mdtCreatedDate.Enabled = false;
			mtcStudentPage.SelectedIndex = 0;

			InitExamDetailGridView();
			InitExamResultGridView();
			InitTypeOfExamComboboxes();
		}

		private void mbtnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void mbtnChangePassword_Click(object sender, EventArgs e)
		{
			User user = ChangePassword?.Invoke();
			if (user == null)
			{
				MessageBox.Show(Message);
			}
			else
			{
				MessageBox.Show("Đổi mật khẩu thành công!");
				CurrentUser = user;
				oldPassword = "";
				newPassword = "";
				reNewPassword = "";
			}
		}

		private void frmStudent_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(MessageBox.Show("Bạn có đồng ý đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				CurrentUser = Logout?.Invoke();
			}
			else
			{
				e.Cancel = true;
			}
		}

		private void mbtnChangeProfile_Click(object sender, EventArgs e)
		{
			if(IsEditType)
			{
				var isValid = ChangeUserProfile?.Invoke();
				if (!isValid.Value)
				{
					MessageBox.Show(Message);
					return;
				}
				else
				{
					MessageBox.Show(Message);					
				}
			}
			IsEditType = !IsEditType;
		}

		private void McmbExamResult_SelectedIndexChanged(object sender, EventArgs e)
		{
			ExamResultFilter?.Invoke(mcmbExamResult.SelectedValue, null);
		}

		private void McmbExamDetail_SelectedIndexChanged(object sender, EventArgs e)
		{
			ExamDetailFilter?.Invoke(mcmbExamDetail.SelectedValue, null);
		}

		private void mbtnStartExamination_Click(object sender, EventArgs e)
		{
			int? isStart = StartExamination?.Invoke();
			if(isStart.Value == 0)
			{
				MessageBox.Show("Chúc bạn thi thật tốt!");

				//open new form here

			}
			else
			{
				MessageBox.Show(Message);
				//reset exam detail and exam list
				if(isStart.Value == 1)
				{
					ExamResultFilter?.Invoke(mcmbExamResult.SelectedValue, null);
					ExamDetailFilter?.Invoke(mcmbExamDetail.SelectedValue, null);
				}
			}
		}
	}
}
