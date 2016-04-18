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

        public static object WelcomeMessage(this FacebookClient client, string pageId, ThreadSettings threadSettings)
        {
            return client.Post($"{pageId}/thread_settings", threadSettings);
        }

        public static UserProfile UserProfile(this FacebookClient client, string userId)
        {
            return client.Get<UserProfile>($"{userId}?fields=first_name,last_name,profile_pic");
        }
    }
}
