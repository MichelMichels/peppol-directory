using System.Text.Json.Serialization;

namespace MichelMichels.Peppol.Models;

public class Match
{
    [JsonPropertyName("participantID")]
    public ParticipantIdentifier ParticipantIdentifier { get; set; } = new();

    [JsonPropertyName("docTypes")]
    public List<DocumentType> DocumentTypes { get; set; } = [];

    [JsonPropertyName("entities")]
    public List<Entity> Entities { get; set; } = [];
}
