﻿//  <copyright file="RoleClaimConfiguration.cs" project="Infrastructure" solution="IdentityService">
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
    /// RoleClaim Configuration.
    /// </summary>
    public class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaim>
    {
        public void Configure(EntityTypeBuilder<RoleClaim> builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(RoleClaim));
        }
    }
}
