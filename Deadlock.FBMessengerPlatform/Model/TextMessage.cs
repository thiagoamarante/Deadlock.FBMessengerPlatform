using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class TextMessage : MessageSent
    {
        /// <summary>
        /// text is used when sending a text message, must be UTF-8 and has a 320 character limit
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
