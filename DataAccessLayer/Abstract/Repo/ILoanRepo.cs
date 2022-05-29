using DataAccessLayer.Models;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.Repo
{
    public interface ILoanRepo : IGenericRepo<Loan>
    {
        IEnumerable<AllLoans> FetchLoansOrderByAscending();
        LoanDetails LoanDetails(int clientId, int loanId);
    }
}
