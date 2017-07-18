using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// The URL Button can be used to open a web page in the in-app browser. This button can be used with the Button and Generic Templates.
    /// </summary>
    public class URLButton : Button
    {
        public URLButton() 
            : base("web_url")
        {
        }

        public URLButton(string title, string url, WebviewHeightRatio webviewHeightRatio = WebviewHeightRatio.Full, bool? messengerExtensions = null, string fallbackUrl = null)
            : this()
        {
            this.Title = title;
            this.Url = url;
            this.WebviewHeightRatio = webviewHeightRatio;
            this.MessengerExtensions = messengerExtensions;
            this.FallbackUrl = fallbackUrl;
        }

        /// <summary>
        /// Button title
        /// 20 characters
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

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

        /// <summary>
        /// URL to use on clients that don't support Messenger Extensions. If this is not defined, the url will be used as the fallback.
        /// </summary>
        [JsonProperty("fallback_url")]
        public string FallbackUrl { get; set; }

        [JsonProperty("webview_share_button")]
        [JsonConverter(typeof(StringEnumConverter), true)]
        public WebviewShareButton WebviewShareButton { get; set; }
    }
}
