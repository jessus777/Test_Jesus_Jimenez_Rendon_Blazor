namespace NorthWind.Sales.BusinessObjects.Interfaces.Ports
{
    public interface ICreateMathOperationInputPort
    {
        ValueTask Handle(CreateMathOperationDTO mathOperation);
    }
}
