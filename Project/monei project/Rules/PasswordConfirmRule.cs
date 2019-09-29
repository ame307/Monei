using monei_project.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace monei_project.Rules
{
    class PasswordConfirmRule : ValidationRule
    {

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            string charString = value as string;
            
            if (charString != null)
            {
                if (charString.Equals(GetPassword()))
                {
                    return new ValidationResult(false, ErrorMessage);
                }
                return new ValidationResult(true, null);
            }
            else
                return new ValidationResult(false, "A jelszó nem egyezik");

        }

        private string GetPassword()
        {
            RegistrationViewModel rv = new RegistrationViewModel();
            return rv.Password;
        }
    }
}