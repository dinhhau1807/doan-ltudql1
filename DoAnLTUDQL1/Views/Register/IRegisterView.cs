using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.Register
{
    public interface IRegisterView
    {
        string Username { get; }
        string Password { get; }
        string Phone { get; }
        string FirstName { get; }
        string LastName { get; }
        DateTime Dob { get; }
        int RoleTypeId { get; }

        string Message { get; set; }

        IEnumerable<RoleType> RoleTypes { get; set; }

        event EventHandler Register;
    }
}
