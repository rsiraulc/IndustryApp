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
using IndustryApp.Code.Services;

namespace IndustryApp.Droid.Services
{
    class NativeHelper:INativeHelper
    {
        public void CloseApp()
        {
            Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}