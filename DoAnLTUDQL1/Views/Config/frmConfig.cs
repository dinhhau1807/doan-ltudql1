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

namespace DoAnLTUDQL1.Views.Config
{
    public partial class frmConfig : MetroFramework.Forms.MetroForm, IConfigView
    {
        ConfigPresenter presenter;

        public frmConfig()
        {
            InitializeComponent();
            Load += FrmConfig_Load;
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            presenter = new ConfigPresenter(this);

            // Register event
            mBtnConfigTestConnection.Click += MBtnConfigTestConnection_Click;
            mBtnConfigSaveConnectionString.Click += MBtnConfigSaveConnectionString_Click;
        }

        private void MBtnConfigSaveConnectionString_Click(object sender, EventArgs e)
        {
            ConnectionString = mTxtConfigConnectionString.Text;
            SaveConfig?.Invoke(this, null);
        }

        private void MBtnConfigTestConnection_Click(object sender, EventArgs e)
        {
            ConnectionString = mTxtConfigConnectionString.Text;
            CheckConnection?.Invoke(this, null);
        }


        #region IConfigView implementations
        public event EventHandler SaveConfig;
        public event EventHandler CheckConnection;

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
        #endregion
    }
}
