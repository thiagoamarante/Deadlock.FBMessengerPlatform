using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    /// <summary>
    /// Button template
    /// </summary>
    public class ButtonPayloadTemplate : IPayloadTemplate
    {
        /// <summary>
        /// Value must be generic
        /// </summary>
        public string template_type { get { return "button"; } }

        /// <summary>
        /// Text that appears in main body
        /// </summary>
        public string text { get; set; }

        /// <summary>
        /// Set of buttons that appear as call-to-actions
        /// Call-to-action items: 3 buttons
        /// </summary>
        public List<Button> buttons { get; set; }
    }
}
