using Lab3EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3EF.ViewModel
{
    public class CustomersWithCityViewModel
    {
        public List<City> Cities { get; set; }
        public Customer Customer { get; set; }
    }
}