using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Converters
{
    public class EnumValueConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsEnum;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var member = value.GetType().GetMember(value.ToString()).First();
            JsonPropertyAttribute attribute = (JsonPropertyAttribute)member.GetCustomAttributes(typeof(JsonPropertyAttribute), false).FirstOrDefault();
            string result = value.ToString();
            if (attribute != null)
                result = attribute.PropertyName;
            serializer.Serialize(writer, result);
        }
    }
}
