using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class ReceiptElement : IElement
    {
        /// <summary>
        /// Image URL of item
        /// </summary>
        public string image_url { get; set; }

        /// <summary>
        /// Bubble Title of item
        /// 80 characters
        /// </summary>
        public string subtitle { get; set; }

        /// <summary>
        /// Title of item
        /// 45 characters
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Quantity of item
        /// </summary>
        public decimal quantity { get; set; }

        /// <summary>
        /// Item price
        /// </summary>
        public decimal price { get; set; }

        /// <summary>
        /// Currency of price
        /// </summary>
        public string currency { get; set; }
    }
}
