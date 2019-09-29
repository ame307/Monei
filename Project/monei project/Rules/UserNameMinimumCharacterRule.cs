using System.Globalization;
using System.Windows.Controls;

namespace monei_project.Rules
{
    public class UserNameMinimumCharacterRule : ValidationRule
    {
        public int UserNameMinimumCharacter { get; set; }

        private string _errorMessage;

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;
            if(charString != null)
            {
                if (charString.Length < UserNameMinimumCharacter || charString.Length == 0)
                {
                    return new ValidationResult(false, ErrorMessage);
                }
                return new ValidationResult(true, null);
            }
            else
                return new ValidationResult(false, "Nem lehet Üres");
        }
    }
}
