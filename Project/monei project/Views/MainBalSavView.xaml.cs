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

namespace monei_project
{
    /// <summary>
    /// Interaction logic for MainBalSavView.xaml
    /// </summary>
    public partial class MainBalSavView : UserControl
    {
        public MainBalSavView()
        {
            InitializeComponent();
        }

        private void tb_Sajat_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        public static event EventHandler felhasznalonev;
        private void lblFelhasznaloNev_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (felhasznalonev != null)
            {
                felhasznalonev(this, e);
            }
        }

        public static event EventHandler megosztott;
        private void tb_Megosztott_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (megosztott != null)
            {
                megosztott(this, e);
            }
        }

        private void rect_megosztott_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void rect_sajat_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void rect_sajat_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
