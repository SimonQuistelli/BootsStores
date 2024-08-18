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
            lab_storeNumber.BindingContext = _Stores;
            btn_ShowStore.Clicked += BTN_ShowStore_Clicked;
        }

        private void BTN_ShowStore_Clicked(object sender, EventArgs e)
        {
            lab_StoreName.Text = "Cribbs Causeway";
        }
    }
}
