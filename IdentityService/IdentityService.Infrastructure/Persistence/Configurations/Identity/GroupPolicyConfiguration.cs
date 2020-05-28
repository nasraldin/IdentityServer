namespace IdentityService.Infrastructure.Persistence.Configurations.Identity
{
    using System;
    using IdentityService.Core.Entities.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// GroupPolicy Configuration.
    /// </summary>
    public class GroupPolicyConfiguration : IEntityTypeConfiguration<GroupPolicy>
    {
        public void Configure(EntityTypeBuilder<GroupPolicy> builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(GroupPolicy));

            // Each Group can have many entries in the GroupRole join table
            builder.HasMany(e => e.Roles)
                .WithOne(e => e.GroupPolicy)
                .HasForeignKey(gp => gp.GroupPolicyId)
                .IsRequired();

            // Each Group can have many associated UserGroup
            builder.HasMany(e => e.Users)
                .WithOne(e => e.GroupPolicy)
                .HasForeignKey(gp => gp.GroupPolicyId)
                .IsRequired();
        }
    }
}
