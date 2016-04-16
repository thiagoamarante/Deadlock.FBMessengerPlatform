using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    public interface IPayloadTemplate : IPayload
    {
        /// <summary>
        /// Template attachments has 3 different types of templates: generic, button and receipt.
        /// </summary>
        string template_type { get; }
    }
}
