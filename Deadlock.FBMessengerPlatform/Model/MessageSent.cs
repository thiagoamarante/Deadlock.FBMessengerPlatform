using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public abstract class MessageSent
    {
        /// <summary>
        /// Custom string that will be re-delivered to webhook listeners
        /// metadata has a 1000 character limit
        /// </summary>
        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// Quick Replies provide a new way to present buttons to the user. Quick Replies appear prominently above the composer, with the keyboard less prominent. When a quick reply is tapped, the message is sent in the conversation with developer-defined metadata in the callback. Also, the buttons are dismissed preventing the issue where users could tap on buttons attached to old messages in a conversation.
        /// quick_replies is limited to 10
        /// </summary>
        [JsonProperty("quick_replies")]
        public List<QuickReply> QuickReplies { get; set; }
    }
}
