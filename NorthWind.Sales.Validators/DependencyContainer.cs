using NorthWind.Sales.BusinessObjects.DTOs.CreateMathOperation;
using NorthWind.Sales.Validators.CreateMathOperation;

namespace NorthWind.Sales.Validators
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddValidators(
            this IServiceCollection services)
        {
            services.AddScoped<Entities.Interfaces
                .IValidator<CreateMathOperationDTO>, CreateMathOperationDTOValidator>();
            return services;
        }
    }
}
