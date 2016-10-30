using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    /// <summary>
    /// The Share Button enables people to share message bubbles with their contacts using a native share dialog in Messenger.
    /// </summary>
    public class ShareButton : Button
    {
        public ShareButton() 
            : base("element_share")
        {
        }
    }
}
