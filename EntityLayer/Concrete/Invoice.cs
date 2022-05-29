using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Invoice : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public int InvoiceNr { get; set; }
        public int OrderNr { get; set; }
    }
}
