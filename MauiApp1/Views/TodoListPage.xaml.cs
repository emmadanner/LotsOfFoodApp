/* Unmerged change from project 'todo_dannerecCore (net8.0-ios)'
Before:
using System;
After:
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0)'
Before:
using System;
After:
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0-windows10.0.19041.0)'
Before:
using System;
After:
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0-ios)'
Before:
using 
After:
using
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0)'
Before:
using 
After:
using
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0-windows10.0.19041.0)'
Before:
using 
After:
using
*/
/* Unmerged change from project 'todo_dannerecCore (net8.0-ios)'
Before:
using todo_dannerec;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
After:
using todo_dannerec.Models;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0)'
Before:
using todo_dannerec;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
After:
using todo_dannerec.Models;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0-windows10.0.19041.0)'
Before:
using todo_dannerec;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
After:
using todo_dannerec.Models;
*/

namespace todo_dannerec.Views
{
    public partial class TodoListPage : ContentPage
    {
        public TodoListPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //TodoItemDatabase database = await TodoItemDatabase.Instance;
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }
        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoItemPage
            {
                BindingContext = new TodoItem()
            });
        }
        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TodoItemPage
                {
                    BindingContext = e.SelectedItem as TodoItem
                });
            }
        }
    }
}