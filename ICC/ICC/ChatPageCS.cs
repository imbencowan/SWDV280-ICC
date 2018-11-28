using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace ICC
{
    public class ChatPageCS : ContentPage
    {
        public ChatPageCS()
        {
            Title = "Chat";
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        Text = "This is the Chat Page",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}
