﻿using AlemdarLabs.Spotify.Droid.Renderers;
using Android.Content;
using Android.Graphics.Drawables;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AlemdarLabs.XF.AudioSlider;

[assembly: ExportRenderer(typeof(AudioSlider), typeof(AudioSliderRenderer))]
namespace AlemdarLabs.Spotify.Droid.Renderers
{
    public class AudioSliderRenderer : SliderRenderer
    {
        public AudioSliderRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);

            if (Control != null && e.NewElement != null)
            {
                Control.SetPadding(0, 0, 0, 0);
                Control.SetPaddingRelative(0, 0, 0, 0);

                // Set custom drawable resource
                Control.SetProgressDrawableTiled(Resources.GetDrawable(Resource.Drawable.custom_slider, (this.Context).Theme));

                // Hide thumb
                if (!(e.NewElement as AudioSlider).HasThumb)
                {
                    Control.SetThumb(new ColorDrawable(Android.Graphics.Color.Transparent));
                }
            }
        }
    }
}