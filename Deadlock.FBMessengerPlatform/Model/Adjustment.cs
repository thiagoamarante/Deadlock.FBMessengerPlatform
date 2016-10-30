using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Adjustment
    {
        /// <summary>
        /// Name of adjustment
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Adjusted amount
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}
