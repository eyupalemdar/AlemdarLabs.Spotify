using FSF = FFImageLoading.Svg.Forms;
using Microsoft.MobileBlazorBindings.Core;
using System;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Handlers
{
    public partial class SvgCachedImageHandler : CachedImageHandler
    {
        public SvgCachedImageHandler(NativeComponentRenderer renderer, FSF.SvgCachedImage svgCachedImageControl) : base(renderer, svgCachedImageControl)
        {
            SvgCachedImageControl = svgCachedImageControl ?? throw new ArgumentNullException(nameof(svgCachedImageControl));

            Initialize(renderer);
        }

        partial void Initialize(NativeComponentRenderer renderer);

        public FSF.SvgCachedImage SvgCachedImageControl { get; }

        public override void ApplyAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch (attributeName)
            {
                default:
                    base.ApplyAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;
            }
        }
    }
}
