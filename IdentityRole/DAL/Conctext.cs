using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityRole.DAL
{
    public class Conctext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-4UM3KTM;initial Catalog=CasgemDbRole;integrated Security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
