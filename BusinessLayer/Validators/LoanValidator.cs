using BusinessLayer.DTOs;
using DataAccessLayer.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validators
{
    public class LoanValidator : AbstractValidator<LoanDto>
    {
        public LoanValidator()
        {
            RuleFor(c => c.Amount).NotEmpty().WithMessage("Please fill in")
                .WithMessage("Name cannot exceed 50 characters.");
            RuleFor(c => c.ClientId).NotEmpty().WithMessage("Please fill in");
            RuleFor(c => c.PayoutDate).NotEmpty().WithMessage("Please fill in");
            RuleFor(c => c.InterestRate).NotEmpty().WithMessage("Please fill in");
            RuleFor(c => c.LoanPeriod).NotEmpty().WithMessage("Please fill in");
        }
    }
}
