using NorthWind.Sales.BusinessObjects.DTOs.CreateMathOperation;
using NorthWind.Sales.BusinessObjects.Enums;
using NorthWind.Sales.BusinessObjects.POCOEntities;

namespace NorthWind.Sales.UseCases.CreateMathOperation
{
    public class CreateMathOperationInteractor : ICreateMathOperationInputPort
    {
        readonly INorthWindSalesCommandsRepository Repository;
        readonly ICreateMathOperationOutputPort OutputPort;
        readonly IValidator<CreateMathOperationDTO> Validator;

        public CreateMathOperationInteractor(INorthWindSalesCommandsRepository repository, ICreateMathOperationOutputPort outputPort, IValidator<CreateMathOperationDTO> validator)
        {
            Repository = repository;
            OutputPort = outputPort;
            Validator = validator;
        }

        public async ValueTask Handle(CreateMathOperationDTO mathOperation)
        {
            if (!await Validator.Validate(mathOperation))
            {
                string Errors = string.Join(" ",
                    Validator.Failures
                    .Select(kvp => $"{kvp.Key}: {kvp.Value}").ToArray());
                throw new Exception($"Error de validación: {Errors}");
            }

            var resultOperation = ExecuteMathValidation(mathOperation);

            var MathOperation = new MathOperation
            {
                OperationType = (OperationType)mathOperation.MathOperationType,
                NumberOne = mathOperation.NumberOne,
                NumberTwo = mathOperation.NumberTwo,
                Result = resultOperation ,
                NameOperation = Enum.GetName(typeof(OperationType), (OperationType)mathOperation.MathOperationType)
            };

            await Repository.CreateMathOperation(MathOperation);
            await Repository.SaveChanges();
            await OutputPort.Handle(resultOperation);
        }

        static string ExecuteMathValidation(CreateMathOperationDTO mathOperation)
        {
            string result = mathOperation.MathOperationType switch
            {
                (int)OperationType.Addition => OperationAddition(mathOperation.NumberOne, mathOperation.NumberTwo),
                (int)OperationType.Subtraction => OperationSubtraction(mathOperation.NumberOne, mathOperation.NumberTwo),
                (int)OperationType.Multiplication => OperationMultiplication(mathOperation.NumberOne, mathOperation.NumberTwo),
                (int)OperationType.Division => OperationDivision(mathOperation.NumberOne, mathOperation.NumberTwo),
                (int)OperationType.Factorial => OperationFactorial(mathOperation.NumberOne),
                _ => "0",
            };
            return result;
        }

        static string OperationAddition(decimal numberOne, decimal numberTwo)
        {
            var result = numberOne + numberTwo;
            return result.ToString();
        }
        static string OperationSubtraction(decimal numberOne, decimal numberTwo)
        {
            var result = (numberOne - numberTwo);
            return result.ToString();
        }
        static string OperationMultiplication(decimal numberOne, decimal numberTwo)
        {
            var result = numberOne * numberTwo;
            return result.ToString();
        }
        static string OperationDivision(decimal numberOne, decimal numberTwo)
        {
            decimal result;
            if (numberTwo == 0)
            {
                throw new Exception(string.Format(
                     "No se puede dividir. El input 2  tiene un valor de {0}.",
                     numberTwo));
            }
            else
            {
                result = numberOne / numberTwo;
            }

            return result.ToString();
        }

        static string OperationFactorial(decimal numberOne)
        {
            int factorial = 1;
            var roundedNumber = Math.Round(numberOne, 0);
            if (roundedNumber < 0)
            {
                throw new Exception(string.Format(
                     "No se puede obtener el factorial. El input 1 tiene un valor negativo de {0}.",
                     numberOne));
            }
            else
            {
               
                for (int i = 1; i <= roundedNumber; i++)
                {
                    factorial *= i;
                }
            }

            return factorial.ToString();
        }
    }
}
