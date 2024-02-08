using System;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Widget;
using App6.Droid.Renderer;
using App6.Renderer;
using Java.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using DatePicker = Xamarin.Forms.DatePicker;
using TextAlignment = Android.Views.TextAlignment;

[assembly:ExportRenderer(typeof(ExtendedDatePicker), typeof(ExtendedDatePickerRenderer))]
namespace App6.Droid.Renderer
{
    public class ExtendedDatePickerRenderer : DatePickerRenderer
    {
 
        public ExtendedDatePickerRenderer(Context context) : base(context)
        {
 
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Text = "DD/MM/YYYY";
                Control.SetTextColor(new Android.Graphics.Color(128, 128, 128));
                Control.TextSize = 12f;
                Control.Background = null;
            }
        }
    }
}