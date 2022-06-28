using NorthWind.Sales.BusinessObjects.DTOs.CreateMathOperation;

namespace NorthWind.Sales.Controllers
{
    public class CreateMathOperationController : ICreateMathOperationController
    {
        readonly ICreateMathOperationInputPort InputPort;
        readonly ICreateMathOperationPresenter Presenter;

        public CreateMathOperationController(ICreateMathOperationInputPort inputPort, ICreateMathOperationPresenter presenter)
        {
            InputPort = inputPort;
            Presenter = presenter;
        }

        public async ValueTask<string> CreateMathOperation(CreateMathOperationDTO mathOperation)
        {
            await InputPort.Handle(mathOperation);
            return Presenter.Value;
        }
    }
}
