using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace monei_project.ViewModels
{
    class MainFelsoViewModel : ViewModelBase
    {
        private string _balance = "11111$";
        public string Balance
        {
            get { return _balance; }
            set { SetAndRaisePropertyChanged(ref _balance, value); }
        }

        public void SetBalance()
        {
            Balance = "érték";
        }
    }
}
