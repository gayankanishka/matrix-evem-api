using FluentValidation;

namespace Matrix.EveM.Contracts.Vendors.Requests;

public class CreateVendorRequestValidator : AbstractValidator<CreateVendorRequest>
{
    public CreateVendorRequestValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.Description)
            .MaximumLength(500);
        
        RuleFor(x => x.ContactName)
            .NotEmpty()
            .MaximumLength(50);
        
        RuleFor(x => x.ContactNumber)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.ContactEmail)
            .NotEmpty()
            .EmailAddress()
            .MaximumLength(50);

        RuleFor(x => x.ServiceType)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.Remarks)
            .MaximumLength(500);
    }
}
