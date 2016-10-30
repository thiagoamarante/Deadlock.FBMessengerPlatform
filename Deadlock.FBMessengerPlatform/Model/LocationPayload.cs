using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class LocationPayload : IPayload
    {
        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }
    }
}
