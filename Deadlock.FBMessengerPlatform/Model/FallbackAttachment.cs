using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// A fallback attachment is any attachment not currently recognized or supported by the Message Echo feature.
    /// </summary>
    public class FallbackAttachment : Attachment<MediaPayload>
    {
        public FallbackAttachment() 
            : base("fallback")
        {
        }

        /// <summary>
        /// Title of attachment (optional)
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL of attachment (optional)
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
