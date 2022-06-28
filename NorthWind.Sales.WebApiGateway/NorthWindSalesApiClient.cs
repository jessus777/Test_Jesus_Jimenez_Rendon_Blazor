namespace NorthWind.Sales.WebApiGateway
{
    public class NorthWindSalesApiClient
    {
        const string CreateOrderEndpoint = "createMathOperation";
        readonly HttpClient HttpClient;

        public NorthWindSalesApiClient(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public async Task<string> CreateMathOperationAsync(CreateMathOperationDTO mathOperationDTO)
        {
            string Value = "";
            var Response = await HttpClient.PostAsJsonAsync(
                CreateOrderEndpoint, mathOperationDTO);

            if (Response.IsSuccessStatusCode)
            {
                Value = await Response.Content.ReadFromJsonAsync<string>();
            }
            return Value;
        }
    }
}
