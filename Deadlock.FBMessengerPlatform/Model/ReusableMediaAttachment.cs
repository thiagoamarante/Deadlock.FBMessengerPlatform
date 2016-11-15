using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class ReusableMediaAttachment : Attachment<ReusableMediaPayload>
    {
        public ReusableMediaAttachment(MediaType type)
            : base(type.ToString().ToLower())
        {
        }

        public ReusableMediaAttachment(MediaType type, string attachmentId)
            : this(type)
        {
            this.Payload = new ReusableMediaPayload(attachmentId);
        }
    }
}
