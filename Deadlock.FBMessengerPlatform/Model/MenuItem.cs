using Deadlock.FBMessengerPlatform.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public abstract class MenuItem
    {
        public MenuItem(string type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Value is web_url or postback
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// title has a 30 character limit
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
