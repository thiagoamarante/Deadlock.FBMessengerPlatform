using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// This callback will occur when a message a page has sent has been delivered.
    /// You can subscribe to this callback by selecting the message_deliveries field when setting up your webhook.
    /// </summary>
    public class Delivery
    {
        /// <summary>
        /// Array containing message IDs of messages that were delivered. Field may not be present.
        /// </summary>
        [JsonProperty("mids")]
        public List<string> Mids { get; set; }

        /// <summary>
        /// All messages that were sent before this timestamp were delivered
        /// </summary>
        [JsonProperty("watermark")]
        public string Watermark { get; set; }

        /// <summary>
        /// Sequence number
        /// </summary>
        [JsonProperty("seq")]
        public int Seq { get; set; }
    }
}
