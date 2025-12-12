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
        PeppolDirectoryClient client = new(PeppolDirectoryBaseUrl.Production);
        QueryParameters parameters = new()
        {
            Query = "0897067282",
        };

        // Act
        var result = await client.Search(parameters);

        // Assert
        Assert.HasCount(1, result.Matches);
        Assert.AreEqual("0208:0897067282", result.Matches[0].ParticipantIdentifier.Value);
    }
}
