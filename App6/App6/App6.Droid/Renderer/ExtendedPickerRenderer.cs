using Android.Content;
using Android.Graphics.Drawables;
using Android.Service.Controls;
using App6.Droid.Renderer;
using App6.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(ExtendedPicker), typeof(ExtendedPickerRenderer))]
namespace App6.Droid.Renderer
{
    public class ExtendedPickerRenderer : PickerRenderer
        {
        public ExtendedPickerRenderer(Context context) : base(context)
        {
 
        }

        private ExtendedPicker customPicker;

        public static void Init() { }
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
 
                var layoutParams = new MarginLayoutParams(Control.LayoutParameters);
                layoutParams.SetMargins(10, 10, 0, 0);
                LayoutParameters = layoutParams;
                Control.LayoutParameters = layoutParams;
                Control.SetPadding(10, 10, 0, 0);
                SetPadding(10, 10, 0, 0);
            }
        }
        }
}