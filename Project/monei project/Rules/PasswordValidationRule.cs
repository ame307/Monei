using System.Globalization;
using System.Linq;
using System.Windows.Controls;

namespace monei_project.Rules
{
    public class PasswordValidationRule : ValidationRule
    {
        public int PasswordMinimumCharacter { get; set; }

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
                if (PasswordIsValid(charString))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, ErrorMessage);
            }
            else
                return new ValidationResult(false, "Nem lehet üres");
        }

        private bool PasswordIsValid(string charString)
        {
            return charString.Any(char.IsDigit) && !(charString.Length < PasswordMinimumCharacter || charString.Length == 0) && charString.Any(char.IsUpper);
        }
    }
}
