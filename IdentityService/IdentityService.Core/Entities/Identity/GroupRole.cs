//  <copyright file="GroupRole.cs" project="Core" solution="IdentityService">
//      Copyright (c) 2020 Nasr Aldin.  All rights reserved.
//      Licensed under the MIT License, See LICENSE in the project root for license information.
//  </copyright>
//  <author>Nasr Aldin</author>
//  <email>nasr2ldin@gmail.com</email>
//  <github>https://github.com/nasraldin/IdentityServer</github>
//  <date>31/05/2020 01:00 AM</date>

using System;

namespace IdentityService.Core.Entities.Identity
{
    /// <summary>
    /// A join entity that associates groupPolicy and role.
    /// </summary>
    public class GroupRole
    {
        public Guid GroupPolicyId { get; set; }
        public Guid RoleId { get; set; }

        public virtual GroupPolicy GroupPolicy { get; set; }
        public virtual Role Role { get; set; }
    }
}
