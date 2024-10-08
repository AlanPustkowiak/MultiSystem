using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MultiSystem.Services;
using MultiSystem.Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddScoped<IGameService, ClientGameService>();

await builder.Build().RunAsync();
