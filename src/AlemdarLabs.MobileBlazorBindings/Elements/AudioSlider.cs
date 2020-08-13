using AXFA = AlemdarLabs.XF.AudioSlider;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;
using Microsoft.AspNetCore.Components;

namespace AlemdarLabs.MobileBlazorBindings.Elements
{
    public class AudioSlider : Slider
    {
        static AudioSlider()
        {
            ElementHandlerRegistry
                .RegisterElementHandler<AudioSlider>(renderer => 
                    new AudioSliderHandler(renderer, new AXFA.AudioSlider()));
        }

        [Parameter] public bool? HasThumb { get; set; }

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            if (HasThumb.HasValue)
            {
                builder.AddAttribute(nameof(HasThumb), HasThumb.Value);
            }
        }
    }
}
