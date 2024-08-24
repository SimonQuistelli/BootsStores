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
            Stores.Add(new Store(243, "Broadmead"));
            Stores.Add(new Store(255, "Yate"));
            Stores.Add(new Store(296, "Bridgend"));
            Stores.Add(new Store(2057, "Cardiff Hospital"));
            Stores.Add(new Store(2089, "Cribbs Causeway"));
            Stores.Add(new Store(2112, "Clevdon"));
            Stores.Add(new Store(2255, "Bristol Airport"));
            Stores.Add(new Store(6424, "Emerson Green"));
        }

        public Store GetRandomStore()
        {
            Random rnd = new Random();

            int store = rnd.Next(0, Stores.Count - 1);

            return Stores[store];
        }
    }
}