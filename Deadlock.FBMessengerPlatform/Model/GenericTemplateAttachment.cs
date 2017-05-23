using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// Use the Generic Template with the Send API to send a horizontal scrollable carousel of items, each composed of an image attachment, short description and buttons to request input from the user.
    /// </summary>
    public class GenericTemplateAttachment : Attachment<GenericTemplatePayload>
    {
        public GenericTemplateAttachment() 
            : base("template")
        {

        }

        public GenericTemplateAttachment(List<GenericElement> elements, ImageAspectRatioType imageAspectRatioType = ImageAspectRatioType.Horizontal)
            : this()
        {
            this.Payload = new GenericTemplatePayload(elements, imageAspectRatioType);
        }
    }
}
