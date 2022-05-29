using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.DTOs
{
    public class ClientDto
    {
        public string ClientUniqueId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TehephoneNr { get; set; }

    }
}
