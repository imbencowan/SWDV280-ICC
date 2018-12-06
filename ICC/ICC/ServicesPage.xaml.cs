using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICC
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ServicesPage : ContentPage
	{
		public ServicesPage ()
		{
			InitializeComponent ();
		}

        async void Relocation_Services(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContentPage());
        }

        async void Corporate_Events(object sender, EventArgs e)
        {

        }

        async void Errand_Running(object sender, EventArgs e)
        {

        }

        async void Temporary_Assisants(object sender, EventArgs e)
        {

        }

        async void AccommodationsBTN(object sender, EventArgs e)
        {

        }

        async void Business_Retreats(object sender, EventArgs e)
        {

        }
    }
}