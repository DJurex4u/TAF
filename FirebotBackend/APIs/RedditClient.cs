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
        
        public async Task<JsonNode> GetMe()
        {
            //var response = await _client.GetJsonAsync<RedditSingleObject<RedditUser>>(
            //    "api/v1/me"
            //);
            //return response!.Data;

            var request = new RestRequest("api/v1/me");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            var response1 = await _client.ExecuteGetAsync(request);
            var response2 = await _client.ExecuteGetAsync<JsonNode>(request);
            //var data = JsonSerializer.Deserialize<JsonNode>(RedditUser.Content!)!;

            // deserialize json string response to JsonNode object
            //var data = JsonSerializer.Deserialize<JsonNode>(response.Content!)!;
            return response2.Data!;
        }

        record RedditSingleObject<T>(T Data);

        public void Dispose()
        {
            _client?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
