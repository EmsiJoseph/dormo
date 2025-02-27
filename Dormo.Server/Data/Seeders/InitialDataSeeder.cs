using Dormo.Server.Constants;
using Dormo.Server.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Data.Seeders;

public static class InitialDataSeeder
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        // Seed Amenities
        modelBuilder.Entity<Amenity>().HasData(
            new Amenity
            {
                Id = 1, Name = "Air Conditioning", Description = "Cooling system for comfortable room temperature"
            },
            new Amenity
            {
                Id = 2, Name = "Wi-Fi", Description = "High-speed wireless internet connection",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXdpZmkiPjxwYXRoIGQ9Ik0xMiAyMGguMDEiLz48cGF0aCBkPSJNMiA4LjgyYTE1IDE1IDAgMCAxIDIwIDAiLz48cGF0aCBkPSJNNSAxMi44NTlhMTAgMTAgMCAwIDEgMTQgMCIvPjxwYXRoIGQ9Ik04LjUgMTYuNDI5YTUgNSAwIDAgMSA3IDAiLz48L3N2Zz4="
            },
            new Amenity
            {
                Id = 3, Name = "Study Area", Description = "Dedicated space for studying",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLW5vdGVib29rIj48cGF0aCBkPSJNMiA2aDQiLz48cGF0aCBkPSJNMiAxMGg0Ii8+PHBhdGggZD0iTTIgMTRoNCIvPjxwYXRoIGQ9Ik0yIDE4aDQiLz48cmVjdCB3aWR0aD0iMTYiIGhlaWdodD0iMjAiIHg9IjQiIHk9IjIiIHJ4PSIyIi8+PHBhdGggZD0iTTE2IDJ2MjAiLz48L3N2Zz4="
            },
            new Amenity
            {
                Id = 4, Name = "Laundry", Description = "On-site laundry facilities",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXdhc2hpbmctbWFjaGluZSI+PHBhdGggZD0iTTMgNmgzIi8+PHBhdGggZD0iTTE3IDZoLjAxIi8+PHJlY3Qgd2lkdGg9IjE4IiBoZWlnaHQ9IjIwIiB4PSIzIiB5PSIyIiByeD0iMiIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iMTMiIHI9IjUiLz48cGF0aCBkPSJNMTIgMThhMi41IDIuNSAwIDAgMCAwLTUgMi41IDIuNSAwIDAgMSAwLTUiLz48L3N2Zz4="
            },
            new Amenity
            {
                Id = 5, Name = "Security", Description = "24/7 security personnel and CCTV",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNjdHYiPjxwYXRoIGQ9Ik0xNi43NSAxMmgzLjYzMmExIDEgMCAwIDEgLjg5NCAxLjQ0N2wtMi4wMzQgNC4wNjlhMSAxIDAgMCAxLTEuNzA4LjEzNGwtMi4xMjQtMi45NyIvPjxwYXRoIGQ9Ik0xNy4xMDYgOS4wNTNhMSAxIDAgMCAxIC40NDcgMS4zNDFsLTMuMTA2IDYuMjExYTEgMSAwIDAgMS0xLjM0Mi40NDdMMy42MSAxMi4zYTIuOTIgMi45MiAwIDAgMS0xLjMtMy45MUwzLjY5IDUuNmEyLjkyIDIuOTIgMCAwIDEgMy45Mi0xLjN6Ii8+PHBhdGggZD0iTTIgMTloMy43NmEyIDIgMCAwIDAgMS44LTEuMUw5IDE1Ii8+PHBhdGggZD0iTTIgMjF2LTQiLz48cGF0aCBkPSJNNyA5aC4wMSIvPjwvc3ZnPg=="
            },
            new Amenity
            {
                Id = 6, Name = "Common Room", Description = "Shared space for socializing",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWFybWNoYWlyIj48cGF0aCBkPSJNMTkgOVY2YTIgMiAwIDAgMC0yLTJIN2EyIDIgMCAwIDAtMiAydjMiLz48cGF0aCBkPSJNMyAxNmEyIDIgMCAwIDAgMiAyaDE0YTIgMiAwIDAgMCAyLTJ2LTVhMiAyIDAgMCAwLTQgMHYxLjVhLjUuNSAwIDAgMS0uNS41aC05YS41LjUgMCAwIDEtLjUtLjVWMTFhMiAyIDAgMCAwLTQgMHoiLz48cGF0aCBkPSJNNSAxOHYyIi8+PHBhdGggZD0iTTE5IDE4djIiLz48L3N2Zz4="
            },
            new Amenity
            {
                Id = 7, Name = "Kitchen", Description = "Shared cooking facilities",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNvb2tpbmctcG90Ij48cGF0aCBkPSJNMiAxMmgyMCIvPjxwYXRoIGQ9Ik0yMCAxMnY4YTIgMiAwIDAgMS0yIDJINmEyIDIgMCAwIDEtMi0ydi04Ii8+PHBhdGggZD0ibTQgOCAxNi00Ii8+PHBhdGggZD0ibTguODYgNi43OC0uNDUtMS44MWEyIDIgMCAwIDEgMS40NS0yLjQzbDEuOTQtLjQ4YTIgMiAwIDAgMSAyLjQzIDEuNDZsLjQ1IDEuOCIvPjwvc3ZnPg=="
            },
            new Amenity
            {
                Id = 8, Name = "Parking", Description = "Secure parking space",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNpcmNsZS1wYXJraW5nIj48Y2lyY2xlIGN4PSIxMiIgY3k9IjEyIiByPSIxMCIvPjxwYXRoIGQ9Ik05IDE3VjdoNGEzIDMgMCAwIDEgMCA2SDkiLz48L3N2Zz4="
            }
        );

        // Seed Categories with icons
        SeedCategories(modelBuilder);

        // Seed Habits
        modelBuilder.Entity<Habit>().HasData(
            new Habit { Id = 1, Name = "Early Bird", Description = "Wakes up early in the morning" },
            new Habit { Id = 2, Name = "Night Owl", Description = "Stays up late at night" },
            new Habit { Id = 3, Name = "Neat Freak", Description = "Keeps everything clean and organized" },
            new Habit { Id = 4, Name = "Social Butterfly", Description = "Enjoys socializing and having friends over" },
            new Habit { Id = 5, Name = "Quiet Person", Description = "Prefers quiet environment" },
            new Habit { Id = 6, Name = "Studious", Description = "Spends most time studying" }
        );

        // Seed Interests
        modelBuilder.Entity<Interest>().HasData(
            new Interest { Id = 1, Name = "Gaming", Description = "Enjoys playing video games" },
            new Interest { Id = 2, Name = "Reading", Description = "Enjoys reading books" },
            new Interest { Id = 3, Name = "Music", Description = "Interested in music and instruments" },
            new Interest { Id = 4, Name = "Sports", Description = "Enjoys sports activities" },
            new Interest { Id = 5, Name = "Cooking", Description = "Enjoys cooking and culinary arts" },
            new Interest { Id = 6, Name = "Art", Description = "Interested in various forms of art" }
        );

        // Seed Tags
        modelBuilder.Entity<Tag>().HasData(
            new Tag
            {
                Id = 1, Name = "Near Campus", Description = "Located close to educational institutions",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXNjaG9vbCI+PHBhdGggZD0iTTE0IDIydi00YTIgMiAwIDEgMC00IDB2NCIvPjxwYXRoIGQ9Im0xOCAxMCAzLjQ0NyAxLjcyNGExIDEgMCAwIDEgLjU1My44OTRWMjBhMiAyIDAgMCAxLTIgMkg0YTIgMiAwIDAgMS0yLTJ2LTcuMzgyYTEgMSAwIDAgMSAuNTUzLS44OTRMNiAxMCIvPjxwYXRoIGQ9Ik0xOCA1djE3Ii8+PHBhdGggZD0ibTQgNiA3LjEwNi0zLjU1M2EyIDIgMCAwIDEgMS43ODggMEwyMCA2Ii8+PHBhdGggZD0iTTYgNXYxNyIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iOSIgcj0iMiIvPjwvc3ZnPg=="
            },
            new Tag
            {
                Id = 2, Name = "Pet Friendly", Description = "Allows pets in the premises",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNhdCI+PHBhdGggZD0iTTEyIDVjLjY3IDAgMS4zNS4wOSAyIC4yNiAxLjc4LTIgNS4wMy0yLjg0IDYuNDItMi4yNiAxLjQuNTgtLjQyIDctLjQyIDcgLjU3IDEuMDcgMSAyLjI0IDEgMy40NEMyMSAxNy45IDE2Ljk3IDIxIDEyIDIxcy05LTMtOS03LjU2YzAtMS4yNS41LTIuNCAxLTMuNDQgMCAwLTEuODktNi40Mi0uNS03IDEuMzktLjU4IDQuNzIuMjMgNi41IDIuMjNBOS4wNCA5LjA0IDAgMCAxIDEyIDVaIi8+PHBhdGggZD0iTTggMTR2LjUiLz48cGF0aCBkPSJNMTYgMTR2LjUiLz48cGF0aCBkPSJNMTEuMjUgMTYuMjVoMS41TDEyIDE3bC0uNzUtLjc1WiIvPjwvc3ZnPg=="
            },
            new Tag
            {
                Id = 3, Name = "Female Only", Description = "Exclusive for female residents",
                Icon =
                    "data:image/svg +xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXZlbnVzIj48cGF0aCBkPSJNMTIgMTV2NyIvPjxwYXRoIGQ9Ik05IDE5aDYiLz48Y2lyY2xlIGN4PSIxMiIgY3k9IjkiIHI9IjYiLz48L3N2Zz4="
            },
            new Tag
            {
                Id = 4, Name = "Male Only", Description = "Exclusive for male residents",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLW1hcnMiPjxwYXRoIGQ9Ik0xNiAzaDV2NSIvPjxwYXRoIGQ9Im0yMSAzLTYuNzUgNi43NSIvPjxjaXJjbGUgY3g9IjEwIiBjeT0iMTQiIHI9IjYiLz48L3N2Zz4="
            },
            new Tag
            {
                Id = 5, Name = "Student Friendly", Description = "Suitable for students",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWdyYWR1YXRpb24tY2FwIj48cGF0aCBkPSJNMjEuNDIgMTAuOTIyYTEgMSAwIDAgMC0uMDE5LTEuODM4TDEyLjgzIDUuMThhMiAyIDAgMCAwLTEuNjYgMEwyLjYgOS4wOGExIDEgMCAwIDAgMCAxLjgzMmw4LjU3IDMuOTA4YTIgMiAwIDAgMCAxLjY2IDB6Ii8+PHBhdGggZD0iTTIyIDEwdjYiLz48cGF0aCBkPSJNNiAxMi41VjE2YTYgMyAwIDAgMCAxMiAwdi0zLjUiLz48L3N2Zz4="
            },
            new Tag
            {
                Id = 6, Name = "Newly Built", Description = "Recently constructed property",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLW1hcC1waW4tcGx1cyI+PHBhdGggZD0iTTE5LjkxNCAxMS4xMDVBNy4yOTggNy4yOTggMCAwIDAgMjAgMTBhOCA4IDAgMCAwLTE2IDBjMCA0Ljk5MyA1LjUzOSAxMC4xOTMgNy4zOTkgMTEuNzk5YTEgMSAwIDAgMCAxLjIwMiAwIDMyIDMyIDAgMCAwIC44MjQtLjczOCIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iMTAiIHI9IjMiLz48cGF0aCBkPSJNMTYgMThoNiIvPjxwYXRoIGQ9Ik0xOSAxNXY2Ii8+PC9zdmc+"
            },
            new Tag
            {
                Id = 7, Name = "Budget Friendly", Description = "Affordable accommodation",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXBoaWxpcHBpbmUtcGVzbyI+PHBhdGggZD0iTTIwIDExSDQiLz48cGF0aCBkPSJNMjAgN0g0Ii8+PHBhdGggZD0iTTcgMjFWNGExIDEgMCAwIDEgMS0xaDRhMSAxIDAgMCAxIDAgMTJINyIvPjwvc3ZnPg=="
            },
            new Tag
            {
                Id = 8, Name = "Luxury", Description = "High-end accommodation",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWdlbSI+PHBhdGggZD0iTTYgM2gxMmw0IDYtMTAgMTNMMiA5WiIvPjxwYXRoIGQ9Ik0xMSAzIDggOWw0IDEzIDQtMTMtMy02Ii8+PHBhdGggZD0iTTIgOWgyMCIvPjwvc3ZnPg=="
            }
        );

        // Define role IDs - move this up to make them available globally
        var adminRoleId = "1";
        var ownerRoleId = "2";
        var memberRoleId = "3";
        var tenantRoleId = "4";

        // Seed Roles with explicit IDs
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = adminRoleId,
                Name = RolesConstants.Admin,
                NormalizedName = RolesConstants.Admin.ToUpperInvariant(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new IdentityRole
            {
                Id = ownerRoleId,
                Name = RolesConstants.Owner,
                NormalizedName = RolesConstants.Owner.ToUpperInvariant(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new IdentityRole
            {
                Id = memberRoleId,
                Name = RolesConstants.Member,
                NormalizedName = RolesConstants.Member.ToUpperInvariant(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },
            new IdentityRole
            {
                Id = tenantRoleId,
                Name = RolesConstants.Tenant,
                NormalizedName = RolesConstants.Tenant.ToUpperInvariant(),
                ConcurrencyStamp = Guid.NewGuid().ToString()
            }
        );

        // Seed Users (including dorm owners) - pass the role IDs
        var ownerIds = SeedUsers(modelBuilder, adminRoleId, ownerRoleId, memberRoleId, tenantRoleId);

        // Seed Dorms (100 sample dormitories distributed among owners)
        SeedDorms(modelBuilder, ownerIds);
    }

    private static void SeedCategories(ModelBuilder modelBuilder)
    {
        // Define icon mapping - category name to base64 icon
        var iconMap = new Dictionary<string, string>
        {
            ["Near Schools/Uni"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVuaXZlcnNpdHkiPjxjaXJjbGUgY3g9IjEyIiBjeT0iMTAiIHI9IjEiLz48cGF0aCBkPSJNMjIgMjBWOGgtNGwtNi00LTYgNEgydjEyYTIgMiAwIDAgMCAyIDJoMTZhMiAyIDAgMCAwIDItMiIvPjxwYXRoIGQ9Ik02IDE3di4wMSIvPjxwYXRoIGQ9Ik02IDEzdi4wMSIvPjxwYXRoIGQ9Ik0xOCAxN3YuMDEiLz48cGF0aCBkPSJNMTggMTN2LjAxIi8+PHBhdGggZD0iTTE0IDIydi01YTIgMiAwIDAgMC0yLTJhMiAyIDAgMCAwLTIgMnY1Ii8+PC9zdmc+",
            ["City Dorms"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik02IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=",
            ["Suburban Dorms"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik02IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=",
            ["Campus-Connected"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXNjaG9vbCI+PHBhdGggZD0iTTE0IDIydi00YTIgMiAwIDEgMC00IDB2NCIvPjxwYXRoIGQ9Im0xOCAxMCAzLjQ0NyAxLjcyNGExIDEgMCAwIDEgLjU1My44OTRWMjBhMiAyIDAgMCAxLTIgMkg0YTIgMiAwIDAgMS0yLTJ2LTcuMzgyYTEgMSAwIDAgMSAuNTUzLS44OTRMNiAxMCIvPjxwYXRoIGQ9Ik0xOCA1djE3Ii8+PHBhdGggZD0ibTQgNiA3LjEwNi0zLjU1M2EyIDIgMCAwIDEgMS43ODggMEwyMCA2Ii8+PHBhdGggZD0iTTYgNXYxNyIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iOSIgcj0iMiIvPjwvc3ZnPg==",
            ["Bed Spaces"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJlZCI+PHBhdGggZD0iTTIgNHYxNiIvPjxwYXRoIGQ9Ik0yIDhoMThhMiAyIDAgMCAxIDIgMnYxMCIvPjxwYXRoIGQ9Ik0yIDE3aDIwIi8+PHBhdGggZD0iTTYgOHY5Ii8+PC9zdmc+",
            ["Private Room"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXIiPjxwYXRoIGQ9Ik0xOSAyMXYtMmE0IDQgMCAwIDAtNC00SDlhNCA0IDAgMCAwLTQgNHYyIi8+PGNpcmNsZSBjeD0iMTIiIGN5PSI3IiByPSI0Ii8+PC9zdmc+",
            ["Co-Living Spaces"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXJzIj48cGF0aCBkPSJNMTYgMjF2LTJhNCA0IDAgMCAwLTQtNEg2YTQgNCAwIDAgMC00IDR2MiIvPjxjaXJjbGUgY3g9IjkiIGN5PSI3IiByPSI0Ii8+PHBhdGggZD0iTTIyIDIxdi0yYTQgNCAwIDAgMC0zLTMuODciLz48cGF0aCBkPSJNMTYgMy4xM2E0IDQgMCAwIDEgMCA3Ljc1Ii8+PC9zdmc+",
            ["Apartment Style"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXJzIj48cGF0aCBkPSJNMTYgMjF2LTJhNCA0IDAgMCAwLTQtNEg2YTQgNCAwIDAgMC00IDR2MiIvPjxjaXJjbGUgY3g9IjkiIGN5PSI3IiByPSI0Ii8+PHBhdGggZD0iTTIyIDIxdi0yYTQgNCAwIDAgMC0zLTMuODciLz48cGF0aCBkPSJNMTYgMy4xM2E0IDQgMCAwIDEgMCA3Ljc1Ii8+PC9zdmc+",
            ["Studio Type"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlIj48cGF0aCBkPSJNMTUgMjF2LThhMSAxIDAgMCAwLTEtMWgtNGExIDEgMCAwIDAtMSAxdjgiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PC9zdmc+",
            ["Smart Dorms"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlLXdpZmkiPjxwYXRoIGQ9Ik05LjUgMTMuODY2YTQgNCAwIDAgMSA1IC4wMSIvPjxwYXRoIGQ9Ik0xMiAxN2guMDEiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PHBhdGggZD0iTTcgMTAuNzU0YTggOCAwIDAgMSAxMCAwIi8+PC9zdmc+",
            ["Condo Dorms"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik02IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=",
            ["Review Centers & Dorms"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJvb2stb3Blbi10ZXh0Ij48cGF0aCBkPSJNMTIgN3YxNCIvPjxwYXRoIGQ9Ik0xNiAxMmgyIi8+PHBhdGggZD0iTTE2IDhoMiIvPjxwYXRoIGQ9Ik0zIDE4YTEgMSAwIDAgMS0xLTFWNGExIDEgMCAwIDEgMS0xaDVhNCA0IDAgMCAxIDQgNCA0IDQgMCAwIDEgNC00aDVhMSAxIDAgMCAxIDEgMXYxM2ExIDEgMCAwIDEtMSAxaC02YTMgMyAwIDAgMC0zIDMgMyAzIDAgMCAwLTMtM3oiLz48cGF0aCBkPSJNNiAxMmgyIi8+PHBhdGggZD0iTTYgOGgyIi8+PC9zdmc+",
            ["Boarding Houses"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlIj48cGF0aCBkPSJNMTUgMjF2LThhMSAxIDAgMCAwLTEtMWgtNGExIDEgMCAwIDAtMSAxdjgiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PC9zdmc+",
            ["Short Term Stays"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXJnbGFzcyI+PHBhdGggZD0iTTUgMjJoMTQiLz48cGF0aCBkPSJNNSAyaDE0Ii8+PHBhdGggZD0iTTE3IDIydi00LjE3MmEyIDIgMCAwIDAtLjU4Ni0xLjQxNEwxMiAxMmwtNC40MTQgNC40MTRBMiAyIDAgMCAwIDcgMTcuODI4VjIyIi8+PHBhdGggZD0iTTcgMnY0LjE3MmEyIDIgMCAwIDAgLjU4NiAxLjQxNEwxMiAxMmw0LjQxNC00LjQxNEEyIDIgMCAwIDAgMTcgNi4xNzJWMiIvPjwvc3ZnPg==",
            ["Historical Dorms"] =
                "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNhbGVuZGFyIj48cGF0aCBkPSJNOCAydjQiLz48cGF0aCBkPSJNMTYgMnY0Ii8+PHJlY3Qgd2lkdGg9IjE4IiBoZWlnaHQ9IjE4IiB4PSIzIiB5PSI0IiByeD0iMiIvPjxwYXRoIGQ9Ik0zIDEwaDE4Ii8+PC9zdmc+"
        };

        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1, Name = "Studio Type", Description = "Single room accommodation", ParentId = null,
                Icon = iconMap["Studio Type"]
            },
            new Category
            {
                Id = 2, Name = "Apartment Type", Description = "Multiple room accommodation", ParentId = null,
                Icon = iconMap["Apartment Style"]
            },
            new Category
            {
                Id = 4, Name = "Single Studio", Description = "Studio for one person", ParentId = 1,
                Icon = iconMap["Studio Type"]
            },
            new Category
            {
                Id = 5, Name = "Double Studio", Description = "Studio for two persons", ParentId = 1,
                Icon = iconMap["Studio Type"]
            },
            new Category
            {
                Id = 6, Name = "2-Bedroom", Description = "Two bedroom apartment", ParentId = 2,
                Icon = iconMap["Apartment Style"]
            },
            new Category
            {
                Id = 7, Name = "3-Bedroom", Description = "Three bedroom apartment", ParentId = 2,
                Icon = iconMap["Apartment Style"]
            },
            new Category
            {
                Id = 8, Name = "Near Schools/Uni", Description = "Dorms near schools or universities", ParentId = null,
                Icon = iconMap["Near Schools/Uni"]
            },
            new Category
            {
                Id = 9, Name = "City Dorms", Description = "Dorms located in the city", ParentId = null,
                Icon = iconMap["City Dorms"]
            },
            new Category
            {
                Id = 10, Name = "Suburban Dorms", Description = "Dorms located in suburban areas", ParentId = null,
                Icon = iconMap["Suburban Dorms"]
            },
            new Category
            {
                Id = 11, Name = "Campus-Connected", Description = "Dorms connected to campuses", ParentId = null,
                Icon = iconMap["Campus-Connected"]
            },
            new Category
            {
                Id = 12, Name = "Bed Spaces", Description = "Dorms offering bed spaces", ParentId = null,
                Icon = iconMap["Bed Spaces"]
            },
            new Category
            {
                Id = 13, Name = "Private Room", Description = "Dorms offering private rooms", ParentId = null,
                Icon = iconMap["Private Room"]
            },
            new Category
            {
                Id = 14, Name = "Co-Living Spaces", Description = "Dorms offering co-living spaces", ParentId = null,
                Icon = iconMap["Co-Living Spaces"]
            },
            new Category
            {
                Id = 17, Name = "Condo Dorms", Description = "Dorms with condominium-style accommodations",
                ParentId = null, Icon = iconMap["Condo Dorms"]
            },
            new Category
            {
                Id = 18, Name = "Review Centers & Dorms", Description = "Dorms with review centers", ParentId = null,
                Icon = iconMap["Review Centers & Dorms"]
            },
            new Category
            {
                Id = 19, Name = "Boarding Houses", Description = "Boarding houses", ParentId = null,
                Icon = iconMap["Boarding Houses"]
            },
            new Category
            {
                Id = 20, Name = "Short Term Stays", Description = "Dorms for short term stays", ParentId = null,
                Icon = iconMap["Short Term Stays"]
            },
            new Category
            {
                Id = 21, Name = "Historical Dorms", Description = "Dorms with historical significance", ParentId = null,
                Icon = iconMap["Historical Dorms"]
            }
        );
    }

    private static List<string> SeedUsers(ModelBuilder modelBuilder, string adminRoleId, string ownerRoleId,
        string memberRoleId, string tenantRoleId)
    {
        var hasher = new PasswordHasher<User>();
        var ownerIds = new List<string>();
        var users = new List<User>();
        var userRoles = new List<IdentityUserRole<string>>();

        // Owner 1 - Property Management Company
        var owner1Id = "8e445865-a24d-4543-a6c6-9443d048cdb9";
        var owner1 = new User
        {
            Id = owner1Id,
            UserName = "pmcrealty@example.com",
            NormalizedUserName = "PMCREALTY@EXAMPLE.COM",
            Email = "pmcrealty@example.com",
            NormalizedEmail = "PMCREALTY@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "PMC",
            LastName = "Realty",
            PhoneNumber = "+639171234567",
            PhoneNumberConfirmed = true,
        };
        owner1.PasswordHash = hasher.HashPassword(owner1, "Password1*");
        users.Add(owner1);
        ownerIds.Add(owner1Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = owner1Id, RoleId = ownerRoleId });

        // Owner 2 - Individual Owner
        var owner2Id = "8e445865-a24d-4543-a6c6-9443d048cdb8";
        var owner2 = new User
        {
            Id = owner2Id,
            UserName = "maria.santos@example.com",
            NormalizedUserName = "MARIA.SANTOS@EXAMPLE.COM",
            Email = "maria.santos@example.com",
            NormalizedEmail = "MARIA.SANTOS@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Maria",
            LastName = "Santos",
            PhoneNumber = "+639187654321",
            PhoneNumberConfirmed = true,
        };
        owner2.PasswordHash = hasher.HashPassword(owner2, "Password1*");
        users.Add(owner2);
        ownerIds.Add(owner2Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = owner2Id, RoleId = ownerRoleId });

        // Owner 3 - Real Estate Developer
        var owner3Id = "8e445865-a24d-4543-a6c6-9443d048cdb7";
        var owner3 = new User
        {
            Id = owner3Id,
            UserName = "megadevelopers@example.com",
            NormalizedUserName = "MEGADEVELOPERS@EXAMPLE.COM",
            Email = "megadevelopers@example.com",
            NormalizedEmail = "MEGADEVELOPERS@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Mega",
            LastName = "Developers",
            PhoneNumber = "+639191234567",
            PhoneNumberConfirmed = true,
        };
        owner3.PasswordHash = hasher.HashPassword(owner3, "Password1*");
        users.Add(owner3);
        ownerIds.Add(owner3Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = owner3Id, RoleId = ownerRoleId });

        // Owner 4 - Small Property Owner
        var owner4Id = "8e445865-a24d-4543-a6c6-9443d048cdb6";
        var owner4 = new User
        {
            Id = owner4Id,
            UserName = "antonio.reyes@example.com",
            NormalizedUserName = "ANTONIO.REYES@EXAMPLE.COM",
            Email = "antonio.reyes@example.com",
            NormalizedEmail = "ANTONIO.REYES@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Antonio",
            LastName = "Reyes",
            PhoneNumber = "+639207654321",
            PhoneNumberConfirmed = true,
        };
        owner4.PasswordHash = hasher.HashPassword(owner4, "Password1*");
        users.Add(owner4);
        ownerIds.Add(owner4Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = owner4Id, RoleId = ownerRoleId });

        // Owner 5 - University Housing Department
        var owner5Id = "8e445865-a24d-4543-a6c6-9443d048cdb5";
        var owner5 = new User
        {
            Id = owner5Id,
            UserName = "housing@university.edu",
            NormalizedUserName = "HOUSING@UNIVERSITY.EDU",
            Email = "housing@university.edu",
            NormalizedEmail = "HOUSING@UNIVERSITY.EDU",
            EmailConfirmed = true,
            FirstName = "University",
            LastName = "Housing",
            PhoneNumber = "+639211234567",
            PhoneNumberConfirmed = true,
        };
        owner5.PasswordHash = hasher.HashPassword(owner5, "Password1*");
        users.Add(owner5);
        ownerIds.Add(owner5Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = owner5Id, RoleId = ownerRoleId });

        // Seed Admin User
        var adminId = "8e445865-a24d-4543-a6c6-9443d048cdb0";
        var admin = new User
        {
            Id = adminId,
            UserName = "admin@dormo.com",
            NormalizedUserName = "ADMIN@DORMO.COM",
            Email = "admin@dormo.com",
            NormalizedEmail = "ADMIN@DORMO.COM",
            EmailConfirmed = true,
            FirstName = "System",
            LastName = "Administrator",
            PhoneNumber = "+639190000000",
            PhoneNumberConfirmed = true,
        };
        admin.PasswordHash = hasher.HashPassword(admin, "Admin123$");
        users.Add(admin);
        userRoles.Add(new IdentityUserRole<string> { UserId = adminId, RoleId = adminRoleId });

        // Add users to database
        modelBuilder.Entity<User>().HasData(users);

        // Add user roles to database
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

        return ownerIds;
    }

    private static void SeedDorms(ModelBuilder modelBuilder, List<string> ownerIds)
    {
        var random = new Random(123); // Fixed seed for reproducibility
        var dorms = new List<Dorm>();
        var dormAmenities = new List<DormAmenity>();
        var dormTags = new List<DormTag>();
        var rooms = new List<Room>();
        var dormImages = new List<Image>();

        // Define location data arrays for variety
        string[] cities = { "Manila", "Quezon City", "Makati", "Pasig", "Taguig", "Parañaque", "Pasay", "Mandaluyong" };
        string[] barangays =
        {
            "San Antonio", "Poblacion", "Guadalupe Nuevo", "San Lorenzo", "San Isidro", "Pinagkaisahan", "Palanan",
            "Pio del Pilar", "Valenzuela", "Singkamas"
        };
        string[] streets =
        {
            "Rizal Avenue", "EDSA", "Ortigas Avenue", "Shaw Boulevard", "Taft Avenue", "Buendia Avenue", "Ayala Avenue",
            "Marcos Highway", "Commonwealth Avenue", "Katipunan Avenue"
        };
        string[] dormPrefixes =
        {
            "Green", "Blue", "Red", "Orange", "Purple", "Golden", "Silver", "Crystal", "Royal", "Grand", "Premium",
            "Elite", "Superior", "Elegant", "Central"
        };
        string[] dormTypes =
        {
            "Dormitory", "Residences", "Hall", "Place", "House", "Suites", "Living Spaces", "Quarters", "Lodgings",
            "Dwellings"
        };
        string[] dormFeatures =
        {
            "Cozy", "Spacious", "Modern", "Stylish", "Contemporary", "Classic", "Luxurious", "Comfortable",
            "Student-friendly", "Professional"
        };
        string[] descriptions =
        {
            "A comfortable living space designed for students and young professionals.",
            "Modern accommodations with convenient access to universities and business districts.",
            "Premium living experience with top-notch amenities and security features.",
            "Affordable lodgings with essential amenities for a comfortable stay.",
            "Luxurious residences offering the best in comfort and convenience.",
            "Student-friendly dormitory with study areas and high-speed internet.",
            "Contemporary living spaces designed for the modern lifestyle.",
            "Secure and well-maintained accommodations for peace of mind.",
            "Budget-friendly options without compromising on quality and comfort.",
            "Strategically located residences for easy access to key city establishments."
        };
        string[] nearbyLandmarks =
        {
            "Near University of the Philippines",
            "Close to Ateneo de Manila University",
            "Walking distance to De La Salle University",
            "Near University of Santo Tomas",
            "Close to University of the East",
            "Near Far Eastern University",
            "Walking distance to Manila Central University",
            "Near AMA University",
            "Close to Polytechnic University of the Philippines",
            "Near Technological University of the Philippines"
        };

        // Image dimensions suitable for an Airbnb-like app
        int[] imageWidths = { 800, 1024, 1200 };
        int[] imageHeights = { 600, 768, 900 };

        int roomId = 1; // Start room IDs from 1
        int imageId = 1; // Start image IDs from 1

        // Define the valid category IDs that actually exist in the database
        int[] validCategoryIds = { 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 17, 18, 19, 20, 21 };

        // Create 100 dorms
        for (int i = 1; i <= 100; i++)
        {
            string dormName =
                $"{dormPrefixes[random.Next(dormPrefixes.Length)]} {dormTypes[random.Next(dormTypes.Length)]}";
            string city = cities[random.Next(cities.Length)];
            string barangay = barangays[random.Next(barangays.Length)];
            string street = streets[random.Next(streets.Length)];
            int streetNumber = random.Next(1, 999);

            // Compose a full address string for the Address property in Dorm
            string fullAddress = $"{streetNumber} {street}, {barangay}, {city}, Metro Manila, Philippines";

            // Generate a random rating between 3.0 and 5.0 with one decimal place
            decimal rating = Math.Round((decimal)(3.0 + random.NextDouble() * 2.0), 1);

            // Generate latitude and longitude within Metro Manila area
            decimal latitude = 14.5995m + (decimal)(random.NextDouble() - 0.5);
            decimal longitude = 120.9842m + (decimal)(random.NextDouble() - 0.5);

            // Select a random category ID from our valid list instead of using all numbers 1-7
            int categoryId = validCategoryIds[random.Next(validCategoryIds.Length)];

            // Assign dorm to a random owner
            string ownerId = ownerIds[random.Next(ownerIds.Count)];

            // Create the dorm with proper model properties
            var dorm = new Dorm
            {
                Id = i,
                Name = dormName,
                Description =
                    $"{dormFeatures[random.Next(dormFeatures.Length)]} {descriptions[random.Next(descriptions.Length)]} {nearbyLandmarks[random.Next(nearbyLandmarks.Length)]}",
                Address = fullAddress,
                Rating = rating,
                IsVerified = random.Next(0, 10) >= 2, // 80% chance of being verified
                OwnerId = ownerId, // Assign to the selected owner
                CategoryId = categoryId,
                Latitude = latitude,
                Longitude = longitude,
                IsAvailable = random.Next(0, 10) <= 7, // 80% chance of being available
                CreatedAt = DateTime.Now.AddDays(-random.Next(1, 365)),
                UpdatedAt = DateTime.Now
            };

            dorms.Add(dorm);

            // Add 2-5 rooms for each dorm
            int roomCount = random.Next(2, 6);
            for (int j = 0; j < roomCount; j++)
            {
                // Base price for the room, with some variation
                decimal basePrice;

                // Set price range based on category and room size
                switch (categoryId)
                {
                    case 1: // Studio Type
                    case 4: // Single Studio
                        basePrice = random.Next(5000, 12000);
                        break;
                    case 2: // Apartment Type
                    case 5: // Double Studio
                        basePrice = random.Next(8000, 15000);
                        break;
                    case 3: // Dormitory
                        basePrice = random.Next(3000, 8000);
                        break;
                    case 6: // 2-Bedroom
                        basePrice = random.Next(15000, 25000);
                        break;
                    case 7: // 3-Bedroom
                        basePrice = random.Next(20000, 35000);
                        break;
                    default:
                        basePrice = random.Next(5000, 15000);
                        break;
                }

                // Add some random variation to the price
                decimal price = Math.Round(basePrice + (random.Next(-1000, 1000) / 100m) * 100, 0);

                // Create room
                var room = new Room
                {
                    Id = roomId++,
                    RoomNumber = $"Room {100 + j}-{i}", // Room number format: Room 100-1, Room 101-1, etc.
                    Description = $"A {RoomDescriptions[random.Next(RoomDescriptions.Length)]} room in {dormName}.",
                    DormId = i,
                    Capacity = random.Next(1, 5), // 1 to 4 people per room
                    PricePerMonth = price,
                    IsAvailable = random.Next(0, 10) <= 8, // 90% chance of being available
                    CreatedAt = DateTime.Now.AddDays(-random.Next(1, 365)),
                    UpdatedAt = DateTime.Now
                };

                rooms.Add(room);
            }

            // Assign 2-5 random amenities to each dorm
            int amenityCount = random.Next(2, 6);
            var assignedAmenities = new HashSet<int>();

            for (int j = 0; j < amenityCount; j++)
            {
                int amenityId = random.Next(1, 9); // 8 amenities from seed data
                if (assignedAmenities.Add(amenityId)) // Avoid duplicates
                {
                    dormAmenities.Add(new DormAmenity
                    {
                        DormId = i,
                        AmenityId = amenityId,
                        IsActive = true // Add this line to set IsActive
                    });
                }
            }

            // Assign 1-3 random tags to each dorm
            int tagCount = random.Next(1, 4);
            var assignedTags = new HashSet<int>();

            for (int j = 0; j < tagCount; j++)
            {
                int tagId = random.Next(1, 9); // 8 tags from seed data
                if (assignedTags.Add(tagId)) // Avoid duplicates
                {
                    dormTags.Add(new DormTag
                    {
                        DormId = i,
                        TagId = tagId
                    });
                }
            }

            // Add 3-6 images for each dorm
            int imageCount = random.Next(3, 7);
            for (int j = 0; j < imageCount; j++)
            {
                // Generate image dimensions suitable for a property listing
                int width = imageWidths[random.Next(imageWidths.Length)];
                int height = imageHeights[random.Next(imageHeights.Length)];

                // Generate a unique random number for each image
                int randomNumber = i * 100 + j + random.Next(1000); // Ensures uniqueness

                // Generate LoremFlickr URL with the new format
                string imageUrl = $"https://loremflickr.com/{width}/{height}?random={randomNumber}";

                // Create image captions based on index
                string caption;
                if (j == 0) caption = "Main View";
                else if (j == 1) caption = "Exterior";
                else if (j == 2) caption = "Interior";
                else if (j == 3) caption = "Bedroom";
                else if (j == 4) caption = "Bathroom";
                else caption = "Additional View";

                dormImages.Add(new Image
                {
                    Id = imageId++,
                    DormId = i,
                    Url = imageUrl,
                    Caption = caption,
                    IsPrimary = j == 0
                });
            }
        }

        modelBuilder.Entity<Dorm>().HasData(dorms);
        modelBuilder.Entity<Room>().HasData(rooms);
        modelBuilder.Entity<Image>().HasData(dormImages);
        modelBuilder.Entity<DormAmenity>().HasData(dormAmenities
            .Select((da, idx) => new { da.DormId, da.AmenityId, Id = idx + 1, IsActive = true, IsDeleted = false })
            .ToArray());
        modelBuilder.Entity<DormTag>()
            .HasData(dormTags.Select((dt, idx) =>
                new { dt.DormId, dt.TagId, Id = idx + 1, IsActive = true, IsDeleted = false }).ToArray());
    }

    private static readonly string[] RoomDescriptions =
    [
        "comfortable and well-lit",
        "cozy and quiet",
        "spacious and airy",
        "modern and stylish",
        "charming and homey",
        "functional and practical",
        "newly renovated",
        "fully furnished",
        "bright and cheerful",
        "clean and minimalist"
    ];
}