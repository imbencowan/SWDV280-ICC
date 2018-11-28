using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ICC
{
    public class EventsPageCS : ContentPage
    {
        public EventsPageCS()
        {
            Title = "Events";
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "This is the Events Page",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}
