using System.Text.Json.Serialization;

namespace MichelMichels.Peppol.Models;

public class Entity
{
    [JsonPropertyName("name")]
    public List<Name> Name { get; set; } = [];

    [JsonPropertyName("countryCode")]
    public string CountryCode { get; set; } = string.Empty;

    [JsonPropertyName("websites")]
    public List<string> Websites { get; set; } = [];

    [JsonPropertyName("additionalInfo")]
    public string AdditionalInfo { get; set; } = string.Empty;

    [JsonPropertyName("regDate")]
    public string RegistrationDate { get; set; } = string.Empty;

    [JsonPropertyName("geoInfo")]
    public string GeographicalInformation { get; set; } = string.Empty;

    [JsonPropertyName("identifiers")]
    public List<Identifier> Identifiers { get; set; } = [];
}
