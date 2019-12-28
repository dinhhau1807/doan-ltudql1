using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Views.StudentView
{
	public interface IStudentView
	{
		string StudentId { get; set; }
		string Message { get; set; }

		#region for Profile tab
		string FirstName { get; set; }
		string LastName { get; set; }
		string Phone { get; set; }
		DateTime? Dob { get; set; }
		DateTime? CreatedDate { get; set; }
		DateTime? LastLoginDate { get; set; }
		#endregion

		#region for change password tab
		string oldPassword { get; set; }
		string newPassword { get; set; }
		string reNewPassword { get; set; }
		#endregion

		IEnumerable<dynamic> ExamDetailList { get; set; } 
		IEnumerable<dynamic> ExamResultList { get; set; }
		dynamic TheLatestExamDetail { get; set; }

		#region events
		event Func<User> Logout;
		event Func<User> ChangePassword;
		event Func<bool> ChangeUserProfile;
		event EventHandler ExamDetailFilter;
		event EventHandler ExamResultFilter;
		event Func<int> StartExamination;
		#endregion
	}
}
