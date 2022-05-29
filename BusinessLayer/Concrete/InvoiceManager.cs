using BusinessLayer.Abstract;
using DataAccessLayer.Abstract.Repo;
using EntityLayer.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class InvoiceManager : IInvoiceService
    {
        IInvoiceRepo _invoiceService;
        ILogger _logger;


        public InvoiceManager(IInvoiceRepo invoiceService, ILogger logger)
        {
            _invoiceService = invoiceService;
            _logger = logger;
        }
        public bool Create(Invoice entity)
        {
            try
            {
                _invoiceService.Add(entity);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(InvoiceManager)} {nameof(Create)} threw an exception.");
            }

            return false;
        }

        public bool Delete(Invoice entity)
        {
            try
            {
                _invoiceService.Delete(entity.Id);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(InvoiceManager)} {nameof(Delete)} threw an exception.");
            }

            return false;

        }

        public IEnumerable<Invoice> FetchAll()
        {
            try
            {
                return _invoiceService.All();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(InvoiceManager)} {nameof(FetchAll)} threw an exception.");
            }

            return new List<Invoice>();

        }

        public Invoice GetById(int id)
        {
            try
            {
                return _invoiceService.GetById(id);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(InvoiceManager)} {nameof(GetById)} threw an exception.");
            }

            return null;

        }

        public bool Save()
        {
            {


                try
                {
                    _invoiceService.Save();
                    return true;
                }
                catch (Exception ex)
                {

                    _logger.LogError(ex, $"{typeof(ClientManager)} {nameof(GetById)} threw an exception.");
                }

                return false;
            }
        }

        public bool Update(Invoice entity)
        {
            try
            {
                _invoiceService.Update(entity);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(ClientManager)} {nameof(Update)} threw an exception.");
            }

            return false;

        }
    }
}
