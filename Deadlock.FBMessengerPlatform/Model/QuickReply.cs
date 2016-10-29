using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public abstract class QuickReply
    {
        public QuickReply(string contentType)
        {
            this.ContentType = contentType;
        }

        /// <summary>
        /// Value must be text or location
        /// </summary>
        [JsonProperty("content_type")]
        public string ContentType { get; private set; }       

        /// <summary>
        /// Image for image_url should be at least 24x24 and will be cropped and resized
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }
}
