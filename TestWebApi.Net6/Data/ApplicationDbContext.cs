namespace TestWebApi.Net6.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.ProductId, x.CategoryId });
        }
        public DbSet<Product> products => Set<Product>();
        public DbSet<Category> categories => Set<Category>();
        public DbSet<Customer> customers => Set<Customer>();
        public DbSet<Order> orders => Set<Order>();
        public DbSet<ProductCategory> productCategories => Set<ProductCategory>();

    }
}

