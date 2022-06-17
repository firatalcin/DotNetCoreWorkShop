using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentity.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public DateTime CreatedTime { get; set; }
    }
}