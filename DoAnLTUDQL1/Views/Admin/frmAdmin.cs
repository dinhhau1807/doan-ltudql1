using DoAnLTUDQL1.Presenters;
using DoAnLTUDQL1.Validators;
using DoAnLTUDQL1.ViewModels;
using DoAnLTUDQL1.Views.Login;
using MetroFramework.Controls;
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

namespace DoAnLTUDQL1.Views.Admin
{
    public partial class frmAdmin : MetroFramework.Forms.MetroForm, IAdminView
    {
        private AdminPresenter presenter;
        private BindingSource bs = new BindingSource();
        List<BaseValidator> EditUserValidatorList;
        List<BaseValidator> AddUserValidatorList;
        //import, export data
        RequiedInputValidator rqImportData, rqExportData;
        //restore, backup data
        RequiedInputValidator rqRestoreData, rqBackupData;

        public frmAdmin(User admin)
        {
            Admin = admin;
            InitializeComponent();
        }

        #region Events
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            presenter = new AdminPresenter(this);

            // Select first tabPage
            mTabCtrl.SelectTab(0);

            // Set data for mCbAddRoleType
            mCbAddRoleType.DataSource = RoleTypes;
            mCbAddRoleType.DisplayMember = "RoleName";
            mCbAddRoleType.ValueMember = "RoleTypeId";

            // Register event
            mTileListUser.Click += MTileListUser_Click;
            mTileAddUser.Click += MTileAddUser_Click;
            mTileImportExportUser.Click += MTileImportUser_Click;
            mTileLogout.Click += MTileLogout_Click;
            mTileBackupRestore.Click += MTileBackupRestore_Click;
            mTileConfig.Click += MTileConfig_Click;
            mTabCtrl.KeyDown += MTabCtrl_KeyDown;
            mGridListUser.CellMouseDown += MGridListUser_CellMouseDown;
            toolStripMenuItemEditUser.Click += ToolStripMenuItemEditUser_Click;
            mBtnListUserReload.Click += MBtnListUserReload_Click;
            mBtnEditCancel.Click += MBtnEditCancel_Click;
            mBtnEditSave.Click += MBtnEditSave_Click;
            mBtnAddCancel.Click += MBtnAddCancel_Click;
            mBtnAddUser.Click += MBtnAddUser_Click;
            mBtnImportChosePath.Click += MBtnImportChosePath_Click;
            mBtnImportUser.Click += MBtnImportUser_Click;
            mBtnExportChosePath.Click += MBtnExportChosePath_Click;
            mBtnExportUser.Click += MBtnExportUser_Click;
            mBtnRestoreChoosePath.Click += MBtnRestoreChoosePath_Click;
            mBtnRestore.Click += MBtnRestore_Click;
            mBtnBackupChoosePath.Click += MBtnBackupChoosePath_Click;
            mBtnBackup.Click += MBtnBackup_Click;
            mBtnConfigTestConnection.Click += MBtnConfigTestConnection_Click;
            mBtnConfigSaveConnectionString.Click += MBtnConfigSaveConnectionString_Click;

            EditUserValidatorList = new List<BaseValidator>();
            AddUserValidatorList = new List<BaseValidator>();

            RequiredValidatingControls();
            RegexValidatingControls();
        }

        private void MTabCtrl_KeyDown(object sender, KeyEventArgs e)
        {
            // Disable arrow keys change tab
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.Handled = true;
            }
        }

        private void MGridListUser_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == MouseButtons.Right)
            {
                DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                if (!c.Selected)
                {
                    c.DataGridView.ClearSelection();
                    c.DataGridView.CurrentCell = c;
                    c.Selected = true;
                }

                var mousePos = mGridListUser.PointToClient(Cursor.Position);
                mContextMenuListUser.Show(mGridListUser, mousePos);
            }
        }

        private void ToolStripMenuItemEditUser_Click(object sender, EventArgs e)
        {
            mTxtEditUsername.Focus();
            mTabCtrl.SelectTab(1);
        }

        private void MBtnEditSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(mTxtEditNewPassword.Text))
            {
                if(!mTxtEditNewPassword.Text.Equals(mTxtEditConfirmPassword.Text))
                {
                    MessageBox.Show("Nhập lại mật khẩu không chính xác!");
                    return;
                }
            }

            if (!EditUserValidatorList.All(a => a.IsValid))
            {
                var InvalidValidatingControl = EditUserValidatorList.First(f => !f.IsValid);
                InvalidValidatingControl.ControlToValidate.Focus();

                return;
            }

            UserEdit = new User
            {
                Username = mTxtEditUsername.Text,
                Password = mTxtEditNewPassword.Text,
                FirstName = mTxtEditFirstName.Text,
                LastName = mTxtEditLastName.Text,
                Dob = mDateTimeEditDob.Value,
                Phone = mTxtEditPhone.Text,
                Status = bool.Parse(mTxtEditStatus.Text)
            };

            mTxtEditNewPassword.ResetText();
            mTxtEditConfirmPassword.ResetText();

            SaveEdit?.Invoke(this, null);
            mTabCtrl.SelectTab(0);
        }

        private void MBtnEditCancel_Click(object sender, EventArgs e)
        {
            mTxtEditNewPassword.ResetText();
            mTxtEditConfirmPassword.ResetText();

            mTabCtrl.SelectTab(0);
            mBtnListUserReload.PerformClick();
        }

        private void MBtnListUserReload_Click(object sender, EventArgs e)
        {
            if (Reload != null)
            {
                Reload(this, null);
                bs.DataSource = Users;
            }
        }

        private void MBtnAddUser_Click(object sender, EventArgs e)
        {
            if (!mTxtAddPassword.Text.Equals(mTxtAddConfirmPassword.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác!");
                return;
            }

            if (!AddUserValidatorList.All(a => a.IsValid))
            {
                var InvalidValidatingControl = AddUserValidatorList.First(f => !f.IsValid);
                InvalidValidatingControl.ControlToValidate.Focus();

                return;
            }

            UserAdd = new User
            {
                Username = mTxtAddUsername.Text,
                Password = mTxtAddPassword.Text,
                FirstName = mTxtAddFirstName.Text,
                LastName = mTxtAddLastName.Text,
                Dob = mDateTimeAddDob.Value,
                Phone = mTxtAddPhone.Text,
                Status = true,
                RoleTypeId = (int)mCbAddRoleType.SelectedValue
            };

            AddUser?.Invoke(this, null);

            Reload?.Invoke(this, null);
        }

        private void MBtnAddCancel_Click(object sender, EventArgs e)
        {
            mTxtAddUsername.ResetText();
            mTxtAddPassword.ResetText();
            mTxtAddConfirmPassword.ResetText();
            mTxtAddFirstName.ResetText();
            mTxtAddLastName.ResetText();
            mTxtAddPhone.ResetText();
            mCbAddRoleType.SelectedIndex = 0;
            mDateTimeAddDob.Value = DateTime.Now;
        }

        private void MBtnImportChosePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Chọn file danh sách người dùng",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            DialogResult result = STAShowDialog(openFileDialog);
            if (result == DialogResult.OK)
            {
                mTxtImportPath.Text = openFileDialog.FileName;
                mTxtImportPath.Focus();
            }
        }

        private void MBtnImportUser_Click(object sender, EventArgs e)
        {
            if(!rqImportData.IsValid)
            {
                rqImportData.ControlToValidate.Focus();

                return;
            }

            try
            {
                Path = mTxtImportPath.Text;
                ImportUser?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi nhập dữ liệu: " + ex.Message);
            }
        }

        private void MBtnExportChosePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            DialogResult result = STAShowDialog(folderBrowserDialog);
            if (result == DialogResult.OK)
            {
                mTxtExportPath.Text = folderBrowserDialog.SelectedPath;
                mTxtExportPath.Focus();
            }
        }

        private void MBtnExportUser_Click(object sender, EventArgs e)
        {
            if (!rqExportData.IsValid)
            {
                rqExportData.ControlToValidate.Focus();

                return;
            }

            try
            {
                Path = mTxtExportPath.Text;
                ExportUser?.Invoke(this, null);
                mTxtExportPath.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xuất dữ liệu: " + ex.Message);
            }

		}

		private void MBtnRestore_Click(object sender, EventArgs e)
        {
            if (!rqRestoreData.IsValid)
            {
                rqRestoreData.ControlToValidate.Focus();

                return;
            }

            try
            {
                Path = mTxtRestorePath.Text;
                RestoreData?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi phục hồi dữ liệu: " + ex.Message);
            }
        }

        private void MBtnRestoreChoosePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Chọn file phục hồi dữ liệu",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "bak",
                Filter = "Backup files (*.bak)|*.bak",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            DialogResult result = STAShowDialog(openFileDialog);
            if (result == DialogResult.OK)
            {
                mTxtRestorePath.Text = openFileDialog.FileName;
                mTxtRestorePath.Focus();
            }
        }

        private void MBtnBackup_Click(object sender, EventArgs e)
        {           
            if (!rqBackupData.IsValid)
            {
                rqBackupData.ControlToValidate.Focus();

                return;
            }

            try
            {
                Path = mTxtBackupPath.Text;
                BackupData?.Invoke(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi sao lưu dữ liệu: " + ex.Message);
            }
        }

        private void MBtnBackupChoosePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            DialogResult result = STAShowDialog(folderBrowserDialog);
            if (result == DialogResult.OK)
            {
                mTxtBackupPath.Text = folderBrowserDialog.SelectedPath;
                mTxtBackupPath.Focus();
            }
        }

        private void MBtnConfigTestConnection_Click(object sender, EventArgs e)
        {
            ConnectionString = mTxtConfigConnectionString.Text;
            CheckConnection?.Invoke(this, null);
        }

        private void MBtnConfigSaveConnectionString_Click(object sender, EventArgs e)
        {
            ConnectionString = mTxtConfigConnectionString.Text;
            SaveConfig?.Invoke(this, null);
        }
        #endregion

        #region Event control tabPage
        private void MTileListUser_Click(object sender, EventArgs e)
        {
            mTabCtrl.SelectTab(0);
        }

        private void MTileAddUser_Click(object sender, EventArgs e)
        {
            mTabCtrl.SelectTab(2);
        }

        private void MTileImportUser_Click(object sender, EventArgs e)
        {
            mTabCtrl.SelectTab(3);
        }

        private void MTileBackupRestore_Click(object sender, EventArgs e)
        {
            mTabCtrl.SelectTab(4);
        }

        private void MTileConfig_Click(object sender, EventArgs e)
        {
            mTabCtrl.SelectTab(5);
        }

        private void MTileLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();

                Thread tRegister = new Thread(_ =>
                {
                    Application.Run(new frmLogin());
                });
                tRegister.Start();

                this.Close();
            }
        }
        #endregion

        #region IAdminView implementations
        public event EventHandler SaveEdit;
        public event EventHandler Reload;
        public event EventHandler AddUser;
        public event EventHandler ImportUser;
        public event EventHandler ExportUser;
        public event EventHandler SaveConfig;
        public event EventHandler CheckConnection;
        public event EventHandler RestoreData;
        public event EventHandler BackupData;

        public User Admin { get; set; }

        private IList<AdminViewModel> _users;
        public IList<AdminViewModel> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                if(_users != null)
                {
                    // Set data for mGridListUser
                    bs.DataSource = Users;
                    mGridListUser.DataSource = bs;
                    SetHeaderDataGridView();
                    SetDataBinding();
                }
            }
        }

        public IEnumerable<RoleType> RoleTypes { get; set; }

        public User UserEdit { get; set; }
        public User UserAdd { get; set; }

        private string _addMessage;
        public string AddMessage
        {
            get { return _addMessage; }
            set
            {
                _addMessage = value;

                if (value.Contains("Success"))
                {
                    mBtnAddCancel.PerformClick();
                }
            }
        }

        public string Path { get; set; }

        private string _importMessage;
        public string ImportMessage
        {
            get { return _importMessage; }
            set
            {
                _importMessage = value;
                mTxtImportPath.ResetText();

                if (value.Contains("Success"))
                {
                    MessageBox.Show("Đã thêm người dùng vào!");
                }

                if (value.Contains("File not exists"))
                {
                    MessageBox.Show("File này không tồn tại!");
                }
            }
        }

        private string _exportMessage;
        public string ExportMessage
        {
            get { return _exportMessage; }
            set
            {
                _exportMessage = value;
                mTxtExportPath.ResetText();

                if (value.Contains("Success"))
                {
                    MessageBox.Show("Đã xuất danh sách người dùng!");
                }

                if (value.Contains("Failed"))
                {
                    MessageBox.Show("Xuất file thất bại!");
                }
            }
        }

        private string _connectionString;
        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                _connectionString = value;
                mTxtConfigConnectionString.Text = value;
            }
        }

        public string CheckConnectionMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Kết nối thành công!");
                }
                else
                {
                    MessageBox.Show("Kết nối thất bại!");
                }
            }
        }

        public string SaveConfigMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã lưu cài đặt, chương trình sẽ khởi động lại để thực hiện các thay đổi!", "Lưu thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Lưu thất bại!");
                }
            }
        }

        public string RestoreMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã phục hồi dữ liệu!", "Phục hồi thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Phục hồi thất bại!");
                }
            }
        }

        public string BackupMessage
        {
            set
            {
                if (value == "Succeed")
                {
                    MessageBox.Show("Đã sao lưu dữ liệu!", "Sao lưu thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Sao lưu thất bại!");
                }
            }
        }
        #endregion

        #region Utilities
        void RequiredValidatingControls()
        {
            //edit, add user vars
            RequiedInputValidator rqEditFirstName, rqEditLastName, rqEditPhone, rqEditStatus,
                rqAddUserName, rqAddPassword, rqAddFirstName, rqAddLastName, rqAddPhone;

            #region edit, add user
            rqEditFirstName = new RequiedInputValidator();
            rqEditLastName = new RequiedInputValidator();
            rqEditPhone = new RequiedInputValidator();
            rqEditStatus = new RequiedInputValidator();

            rqAddUserName = new RequiedInputValidator();
            rqAddPassword = new RequiedInputValidator();
            rqAddFirstName = new RequiedInputValidator();
            rqAddLastName = new RequiedInputValidator();
            rqAddPhone = new RequiedInputValidator();

            rqEditFirstName.ControlToValidate = mTxtEditFirstName;
            rqEditLastName.ControlToValidate = mTxtEditLastName;
            rqEditPhone.ControlToValidate = mTxtEditPhone;
            rqEditStatus.ControlToValidate = mTxtEditStatus;

            rqAddUserName.ControlToValidate = mTxtAddUsername;
            rqAddPassword.ControlToValidate = mTxtAddPassword;
            rqAddFirstName.ControlToValidate = mTxtAddFirstName;
            rqAddLastName.ControlToValidate = mTxtAddLastName;
            rqAddPhone.ControlToValidate = mTxtAddPhone;

            EditUserValidatorList.Add(rqEditFirstName);
            EditUserValidatorList.Add(rqEditLastName);
            EditUserValidatorList.Add(rqEditPhone);
            EditUserValidatorList.Add(rqEditStatus);

            AddUserValidatorList.Add(rqAddUserName);
            AddUserValidatorList.Add(rqAddPassword);
            AddUserValidatorList.Add(rqAddFirstName);
            AddUserValidatorList.Add(rqAddLastName);
            AddUserValidatorList.Add(rqAddPhone);

            //set default to false
            foreach (var item in AddUserValidatorList)
            {
                item.IsValid = false;
            }
            #endregion

            #region import, export data
            rqImportData = new RequiedInputValidator();
            rqExportData = new RequiedInputValidator();

            rqImportData.ControlToValidate = mTxtImportPath;
            rqExportData.ControlToValidate = mTxtExportPath;

            rqImportData.IsValid = false;
            rqExportData.IsValid = false;
            #endregion

            #region restore, backup data
            rqRestoreData = new RequiedInputValidator();
            rqBackupData = new RequiedInputValidator();

            rqRestoreData.ControlToValidate = mTxtRestorePath;
            rqBackupData.ControlToValidate = mTxtBackupPath;

            rqRestoreData.IsValid = false;
            rqBackupData.IsValid = false;
            #endregion

        }

        void RegexValidatingControls()
        {
            RegexValidator rgEditFirstName, rgEditLastName, rgEditPhone,
                rgAddUserName, rgAddPassword, rgAddLastName, rgAddFirstName, rgAddPhone;

            string errorMessageName = "Không được nhập số hoặc ký tự đặc biệt";
            string errorMessagePassword = "Chỉ gồm chữ và số, tối thiểu 3 ký tự";
            string errorMessageUserName = "Chỉ gồm chữ và số, tối thiểu 3 kí tự";
            string errorMessagePhone = "Chỉ chứa số và phải chứa từ 10 kí tự trở lên";            

            rgEditFirstName = new RegexValidator(RegexPattern.Name);
            rgEditFirstName.ErrorMessage = errorMessageName;
            rgEditLastName = new RegexValidator(RegexPattern.Name);
            rgEditLastName.ErrorMessage = errorMessageName;
            rgEditPhone = new RegexValidator(RegexPattern.Phone);
            rgEditPhone.ErrorMessage = errorMessagePhone;

            rgAddUserName = new RegexValidator(RegexPattern.UserName);
            rgAddUserName.ErrorMessage = errorMessageUserName;
            rgAddPassword = new RegexValidator(RegexPattern.Password);
            rgAddPassword.ErrorMessage = errorMessagePassword;
            rgAddLastName = new RegexValidator(RegexPattern.Name);
            rgAddLastName.ErrorMessage = errorMessageName;
            rgAddFirstName = new RegexValidator(RegexPattern.Name);
            rgAddFirstName.ErrorMessage = errorMessageName;
            rgAddPhone = new RegexValidator(RegexPattern.Phone);
            rgAddPhone.ErrorMessage = errorMessagePhone;

            rgEditFirstName.ControlToValidate = mTxtEditFirstName;
            rgEditLastName.ControlToValidate = mTxtEditLastName;
            rgEditPhone.ControlToValidate = mTxtEditPhone;

            rgAddUserName.ControlToValidate = mTxtAddUsername;
            rgAddPassword.ControlToValidate = mTxtAddPassword;
            rgAddLastName.ControlToValidate = mTxtAddLastName;
            rgAddFirstName.ControlToValidate = mTxtAddFirstName;
            rgAddPhone.ControlToValidate = mTxtAddPhone;

            EditUserValidatorList.Add(rgEditLastName);
            EditUserValidatorList.Add(rgEditFirstName);
            EditUserValidatorList.Add(rgEditPhone);

            AddUserValidatorList.Add(rgAddUserName);
            AddUserValidatorList.Add(rgAddPassword);
            AddUserValidatorList.Add(rgAddFirstName);
            AddUserValidatorList.Add(rgAddLastName);
            AddUserValidatorList.Add(rgAddPhone);
        }
		private void SetHeaderDataGridView()
        {
            mGridListUser.AutoGenerateColumns = false;

            mGridListUser.Columns[0].HeaderText = "Tên người dùng";
            mGridListUser.Columns[0].DataPropertyName = "Username";

            mGridListUser.Columns[1].Visible = false;

            mGridListUser.Columns[2].HeaderText = "Tên";
            mGridListUser.Columns[2].DataPropertyName = "FirstName";

            mGridListUser.Columns[3].HeaderText = "Họ";
            mGridListUser.Columns[3].DataPropertyName = "LastName";

            mGridListUser.Columns[4].HeaderText = "Ngày sinh";
            mGridListUser.Columns[4].DataPropertyName = "Dob";

            mGridListUser.Columns[5].HeaderText = "Số điện thoại";
            mGridListUser.Columns[5].DataPropertyName = "Phone";

            mGridListUser.Columns[6].HeaderText = "Ngày tạo";
            mGridListUser.Columns[6].DataPropertyName = "CreatedDate";

            mGridListUser.Columns[7].HeaderText = "Trạng thái";
            mGridListUser.Columns[7].DataPropertyName = "Status";

            mGridListUser.Columns[8].HeaderText = "Lần đăng nhập cuối";
            mGridListUser.Columns[8].DataPropertyName = "LastLoginDate";

            mGridListUser.Columns[9].Visible = false;

            mGridListUser.Columns[10].HeaderText = "Vai trò";
            mGridListUser.Columns[10].DataPropertyName = "RoleName";

            foreach (DataGridViewColumn col in mGridListUser.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void SetDataBinding()
        {
            mTxtEditUsername.DataBindings.Clear();
            mTxtEditFirstName.DataBindings.Clear();
            mTxtEditLastName.DataBindings.Clear();
            mDateTimeEditDob.DataBindings.Clear();
            mTxtEditPhone.DataBindings.Clear();
            mTxtEditCreatedDate.DataBindings.Clear();
            mTxtEditStatus.DataBindings.Clear();
            mTxtEditLastLoginDate.DataBindings.Clear();
            mTxtEditRoleName.DataBindings.Clear();

            // Data binding for tab EditUser
            mTxtEditUsername.DataBindings.Add("Text", bs, "Username");
            mTxtEditFirstName.DataBindings.Add("Text", bs, "FirstName");
            mTxtEditLastName.DataBindings.Add("Text", bs, "LastName");
            mDateTimeEditDob.DataBindings.Add("Value", bs, "Dob", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditPhone.DataBindings.Add("Text", bs, "Phone");
            mTxtEditCreatedDate.DataBindings.Add("Text", bs, "CreatedDate");
            mTxtEditStatus.DataBindings.Add("Text", bs, "Status", true, DataSourceUpdateMode.OnPropertyChanged);
            mTxtEditLastLoginDate.DataBindings.Add("Text", bs, "LastLoginDate");
            mTxtEditRoleName.DataBindings.Add("Text", bs, "RoleName");
        }

        private DialogResult STAShowDialog(FileDialog dialog)
        {
            DialogState state = new DialogState
            {
                fileDialog = dialog
            };
            System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowFileDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.Join();
            return state.result;
        }

        private DialogResult STAShowDialog(FolderBrowserDialog dialog)
        {
            DialogState state = new DialogState
            {
                folderDialog = dialog
            };
            System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowFolderDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.Join();
            return state.result;
        }
        #endregion
    }

    public class DialogState
    {
        public DialogResult result;
        public FileDialog fileDialog;
        public FolderBrowserDialog folderDialog;

        public void ThreadProcShowFileDialog()
        {
            result = fileDialog.ShowDialog();
        }

        public void ThreadProcShowFolderDialog()
        {
            result = folderDialog.ShowDialog();
        }
    }
}
