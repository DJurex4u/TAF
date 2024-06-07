using FirebotBackend.APIs;
using FirebotBackend.APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebotBackend.Steps.BaseApiScenarioSteps
{
    internal class RedditBaseSteps
    {
        protected IRedditClient? RedditClient;
        protected RedditUserResponseModel? RedditUserResponse;
    }
}
