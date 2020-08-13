using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using System;
using Xamarin.Forms.PancakeView;
using XFF = Xamarin.Forms;
using AMEH = AlemdarLabs.MobileBlazorBindings.Elements.Helpers;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Handlers
{
    public class PancakeViewHandler : ContentViewHandler
    {
        public PancakeViewHandler(NativeComponentRenderer renderer, XFF.PancakeView.PancakeView pancakeViewControl) : base(renderer, pancakeViewControl)
        {
            PancakeViewControl = pancakeViewControl ?? throw new ArgumentNullException(nameof(pancakeViewControl));
        }

        public XFF.PancakeView.PancakeView PancakeViewControl { get; }

        public override void ApplyAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch (attributeName)
            {
                case nameof(PancakeView.BackgroundGradientStops):
                    PancakeViewControl.BackgroundGradientStops = AMEH.AttributeHelper.StringToGradientStopCollection(attributeValue);
                    break;
                case nameof(PancakeView.BackgroundGradientStartPoint):
                    PancakeViewControl.BackgroundGradientStartPoint = AMEH.AttributeHelper.StringToPoint(attributeValue);
                    break;
                case nameof(PancakeView.BackgroundGradientEndPoint):
                    PancakeViewControl.BackgroundGradientEndPoint = AMEH.AttributeHelper.StringToPoint(attributeValue);
                    break;
                //[Parameter] public IEnumerable<GradientStop> BackgroundGradientStops { get; set; }
                case nameof(XFF.PancakeView.PancakeView.BorderColor):
                    PancakeViewControl.BorderColor = AttributeHelper.StringToColor((string)attributeValue);
                    break;
                case nameof(XFF.PancakeView.PancakeView.BorderDrawingStyle):
                    PancakeViewControl.BorderDrawingStyle = (BorderDrawingStyle)AttributeHelper.GetInt(attributeValue);
                    break;
                case nameof(XFF.PancakeView.PancakeView.BorderGradientAngle):
                    PancakeViewControl.BorderGradientAngle = AttributeHelper.GetInt(attributeValue);
                    break;
                case nameof(XFF.PancakeView.PancakeView.BorderGradientEndColor):
                    PancakeViewControl.BorderGradientEndColor = AttributeHelper.StringToColor((string)attributeValue);
                    break;
                case nameof(XFF.PancakeView.PancakeView.BorderGradientStartColor):
                    PancakeViewControl.BorderGradientStartColor = AttributeHelper.StringToColor((string)attributeValue);
                    break;
                //[Parameter] public IEnumerable<GradientStop> BorderGradientStops { get; set; }
                case nameof(XFF.PancakeView.PancakeView.BorderIsDashed):
                    PancakeViewControl.BorderIsDashed = AttributeHelper.GetBool(attributeValue);
                    break;
                case nameof(XFF.PancakeView.PancakeView.BorderThickness):
                    PancakeViewControl.BorderThickness = AttributeHelper.StringToSingle((string)attributeValue);
                    break;
                case nameof(XFF.PancakeView.PancakeView.CornerRadius):
                    PancakeViewControl.CornerRadius = AttributeHelper.StringToCornerRadius(attributeValue);
                    break;
                case nameof(XFF.PancakeView.PancakeView.Elevation):
                    PancakeViewControl.Elevation = AttributeHelper.GetInt(attributeValue);
                    break;
                case nameof(XFF.PancakeView.PancakeView.HasShadow):
                    PancakeViewControl.HasShadow = AttributeHelper.GetBool(attributeValue);
                    break;
                case nameof(XFF.PancakeView.PancakeView.OffsetAngle):
                    PancakeViewControl.OffsetAngle = AttributeHelper.StringToDouble((string)attributeValue);
                    break;
                case nameof(XFF.PancakeView.PancakeView.Sides):
                    PancakeViewControl.Sides = AttributeHelper.GetInt(attributeValue);
                    break;
                default:
                    base.ApplyAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;
            }
        }
    }
}
