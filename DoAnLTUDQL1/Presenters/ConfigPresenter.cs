using DoAnLTUDQL1.Views.Config;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Presenters
{
    public class ConfigPresenter
    {
        IConfigView view;

        public ConfigPresenter(IConfigView configView)
        {
            view = configView;
            Initializer();
        }
        public void Initializer()
        {
            view.ConnectionString = SqlHelper.GetConnectionString;
            view.CheckConnection += CheckConnection;
            view.SaveConfig += SaveConfig;
        }

        private void SaveConfig(object sender, EventArgs e)
        {
            try
            {
                SqlHelper sqlHelper = new SqlHelper(view.ConnectionString);
                if (sqlHelper.IsConnection)
                {
                    var MyConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    MyConfig.ConnectionStrings.ConnectionStrings["DoAnLTUDQL1.Properties.Settings.QLThiTracNghiemConnectionString"].ConnectionString = view.ConnectionString;
                    MyConfig.ConnectionStrings.ConnectionStrings["DoAnLTUDQL1.Properties.Settings.QLThiTracNghiemConnectionString"].ProviderName = "System.Data.SqlClient";
                    MyConfig.Save(ConfigurationSaveMode.Modified);

                    view.SaveConfigMessage = "Succeed";
                }
                else
                {
                    view.CheckConnectionMessage = "Failed";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                view.CheckConnectionMessage = "Failed";
            }
        }

        private void CheckConnection(object sender, EventArgs e)
        {
            SqlHelper sqlHelper = new SqlHelper(view.ConnectionString);
            try
            {
                if (sqlHelper.IsConnection)
                {
                    view.CheckConnectionMessage = "Succeed";
                }
                else
                {
                    view.CheckConnectionMessage = "Failed";
                }
            }
            catch (Exception)
            {
                view.CheckConnectionMessage = "Failed";
            }
        }
    }
}
