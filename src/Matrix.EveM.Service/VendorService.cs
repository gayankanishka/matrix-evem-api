using Mapster;
using Matrix.EveM.Contracts.Vendors.Requests;
using Matrix.EveM.Contracts.Vendors.Responses;
using Matrix.EveM.Domain.Vendors.Entities;
using Matrix.EveM.Domain.Vendors.Exceptions;
using Matrix.EveM.Domain.Vendors.Interfaces;

namespace Matrix.EveM.Service;

internal sealed class VendorService : IVendorService
{
    private readonly IVendorRepository _vendorRepository;

    public VendorService(IVendorRepository vendorRepository)
    {
        _vendorRepository = vendorRepository;
    }

    public async Task<VendorDto> GetVendorByIdAsync(int vendorId, CancellationToken cancellationToken = default)
    {
        var vendor = await _vendorRepository.GetVendorByIdAsync(vendorId, cancellationToken);

        if (vendor is null)
        {
            throw new NotFoundException(nameof(Vendor), vendorId);
        }

        return vendor.Adapt<VendorDto>();
    }

    public async Task<IEnumerable<VendorDto>> GetVendorsAsync(CancellationToken cancellationToken = default)
    {
        var vendors = await _vendorRepository.GetVendorsAsync(cancellationToken);
        
        return vendors.Any() ? vendors.Adapt<IEnumerable<VendorDto>>() : Enumerable.Empty<VendorDto>();
    }

    public async Task<int> CreateVendorAsync(CreateVendorRequest createVendorRequest, CancellationToken cancellationToken = default)
    {
        var vendor = createVendorRequest.Adapt<Vendor>();
        await _vendorRepository.CreateVendorAsync(vendor, cancellationToken);
        
        return vendor.Id;
    }

    public async Task UpdateVendorAsync(UpdateVendorRequest updateVendorRequest, CancellationToken cancellationToken = default)
    {
        var vendor = updateVendorRequest.Adapt<Vendor>();
        await _vendorRepository.UpdateVendorAsync(vendor, cancellationToken);
    }

    public async Task DeleteVendorAsync(int vendorId, CancellationToken cancellationToken = default)
    {
        var vendor = await _vendorRepository.GetVendorByIdAsync(vendorId, cancellationToken);

        if (vendor is null)
        {
            throw new NotFoundException(nameof(Vendor), vendorId);
        }

        await _vendorRepository.DeleteVendorAsync(vendor, cancellationToken);
    }
}
