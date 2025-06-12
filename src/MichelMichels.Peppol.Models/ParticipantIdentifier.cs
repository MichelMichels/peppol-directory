using System.Text.Json.Serialization;

namespace MichelMichels.Peppol.Models;

public class ParticipantIdentifier
{
    [JsonPropertyName("scheme")]
    public string Scheme { get; set; } = string.Empty;

    [JsonPropertyName("value")]
    public string Value { get; set; } = string.Empty;
}
