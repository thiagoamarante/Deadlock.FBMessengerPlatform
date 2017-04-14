using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class MessengerProfile
    {
        [JsonProperty("account_linking_url")]
        public string AccountLinkingUrl { get; set; }

        [JsonProperty("greeting")]
        public List<GreetingValue> Greeting { get; set; }

        [JsonProperty("get_started")]
        public PayloadItem GetStarted { get; set; }

        [JsonProperty("persistent_menu")]
        public List<PersistentMenu> PersistentMenu { get; set; }
    }
}
