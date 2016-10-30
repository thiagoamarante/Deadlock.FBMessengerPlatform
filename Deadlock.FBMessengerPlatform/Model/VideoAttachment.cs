using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// You can send videos by uploading them or sharing a URL using the Send API.
    /// </summary>
    public class VideoAttachment : Attachment<MediaPayload>
    {
        public VideoAttachment() 
            : base("video")
        {
        }

        public VideoAttachment(string url)
            : this()
        {
            this.Payload = new MediaPayload(url);
        }
    }
}
