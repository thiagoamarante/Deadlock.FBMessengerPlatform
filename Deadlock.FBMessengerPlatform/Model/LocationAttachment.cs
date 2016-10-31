using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class LocationAttachment : Attachment<LocationPayload>
    {
        public LocationAttachment() 
            : base("location")
        {
        }

        public LocationAttachment(Coordinates coordinates)
            : this()
        {
            this.Payload = new LocationPayload(coordinates);
        }

        /// <summary>
        /// Title of attachment (optional)
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL of attachment (optional)
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
