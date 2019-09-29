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

namespace design_teszt.Views
{
    /// <summary>
    /// Interaction logic for Elfelejtett4View.xaml
    /// </summary>
    public partial class Elfelejtett4View : UserControl
    {
        public Elfelejtett4View()
        {
            InitializeComponent();
        }

        public static event EventHandler Vissza;

        private void vissza(object sender, RoutedEventArgs e)
        {
            if (Vissza != null)
            {
                Vissza(this, e);
            }
        }
    }
}
