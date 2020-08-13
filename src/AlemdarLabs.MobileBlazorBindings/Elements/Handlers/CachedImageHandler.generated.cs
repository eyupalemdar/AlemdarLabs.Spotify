using FF = FFImageLoading.Forms;
using FFImageLoading.Cache;
using FFImageLoading.Work;
using Microsoft.MobileBlazorBindings.Core;
using Microsoft.MobileBlazorBindings.Elements;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using System;
using XFF = Xamarin.Forms;
using AMEH = AlemdarLabs.MobileBlazorBindings.Elements.Helpers;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Handlers
{
    public partial class CachedImageHandler : ViewHandler
    {
        public CachedImageHandler(NativeComponentRenderer renderer, FF.CachedImage cachedImageControl) : base(renderer, cachedImageControl)
        {
            CachedImageControl = cachedImageControl ?? throw new ArgumentNullException(nameof(CachedImageControl));

            Initialize(renderer);
        }

        partial void Initialize(NativeComponentRenderer renderer);

        public FF.CachedImage CachedImageControl { get; }

        public override void ApplyAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName)
        {
            switch (attributeName)
            {
                case nameof(FF.CachedImage.Aspect):
                    CachedImageControl.Aspect = (XFF.Aspect)AttributeHelper.GetInt(attributeValue);
                    break;
                case nameof(FF.CachedImage.BitmapOptimizations):
                    CachedImageControl.BitmapOptimizations = AttributeHelper.GetBool(attributeValue);
                    break;
                case nameof(FF.CachedImage.CacheDuration):
                    CachedImageControl.CacheDuration = AMEH.AttributeHelper.StringToTimeSpan(attributeValue); ;
                    break;
                //case nameof(FF.CachedImage.CacheKeyFactory):
                //    CachedImageControl.CacheKeyFactory = ;
                //    break;
                case nameof(FF.CachedImage.CacheType):
                    CachedImageControl.CacheType = (CacheType)AttributeHelper.GetInt(attributeValue);
                    break;
                //case nameof(FF.CachedImage.CustomDataResolver):
                //    CachedImageControl.CustomDataResolver = ;
                //    break;
                case nameof(FF.CachedImage.DownsampleHeight):
                    CachedImageControl.DownsampleHeight = AttributeHelper.StringToDouble((string)attributeValue);
                    break;
                case nameof(FF.CachedImage.DownsampleToViewSize):
                    CachedImageControl.DownsampleToViewSize = AttributeHelper.GetBool(attributeValue);
                    break;
                case nameof(FF.CachedImage.DownsampleUseDipUnits):
                    CachedImageControl.DownsampleUseDipUnits = AttributeHelper.GetBool(attributeValue);
                    break;
                case nameof(FF.CachedImage.DownsampleWidth):
                    CachedImageControl.DownsampleWidth = AttributeHelper.StringToDouble((string)attributeValue);
                    break;
                case nameof(FF.CachedImage.ErrorPlaceholder):
                    CachedImageControl.ErrorPlaceholder = AttributeHelper.StringToImageSource(attributeValue);
                    break;
                case nameof(FF.CachedImage.FadeAnimationDuration):
                    CachedImageControl.FadeAnimationDuration = AttributeHelper.GetInt(attributeValue);
                    break;
                case nameof(FF.CachedImage.FadeAnimationEnabled):
                    CachedImageControl.FadeAnimationEnabled = AttributeHelper.GetBool(attributeValue);
                    break;
                case nameof(FF.CachedImage.FadeAnimationForCachedImages):
                    CachedImageControl.FadeAnimationForCachedImages = AttributeHelper.GetBool(attributeValue);
                    break;
                //case nameof(FF.CachedImage.FixedAndroidMotionEventHandler):
                //    CachedImageControl.FixedAndroidMotionEventHandler = AttributeHelper.GetBool(attributeValue);
                //    break;
                //case nameof(FF.CachedImage.FixedOnMeasureBehavior):
                //    CachedImageControl.FixedOnMeasureBehavior = AttributeHelper.GetBool(attributeValue);
                //    break;
                case nameof(FF.CachedImage.InvalidateLayoutAfterLoaded):
                    CachedImageControl.InvalidateLayoutAfterLoaded = AttributeHelper.GetBool(attributeValue); ;
                    break;
                case nameof(FF.CachedImage.IsOpaque):
                    CachedImageControl.IsOpaque = AttributeHelper.GetBool(attributeValue);
                    break;
                case nameof(FF.CachedImage.LoadingDelay):
                    CachedImageControl.LoadingDelay = AttributeHelper.GetInt(attributeValue); ;
                    break;
                case nameof(FF.CachedImage.LoadingPlaceholder):
                    CachedImageControl.LoadingPlaceholder = AttributeHelper.StringToImageSource(attributeValue);
                    break;
                case nameof(FF.CachedImage.LoadingPriority):
                    CachedImageControl.LoadingPriority = (LoadingPriority)AttributeHelper.GetInt(attributeValue);
                    break;
                case nameof(FF.CachedImage.RetryCount):
                    CachedImageControl.RetryCount = AttributeHelper.GetInt(attributeValue, 3);
                    break;
                case nameof(FF.CachedImage.RetryDelay):
                    CachedImageControl.RetryDelay = AttributeHelper.GetInt(attributeValue, 250);
                    break;
                case nameof(FF.CachedImage.Source):
                    CachedImageControl.Source = AttributeHelper.StringToImageSource(attributeValue);
                    break;
                //case nameof(FF.CachedImage.Transformations):
                //    CachedImageControl.Transformations = ;
                //    break;
                case nameof(FF.CachedImage.TransformPlaceholders):
                    CachedImageControl.TransformPlaceholders = AttributeHelper.GetBool(attributeValue); ;
                    break;
                default:
                    ApplyAdditionalAttribute(attributeEventHandlerId, attributeName, attributeValue, attributeEventUpdatesAttributeName);
                    break;
            }
        }

        partial void ApplyAdditionalAttribute(ulong attributeEventHandlerId, string attributeName, object attributeValue, string attributeEventUpdatesAttributeName);
    }
}