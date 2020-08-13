using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;

namespace AlemdarLabs.MobileBlazorBindings.Elements
{
    public partial class BottomTabbedPage : TabbedPage
    {
        [Parameter] public EventCallback OnCurrentPageChanged { get; set; }

        partial void RenderAdditionalAttributes(AttributesBuilder builder)
        {
            builder.AddAttribute("oncurrentpagechanged", OnCurrentPageChanged);
        }
    }
}
