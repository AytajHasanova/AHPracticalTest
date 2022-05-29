using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Loan : BaseEntity
    {
        public decimal Amount { get; set; }
        public double InterestRate { get; set; }

        public int LoanPeriod { get; set; }
        public DateTime PayoutDate { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int InvoiceId { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
