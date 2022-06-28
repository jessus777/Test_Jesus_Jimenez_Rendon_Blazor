namespace NorthWind.Sales.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(
            this IServiceCollection services)
        {
            
            services.AddScoped<CreateMathOperationPresenter>();

            services.AddScoped<ICreateMathOperationPresenter>
               (provider => provider.GetService<CreateMathOperationPresenter>());

            services.AddScoped<ICreateMathOperationOutputPort>
               (provider => provider.GetService<CreateMathOperationPresenter>());

            return services;
        }
    }
}
