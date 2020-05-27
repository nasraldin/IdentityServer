using IdentityService.Core.Common;
using System.Threading.Tasks;

namespace IdentityService.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}
