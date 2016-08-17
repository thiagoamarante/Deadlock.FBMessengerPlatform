using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// A successful Send API request returns a json string with the identifier of the user and the message.
    /// </summary>
    public class SendResponse
    {
        /// <summary>
        /// Unique ID for the user
        /// </summary>
        public string recipient_id { get; set; }

        /// <summary>
        /// Unique ID for the message
        /// </summary>
        public string message_id { get; set; }

        public SendResponseError error { get; set; }
    }
}
