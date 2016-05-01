using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.WebHooks
{
    public class Attachment
    {
        /// <summary>
        /// image, audio, video, location
        /// </summary>
        public string Type { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public Payload Payload { get; set; }
    }
}
