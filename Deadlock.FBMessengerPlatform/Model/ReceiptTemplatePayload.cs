using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// Use the Receipt Template with the Send API to send a order confirmation, with the transaction summary and description for each item.
    /// Notes
    /// order_number must be unique per call.
    /// payment_method is required but is a String. You may insert an arbitrary string here but we recommend providing enough information for the person to decipher which payment method and account they used (e.g., the name of the payment method and partial account number)
    /// address is optional.If you do not ship an item, you may omit these fields.
    /// adjustments allow a way to insert adjusted pricing (e.g., sales). Adjustments are optional.
    /// </summary>
    public class ReceiptTemplatePayload : TemplatePayload
    {
        public ReceiptTemplatePayload() 
            : base("receipt")
        {
        }

        /// <summary>
        /// Recipient's Name
        /// </summary>
        [JsonProperty("recipient_name")]
        public string RecipientName { get; set; }

        /// <summary>
        /// Merchant's name. If present this is shown as logo text.
        /// </summary>
        [JsonProperty("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// Order number. (must be unique for each user)
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Currency for order
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Payment method details. This can be a custom string. Ex: 'Visa 1234'
        /// payment_method is required but is a String. You may insert an arbitrary string here but we recommend providing enough information for the person to decipher which payment method and account they used (e.g., the name of the payment method and partial account number) 
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Timestamp of the order, in seconds.
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// URL of order
        /// </summary>
        [JsonProperty("order_url")]
        public string OrderUrl { get; set; }

        /// <summary>
        /// Items in order (has a maximum of 100)
        /// </summary>
        [JsonProperty("elements")]
        public List<ReceiptElement> Elements { get; set; }

        /// <summary>
        /// Shipping address
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Address Address { get; set; }

        /// <summary>
        /// Payment summary
        /// </summary>
        [JsonProperty("summary")]
        public Summary Summary { get; set; }

        /// <summary>
        /// Payment adjustments
        /// </summary>
        [JsonProperty("adjustments")]
        public List<Adjustment> Adjustments { get; set; }
    }
}
