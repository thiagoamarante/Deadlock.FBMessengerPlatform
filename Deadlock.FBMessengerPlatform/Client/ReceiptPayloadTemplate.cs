using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    /// <summary>
    /// Receipt template
    /// Notes
    /// order_number must be unique per call.
    /// payment_method is required but is a String. You may insert an arbitrary string here but we recommend providing enough information for the person to decipher which payment method and account they used (e.g., the name of the payment method and partial account number)
    /// address is optional.If you do not ship an item, you may omit these fields.
    /// adjustments allow a way to insert adjusted pricing (e.g., sales). Adjustments are optional.
    /// </summary>
    public class ReceiptPayloadTemplate : IPayloadTemplate
    {
        /// <summary>
        /// Value should be receipt
        /// </summary>
        public string template_type { get { return "receipt"; } }

        /// <summary>
        /// Recipient's Name
        /// </summary>
        public string recipient_name { get; set; }

        /// <summary>
        /// Order number.
        /// </summary>
        public string order_number { get; set; }

        /// <summary>
        /// Currency for order
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Payment method details. This can be a custom string. Ex: 'Visa 1234'
        /// </summary>
        public string payment_method { get; set; }

        /// <summary>
        /// Timestamp of order
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        /// URL of order
        /// </summary>
        public string order_url { get; set; }

        /// <summary>
        /// Items in order
        /// </summary>
        public List<ReceiptElement> elements { get; set; }

        /// <summary>
        /// Shipping address
        /// </summary>
        public Address address { get; set; }

        /// <summary>
        /// Payment summary
        /// </summary>
        public Summary summary { get; set; }

        /// <summary>
        /// Payment adjustments
        /// </summary>
        public List<Adjustment> adjustments { get; set; }
    }
}
