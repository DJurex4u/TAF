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
        internal static readonly string accessToken = "eyJhbGciOiJSUzI1NiIsImtpZCI6IlNIQTI1NjpzS3dsMnlsV0VtMjVmcXhwTU40cWY4MXE2OWFFdWFyMnpLMUdhVGxjdWNZIiwidHlwIjoiSldUIn0.eyJzdWIiOiJ1c2VyIiwiZXhwIjoxNzE2ODgzNDg2LjU5MzY5NSwiaWF0IjoxNzE2Nzk3MDg2LjU5MzY5NSwianRpIjoiOUhuN2tTWFNSX2M2MGFFT0lscmg4VUdmVktaaDd3IiwiY2lkIjoiTzZEMTJkdzJVU1oycVRQM2pGT0FrZyIsImxpZCI6InQyX242eG1tb2l6IiwiYWlkIjoidDJfbjZ4bW1vaXoiLCJsY2EiOjE2NTI2ODg5OTcwMDAsInNjcCI6ImVKeUtWdEpTaWdVRUFBRF9fd056QVNjIiwiZmxvIjo5fQ.YRxFyK5KUDh9399VHx0yKyu0fMa6y7daVM8Kl9nwO93hlMmFMi4xQE8HAVn2iSmAe3xZowI_D3blWK0HS2-RpCuWmQlNWujZqTbiohiO531wOgPC_iJnY-nl1zowVbfbMc7B9VhFzGLquW-0xrEK3FM-xpdpzRiXmurT8aWQgNMFvBDmxlFNGZinXaJF1vvQKmfgpt5G9cHeksjtYz4cidlOhqmNTL1L1BumignnwrlfHEna_6XIRzf5UTsDmM1dSfH_i_R9UheCzYVMj8ZG94ZeqAtdyGE4lHUrzgMinCT5ggOfuEOVKi_jVuSNp3dcrWiRWyRO1KGC3HCMXeKZQA";
        internal static string? redirectUri = "https://oauth.pstmn.io/v1/callback";
        internal static string? username = "myDummyAcc2";
        internal static string? password = "12#$56/(";
    }
}
