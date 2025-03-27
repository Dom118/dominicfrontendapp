using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using EcommerceFE;
using FeProduct.Services;
using FeUser.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://dominicbackendapp-gvewgradhvbke4fa.eastus2-01.azurewebsites.net") });
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<UserService>();
await builder.Build().RunAsync();
