using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Core.Entities.Identity
{
    public class RoleClaim : IdentityRoleClaim<Guid>
    {
        public virtual Role Role { get; set; }
    }
}
