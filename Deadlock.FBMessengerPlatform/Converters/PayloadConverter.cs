using Deadlock.FBMessengerPlatform.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Converters
{
    public class PayloadConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IPayload);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var payload = default(IPayload);           
            if(jsonObject["url"] != null)
            {
                payload = new MediaPayload();
            }
            else if (jsonObject["coordinates"] != null)
            {
                payload = new LocationPayload();
            }
            else if (jsonObject["template_type"] != null)
            {
                var token = (JValue)jsonObject["template_type"];
                switch(token.Value.ToString())
                {
                    case "button":
                        payload = new ButtonTemplatePayload();
                        break;
                    case "generic":
                        payload = new GenericTemplatePayload();
                        break;
                    case "receipt":
                        payload = new ReceiptTemplatePayload();
                        break;
                }
            }
            serializer.Populate(jsonObject.CreateReader(), payload);
            return payload;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
