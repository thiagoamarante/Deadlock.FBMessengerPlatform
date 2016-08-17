using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class GreetingThreadSettings : IThreadSettings
    {
        public string setting_type { get; set; } = "greeting";

        public Greeting greeting { get; set; }
    }
}
