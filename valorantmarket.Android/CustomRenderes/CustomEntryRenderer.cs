using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using valorantmarket.CustomControl;
using valorantmarket.Droid.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace valorantmarket.Droid.CustomRenders
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                return;
            }

            LoginEntry loginEntry = Element as LoginEntry;

            var shape = new ShapeDrawable(new RectShape());
            //shape.Paint.Color = Android.Graphics.Color.White;
            shape.Paint.Color = loginEntry.BorderColor.ToAndroid();
            shape.Paint.SetStyle(Paint.Style.Stroke);
            shape.Paint.StrokeWidth = loginEntry.BorderWidth;
            //shape.Paint.StrokeWidth = 10;

            Control.Background = shape;
        }
    }
}