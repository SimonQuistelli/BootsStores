using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boots_Stores
{
    public class Store
    {
        public int StoreNumber { get; set; }

        public string StoreName { get; set; }

        public Store(int storeNumber, string storeName)
        {
            StoreNumber = storeNumber;
            StoreName = storeName;
        }
    }
    public class StoreList
    {
        private List<Store> Stores;

        public StoreList()
        {
            Stores = new List<Store>();
            LoadStores();
        }

        private void LoadStores()
        {
            Stores.Add(new Store(255, "Yate"));
            Stores.Add(new Store(2112, "Clevdon"));
        }

        public Store GetRandomStore()
        {
            Random rnd = new Random();

            int store = rnd.Next(0, Stores.Count - 1);

            return Stores[store];
        }
    }
}