using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class ReusableMediaPayload : IPayload
    {
        public ReusableMediaPayload()
        {

        }

        public ReusableMediaPayload(string attachmentId)
        {
            this.AttachmentId = attachmentId;
        }

        /// <summary>
        /// Attachment id of media
        /// </summary>
        [JsonProperty("attachment_id")]
        public string AttachmentId { get; set; }
    }
}
