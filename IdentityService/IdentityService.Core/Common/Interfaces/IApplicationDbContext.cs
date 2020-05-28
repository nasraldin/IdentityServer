using System.Threading;
using System.Threading.Tasks;
using IdentityService.Core.Entities.Identity;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.Core.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<GroupPolicy> GroupPolicies { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
