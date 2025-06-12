using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace MichelMichels.Peppol.Models;

public class SearchResponse
{
    [JsonPropertyName("version")]
    public string Version { get; set; } = string.Empty;

    [JsonPropertyName("total-result-count")]
    public int? TotalResultCount { get; set; }

    [JsonPropertyName("used-result-count")]
    public int? UsedResultCount { get; set; }

    [JsonPropertyName("result-page-index")]
    public int? ResultPageIndex { get; set; }

    [JsonPropertyName("result-page-count")]
    public int? ResultPageCount { get; set; }

    [JsonPropertyName("first-result-index")]
    public int? FirstResultIndex { get; set; }

    [JsonPropertyName("last-result-index")]
    public int? LastResultIndex { get; set; }

    [JsonPropertyName("query-terms")]
    public string QueryTerms { get; set; } = string.Empty;

    [JsonPropertyName("creation-dt")]
    public DateTime? DateCreated { get; set; }

    [JsonPropertyName("matches")]
    public List<Match> Matches { get; set; }
}
