using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public Country CountryId { get; set; }
    }
}
