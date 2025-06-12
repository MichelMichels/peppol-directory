namespace MichelMichels.Peppol.Models;

public class QueryParameters
{
    public string? Query { get; set; }
    public string? Participant { get; set; }
    public string? Name { get; set; }
    public string? Country { get; set; }
    public string? GeographicalInformation { get; set; }
    public string? IdentifierScheme { get; set; }
    public string? IdentifierValue { get; set; }
    public string? Website { get; set; }
    public string? Contact { get; set; }
    public string? AdditionalInformation { get; set; }
    public DateOnly? RegistrationDate { get; set; }
    public string? DocumentType { get; set; }
    public int? ResultPageIndex { get; set; }
    public int? ResultPageCount { get; set; }
}
