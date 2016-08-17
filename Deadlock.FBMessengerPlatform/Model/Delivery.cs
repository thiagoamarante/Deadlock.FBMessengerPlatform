using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Delivery
    {
        public List<string> mids { get; set; }

        public string watermark { get; set; }

        public int seq { get; set; }
    }
}
