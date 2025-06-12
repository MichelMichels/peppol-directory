using MichelMichels.Peppol.Models;

namespace MichelMichels.Peppol.Core;

public interface IPeppolDirectoryClient
{
    Task<SearchResponse> Search(QueryParameters parameters);
}
