using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Content.Res;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using valorantmarket.Helpers;
using Xamarin.Forms;
using valorantmarket.Droid.Helpers;

[assembly: Dependency(typeof(DeviceHelper))]
namespace valorantmarket.Droid.Helpers
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetPlatformName()
        {
            return "Android";
        }

        public Size GetScreenSize()
        {
            var displayMetrics = Resources.System.DisplayMetrics;

            float width = displayMetrics.WidthPixels / displayMetrics.Density;
            float height = displayMetrics.HeightPixels / displayMetrics.Density;

            return new Size(width, height);
        }
    }
}