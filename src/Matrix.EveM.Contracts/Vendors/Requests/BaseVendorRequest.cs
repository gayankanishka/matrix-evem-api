namespace Matrix.EveM.Contracts.Vendors.Requests;

public abstract class BaseVendorRequest
{
    public string Name { get; init; }
    public string? Description { get; init; }
    public string ContactName { get; init; }
    public string ContactNumber { get; init; }
    public string ContactEmail { get; init; }
    public string ServiceType { get; init; }
    public string? Remarks { get; init; }
}