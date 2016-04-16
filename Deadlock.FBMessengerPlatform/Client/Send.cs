using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    public class Send
    {
        /// <summary>
        /// Information about the recipient of the message
        /// </summary>
        public Recipient recipient { get; set; }

        /// <summary>
        /// Push notification type: REGULAR, SILENT_PUSH, NO_PUSH
        /// </summary>
        public string notification_type { get; set; }

        /// <summary>
        /// Contents of the message
        /// </summary>
        public Message message { get; set; }
    }
}
