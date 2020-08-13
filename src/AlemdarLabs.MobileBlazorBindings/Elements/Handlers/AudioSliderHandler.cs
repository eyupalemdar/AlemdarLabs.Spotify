using AXFA = AlemdarLabs.XF.AudioSlider;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using System;
using Microsoft.MobileBlazorBindings.Elements;

namespace AlemdarLabs.MobileBlazorBindings.Elements
{
    public partial class AudioSliderHandler : SliderHandler
    {
        public AudioSliderHandler(NativeComponentRenderer renderer, AXFA.AudioSlider audioSliderControl) : base(renderer, audioSliderControl)
        {
            AudioSliderControl = audioSliderControl ?? throw new ArgumentNullException(nameof(audioSliderControl));
            Initialize(renderer);
        }

        partial void Initialize(NativeComponentRenderer renderer);

        public AXFA.AudioSlider AudioSliderControl { get; }

        public override void ApplyAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch (attributeName)
            {
                case nameof(AXFA.AudioSlider.HasThumb):
                    AudioSliderControl.HasThumb = AttributeHelper.GetBool(attributeValue);
                    break;

                default:
                    base.ApplyAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;
            }
        }
    }
}
