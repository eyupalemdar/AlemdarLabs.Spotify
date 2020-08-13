using System;
using Xamarin.Forms;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Helpers
{
    public static partial class AttributeHelper
    {
        /// <summary>
        /// Helper method to deserialize <see cref="Point" /> objects.
        /// </summary>
        public static Point StringToPoint(object pointString, Point defaultValueIfNull = default)
        {
            if (pointString is null)
            {
                return defaultValueIfNull;
            }
            if (!(pointString is string pointAsString))
            {
                throw new ArgumentException("Expected parameter instance to be a string.", nameof(pointString));
            }

            var pointStringParts = pointAsString.Replace("{", "").Replace("}", "").Split(' ');
            double xPoint = Convert.ToDouble(pointStringParts[0].Replace("X=", ""));
            double yPoint = Convert.ToDouble(pointStringParts[1].Replace("Y=", ""));

            return new Point(xPoint, yPoint);
        }
    }
}
