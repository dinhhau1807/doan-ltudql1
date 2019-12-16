using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1
{
    public class SqlHelper
    {
        SqlConnection connection;
        public string ServerName { get; set; }
        public string DatabaseName { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public SqlHelper(string connectionString)
        {
            connection = new SqlConnection(connectionString);
            var instance = connectionString.Split(';');
            for (int i = 0; i < instance.Length; i++)
            {
                if (instance[i].Contains("Data Source"))
                {
                    ServerName = instance[i].Split('=')[1];
                }
                if (instance[i].Contains("Initial Catalog"))
                {
                    DatabaseName = instance[i].Split('=')[1];
                }
                if (instance[i].Contains("User ID"))
                {
                    Username = instance[i].Split('=')[1];
                }
                if (instance[i].Contains("Password"))
                {
                    Password = instance[i].Split('=')[1];
                }
            }
        }

        public bool IsConnection
        {
            get
            {
                try
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static string GetConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["DoAnLTUDQL1.Properties.Settings.QLThiTracNghiemConnectionString"].ConnectionString;
            }
        }
    }
}
