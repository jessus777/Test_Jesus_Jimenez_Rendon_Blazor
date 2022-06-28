namespace NorthWind.EfCore.Repositories.Repositories
{
    public class NorthWindSalesCommandsRepository :
        INorthWindSalesCommandsRepository
    {
        readonly NorthWindSalesContext Context;

        public NorthWindSalesCommandsRepository(NorthWindSalesContext context)
        {
            Context = context;
        }

        public async ValueTask CreateMathOperation(MathOperation mathOperation)
        {
            await Context.AddAsync(mathOperation);
        }

        public async ValueTask SaveChanges()
        {
            await Context.SaveChangesAsync();
        }
    }
}
