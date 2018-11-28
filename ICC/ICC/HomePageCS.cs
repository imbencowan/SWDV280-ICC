using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ICC
{
    public class HomePageCS : ContentPage
    {
        public HomePageCS()
        {
            Title = "Home";
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "This is the Home Page",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}
