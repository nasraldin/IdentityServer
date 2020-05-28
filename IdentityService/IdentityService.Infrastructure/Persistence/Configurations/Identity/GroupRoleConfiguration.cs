namespace IdentityService.Infrastructure.Persistence.Configurations.Identity
{
    using System;
    using IdentityService.Core.Entities.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// GroupRole Configuration.
    /// </summary>
    public class GroupRoleConfiguration : IEntityTypeConfiguration<GroupRole>
    {
        public void Configure(EntityTypeBuilder<GroupRole> builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(GroupRole));

            // Sets the properties that make up the multiple primary keys for GroupRole.
            builder.HasKey(e => new
            {
                e.GroupPolicyId,
                e.RoleId
            });
        }
    }
}
