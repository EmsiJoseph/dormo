using Dormo.Server.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Data.Seeders;

public static class RoleSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "1",
                Name = RolesConstants.Admin,
                NormalizedName = RolesConstants.Admin.ToUpperInvariant(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new IdentityRole
            {
                Id = "2",
                Name = RolesConstants.Owner,
                NormalizedName = RolesConstants.Owner.ToUpperInvariant(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new IdentityRole
            {
                Id = "3",
                Name = RolesConstants.Member,
                NormalizedName = RolesConstants.Member.ToUpperInvariant(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new IdentityRole
            {
                Id = "4",
                Name = RolesConstants.Tenant,
                NormalizedName = RolesConstants.Tenant.ToUpperInvariant(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            }
        );
    }
}