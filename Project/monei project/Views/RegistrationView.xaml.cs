using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace monei_project.Views
{
    /// <summary>
    /// Interaction logic for RegistrationView.xaml
    /// </summary>
    public partial class RegistrationView : UserControl
    {
        public RegistrationView()
        {
            InitializeComponent();
        }

        public static bool _hasValidationError = true;
        public static bool HasValidationError
        {
            get { return _hasValidationError; }
            set { _hasValidationError = value; }
        }

        public static event EventHandler Regisztracio;
        public static event EventHandler Vissza;

        private void register(object sender, RoutedEventArgs e)
        {
            txtUsername.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            pwdPassword.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            pwdPasswordConformation.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtLastName.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtForename.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txtAnswerToSecurityQuestion.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            if (!txtUsername.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
            !pwdPassword.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
            !pwdPasswordConformation.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
            !txtLastName.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
            !txtForename.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
            !txtAnswerToSecurityQuestion.GetBindingExpression(TextBox.TextProperty).HasValidationError)
            {
                HasValidationError = true;
                if (Regisztracio != null)
                {
                    Regisztracio(this, e);
                    HasValidationError = false;
                }
            }
        }

        private void back(object sender, RoutedEventArgs e)
        {
            if (Vissza != null)
            {
                Vissza(this, e);
            }
        }
    }
}
