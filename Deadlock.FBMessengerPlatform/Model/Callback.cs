using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Callback
    {
        /// <summary>
        /// Value will be page
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Array containing event data
        /// </summary>
        [JsonProperty("entry")]
        public List<Entry> Entry { get; set; }
    }
}
