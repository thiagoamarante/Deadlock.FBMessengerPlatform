using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    public class Attachment
    {
        /// <summary>
        /// Type of attachment, may be image or template
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Payload of attachment
        /// </summary>
        public IPayload payload { get; set; }
    }
}
