using AXFB = AlemdarLabs.XF.BottomTabbedPage;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using System;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Handlers
{
    public partial class BottomTabbedPageHandler : TabbedPageHandler
    {
        public BottomTabbedPageHandler(NativeComponentRenderer renderer, AXFB.BottomTabbedPage bottomTabbedPageControl) : base(renderer, bottomTabbedPageControl)
        {
            BottomTabbedPageControl = bottomTabbedPageControl ?? throw new ArgumentNullException(nameof(bottomTabbedPageControl));

            Initialize(renderer);
        }

        partial void Initialize(NativeComponentRenderer renderer);

        public AXFB.BottomTabbedPage BottomTabbedPageControl { get; }
    }
}