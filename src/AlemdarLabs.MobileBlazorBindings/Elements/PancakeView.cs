using AlemdarLabs.MobileBlazorBindings.Elements.Handlers;
using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;
using System.Collections.Generic;
using Xamarin.Forms.PancakeView;
using XFF = Xamarin.Forms;
using AMEH = AlemdarLabs.MobileBlazorBindings.Elements.Helpers;

namespace AlemdarLabs.MobileBlazorBindings.Elements
{
    public class PancakeView : ContentView
    {
        static PancakeView()
        {
            ElementHandlerRegistry
                .RegisterElementHandler<PancakeView>(renderer => new PancakeViewHandler(renderer, new XFF.PancakeView.PancakeView()));
        }

        [Parameter] public IEnumerable<GradientStop> BackgroundGradientStops { get; set; }
        [Parameter] public XFF.Point? BackgroundGradientStartPoint { get; set; }
        [Parameter] public XFF.Point? BackgroundGradientEndPoint { get; set; }
        [Parameter] public XFF.Color? BorderColor { get; set; }
        [Parameter] public BorderDrawingStyle? BorderDrawingStyle { get; set; }
        [Parameter] public int? BorderGradientAngle { get; set; }
        [Parameter] public XFF.Color? BorderGradientEndColor { get; set; }
        [Parameter] public XFF.Color? BorderGradientStartColor { get; set; }
        [Parameter] public bool? BorderIsDashed { get; set; }
        [Parameter] public float? BorderThickness { get; set; }
        [Parameter] public XFF.CornerRadius? CornerRadius { get; set; }
        [Parameter] public int? Elevation { get; set; }
        [Parameter] public bool? HasShadow { get; set; }
        [Parameter] public double? OffsetAngle { get; set; }
        [Parameter] public int? Sides { get; set; }

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            if (BackgroundGradientStops != null)
            {
                builder.AddAttribute(nameof(BackgroundGradientStops), AMEH.AttributeHelper.GradientStopListToString(BackgroundGradientStops));
            }
            if (BackgroundGradientStartPoint != null)
            {
                builder.AddAttribute(nameof(BackgroundGradientStartPoint), BackgroundGradientStartPoint.Value);
            }
            if (BackgroundGradientEndPoint != null)
            {
                builder.AddAttribute(nameof(BackgroundGradientEndPoint), BackgroundGradientEndPoint.Value);
            }
            if (BorderColor != null)
            {
                builder.AddAttribute(nameof(BorderColor), AttributeHelper.ColorToString(BorderColor.Value));
            }
            if (BorderDrawingStyle != null)
            {
                builder.AddAttribute(nameof(BorderDrawingStyle), (int)BorderDrawingStyle.Value);
            }
            if (BorderGradientAngle != null)
            {
                builder.AddAttribute(nameof(BorderGradientAngle), BorderGradientAngle.Value);
            }
            if (BorderGradientEndColor != null)
            {
                builder.AddAttribute(nameof(BorderGradientEndColor), AttributeHelper.ColorToString(BorderGradientEndColor.Value));
            }
            if (BorderGradientStartColor != null)
            {
                builder.AddAttribute(nameof(BorderGradientStartColor), AttributeHelper.ColorToString(BorderGradientStartColor.Value));
            }
            if (BorderIsDashed != null)
            {
                builder.AddAttribute(nameof(BorderIsDashed), BorderIsDashed.Value);
            }
            if (BorderThickness != null)
            {
                builder.AddAttribute(nameof(BorderThickness), AttributeHelper.SingleToString(BorderThickness.Value));
            }
            if (CornerRadius != null)
            {
                builder.AddAttribute(nameof(CornerRadius), AttributeHelper.CornerRadiusToString(CornerRadius.Value));
            }
            if (Elevation != null)
            {
                builder.AddAttribute(nameof(Elevation), Elevation.Value);
            }
            if (HasShadow != null)
            {
                builder.AddAttribute(nameof(HasShadow), HasShadow.Value);
            }
            if (OffsetAngle != null)
            {
                builder.AddAttribute(nameof(OffsetAngle), AttributeHelper.DoubleToString(OffsetAngle.Value));
            }
            if (Sides != null)
            {
                builder.AddAttribute(nameof(Sides), Sides.Value);
            }
        }
    }

    public class GradientStop
    {
        public float Offset { get; set; }
        public XFF.Color Color { get; set; }
    }
}
