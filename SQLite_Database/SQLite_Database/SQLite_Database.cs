using System;

using Xamarin.Forms;

namespace SQLite_Database
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage (new SQLite_Database.MainPage ()) {
				BarTextColor=Color.White, BarBackgroundColor=Color.FromHex("63ad72")
				
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

