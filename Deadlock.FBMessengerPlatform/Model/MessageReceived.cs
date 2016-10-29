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
        /// Indicates the message sent from the page itself
        /// </summary>
        public bool is_echo { get; set; }

        /// <summary>
        /// ID of the app from which the message was sent
        /// </summary>
        public string app_id { get; set; }

        /// <summary>
        /// Custom string passed to the Send API as the metadata field
        /// </summary>
        public string metadata { get; set; }

        /// <summary>
        /// Message ID
        /// </summary>
        public string mid { get; set; }

        /// <summary>
        /// Sequence number
        /// </summary>
        public int seq { get; set; }

        /// <summary>
        /// Text of message
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Optional custom data provided by the sending app
        /// </summary>
        public QuickReply quick_reply { get; set; }

        /// <summary>
        /// Array containing attachment data
        /// </summary>
        //public List<Attachment> attachments { get; set; }
    }
}
