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
using IndustryApp.Droid;
using IndustryApp.Code;
using IndustryApp.Pages;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidMethods))]
namespace IndustryApp.Droid
{
    class AndroidMethods: IAndroidMethods
    {
        public void CloseApp()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}