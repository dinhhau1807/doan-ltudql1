using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAnLTUDQL1.Validators
{
	public class RegexValidator : BaseValidator
	{
		public string Pattern { get; set; }

		public RegexValidator(string pattern)
		{
			this.Pattern = pattern;
		}

		public override bool Validate()
		{
			var rg = new Regex(Pattern);
			return rg.IsMatch(ControlToValidate.Text);
		}
	}
}
