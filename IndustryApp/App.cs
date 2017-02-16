using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IndustryApp.Pages;
using Xamarin.Forms;

namespace IndustryApp
{
    public class App : Application
    {
        public App()
        {

            // The root page of your application
            //    MainPage = Application.Current.Properties.ContainsKey("user") ? new NavigationPage(new Menu()) : new NavigationPage(new Bienvenido());
            MainPage = new NavigationPage(new Menu());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
