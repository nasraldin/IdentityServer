using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Core.Entities.Identity
{
    public class UserToken : IdentityUserToken<Guid>
    {
        public virtual User User { get; set; }
    }
}
