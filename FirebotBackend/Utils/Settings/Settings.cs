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
        internal static string accessToken = "bearer eyJhbGciOiJSUzI1NiIsImtpZCI6IlNIQTI1NjpzS3dsMnlsV0VtMjVmcXhwTU40cWY4MXE2OWFFdWFyMnpLMUdhVGxjdWNZIiwidHlwIjoiSldUIn0.eyJzdWIiOiJ1c2VyIiwiZXhwIjoxNzE3NTcxOTQ1LjYzNDk5MiwiaWF0IjoxNzE3NDg1NTQ1LjYzNDk5MSwianRpIjoiUERDSk00bU5ob0x4WXZCanFVaVVIR2lfV1FDQlpBIiwiY2lkIjoiTzZEMTJkdzJVU1oycVRQM2pGT0FrZyIsImxpZCI6InQyX242eG1tb2l6IiwiYWlkIjoidDJfbjZ4bW1vaXoiLCJsY2EiOjE2NTI2ODg5OTcwMDAsInNjcCI6ImVKeUtWdEpTaWdVRUFBRF9fd056QVNjIiwiZmxvIjo5fQ.VCcpsj-wGqXviSExBnf6aokPP02KVCAkACsrIgX58QsfYFDXNF1Qeb9gtOsCOS8LQOP_bLZR8ZeB_jd55RvQoeLHBdwOajhowbMlNs64jyf5xjyRKS3ycgSMmWSVLcOcr5KM6SFVVp0VJc6GyMnPnvjBHWAakk9CewRDARZq9pCyWMGoxuHQLbS6KV9eY8TQxya9Q-BF8q7n_yrIcHposOpoy17IPdvAOCItWADVp_nz24sG7tMjDpdP3eUjHrE2kGdFQHaGMHjHqFLYyO5F25ahUXtOE_Nnqkzc3li0RKK4ioWntuZIDUr0MN0gSjwBQnhk6VI-taUQ_aqw8p7Y4g";
        internal static string? redirectUri = "https://oauth.pstmn.io/v1/callback";
        internal static string? username = "myDummyAcc2";
        internal static string? password = "12#$56/(";
    }
}
