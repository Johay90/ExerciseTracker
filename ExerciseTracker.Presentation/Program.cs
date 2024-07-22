using ExerciseTracker.DataAccess.EFCore;
using ExerciseTracker.Presentation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = CreateHostBuilder(args).Build();
var app = host.Services.GetRequiredService<Application>();
app.Run();
await host.RunAsync();

static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContent, services) =>
        {
            IConfiguration configuration = hostContent.Configuration;

                // Register your DbContext
                services.AddDbContext<ExerciseDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        });