using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Messaging
    {
        public Identity sender { get; set; }

        public Identity recipient { get; set; }

        public string timestamp { get; set; }

        #region Options
        public MessageReceived message { get; set; }

        public PostBack postback { get; set; }

        public Optin optin { get; set; }       

        public Delivery delivery { get; set; }       

        public Read read { get; set; }
        #endregion
    }
}
