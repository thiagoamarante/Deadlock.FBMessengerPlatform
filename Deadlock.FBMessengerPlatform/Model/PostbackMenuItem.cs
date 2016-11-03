using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class PostbackMenuItem : MenuItem
    {
        public PostbackMenuItem()
            :base("postback")
        {

        }

        public PostbackMenuItem(string title, string payload)
            :this()
        {
            this.Title = title;
            this.Payload = payload;
        }

        /// <summary>
        /// For postback buttons, this data will be sent back to you via webhook
        /// payload has a 1000 character limit
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}
