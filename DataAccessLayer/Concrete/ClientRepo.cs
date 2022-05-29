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
    public class ClientRepo : GenericRepo<Client>, IClientRepo
    {

        public ClientRepo(MySqlContext context,
            ILogger logger
           ) 
           
            :base(context, logger)
        {
            
        }

        public IEnumerable<DropdownModel> ClientDropdown()
        {
            List<DropdownModel> dropdownData = new List<DropdownModel>() { new DropdownModel { Id=0, Value = "Seçim edin"} };

            dropdownData.AddRange(_context.Clients
                .Select(x => new DropdownModel { Id = x.Id, Value = $"{x.Name} {x.Surname}" }));
            return dropdownData;
        }

     
    }
}
