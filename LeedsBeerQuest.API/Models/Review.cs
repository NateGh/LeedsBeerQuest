using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeedsBeerQuest.API.Models
{
    public class Review
    {
        public DateTime Date { get; set; }
        public string Excerpt { get; set; }
        public decimal BeerStars { get; set; }
        public decimal AtmosphereStars { get; set; }
        public decimal AmenitiesStars { get; set; }
        public decimal ValueStars { get; set; }

    }
}
