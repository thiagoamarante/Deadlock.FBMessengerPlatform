using Deadlock.FBMessengerPlatform.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public abstract class Attachment<T> : IAttachment
        where T: IPayload
    {
        public Attachment(string type)
        {
            this.Type = type;
        }

        /// <summary>
        /// image, audio, video, file, location, template, fallback
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        //public string title { get; set; }

        //public string url { get; set; }

        //[JsonConverter(typeof(PayloadConverter))]
        [JsonProperty("payload")]
        public T Payload { get; set; }
    }
}
