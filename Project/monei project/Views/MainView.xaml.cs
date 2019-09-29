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
    /// Interaction logic for fokepernyo.xaml
    /// </summary>
    public partial class MainView : UserControl
    {
        public MainJobbSavView mainJobbSavView = new MainJobbSavView();
        public MainBalSavView mainBalSavView = new MainBalSavView();
        public MainKozepsoView mainKozepsoView = new MainKozepsoView();
        public MainFelsoView mainFelsoView = new MainFelsoView();
        public MainUserSettings mainUserSetting = new MainUserSettings();

        public MainView()
        {
            InitializeComponent();

            jobbresz.Children.Add(mainJobbSavView);
            balresz.Children.Add(mainBalSavView);
            kozepsoresz.Children.Add(mainKozepsoView);
            felsoresz.Children.Add(mainFelsoView);
            MainBalSavView.felhasznalonev += new EventHandler(MainBalSavfelhasznalonev);
        }

        void MainBalSavfelhasznalonev(object sender, EventArgs e)
        {
            mainUserSetting = new MainUserSettings();
            mainUserSetting.ShowDialog();
        }
    }
}
