using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{ 
    public class InvoiceDTO
    {
        public int Id { get; set; }
        public string Amount { get; set; }
        public DateTime DueDate { get; set; }
        public int InvoiceNr { get; set; }
        public int OrderNr { get; set; }
    }
}
