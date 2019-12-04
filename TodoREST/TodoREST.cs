﻿using System.Collections.Generic;
using TodoREST.Data;
using TodoREST.Models;
using TodoREST.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TodoREST
{
	public class App : Application
	{
		public static TodoItemManager TodoManager { get; private set; }


        public static bool isLoggedIn = false;

        public static string BrugernavnOnLogIn;

        public static string Token;

        public static Player player;

        public static QueueModstander modstander;
        public static Game game;

        public static List<WebsocketData> BeerBongData;

        public static string gameresultat;
        

        public App ()
		{
			TodoManager = new TodoItemManager (new RestService (), new RestServicePlayer());
            
			MainPage = new NavigationPage (new Forside ());
		}

        

		protected override void OnStart ()
        {
            
        }

		protected override void OnSleep ()
		{
			
		}

		protected override void OnResume ()
		{
			
		}
	}
}
