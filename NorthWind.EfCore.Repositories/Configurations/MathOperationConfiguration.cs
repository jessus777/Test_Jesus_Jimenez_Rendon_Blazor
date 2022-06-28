namespace NorthWind.EfCore.Repositories.Configurations
{
    public class MathOperationConfiguration : IEntityTypeConfiguration<MathOperation>
    {
        public void Configure(EntityTypeBuilder<MathOperation> builder)
        {
            builder.Property(b => b.NumberOne).HasPrecision(8, 2);
            builder.Property(b => b.NumberTwo).HasPrecision(8, 2);
        }
    }
}
