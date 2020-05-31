//  <copyright file="Role.cs" project="Core" solution="IdentityService">
//      Copyright (c) 2020 Nasr Aldin.  All rights reserved.
//      Licensed under the MIT License, See LICENSE in the project root for license information.
//  </copyright>
//  <author>Nasr Aldin</author>
//  <email>nasr2ldin@gmail.com</email>
//  <github>https://github.com/nasraldin/IdentityServer</github>
//  <date>31/05/2020 01:00 AM</date>

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Core.Entities.Identity
{
    /// <summary>
    /// Represents a role.
    /// </summary>
    public class Role : IdentityRole<Guid>
    {
        public virtual string Description { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<RoleClaim> RoleClaims { get; set; }
    }
}
