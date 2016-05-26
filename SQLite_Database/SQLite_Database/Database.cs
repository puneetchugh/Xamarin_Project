using System;
using SQLite;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace SQLite_Database
{
	public class Database
	{
		private SQLiteConnection _connection;

		public Database ()
		{
			_connection = DependencyService.Get<ISQLite> ().GetConnection ();
			_connection.CreateTable<ToDoListItem> ();
		}

		public List<ToDoListItem> GetToDoItems(){

			return(from t in _connection.Table<ToDoListItem> ()
			       select t).ToList ();
		}

		public void AddToDoItem(ToDoListItem item){

			_connection.Insert (item);
		}

		public void AddToDoItems(List<ToDoListItem> items){
			foreach (var item in items)
				_connection.Insert (item);
		
		}
	}
}

