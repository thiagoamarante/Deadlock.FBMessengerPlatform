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
        public static async Task<object> SendMessage(this FacebookClient client, Send send)
        {
            return await client.PostTaskAsync("me/messages", send);
        }

        public static async Task<object> WelcomeMessage(this FacebookClient client, string pageId, ThreadSettings threadSettings)
        {
            return await client.PostTaskAsync($"{pageId}/thread_settings", threadSettings);
        }

        public static async Task<UserProfile> UserProfile(this FacebookClient client, string userId)
        {
            return await client.GetTaskAsync<UserProfile>($"{userId}?fields=first_name,last_name,profile_pic");
        }
    }
}
