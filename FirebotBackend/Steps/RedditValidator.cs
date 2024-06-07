using FirebotBackend.APIs;
using FirebotBackend.APIs.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace FirebotBackend.Steps
{
    [Binding]
    public class RedditValidator : ValidatorBase
    {
        RedditUserResponseModel Model { get; set; }
        public RedditValidator(RedditUserResponseModel model) => Model = model;
        protected override void ValidateRedditUserResponse()
        {
            try
            {
                Assert.That(Model.id, Is.Not.Null);
                Assert.That(Model.name, Is.Not.Null);
                Assert.That(Model.isEmployee, Is.Not.Null);
                Assert.That(Model.oauthClientId, Is.Not.Null);
                Assert.That(Model.subreddit, Is.Not.Null);
                Assert.That(Model.subreddit?.url, Is.Not.Null);

                Assert.That(Model.id, Is.EqualTo("n6xmmoiz"));
                Assert.That(Model.name, Is.EqualTo("myDummyAcc2"));
                Assert.That(Model.isEmployee, Is.EqualTo(false));
                Assert.That(Model.oauthClientId, Is.EqualTo("O6D12dw2USZ2qTP3jFOAkg"));
                Assert.That(Model.subreddit?.url, Is.EqualTo("/user/myDummyAcc2/"));
            }
            catch (Exception)
            {
                throw;
            }                  
        }
    }
}
