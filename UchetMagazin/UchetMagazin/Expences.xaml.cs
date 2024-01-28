using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UchetMagazin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Expences : ContentPage
	{
		public Expences ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
           
        }
		
		/*private async void CreateFile(object sender, EventArgs e)
		{
			try
			{
                FileInfo file = new FileInfo(@"/storage/emulated/0/Android/some.txt");
                FileStream strem = file.Create();
                strem.Close();
                await DisplayAlert("Сообщение", "Данные успешно сохранены", "ОК");
				return;
            }
			catch (Exception ex)
			{
                await DisplayAlert("Сообщение", ex.ToString(), "ОК");
				return;
            }
			
		}*/



    }
}