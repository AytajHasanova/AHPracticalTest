using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class LoanDetails
    {
        public string ClientIdAndName { get; set; }
        public string ClientPhoneNumber { get; set; }
        public decimal LoanAmount { get; set; }
        public int LoanPeriod { get; set; }
        public double MonthlyInterestRate { get; set; }
        public string PayoutDate { get; set; }
        public int ClientId { get; set; }
        public int LoanId { get; set; }
    }
}
