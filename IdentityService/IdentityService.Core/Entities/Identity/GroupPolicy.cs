//  <copyright file="GroupPolicy.cs" project="Core" solution="IdentityService">
//      Copyright (c) 2020 Nasr Aldin.  All rights reserved.
//      Licensed under the MIT License, See LICENSE in the project root for license information.
//  </copyright>
//  <author>Nasr Aldin</author>
//  <email>nasr2ldin@gmail.com</email>
//  <github>https://github.com/nasraldin/IdentityServer</github>
//  <date>31/05/2020 01:00 AM</date>

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentityService.Core.Entities.Identity
{
    /// <summary>
    /// Represents a GroupPolicy in the identity system.
    /// </summary>
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
