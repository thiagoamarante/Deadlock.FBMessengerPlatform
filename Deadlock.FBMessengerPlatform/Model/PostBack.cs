using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// Postbacks occur when a Postback button, Get Started button, Persistent menu or Structured Message is tapped. The payload field in the callback is defined on the button.
    /// You can subscribe to this callback by selecting the messaging_postbacks field when setting up your webhook.
    /// </summary>
    public class Postback
    {
        /// <summary>
        /// payload parameter that was defined with the button
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}
