using AlemdarLabs.MobileBlazorBindings.Elements.Handlers;
using Microsoft.MobileBlazorBindings.Core;
using FSF = FFImageLoading.Svg.Forms;

namespace AlemdarLabs.MobileBlazorBindings.Elements
{
    public partial class SvgCachedImage : CachedImage
    {
        static SvgCachedImage()
        {
            ElementHandlerRegistry.RegisterElementHandler<SvgCachedImage>(
                renderer => new SvgCachedImageHandler(renderer, new FSF.SvgCachedImage()));
        }

        public new FSF.SvgCachedImage NativeControl => ((SvgCachedImageHandler)ElementHandler).SvgCachedImageControl;

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            RenderAdditionalAttributes(builder);
        }

        partial void RenderAdditionalAttributes(AttributesBuilder builder);
    }
}
