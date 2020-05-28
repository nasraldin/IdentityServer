using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentityService.Core.Entities.Identity
{
    // Summary:
    //     Represents a GroupPolicy in the identity system
    //
    // Type parameters:
    //   TKey:
    //     The type used for the primary key for the role.
    public class GroupPolicy
    {
        // Empty constructor for EF
        public GroupPolicy() { }

        public GroupPolicy(string name) : this()
        {
            Name = name;
        }

        public GroupPolicy(string name, string description) : this(name)
        {
            Description = description;
        }

        [Key]
        public virtual Guid Id { get; set; }

        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        // Summary:
        //     A random value that should change whenever a role is persisted to the store
        public virtual string ConcurrencyStamp { get; set; }

        public virtual ICollection<GroupRole> Roles { get; set; }
        public virtual ICollection<UserGroup> Users { get; set; }
    }
}
