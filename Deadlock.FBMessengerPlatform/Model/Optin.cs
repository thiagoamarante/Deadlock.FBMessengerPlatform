using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class Optin
    {
        /// <summary>
        /// data-ref parameter that was defined with the entry point
        /// </summary>
        [JsonProperty("ref")]
        public string Ref { get; set; }
    }
}
