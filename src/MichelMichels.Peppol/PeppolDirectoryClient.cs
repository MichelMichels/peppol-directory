using MichelMichels.Peppol.Core;
using MichelMichels.Peppol.Models;
using System.Diagnostics;
using System.Text.Json;

namespace MichelMichels.Peppol;

public class PeppolDirectoryClient(string baseUrl) : IPeppolDirectoryClient
{
    private readonly string _baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
    private HttpClient? _httpClient;

    public async Task<SearchResponse> Search(QueryParameters parameters)
    {
        // https://directory.peppol.eu/search/1.0/json?q=Austrian+Government&beautify=true

        string queryString = ConvertObjectToQueryString(parameters);
        HttpResponseMessage response = await GetOrCreateHttpClient().GetAsync($"search/1.0/json{queryString}");

        if (!response.IsSuccessStatusCode)
        {
            throw new NotSupportedException();
        }

        string json = await response.Content.ReadAsStringAsync();
#if DEBUG
        Debug.WriteLine(json);
#endif

        return JsonSerializer.Deserialize<SearchResponse>(json) ?? throw new NotSupportedException();
    }

    private static string ConvertObjectToQueryString(QueryParameters parameters)
    {
        string queryString = "?";

        if (parameters.Query is not null)
        {
            queryString += $"q={Uri.EscapeDataString(parameters.Query)}&";
        }

        return !queryString.Equals("?") ? queryString : string.Empty;
    }

    private HttpClient GetOrCreateHttpClient()
    {
        return _httpClient ??= new HttpClient
        {
            BaseAddress = new Uri(_baseUrl)
        };
    }
}
