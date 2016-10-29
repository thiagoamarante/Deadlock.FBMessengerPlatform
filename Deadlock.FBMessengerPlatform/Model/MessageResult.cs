using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class MessageResult : Result
    {
        public string RecipientId { get; set; }

        public string MessageId { get; set; }
    }
}
