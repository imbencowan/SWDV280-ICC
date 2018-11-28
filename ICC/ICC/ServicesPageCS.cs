using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace ICC
{
    public class ServicesPageCS : ContentPage
    {
        public ServicesPageCS()
        {
            Title = "Services";
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "This is the Services Page",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}
