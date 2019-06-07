using System;

namespace CodeFirstFluentApiDemo.Entities
{
    public class Order
    {
        public int OrderID { get; set; }

        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }



        public Customer Customer { get; set; }

    }
}