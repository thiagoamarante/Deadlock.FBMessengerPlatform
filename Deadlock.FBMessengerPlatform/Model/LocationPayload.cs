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
        public LocationPayload()
        {

        }

        public LocationPayload(Coordinates coordinates)
        {
            this.Coordinates = coordinates;
        }

        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }
    }
}
