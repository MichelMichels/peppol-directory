using System.Xml.Serialization;

namespace MichelMichels.Peppol.Models;

public class BusinessCard
{
    [XmlElement("participant")]
    public required Participant Participant { get; set; }

    [XmlElement("entity")]
    public List<XmlEntityType> Entities { get; set; } = [];
}
