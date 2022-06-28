using NorthWind.Sales.BusinessObjects.DTOs.CreateMathOperation;

namespace NorthWind.Sales.WebApi
{
    public static class Endpoints
    {
        public static WebApplication UseNorthWindSalesEndpoints(
            this WebApplication app)
        {
            //app.MapPost("/create",
            //    async (CreateOrderDTO order,
            //    ICreateOrderController controller) =>
            //    Results.Ok(await controller.CreateOrder(order)));

            app.MapPost("/createMathOperation",
                async (CreateMathOperationDTO mathOperation,
                ICreateMathOperationController controller) =>
                Results.Ok(await controller.CreateMathOperation(mathOperation)));


            return app;
        }
    }
}
