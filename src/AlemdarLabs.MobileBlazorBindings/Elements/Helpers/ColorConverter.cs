using Newtonsoft.Json;
using System;
using XFF = Xamarin.Forms;
using MME = Microsoft.MobileBlazorBindings.Elements;

namespace AlemdarLabs.MobileBlazorBindings.Elements.Helpers
{
    public class ColorConverter : JsonConverter<XFF.Color>
    {
        public override XFF.Color ReadJson(JsonReader reader, Type objectType, XFF.Color existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return MME.AttributeHelper.StringToColor(reader.Value);
        }

        public override void WriteJson(JsonWriter writer, XFF.Color value, JsonSerializer serializer)
        {
            writer.WriteValue(MME.AttributeHelper.ColorToString(value));
        }
    }
}
