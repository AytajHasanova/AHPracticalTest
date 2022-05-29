using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs
{ 
    public class LoanDto
    {
        public int Id { get; set; }

        [Range(100, 5000)]
        public double? Amount { get; set; }

        [DisplayName("Interest Rate")]
        public double? InterestRate { get; set; }

        [DisplayName("Loan Period")]
        [Range(3,24)]
        public int? LoanPeriod { get; set; }

        [DisplayName("Payout Date")]
        public DateTime? PayoutDate { get; set; }
        public int? InvoiceId { get; set; }
        [DisplayName("Client")]
        public int ClientId { get; set; }
        public IEnumerable<DropdownModel> Clients { get; set; }
    }
}
