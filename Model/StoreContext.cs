using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PagesMariaDB.Models
{
    public partial class StoreContext : IdentityDbContext
    {

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<WebUser> WebUsers { get; set; }

        public StoreContext(DbContextOptions<StoreContext> opt) : base(opt) { }
    }
}