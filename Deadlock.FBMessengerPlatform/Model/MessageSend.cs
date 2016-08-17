using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class MessageSend
    {
        /// <summary>
        /// Text is used when sending a text message, must be UTF-8 and has a 320 character limit
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Attachment is used to send messages with images or Structured Messages
        /// </summary>
        public Attachment attachment { get; set; }

        /// <summary>
        /// Custom string that will be re-delivered to webhook listeners (has a 1000 character limit)
        /// </summary>
        public string metadata { get; set; }

        /// <summary>
        /// Array of quick_reply to be sent with messages (is limited to 10)
        /// </summary>
        public List<QuickReply> quick_replies { get; set; }
    }
}
