using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    public class Message
    {
        /// <summary>
        /// Message text, must be UTF-8, 320 character limit
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Attachment data
        /// </summary>
        public Attachment attachment { get; set; }
    }
}
