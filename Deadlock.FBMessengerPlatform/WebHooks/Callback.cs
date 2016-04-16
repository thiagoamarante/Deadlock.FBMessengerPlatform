using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.WebHooks
{
    public class Callback
    {
        public string Object { get; set; }

        public List<Entry> Entry { get; set; }
    }
}
