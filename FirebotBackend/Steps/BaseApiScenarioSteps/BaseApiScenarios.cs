using FirebotBackend.APIs;
using FirebotBackend.Utils.Settings;
using Gherkin;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FirebotBackend.Steps.BaseApiScenarioSteps
{
    [Binding]
    public class BaseApiScenarios
    {
        [Given(@"JWT token is valid")]
        public async Task GivenJWTTokenIsValid()
        {
            //todo: prebaci u hookse
            IRedditClient redditClient = new RedditClient();            
            var me = await redditClient.GetMe();
            string.IsNullOrEmpty(Settings.accessToken);
            Console.WriteLine("heh");
        }

        [When(@"\[action]")]
        public void WhenAction()
        {
            throw new PendingStepException();
        }

    }
}
