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
        internal static string accessToken = "bearer eyJhbGciOiJSUzI1NiIsImtpZCI6IlNIQTI1NjpzS3dsMnlsV0VtMjVmcXhwTU40cWY4MXE2OWFFdWFyMnpLMUdhVGxjdWNZIiwidHlwIjoiSldUIn0.eyJzdWIiOiJ1c2VyIiwiZXhwIjoxNzE3NTgyNzY5LjkzMzEzOCwiaWF0IjoxNzE3NDk2MzY5LjkzMzEzOCwianRpIjoiSlZVZW10TExFdDFGMld1aFVUTmF4b1JWZDZLZF93IiwiY2lkIjoiTzZEMTJkdzJVU1oycVRQM2pGT0FrZyIsImxpZCI6InQyX242eG1tb2l6IiwiYWlkIjoidDJfbjZ4bW1vaXoiLCJsY2EiOjE2NTI2ODg5OTcwMDAsInNjcCI6ImVKeUtWdEpTaWdVRUFBRF9fd056QVNjIiwiZmxvIjo5fQ.o0oKec8CrKUVJWROS58Otqxot60nFqJB7wf_ScgzyFXDCKuhMRCyxdQtNzeYHFXDRojtv2uYV0JZ_Eg7MG7XoPwkzX5U4ZVHOwVnh7oS9-NN7lhJfKbuYP88LRK7p3-4dquEE8WwKLORt3xPjaqJtpDkI04NRMSx-gQ0Vq8O-ManrUGBnjG7G_D3qbYwMy5FLFz5m7iTs6dXKcTkvwwTDAozMrJ8kVxjEVvigGfyFS4twWculACvjCf6zN6C1Okdcq-oeuSioFdPkqarJSCoEaWsaTCvm9yN_RYeb3zlVO8vtz37yLRZ_4FIQFdWHFk1lof8Icajr7IV_AbNzDm0uA";
        internal static string? redirectUri = "https://oauth.pstmn.io/v1/callback";
        internal static string? username = "myDummyAcc2";
        internal static string? password = "12#$56/(";
    }
}
