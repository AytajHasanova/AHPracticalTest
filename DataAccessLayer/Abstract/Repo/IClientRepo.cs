using DataAccessLayer.Models;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract.Repo
{
    public interface IClientRepo  : IGenericRepo<Client>
    {
        IEnumerable<DropdownModel> ClientDropdown();
    }
}
