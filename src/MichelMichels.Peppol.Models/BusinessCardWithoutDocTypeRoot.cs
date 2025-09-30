using System.Xml.Serialization;

namespace MichelMichels.Peppol.Models;

[XmlRoot("root", Namespace = "http://www.peppol.eu/schema/pd/businesscard-generic/201907/")]
public class BusinessCardWithoutDocTypeRoot
{
    [XmlElement(ElementName = "businesscard")]
    public List<BusinessCard> BusinessCards { get; set; } = [];

    [XmlAttribute(AttributeName = "version")]
    public required string Version { get; set; }

    [XmlAttribute(AttributeName = "creationdt")]
    public required DateTime Created { get; set; }
}
