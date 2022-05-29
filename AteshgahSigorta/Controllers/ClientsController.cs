using AteshgahSigorta.Helpers;
using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Validators;
using DataAccessLayer.Abstract.Repo;
using DataAccessLayer.DTOs;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AteshgahSigorta.Controllers
{
    public class ClientsController : Controller
    {
        // IUnitOfWork _work;
        IMapper _mapper;
        IClientService _clientService;
        public ClientsController(IClientService clientService,
            IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(_mapper.Map<IEnumerable<ClientDto>>(_clientService.FetchAll()));
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ClientDto form)
        {
            form.ClientUniqueId = ClientHelper.GenerateUniqueClientId();
            ClientValidator validationRules = new ClientValidator();
            ValidationResult result = validationRules.Validate(form);
            if (result.IsValid)
            {
                
                var model = _mapper.Map<Client>(form);
                if (_clientService.Create(model))
                {
                    _clientService.Save();
                }
                
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
                return View(form);
            }



            return RedirectToAction("Index", "Clients", null);
        }

    }
}
