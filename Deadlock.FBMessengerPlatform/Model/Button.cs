using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public abstract class Button
    {
        public Button(string type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Value is web_url, postback, phone_number, element_share, payment
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }
    }
}
