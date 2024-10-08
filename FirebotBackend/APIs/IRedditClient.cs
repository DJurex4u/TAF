﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using FirebotBackend.APIs.Models;
using FirebotBackend.Steps.BaseApiScenarioSteps;

namespace FirebotBackend.APIs
{
    internal interface IRedditClient
    {
        Task<RedditUserResponseModel> GetUser(string user);
        Task<RedditUserResponseModel> GetMe(RedditBaseSteps steps);
    }
}
