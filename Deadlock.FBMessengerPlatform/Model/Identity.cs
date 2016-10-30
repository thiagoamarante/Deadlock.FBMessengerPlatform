using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Identity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
