using Android.Content;
using Android.Graphics.Drawables;
using App6.Droid.Renderer;
using App6.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
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
            if (e.NewElement != null)
            {
                Control.Text = "DD/MM/YYYY";
                // Control.CurrentHintTextColor = Color.Gray;
                Control.Background = null;
            }
        }
    }
}