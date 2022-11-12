using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrHouse.Domain.Models.Entities
{
    public class Review : BaseEntity
    {
        public string VoterName { get; set; }

        public short NumStars { get; set; }

        public string Comment { get; set; }

        public int ApartamentId { get; set; }

        public Apartament Apartament { get; set; }

        public User User { get; set; }
    }
}
