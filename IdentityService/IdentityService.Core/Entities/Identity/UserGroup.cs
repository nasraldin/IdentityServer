using System;

namespace IdentityService.Core.Entities.Identity
{
    public class UserGroup
    {
        public Guid UserId { get; set; }
        public Guid GroupPolicyId { get; set; }

        public virtual User User { get; set; }
        public virtual GroupPolicy GroupPolicy { get; set; }
    }
}
