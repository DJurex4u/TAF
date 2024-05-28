using FirebotBackend.APIs.Models;
using FirebotBackend.Utils.Settings;
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
            var options = new RestClientOptions(Settings.getAccessTokenUrl);
            _client = new RestClient(options);
            _client.AddDefaultHeader()
        }

        public async Task<RedditUser> GetUser(string user)
        {
            var response = await _client.GetJsonAsync<RedditSingleObject<RedditUser>>(
                "users/by/username/{user}",
                new { user }
            );
            return response!.Data;
        }

        public async Task<RedditUser> GetMe()
        {
            var response = await _client.GetJsonAsync<RedditSingleObject<RedditUser>>(
                "api/v1/me"
            );
            return response!.Data;
        }

        record RedditSingleObject<T>(T Data);

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
