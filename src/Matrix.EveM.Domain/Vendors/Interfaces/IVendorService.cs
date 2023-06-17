using Matrix.EveM.Contracts.Vendors.Requests;
using Matrix.EveM.Contracts.Vendors.Responses;

namespace Matrix.EveM.Domain.Vendors.Interfaces;

public interface IVendorService
{
    Task<VendorDto> GetVendorByIdAsync(int vendorId, CancellationToken cancellationToken = default);
    Task<IEnumerable<VendorDto>> GetVendorsAsync(CancellationToken cancellationToken = default);
    Task<int> CreateVendorAsync(CreateVendorRequest createVendorRequest, CancellationToken cancellationToken = default);
    Task UpdateVendorAsync(UpdateVendorRequest updateVendorRequest, CancellationToken cancellationToken = default);
    Task DeleteVendorAsync(int vendorId, CancellationToken cancellationToken = default);
}
