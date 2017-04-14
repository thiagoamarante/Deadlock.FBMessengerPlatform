using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class PayloadItem
    {
        public PayloadItem()
        {

        }

        public PayloadItem(string payload)
        {
            this.Payload = payload;
        }

        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}
