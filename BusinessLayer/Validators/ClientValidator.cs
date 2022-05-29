using DataAccessLayer.DTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    public class ClientValidator : AbstractValidator<ClientDto>
    {
        public ClientValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage("Please fill in")
                .MaximumLength(50).WithMessage("Name cannot exceed 50 characters.");

            RuleFor(c => c.Surname).NotEmpty().WithMessage("Please fill in")
                .MaximumLength(50).WithMessage("Surname cannot exceed 50 characters.");

            RuleFor(c => c.TehephoneNr).NotEmpty().WithMessage("Please fill in");
        }
    }
}
