using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// This callback will occur when a message a page has sent has been read by the user.
    /// You can subscribe to this callback by selecting the message_reads field when setting up your webhook.
    /// </summary>
    public class Read
    {
        /// <summary>
        /// All messages that were sent before this timestamp were read
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
