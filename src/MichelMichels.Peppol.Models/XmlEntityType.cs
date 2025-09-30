using System.Xml.Serialization;

namespace MichelMichels.Peppol.Models;

public class XmlEntityType
{
    [XmlAttribute("countrycode")]
    public required string CountryCode { get; set; }

    [XmlElement("name")]
    public List<XmlNameType> Name { get; set; } = [];

    [XmlElement("geoinfo")]
    public List<string> GeoInfo { get; set; } = [];

    [XmlElement("id")]
    public List<XmlIdType> Ids { get; set; } = [];

    [XmlElement("website")]
    public List<string> Websites { get; set; } = [];

    [XmlElement("contact")]
    public List<XmlContactType> Contacts { get; set; } = [];

    [XmlElement("additionalinfo")]
    public List<string> AdditionalInfo { get; set; } = [];

    [XmlElement("regdate")]
    public string? RegistrationDate { get; set; }
}
