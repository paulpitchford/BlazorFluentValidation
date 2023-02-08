using BlazorFluentValidation.Data;
using FluentValidation;

namespace BlazorFluentValidation.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty().WithMessage("You must enter your first name")
                .MaximumLength(50).WithMessage("First name cannot be longer than 50 characters");

            RuleFor(p => p.LastName)
                .NotEmpty().WithMessage("You must enter your last name")
                .MaximumLength(50).WithMessage("First name cannot be longer than 50 characters");

            RuleFor(p => p.Age)
                .NotNull().WithMessage("You must enter your age.")
                .GreaterThanOrEqualTo(1).WithMessage("Your age must be greater than 0.")
                .LessThan(150).WithMessage("Your age must be less than 150.");
        }
    }
}
