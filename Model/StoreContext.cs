using Microsoft.EntityFrameworkCore;

namespace PagesMariaDB.Models
{
    public partial class StoreContext : DbContext
    {

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }

        public StoreContext(DbContextOptions<StoreContext> opt) : base(opt) { }
    }
}