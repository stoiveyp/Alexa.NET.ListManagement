using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alexa.NET.ListManagement.Requests
{
    internal class SkillItemDateConverter:JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((DateTime)value).ToString("ddd MMM dd HH:mm:ss zzz yyyy").Replace("+00:00", "UTC"));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            var dateValue = reader.Value.ToString();

                return DateTime.ParseExact(dateValue.Replace("UTC", "+00:00"),
                    "ddd MMM dd HH:mm:ss zzz yyyy",
                    CultureInfo.InvariantCulture);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }
    }
}