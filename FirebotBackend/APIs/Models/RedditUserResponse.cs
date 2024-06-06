using System.Text.Json.Serialization;

namespace FirebotBackend.APIs.Models
{
    public record RedditUserResponse
    {
        
        public string? id { get; init; }
        
        public string? name { get; init; }

        [JsonPropertyName("oauth_client_id")]
        public string? oauthClientId { get; init; }
        [JsonPropertyName("is_employee")]
        public bool? isEmployee { get; init; }

        public Subreddit? subreddit { get; init; }        
    }
    public class Subreddit
    {
        [JsonPropertyName("url")]
        public string? url { get; init; }
    }

    public record TwitterUser(string Id, string Name, string Username);
}