using monei_project.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace monei_project.ViewModels
{
    class MainBalSavViewModel : ViewModelBase
    {
        private List<string> sajatszamlak = new List<string>{ "számla 1", "számla 2", "számla 3", "számla 4", "számla 5", };
        private List<string> labelList;
        public List<string> LabelList
        {
            get { return labelList; }
            set { labelList = value; }
        }

        private string _backGroundColor = "#287497";

        public string BackGroundColor
        {
            get { return _backGroundColor; }
            set { _backGroundColor = value; OnPropertyChanged("BackGroundColor"); }
        }

        ICommand _doBackGroundColor1;
        ICommand _doBackGroundColor2;

        public ICommand DoBackGroundColorMegosztott
        {
            get
            {
                if (_doBackGroundColor1 == null)
                {
                    _doBackGroundColor1 = new RelayCommand(CanDoBackGroundColor, DoBackGroundColorExecuteMegosztott);
                }
                return _doBackGroundColor1;
            }
        }

        public ICommand DoBackGroundColorSajat
        {
            get
            {
                if (_doBackGroundColor2 == null)
                {
                    _doBackGroundColor2 = new RelayCommand(CanDoBackGroundColor, DoBackGroundColorExecuteSajat);
                }
                return _doBackGroundColor2;
            }
        }

        private bool CanDoBackGroundColor(object obj)
        {
            return true;
        }

        private void DoBackGroundColorExecuteMegosztott(object obj)
        {
            BackGroundColor = "#52abbb";           
        }

        private void DoBackGroundColorExecuteSajat(object obj)
        {
            BackGroundColor = "#287497";
            LabelList = sajatszamlak;
        }

    }

}
