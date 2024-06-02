using RestSharp.Authenticators;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebotBackend.Utils.Settings;
using TechTalk.SpecFlow;

namespace FirebotBackend.APIs
{
    internal class BaseApiTests
    {
        public static RestClient? Client;
        public static RestRequest? Request;
        public static RestResponse? Response;

        //public static void SetBaseUriAndAuth()
        //{
        //    Client = new RestClient(Settings.baseUrl) ;
        //    Client.Authenticator = AuthTwitter();
        //}

        //private static OAuth1Authenticator AuthTwitter()
        //{
        //    OAuth1Authenticator oAuth1Authenticator = OAuth1Authenticator.ForProtectedResource(consumerKey, consumerSecret, accessToken, accessTokenSecret);
        //    return oAuth1Authenticator;
        //}
    }
}
