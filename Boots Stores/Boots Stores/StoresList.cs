using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boots_Stores
{
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
            Stores.Add(new Store(245, "Gloucester Rd"));
            Stores.Add(new Store(255, "Yate"));
            Stores.Add(new Store(261, "Stroud"));
            Stores.Add(new Store(267, "Frome"));
            Stores.Add(new Store(276, "Hereford"));
            Stores.Add(new Store(280, "Swansea The Quadrant"));
            Stores.Add(new Store(286, "Pontypridd"));
            Stores.Add(new Store(291, "Port Taybot"));
            Stores.Add(new Store(295, "Barry"));
            Stores.Add(new Store(296, "Bridgend"));
            Stores.Add(new Store(371, "Wells"));
            Stores.Add(new Store(451, "Chepstow"));
            Stores.Add(new Store(494, "Cardiff Whichchurch"));
            Stores.Add(new Store(1035, "Bradly Stoke"));
            Stores.Add(new Store(2011, "Bath Southgate"));
            Stores.Add(new Store(2019, "Caerphilly"));
            Stores.Add(new Store(2057, "Cardiff Hospital"));
            Stores.Add(new Store(2074, "Brecon"));
            Stores.Add(new Store(2089, "Cribbs Causeway"));
            Stores.Add(new Store(2105, "Tredeger"));
            Stores.Add(new Store(2112, "Clevdon"));
            Stores.Add(new Store(2255, "Bristol Airport"));
            Stores.Add(new Store(6424, "Emerson Green"));
            Stores.Add(new Store(6547, "Llantrisant"));
            Stores.Add(new Store(6565, "Bristol Eastgate"));
            Stores.Add(new Store(6588, "Merthyr tydfil"));
            Stores.Add(new Store(6705, "Evesham"));
        }

        public Store GetRandomStore()
        {
            Random rnd = new Random();

            int store = rnd.Next(0, Stores.Count - 1);

            return Stores[store];
        }
    }
}