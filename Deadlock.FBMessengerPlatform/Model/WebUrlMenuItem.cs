using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class WebUrlMenuItem : MenuItem
    {
        public WebUrlMenuItem()
            :base("web_url")
        {
            
        }

        public WebUrlMenuItem(string title, string url)
            :this()
        {
            this.Title = title;
            this.Url = url;
        }

        /// <summary>
        /// For web_url buttons, this URL is opened in a mobile browser when the button is tapped
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Height of the Webview. Valid values: compact, tall, full.
        /// </summary>
        [JsonProperty("webview_height_ratio")]
        [JsonConverter(typeof(StringEnumConverter), true)]
        public WebviewHeightRatio WebviewHeightRatio { get; set; }

        /// <summary>
        /// Must be true if using Messenger Extensions.
        /// </summary>
        [JsonProperty("messenger_extensions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MessengerExtensions { get; set; }

        [JsonProperty("webview_share_button")]
        [JsonConverter(typeof(StringEnumConverter), true)]
        public WebviewShareButton WebviewShareButton { get; set; }
    }
}
