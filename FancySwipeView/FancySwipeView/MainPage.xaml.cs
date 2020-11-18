using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FancySwipeView
{
    public partial class MainPage : ContentPage
    {
        List<string> Items;
        public MainPage()
        {
            Items = new List<string>();
            Items.Add("asf");
            Items.Add("asf");
            Items.Add("asf");
            InitializeComponent();
            CollectionView.ItemsSource = Items;
        }
    }
}
