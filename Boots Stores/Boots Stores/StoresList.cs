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
            Stores.Add(new Store(252, "Evesham Bridge St"));
            Stores.Add(new Store(254, "Gloucester Eastgate"));
            Stores.Add(new Store(255, "Yate"));
            Stores.Add(new Store(260, "Cheltenham High St"));
            Stores.Add(new Store(261, "Stroud"));
            Stores.Add(new Store(267, "Frome"));
            Stores.Add(new Store(276, "Hereford"));
            Stores.Add(new Store(280, "Quadrant"));
            Stores.Add(new Store(283, "Llanelli Vaughan St"));
            Stores.Add(new Store(285, "Aberdare"));
            Stores.Add(new Store(286, "Pontypridd"));
            Stores.Add(new Store(290, "Neath"));
            Stores.Add(new Store(291, "Port Talbot"));
            Stores.Add(new Store(292, "Newport Commercial"));
            Stores.Add(new Store(295, "Barry"));
            Stores.Add(new Store(296, "Bridgend"));
            Stores.Add(new Store(320, "Ebbw Vale"));
            Stores.Add(new Store(322, "Albany Rd"));
            Stores.Add(new Store(323, "Cardiff Queen St"));
            Stores.Add(new Store(326, "Tewkesbury"));
            Stores.Add(new Store(331, "Penarth"));
            Stores.Add(new Store(332, "Abergavenny"));
            Stores.Add(new Store(340, "Porthcawl"));
            Stores.Add(new Store(341, "Treorchy"));
            Stores.Add(new Store(342, "Blackwood"));
            Stores.Add(new Store(345, "Ludlow"));
            Stores.Add(new Store(350, "Neilsea"));
            Stores.Add(new Store(371, "Wells"));
            Stores.Add(new Store(394, "Cirenceter"));
            Stores.Add(new Store(399, "Chippenham"));
            Stores.Add(new Store(420, "Keynsham"));
            Stores.Add(new Store(432, "Ross-on-Wye"));
            Stores.Add(new Store(446, "Cliffton Down"));
            Stores.Add(new Store(451, "Chepstow"));
            Stores.Add(new Store(454, "St Augustines"));
            Stores.Add(new Store(455, "Llandrindod"));
            Stores.Add(new Store(468, "Tonypandy"));
            Stores.Add(new Store(469, "Abertillery"));
            Stores.Add(new Store(473, "Kingswood"));
            Stores.Add(new Store(489, "Henleaze"));
            Stores.Add(new Store(491, "Thornbury"));
            Stores.Add(new Store(494, "Whichchurch"));
            Stores.Add(new Store(512, "Bristol Queens Rd"));
            Stores.Add(new Store(843, "Ledbury"));
            Stores.Add(new Store(1035, "Bradly Stoke"));
            Stores.Add(new Store(1138, "Cardiff St Davis"));
            Stores.Add(new Store(2011, "Bath Southgate"));
            Stores.Add(new Store(2019, "Caerphilly"));
            Stores.Add(new Store(2023, "Cwmbran"));
            Stores.Add(new Store(2054, "Builth Wells"));
            Stores.Add(new Store(2057, "Hospital"));
            Stores.Add(new Store(2058, "Monmouth"));
            Stores.Add(new Store(2074, "Brecon"));
            Stores.Add(new Store(2089, "Cribbs Causeway"));
            Stores.Add(new Store(2103, "Bath Westgate"));
            Stores.Add(new Store(2105, "Tredeger"));
            Stores.Add(new Store(2156, "Broadcast House"));
            Stores.Add(new Store(2112, "Clevdon"));
            Stores.Add(new Store(2255, "Bristol Airport"));
            Stores.Add(new Store(6034, "Quedgeley RP"));
            Stores.Add(new Store(6386, "Trowbridge"));
            Stores.Add(new Store(6424, "Emerson Green"));
            Stores.Add(new Store(6476, "Spitty"));
            Stores.Add(new Store(6481, "Avonmeads"));
            Stores.Add(new Store(6507, "Chelthenhan Gallagher"));
            Stores.Add(new Store(6542, "Cardiff Ty Glas"));
            Stores.Add(new Store(6544, "Longwell Green"));
            Stores.Add(new Store(6546, "Malvern"));
            Stores.Add(new Store(6547, "Llantrisant"));
            Stores.Add(new Store(6554, "Shepton Mallet"));
            Stores.Add(new Store(6565, "Bristol Eastgate"));
            Stores.Add(new Store(6572, "Llanelli Parc Trostre"));
            Stores.Add(new Store(6575, "Morfa"));
            Stores.Add(new Store(6588, "Merthyr tydfil"));
            Stores.Add(new Store(6611, "Imperial RP"));
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