using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// You can send files by uploading them or sharing a URL using the Send API.
    /// </summary>
    public class FileAttachment : Attachment<MediaPayload>
    {
        public FileAttachment() 
            : base("file")
        {
        }

        public FileAttachment(string url)
            : this()
        {
            this.Payload = new MediaPayload(url);
        }
    }
}
