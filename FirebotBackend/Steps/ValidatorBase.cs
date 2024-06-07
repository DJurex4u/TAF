using FirebotBackend.APIs.Models;
using Gherkin;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebotBackend.Steps
{
    public abstract class ValidatorBase : IValidator
    {
        protected ResponseModel? Model { get; set; }

        protected abstract Task ValidateRequestAsync();
        public void Validate()
        {
            ValidateRequestAsync();
        }
    }
}
