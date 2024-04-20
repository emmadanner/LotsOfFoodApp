using System;
using todo_dannerec.Models;
using Xamarin.Forms;

namespace todo_dannerec.Views
{
    public partial class TodoItemPage : ContentPage
    {
        public TodoItemPage()
        {
            InitializeComponent();
        }
        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            // TodoItemDatabase database = await TodoItemDatabase.Instance;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }
        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            //TodoItemDatabase database = await TodoItemDatabase.Instance;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }
        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
