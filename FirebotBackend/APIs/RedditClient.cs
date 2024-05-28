using FirebotBackend.APIs.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebotBackend.APIs
{
    internal class RedditClient : IRedditClient, IDisposable
    {
        readonly RestClient _client;

        public RedditClient(string apiKey, string apiKeySecret)
        {
            var options = new RestClientOptions("https://api.twitter.com/2");
            _client = new RestClient(options);
        }

        public async Task<RedditUser> GetUser(string user)
        {
            var response = await _client.GetJsonAsync<TwitterSingleObject<RedditUser>>(
                "users/by/username/{user}",
                new { user }
            );
            return response!.Data;
        }

        record TwitterSingleObject<T>(T Data);

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
