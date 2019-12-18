using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.Login
{
    public interface ILoginView
    {
        string Username { get; }
        string Password { get; }
        string Message { get; set; }
        string CheckConnectionMessage { set; }
        object User { get; set;  }

        event EventHandler Login;
        event EventHandler CheckConnection;
    }
}
