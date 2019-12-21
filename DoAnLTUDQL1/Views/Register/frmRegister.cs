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
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = false;
        }

        private void AddValidators()
        {
            var required1 = new RequiedInputValidator
            {
                ErrorMessage = "Bạn phải nhập tên người dùng!",
                ControlToValidate = mTxtUsername
            };

            var required2 = new RequiedInputValidator
            {
                ErrorMessage = "Bạn phải nhập mật khẩu!",
                ControlToValidate = mTxtPassword
            };

            var required3 = new RequiedInputValidator
            {
                ErrorMessage = "Bạn phải nhập lại mật khẩu!",
                ControlToValidate = mTxtConfirmPassword
            };

            var required4 = new RequiedInputValidator
            {
                ErrorMessage = "Bạn phải số điện thoại!",
                ControlToValidate = mTxtPhone
            };

            var required5 = new RequiedInputValidator
            {
                ErrorMessage = "Bạn phải nhập tên!",
                ControlToValidate = mTxtFirstName
            };

            var required6 = new RequiedInputValidator
            {
                ErrorMessage = "Bạn phải họ và tên đệm!",
                ControlToValidate = mTxtLastName
            };
        }

        private void MBtnRegister_Click(object sender, EventArgs e)
        {
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
                if (value == "Success")
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
