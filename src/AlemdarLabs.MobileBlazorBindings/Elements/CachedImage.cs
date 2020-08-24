using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;

namespace AlemdarLabs.MobileBlazorBindings.Elements
{
    public partial class CachedImage : View
    {
        [Parameter] public double? BlurredTransformation { get; set; }

        partial void RenderAdditionalAttributes(AttributesBuilder builder)
        {
            if (BlurredTransformation != null)
            {
                builder.AddAttribute(nameof(BlurredTransformation), BlurredTransformation.Value);
            }
        }

#pragma warning disable CA1721 // Property names should not match get methods
        [Parameter] public RenderFragment ChildContent { get; set; }
#pragma warning restore CA1721 // Property names should not match get methods

        protected override RenderFragment GetChildContent() => ChildContent;
    }
}
