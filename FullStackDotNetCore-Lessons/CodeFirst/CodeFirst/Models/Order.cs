namespace CodeFirst.Models
{
    public class Order : BaseEntity
    {
        public int AppUserId { get; set; }


        // Relational Property
        public virtual AppUser AppUser { get; set; }
    }
}
