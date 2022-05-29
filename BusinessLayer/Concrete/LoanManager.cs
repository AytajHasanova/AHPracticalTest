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
    public class LoanManager : ILoanService
    {
        ILoanRepo _loanService;
        ILogger _logger;


        public LoanManager(ILoanRepo loanService, ILogger logger)
        {
            _loanService = loanService;
            _logger = logger;
        }
        public bool Create(Loan entity)
        {
            try
            {
                _loanService.Add(entity);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(LoanManager)} {nameof(Create)} threw an exception.");
            }

            return false;
        }

        public bool Delete(Loan entity)
        {
            try
            {
                _loanService.Delete(entity.Id);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(LoanManager)} {nameof(Delete)} threw an exception.");
            }

            return false;
            
        }

        public IEnumerable<Loan> FetchAll()
        {
            try
            {
                return _loanService.All();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(LoanManager)} {nameof(FetchAll)} threw an exception.");
            }

            return new List<Loan>();
           
        }

        public IEnumerable<AllLoans> FetchLoansOrderByAscending()
        {
            return _loanService.FetchLoansOrderByAscending();
        }

        public Loan GetById(int id)
        {
            try
            {
                return _loanService.GetById(id);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(LoanManager)} {nameof(GetById)} threw an exception.");
            }

            return null;
           
        }

        public LoanDetails LoanDetails(int clientId, int loanId)
        {
            return _loanService.LoanDetails(clientId,loanId);
        }

        public bool Save()
        {
            {


                try
                {
                    _loanService.Save();
                    return true;
                }
                catch (Exception ex)
                {

                    _logger.LogError(ex, $"{typeof(ClientManager)} {nameof(GetById)} threw an exception.");
                }

                return false;
            }
        }

        public bool Update(Loan entity)
        {
            try
            {
                _loanService.Update(entity);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"{typeof(LoanManager)} {nameof(Update)} threw an exception.");
            }

            return false;
            
        }

      
    }
}
