using NorthWind.Sales.IoC;

namespace NorthWind.Sales.WebApi
{
    public static class WebApplicationHelper
    {
        public static WebApplication CreateWebApplication(
            this WebApplicationBuilder builder)
        {
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddNorthWindSalesServices(
                builder.Configuration, "NorthWindDB");

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(config =>
                {
                    config.AllowAnyMethod();
                    config.AllowAnyOrigin();
                    config.AllowAnyHeader();
                });
            });

            return builder.Build();
        }

        public static WebApplication ConfigureWebApplication(
            this WebApplication app)
        {
            if(app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseNorthWindSalesEndpoints();

            app.UseCors();
            return app;
        }
    }
}
