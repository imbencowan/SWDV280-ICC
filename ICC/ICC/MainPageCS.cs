using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ICC
{
    public class MainPageCS : TabbedPage
    {
        public MainPageCS ()
        {
            Children.Add (new HomePageCS());
            Children.Add (new EventsPageCS());
            Children.Add (new ServicesPageCS());
            Children.Add (new ChatPageCS());
        }
    }
}
