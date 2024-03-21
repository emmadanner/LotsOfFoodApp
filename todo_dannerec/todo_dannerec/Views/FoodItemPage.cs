using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotsOfFoodApp;
using LotsOfFoodApp.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LotsOfFoodApp.Models;

namespace LotsOfFoodApp.Views
{
    public partial class FoodItemPage : ContentPage
    {
        public FoodItemPage()
        {
            InitializeComponent();
        }
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (FoodItem)BindingContext;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }
        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var foodItem = (FoodItem)BindingContext;
            await App.Database.DeleteItemAsync(foodItem);
            await Navigation.PopAsync();
        }
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
