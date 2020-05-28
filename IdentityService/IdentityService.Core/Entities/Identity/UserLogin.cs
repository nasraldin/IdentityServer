using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Core.Entities.Identity
{
    public class UserLogin : IdentityUserLogin<Guid>
    {
        public virtual User User { get; set; }
    }
}
