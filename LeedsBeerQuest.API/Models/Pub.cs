using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeedsBeerQuest.API.Models
{
    public class Pub
    {
        public string Name { get; set; }        
        public decimal Lat { get; set; }        
        public decimal Lng { get; set; }
        public string Address { get; set; }
        public string Twitter { get; set; }
        public string Phone { get; set; }
        public string Url { get; set; }
        public string Thumbnail { get; set; }
    }
}
