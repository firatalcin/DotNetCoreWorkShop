namespace CodeFirst.Models
{
    public class AppUserDetail : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int AppUserId { get; set; }

        // Relational Property

        public AppUser AppUser { get; set; }
    }
}
