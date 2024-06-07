using FirebotBackend.APIs.Models;
using FirebotBackend.Utils.Settings;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace FirebotBackend.APIs
{
    public class RedditAuthentificator : AuthenticatorBase
    {
        readonly string _baseUrl;
        readonly string _clientId;
        readonly string _clientSecret;

        public RedditAuthentificator(string baseUrl, string clientId, string clientSecret) : base("")
        {
            _baseUrl = baseUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            Token = Settings.accessToken;
            
            //todo:implement getting its own token
            Token = string.IsNullOrEmpty(Token) ? await GetToken() : Token;            
            return new HeaderParameter(KnownHeaders.Authorization, Token);
        }

        async Task<string> GetToken()
        {
            var options = new RestClientOptions(_baseUrl)
            {
                Authenticator = new HttpBasicAuthenticator(_clientId, _clientSecret),
            };
            using var client = new RestClient(options);
            var request = new RestRequest(Settings.getAccessTokenUrl);
                request.AddParameter("grant_type", "password")
                .AddParameter("redirect_uri", Settings.redirectUri)
                .AddParameter("username", Settings.username)
                .AddParameter("password", Settings.password);
            //var response = await client.PostAsync<TokenResponse>(request);
            var response2 = await client.ExecutePostAsync<TokenResponseModel>(request);
            //var response3 = await client.ExecutePostAsync<JsonNode>(request);
            //Assert.That(response.TokenType, );
            Console.WriteLine("");
            return $"{response2!.Data.TokenType} {response2!.Data.AccessToken}";
        }
    }
}
