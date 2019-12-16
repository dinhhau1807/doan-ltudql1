using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.Config
{
    public interface IConfigView
    {
        string ConnectionString { get; set; }

        string CheckConnectionMessage { set; }
        string SaveConfigMessage { set; }

        event EventHandler SaveConfig;
        event EventHandler CheckConnection;
    }
}
