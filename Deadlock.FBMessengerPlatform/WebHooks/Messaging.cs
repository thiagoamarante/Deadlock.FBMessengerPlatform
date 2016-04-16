using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.WebHooks
{
    public class Messaging
    {
        public Identity Sender { get; set; }

        public Identity Recipient { get; set; }

        public string Timestamp { get; set; }

        #region Options
        public Optin Optin { get; set; }

        public Message Message { get; set; }

        public Delivery Delivery { get; set; }

        public PostBack PostBack { get; set; }
        #endregion
    }
}
