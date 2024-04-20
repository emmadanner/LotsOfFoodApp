
/* Unmerged change from project 'todo_dannerecCore (net8.0-ios)'
Before:
using System;
After:
using SQLite;
using System;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0)'
Before:
using System;
After:
using SQLite;
using System;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0-windows10.0.19041.0)'
Before:
using System;
After:
using SQLite;
using System;
*/
using
/* Unmerged change from project 'todo_dannerecCore (net8.0-ios)'
Before:
using System.Text;
using SQLite;
After:
using System.Text;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0)'
Before:
using System.Text;
using SQLite;
After:
using System.Text;
*/

/* Unmerged change from project 'todo_dannerecCore (net8.0-windows10.0.19041.0)'
Before:
using System.Text;
using SQLite;
After:
using System.Text;
*/
SQLite;

namespace todo_dannerec.Models
{
    internal class TodoItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
    }
}