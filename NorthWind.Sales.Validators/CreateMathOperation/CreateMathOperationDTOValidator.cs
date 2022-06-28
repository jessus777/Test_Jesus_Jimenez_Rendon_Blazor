using NorthWind.Sales.BusinessObjects.DTOs.CreateMathOperation;

namespace NorthWind.Sales.Validators.CreateMathOperation
{
    public class CreateMathOperationDTOValidator : ValidatorWrapper<CreateMathOperationDTO>
    {
        public CreateMathOperationDTOValidator()
        {
            RuleFor(o => o.MathOperationType)
                .NotNull()
                .WithMessage("Debe proporcionar el identificador de la operación.");
        }
    }
}
