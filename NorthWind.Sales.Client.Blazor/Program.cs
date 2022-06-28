using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NorthWind.Sales.Client.Blazor;
using NorthWind.Sales.WebApiGateway;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient<NorthWindSalesApiClient>(HttpClient =>
HttpClient.BaseAddress = new Uri(builder.Configuration["WebApiUri"]));

await builder.Build().RunAsync();
