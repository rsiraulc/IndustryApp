using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using IndustryApp.Code.Database;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using Xamarin.Forms;

[assembly: Dependency(typeof(IndustryApp.Droid.Config))]
namespace IndustryApp.Droid
{
    class Config : IConfig
    {
        private string directorioBD;
        private ISQLitePlatform plataforma;

        public string DirectorioBD
        {
            get
            {
                if (string.IsNullOrEmpty(directorioBD))
                    directorioBD = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

                return directorioBD;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get { return plataforma ?? (plataforma = new SQLitePlatformAndroid()); }
        }
    }
}