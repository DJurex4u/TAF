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
        internal static string accessToken = "bearer eyJhbGciOiJSUzI1NiIsImtpZCI6IlNIQTI1NjpzS3dsMnlsV0VtMjVmcXhwTU40cWY4MXE2OWFFdWFyMnpLMUdhVGxjdWNZIiwidHlwIjoiSldUIn0.eyJzdWIiOiJ1c2VyIiwiZXhwIjoxNzE3ODc1NTY1LjUzNDM1NiwiaWF0IjoxNzE3Nzg5MTY1LjUzNDM1NiwianRpIjoiVVRYaTZySTNONG5PTUxOSUxPVTUxWTVTXzVJWkRBIiwiY2lkIjoiTzZEMTJkdzJVU1oycVRQM2pGT0FrZyIsImxpZCI6InQyX242eG1tb2l6IiwiYWlkIjoidDJfbjZ4bW1vaXoiLCJsY2EiOjE2NTI2ODg5OTcwMDAsInNjcCI6ImVKeUtWdEpTaWdVRUFBRF9fd056QVNjIiwiZmxvIjo5fQ.EorBWcPFaGBnC8Y5PINaQ-giGAxiBprf6LMpXb3jSYcfaWNm12XUrHqxeV_I3zPQBtDwGMW5r3Xn-OZGHX9iG8f9NFEGFa7iKK5ZIxC4CZQhD6M1l7SMLGjlkOyXVCQygdtg_vGQPT1xGQpWO2Raax_8eqZVNJFtQmd5s3YWJHgazvbOg8Vj65FQqUqhUN63EMhRYkK1ASkwfAacJT_PnJzN0sZq6egeDJ52xENCiWmZV2KsbEh6M7Ghmd-yi8ebUOB1QmRVgYoObg7l7assof6BcshHox3KbRNn3-88D6_ULaMhEu9nwDbjmmrDXRgu0WGsQZsFjeBgrZTkFczcxQ";
        internal static string? redirectUri = "https://oauth.pstmn.io/v1/callback";
        internal static string? username = "myDummyAcc2";
        internal static string? password = "12#$56/(";
    }
}
