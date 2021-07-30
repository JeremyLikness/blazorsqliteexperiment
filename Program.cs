using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using blazorsqliteexperiment;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddDbContext<TodoContext>(opt => opt.UseSqlite("Data Source=:memory:"));

await builder.Build().RunAsync();

