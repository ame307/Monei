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
    /// Interaction logic for Elfelejtett2View.xaml
    /// </summary>
    public partial class ForgottenPwdView2 : UserControl
    {
        public ForgottenPwdView2()
        {
            InitializeComponent();
        }
        public static event EventHandler Kuldes;
        public static event EventHandler Vissza;

        private void back(object sender, RoutedEventArgs e)
        {
            if (Vissza != null)
            {
                Vissza(this, e);
            }
        }

        private void kuldes(object sender, RoutedEventArgs e)
        {
            if (Kuldes != null)
            {
                Kuldes(this, e);
            }
        }
    }
}
