using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FancySwipeView
{
    public partial class DetailsPage : ContentPage
    {
        public DetailsPage()
        {
            var shouldExit = false;
            InitializeComponent();
            Device.StartTimer(new TimeSpan(0, 0, 0, 0, 250), () =>
            {
                if (!shouldExit)
                {
                    swipeView2.Open(OpenSwipeItem.LeftItems);
                    shouldExit = true;
                    return true;
                }
                else
                {
                    swipeView2.Close();
                    return false;
                }
            });

        }
    }
}
