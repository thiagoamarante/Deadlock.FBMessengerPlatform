using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.WebHooks
{
    public class Delivery
    {
        public List<string> Mids { get; set; }

        public string Watermark { get; set; }

        public int Seq { get; set; }
    }
}
