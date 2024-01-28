using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UchetMagazin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ToolbarItem tb = new ToolbarItem()
            {
                Text = "О программе",
                Order = ToolbarItemOrder.Secondary,
                Priority=0,
            };

            ToolbarItem tb1 = new ToolbarItem()
            {
                Text = "Помощь",
                Order = ToolbarItemOrder.Secondary,
                Priority = 1,
            };

            ToolbarItems.Add(tb);
            ToolbarItems.Add(tb1);


        }

        
        private async void ExpensesPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Expences());
        }
    }
}
