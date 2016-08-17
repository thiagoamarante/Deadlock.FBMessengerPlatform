using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Callback
    {
        public string @object { get; set; }

        public List<Entry> entry { get; set; }
    }
}
