using Xamarin.Forms;

namespace AlemdarLabs.XF.AudioSlider
{
    public class AudioSlider : Slider
    {
        public static readonly BindableProperty HasThumbProperty =
            BindableProperty.Create(nameof(HasThumb), typeof(bool), typeof(ScrollView), true);

        public bool HasThumb
        {
            get { return (bool)GetValue(HasThumbProperty); }
            set { SetValue(HasThumbProperty, value); }
        }
    }
}
