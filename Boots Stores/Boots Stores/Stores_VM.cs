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
        private Queue<Store> _RecentStores;

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
            _RecentStores = new Queue<Store>();
            _RecentStores.Enqueue(_Store);
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
            bool RecentStore = false;
            _StoreName = "";
            _Store = _StoreList.GetRandomStore();

            RecentStore = _RecentStores.Contains(_Store);

            while (RecentStore)
            {
                _Store = _StoreList.GetRandomStore();
                RecentStore = _RecentStores.Contains(_Store);
            }

            if (_RecentStores.Count > 15)
                _RecentStores.Dequeue();

            _RecentStores.Enqueue(_Store);

            OnPropertyChanged("StoreNumber");
            OnPropertyChanged("StoreName");
        }
    }
}
