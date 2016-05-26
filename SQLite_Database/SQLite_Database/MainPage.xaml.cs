using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SQLite_Database
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();

			CheckDatabasePopulated ();
			listView.ItemsSource = GetToDoList ();
		}

		public async void OnItemSelected(object sender, SelectedItemChangedEventArgs eventArgs){
		
		}

		List<ToDoListItem> GetToDoList(){
			var items = new Database ().GetToDoItems ();
			return items;
		}
		void CheckDatabasePopulated(){
		
			if (new Database ().GetToDoItems ().Count < 1) {

				//fill up database with defaults
				var items = new List<ToDoListItem>();

				for (int i = 0; i < 10; i++) {
				
					items.Add(
					
						new ToDoListItem(){
							
								title = "Task" + (i+1).ToString(),
								content = "Description - Tap to edit",
							alpha = (1 - ((double)i/20)).ToString()
							}
									);
				}
				new Database ().AddToDoItems (items);
			}
		}
	}
}

