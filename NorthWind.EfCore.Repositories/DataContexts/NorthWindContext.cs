namespace NorthWind.EfCore.Repositories.DataContexts
{
    // Add-Migration InitialCreate -p NorthWind.EfCore.Repositories -s NorthWind.EfCore.Repositories -c NorthWindContext
    // Update-Database -p NorthWind.EfCore.Repositories -s NorthWind.EfCore.Repositories -context NorthWindContext
    internal class NorthWindContext : DbContext
    {
        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Server=BLACK-HACK\\SQLSERVER;Database=NorthWindDB;Trusted_Connection=True;");

        }
        public DbSet<MathOperation> MathOperations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());
        }
    }
}
