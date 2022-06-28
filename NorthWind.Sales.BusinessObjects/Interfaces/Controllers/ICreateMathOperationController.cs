namespace NorthWind.Sales.BusinessObjects.Interfaces.Controllers
{
    public interface ICreateMathOperationController
    {
        ValueTask<string> CreateMathOperation(CreateMathOperationDTO mathOperation);
    }
}
