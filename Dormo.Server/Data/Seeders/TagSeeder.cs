using Dormo.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Data.Seeders;

public static class TagSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
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
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNhdCI+PHBhdGggZD0iTTEyIDVjLjY3IDAgMS4zNS4wOSAyIC4yNiAxLjc4LTIgNS4wMy0yLjg0IDYuNDItMi4yNiAxLjQuNTgtLjQyIDctLjQyIDcgLjU3IDEuMDcgMSAyLjI0IDEgMy40NEMyMSAxNy45IDE2Ljk3IDIxIDEyIDIxcy05LTMtOS03LjU2YzAtMS4yNS41LTIuNCAxLTMuNDQgMCAwLTEuODktNi40Mi0uNS03IDEuMzktLjU4IDQuNzIuMjMgNi41IDIuMjNBOS4wNCA5LjA0IDAgMCAxIDEyIDVaIi8+PHBhdGggZD0iTTggMTR2LjUiLz48cGF0aCBkPSJNMjAgMTR2LjUiLz48cGF0aCBkPSJNMTEuMjUgMTYuMjVoMS41TDEyIDE3bC0uNzUtLjc1WiIvPjwvc3ZnPg=="
            },
            new Tag
            {
                Id = 3, Name = "Female Only", Description = "Exclusive for female residents",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXZlbnVzIj48cGF0aCBkPSJNMTIgMTV2NyIvPjxwYXRoIGQ9Ik05IDE5aDYiLz48Y2lyY2xlIGN4PSIxMiIgY3k9IjkiIHI9IjYiLz48L3N2Zz4="
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
            },
            new Tag
            {
                Id = 9, Name = "Air Conditioning", Description = "Cooling system for comfortable room temperature",
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWFpci12ZW50Ij48cGF0aCBkPSJNNiAxMkg0YTIgMiAwIDAgMS0yLTJWNWEyIDIgMCAwIDEgMi0yaDE2YTIgMiAwIDAgMSAyIDJ2NWEyIDIgMCAwIDEtMiAyaC0yIi8+PHBhdGggZD0iTTYgOGgxMiIvPjxwYXRoIGQ9Ik0xOC4zIDE3LjdhMi41IDIuNSAwIDAgMS0zLjE2IDMuODMgMi41MyAyLjUzIDAgMCAxLTEuMTQtMlYxMiIvPjxwYXRoIGQ9Ik02LjYgMTUuNkEyIDIgMCAxIDAgMTAgMTd2LTUiLz48L3N2Zz4=",
                Type = TagType.Amenity
            },
            new Tag
            {
                Id = 10, Name = "Wi-Fi", Description = "High-speed wireless internet connection",
                Type = TagType.Amenity,
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXdpZmkiPjxwYXRoIGQ9Ik0xMiAyMGguMDEiLz48cGF0aCBkPSJNMiA4LjgyYTE1IDE1IDAgMCAxIDIwIDAiLz48cGF0aCBkPSJNNSAxMi44NTlhMTAgMTAgMCAwIDEgMTQgMCIvPjxwYXRoIGQ9Ik04LjUgMTYuNDI5YTUgNSAwIDAgMSA3IDAiLz48L3N2Zz4="
            },
            new Tag
            {
                Id = 11, Name = "Study Area", Description = "Dedicated space for studying", Type = TagType.Amenity,
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLW5vdGVib29rIj48cGF0aCBkPSJNMiA2aDQiLz48cGF0aCBkPSJNMiAxMGg0Ii8+PHBhdGggZD0iTTIgMTRoNCIvPjxwYXRoIGQ9Ik0yIDE4aDQiLz48cmVjdCB3aWR0aD0iMTYiIGhlaWdodD0iMjAiIHg9IjQiIHk9IjIiIHJ4PSIyIi8+PHBhdGggZD0iTTE2IDJ2MjAiLz48L3N2Zz4="
            },
            new Tag
            {
                Id = 12, Name = "Laundry", Description = "On-site laundry facilities", Type = TagType.Amenity,
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXdhc2hpbmctbWFjaGluZSI+PHBhdGggZD0iTTMgNmgzIi8+PHBhdGggZD0iTTE3IDZoLjAxIi8+PHJlY3Qgd2lkdGg9IjE4IiBoZWlnaHQ9IjIwIiB4PSIzIiB5PSIyIiByeD0iMiIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iMTMiIHI9IjUiLz48cGF0aCBkPSJNMTIgMThhMi41IDIuNSAwIDAgMCAwLTUgMi41IDIuNSAwIDAgMSAwLTUiLz48L3N2Zz4="
            },
            new Tag
            {
                Id = 13, Name = "Security", Description = "24/7 security personnel and CCTV", Type = TagType.Amenity,
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNjdHYiPjxwYXRoIGQ9Ik0xNi43NSAxMmgzLjYzMmExIDEgMCAwIDEgLjg5NCAxLjQ0N2wtMi4wMzQgNC4wNjlhMSAxIDAgMCAxLTEuNzA4LjEzNGwtMi4xMjQtMi45NyIvPjxwYXRoIGQ9Ik0xNy4xMDYgOS4wNTNhMSAxIDAgMCAxIC40NDcgMS4zNDFsLTMuMTA2IDYuMjExYTEgMSAwIDAgMS0xLjM0Mi40NDdMMy42MSAxMi4zYTIuOTIgMi45MiAwIDAgMS0xLjMtMy45MUwzLjY5IDUuNmEyLjkyIDIuOTIgMCAwIDEgMy45Mi0xLjN6Ii8+PHBhdGggZD0iTTIgMTloMy43NmEyIDIgMCAwIDAgMS44LTEuMUw5IDE1Ii8+PHBhdGggZD0iTTIgMjF2LTQiLz48cGF0aCBkPSJNNyA5aC4wMSIvPjwvc3ZnPg=="
            },
            new Tag
            {
                Id = 14, Name = "Common Room", Description = "Shared space for socializing", Type = TagType.Amenity,
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWFybWNoYWlyIj48cGF0aCBkPSJNMTkgOVY2YTIgMiAwIDAgMC0yLTJIN2EyIDIgMCAwIDAtMiAydjMiLz48cGF0aCBkPSJNMyAxNmEyIDIgMCAwIDAgMiAyaDE0YTIgMiAwIDAgMCAyLTJ2LTVhMiAyIDAgMCAwLTQgMHYxLjVhLjUuNSAwIDAgMS0uNS41aC05YS41LjUgMCAwIDEtLjUtLjVWMTFhMiAyIDAgMCAwLTQgMHoiLz48cGF0aCBkPSJNNSAxOHYyIi8+PHBhdGggZD0iTTE5IDE4djIiLz48L3N2Zz4="
            },
            new Tag
            {
                Id = 15, Name = "Kitchen", Description = "Shared cooking facilities", Type = TagType.Amenity,
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNvb2tpbmctcG90Ij48cGF0aCBkPSJNMiAxMmgyMCIvPjxwYXRoIGQ9Ik0yMCAxMnY4YTIgMiAwIDAgMS0yIDJINmEyIDIgMCAwIDEtMi0ydi04Ii8+PHBhdGggZD0ibTQgOCAxNi00Ii8+PHBhdGggZD0ibTguODYgNi43OC0uNDUtMS44MWEyIDIgMCAwIDEgMS40NS0yLjQzbDEuOTQtLjQ4YTIgMiAwIDAgMSAyLjQzIDEuNDZsLjQ1IDEuOCIvPjwvc3ZnPg=="
            },
            new Tag
            {
                Id = 16, Name = "Parking", Description = "Secure parking space", Type = TagType.Amenity,
                Icon =
                    "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNpcmNsZS1wYXJraW5nIj48Y2lyY2xlIGN4PSIxMiIgY3k9IjEyIiByPSIxMCIvPjxwYXRoIGQ9Ik05IDE3VjdoNGEzIDMgMCAwIDEgMCA2SDkiLz48L3N2Zz4="
            }
        );
    }
}