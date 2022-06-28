namespace NorthWind.Sales.BusinessObjects.Interfaces.Repositories
{
    public interface INorthWindSalesCommandsRepository : IUnitOfWork
    {
  
        ValueTask CreateMathOperation(MathOperation mathOperation);

    }
}

