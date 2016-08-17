using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class ButtonTemplatePayload : ITemplatePayload
    {
        /// <summary>
        /// Value must be generic
        /// </summary>
        public string template_type { get; set; } = "button";

        /// <summary>
        /// Text that appears in main body
        /// text must be UTF-8 and has a 320 character limit
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Set of buttons that appear as call-to-actions
        /// Call-to-action items: 3 buttons
        /// </summary>
        public List<Button> buttons { get; set; }
    }
}
