using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace monei_project.Rules
{
    public class CantBeNullIndexRule : ValidationRule
    {
        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int index = int.Parse(value.ToString());
            if (index == -1)
            {
                return new ValidationResult(false, this.ErrorMessage);
            }
            else
            return new ValidationResult(true, null);

        }
    }
}
