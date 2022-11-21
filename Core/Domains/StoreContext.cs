using Microsoft.EntityFrameworkCore;


namespace Core.Domains
{
    public class StoreContext: DbContext
    {
        public StoreContext(DbContextOptions options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-OMKQAFS;Database=Store;Trusted_Connection=True;");
        //}

        
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }

    }
}
