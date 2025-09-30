using System.Xml.Serialization;

namespace MichelMichels.Peppol.Models;

public class XmlContactType
{
    [XmlAttribute("email")]
    public string? Email { get; set; }

    [XmlAttribute("name")]
    public string? Name { get; set; }

    [XmlAttribute("phonenumber")]
    public string? PhoneNumber { get; set; }

    [XmlAttribute("type")]
    public string? Type { get; set; }
}
