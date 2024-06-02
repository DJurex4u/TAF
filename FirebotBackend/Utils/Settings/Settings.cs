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
        internal static string accessToken = "bearer eyJhbGciOiJSUzI1NiIsImtpZCI6IlNIQTI1NjpzS3dsMnlsV0VtMjVmcXhwTU40cWY4MXE2OWFFdWFyMnpLMUdhVGxjdWNZIiwidHlwIjoiSldUIn0.eyJzdWIiOiJ1c2VyIiwiZXhwIjoxNzE3NDEwNTIyLjQwMjQxMywiaWF0IjoxNzE3MzI0MTIyLjQwMjQxMywianRpIjoiamw0Tm1Jck10UU5kbmMwQXNFVlJqQ1g0RmRkdUlnIiwiY2lkIjoiTzZEMTJkdzJVU1oycVRQM2pGT0FrZyIsImxpZCI6InQyX242eG1tb2l6IiwiYWlkIjoidDJfbjZ4bW1vaXoiLCJsY2EiOjE2NTI2ODg5OTcwMDAsInNjcCI6ImVKeUtWdEpTaWdVRUFBRF9fd056QVNjIiwiZmxvIjo5fQ.pf_oDvDDyrANLqDymkGSyN9A1OTEpa3JtKuJD8yOh8VOTODvv2DJCFXIXd97-2ySfKJGwh22kzTpshPG91B8FYf8-H92O39psX3I1VzYbSUXjIiczxdFtLii18L5g1Dx-tvZtQhb6wXEubbQjnoWh-QwQ2tOoA7491io34RPLoXRI-20nILMpMDaXtUUwbvEjWKDzYiQ-UxkKxYc2SjPZXME8lv0n_eLpx7mUSLvzHaxQpzQ8yulKmtxvVTHUzYq25i3eBjlG1TXYJsdPfYRoY25aLx0-Cscj3-eD-TkNnBnjw_j_WFvhdwcVJ7qBWXYBU-tWo1dyMjjq-eOCyVEhQ";
        internal static string? redirectUri = "https://oauth.pstmn.io/v1/callback";
        internal static string? username = "myDummyAcc2";
        internal static string? password = "12#$56/(";
    }
}
