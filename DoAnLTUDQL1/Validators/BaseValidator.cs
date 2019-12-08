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

        public string Pattern { get; set; }
        public string ErrorMessage { get; set; }

        public Icon ErrorIcon
        {
            get { return errorProvider.Icon; }
            set { errorProvider.Icon = value; }
        }


        private Control _controlToValidate;
        public Control ControlToValidate
        {
            get { return _controlToValidate; }
            set
            {
                if (_controlToValidate != null && !DesignMode)
                {
                    _controlToValidate.Validating -= ControlToValidate_Validating;
                }
                _controlToValidate = value;
                if (_controlToValidate != null && !DesignMode)
                {
                    _controlToValidate.Validating += ControlToValidate_Validating;
                }
            }
        }

        public BaseValidator()
        {
            InitializeComponent();
        }

        public BaseValidator(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void ControlToValidate_Validating(object sender, CancelEventArgs e)
        {
            if (!Validate())
            {
                e.Cancel = true;
                errorProvider.SetError(ControlToValidate, ErrorMessage);
            }
            else
            {
                errorProvider.SetError(ControlToValidate, "");
            }
        }

        public abstract bool Validate();
    }
}
