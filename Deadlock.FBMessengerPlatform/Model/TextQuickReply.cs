using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class TextQuickReply : QuickReply
    {
        public TextQuickReply() 
            : base("text")
        {

        }

        /// <summary>
        /// Caption of button (has a 20 character limit)
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Custom data that will be sent back to you via webhook (has a 1000 character limit)
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}
