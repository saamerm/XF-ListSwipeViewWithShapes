using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Plugin.SharedTransitions;
namespace FancySwipeView
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> Items;
        public MainPage()
        {
            InitializeComponent();
            //swipeView3.Open(OpenSwipeItem.LeftItems);
        }

        void Favorite_Invoked(object sender, EventArgs e)
        {
            DisplayAlert("Xamarin.Forms is my favorite too! <3", "Favorite", "Woohoo!");
        }

        void Delete_Invoked(object sender, EventArgs e)
        {
            DisplayAlert("Are you sure you want to delete Xamarin.Forms?", "Delete", "No");
        }

        async void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            // Comment below l
            //SharedTransitionNavigationPage.SetTransitionSelectedGroup(this, "1");
            await Navigation.PushAsync(new DetailsPage());
        }

    }
}
