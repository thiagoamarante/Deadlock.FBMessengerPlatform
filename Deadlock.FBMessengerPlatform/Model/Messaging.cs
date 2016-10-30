using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Messaging
    {
        /// <summary>
        /// Sender user ID
        /// </summary>
        [JsonProperty("sender")]
        public Identity Sender { get; set; }

        /// <summary>
        /// Recipient user ID
        /// </summary>
        [JsonProperty("recipient")]
        public Identity Recipient { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        #region Options
        /// <summary>
        /// This callback will occur when a message has been sent to your page. You may receive text messages or messages with attachments (image, audio, video, file or location). Callbacks contain a seq number which can be used to know the sequence of a message in a conversation. Messages are always sent in order.
        /// You can subscribe to this callback by selecting the message field when setting up your webhook.
        /// </summary>
        [JsonProperty("message")]
        public MessageReceived Message { get; set; }

        /// <summary>
        /// Postbacks occur when a Postback button, Get Started button, Persistent menu or Structured Message is tapped. The payload field in the callback is defined on the button.
        /// You can subscribe to this callback by selecting the messaging_postbacks field when setting up your webhook.
        /// </summary>
        [JsonProperty("postback")]
        public Postback Postback { get; set; }

        /// <summary>
        /// This callback will occur when the Send-to-Messenger plugin has been tapped. The optin.ref parameter is set by the data-ref field on the "Send to Messenger" plugin. This field can be used by the developer to associate a click event on the plugin with a callback.
        /// You can subscribe to this callback by selecting the messaging_optins field when setting up your webhook.
        /// </summary>
        [JsonProperty("optin")]
        public Optin Optin { get; set; }

        /// <summary>
        /// This callback will occur when a message a page has sent has been delivered.
        /// You can subscribe to this callback by selecting the message_deliveries field when setting up your webhook.
        /// </summary>
        [JsonProperty("delivery")]
        public Delivery Delivery { get; set; }

        /// <summary>
        /// This callback will occur when a message a page has sent has been read by the user.
        /// You can subscribe to this callback by selecting the message_reads field when setting up your webhook.
        /// </summary>
        [JsonProperty("read")]
        public Read Read { get; set; }
        #endregion
    }
}
