using System;
using SQLite;

namespace SQLite_Database
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();

	}
}

