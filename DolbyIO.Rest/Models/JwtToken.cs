using Newtonsoft.Json;

namespace DolbyIO.Rest.Models;

public sealed class JwtToken
{
    /// <summary>
    /// Gets the access token in JWT format.
    /// </summary>
    [JsonProperty("access_token")]
    public string AccessToken { get; internal set; }

    /// <summary>
    /// Gets the access token expiration time in seconds.
    /// </summary>
    [JsonProperty("expires_in")]
    public int ExpiresIn { get; internal set; }

    /// <summary>
    /// Gets the type of access token.
    /// </summary>
    [JsonProperty("token_type")]
    public string TokenType { get; internal set; }

    // TODO: Commented out due to issue below.

    // If we pass a single scope, we'll get a string, not string array back
    // from the API.
//#nullable enable
//    /// <summary>
//    /// Gets the scope of access token.
//    /// </summary>
//    [JsonProperty("scope")]
//    public string[]? Scope { get; internal set; }
//#nullable disable
}
