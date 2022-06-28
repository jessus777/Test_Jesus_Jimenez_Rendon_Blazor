namespace NorthWind.Sales.BusinessObjects.Interfaces.Ports
{
    public interface ICreateMathOperationOutputPort
    {
        ValueTask Handle(string value);
    }
}
