//  <copyright file="DatabaseInitializer.cs" project="Infrastructure" solution="IdentityService">
//      Copyright (c) 2020 Nasr Aldin.  All rights reserved.
//      Licensed under the MIT License, See LICENSE in the project root for license information.
//  </copyright>
//  <author>Nasr Aldin</author>
//  <email>nasr2ldin@gmail.com</email>
//  <github>https://github.com/nasraldin/IdentityServer</github>
//  <date>31/05/2020 01:00 AM</date>

using System.Threading.Tasks;
using IdentityService.Core.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IdentityService.Infrastructure.Persistence
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly ApplicationDbContext _context;
#pragma warning disable IDE0052 // Remove unread private members
        private readonly ILogger _logger;
#pragma warning restore IDE0052 // Remove unread private members

        public DatabaseInitializer(ApplicationDbContext context, ILogger<DatabaseInitializer> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task SeedAsync()
        {
            await _context.Database.MigrateAsync().ConfigureAwait(false);
        }
    }
}
