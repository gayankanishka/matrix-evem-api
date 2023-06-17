using FluentValidation.Results;
using Matrix.EveM.Api.Filters;
using Matrix.EveM.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Matrix.EveM.Api.Controllers;

[ApiController]
[ApiExceptionFilter]
[Route("api/[controller]")]
public class ApiControllorBase : ControllerBase
{
    protected void ThrowValidationException(ValidationResult validationResult)
    {
        List<ValidationFailure> failures = validationResult.Errors.ToList();
        throw new ValidationException(failures);
    }
}
