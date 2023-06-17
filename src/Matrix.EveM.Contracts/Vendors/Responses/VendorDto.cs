namespace Matrix.EveM.Contracts.Vendors.Responses;

public record VendorDto(
    int Id,
    string Name,
    string Description,
    string ContactName,
    string ContactNumber,
    string ContactEmail,
    string ServiceType,
    string Remarks);
