using System;
using System.IO;
using IndustryApp.Code.Database;
using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinIOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(IndustryApp.iOS.Config))]

namespace IndustryApp.iOS
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
                {
                    var directorio = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    directorioBD = Path.Combine(directorio, "..", "Library");
                }

                return directorioBD;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get { return plataforma ?? (plataforma = new SQLitePlatformIOS()); }
        }
    }
}