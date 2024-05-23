using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Communication
{
    internal class ApiQuery
    {
        private string queryString { get; set; }
        public RestClient restClient;

        public ApiQuery(string queryString)
        {
            this.queryString = queryString ?? throw new ArgumentNullException(nameof(queryString));
        }

        //public Success GET(out RestResponse response, string sUrlParameters = null, Dictionary<string, string> headers = null)
        //{
        //    Success suc = new Success(this);
        //    response = null;
        //    try
        //    {
        //        String sMessageAddon = "";
        //        if (!String.IsNullOrEmpty(sUrlParameters))
        //        {
        //            sMessageAddon += "<h3>URL Parameters:</h3> <br><p>" + sUrlParameters + "</p><br>";
        //        }

        //        if (headers != null)
        //        {
        //            sMessageAddon += "<h3> Request headers:</h3> <br>" + GenerateTableFromDict("Header", "Value", headers);
        //        }

        //        suc.sMessageAddon = sMessageAddon;

        //        if (String.IsNullOrEmpty(this.sAlias))
        //        {
        //            throw new Exception("Query String not declared correctly");
        //        }

        //        string sPath = Path.Combine(APIReferences.CurrentPageContext, sQueryString);
        //        if (!String.IsNullOrEmpty(sUrlParameters))
        //            sPath = Path.Combine(sPath, sUrlParameters);
        //        restClient = new RestClient(sPath);
        //        RestRequest Req = new RestRequest(Method.GET);
        //        if (headers != null)
        //            Req.AddHeaders(headers);

        //        IRestResponse resp = restClient.Execute(Req);
        //        response = new RAFRestResponse(this, resp);
        //        return suc.Finish();
        //    }
        //    catch (Exception ex)
        //    {
        //        response = new RAFRestResponse(ex);
        //        return suc.Finish(ex);
        //    }

        }
    }
