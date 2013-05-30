using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirst.Models
{
    class Address
    {
        public int Id { get; set; }
        public string HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string PostalCode { get; set; }
        public string Town { get; set; }
        public string Country { get; set; }
    }
}
