using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.ViewModels
{
    public class AdminViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _username;
        private string _password;
        private string _firstName;
        private string _lastName;
        private DateTime? _dob;
        private string _phone;
        private DateTime? _createdDate;
        private bool? _status;
        private DateTime? _lastLoginDate;
        private int? _roleTypeId;
        private string _roleName;

        public string Username
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public DateTime? Dob
        {
            get
            {
                return _dob;
            }

            set
            {
                _dob = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        public DateTime? CreatedDate
        {
            get
            {
                return _createdDate;
            }

            set
            {
                _createdDate = value;
                OnPropertyChanged();
            }
        }

        public bool? Status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
                OnPropertyChanged();
            }
        }

        public DateTime? LastLoginDate
        {
            get
            {
                return _lastLoginDate;
            }

            set
            {
                _lastLoginDate = value;
                OnPropertyChanged();
            }
        }

        public int? RoleTypeId
        {
            get
            {
                return _roleTypeId;
            }

            set
            {
                _roleTypeId = value;
                OnPropertyChanged();
            }
        }

        public string RoleName
        {
            get
            {
                return _roleName;
            }

            set
            {
                _roleName = value;
                OnPropertyChanged();
            }
        }
    }
}
