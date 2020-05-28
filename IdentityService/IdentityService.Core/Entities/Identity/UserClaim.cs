using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Core.Entities.Identity
{
    public class UserClaim : IdentityUserClaim<Guid>
    {
        public virtual User User { get; set; }
    }
}
