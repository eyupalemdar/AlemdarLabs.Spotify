using System;
using System.Collections.Generic;
using Xamarin.Forms.PancakeView;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Helpers
{
    public static partial class AttributeHelper
    {
        public static string GradientStopListToString(IEnumerable<GradientStop> gradientStopList)
        {
            if (gradientStopList is null)
            {
                throw new ArgumentNullException(nameof(gradientStopList));
            }

            return gradientStopList.SerializeObject();
        }

        public static GradientStopCollection StringToGradientStopCollection(object gradientStopListString, GradientStopCollection defaultValueIfNull = default)
        {
            if (gradientStopListString is null)
            {
                return defaultValueIfNull;
            }
            if (!(gradientStopListString is string gradientStopListAsString))
            {
                throw new ArgumentException("Expected parameter instance to be a string.", nameof(gradientStopListString));
            }

            return gradientStopListAsString.DeserializeObject<GradientStopCollection>();
        }
    }
}
