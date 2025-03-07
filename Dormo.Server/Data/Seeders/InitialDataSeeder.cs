using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Data.Seeders;

public static class InitialDataSeeder
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        RoleSeeder.Seed(modelBuilder);
        var (ownerIds, tenantIds) = UserSeeder.Seed(modelBuilder);
        CategorySeeder.Seed(modelBuilder);
        HabitSeeder.Seed(modelBuilder);
        InterestSeeder.Seed(modelBuilder);
        TagSeeder.Seed(modelBuilder);
        DormSeeder.Seed(modelBuilder, ownerIds, tenantIds);
    }
}