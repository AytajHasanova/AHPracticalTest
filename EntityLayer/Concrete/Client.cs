using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Client : BaseEntity
    {
        public string ClientUniqueId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TehephoneNr { get; set; }

    }
}
