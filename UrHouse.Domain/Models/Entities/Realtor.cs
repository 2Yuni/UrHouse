using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrHouse.Domain.Models.Entities
{
    public class Realtor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long TelephoneNumber { get; set; }
        public  ICollection<Apartament> Apartaments { get; set; }

        
    }
}
