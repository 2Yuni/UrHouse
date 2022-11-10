using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrHouse.Domain.Enums;

namespace UrHouse.Domain.Models.Entities
{
    
    public class Apartament : BaseEntity
    {
        public string Name { get; set; }
        public long AddressId { get; set; }
        public Address Address { get; set; }

        public string ShortDescription { get; set; }
        public double Area { get; set; }
        public int NumberOfPeople { get; set; }
        public decimal Price { get; set; }
        public BookingStatus BookingStatus { get; set; }
       
        public long RealtorId   { get; set; }
        public Realtor Realtor { get; set; }

        public ICollection<Booking> Bookings { get; set; }


    }
}
