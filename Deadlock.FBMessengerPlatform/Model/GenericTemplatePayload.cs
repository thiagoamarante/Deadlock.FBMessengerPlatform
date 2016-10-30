using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class GenericTemplatePayload : TemplatePayload
    {
        public GenericTemplatePayload() 
            : base("generic")
        {
        }

        public GenericTemplatePayload(List<GenericElement> elements)
            : this()
        {
            this.Elements = elements;
        }


        // <summary>
        /// Data for each bubble in message
        /// Bubbles per message (horizontal scroll): 10 elements
        /// </summary>
        [JsonProperty("elements")]
        public List<GenericElement> Elements { get; set; }
    }
}
