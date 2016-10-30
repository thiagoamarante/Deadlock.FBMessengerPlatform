using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// Use the Button Template with the Send API to send a text and buttons attachment to request input from the user. The buttons can open a URL, or make a back-end call to your webhook.
    /// </summary>
    public class ButtonTemplateAttachment : Attachment<ButtonTemplatePayload>
    {
        public ButtonTemplateAttachment() 
            : base("template")
        {

        }

        /// <summary>
        /// Use the Button Template with the Send API to send a text and buttons attachment to request input from the user. The buttons can open a URL, or make a back-end call to your webhook.
        /// </summary>
        /// <param name="text">text must be UTF-8 and has a 320 character limit</param>
        /// <param name="buttons">buttons is limited to 3</param>
        public ButtonTemplateAttachment(string text, List<Button> buttons)
            : this()
        {
            this.Payload = new ButtonTemplatePayload(text, buttons);
        }
    }
}
