using MichelMichels.Peppol.Core;
using MichelMichels.Peppol.Models;
using System.Xml.Serialization;

namespace MichelMichels.Peppol;

public class PeppolDirectoryFileParser : IPeppolDirectoryFileParser
{
    public BusinessCardWithoutDocTypeRoot ParseXmlBusinessCardsWithoutDocTypes(Stream source)
    {
        XmlSerializer serializer = new(typeof(BusinessCardWithoutDocTypeRoot));

        object result = serializer.Deserialize(source) ?? throw new NotSupportedException();

        return (BusinessCardWithoutDocTypeRoot)result;
    }
}
