using FirebotBackend.APIs;
using FirebotBackend.APIs.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebotBackend.Steps.BaseApiScenarioSteps
{
    internal class RedditBaseSteps
    {
        protected IRedditClient? RedditClient { get; set; }
        protected RedditUserResponseModel? RedditUserResponse { get; set; }
        public RestResponse? Response { get; set; }
    }
}
