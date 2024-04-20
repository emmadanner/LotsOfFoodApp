
/* Unmerged change from project 'todo_dannerecCore (net8.0-ios)'
Before:
using System;
using todo_dannerec.Data;
After:
using Microsoft.Maui;
using Microsoft.Data;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0)'
Before:
using System;
using todo_dannerec.Data;
After:
using Microsoft.Maui;
using Microsoft.Data;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0-windows10.0.19041.0)'
Before:
using System;
using todo_dannerec.Data;
After:
using Microsoft.Maui;
using Microsoft.Data;
*/
using
/* Unmerged change from project 'todo_dannerecCore (net8.0-ios)'
Before:
using System.IO;
After:
using System;
using System.IO;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0)'
Before:
using System.IO;
After:
using System;
using System.IO;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0-windows10.0.19041.0)'
Before:
using System.IO;
After:
using System;
using System.IO;
*/
todo_dannerec.Data;
/* Unmerged change from project 'todo_dannerecCore (net8.0-ios)'
Before:
using Microsoft.Maui.Controls;
using Microsoft.Maui;
After:
using todo_dannerec.Views;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0)'
Before:
using Microsoft.Maui.Controls;
using Microsoft.Maui;
After:
using todo_dannerec.Views;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0-windows10.0.19041.0)'
Before:
using Microsoft.Maui.Controls;
using Microsoft.Maui;
After:
using todo_dannerec.Views;
*/


namespace todo_dannerec
{
    public partial class App : Application
    {
        private static TodoItemDatabase database;
        internal static TodoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new TodoItemDatabase(Path.Combine(Environment.GetFolderPath
                    (Environment.SpecialFolder.LocalApplicationData), "TodoListItems.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new TodoListPage());
        }
        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}