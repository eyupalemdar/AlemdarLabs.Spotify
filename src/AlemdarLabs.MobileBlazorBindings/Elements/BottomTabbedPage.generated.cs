using AlemdarLabs.MobileBlazorBindings.Elements.Handlers;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;
using AXB = AlemdarLabs.XF.BottomTabbedPage;

namespace AlemdarLabs.MobileBlazorBindings.Elements
{
    public partial class BottomTabbedPage : TabbedPage
    {
        static BottomTabbedPage()
        {
            ElementHandlerRegistry
                .RegisterElementHandler<BottomTabbedPage>(renderer =>
                    new BottomTabbedPageHandler(renderer, new AXB.BottomTabbedPage()));
        }

        public new AXB.BottomTabbedPage NativeControl => ((BottomTabbedPageHandler)ElementHandler).BottomTabbedPageControl;

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            RenderAdditionalAttributes(builder);
        }

        partial void RenderAdditionalAttributes(AttributesBuilder builder);
    }
}
