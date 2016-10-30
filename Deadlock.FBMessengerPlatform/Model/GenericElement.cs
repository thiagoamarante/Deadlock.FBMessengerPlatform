using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class GenericElement
    {
        /// <summary>
        /// Bubble title
        /// has a 80 character limit
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Bubble subtitle
        /// has a 80 character limit
        /// </summary>
        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        /// <summary>
        /// URL that is opened when bubble is tapped
        /// </summary>
        [JsonProperty("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// Bubble image
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Set of buttons that appear as call-to-actions
        /// Call-to-action items: 3 buttons
        /// </summary>
        [JsonProperty("buttons")]
        public List<Button> Buttons { get; set; }
    }
}
