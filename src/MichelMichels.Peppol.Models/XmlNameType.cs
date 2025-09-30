using System.Xml.Serialization;

namespace MichelMichels.Peppol.Models;

public class XmlNameType
{
    [XmlAttribute("name")]
    public required string Name { get; set; }

    [XmlAttribute("language")]
    public string? Language { get; set; }
}
