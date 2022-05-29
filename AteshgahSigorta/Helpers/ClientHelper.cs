using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AteshgahSigorta.Helpers
{
    public class ClientHelper
    {
        public static string GenerateUniqueClientId()
        {
            Guid g = Guid.NewGuid();
            string guidString = Convert.ToBase64String(g.ToByteArray());
            guidString = guidString.Substring(1,10);

            return guidString;
        }
    }
}
