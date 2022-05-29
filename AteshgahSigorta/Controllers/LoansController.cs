using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.DTOs;
using BusinessLayer.Validators;
using DataAccessLayer.Abstract.Repo;
using DataAccessLayer.Models;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;

namespace AteshgahSigorta.Controllers
{
    public class LoansController : Controller
    {
        ILoanService _loanService;
        IClientService _clientService;
        IMapper _mapper;

        public LoansController(ILoanService service, IClientService clientService,
        IMapper mapper)
        {
            _mapper = mapper;
            _loanService = service;
            _clientService = clientService;
        }
        public IActionResult Index()
        {
            var data = _mapper.Map<IEnumerable<AllLoans>>(_loanService.FetchLoansOrderByAscending());
            return View(data);
        }

        public IActionResult Create()
        {
            var model = new LoanDto() { Clients = _clientService.ClientDropdown() };
            return View(model); ;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LoanDto form)
        {
            LoanValidator validationRules = new LoanValidator();
            ValidationResult result = validationRules.Validate(form);
            if (result.IsValid)
            {

                var model = _mapper.Map<Loan>(form);
                _loanService.Create(model);
                _loanService.Save();
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                form.Clients = _clientService.ClientDropdown();
                return View(form);
            }



            return RedirectToAction("Index","Loans",null);
        }


      

    }
}
