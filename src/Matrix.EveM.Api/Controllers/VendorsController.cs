using Matrix.EveM.Contracts.Vendors.Requests;
using Matrix.EveM.Contracts.Vendors.Responses;
using Matrix.EveM.Domain.Vendors.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.EveM.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VendorsController : ControllerBase
{
    private readonly IVendorService _vendorService;

    public VendorsController(IVendorService vendorService)
    {
        _vendorService = vendorService;
    }

    [HttpGet]
    [Route("{vendorId:int}", Name = "GetVendorById}")]
    [ProducesResponseType(typeof(VendorDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<VendorDto> GetVendorByIdAsync(int vendorId, CancellationToken cancellationToken = default)
    {
        return await _vendorService.GetVendorByIdAsync(vendorId, cancellationToken);
    }
    
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<VendorDto>), StatusCodes.Status200OK)]
    public async Task<IEnumerable<VendorDto>> GetVendorsAsync(CancellationToken cancellationToken = default)
    {
        return await _vendorService.GetVendorsAsync(cancellationToken);
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateVendorAsync(
        CreateVendorRequest createVendorRequest,
        CancellationToken cancellationToken = default)
    {
        var vendorId = await _vendorService.CreateVendorAsync(createVendorRequest, cancellationToken);
        return Created(Url.RouteUrl("GetVendorById", new { vendorId }), vendorId);
    }
    
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateVendorAsync(
        UpdateVendorRequest updateVendorRequest,
        CancellationToken cancellationToken = default)
    {
        await _vendorService.UpdateVendorAsync(updateVendorRequest, cancellationToken);
        return NoContent();
    }
    
    [HttpDelete]
    [Route("{vendorId:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteVendorAsync(int vendorId, CancellationToken cancellationToken = default)
    {
        await _vendorService.DeleteVendorAsync(vendorId, cancellationToken);
        return NoContent();
    }
}
