using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FancySwipeView
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> Items;
        public MainPage()
        {
            InitializeComponent();
            Items = new ObservableCollection<string>();
            CollectionView.ItemsSource = Items;
        }

        protected override void OnAppearing()
        {
            Items.Add("One");
            Items.Add("Two");
            Items.Add("Three");
            Items.Add("Four");

            base.OnAppearing();
        }
    }
}
