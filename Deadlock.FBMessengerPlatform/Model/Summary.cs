using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Summary
    {
        /// <summary>
        /// Subtotal
        /// </summary>
        [JsonProperty("subtotal")]
        public decimal Subtotal { get; set; }

        /// <summary>
        /// Cost of shipping
        /// </summary>
        [JsonProperty("shipping_cost")]
        public decimal ShippingCost { get; set; }

        /// <summary>
        /// Total tax
        /// </summary>
        [JsonProperty("total_tax")]
        public decimal TotalTax { get; set; }

        /// <summary>
        /// Total cost
        /// </summary>
        [JsonProperty("total_cost")]
        public decimal TotalCost { get; set; }
    }
}
