using IdentityService.Core.Common.Interfaces;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace IdentityService.Infrastructure.Persistence
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;

        public DatabaseInitializer(ApplicationDbContext context, ILogger<DatabaseInitializer> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task SeedAsync()
        {
            //await _context.Database.MigrateAsync().ConfigureAwait(false);
        }
    }
}
