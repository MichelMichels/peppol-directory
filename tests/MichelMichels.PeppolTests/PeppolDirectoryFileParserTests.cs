using MichelMichels.Peppol;
using System.Text;

namespace MichelMichels.PeppolTests;

[TestClass()]
public class PeppolDirectoryFileParserTests
{
    [TestMethod()]
    public void ParseXmlBusinessCardsWithoutDocTypesTest()
    {
        // Arrange
        string xml = """
            <?xml version="1.0" encoding="UTF-8"?>
            <root xmlns="http://www.peppol.eu/schema/pd/businesscard-generic/201907/" version="2" creationdt="2025-09-29T19:52:50.696Z">
              <businesscard>
                <participant scheme="iso6523-actorid-upis" value="0192:815344782" />
                <entity countrycode="NO">
                  <name name="TA-EIENDOM 2 AS" />
                  <regdate>2021-01-04</regdate>
                </entity>
              </businesscard>
              <businesscard>
                <participant scheme="iso6523-actorid-upis" value="0192:930219967" />
                <entity countrycode="NO">
                  <name name="ØRJAN HAUGSVÆR" />
                  <regdate>2022-12-20</regdate>
                </entity>
              </businesscard>
              <businesscard>
                <participant scheme="iso6523-actorid-upis" value="0007:5590700299" />
                <entity countrycode="SE">
                  <name name="Söderorts Bygg &amp; Betong AB" />
                  <id scheme="0007" value="5590700299" />
                  <contact type="" name="" phonenumber="" email="" />
                  <regdate>2022-12-20</regdate>
                </entity>
              </businesscard>
            </root>
            """;
        PeppolDirectoryFileParser context = new();

        // Act
        using MemoryStream ms = new();
        ms.Write(Encoding.UTF8.GetBytes(xml));
        ms.Seek(0, SeekOrigin.Begin);

        Peppol.Models.BusinessCardWithoutDocTypeRoot result = context.ParseXmlBusinessCardsWithoutDocTypes(ms);

        // Assert        
        Assert.AreEqual("2", result.Version);
        Assert.AreEqual(new DateTime(2025, 09, 29, 19, 52, 50, 696), result.Created);
        Assert.HasCount(3, result.BusinessCards);
        Assert.IsNotNull(result.BusinessCards[0].Participant);
        Assert.AreEqual("iso6523-actorid-upis", result.BusinessCards[0].Participant.Scheme);
        Assert.AreEqual("0192:815344782", result.BusinessCards[0].Participant.Value);
        Assert.AreEqual("NO", result.BusinessCards[0].Entities[0].CountryCode);
        Assert.AreEqual("TA-EIENDOM 2 AS", result.BusinessCards[0].Entities[0].Name[0].Name);
        Assert.AreEqual("2021-01-04", result.BusinessCards[0].Entities[0].RegistrationDate);
        Assert.AreEqual("0007", result.BusinessCards[2].Entities[0].Ids[0].Scheme);
        Assert.AreEqual("5590700299", result.BusinessCards[2].Entities[0].Ids[0].Value);
    }
}