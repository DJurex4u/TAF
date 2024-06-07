using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebotBackend.APIs
{
    internal static class ClientProvider
    {
        static IRedditClient? RedditClient { get; set; }

        internal static IRedditClient GetRedditClientInstance()
        {
            if (RedditClient == null)
            {
                RedditClient = new RedditClient();
            }
            return RedditClient;
        }
    }
}
