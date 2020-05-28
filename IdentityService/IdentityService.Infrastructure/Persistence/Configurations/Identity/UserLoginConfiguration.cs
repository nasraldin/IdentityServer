namespace IdentityService.Infrastructure.Persistence.Configurations.Identity
{
    using System;
    using IdentityService.Core.Entities.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// UserLogin Configuration.
    /// </summary>
    public class UserLoginConfiguration : IEntityTypeConfiguration<UserLogin>
    {
        public void Configure(EntityTypeBuilder<UserLogin> builder)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            builder.ToTable(nameof(UserLogin));
        }
    }
}
