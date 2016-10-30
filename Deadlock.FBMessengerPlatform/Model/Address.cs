using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Address
    {
        /// <summary>
        /// Street Address, line 1
        /// </summary>
        [JsonProperty("street_1")]
        public string Street1 { get; set; }

        /// <summary>
        /// Street Address, line 2
        /// </summary>
        [JsonProperty("street_2")]
        public string Street2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// US Postal Code
        /// </summary>
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// State abbreviation or Region/Province (international)
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Two-letter country abbreviation
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }
    }
}
