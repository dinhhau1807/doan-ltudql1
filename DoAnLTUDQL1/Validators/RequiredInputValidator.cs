using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTUDQL1.Validators
{
    public partial class RequiedInputValidator : BaseValidator
    {
        public RequiedInputValidator()
        {
            ErrorMessage = "Bạn phải nhập dữ liệu vào trường này!";
        }

        public override bool Validate()
        {
            return ControlToValidate.Text.Length > 0;
        }
    }
}
