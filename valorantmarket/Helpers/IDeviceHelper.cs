using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin.Forms;

namespace valorantmarket.Helpers
{
    public interface IDeviceHelper
    {
        string GetPlatformName();

        Xamarin.Forms.Size GetScreenSize();
    }
}
