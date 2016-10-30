using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// The Call Button can be used to initiate a phone call. This button can be used with the Button and Generic Templates.
    /// </summary>
    public class CallButton : Button
    {
        public CallButton() 
            : base("phone_number")
        {
        }

        public CallButton(string title, string payload)
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
        /// Format must have "+" prefix followed by the country code, area code and local number. For example, +16505551234.
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}
