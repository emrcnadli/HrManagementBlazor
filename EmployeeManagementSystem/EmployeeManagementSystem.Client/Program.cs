using EmployeeManagementSystem.Client;
using EmployeeManagementSystem.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register EmployeeService
builder.Services.AddScoped<EmployeeService>(sp => new EmployeeService(sp.GetRequiredService<HttpClient>()));

await builder.Build().RunAsync();
