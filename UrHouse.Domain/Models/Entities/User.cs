using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UrHouse.Domain.Enums;
using System.Threading.Tasks;

namespace UrHouse.Domain.Models.Entities
{
    
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long TelephoneNumber { get; set; }
        public UserStatus UserStatus { get; set; }
        public ICollection<Booking> Bookings { get; set; }

    }
}  