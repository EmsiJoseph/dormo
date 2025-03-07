using Dormo.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Data.Seeders;

public static class InterestSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Interest>().HasData(
            new Interest { Id = 1, Name = "Gaming", Description = "Enjoys playing video games" },
            new Interest { Id = 2, Name = "Reading", Description = "Enjoys reading books" },
            new Interest { Id = 3, Name = "Music", Description = "Interested in music and instruments" },
            new Interest { Id = 4, Name = "Sports", Description = "Enjoys sports activities" },
            new Interest { Id = 5, Name = "Cooking", Description = "Enjoys cooking and culinary arts" },
            new Interest { Id = 6, Name = "Art", Description = "Interested in various forms of art" }
        );
    }
}