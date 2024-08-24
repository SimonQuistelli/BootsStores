using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Boots_Stores
{
    public class Stores_VM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _StoreName;
        private StoreList _StoreList;
        private Store _Store;

        public string StoreNumber
        {
            get { return _Store.StoreNumber.ToString(); }
        }

        public string StoreName
        {
            get { return _StoreName; }
        }

        public Stores_VM()
        {
            _StoreName = "";

            _StoreList = new StoreList();
            _Store = _StoreList.GetRandomStore();
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void ShowStore()
        {
            _StoreName = _Store.StoreName;
            OnPropertyChanged("StoreName");
        }

        public void NextStore()
        {
            _StoreName = "";
            _Store = _StoreList.GetRandomStore();
            OnPropertyChanged("StoreName");
        }
    }
}
