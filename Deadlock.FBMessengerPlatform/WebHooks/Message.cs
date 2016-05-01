using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.WebHooks
{
    public class Message
    {
        public string Mid { get; set; }

        public int Seq { get; set; }

        public string Text { get; set; }

        public List<Attachment> Attachments { get; set; }
    }
}
