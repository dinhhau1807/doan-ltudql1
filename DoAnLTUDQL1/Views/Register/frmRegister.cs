using DoAnLTUDQL1.Presenters;
using DoAnLTUDQL1.Validators;
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

namespace DoAnLTUDQL1.Views.Register
{
    public partial class frmRegister : MetroFramework.Forms.MetroForm, IRegisterView
    {
        RegisterPresenter presenter;
        List<BaseValidator> registerValidatorList;

        public frmRegister()
        {
            InitializeComponent();
            mCbRoleType.DropDownStyle = ComboBoxStyle.DropDownList;
            Load += FrmRegister_Load;
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            // Add validators
            //AddValidators();

            presenter = new RegisterPresenter(this);

            // Set data for mCbRoleType
            mCbRoleType.DataSource = RoleTypes;
            mCbRoleType.DisplayMember = "RoleName";
            mCbRoleType.ValueMember = "RoleTypeId";

            mLLogin.Click += MLLogin_Click;
            mBtnRegister.Click += MBtnRegister_Click;

            registerValidatorList = new List<BaseValidator>();

            RequiredValidatingControls();
            RegexValidatingControls();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = false;
        }

        void RequiredValidatingControls()
        {
            RequiedInputValidator rqUserName, rqPassword, rqFirstName, rqLastName, rqPhone;

            rqUserName = new RequiedInputValidator();
            rqPassword = new RequiedInputValidator();
            rqFirstName = new RequiedInputValidator();
            rqLastName = new RequiedInputValidator();
            rqPhone = new RequiedInputValidator();

            rqUserName.ControlToValidate = mTxtUsername;
            rqPassword.ControlToValidate = mTxtPassword;
            rqFirstName.ControlToValidate = mTxtFirstName;
            rqLastName.ControlToValidate = mTxtLastName;
            rqPhone.ControlToValidate = mTxtPhone;

            registerValidatorList.Add(rqUserName);
            registerValidatorList.Add(rqPassword);
            registerValidatorList.Add(rqFirstName);
            registerValidatorList.Add(rqLastName);
            registerValidatorList.Add(rqPhone);

            //set default to false
            foreach (var item in registerValidatorList)
            {
                item.IsValid = false;
            }
        }

        void RegexValidatingControls()
        {
            RegexValidator rgUserName, rgPassword, rgFirstName, rgLastName, rgPhone;

            string errorMessageName = "Không được nhập số hoặc ký tự đặc biệt";
            string errorMessagePassword = "Chỉ gồm chữ và số, tối thiểu 3 ký tự";
            string errorMessageUserName = "Chỉ gồm chữ và số, tối thiểu 3 kí tự";
            string errorMessagePhone = "Chỉ chứa số và phải chứa từ 10 kí tự trở lên";

            rgUserName = new RegexValidator(RegexPattern.UserName);
            rgUserName.ErrorMessage = errorMessageUserName;
            rgPassword = new RegexValidator(RegexPattern.Password);
            rgPassword.ErrorMessage = errorMessagePassword;
            rgFirstName = new RegexValidator(RegexPattern.Name);
            rgFirstName.ErrorMessage = errorMessageName;
            rgLastName = new RegexValidator(RegexPattern.Name);
            rgLastName.ErrorMessage = errorMessageName;
            rgPhone = new RegexValidator(RegexPattern.Phone);
            rgPhone.ErrorMessage = errorMessagePhone;

            rgUserName.ControlToValidate = mTxtUsername;
            rgPassword.ControlToValidate = mTxtPassword;
            rgFirstName.ControlToValidate = mTxtFirstName;
            rgLastName.ControlToValidate = mTxtLastName;
            rgPhone.ControlToValidate = mTxtPhone;

            registerValidatorList.Add(rgUserName);
            registerValidatorList.Add(rgPassword);
            registerValidatorList.Add(rgFirstName);
            registerValidatorList.Add(rgLastName);
            registerValidatorList.Add(rgPhone);
        }

        private void MBtnRegister_Click(object sender, EventArgs e)
        {
            if (!registerValidatorList.All(a => a.IsValid))
            {
                var InvalidValidatingControl = registerValidatorList.First(f => !f.IsValid);
                InvalidValidatingControl.ControlToValidate.Focus();

                return;
            }

            if (!mTxtPassword.Text.Equals(mTxtConfirmPassword.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác!");
                return;
            }

            Register?.Invoke(this, null);
        }

        private void MLLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Thread tLogin = new Thread(_ =>
            {
                Application.Run(new frmLogin());
            });
            tLogin.Start();

            this.Close();
        }

        #region IRegisterView implementations
        public string Username { get { return mTxtUsername.Text; } }
        public string Password { get { return mTxtPassword.Text; } }
        public string Phone { get { return mTxtPhone.Text; } }
        public string FirstName { get { return mTxtFirstName.Text; } }
        public string LastName { get { return mTxtLastName.Text; } }
        public DateTime Dob { get { return mDtpDob.Value; } }
        public int RoleTypeId { get { return (int)mCbRoleType.SelectedValue; } }

        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                if (value == "Succeed")
                {
                    var result = MessageBox.Show("Đã đăng kí thành công!");
                    if (result == DialogResult.OK)
                    {
                        mLLogin.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng kí thất bại!");
                }
            }
        }

        public IEnumerable<RoleType> RoleTypes { get; set; }

        public event EventHandler Register;
        #endregion
    }
}
