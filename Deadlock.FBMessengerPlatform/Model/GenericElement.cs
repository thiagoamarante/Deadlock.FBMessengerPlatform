using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class GenericElement : IElement
    {
        /// <summary>
        /// URL that is opened when bubble is tapped
        /// </summary>
        public string item_url { get; set; }

        /// <summary>
        /// Bubble image
        /// </summary>
        public string image_url { get; set; }

        /// <summary>
        /// Bubble subtitle
        /// has a 80 character limit
        /// </summary>
        public string subtitle { get; set; }

        /// <summary>
        /// Bubble title
        /// has a 80 character limit
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Set of buttons that appear as call-to-actions
        /// Call-to-action items: 3 buttons
        /// </summary>
        public List<Button> buttons { get; set; }
    }
}
