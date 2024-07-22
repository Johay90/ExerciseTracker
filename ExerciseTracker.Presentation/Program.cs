using Microsoft.Extensions.Hosting;

using IHost host = CreateHostBuilder(args).Build();
// var app = host.Services.GetRequiredService<Application>();
// await app.RunAsync();
await host.RunAsync();

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContent, services) =>
        {
            // Register your services here
        });