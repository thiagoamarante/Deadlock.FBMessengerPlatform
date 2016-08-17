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
        public decimal subtotal { get; set; }

        /// <summary>
        /// Cost of shipping
        /// </summary>
        public decimal shipping_cost { get; set; }

        /// <summary>
        /// Total tax
        /// </summary>
        public decimal total_tax { get; set; }

        /// <summary>
        /// Total cost
        /// </summary>
        public decimal total_cost { get; set; }
    }
}
