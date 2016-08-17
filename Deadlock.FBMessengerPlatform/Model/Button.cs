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
        /// Value is web_url, postback and phone_number
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
        /// payload has a 1000 character limit
        /// phone_number payload format mush be ‘+’ prefix followed by the country code, area code and local 
        /// </summary>
        public string payload { get; set; }

        //Closing the browser???
    }
}
