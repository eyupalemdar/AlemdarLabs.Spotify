using AlemdarLabs.MobileBlazorBindings.Elements.Handlers;
using FFImageLoading.Cache;
using FF = FFImageLoading.Forms;
using FFImageLoading.Work;
using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using System;
using XFF = Xamarin.Forms;
using Microsoft.MobileBlazorBindings.Elements;

namespace AlemdarLabs.MobileBlazorBindings.Elements
{
    public partial class CachedImage : View
    {
        static CachedImage()
        {
            ElementHandlerRegistry.RegisterElementHandler<CachedImage>(
                renderer => new CachedImageHandler(renderer, new FF.CachedImage()));
        }

        [Parameter] public XFF.Aspect? Aspect { get; set; }
        [Parameter] public bool? BitmapOptimizations { get; set; }
        [Parameter] public TimeSpan? CacheDuration { get; set; }
        //[Parameter] public ICacheKeyFactory CacheKeyFactory { get; set; }
        [Parameter] public CacheType? CacheType { get; set; }
        //[Parameter] public IDataResolver CustomDataResolver { get; set; }
        [Parameter] public double? DownsampleHeight { get; set; }
        [Parameter] public bool? DownsampleToViewSize { get; set; }
        [Parameter] public bool? DownsampleUseDipUnits { get; set; }
        [Parameter] public double? DownsampleWidth { get; set; }
        [Parameter] public XFF.ImageSource ErrorPlaceholder { get; set; }
        [Parameter] public int? FadeAnimationDuration { get; set; }
        [Parameter] public bool? FadeAnimationEnabled { get; set; }
        [Parameter] public bool? FadeAnimationForCachedImages { get; set; }
        //[Parameter] public bool? FixedAndroidMotionEventHandler { get; set; }
        //[Parameter] public bool? FixedOnMeasureBehavior { get; set; }
        [Parameter] public bool? InvalidateLayoutAfterLoaded { get; set; }
        [Parameter] public bool? IsOpaque { get; set; }
        [Parameter] public int? LoadingDelay { get; set; }
        [Parameter] public XFF.ImageSource LoadingPlaceholder { get; set; }
        [Parameter] public LoadingPriority? LoadingPriority { get; set; }
        [Parameter] public int? RetryCount { get; set; }
        [Parameter] public int? RetryDelay { get; set; }
        [Parameter] public XFF.ImageSource Source { get; set; }
        //[Parameter] public List<ITransformation> Transformations { get; set; }
        [Parameter] public bool? TransformPlaceholders { get; set; }

        public new FF.CachedImage NativeControl => ((CachedImageHandler)ElementHandler).CachedImageControl;

        protected override void RenderAttributes(AttributesBuilder builder)
        {
            base.RenderAttributes(builder);

            if (Aspect != null)
            {
                builder.AddAttribute(nameof(Aspect), (int)Aspect.Value);
            }
            if (BitmapOptimizations != null)
            {
                builder.AddAttribute(nameof(BitmapOptimizations), BitmapOptimizations.Value);
            }
            if (CacheDuration != null)
            {
                builder.AddAttribute(nameof(CacheDuration), CacheDuration.Value);
            }
            //if (CacheKeyFactory != null)
            //{
            //    builder.AddAttribute(nameof(CacheKeyFactory), CacheKeyFactory);
            //}
            if (CacheType != null)
            {
                builder.AddAttribute(nameof(CacheType), CacheType.Value);
            }
            //if (CustomDataResolver != null)
            //{
            //    builder.AddAttribute(nameof(CustomDataResolver), CustomDataResolver);
            //}
            if (DownsampleHeight != null)
            {
                builder.AddAttribute(nameof(DownsampleHeight), AttributeHelper.DoubleToString(DownsampleHeight.Value));
            }
            if (DownsampleToViewSize != null)
            {
                builder.AddAttribute(nameof(DownsampleToViewSize), DownsampleToViewSize.Value);
            }
            if (DownsampleUseDipUnits != null)
            {
                builder.AddAttribute(nameof(DownsampleUseDipUnits), DownsampleUseDipUnits.Value);
            }
            if (DownsampleWidth != null)
            {
                builder.AddAttribute(nameof(DownsampleWidth), AttributeHelper.DoubleToString(DownsampleWidth.Value));
            }
            if (ErrorPlaceholder != null)
            {
                builder.AddAttribute(nameof(ErrorPlaceholder), AttributeHelper.ImageSourceToString(ErrorPlaceholder));
            }
            if (FadeAnimationDuration != null)
            {
                builder.AddAttribute(nameof(FadeAnimationDuration), FadeAnimationDuration.Value);
            }
            if (FadeAnimationEnabled != null)
            {
                builder.AddAttribute(nameof(FadeAnimationEnabled), FadeAnimationEnabled.Value);
            }
            if (FadeAnimationForCachedImages != null)
            {
                builder.AddAttribute(nameof(FadeAnimationForCachedImages), FadeAnimationForCachedImages.Value);
            }
            //if (FixedAndroidMotionEventHandler != null)
            //{
            //    builder.AddAttribute(nameof(FixedAndroidMotionEventHandler), FixedAndroidMotionEventHandler.Value);
            //}
            //if (FixedOnMeasureBehavior != null)
            //{
            //    builder.AddAttribute(nameof(FixedOnMeasureBehavior), FixedOnMeasureBehavior.Value);
            //}
            if (InvalidateLayoutAfterLoaded != null)
            {
                builder.AddAttribute(nameof(InvalidateLayoutAfterLoaded), InvalidateLayoutAfterLoaded.Value);
            }
            if (IsOpaque != null)
            {
                builder.AddAttribute(nameof(IsOpaque), IsOpaque.Value);
            }
            if (LoadingDelay != null)
            {
                builder.AddAttribute(nameof(LoadingDelay), LoadingDelay.Value);
            }
            if (LoadingPlaceholder != null)
            {
                builder.AddAttribute(nameof(LoadingPlaceholder), AttributeHelper.ImageSourceToString(LoadingPlaceholder));
            }
            if (LoadingPriority != null)
            {
                builder.AddAttribute(nameof(LoadingPriority), (int)LoadingPriority.Value);
            }
            if (RetryCount != null)
            {
                builder.AddAttribute(nameof(RetryCount), RetryCount.Value);
            }
            if (RetryDelay != null)
            {
                builder.AddAttribute(nameof(RetryDelay), RetryDelay.Value);
            }
            if (Source != null)
            {
                builder.AddAttribute(nameof(Source), AttributeHelper.ImageSourceToString(Source));
            }
            //if (Transformations != null)
            //{
            //    builder.AddAttribute(nameof(Transformations), Transformations);
            //}
            if (TransformPlaceholders != null)
            {
                builder.AddAttribute(nameof(TransformPlaceholders), TransformPlaceholders.Value);
            }

            RenderAdditionalAttributes(builder);
        }

        partial void RenderAdditionalAttributes(AttributesBuilder builder);
    }
}
