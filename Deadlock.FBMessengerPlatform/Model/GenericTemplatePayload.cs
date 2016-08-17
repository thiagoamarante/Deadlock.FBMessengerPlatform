using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class GenericTemplatePayload : ITemplatePayload
    {
        /// <summary>
        /// Value must be generic
        /// </summary>
        public string template_type { get; set; } = "generic";

        // <summary>
        /// Data for each bubble in message
        /// Bubbles per message (horizontal scroll): 10 elements
        /// </summary>
        public List<GenericElement> elements { get; set; }
    }
}
