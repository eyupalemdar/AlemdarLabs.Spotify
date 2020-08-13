using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Elements;

namespace AlemdarLabs.MobileBlazorBindings.Elements
{
    public partial class FlexLayout : Layout
    {
#pragma warning disable CA1721 // Property names should not match get methods
        [Parameter] public RenderFragment ChildContent { get; set; }
#pragma warning restore CA1721 // Property names should not match get methods

        protected override RenderFragment GetChildContent() => ChildContent;
    }
}
