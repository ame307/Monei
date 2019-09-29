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
using monei_project.Views;

namespace monei_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public LoginView loginview = new LoginView();
        public RegistrationView registrationview = new RegistrationView();
        public RegistrationView2 registrationview2 = new RegistrationView2();
        public MainView fokepernyo = new MainView();
        public ForgottenPwdView1 elfelejtett1 = new ForgottenPwdView1();
        public ForgottenPwdView2 elfelejtett2 = new ForgottenPwdView2();
        public ForgottenPwdView3 elfelejtett3 = new ForgottenPwdView3();
        public ForgottenPwdView4 elfelejtett4 = new ForgottenPwdView4();

        public MainWindow()
        {
            InitializeComponent();
            maingrid.Children.Add(loginview);

            LoginView.Bejelentkezes += new EventHandler(LoginView_Bejelentkezes);
            LoginView.Regisztracio += new EventHandler(LoginView_Regisztracio);
            LoginView.Elfelejtett += new EventHandler(LoginView_Elfelejtett);

            RegistrationView.Regisztracio += new EventHandler(RegistrationView_Regisztracio);
            RegistrationView.Vissza += new EventHandler(Vissza);

            RegistrationView2.Vissza += new EventHandler(Vissza);

            ForgottenPwdView1.Vissza += new EventHandler(Vissza);
            ForgottenPwdView1.Biztonsagi += new EventHandler(ForgottenPwdView1_Biztonsagi);

            ForgottenPwdView2.Kuldes += new EventHandler(ForgottenPwdView2_Kuldes);
            ForgottenPwdView2.Vissza += new EventHandler(Vissza);

            ForgottenPwdView3.Beallitas += new EventHandler(ForgottenPwdView3_Beallitas);
            ForgottenPwdView3.Vissza += new EventHandler(Vissza);

            ForgottenPwdView4.Vissza += new EventHandler(Vissza);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        void LoginView_Bejelentkezes(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(fokepernyo);
        }

        void LoginView_Regisztracio(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(registrationview);
        }

        void LoginView_Elfelejtett(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(elfelejtett1);
        }

        void RegistrationView_Regisztracio(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(registrationview2);
        }

        void Vissza(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(loginview);
        }

        void ForgottenPwdView1_Biztonsagi(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(elfelejtett2);
        }

        void ForgottenPwdView2_Kuldes(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(elfelejtett3);
        }

        void ForgottenPwdView3_Beallitas(object sender, EventArgs e)
        {
            maingrid.Children.Clear();
            maingrid.Children.Add(elfelejtett4);
        }


}
}
