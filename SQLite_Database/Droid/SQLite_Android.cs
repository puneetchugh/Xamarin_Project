using System;
using System.IO;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_Database.Droid.SQLite_Android))]
namespace SQLite_Database.Droid
{
	public class SQLite_Android 
	{
		public SQLite_Android ()
		{
		}

		#region ISQLite implementation

		public SQLite.SQLiteConnection GetConnection(){
		
			var filename = "database.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var path = Path.Combine (documentsPath, filename);

			var connection = new SQLite.SQLiteConnection (path, true);

			return connection;
		}

		#endregion
	}
}

