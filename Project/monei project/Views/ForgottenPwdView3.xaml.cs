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
    /// Interaction logic for Elfelejtett3View.xaml
    /// </summary>
    public partial class ForgottenPwdView3 : UserControl
    {
        public ForgottenPwdView3()
        {
            InitializeComponent();
        }

        public static bool _hasValidationError = true;
        public static bool HasValidationError
        {
            get { return _hasValidationError; }
            set { _hasValidationError = value; }
        }

        public static event EventHandler Beallitas;
        public static event EventHandler Vissza;

        private void beallitas(object sender, RoutedEventArgs e)
        {
            pwdPassword.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            pwdPasswordConformation.GetBindingExpression(TextBox.TextProperty).UpdateSource();


            if (!pwdPassword.GetBindingExpression(TextBox.TextProperty).HasValidationError &&
                !pwdPasswordConformation.GetBindingExpression(TextBox.TextProperty).HasValidationError)
            {
                HasValidationError = true;
                if (Beallitas != null)
                {
                    Beallitas(this, e);
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
