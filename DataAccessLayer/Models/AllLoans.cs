using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class AllLoans
    {
        [DisplayName("Client Id")]
        public string ClientUniqueId { get; set; }
        [DisplayName("Client")]
        public string ClientFullName { get; set; }

        [DisplayName("Loan Amount")]
        public decimal LoanAmount { get; set; }
        [DisplayName("Payout Date")]

        public string PayoutDay { get; set; }

        public int ClientId { get; set; }
        public int LoanId { get; set; }
    }
}
