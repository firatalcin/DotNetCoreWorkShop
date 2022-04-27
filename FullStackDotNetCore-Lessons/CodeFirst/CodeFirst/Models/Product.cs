namespace CodeFirst.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int CategoryId { get; set; }

        // Relational Propery

        public virtual Category Category { get; set; }
    }
}
