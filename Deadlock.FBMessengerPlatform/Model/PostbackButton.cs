using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// When a Postback Button is tapped, we will send a call to your webhook. This is useful when you want to send a person's action to your bot. This button can be used with the Button and Generic Templates.
    /// </summary>
    public class PostbackButton : Button
    {
        public PostbackButton() 
            : base("postback")
        {
        }

        public PostbackButton(string title, string payload)
            : this()
        {
            this.Title = title;
            this.Payload = payload;
        }

        /// <summary>
        /// Button title
        /// 20 characters
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// For postback buttons, this data will be sent back to you via webhook
        /// payload has a 1000 character limit
        /// phone_number payload format mush be ‘+’ prefix followed by the country code, area code and local 
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}
