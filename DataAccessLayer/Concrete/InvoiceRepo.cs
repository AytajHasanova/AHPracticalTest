using DataAccessLayer.Abstract.Repo;
using DataAccessLayer.AppDbContexts;
using EntityLayer.Concrete;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    class InvoiceRepo : GenericRepo<Invoice>, IInvoiceRepo
    {
        public InvoiceRepo(MySqlContext context,
            ILogger logger)
            : base(context, logger)
        {
            
        }
    }

}
