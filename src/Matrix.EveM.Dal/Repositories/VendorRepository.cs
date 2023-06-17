using Matrix.EveM.Domain.Vendors.Entities;
using Matrix.EveM.Domain.Vendors.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Matrix.EveM.Dal.Repositories;

internal sealed class VendorRepository : IVendorRepository
{
    private readonly ApplicationDbContext _dbContext;

    public VendorRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<Vendor?> GetVendorByIdAsync(int vendorId, CancellationToken cancellationToken = default)
    {
        return _dbContext
            .Vendors
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == vendorId, cancellationToken);
    }

    public async Task<IEnumerable<Vendor>> GetVendorsAsync(CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Vendors
            .AsNoTracking()
            .ToListAsync(cancellationToken);
    }

    public async Task CreateVendorAsync(Vendor vendor, CancellationToken cancellationToken = default)
    {
        await _dbContext.AddAsync(vendor, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateVendorAsync(Vendor vendor, CancellationToken cancellationToken = default)
    {
        _dbContext.Update(vendor);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteVendorAsync(Vendor vendor, CancellationToken cancellationToken = default)
    {
        _dbContext.Remove(vendor);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
