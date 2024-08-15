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
        public MainPage()
        {
            InitializeComponent();
            BTN_ShowStore.Clicked += BTN_ShowStore_Clicked;
        }

        private void BTN_ShowStore_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
