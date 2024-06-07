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
        public RedditValidator(RedditUserResponseModel model) : base(model) { }
        protected override void ValidateRedditUserResponse()
        {  
            foreach (PropertyInfo propertyInfo in Model.GetType().GetProperties())
            {
                Assert.That(propertyInfo, Is.Not.Null);
            }
        }
    }
}
