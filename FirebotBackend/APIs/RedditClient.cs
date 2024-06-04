﻿using FirebotBackend.APIs.Models;
using FirebotBackend.Utils.Settings;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace FirebotBackend.APIs
{
    internal class RedditClient : IRedditClient, IDisposable
    {
        readonly RestClient _client;

        public RedditClient()
        {
            var options = new RestClientOptions(Settings.baseUrl)
            {
                Authenticator = new RedditAuthentificator(Settings.getAccessTokenUrl, Settings.clientId, Settings.clientSecret)
            };
            _client = new RestClient(options);
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
            var request = new RestRequest("api/v1/me");            
            var response = await _client.ExecuteGetAsync<RedditUser>(request);
            
            return response.Data!;
        }

        record RedditSingleObject<T>(T Data);

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
