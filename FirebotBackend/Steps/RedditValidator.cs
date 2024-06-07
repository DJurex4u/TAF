using FirebotBackend.APIs;
using FirebotBackend.APIs.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FirebotBackend.Steps
{
    [Binding]
    public class RedditValidator : ValidatorBase
    {
        public RedditValidator(RedditUserResponseModel model)
        {
            Model = model;
        }

        [Then(@"Reddit user is valid")]
        
        protected override async Task ValidateRequestAsync()
        {
            //todo: mkožda naslijediti assert pa se zajj AssertBase
            RedditClient = ClientProvider.GetRedditClientInstance();
            RedditUserResponse = await RedditClient.GetMe();
            Assert.That(Model, Is.Not.Null);
        }
    }
}
