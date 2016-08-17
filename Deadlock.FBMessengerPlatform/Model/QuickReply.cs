using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class QuickReply
    {
        /// <summary>
        /// Value must be text or template
        /// </summary>
        public string content_type { get; set; }

        /// <summary>
        /// Caption of button (has a 20 character limit)
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Custom data that will be sent back to you via webhook (has a 1000 character limit)
        /// </summary>
        public string payload { get; set; }
    }
}
