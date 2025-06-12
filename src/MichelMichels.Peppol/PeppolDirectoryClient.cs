using MichelMichels.Peppol.Core;
using MichelMichels.Peppol.Models;

namespace MichelMichels.Peppol;

public class PeppolDirectoryClient(string baseUrl) : IPeppolDirectoryClient
{
    private readonly string _baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
    private HttpClient? _httpClient;

    public async Task<SearchResponse> Search(QueryParameters parameters)
    {
        // https://directory.peppol.eu/search/1.0/json?q=Austrian+Government&beautify=true
        throw new NotImplementedException();
    }

    private HttpClient GetOrCreateHttpClient()
    {
        return _httpClient ??= new HttpClient
        {
            BaseAddress = new Uri(_baseUrl)
        };
    }
}
