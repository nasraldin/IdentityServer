using System;
using System.Threading.Tasks;
using IdentityService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace IdentityService.IntegrationTests.Persistence
{
    public class ApplicationDbContextTests : IDisposable
    {
        private readonly ApplicationDbContext _appDb;

        public ApplicationDbContextTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            _appDb = new ApplicationDbContext(options, null);

            _appDb.SaveChanges();
        }

        [Fact]
        public async Task SaveChangesAsync_GivenNewCategory_ShouldSetCreatedProperties()
        {
            await _appDb.SaveChangesAsync();
        }

        public void Dispose()
        {
            _appDb?.Dispose();
        }
    }
}
