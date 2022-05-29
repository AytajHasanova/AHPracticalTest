using BusinessLayer.Abstract;
using DataAccessLayer.Abstract.Repo;
using DataAccessLayer.Models;
using EntityLayer.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ClientManager : IClientService
    {
        IClientRepo _clientService;
        ILogger _logger;


        public ClientManager(IClientRepo clientService, ILogger logger)
        {
            _clientService = clientService;
            _logger = logger;
        }

        public IEnumerable<DropdownModel> ClientDropdown()
        {
            return _clientService.ClientDropdown();
        }

        public bool Create(Client entity)
        {
            try
            {
                _clientService.Add(entity);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(ClientManager)} {nameof(Create)} threw an exception.");
            }

            return false;
        }

        public bool Delete(Client entity)
        {
            try
            {
                _clientService.Delete(entity.Id);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(ClientManager)} {nameof(Delete)} threw an exception.");
            }

            return false;

        }

        public IEnumerable<Client> FetchAll()
        {
            try
            {
                return _clientService.All();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(ClientManager)} {nameof(FetchAll)} threw an exception.");
            }

            return new List<Client>();

        }

        public Client GetById(int id)
        {
            try
            {
                return _clientService.GetById(id);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(ClientManager)} {nameof(GetById)} threw an exception.");
            }

            return null;

        }

      

        public bool Save()
        {
           

            try
            {
                _clientService.Save();
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(ClientManager)} {nameof(GetById)} threw an exception.");
            }

            return false;
        }

        public bool Update(Client entity)
        {
            try
            {
                _clientService.Update(entity);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(ClientManager)} {nameof(GetById)} threw an exception.");
            }

            return false;

        }

    }
}
