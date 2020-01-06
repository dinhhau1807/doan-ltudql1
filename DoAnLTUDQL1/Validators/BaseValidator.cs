using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTUDQL1.Validators
{
    public abstract partial class BaseValidator : Component
    {
        ErrorProvider errorProvider = new ErrorProvider();

        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }

        public Icon ErrorIcon
        {
            get { return errorProvider.Icon; }
            set { errorProvider.Icon = value; }
        }


        private Control controlToValidate;
        [TypeConverter(typeof(ReferenceConverter))]
        public Control ControlToValidate
        {
            get { return controlToValidate; }
            set
            {
                controlToValidate = value;
                if (controlToValidate != null && !DesignMode)
                {
                    controlToValidate.Validating += ControlToValidate_Validating;
                }
            }
        }

        public BaseValidator()
        {
            InitializeComponent();

            IsValid = true;
        }

        private void ControlToValidate_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate())
            {
                errorProvider.SetError(ControlToValidate, ErrorMessage);
                IsValid = false;
            }
            else
            {
                errorProvider.SetError(ControlToValidate, "");
                IsValid = true;
            }
        }

        public abstract bool Validate();
    }
}
