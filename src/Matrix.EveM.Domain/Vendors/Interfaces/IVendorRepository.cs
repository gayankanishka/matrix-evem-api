using Matrix.EveM.Domain.Vendors.Entities;

namespace Matrix.EveM.Domain.Vendors.Interfaces;

public interface IVendorRepository
{
    Task<Vendor?> GetVendorByIdAsync(int vendorId, CancellationToken cancellationToken = default);
    Task<IEnumerable<Vendor>> GetVendorsAsync(CancellationToken cancellationToken = default);
    Task CreateVendorAsync(Vendor vendor, CancellationToken cancellationToken = default);
    Task UpdateVendorAsync(Vendor vendor, CancellationToken cancellationToken = default);
    Task DeleteVendorAsync(Vendor vendor, CancellationToken cancellationToken = default);
}
