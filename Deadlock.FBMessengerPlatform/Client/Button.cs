using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    public class Button
    {
        /// <summary>
        /// Value is web_url or postback
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
        public string url { get; set; }

        /// <summary>
        /// For postback buttons, this data will be sent back to you via webhook
        /// </summary>
        public string payload { get; set; }
    }
}
