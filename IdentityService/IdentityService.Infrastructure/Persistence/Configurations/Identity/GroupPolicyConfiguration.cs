//  <copyright file="GroupPolicyConfiguration.cs" project="Infrastructure" solution="IdentityService">
//      Copyright (c) 2020 Nasr Aldin.  All rights reserved.
//      Licensed under the MIT License, See LICENSE in the project root for license information.
//  </copyright>
//  <author>Nasr Aldin</author>
//  <email>nasr2ldin@gmail.com</email>
//  <github>https://github.com/nasraldin/IdentityServer</github>
//  <date>31/05/2020 01:00 AM</date>

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
