using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrHouse.Domain.Models.Entities
{
    public class Booking : BaseEntity
    {

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        

        public long ApartamentId    { get; set; }
        public Apartament Apartament { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }



    }
}
