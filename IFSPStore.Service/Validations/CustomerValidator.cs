using FluentValidation;
using IFSPStore.Domain.Entities;

namespace IFSPStore.Service.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() {
            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Nome do cliente obrigatório!");
            RuleFor(c => c.Address)
                .NotEmpty().WithMessage("Endereço do cliente obrigatório!");
            RuleFor(c => c.Document)
                .NotEmpty().WithMessage("Documento do cliene obrigatório!")
                .MaximumLength(20).WithMessage("Customer document must not exceed 20 characters.");
            RuleFor(c => c.District)
                .NotEmpty().WithMessage("Customer district is required.")
                .MaximumLength(100).WithMessage("Customer district must not exceed 100 characters.");
            RuleFor(c => c.City)
                .NotNull().WithMessage("Customer city is required.");


        }
    }
}
