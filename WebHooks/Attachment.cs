using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.WebHooks
{
    public class Attachment
    {
        public string Type { get; set; }

        public Payload Payload { get; set; }
    }
}
