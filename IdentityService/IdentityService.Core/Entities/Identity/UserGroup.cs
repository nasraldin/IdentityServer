//  <copyright file="UserGroup.cs" project="Core" solution="IdentityService">
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
    /// A join entity that associates users and groupPolicy.
    /// </summary>
    public class UserGroup
    {
        public Guid UserId { get; set; }
        public Guid GroupPolicyId { get; set; }

        public virtual User User { get; set; }
        public virtual GroupPolicy GroupPolicy { get; set; }
    }
}
