using DoAnLTUDQL1.Presenters;
using DoAnLTUDQL1.Validators;
using DoAnLTUDQL1.ViewModels;
using DoAnLTUDQL1.Views.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTUDQL1.Views.TeacherView
{
    public partial class frmTeacher : MetroFramework.Forms.MetroForm, ITeacherView
    {
        TeacherPresenter presenter;

        List<BaseValidator> PasswordValidatorList;
        List<BaseValidator> ProfileValidatorList;

        public frmTeacher(Teacher teacher)
        {
            CurrentUser = teacher;
            InitializeComponent();
            Load += FrmTeacher_Load;
        }


        #region Events
        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            presenter = new TeacherPresenter(this);
            this.Text = $"{CurrentUser.TeacherId} - {CurrentUserInfo.LastName} {CurrentUserInfo.FirstName}";

            // Logout page
            mLblLastLoginDate.Text = CurrentUserInfo.LastLoginDate.ToString();


            // Init for change info tab
            mTxtInfoTeacherId.Text = CurrentUser.TeacherId;
            mTxtInfoFirstName.Text = CurrentUserInfo.FirstName;
            mTxtInfoLastName.Text = CurrentUserInfo.LastName;
            mTxtInfoPhone.Text = CurrentUserInfo.Phone;
            mDateTimeInfoDob.Value = CurrentUserInfo.Dob.GetValueOrDefault(new DateTime(0001, 01, 01));
            mTxtInfoCreatedDate.Text = CurrentUserInfo.CreatedDate.ToString();
            EnableChangeInfo(false);


            // Set data bindings
            SetDataBinding();


            // Register events
            // Tab manage
            mTileQuestion.Click += MTileQuestion_Click;
            mTileExamCode.Click += MTileExamCode_Click;
            mTileExam.Click += MTileExam_Click;
            mTilePracticeExam.Click += MTilePracticeExam_Click;
            mTileStudent.Click += MTileStudent_Click;

            // Change info - Change password - Logout
            mBtnChangeInfo.Click += MBtnChangeInfo_Click;
            mBtnChangePassword.Click += MBtnChangePassword_Click;
            mBtnLogout.Click += MBtnLogout_Click;

            // Close
            FormClosing += FrmTeacher_FormClosing;

            // Select tab first startup
            mTabCtrl.SelectTab(0);

            PasswordValidatorList = new List<BaseValidator>();
            ProfileValidatorList = new List<BaseValidator>();
            RequireValidatingControls();
            RegexValidatingControls();
        }

        // Close
        private void FrmTeacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Thread tLogin = new Thread(_ =>
                {
                    Application.Run(new frmLogin());
                });
                tLogin.Start();
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }


        // Tab manage
        private void MTileQuestion_Click(object sender, EventArgs e)
        {
            var frmQuestion = new frmTeacherQuestion(CurrentUser, CurrentUserInfo);
            frmQuestion.ShowDialog();
        }

        private void MTileExamCode_Click(object sender, EventArgs e)
        {
            var frmExamCode = new frmTeacherExamCode(CurrentUser, CurrentUserInfo);
            frmExamCode.ShowDialog();
        }

        private void MTileExam_Click(object sender, EventArgs e)
        {
            var frmExam = new frmTeacherExam(CurrentUser, CurrentUserInfo);
            frmExam.ShowDialog();
        }

        private void MTilePracticeExam_Click(object sender, EventArgs e)
        {
            var frmPracticeExam = new frmTeacherPracticeExam(CurrentUser, CurrentUserInfo);
            frmPracticeExam.ShowDialog();
        }

        private void MTileStudent_Click(object sender, EventArgs e)
        {
            var frmTeacherStudent = new frmTeacherStudent(CurrentUser, CurrentUserInfo);
            frmTeacherStudent.ShowDialog();
        }


        // Tab change info
        private void MBtnChangeInfo_Click(object sender, EventArgs e)
        {

            if (mBtnChangeInfo.Text == "Thay đổi thông tin cá nhân")
            {
                EnableChangeInfo(true);
                mBtnChangeInfo.Text = "Lưu thay đổi";
            }
            else if (mBtnChangeInfo.Text == "Lưu thay đổi")
            {
                if (!ProfileValidatorList.All(a => a.IsValid))
                {
                    var InvalidValidatingControl = ProfileValidatorList.First(f => !f.IsValid);
                    InvalidValidatingControl.ControlToValidate.Focus();

                    return;
                }

                CurrentUserInfo.FirstName = mTxtInfoFirstName.Text;
                CurrentUserInfo.LastName = mTxtInfoLastName.Text;
                CurrentUserInfo.Phone = mTxtInfoPhone.Text;
                CurrentUserInfo.Dob = mDateTimeInfoDob.Value;

                SaveInfo?.Invoke(this, null);

                EnableChangeInfo(false);
                mBtnChangeInfo.Text = "Thay đổi thông tin cá nhân";
                this.ResetText();
                this.Text = $"{CurrentUser.TeacherId} - {CurrentUserInfo.LastName} {CurrentUserInfo.FirstName}";
            }
        }


        // Tab change password
        private void MBtnChangePassword_Click(object sender, EventArgs e)
        {
            if (!PasswordValidatorList.All(a => a.IsValid))
            {
                var InvalidValidatingControl = PasswordValidatorList.First(f => !f.IsValid);
                InvalidValidatingControl.ControlToValidate.Focus();

                return;
            }

            OldPassword = mTxtOldPassword.Text;
            NewPassword = mTxtNewPassword.Text;
            ConfirmNewPassword = mTxtConfirmPassword.Text;

            ChangePassword?.Invoke(this, null);
        }


        // Tab logout
        private void MBtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();

                Thread tLogin = new Thread(_ =>
                {
                    Application.Run(new frmLogin());
                });
                tLogin.Start();

                this.Close();
            }
        }
        #endregion


        #region ITeacherView implementations
        // Events
        public event EventHandler ChangePassword;
        public event EventHandler SaveInfo;

        // Get user information
        public Teacher CurrentUser { get; set; }
        public User CurrentUserInfo { get; set; }

        // Change password
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmNewPassword { get; set; }
        public string ChangePasswordMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    mTxtOldPassword.ResetText();
                    mTxtNewPassword.ResetText();
                    mTxtConfirmPassword.ResetText();
                    MessageBox.Show("Thay đổi mật khẩu thành công!");
                    return;
                }

                MessageBox.Show("Thay đổi mật khẩu thất bại!");
            }
        }
        #endregion


        #region Utilities
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

            rqOldPassword.ControlToValidate = mTxtOldPassword;
            rqNewPassword.ControlToValidate = mTxtNewPassword;
            rqReNewPassword.ControlToValidate = mTxtConfirmPassword;

            rqFirstName.ControlToValidate = mTxtInfoFirstName;
            rqLastName.ControlToValidate = mTxtInfoLastName;
            rqPhone.ControlToValidate = mTxtInfoPhone;

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

            string errorMessagePassword = "Chỉ gồm chữ và số, tối thiểu 3 ký tự";
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

            rgPassword.ControlToValidate = mTxtNewPassword;
            rgLastName.ControlToValidate = mTxtInfoLastName;
            rgFirstName.ControlToValidate = mTxtInfoFirstName;
            rgPhone.ControlToValidate = mTxtInfoPhone;

            PasswordValidatorList.Add(rgPassword);

            ProfileValidatorList.Add(rgLastName);
            ProfileValidatorList.Add(rgFirstName);
            ProfileValidatorList.Add(rgPhone);
        }
        private void SetDataBinding()
        {
            // Bindings something
        }

        private void EnableChangeInfo(bool enable)
        {
            mTxtInfoFirstName.Enabled = enable;
            mTxtInfoLastName.Enabled = enable;
            mTxtInfoPhone.Enabled = enable;
            mDateTimeInfoDob.Enabled = enable;
        }
        #endregion
    }
}
