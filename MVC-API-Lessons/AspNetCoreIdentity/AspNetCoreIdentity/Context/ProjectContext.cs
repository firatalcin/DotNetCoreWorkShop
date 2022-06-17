using AspNetCoreIdentity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentity.Context
{
    public class ProjectContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {
        }
    }
}