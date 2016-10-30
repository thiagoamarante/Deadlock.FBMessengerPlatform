using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// Use the Receipt Template with the Send API to send a order confirmation, with the transaction summary and description for each item.
    /// </summary>
    public class ReceiptTemplateAttachment : Attachment<ReceiptTemplatePayload>
    {
        public ReceiptTemplateAttachment() 
            : base("template")
        {

        }

        public ReceiptTemplateAttachment(ReceiptTemplatePayload receipt)
            : this()
        {
            this.Payload = receipt;
        }
    }
}
