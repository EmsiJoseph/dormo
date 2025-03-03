using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dormo.Server.Migrations
{
    /// <inheritdoc />
    public partial class Addednewdorms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(912), new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1502), new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1586), new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1602), new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1603), new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1604), new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1608), new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1610), new DateTime(2025, 2, 27, 9, 12, 0, 383, DateTimeKind.Utc).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "9fb70076-59ae-4c78-ad6a-656a1f6dcb47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "44166e13-bd0b-4ed4-88e3-022468d59296");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "fc9d66f7-0936-45c8-aebe-fdbc345781ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "a0f16202-e29d-44b3-bcbe-c6e36a65dac1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bf28d584-4b7d-49a7-a5a0-b6fcb3d4c0fa", new DateTime(2025, 2, 27, 9, 12, 0, 604, DateTimeKind.Utc).AddTicks(7968), "AQAAAAIAAYagAAAAEGh+JtQlVoCukvzxiqdzT5jZX8IhFcF9/lLd5YhYvJGaxLdzlj1s/9VhIwdna1yyPg==", "e73a510e-9618-499b-9655-fcd100f1811b", new DateTime(2025, 2, 27, 9, 12, 0, 604, DateTimeKind.Utc).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cd5cf78c-48e7-4688-9155-4ddf2c2982dd", new DateTime(2025, 2, 27, 9, 12, 0, 563, DateTimeKind.Utc).AddTicks(3496), "AQAAAAIAAYagAAAAEHEYMB1sj7/9f3i6VjmVgrijbcu/XIwGjycCPvT+FoMwn1Xh+4TPQjzMlSfufczkOw==", "5eeae766-8b28-484f-ac90-7e1a42b822d3", new DateTime(2025, 2, 27, 9, 12, 0, 563, DateTimeKind.Utc).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "2b7c483a-bace-45ae-a50f-07bc30218255", new DateTime(2025, 2, 27, 9, 12, 0, 520, DateTimeKind.Utc).AddTicks(9420), "AQAAAAIAAYagAAAAECU+VoMjV1rO5FmKA1PmSmex9J4TdLL/rsXEjHo8eJ2f5S1/2AzLe75eow6cXxNjaA==", "5a7fdf41-ef63-4b84-b085-08b8b3f37744", new DateTime(2025, 2, 27, 9, 12, 0, 520, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "28c2bed9-2ac7-499c-9958-2b3a86cb072b", new DateTime(2025, 2, 27, 9, 12, 0, 477, DateTimeKind.Utc).AddTicks(5731), "AQAAAAIAAYagAAAAEA+t38nT6Ol26CZtLDAWCcULlqzDZdzL71yA4Cd1WqyPzQQTcnCeiv8d5sVDCPSnVw==", "571870df-bad7-4c9d-be1d-04824d941fcc", new DateTime(2025, 2, 27, 9, 12, 0, 477, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d6384ec3-1c26-47ca-8bdc-0a37604ab6d6", new DateTime(2025, 2, 27, 9, 12, 0, 434, DateTimeKind.Utc).AddTicks(163), "AQAAAAIAAYagAAAAEFYIqD4pRFZ591sA7GeqSgdJTy71Jnxaqkm4xUOc9NLFJMdOdqT8Azue9xwZfYP74Q==", "3cd9b5dc-63df-4d5b-9de9-17231387e838", new DateTime(2025, 2, 27, 9, 12, 0, 434, DateTimeKind.Utc).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "15015bab-afa3-455e-b7ab-72ead4deb67b", new DateTime(2025, 2, 27, 9, 12, 0, 386, DateTimeKind.Utc).AddTicks(2140), "AQAAAAIAAYagAAAAEFr1Vj0Crwq4i00ctHqJjsM26FO2rSna3z6qnfDBBjUAQxAhox0EMoIlhOUEzmNi8w==", "a8fd1607-f523-4979-a552-1edde0cbf2fb", new DateTime(2025, 2, 27, 9, 12, 0, 386, DateTimeKind.Utc).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2575), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2580), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2582), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2584), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2586), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2588), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2590), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2592), "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik06IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2594), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2596), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2598), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2600), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2602), "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik06IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2604), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2606), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2608), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2608) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2609), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsVerified", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 17, 12, 0, 649, DateTimeKind.Local).AddTicks(202), true, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7486), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7543), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7576), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7627), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7676), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7716), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7752), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7798), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7834), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsVerified", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7863), true, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 28, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7902), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7941), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7977), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8017), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8054), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8088), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8130), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8156), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 25, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8186), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8224), 4.7m, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "IsVerified", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8266), true, 4.6m, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "IsVerified", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8305), true, 5.0m, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8347), 4.2m, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8348) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8377), 4.0m, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8422), 3.7m, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8422) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8576), 3.6m, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8622), 3.7m, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 6, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8668), 3.7m, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8709), 4.2m, new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 1, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8754), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8789), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8827), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8875), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8906), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8907) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 19, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8949), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8987), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9012), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9049), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9076), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 10, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9102), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9145), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9146) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9185), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9209), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9252), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 5, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9284), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9317), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9352), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9397), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9423), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9459), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9492), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9528), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9557), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9592), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9592) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9632), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9672), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9713), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9746), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 8, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9791), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9826), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9866), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 31, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9906), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9906) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9937), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9974), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 1, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(13), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(40), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(41) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(75), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(76) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(110), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(154), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 9, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(185), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(186) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(214), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(240), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(270), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(309), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 6, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(346), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(373), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(374) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(417), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(439), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(476), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(477) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(504), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(526), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(566), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(599), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(635), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(680), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(709), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(736), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(778), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(814), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(840), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(877), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(909), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(946), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(946) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(970), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1000), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1028), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1067), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1092), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 10, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1126), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3425), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3657), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3658), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3659), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3661), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3662), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7097), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7437), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7440), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7441) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7525), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7527), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7527) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7529), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7531), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7532), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7560), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7562), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7563), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7614), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7616), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7618), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7619), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7661), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7662), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7664), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7666), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7667), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7668) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7669), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7669) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7704), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7706), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7707), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7707) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7709), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7710), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7742), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7744), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7745), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7777), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7779), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7779) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7780), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7782), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7784), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7785), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7821), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7822) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7824), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7826), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7826) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7827), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7849), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7849) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7851), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7852), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7888), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7890), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7891), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7892), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7894), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7895), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7928), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7930), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7931), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7932), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7934), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7935), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7965), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7966), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7967), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7969), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7970), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8006), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8008), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8009), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8010), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8043), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8044), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8045), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8047), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8075), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8077), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8078), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8079), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8081), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8113), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8114), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8116), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8117), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8118), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8124), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8145), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8147), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8148), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8149), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8149) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8177), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8179), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8180), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8211), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8213), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8214), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8215), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8217), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8218), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8250), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8251), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8252), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8254), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8259), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8294), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8296), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8297), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8298), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8335), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8337), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8338), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8339), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8341), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8366), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8367), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8368), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8370), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8371), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8409), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8410), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8411), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8413), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8414), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8416), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8559), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8561), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8561) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8563), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8564), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8610), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8612), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8613), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8614) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8615), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8616), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8646), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8648), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8657), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8658), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8659), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8697), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8698), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8700), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8701), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8702), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8702) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8704), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8743), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8744), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8745), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8747), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8748), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8748) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8772), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8774), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8774) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8775), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8776), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8778), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8816), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8817), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8818), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8819) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8820), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8821), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8862), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8863), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8864), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8866), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8867), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8867) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8869), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8869) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8896), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8898), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8899), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8900), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8939), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8940), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8941), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8943), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8973), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8975), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8975) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8976), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9001), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9003), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9004), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9005), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9032), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9034), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9035), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9036), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9038), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9039), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9063), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9065), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9066), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9067), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9069), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9070), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9093), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9095), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9096), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9133), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9135), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9136), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9138), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9139), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9139) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9168), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9169), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9170), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9172), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9172) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9173), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9179), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9200), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9202), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9202) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9203), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9240), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9241) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9242), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9243), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9243) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9244), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9246), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9274), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9275), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9276), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9277), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9301), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9311), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9342), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9344), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9344) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9345), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9346), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9384), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9387), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9388), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9390), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9391), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9412), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9413), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9414), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9416), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9417), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9442), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9443), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9444), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9449), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9452), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9452) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9453), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9481), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9482), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9483), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9484) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9485), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9485) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9486), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9486) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9513), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9513) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9515), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9519), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9522), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9545), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9546), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9547), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9548) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9549), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9550), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9552), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9574), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9576), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9577), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9579), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9585), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9614), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9616), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9617), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9619), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9624), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9625), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9661), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9662), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9663) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9664), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9665), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9666), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9667) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9700), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9701), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9703), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9704), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9705), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9707), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9735), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9736), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9737) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9738), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9739), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9739) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9740), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9778), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9779), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9781), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9781) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9782), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9783), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9785), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9785) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9814), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9815), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9816), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9816) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9817), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9819), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9820), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9853), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9855), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9856), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9857), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9858) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9860), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9890), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9891), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9893), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9896), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9928), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9930), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9931), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9931) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9961), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9962), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9964), new DateTime(2025, 2, 27, 9, 12, 0, 650, DateTimeKind.Utc).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(3), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(3) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(4), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(5), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(6) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(7), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(26), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(28), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(28) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(29), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(30), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(31) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(60), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(62), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(63), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(63) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(64), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(64) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(65), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(66) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(98), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(98) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(99), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(101), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(102), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(102) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(103), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(104) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(105), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(136), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(137) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(138), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(144), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(145) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(147), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(148), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(148) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(176), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(176) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(177), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(177) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(178), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(179), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(201), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(202), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(203), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(205), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(229), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(230), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(232), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(233), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(234), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(261), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(262), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(264), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(265), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(296), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(298), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(299), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(300), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(302), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(303), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(330), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(334), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(335), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(337), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(338), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(340), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(365), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(366), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(367), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(405), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(407), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(409), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(409) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(410), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(412), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(431), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(432), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(433) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(434), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(462), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(463) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(464), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(464) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(465), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(466) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(466), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(467) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(492), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(494), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(495), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(496), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(498), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(516), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(517), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(519), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(520), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(556), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(558), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(559), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(560), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(586), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(586) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(587), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(589), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(590), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(591), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(593), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(593) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(626), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(628), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(629), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(661), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(662), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(663), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(665), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(666), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(668), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(699), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(700), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(702), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(703), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(728), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(730), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(731), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(766), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(768), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(769), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(770), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(771), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(805), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(808), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(829), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(830), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(831), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(833), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(834), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(867), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(868), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(870), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(871), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(900), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(901), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(902), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(904), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(936), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(937), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(938), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(940), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(960), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(961), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(963), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(964), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(964) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(989), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(990), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(991), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(992) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(993), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(994), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(994) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1019), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1019) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1020), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1022), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1050), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1057), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1058) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1059), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1060), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1061), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1080), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1081), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1083), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1083) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1084), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1086), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1109), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1110), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1112), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1113), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1115), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1119), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1147), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1148), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1150), new DateTime(2025, 2, 27, 9, 12, 0, 651, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4055), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4487), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4488), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4490), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4491), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4492), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(5911), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(5955), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(5961), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7493), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7498), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7506), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7511), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7516), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 5, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7548), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7553), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7581), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7585), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7590), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7594), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7598), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7632), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7636), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7641), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7645), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7649), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7681), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7685), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7689), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7693), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7697), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7720), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7729), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7733), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7756), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7760), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7764), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7767), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7771), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7802), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 22, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7806), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7810), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7814), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7838), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7843), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7867), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7871), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7875), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7879), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7906), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7910), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 13, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7914), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7918), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7945), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7950), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7954), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7958), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7981), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7985), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7989), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7993), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8022), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8026), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8030), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8034), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 5, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8038), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8058), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8067), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8094), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8099), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8103), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8104) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 1, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8108), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8135), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8139), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8159), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8164), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8168), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8171), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8172) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 30, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8198), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8202), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8206), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8228), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8232), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8235), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8239), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8270), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8274), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8278), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8283), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8287), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8309), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8314), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8318), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8322), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8351), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8356), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8360), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8381), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8381) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8385), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 1, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8389), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 12, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8393), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8401), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8426), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8430), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8534), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8544), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8549), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 1, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8581), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8590), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8595), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8599), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8603), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8627), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8627) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8631), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8635), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8639), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8672), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8676), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8680), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8685), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8689), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8713), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8722), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8726), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8730), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8734), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8758), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8762), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8766), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8793), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8797), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8801), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8805), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8809), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8833), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8838), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8847), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 14, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8851), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8852) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8855), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8856) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8880), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8884), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 14, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8888), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8891), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8917), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8918) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8921), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 5, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8925), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8929), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8933), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8953), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8958), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8962), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8966), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8991), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8992) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8995), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9016), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9021), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9021) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9025), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9054), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9057), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9080), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 6, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9084), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9088), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9106), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9114), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9118), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9122), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9125), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9149), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9153), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9157), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9161), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9190), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9194), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9214), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9218), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9222), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9257), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9261), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9265), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9269), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9288), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 3, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9292), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9296), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9321), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9325), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9329), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9333), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9337), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9356), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9360), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9364), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9364) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9368), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9371), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9402), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9402) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9406), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9427), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9431), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9435), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9464), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9468), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9471), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9475), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9476) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9496), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9500), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9504), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9507), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9508) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9533), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9537), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9561), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9566), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9596), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9600), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9605), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9609), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9609) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9636), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9640), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9647), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9651), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 30, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9655), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9676), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9680), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9684), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9688), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9717), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9721), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9725), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 28, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9729), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 18, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9750), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9754), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9758), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9762), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9771), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 19, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9795), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9799), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9803), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9807), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9807) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9835), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9839), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9844), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9848), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9870), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9874), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9875) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9878), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9882), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9886), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9886) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9910), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9914), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9914) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9918), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9922), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9941), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 9, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9945), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9949), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9954), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9979), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9984), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9988), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9992), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9997), new DateTime(2025, 2, 27, 17, 12, 0, 650, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 3, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(17), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(20), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(44), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 16, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(48), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(52), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(80), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(84), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(84) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 31, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(88), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(92), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(114), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(115) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(118), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(119) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(122), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(126), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(127) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(130), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(158), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(162), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(166), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 23, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(169), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(190), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(194), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(219), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(223), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 28, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(244), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 4, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(248), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(252), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(256), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 18, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(280), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(284), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(288), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(314), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(318), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(322), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(350), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(354), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(355) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(359), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(359) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(377), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(382), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(382) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(386), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(386) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(390), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(393), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(422), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(426), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 12, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(444), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(448), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(452), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 29, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(456), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(480), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(484), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(508), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 5, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(512), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(530), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(534), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(542), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 17, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(546), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(550), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(570), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(574), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(578), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(608), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(612), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 29, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(616), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(620), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(621) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(638), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(642), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(646), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 1, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(650), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(654), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(684), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(684) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(688), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(692), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(692) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(714), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(718), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(722), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(723) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(741), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 12, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(749), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(753), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(754) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(757), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 22, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(782), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 24, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(786), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(790), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(794), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(819), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(822), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(844), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(845) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(852), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(856), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(860), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(881), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(885), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(889), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(893), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(913), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 24, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(922), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 31, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(926), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(930), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 22, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(950), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(954), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(975), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(979), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(980) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1004), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1008), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1012), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1013) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1032), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1036), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1041), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1044), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1071), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 24, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1075), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1097), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1101), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1130), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 8, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1134), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1138), new DateTime(2025, 2, 27, 17, 12, 0, 651, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4917), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5233), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNhdCI+PHBhdGggZD0iTTEyIDVjLjY3IDAgMS4zNS4wOSAyIC4yNiAxLjc4LTIgNS4wMy0yLjg0IDYuNDItMi4yNiAxLjQuNTgtLjQyIDctLjQyIDcgLjU3IDEuMDcgMSAyLjI0IDEgMy40NEMyMSAxNy45IDE2Ljk3IDIxIDEyIDIxcy05LTMtOS03LjU2YzAtMS4yNS41LTIuNCAxLTMuNDQgMCAwLTEuODktNi40Mi0uNS03IDEuMzktLjU4IDQuNzIuMjMgNi41IDIuMjNBOS4wNCA5LjA0IDAgMCAxIDEyIDVaIi8+PHBhdGggZD0iTTggMTR2LjUiLz48cGF0aCBkPSJNMjAgMTR2LjUiLz48cGF0aCBkPSJNMTEuMjUgMTYuMjVoMS41TDEyIDE3bC0uNzUtLjc1WiIvPjwvc3ZnPg==", new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5235), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5237), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5238), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5240), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5241) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5242), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5243), new DateTime(2025, 2, 27, 9, 12, 0, 384, DateTimeKind.Utc).AddTicks(5244) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6605), new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6689), new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6691), new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6692), new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6694), new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6695), new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6697), new DateTime(2025, 2, 27, 8, 27, 51, 50, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "157e89cc-c0a6-4ab9-93ac-322d98075c2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "689fa840-dd09-4c89-aa80-76ec8bb7efc6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0be5e66b-0698-49ca-b757-7d7ae56fb6a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "393db02c-9317-44df-830e-5516f3283360");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0e363a0f-6897-407c-bf84-cb1d2e5a8082", new DateTime(2025, 2, 27, 8, 27, 51, 313, DateTimeKind.Utc).AddTicks(5933), "AQAAAAIAAYagAAAAECUHKhGxTomm0FGmzLCuz8atUAquH+bGBm34L6BmoFCbGngnxBUjHIwHTMl5J0R8zA==", "d0c03272-539c-4fac-acba-96bd9536987a", new DateTime(2025, 2, 27, 8, 27, 51, 313, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "33ce537b-6788-4a63-915a-36f1b2580cf1", new DateTime(2025, 2, 27, 8, 27, 51, 269, DateTimeKind.Utc).AddTicks(3257), "AQAAAAIAAYagAAAAEDmjSmnKGUEwb55A83XWmxvTZ/iph1XS+QeHhr7KcYfIs9dU5qv8Ul5LYnQbBbP91w==", "950b999b-d1e6-40c5-83c8-0da1bcb00ec1", new DateTime(2025, 2, 27, 8, 27, 51, 269, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bfd2d3d9-747c-4b21-bfef-1acf594c60be", new DateTime(2025, 2, 27, 8, 27, 51, 223, DateTimeKind.Utc).AddTicks(5043), "AQAAAAIAAYagAAAAEJXOUBi9Eoyffysnv+OIJ6JifaD7o45lX3hf3RGYbX9bJ7hNyCE7HIx1foHn4mSCqg==", "b5fef355-6e50-44bb-975b-bd0700fa9724", new DateTime(2025, 2, 27, 8, 27, 51, 223, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7b68de60-1ebc-48a8-9bc7-4d0df4099680", new DateTime(2025, 2, 27, 8, 27, 51, 170, DateTimeKind.Utc).AddTicks(2699), "AQAAAAIAAYagAAAAEJc0zZtZcoSRn/oVrNLEyPOOCqjg6zZwPWhl+Jr2oZUH+Qr1yzB4db7xppVrzK5DUw==", "be49be60-1463-47b1-a250-0137f6eb23c2", new DateTime(2025, 2, 27, 8, 27, 51, 170, DateTimeKind.Utc).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1af6023d-748b-481d-aa82-7c7d3d4f5de9", new DateTime(2025, 2, 27, 8, 27, 51, 125, DateTimeKind.Utc).AddTicks(2673), "AQAAAAIAAYagAAAAEEqCSB1Bk2nSUqKPDhGZBMWnyCs0TQnTtDhuBMA4wkHXknR2tRZA37h7m+5LBZ7IMw==", "419a7359-4179-4d31-b93f-86572ae8de5e", new DateTime(2025, 2, 27, 8, 27, 51, 125, DateTimeKind.Utc).AddTicks(2677) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b8d9be0c-f984-4d7a-8b41-15b6d393b964", new DateTime(2025, 2, 27, 8, 27, 51, 53, DateTimeKind.Utc).AddTicks(9561), "AQAAAAIAAYagAAAAEFXsn4J/pzP/7dNqyzCU/992odkYa6tho19FfKSlGtnl8427GqcOXSz0K4iNT/Gx1w==", "d18d8cb4-4ee0-4177-bd22-413f2fa3e1e1", new DateTime(2025, 2, 27, 8, 27, 51, 53, DateTimeKind.Utc).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7023), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7536), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7538), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7541), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7542), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7544), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7546), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7548), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7550), "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik02IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7552), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7552) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7554), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7555), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7557), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7557) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7559), "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik02IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7560), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7561) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7563), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7565), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7566), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsVerified", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 27, 51, 373, DateTimeKind.Local).AddTicks(7665), false, new DateTime(2025, 2, 27, 16, 27, 51, 375, DateTimeKind.Local).AddTicks(9687) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1105), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1288), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1372), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1482), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1592), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1675), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1728), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1807), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1874), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "IsVerified", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1928), false, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2000), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2071), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2138), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2225), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2330), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2380), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2483), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2529), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2596), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2647), 4.2m, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "IsVerified", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2736), false, 4.1m, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "IsVerified", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2807), false, 4.8m, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2891), 3.7m, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2944), 3.5m, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3042), 3.2m, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3122), 3.1m, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3187), 3.2m, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3263), 3.2m, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Rating", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3368), 3.7m, new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3443), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3512), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3579), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3677), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3746), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3748) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3812), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3891), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3942), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4012), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4058), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4113), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4189), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4267), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4309), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4381), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4434), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4497), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4555), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4645), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4688), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4689) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4757), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4815), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4888), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4942), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4944) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5010), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5095), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5159), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5242), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5302), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5391), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5462), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5463) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5522), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5592), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5649), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5720), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5797), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5856), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5929), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5992), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6070), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6125), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6186), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6232), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6302), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6304) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6365), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6367) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6435), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6480), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6555), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6593), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6664), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6665) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6711), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6770), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6833), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6901), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6956), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7034), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7084), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7149), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7216), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7293), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7350), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7408), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7478), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7532), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7596), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7644), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7690), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7759), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7799), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7863), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8294), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8474), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8476), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8478), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8479), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8480), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 376, DateTimeKind.Utc).AddTicks(9898), new DateTime(2025, 2, 27, 8, 27, 51, 376, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1015), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1017) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1034), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1035) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1228), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1232), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1237), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1239), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1242), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1349), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1353), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1356), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1459), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1464), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1466), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1562), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1565), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1570), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1572), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1575), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1577), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1641), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1644), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1646), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1649), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1661), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1709), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1711), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1714), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1716), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1773), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1775), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1785), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1788), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1791), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1793), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1853), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1853) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1855), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1858), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1860), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1862), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1910), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1915), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1975), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1977), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1980), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1982), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1984), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1987), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2048), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2050), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2051) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2053), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2055), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2058), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2060), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2116), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2119), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2121), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2123), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2126), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2188), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2190), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2193), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2195), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2294), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2297), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2299), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2316), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2359), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2361), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2363), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2366), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2368), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2369) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2458), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2461), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2463), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2466), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2468), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2470), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2511), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2514), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2516), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2579), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2582), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2584), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2625), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2628), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2630), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2633), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2635), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2637), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2712), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2715), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2717), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2720), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2722), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2787), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2789), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2792), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2794), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2794) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2869), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2872), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2874), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2876), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2879), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2924), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2926), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2929), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2931), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2932) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2934), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3019), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3021), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3024), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3026), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3027) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3029), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3031), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3084), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3086), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3088), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3110), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3167), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3170), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3172), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3175), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3177), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3227), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3238), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3244), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3247), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3249), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3251), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3311), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3313), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3315), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3318), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3320), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3341), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3422), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3424), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3427), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3429), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3432), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3475), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3492), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3497), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3499), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3499) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3559), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3562), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3564), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3567), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3569), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3654), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3656), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3658), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3661), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3663), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3666), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3712), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3715), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3730), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3733), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3793), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3796), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3796) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3798), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3799) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3801), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3873), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3875), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3877), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3922), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3925), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3925) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3927), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3930), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3977), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3991), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3991) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3993), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3996), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3998), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4001), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4037), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4039), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4041), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4044), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4046), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4049), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4086), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4087) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4089), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4101), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4101) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4167), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4170), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4172), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4175), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4175) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4177), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4242), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4244), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4247), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4247) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4249), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4251), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4254), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4294), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4297), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4299), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4360), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4362), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4363) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4365), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4367), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4369), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4417), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4419), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4421), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4424), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4479), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4481), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4484), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4538), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4541), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4543), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4546), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4622), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4624), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4627), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4627) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4629), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4632), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4669), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4671), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4674), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4676), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4732), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4735), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4737), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4739), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4742), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4744), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4795), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4797), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4799), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4802), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4804), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4868), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4870), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4873), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4875), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4918), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4920), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4923), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4925), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4928), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4930), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4987), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4990), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4992), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4995), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4997), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5049), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5069), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5071), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5074), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5076), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5079), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5139), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5141), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5144), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5146), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5149), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5217), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5219), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5222), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5224), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5226), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5229), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5282), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5283) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5284), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5287), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5289), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5292), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5362), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5365), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5367), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5370), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5372), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5374), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5428), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5428) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5430), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5433), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5433) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5435), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5435) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5447), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5447) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5450), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5500), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5504), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5507), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5509), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5512), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5570), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5572), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5575), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5578), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5580), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5633), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5636), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5638), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5701), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5704), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5704) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5706), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5775), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5777), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5780), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5782), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5837), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5839), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5842), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5844), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5906), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5909), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5911), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5916), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5968), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5971), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5973), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5976), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5978), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5981), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6049), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6051), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6054), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6054) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6056), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6058), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6108), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6111), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6116) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6166), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6169), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6171), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6212), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6213) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6215), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6217), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6219), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6222), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6267), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6285), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6288), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6289) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6291), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6342), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6344), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6344) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6346), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6349), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6351), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6354), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6412), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6414), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6417), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6419), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6421), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6424), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6466), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6469), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6469) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6471), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6536), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6538), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6540), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6543), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6545), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6579), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6581), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6584), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6642), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6644), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6646), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6649), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6692), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6694), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6696), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6699), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6701), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6701) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6732), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6734), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6736), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6739), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6816), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6818), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6820), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6823), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6867), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6869), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6872), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6874), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6886), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6889), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6940), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6943), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6945), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7000), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7012), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7015), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7017), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7019), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7022), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7067), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7069), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7072), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7074), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7119), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7122), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7137), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7193), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7195), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7200), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7203), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7272), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7274), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7277), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7319), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7322), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7324), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7335), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7338), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7390), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7393), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7395), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7398), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7448), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7450), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7463), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7464) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7466), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7516), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7520), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7523), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7559), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7561), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7564), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7567), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7624), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7626), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7629), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7631), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7634), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7675), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7678), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7680), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7743), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7745), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7746) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7780), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7782), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7785), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7787), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7790), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7838), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7840), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7841) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7843), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7845), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7848), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7850), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7900), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7903), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7905), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8795), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9214), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9216), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9217), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9219), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9221), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 16, 27, 51, 376, DateTimeKind.Local).AddTicks(6390), new DateTime(2025, 2, 27, 16, 27, 51, 376, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 16, 27, 51, 376, DateTimeKind.Local).AddTicks(6540), new DateTime(2025, 2, 27, 16, 27, 51, 376, DateTimeKind.Local).AddTicks(6542) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 27, 51, 376, DateTimeKind.Local).AddTicks(6553), new DateTime(2025, 2, 27, 16, 27, 51, 376, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1134), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1145), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1161), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1168), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1185), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1301), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1315), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1382), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1388), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1395), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1401), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1408), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1498), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1499) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1505), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1532), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1540), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1547), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1600), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1606), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1613), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1619), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1625), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1683), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1690), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1696), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1734), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1740), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1747), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1753), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1754) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1759), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1819), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1826), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1832), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1838), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1882), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1888), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1937), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1944), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1950), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1957), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2008), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2015), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2030), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2038), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2079), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2085), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2092), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2098), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2153), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2162), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2168), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2175), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2234), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2241), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2247), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2278), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2284), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2338), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2344), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2402), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2410), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2417), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2418) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2427), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2492), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2498), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2537), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2544), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2550), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2551) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2556), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2604), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2610), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2616), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2654), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2660), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2667), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2668) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2673), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2743), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2750), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2757), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2764), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2770), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2831), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2840), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2846), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2852), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2853) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2900), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2906), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2913), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2978), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2985), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2992), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2999), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3005), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3049), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3056), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3062), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3068), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3069) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3075), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3130), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3137), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3144), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3150), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3156), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3194), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3200), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3207), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3213), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3272), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3278), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3285), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3291), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3298), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3378), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3384), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3391), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3398), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3405), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3451), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3457), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3464), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3522), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3528), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3535), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3542), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3548), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3593), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3619), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3627), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3633), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3639), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3684), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3691), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3697), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3704), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3755), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3762), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3768), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3775), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3781), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3782) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3819), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3826), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3827) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3832), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3839), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3899), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3906), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3950), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3957), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3963), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4020), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4026), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4027) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4064), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4071), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4077), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4123), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4129), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4136), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4142), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4149), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4197), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4198) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4203), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4209), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4215), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4216) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4275), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4282), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4317), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4324), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4330), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4389), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4395), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4401), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4408), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4440), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4447), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4466), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4504), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4510), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4516), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4522), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4528), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4529) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4562), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4568), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4569) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4574), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4600), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4609), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4652), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4659), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4695), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4702), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4702) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4708), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4765), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4771), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4778), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4784), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4822), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4828), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4834), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4855), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4896), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4903), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4950), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4956), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5019), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5025), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5032), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5039), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5103), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5109), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5116), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5122), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5128), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5168), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5174), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5193), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5202), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5249), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5260), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5267), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5273), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5323), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5332), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5338), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5344), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5350), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5397), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5404), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5410), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5416), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5470), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5476), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5483), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5490), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5528), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5535), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5541), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5547), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5553), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5601), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5607), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5614), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5620), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5656), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5663), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5664) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5670), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5676), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5735), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5743), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5750), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5756), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5757) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5763), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 3, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5804), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5811), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5812) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5865), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5871), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5878), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5937), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5943), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5949), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5956), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6000), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6006), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6013), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6019), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6036), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6078), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6085), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6091), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6097), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6132), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6139), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6194), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6201), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6240), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6246), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6259), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6311), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6317), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6318) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6324), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6324) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6373), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6374) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6393), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6402), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6403) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6442), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6449), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6455), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6487), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6494), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6501), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6502) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6516), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6523), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6563), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6569), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6599), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6606), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6612), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6619), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6672), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6678), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6679) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6718), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6724), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6778), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6784), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6791), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6798), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6805), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6840), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6847), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6853), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6909), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6916), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6922), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6929), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6962), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6969), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6975), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6981), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6987), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7041), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7048), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7054), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7096), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7102), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7109), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7158), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7164), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7170), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7176), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7224), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7230), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7237), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7243), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7301), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7308), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7358), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7365), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7371), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7378), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7417), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7423), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7424) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7430), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7436), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7486), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7493), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7499), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7505), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7540), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7546), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7606), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7613), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7651), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7658), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7664), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7697), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7698) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7704), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7720), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7728), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7766), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 24, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7772), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7806), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7812), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7871), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7877), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7884), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9556), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9809), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNhdCI+PHBhdGggZD0iTTEyIDVjLjY3IDAgMS4zNS4wOSAyIC4yNiAxLjc4LTIgNS4wMy0yLjg0IDYuNDItMi4yNiAxLjQuNTgtLjQyIDctLjQyIDcgLjU3IDEuMDcgMSAyLjI0IDEgMy40NEMyMSAxNy45IDE2Ljk3IDIxIDEyIDIxcy05LTMtOS03LjU2YzAtMS4yNS41LTIuNCAxLTMuNDQgMCAwLTEuODktNi40Mi0uNS03IDEuMzktLjU4IDQuNzIuMjMgNi41IDIuMjNBOS4wNCA5LjA0IDAgMCAxIDEyIDVaIi8+PHBhdGggZD0iTTggMTR2LjUiLz48cGF0aCBkPSJNMTYgMTR2LjUiLz48cGF0aCBkPSJNMTEuMjUgMTYuMjVoMS41TDEyIDE3bC0uNzUtLjc1WiIvPjwvc3ZnPg==", new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9811), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9812), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9814), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9814) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9815), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9817), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9817) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9818), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9818) });
        }
    }
}
