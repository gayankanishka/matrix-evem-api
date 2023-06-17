using Matrix.EveM.Domain.Common;

namespace Matrix.EveM.Domain.Vendors.Entities;

/// <summary>
/// The vendor entity.
/// </summary>
public class Vendor : BaseEntity
{
    /// <summary>
    /// The name of the vendor.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// A description about vendor.
    /// </summary>
    public string? Description { get; set; }
    
    /// <summary>
    /// The vendor's contact person name.
    /// </summary>
    public string ContactName { get; set; }
    
    /// <summary>
    /// The vendor's contact person number.
    /// </summary>
    public string ContactNumber { get; set; }
    
    /// <summary>
    /// The vendor's contact person email address.
    /// </summary>
    public string ContactEmail { get; set; }
    
    /// <summary>
    /// The service type provided by the vendor.
    /// </summary>
    public string ServiceType { get; set; }
    
    /// <summary>
    /// Additional comments about the vendor.
    /// </summary>
    public string? Remarks { get; set; }
}
