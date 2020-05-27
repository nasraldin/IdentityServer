//using IdentityService.Core.Common.Interfaces;
//using IdentityService.Core.Interfaces;
//using IdentityService.Infrastructure.Persistence;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;
//using System;

//namespace IdentityService.UnitTests
//{
//    public class CustomWebApplicationFactory<TStartup>
//        : WebApplicationFactory<TStartup> where TStartup : class
//    {
//        protected override void ConfigureWebHost(Microsoft.AspNetCore.Hosting.IWebHostBuilder builder)
//        {
//            builder
//                .ConfigureServices(services =>
//                {
//                    // Create a new service provider.
//                    var serviceProvider = new ServiceCollection()
//                        .AddEntityFrameworkInMemoryDatabase()
//                        .BuildServiceProvider();

//                    // Add a database context using an in-memory 
//                    // database for testing.
//                    services.AddDbContext<ApplicationDbContext>(options =>
//                    {
//                        options.UseInMemoryDatabase("InMemoryDbForTesting");
//                        options.UseInternalServiceProvider(serviceProvider);
//                    });

//                    services.AddScoped<IDomainEventDispatcher, NoOpDomainEventDispatcher>();

//                    var sp = services.BuildServiceProvider();

//                    services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());


//                    // Create a scope to obtain a reference to the database
//                    using var scope = sp.CreateScope();
//                    var scopedServices = scope.ServiceProvider;
//                    var context = scopedServices.GetRequiredService<ApplicationDbContext>();
//                    var logger = scopedServices.GetRequiredService<ILogger<CustomWebApplicationFactory<TStartup>>>();

//                    // Ensure the database is created.
//                    context.Database.EnsureCreated();

//                    try
//                    {
//                        // Seed the database with test data.
//                        SeedTestData.PopulateTestData(context);
//                    }
//                    catch (Exception ex)
//                    {
//                        logger.LogError(ex, "An error occurred seeding the " +
//                            $"database with test messages. Error: {ex.Message}");
//                    }
//                }).UseEnvironment("Test");
//        }
//    }
//}
