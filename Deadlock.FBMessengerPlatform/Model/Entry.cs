using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Entry
    {
        /// <summary>
        /// Page ID of page
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Time of update (epoch time in milliseconds)
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// Array containing objects related to messaging
        /// </summary>
        [JsonProperty("messaging")]
        public List<Messaging> Messaging { get; set; }
    }
}
