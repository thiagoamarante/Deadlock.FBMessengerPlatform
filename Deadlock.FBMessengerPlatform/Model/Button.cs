using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Button
    {
        /// <summary>
        /// Value is web_url, postback, phone_number, element_share, payment
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Button title
        /// 20 characters
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// For web_url buttons, this URL is opened in a mobile browser when the button is tapped
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string url { get; set; }

        /// <summary>
        /// For postback buttons, this data will be sent back to you via webhook
        /// payload has a 1000 character limit
        /// phone_number payload format mush be ‘+’ prefix followed by the country code, area code and local 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string payload { get; set; }

        /// <summary>
        /// Height of the Webview. Valid values: compact, tall, full.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string webview_height_ratio { get; set; }

        /// <summary>
        /// Must be true if using Messenger Extensions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public bool? messenger_extensions { get; set; }

        /// <summary>
        /// URL to use on clients that don't support Messenger Extensions. If this is not defined, the url will be used as the fallback.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string fallback_url { get; set; }

        //payment_summary
        //price_list
    }
}
