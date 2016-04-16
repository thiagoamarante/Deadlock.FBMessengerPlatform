using Facebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Client
{
    public static class Extensions
    {
        public static object SendMessage(this FacebookClient client, Send send)
        {
            return client.Post("me/messages", send);
        }
    }
}
