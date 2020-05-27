using IdentityService.Core.Common;
using System.Threading.Tasks;

namespace IdentityService.Core.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}
