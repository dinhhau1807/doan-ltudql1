using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnLTUDQL1
{
	public class RegexPattern
	{
		public static string UserName { get; } = @"^[a-zA-Z0-9]{2,}$";
		public static string Password { get; } = @"^[a-zA-z0-9]{2,}$";
		public static string Name { get; } = @"^[a-zA-Z\s]+$";
		public static string Phone { get; } = @"^[0-9]{10,}$";
	}
}
