using Microsoft.EntityFrameworkCore;


namespace Core.Domains
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Category> category { get; set; }
        public virtual DbSet<Product> product { get; set; }
        public virtual DbSet<ProductType> productType { get; set; }

    }
}
