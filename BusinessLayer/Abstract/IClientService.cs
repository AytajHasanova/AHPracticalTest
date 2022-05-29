using DataAccessLayer.Models;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IClientService : ICrudService<Client>
    {
        IEnumerable<DropdownModel> ClientDropdown();
    }
}
