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
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public static bool _hasValidationError = true;
        public static bool HasValidationError
        {
            get { return _hasValidationError; }
            set { _hasValidationError = value; }
        }

        public static event EventHandler Bejelentkezes;
        public static event EventHandler Regisztracio;
        public static event EventHandler Elfelejtett;

        public void login(object sender, RoutedEventArgs e)
        {
            txtUsername.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            pwdPassword.GetBindingExpression(TextBox.TextProperty).UpdateSource();

            if (!pwdPassword.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !txtUsername.GetBindingExpression(TextBox.TextProperty).HasValidationError)
            {
                HasValidationError = true;
                if (Bejelentkezes != null)
                {
                    Bejelentkezes(this, e);
                    HasValidationError = false;
                }
            }

        }

        private void register(object sender, RoutedEventArgs e)
        {
            if (Regisztracio != null)
            {
                Regisztracio(this, e);
            }
        }

        private void forgotten(object sender, RoutedEventArgs e)
        {
            if (Elfelejtett != null)
            {
                Elfelejtett(this, e);
            }
        }

        private void txtUser_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
