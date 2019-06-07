using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfDemo3.Entity
{
    //[Column("Name")]  
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
      
        [StringLength(50)]
        public string CustomerName { get; set; }
        [StringLength(50)]
        public string CustomerLastname { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }

        
        public virtual Category Category { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public int Stock { get; set; }
        [NotMapped]
        public bool isStock { get; set; }
    }

    [Table("Categories")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }

    }

    [Table("Orders")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }


        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
      

    }
}