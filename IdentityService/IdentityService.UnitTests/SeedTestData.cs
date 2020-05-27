using IdentityService.Core.Interfaces;
using IdentityService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IdentityService.UnitTests
{
    public static class SeedTestData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var dbContext = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>(), serviceProvider.GetRequiredService<IDomainEventDispatcher>());

            //// Look for any items.
            //if (dbContext.SomeEntity.Any())
            //{
            //    return; // DB has been seeded
            //}

            PopulateTestData(dbContext);
        }

        public static void PopulateTestData(ApplicationDbContext dbContext)
        {
            // reset
            //dbContext.RemoveRange(dbContext.SomeEntity, dbContext.SomeEntity2);
            //dbContext.SaveChanges();

            // add
            //dbContext.SomeEntity.AddRange(someEntity);
            dbContext.SaveChanges();
        }
    }

}
