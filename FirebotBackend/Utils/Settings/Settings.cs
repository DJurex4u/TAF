using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirebotBackend.Utils.Settings
{
    internal class Settings
    {
        internal static readonly string baseUrl = "https://oauth.reddit.com";
        internal static readonly string clientId = "O6D12dw2USZ2qTP3jFOAkg";
        internal static readonly string clientSecret = "dx4NAYbnMMm3YtkbCCX1U29adjOiNA";
        internal static readonly string getAccessTokenUrl = "https://www.reddit.com/api/v1/access_token";
        internal static string accessToken = "bearer eyJhbGciOiJSUzI1NiIsImtpZCI6IlNIQTI1NjpzS3dsMnlsV0VtMjVmcXhwTU40cWY4MXE2OWFFdWFyMnpLMUdhVGxjdWNZIiwidHlwIjoiSldUIn0.eyJzdWIiOiJ1c2VyIiwiZXhwIjoxNzE3ODQyNTM5Ljc2NDA1MiwiaWF0IjoxNzE3NzU2MTM5Ljc2NDA1MiwianRpIjoic3ZFVzk2b084Z2RRNEZucWNQTU40X1ZiT2FNSTVBIiwiY2lkIjoiTzZEMTJkdzJVU1oycVRQM2pGT0FrZyIsImxpZCI6InQyX242eG1tb2l6IiwiYWlkIjoidDJfbjZ4bW1vaXoiLCJsY2EiOjE2NTI2ODg5OTcwMDAsInNjcCI6ImVKeUtWdEpTaWdVRUFBRF9fd056QVNjIiwiZmxvIjo5fQ.RqCBiJCZH35vo--w5QGlY2ErsIlzLyZbaiObCneyiM354COhuwn6ZKh3n_64oR9LOQXOVr8DPZb74Oy3oL8AXI7vTSDddec4aKOvVsE-kHCtEvBVE9ZMy_pmrNsdzl7cCD3uCSTWJUKESnIEppqSNVR1KQXzx8JgoaBVS_Uqf2L6Vq5GoGoQxAGJ3F23BIwlFCD-FTBlsII4k13I-dTKR5pz_WpCkT0F5OyPKuuqEZPAtbAWquSI4jxFbFmJTkcds3xkn7KHv6_zgjuAdb1TMqWk--HcMTQhsFTBh37qVyjU3sD1_avIMihLvIhee8W8sRnF43-suEu5gUj0nUhl4g";
        internal static string? redirectUri = "https://oauth.pstmn.io/v1/callback";
        internal static string? username = "myDummyAcc2";
        internal static string? password = "12#$56/(";
    }
}
