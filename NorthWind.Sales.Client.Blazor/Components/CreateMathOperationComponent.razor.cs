

namespace NorthWind.Sales.Client.Blazor.Components
{
    public partial class CreateMathOperationComponent
    {
        InputNumber<decimal> refInput1;
        InputNumber<decimal> refInput2;
        [Inject]
        public NorthWindSalesApiClient Client { get; set; }
        [Parameter]
        public CreateMathOperationDTO MathOperation { get; set; }

        public string ClassValidatorNumber1 { get; set; }
        public string ClassValidatorNumber2 { get; set; }

        public string ErrorNumber1 { get; set; }
        public string ErrorNumber2 { get; set; }
        public string ErrorProccess { get; set; } = null;
        string Message;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await refInput1.Element.Value.FocusAsync();
            }
        }


        private async Task SendAdd(MouseEventArgs e, int typeOperation = 1)
        {
            ErrorProccess = null;
            Message = "";
            MathOperation.MathOperationType = typeOperation;
            var proccessOperation = OperationTypeMessage(MathOperation.MathOperationType);
            var Result = await Client.CreateMathOperationAsync(MathOperation);
            MathOperation.NumberOne = typeOperation == (int)OperationType.Factorial ? Math.Round(MathOperation.NumberOne, 0) : MathOperation.NumberOne;
            if (string.IsNullOrEmpty(Result))
            {
                ErrorProccess = "Error: No se pudo procesar";
                Message = string.Format(proccessOperation, MathOperation.NumberOne, MathOperation.NumberTwo, ErrorProccess);
            }
            else
            {
                Message = string.Format(proccessOperation, MathOperation.NumberOne, MathOperation.NumberTwo, Result);
            }
            

        }

        private static string OperationTypeMessage(int typeOperation)
        {
            string operation = typeOperation switch
            {
                (int)OperationType.Addition => "{0} + {1} =  {2}",
                (int)OperationType.Subtraction => "{0} - {1} =  {2}",
                (int)OperationType.Division => "{0} / {1} =  {2}",
                (int)OperationType.Multiplication => "{0} * {1} =  {2}",
                (int)OperationType.Factorial => "{0} ! =  {2}",
                _ => "{0}",
            };
            return operation;
        }

    }

    public enum OperationType
    {
        Addition = 1,
        Subtraction = 2,
        Division = 3,
        Multiplication = 4,
        Factorial = 5
    }
}
