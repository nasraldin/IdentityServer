using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Core.Entities.Identity
{
    public class User : IdentityUser<Guid>
    {
        public virtual ICollection<UserClaim> Claims { get; set; }
        public virtual ICollection<UserLogin> Logins { get; set; }
        public virtual ICollection<UserToken> Tokens { get; set; }
        public virtual ICollection<UserRole> Roles { get; set; }
        public virtual ICollection<UserGroup> Groups { get; set; }
    }
}
