using DoAnLTUDQL1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.Admin
{
    public interface IAdminView
    {
        IList<AdminViewModel> Users { get; set; }
        IEnumerable<RoleType> RoleTypes { get; set; }


        User UserEdit { get; set; }
        User UserAdd { get; set; }


        string Path { get; set; }
        string ConnectionString { get; set; }


        string AddMessage { get; set; }
        string ImportMessage { get; set; }
        string ExportMessage { get; set; }
        string CheckConnectionMessage { set; }
        string SaveConfigMessage { set; }
        string RestoreMessage {set; }
        string BackupMessage { set; }
         

        event EventHandler SaveEdit;
        event EventHandler Reload;
        event EventHandler AddUser;
        event EventHandler ImportUser;
        event EventHandler ExportUser;
        event EventHandler SaveConfig;
        event EventHandler CheckConnection;
        event EventHandler RestoreData;
        event EventHandler BackupData;
    }
}
