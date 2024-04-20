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
