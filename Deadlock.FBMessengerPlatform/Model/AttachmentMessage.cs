using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class AttachmentMessage : MessageSent
    {
        public AttachmentMessage()
        {

        }

        public AttachmentMessage(IAttachment attachment)
        {
            this.Attachment = attachment;
        }

        /// <summary>
        /// attachment is used to send messages with images or Structured Messages
        /// </summary>
        [JsonProperty("attachment")]
        public IAttachment Attachment { get; set; }
    }
}
