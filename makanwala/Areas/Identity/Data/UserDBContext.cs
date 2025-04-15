using makanwala.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace makanwala.Areas.Identity.Data;

public class UserDBContext : IdentityDbContext<makanwalaUser>
{
    public UserDBContext(DbContextOptions<UserDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new AppEntityConfig());
    }
}

public class AppEntityConfig : IEntityTypeConfiguration<makanwalaUser>
{
    public void Configure(EntityTypeBuilder<makanwalaUser> builder)
    {
        builder.Property(x => x.FullName).HasMaxLength(256);
    }
}

