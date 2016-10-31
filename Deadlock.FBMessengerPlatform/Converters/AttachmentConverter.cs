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
    public class AttachmentConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IAttachment);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            IAttachment result = default(IAttachment); ;
            JObject attachment = JObject.Load(reader);
            string type = (attachment["type"] as JValue).Value.ToString();
            switch(type)
            {
                case "image":
                    result = new ImageAttachment();
                    break;
                case "audio":
                    result = new AudioAttachment();
                    break;
                case "video":
                    result = new VideoAttachment();
                    break;
                case "file":
                    result = new FileAttachment();
                    break;
                case "location":
                    result = new LocationAttachment();
                    break;
                case "fallback":
                    result = new FallbackAttachment();
                    break;
                case "template":
                    string templateType = (attachment["payload"]["template_type"] as JValue).Value.ToString();
                    switch(templateType)
                    {
                        case "generic":
                            result = new GenericTemplateAttachment();
                            break;
                        case "button":
                            result = new ButtonTemplateAttachment();
                            break;
                        case "receipt":
                            result = new ReceiptTemplateAttachment();
                            break;
                    }
                    break;
            }
            serializer.Populate(attachment.CreateReader(), result);
            return result;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.Serialize(writer, value);
        }
    }
}
