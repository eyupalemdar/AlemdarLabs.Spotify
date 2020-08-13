using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using System;
using XFF = Xamarin.Forms;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Handlers
{
    public partial class FlexLayoutHandler : LayoutHandler
    {
        public FlexLayoutHandler(NativeComponentRenderer renderer, XFF.FlexLayout flexLayoutControl) : base(renderer, flexLayoutControl)
        {
            FlexLayoutControl = flexLayoutControl ?? throw new ArgumentNullException(nameof(flexLayoutControl));

            Initialize(renderer);
        }

        partial void Initialize(NativeComponentRenderer renderer);

        public XFF.FlexLayout FlexLayoutControl { get; }

        public override void ApplyAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch (attributeName)
            {
                case nameof(XFF.FlexLayout.AlignContent):
                    FlexLayoutControl.AlignContent = (XFF.FlexAlignContent)AttributeHelper.GetInt(attributeValue, (int)XFF.FlexAlignContent.Stretch);
                    break;
                case nameof(XFF.FlexLayout.AlignItems):
                    FlexLayoutControl.AlignItems = (XFF.FlexAlignItems)AttributeHelper.GetInt(attributeValue, (int)XFF.FlexAlignItems.Stretch);
                    break;
                case nameof(XFF.FlexLayout.Direction):
                    FlexLayoutControl.Direction = (XFF.FlexDirection)AttributeHelper.GetInt(attributeValue);
                    break;
                case nameof(XFF.FlexLayout.JustifyContent):
                    FlexLayoutControl.JustifyContent = (XFF.FlexJustify)AttributeHelper.GetInt(attributeValue, (int)XFF.FlexJustify.Start);
                    break;
                case nameof(XFF.FlexLayout.Position):
                    FlexLayoutControl.Position = (XFF.FlexPosition)AttributeHelper.GetInt(attributeValue);
                    break;
                case nameof(XFF.FlexLayout.Wrap):
                    FlexLayoutControl.Wrap = (XFF.FlexWrap)AttributeHelper.GetInt(attributeValue);
                    break;
                default:
                    base.ApplyAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;
            }
        }
    }
}
