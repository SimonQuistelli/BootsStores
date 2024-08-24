using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Boots_Stores
{
    public partial class MainPage : ContentPage
    {
        private Stores_VM _Stores;
        public MainPage()
        {
            _Stores = new Stores_VM();
            InitializeComponent();
            lab_StoreNumber.BindingContext = _Stores;
            lab_StoreName.BindingContext = _Stores;
            btn_ShowStore.Clicked += BTN_ShowStore_Clicked;
            btn_Next.Clicked += BTN_Next_Clicked;
        }

        private void BTN_ShowStore_Clicked(object sender, EventArgs e)
        {
            _Stores.ShowStore();
        }

        private void BTN_Next_Clicked(object sender, EventArgs e)
        {
            _Stores.NextStore();
        }
    }
}
