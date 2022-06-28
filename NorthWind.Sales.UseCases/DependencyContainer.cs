using NorthWind.Sales.UseCases.CreateMathOperation;

namespace NorthWind.Sales.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(
            this IServiceCollection services)
        {
            //services.AddScoped<ICreateOrderInputPort,
            //    CreateOrderInteractor>();

            services.AddScoped<ICreateMathOperationInputPort, 
                CreateMathOperationInteractor>();

            return services;
        }
    }
}
