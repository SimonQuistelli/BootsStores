using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Boots_Stores
{
    public class Stores_VM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _StoreNumber;
        private string _StoreName;

        public string StoreNumber
        {
            get { return _StoreNumber.ToString(); }
        }

        public string StoreName
        {
            get { return _StoreName; }
        }

        public Stores_VM()
        {
            _StoreNumber = 2089;
            _StoreName = "";
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
