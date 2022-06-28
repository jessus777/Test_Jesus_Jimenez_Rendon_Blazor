
namespace NorthWind.Sales.BusinessObjects.Interfaces.Presenters
{
    public interface ICreateMathOperationPresenter  : ICreateMathOperationOutputPort
    {
        string Value { get; }
    }
}
