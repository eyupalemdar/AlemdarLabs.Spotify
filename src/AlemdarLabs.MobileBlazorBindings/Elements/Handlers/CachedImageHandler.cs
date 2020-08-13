using FFImageLoading.Transformations;
using Microsoft.MobileBlazorBindings.Elements;
using Microsoft.MobileBlazorBindings.Elements.Handlers;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Handlers
{
    public partial class CachedImageHandler : ViewHandler
    {
        partial void ApplyAdditionalAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch (attributeName)
            {
                case nameof(CachedImage.BlurredTransformation):
                    CachedImageControl.Transformations = new System.Collections.Generic.List<FFImageLoading.Work.ITransformation>()
                    {
                        new BlurredTransformation(AttributeHelper.StringToDouble((string)attributeValue))
                    };
                    break;
                default:
                    base.ApplyAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;
            }
        }
    }
}
