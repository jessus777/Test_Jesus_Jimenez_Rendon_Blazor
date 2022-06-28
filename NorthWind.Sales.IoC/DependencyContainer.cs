namespace NorthWind.Sales.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddNorthWindSalesServices(
            this IServiceCollection services,
            IConfiguration configuration,
            string connetionStringName)
        {
            services
                .AddRepositories(configuration, connetionStringName)
                .AddUseCasesServices()
                .AddPresenters()
                .AddNorthWindSalesControllers()
                .AddValidators();

            return services;
        }
    }
}
