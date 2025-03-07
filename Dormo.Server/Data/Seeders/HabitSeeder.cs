using Dormo.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Data.Seeders;

public static class HabitSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Habit>().HasData(
            new Habit { Id = 1, Name = "Early Bird", Description = "Wakes up early in the morning" },
            new Habit { Id = 2, Name = "Night Owl", Description = "Stays up late at night" },
            new Habit { Id = 3, Name = "Neat Freak", Description = "Keeps everything clean and organized" },
            new Habit { Id = 4, Name = "Social Butterfly", Description = "Enjoys socializing and having friends over" },
            new Habit { Id = 5, Name = "Quiet Person", Description = "Prefers quiet environment" },
            new Habit { Id = 6, Name = "Studious", Description = "Spends most time studying" }
        );
    }
}