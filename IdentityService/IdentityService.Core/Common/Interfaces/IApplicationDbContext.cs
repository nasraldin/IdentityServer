using System.Threading;
using System.Threading.Tasks;

namespace IdentityService.Core.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        //DbSet<Entity> Entity { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
