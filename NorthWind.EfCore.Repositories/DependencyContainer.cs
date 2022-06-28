namespace NorthWind.EfCore.Repositories
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services,
            IConfiguration configuration,
            string connetionStringName)
        {
            services.AddDbContext<NorthWindSalesContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString(connetionStringName)));

            services.AddScoped<INorthWindSalesCommandsRepository,
                NorthWindSalesCommandsRepository>();

            return services;
        }
    }
}
