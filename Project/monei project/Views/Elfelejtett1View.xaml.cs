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
    /// Interaction logic for Elfelejtett1View.xaml
    /// </summary>
    public partial class Elfelejtett1View : UserControl
    {
        public Elfelejtett1View()
        {
            InitializeComponent();
        }

        public static event EventHandler Biztonsagi;
        public static event EventHandler Vissza;

        private void back(object sender, RoutedEventArgs e)
        {
            if (Vissza != null)
            {
                Vissza(this, e);
            }
        }

        private void biztonsagi(object sender, RoutedEventArgs e)
        {
            if (Biztonsagi != null)
            {
                Biztonsagi(this, e);
            }
        }
    }
}
