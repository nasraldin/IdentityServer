using IdentityService.Core.Common;
using IdentityService.Core.Interfaces;
using System.Threading.Tasks;

namespace IdentityService.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
