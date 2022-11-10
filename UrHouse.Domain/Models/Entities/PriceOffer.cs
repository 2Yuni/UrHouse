using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrHouse.Domain.Models.Entities
{
    public class PriceOffer : BaseEntity
    {
        public decimal NewPrice { get; set; }

        public string PromotionalText { get; set; }

        public int ApartamentId { get; set; }

        public Apartament Appartament { get; set; }
    }
}
