using DataAccessLayer.Models;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILoanService : ICrudService<Loan>
    {
        IEnumerable<AllLoans> FetchLoansOrderByAscending();
        LoanDetails LoanDetails(int clientId, int loanId);
    }
}
