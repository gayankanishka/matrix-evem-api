using Matrix.EveM.Contracts.Vendors.Requests;
using Matrix.EveM.Contracts.Vendors.Responses;
using Matrix.EveM.Domain.Vendors.Entities;
using Matrix.EveM.Domain.Vendors.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.EveM.Api.Controllers;

/// <summary>
/// The <see cref="VendorsController"/> class defines the API endpoints for <see cref="Vendor"/>.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class VendorsController : ControllerBase
{
    private readonly IVendorService _vendorService;

    public VendorsController(IVendorService vendorService)
    {
        _vendorService = vendorService;
    }

    /// <summary>
    /// The endpoint allows users to retrieve a vendor by it's ID.
    /// </summary>
    /// <param name="vendorId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>A <see cref="Vendor"/>.</returns>
    /// <reposnse code="200">If successful.</reposnse>
    /// <response code="404">If the request is invalid.</response>
    [HttpGet]
    [Route("{vendorId:int}", Name = "GetVendorById}")]
    [ProducesResponseType(typeof(VendorDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<VendorDto> GetVendorByIdAsync(
        [FromRoute] int vendorId,
        CancellationToken cancellationToken = default)
    {
        return await _vendorService.GetVendorByIdAsync(vendorId, cancellationToken);
    }
    
    /// <summary>
    /// The endpoint allows users to retrieve a list of vendors.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>A list of vendors.</returns>
    /// <reposnse code="200">If successful.</reposnse>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<VendorDto>), StatusCodes.Status200OK)]
    public async Task<IEnumerable<VendorDto>> GetVendorsAsync(CancellationToken cancellationToken = default)
    {
        return await _vendorService.GetVendorsAsync(cancellationToken);
    }
    
    /// <summary>
    /// The endpoint allows users to create a new vendor.
    /// </summary>
    /// <param name="createVendorRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <reposnse code="201">If successful</reposnse>
    /// <response code="400">If the request is invalid</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateVendorAsync(
        [FromBody] CreateVendorRequest createVendorRequest,
        CancellationToken cancellationToken = default)
    {
        var vendorId = await _vendorService.CreateVendorAsync(createVendorRequest, cancellationToken);
        return Created($"api/vendors/{vendorId}", vendorId);
    }
    
    /// <summary>
    /// The endpoint allows users to update a vendor by it's ID.
    /// </summary>
    /// <param name="vendorId"></param>
    /// <param name="updateVendorRequest"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <reposnse code="204">If successful</reposnse>
    /// <response code="400">If the request is invalid</response>
    /// <response code="404">If the vehicle feature is not found</response>
    [HttpPut]
    [Route("{vendorId:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> UpdateVendorAsync(
        [FromRoute] int vendorId,
        [FromBody] UpdateVendorRequest updateVendorRequest,
        CancellationToken cancellationToken = default)
    {
        if (vendorId != updateVendorRequest.Id)
        {
            return BadRequest();
        }
        
        await _vendorService.UpdateVendorAsync(updateVendorRequest, cancellationToken);
        return NoContent();
    }
    
    /// <summary>
    /// The endpoint allows users to delete a vendor by it's ID.
    /// </summary>
    /// <param name="vendorId"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <reposnse code="204">If successful</reposnse>
    /// <response code="404">If the vehicle feature is not found</response>
    [HttpDelete]
    [Route("{vendorId:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeleteVendorAsync(
        [FromRoute] int vendorId,
        CancellationToken cancellationToken = default)
    {
        await _vendorService.DeleteVendorAsync(vendorId, cancellationToken);
        return NoContent();
    }
}
