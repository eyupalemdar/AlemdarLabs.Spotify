using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Helpers
{
    public static class GradientStopExtensions
    {
        public static string SerializeObject(this IEnumerable<GradientStop> gradientStopList)
        {
            return JsonConvert.SerializeObject(gradientStopList, 
                Formatting.Indented, 
                new ColorConverter());
        }

        public static T DeserializeObject<T>(this string gradientStopListAsString)
        {
            return JsonConvert.DeserializeObject<T>(gradientStopListAsString, new ColorConverter());
        }
    }
}
