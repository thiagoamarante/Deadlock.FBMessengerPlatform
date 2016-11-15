using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class MediaPayload : IPayload
    {
        public MediaPayload()
        {

        }

        public MediaPayload(string url, bool isReusable = false)
        {
            this.Url = url;
            this.IsReusable = isReusable;
        }

        /// <summary>
        /// URL of media
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("is_reusable")]
        public bool IsReusable { get; set; }
    }
}
