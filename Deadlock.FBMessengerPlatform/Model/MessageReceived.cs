using Deadlock.FBMessengerPlatform.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class MessageReceived
    {
        /// <summary>
        /// Message ID
        /// </summary>
        [JsonProperty("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// Sequence number
        /// </summary>
        [JsonProperty("seq")]
        public int Seq { get; set; }

        /// <summary>
        /// Text of message
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Optional custom data provided by the sending app
        /// </summary>
        [JsonProperty("quick_reply")]
        public QuickReplyReceived QuickReply { get; set; }

        /// <summary>
        /// Indicates the message sent from the page itself
        /// </summary>
        [JsonProperty("is_echo")]
        public bool IsEcho { get; set; }

        /// <summary>
        /// ID of the app from which the message was sent
        /// </summary>
        [JsonProperty("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// Custom string passed to the Send API as the metadata field
        /// </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// attachment is used to send messages with images or Structured Messages
        /// </summary>
        [JsonProperty("attachments", ItemConverterType = typeof(AttachmentConverter))]
        public List<IAttachment> Attachments { get; set; }
    }
}
