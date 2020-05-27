using System.Threading.Tasks;

namespace IdentityService.Core.Common.Interfaces
{
    public interface IDatabaseInitializer
    {
        Task SeedAsync();
    }
}
