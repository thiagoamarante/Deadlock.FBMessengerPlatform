using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class ListTemplatePayload : TemplatePayload
    {
        public ListTemplatePayload() 
            : base("list")
        {
        }

        public ListTemplatePayload(List<GenericElement> elements, TopElementStyleType topElementStyleType = TopElementStyleType.Large)
            : this()
        {
            this.TopElementStyle = topElementStyleType.ToString().ToLower();
            this.Elements = elements;
        }

        [JsonProperty("top_element_style")]
        public string TopElementStyle { get; set; } = TopElementStyleType.Large.ToString().ToLower();

        // <summary>
        /// Data for each bubble in message
        /// Bubbles per message (horizontal scroll): 10 elements
        /// </summary>
        [JsonProperty("elements")]
        public List<GenericElement> Elements { get; set; }
    }
}
