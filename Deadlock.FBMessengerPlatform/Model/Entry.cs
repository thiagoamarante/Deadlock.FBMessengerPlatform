using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Entry
    {
        public string id { get; set; }

        public string time { get; set; }

        public List<Messaging> messaging { get; set; }
    }
}
