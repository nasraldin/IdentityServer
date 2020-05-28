using System;

namespace IdentityService.Core.Entities.Identity
{
    public class GroupRole
    {
        public Guid GroupPolicyId { get; set; }
        public Guid RoleId { get; set; }

        public virtual GroupPolicy GroupPolicy { get; set; }
        public virtual Role Role { get; set; }
    }
}
