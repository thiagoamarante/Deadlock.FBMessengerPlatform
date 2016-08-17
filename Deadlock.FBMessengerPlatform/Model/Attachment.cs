using Deadlock.FBMessengerPlatform.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Attachment
    {
        /// <summary>
        /// image, audio, video, file, location, template, fallback
        /// </summary>
        public string type { get; set; }

        public string title { get; set; }

        public string url { get; set; }

        [JsonConverter(typeof(PayloadConverter))]
        public IPayload payload { get; set; }
    }
}
