﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebotBackend.APIs.Models;

namespace FirebotBackend.APIs
{
    internal interface IRedditClient
    {
        Task<RedditUser> GetUser(string user);
    }
}
