using MichelMichels.Peppol.Models;

namespace MichelMichels.Peppol.Core;

public interface IPeppolDirectoryFileParser
{
    BusinessCardWithoutDocTypeRoot ParseXmlBusinessCardsWithoutDocTypes(Stream source);
}
