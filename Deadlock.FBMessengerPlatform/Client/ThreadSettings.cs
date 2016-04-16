using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    public class ThreadSettings
    {
        public string setting_type { get { return "call_to_actions"; } }

        public string thread_state { get { return "new_thread"; } }

        public List<CallToAction> call_to_actions { get; set; }
    }
}
