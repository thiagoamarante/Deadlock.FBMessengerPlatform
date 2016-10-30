using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Coordinates
    {
        /// <summary>
        /// Latitude
        /// </summary>
        [JsonProperty("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        [JsonProperty("long")]
        public string Long { get; set; }
    }
}
