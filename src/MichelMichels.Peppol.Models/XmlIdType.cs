using System.Xml.Serialization;

namespace MichelMichels.Peppol.Models;

public class XmlIdType
{
    [XmlAttribute("scheme")]
    public string? Scheme { get; set; }

    [XmlAttribute("value")]
    public string? Value { get; set; }
}
