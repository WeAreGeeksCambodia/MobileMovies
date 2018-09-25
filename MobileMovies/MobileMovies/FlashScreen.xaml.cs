using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileMovies
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlashScreen : ContentPage
	{
		public FlashScreen ()
		{
			InitializeComponent ();

		}

       

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await imgFlash.ScaleTo(1, 2000);
            await imgFlash.ScaleTo(0.9, 1500);
            await imgFlash.ScaleTo(150, 1200);
            Application.Current.MainPage = new NavigationPage(new MasterDetailPage1());
        }
    }
}