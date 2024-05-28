using FirebotBackend.APIs;
using FirebotBackend.Utils.Settings;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FirebotBackend.Steps.BaseApiScenarioSteps
{
    internal class BaseApiScenarios
    {
        [Given(@"JWT token is valid")]
        public void GivenJWTTokenIsValid()
        {
            //todo: prebaci u hookse
            var auth = new RedditAuthentificator(Settings.baseUrl,Settings.clientId,Settings.clientSecret);
            IRedditClient redditClient = new RedditClient("", "");
            redditClient.GetMe();
            auth.Authenticate();

            var options = new RestClientOptions("https://example.com")
            {
                Authenticator = new HttpBasicAuthenticator("username", "password")
            };
            var client = new RestClient(options);
        }

    }
}
