using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Read
    {
        public string watermark { get; set; }

        public int seq { get; set; }
    }
}
