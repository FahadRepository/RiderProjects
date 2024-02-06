using Android.Content;
using Android.Graphics.Drawables;
using Android.Service.Controls;
using App6.Droid.Renderer;
using App6.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(ExtendedFrame), typeof(ExtendedFrameRenderer))]
namespace App6.Droid.Renderer
{
    public class ExtendedFrameRenderer : FrameRenderer
    {
 
        public ExtendedFrameRenderer(Context context) : base(context)
        {
 
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
        {
            base.OnElementChanged(e);
            var element = e.NewElement as ExtendedFrame;
            if (element == null) return;
            if (element.HasShadow)
            {
                Elevation = 30.0f;
                TranslationZ = 0.0f;
                SetZ(30f);
            }
        }
    }
}