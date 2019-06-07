using System;
using System.Collections.Generic;

namespace CodeFirstFluentApiDemo.Entities
{
    public class Customer:BaseEntity
    {
        public int CustomerID { get; set; }
        public string ContactName { get; set; }

        public string CompanyName { get; set; }
        public string CityCode { get; set; }


        public string Country { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }


        public List<Order> Orders { get; set; }
    }

    public abstract class BaseEntity
    {
        public DateTime CreateDate { get; set; }
    }
}