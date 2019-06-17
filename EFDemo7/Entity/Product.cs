namespace EFDemo7.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}