using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotsOfFoodApp.Data;
using LotsOfFoodApp;
using LotsOfFoodApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LotsOfFoodApp.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FoodItemPage
            {
                BindingContext = new FoodItem()
            });
        }
        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new FoodItemPage
                {
                    BindingContext = e.SelectedItem as FoodItem
                });
            }
        }
    }
}