using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// You can send images, videos, audio or files by uploading them or sharing a URL using the Send API. 
    /// Images supported formats are jpg, png and gif.
    /// </summary>
    public class MediaAttachment : Attachment<MediaPayload>
    {
        public MediaAttachment(MediaType type)
            : base(type.ToString().ToLower())
        {
        }

        public MediaAttachment(MediaType type, string url, bool isReusable = false)
            : this(type)
        {
            this.Payload = new MediaPayload(url, isReusable);
        }
    }
}
