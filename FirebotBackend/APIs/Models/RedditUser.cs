namespace FirebotBackend.APIs.Models
{
    public record RedditUser
    {
        string? id { get; }
        string? name { get; }
        string? username { get; }       
    }

    public record TwitterUser(string Id, string Name, string Username);
}