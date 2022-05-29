using AutoMapper;
using DataAccessLayer.Abstract.Repo;
using DataAccessLayer.AppDbContexts;
using DataAccessLayer.Models;
using EntityLayer.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class LoanRepo :  GenericRepo<Loan>, ILoanRepo
    {
      
        public LoanRepo(MySqlContext context,
            ILogger logger
          )
            : base(context, logger)
        {
            
        }

        public IEnumerable<AllLoans> FetchLoansOrderByAscending()
        {
            var result = from c in _context.Clients
                         join l in _context.Loans on c.Id equals l.ClientId
                         select new AllLoans
                         {
                             ClientId = c.Id,
                             LoanId = l.Id,
                             ClientUniqueId = c.ClientUniqueId,
                             ClientFullName = $"{c.Name} {c.Surname}",
                             LoanAmount = l.Amount,
                             PayoutDay = l.PayoutDate.ToShortDateString()
                         };
            var loans = result.OrderByDescending(l => l.LoanAmount).ToList();
            return loans;
        }

        public LoanDetails LoanDetails(int clientId, int loanId)
        {
            var result = from c in _context.Clients
                         join l in _context.Loans on c.Id equals l.ClientId
                         select new LoanDetails
                         {
                             ClientId = c.Id,
                             LoanId = l.Id,
                             ClientIdAndName = $"{c.ClientUniqueId}|{c.Name} {c.Surname}",
                             ClientPhoneNumber = $"{c.TehephoneNr}",
                             LoanAmount = l.Amount,
                             PayoutDate = l.PayoutDate.ToShortDateString(),
                             LoanPeriod = l.LoanPeriod,
                             MonthlyInterestRate = l.InterestRate
                         };
            var loan = result.Where(x => x.ClientId == clientId && x.LoanId == loanId).FirstOrDefault();
            return loan;
        }

    }
}
