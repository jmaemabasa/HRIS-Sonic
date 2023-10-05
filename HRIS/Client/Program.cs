global using HRIS.Shared;
global using System.Net.Http.Json;
global using HRIS.Shared.MasterData;
global using HRIS.Client.Services.Master_Data_Service.DivisionService;
using HRIS.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddMudBlazorDialog();


//INTERFACES
builder.Services.AddScoped<IDivisionService, DivisionService>();

await builder.Build().RunAsync();
