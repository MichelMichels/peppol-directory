using MichelMichels.Peppol;
using MichelMichels.Peppol.Core;
using MichelMichels.Peppol.Models;

namespace MichelMichels.PeppolTests;

[TestClass]
public sealed class PeppolDirectoryClientTests
{
    [TestMethod]
    public async Task Search_Test()
    {
        // Arrange
        PeppolDirectoryClient client = new(PeppolDirectoryBaseUrl.Test);
        QueryParameters parameters = new()
        {
            Query = "iDocta",
        };

        // Act
        var result = await client.Search(parameters);

        // Assert
        Assert.IsTrue(result.Matches.Count > 0);
    }
}
