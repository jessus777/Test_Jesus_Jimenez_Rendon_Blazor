namespace NorthWind.EfCore.Repositories.DataContexts
{
    public class NorthWindSalesContext : DbContext
    {
        public NorthWindSalesContext(
            DbContextOptions<NorthWindSalesContext> options) :
            base(options)
        { }

        public DbSet<MathOperation> MathOperations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
    }
}
