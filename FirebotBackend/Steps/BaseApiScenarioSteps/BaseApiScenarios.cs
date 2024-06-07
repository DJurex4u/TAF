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
    internal class BaseApiScenarios : RedditBaseSteps
    {   

        [Given(@"JWT token is valid")]
        public async Task GivenJWTTokenIsValid()
        {
            //todo: prebaci Auth u hookse            
            RedditClient = ClientProvider.GetRedditClientInstance();
            RedditUserResponse = await RedditClient.GetMe(this);

            if (Response == null)
            {
                throw new Exception("Response is null");
            }

            if (!Response.IsSuccessful)
            {
                throw new Exception($"Response in not succesful. Response code is: {(int)Response.StatusCode} ({Response.StatusCode})\n");
            }

            if (RedditUserResponse == null)
            {
                throw new Exception("RedditUserResponse is null");
            }

            IValidator validator = new RedditValidator(RedditUserResponse);
            validator.Validate();
        }
    }
}
