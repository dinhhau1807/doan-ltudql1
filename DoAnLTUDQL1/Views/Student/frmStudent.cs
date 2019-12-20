using DoAnLTUDQL1.Presenters;
using DoAnLTUDQL1.Validators;
using DoAnLTUDQL1.Views.Exam;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace DoAnLTUDQL1.Views.Student
{
	public partial class frmStudent : MetroForm, IStudentView
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
		List<BaseValidator> PasswordValidatorList;
		List<BaseValidator> ProfileValidatorList;
		#endregion

		#region IView
		private string _message;
		public string Message
		{
			get { return _message; }
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

				if (_theLastestExamDetail != null)
				{
					mpnlExamDetailInfo.Show();
					mlblExamName.Text = _theLastestExamDetail.ExamName;
					mlblSubjectId.Text = _theLastestExamDetail.SubjectId;
					mlblSubjectName.Text = _theLastestExamDetail.SubjectName;
					mlblGradeName.Text = _theLastestExamDetail.GradeName;
					mlblStartTime.Text = _theLastestExamDetail.StartTime.ToString("dd/MM/yyyy - HH:mm");
					mlblDuration.Text = _theLastestExamDetail.Duration.ToString() + " phút";
				}
				else
				{
					mpnlExamDetailInfo.Hide();
					mlblExamName.Text = "Không có môn thi nào";
				}
			}
		}

		public event Func<User> Logout;
		public event Func<User> ChangePassword;
		public event Func<bool> ChangeUserProfile;
		public event EventHandler ExamDetailFilter;
		public event EventHandler ExamResultFilter;
		public event Func<int> StartExamination;
		#endregion

		#region user defined methods
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

		void RequireValidatingControls()
		{			
			RequiedInputValidator rqOldPassword, rqNewPassword,
				rqReNewPassword, rqFirstName, rqLastName, rqPhone;

			rqOldPassword = new RequiedInputValidator();
			rqNewPassword = new RequiedInputValidator();
			rqReNewPassword = new RequiedInputValidator();
			rqFirstName = new RequiedInputValidator();
			rqLastName = new RequiedInputValidator();
			rqPhone = new RequiedInputValidator();

			rqOldPassword.ControlToValidate = mtxtOldPassword;
			rqNewPassword.ControlToValidate = mtxtNewPassword;
			rqReNewPassword.ControlToValidate = mtxtRenewPassword;
			rqFirstName.ControlToValidate = mtxtFirstName;
			rqLastName.ControlToValidate = mtxtLastName;
			rqPhone.ControlToValidate = mtxtPhone;

			PasswordValidatorList.Add(rqOldPassword);
			PasswordValidatorList.Add(rqNewPassword);
			PasswordValidatorList.Add(rqReNewPassword);

			ProfileValidatorList.Add(rqLastName);
			ProfileValidatorList.Add(rqFirstName);			
			ProfileValidatorList.Add(rqPhone);
		}

		void RegexValidatingControls()
		{
			RegexValidator rgPassword, rgLastName, rgFirstName, rgPhone;

			string errorMessagePassword = "Chỉ gồm các ký tự: a-z, A-Z, 0-9, tối thiểu 3 ký tự";
			string errorMessageName = "Không được nhập số hoặc ký tự đặc biệt";
			string errorMessagePhone = "Chỉ chứa số và phải chứa từ 10 kí tự trở lên";

			rgPassword = new RegexValidator(RegexPattern.Password);
			rgPassword.ErrorMessage = errorMessagePassword;
			rgLastName = new RegexValidator(RegexPattern.Name);
			rgLastName.ErrorMessage = errorMessageName;
			rgFirstName = new RegexValidator(RegexPattern.Name);
			rgFirstName.ErrorMessage = errorMessageName;
			rgPhone = new RegexValidator(RegexPattern.Phone);
			rgPhone.ErrorMessage = errorMessagePhone;

			rgPassword.ControlToValidate = mtxtNewPassword;
			rgLastName.ControlToValidate = mtxtLastName;
			rgFirstName.ControlToValidate = mtxtFirstName;
			rgPhone.ControlToValidate = mtxtPhone;

			PasswordValidatorList.Add(rgPassword);

			ProfileValidatorList.Add(rgLastName);
			ProfileValidatorList.Add(rgFirstName);
			ProfileValidatorList.Add(rgPhone);
		}
		#endregion

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

			PasswordValidatorList = new List<BaseValidator>();
			ProfileValidatorList = new List<BaseValidator>();
			RequireValidatingControls();
			RegexValidatingControls();
		}

		private void mbtnLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void mbtnChangePassword_Click(object sender, EventArgs e)
		{
			if(!PasswordValidatorList.All(a => a.IsValid))
			{
				MessageBox.Show("Dữ liệu nhập không đúng định dạng, mời nhập lại!");

				var InvalidValidatingControl = PasswordValidatorList.First(f => !f.IsValid);
				InvalidValidatingControl.ControlToValidate.Focus();

				return;
			}

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
			if (IsEditType)
			{
				if (!ProfileValidatorList.All(a => a.IsValid))
				{
					MessageBox.Show("Dữ liệu nhập không đúng định dạng, mời nhập lại!");

					var InvalidValidatingControl = ProfileValidatorList.First(f => !f.IsValid);
					InvalidValidatingControl.ControlToValidate.Focus();

					return;
				}

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
			if (isStart.Value == 0)
			{
				//open new form here
				this.Hide();
				using (frmExam frm = new frmExam(TheLatestExamDetail.ExamDetailId, CurrentUser.Username))
				{
					frm.formClosed += Frm_formClosed;
					frm.ShowDialog();
				}
				this.Show();
			}
			else
			{
				MessageBox.Show(Message);
				//reset exam detail and exam list
				if (isStart.Value == 1)
				{
					ExamResultFilter?.Invoke(mcmbExamResult.SelectedValue, null);
					ExamDetailFilter?.Invoke(mcmbExamDetail.SelectedValue, null);
				}
			}
		}

		private void Frm_formClosed(object sender, EventArgs e)
		{
			//refresh student form after closing the exam form
			InitTypeOfExamComboboxes();
		}
	}
}
