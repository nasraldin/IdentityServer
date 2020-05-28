namespace IdentityService.Infrastructure.Persistence.Configurations.Identity
{
    using System;
    using IdentityService.Core.Entities.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// UserToken Configuration.
    /// </summary>
    public class UserTokenConfiguration : IEntityTypeConfiguration<UserToken>
    {
        public void Configure(EntityTypeBuilder<UserToken> builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(UserToken));
        }
    }
}
