using System.Text.Json.Serialization;

namespace MichelMichels.Peppol.Models;

public class Name
{
    [JsonPropertyName("name")]
    public string Value { get; set; } = string.Empty;

    [JsonPropertyName("language")]
    public string Language { get; set; } = string.Empty;
}
