using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dormo.Server.Migrations
{
    /// <inheritdoc />
    public partial class Updatedtagsandamenities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9296), new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9742), new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9818), new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9818) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9829), new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9830), new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9832), new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9833), new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9834), new DateTime(2025, 2, 27, 8, 5, 34, 722, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "09350f9a-0690-4e85-b355-4410320bc19b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "791312c9-b502-467f-aaf9-e3b8d85e67e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6de63bc1-9575-495c-8b9e-35d5aa781d9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "5cd71b49-b989-4152-8b3f-62f5bcf8327a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "85d8f72c-5e36-4f62-a5ff-e2d85811c459", new DateTime(2025, 2, 27, 8, 5, 34, 948, DateTimeKind.Utc).AddTicks(5395), "AQAAAAIAAYagAAAAEIIwwsdIqjPQWVyvvp6dxii7GlClGXYuyMSQiBZ91W3iOjdJMJWonXY59gy4Qom5Gg==", "bd1a2398-b8e5-4a88-b4dd-03a9b4b05237", new DateTime(2025, 2, 27, 8, 5, 34, 948, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "eb564e48-b74b-4a91-93b4-46b8191504ed", new DateTime(2025, 2, 27, 8, 5, 34, 902, DateTimeKind.Utc).AddTicks(901), "AQAAAAIAAYagAAAAEFvULHkCXyUlBU2enqU6qvjBAFbDeel3BEUAYpoYntFWT2YdCR++VADL4htRfBfK9A==", "e4ee0ced-8d65-48c6-8f95-097d684837d9", new DateTime(2025, 2, 27, 8, 5, 34, 902, DateTimeKind.Utc).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "223e227a-9fdd-4cbb-9cbe-c5cbb13578db", new DateTime(2025, 2, 27, 8, 5, 34, 856, DateTimeKind.Utc).AddTicks(912), "AQAAAAIAAYagAAAAEG5pj/k4F0xbfp1jxJh9irP56oOMM8gIW5VaYdmFFpWT+0tbNwqBswTqXi7CUYKPyw==", "0b74d862-22f9-4985-94ca-4817de9a0f07", new DateTime(2025, 2, 27, 8, 5, 34, 856, DateTimeKind.Utc).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f53a6227-f155-45dc-b5c7-ac7df9611c41", new DateTime(2025, 2, 27, 8, 5, 34, 811, DateTimeKind.Utc).AddTicks(9927), "AQAAAAIAAYagAAAAENitR1KrXqBDIJ46kyVUpjOPj0WsK9Fj7XAMP8bbLVfq8wJmsTuIfGq7UWgSHuZDJw==", "2cfe09c4-17ef-4371-8914-d1484af4443d", new DateTime(2025, 2, 27, 8, 5, 34, 811, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7edfa121-eb29-4b69-968e-e33b07856a5a", new DateTime(2025, 2, 27, 8, 5, 34, 771, DateTimeKind.Utc).AddTicks(462), "AQAAAAIAAYagAAAAEIvVPw4amLuauAXFVXz6lSQY2SqmHDAjKMLmZNV3NVBOYkCQV7h/sZvRA0/Ecz7ITA==", "97e3b987-a670-4211-a968-b33fd434d616", new DateTime(2025, 2, 27, 8, 5, 34, 771, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "875252b0-b84b-40b5-990e-05a38afd5d20", new DateTime(2025, 2, 27, 8, 5, 34, 725, DateTimeKind.Utc).AddTicks(9469), "AQAAAAIAAYagAAAAEGAG0/Sh8UkvKol1OfuoWIHjSd9EjJXYfgM3F1/mEdj3Elu0I7xDlew5mWLAJ8bR6Q==", "8b891fb3-f7c5-4543-8206-d1be31a13146", new DateTime(2025, 2, 27, 8, 5, 34, 725, DateTimeKind.Utc).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9084), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9599), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9602), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9604), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9606), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9608), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9610), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9612), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9612) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9614), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9616), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9618), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9620), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9622), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9623), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9626), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9642), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9644), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9645) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9646), new DateTime(2025, 2, 27, 8, 5, 34, 723, DateTimeKind.Utc).AddTicks(9646) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 5, 35, 1, DateTimeKind.Local).AddTicks(632), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6132), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6210), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6238), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6295), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6341), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6388), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6389) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6419), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6466), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6507), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6531), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6578), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6613), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6654), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6689), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6731), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6758), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6801), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6826), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6862), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6891), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6934), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6982), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7021), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7056), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7096), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7097) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7135), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7173), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7215), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7258), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7298), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7299) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7425), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7490), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7541), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7578), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 19, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7616), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7617) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7655), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7680), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7720), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7747), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7777), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7816), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7857), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7882), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7919), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7950), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7981), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8016), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8017) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8058), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8058) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8082), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8119), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8152), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8191), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8220), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8253), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8254) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8294), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8331), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8373), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8405), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8448), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8488), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8523), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8564), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8596), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8633), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8672), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8700), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8737), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8771), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8772) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8816), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8848), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8877), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8903), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8933), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8969), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9003), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9030), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9072), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9095), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9096) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9127), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9160), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9182), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9226), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9226) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9258), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9259) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9295), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9334), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9368), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9395), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9437), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9474), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9501), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9502) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9538), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9538) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9571), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9606), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9632), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9663), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9664) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9690), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9723), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9724) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9753), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9753) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9782), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(377), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(548), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(550), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(551), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(552), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(554), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(5758), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6090), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6093), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6192), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6193), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6196), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6198), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6198) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6199), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6227), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6229), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6231), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6283), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6284), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6286), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6288), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6326), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6327), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6330), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6331), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6333), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6334), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6375), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6376), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6378), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6378) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6379), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6381), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6381) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6408), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6410), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6411), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6411) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6413), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6451), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6453), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6454), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6456), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6458), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6460), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6490), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6491), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6497), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6499), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6500), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6522), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6524), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6525), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6558), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6564), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6567), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6568), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6570), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6571), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6600), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6601) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6602), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6603), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6605), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6606), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6608), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6608) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6642), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6643), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6645), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6646), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6647), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6648) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6677), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6678), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6679), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6681), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6720), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6721), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6723), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6724), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6747), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6748), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6749), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6750), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6752), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6788), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6789), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6790), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6792), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6793), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6815), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6817), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6818), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6819), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6854), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6855), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6856), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6878), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6880), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6881), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6882), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6884), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6885), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6922), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6924), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6925), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6926), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6928), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6971), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6973), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6974), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6975), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6976) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7009), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7010), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7011), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7013), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7014), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7039), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7045), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7047), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7049), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7050), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7084), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7085), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7086), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7087), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7089), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7091), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7125), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7126), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7128), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7129), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7161), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7162), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7164), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7165), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7167), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7201), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7202), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7205), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7206), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7207), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7209), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7246), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7247), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7248), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7249) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7250), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7251), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7253), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7287), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7289), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7290), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7291), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7293), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7321), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7322), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7324), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7325), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7326), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7471), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7473), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7474), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7476), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7478), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7528), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7529), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7531), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7532), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7533), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7535), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7568), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7569), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7571), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7572), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7604), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7606), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7608), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7609), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7646), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7648), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7649), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7670), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7671), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7673), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7674), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7708), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7709), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7712), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7713), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7715), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7734), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7736), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7737), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7737) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7739) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7740), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7741) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7769), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7770), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7771), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7805), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7806), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7808), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7808) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7809), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7810), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7844), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7845), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7847), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7848), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7849), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7851), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7873), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7874), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7875), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7876) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7907), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7908), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7910), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7911), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7912), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7940), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7941), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7943), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7944), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7972), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7974), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7975), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8007), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8008), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8009), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8010), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8046), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8047), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8049), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8050), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8051), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8071), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8073), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8074), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8075), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8077), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8106), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8107), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8109), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8110), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8111), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8113), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8141), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8142), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8143), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8145), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8146), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8181), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8182), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8183), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8185), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8208), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8209), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8209) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8210), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8211), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8213), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8213) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8214), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8240), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8243), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8245), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8246), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8247), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8275), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8282), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8284), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8284) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8286), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8288), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8320), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8321), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8322), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8324), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8325), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8359), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8361), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8362), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8363), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8365), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8366), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8395), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8397), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8398), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8399), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8436), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8437), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8437) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8438), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8439), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8441), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8442), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8471), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8472), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8474), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8475), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8476), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8478), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8511), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8511) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8512), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8513), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8515), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8516), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8518), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8548), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8548) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8549), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8550), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8551) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8552), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8552) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8553), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8587), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8588), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8590), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8619), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8619) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8620), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8622), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8663), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8664), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8666), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8686), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8687), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8687) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8689), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8690), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8720), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8721), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8723), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8724), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8725), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8759), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8760), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8762), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8763), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8764), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8766), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8798), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8799), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8799) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8800), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8802), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8810), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8838), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8839), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8841), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8842), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8864), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8864) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8865), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8866), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8866) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8867), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8892), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8893), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8895), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8896), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8897), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8924), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8925), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8926), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8928), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8957), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8957) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8958), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8960), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8961), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8963), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8964), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8987), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8988), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8989), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8991), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8996), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8997), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9021), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9023), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9023) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9024), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9057), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9058), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9059), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9061), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9065), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9086), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9088), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9089), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9118), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9119), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9120), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9121) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9122), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9149), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9150), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9151), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9153), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9154), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9173), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9174), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9175), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9177), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9216), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9217), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9219), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9220), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9245), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9247), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9248), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9250), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9251), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9251) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9253), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9287), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9288), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9289), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9322), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9323), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9324), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9326), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9327), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9329), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9357), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9358), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9360), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9361), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9387), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9388), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9389), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9424), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9426), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9427), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9428), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9428) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9430), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9465), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9465) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9466), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9467) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9468), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9468) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9489), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9491), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9492), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9493), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9493) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9494), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9495) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9528), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9528) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9529), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9531), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9532), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9561), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9562), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9564), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9565), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9595), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9597), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9598) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9599), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9600), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9621), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9622), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9623), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9625), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9646), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9648), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9648) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9649), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9651), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9652), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9682), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9684), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9685), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9685) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9712), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9713), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9713) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9715), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9716), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9716) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9717), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9718) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9740), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9742), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9743), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9744) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9745), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9746), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9771), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9773), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9774), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9776), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9777), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9810), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9811), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9813), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(858), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1195), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1196), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1198), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1199), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1200), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(4509), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(4547), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(4553), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6142), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6147), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6156), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6160), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6165), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6214), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6220), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6243), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6248), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6252), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6256), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6260), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6302), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6306), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6311), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6315), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6319), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6345), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6349), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6359), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6364), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6368), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6368) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6392), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6396), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6397) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6401), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6423), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6434), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6438), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6442), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6442) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6445), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6471), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6472) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6475), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6479), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6483), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6511), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6512) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6515), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6536), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6540), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6544), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6548), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6582), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6586), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6590), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6594), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6618), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6622), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6626), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6630), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6658), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6662), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6666), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6670), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6693), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6697), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6707), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6711), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6715), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6735), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6739), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6763), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6773), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6778), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6783), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6805), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6809), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6835), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6840), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6844), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6844) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6848), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6866), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6870), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6874), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6895), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6899), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6908), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6912), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6938), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6942), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6946), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6950), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6954), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6986), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6991), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6995), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(6999), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7025), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7029), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7033), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7060), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7064), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7068), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7072), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7076), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7100), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7104), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7108), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7112), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7120), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7139), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7143), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7147), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7151), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7155), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7177), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7181), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7185), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7193), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7219), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7223), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7227), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7231), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7235), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7262), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7266), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7270), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7274), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7278), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7302), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7307), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7315), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7441), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7446), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7451), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7454), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7459), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7502), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7508), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7512), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7517), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7521), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7521) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7546), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7550), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7554), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7558), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7582), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7587), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7590), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7595), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7598), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7621), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7625), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7629), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7633), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7659), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7664), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7684), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7689), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7693), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7724), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7728), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7751), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7755), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7759), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7781), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7786), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7790), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7793), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7797), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7820), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7824), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7824) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7828), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7831), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7861), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7866), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7886), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7890), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7894), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7924), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7928), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7932), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7936), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7954), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7963), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7967), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7985), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7989), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7993), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7997), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8001), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8020), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8024), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8028), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8029) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8036), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8040), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8062), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8066), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8066) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8087), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8091), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8095), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8123), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8127), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8131), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8135), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8135) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8156), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8160), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8164), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8165) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8168), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8196), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8200), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8224), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8228), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8257), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8262), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8262) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8266), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8266) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8270), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8298), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8299) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8302), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8306), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8310), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8314), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8335), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8339), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8343), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8347), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8377), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8381), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8385), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8389), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8409), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8413), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8417), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8425), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8429), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 19, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8453), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8456), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8460), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8464), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8465) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8492), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8497), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8501), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8505), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8527), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8531), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8535), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8539), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8543), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8543) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8568), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8572), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8577), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8581), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8600), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8604), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8608), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8612), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8612) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8638), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8642), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8647), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8651), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8655), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 3, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8676), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8680), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8704), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8705) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8708), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8712), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8712) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8741), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8745), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8748), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8752), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8776), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8776) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8779), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8783), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8787), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8792), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8820), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8824), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8828), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8832), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8852), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8857), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8857) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8881), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8885), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8907), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8911), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8915), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8919), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8937), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8945), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8949), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8973), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8977), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8982), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9008), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9012), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9016), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9016) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9034), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9038), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9042), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9046), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9050), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9077), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9081), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9099), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9103), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9107), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9111), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9132), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9132) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9141), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9164), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9168), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9187), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9191), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9195), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9199), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9203), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9230), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9234), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9238), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9239) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9263), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9263) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9267), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9271), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9275), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9299), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9303), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9307), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9311), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9315), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9338), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9342), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9343) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9350), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9372), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9373) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9376), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9381), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9399), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9403), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9407), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9411), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9411) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9441), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9445), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9449), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9449) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9453), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9479), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9483), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9483) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9505), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9509), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9513), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9517), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9542), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9546), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9550), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9554), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9575), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9579), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9582), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9587), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9610), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9611) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9614), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9636), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9640), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9668), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9668) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9671), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9672) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9676), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9694), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9699), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9703), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9706), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9727), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9728) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 24, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9736), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9736) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9757), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9758) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9761), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9787), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 8, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9792), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9796), new DateTime(2025, 2, 27, 16, 5, 35, 2, DateTimeKind.Local).AddTicks(9796) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1500), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1716), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1718), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1719), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1721), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1722), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1723), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1724), new DateTime(2025, 2, 27, 8, 5, 34, 724, DateTimeKind.Utc).AddTicks(1725) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(609), new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1097), new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1177), new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1190), new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1191), new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1193), new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1194), new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1196), new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f20f9f31-c10b-4635-b790-3a671a503f67");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "b7ac3395-198d-4c83-ba7e-5a367f350e94");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "9e628f76-4fa8-4c1e-9ffc-ec5e6c0becbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "a8d9ad46-384c-45fd-a966-b45e78a6f012");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "09464444-544d-4123-b75c-92efa0e0c12e", new DateTime(2025, 2, 27, 7, 44, 12, 974, DateTimeKind.Utc).AddTicks(7145), "AQAAAAIAAYagAAAAEL23NMouFPYKngOm4opsz4Z0wRsu409BdwHKWGhdPE4Sr14By/Gr3dBiqFGEgMPGTQ==", "cd536abc-1cbe-48b7-a3cc-2dbe818c2a0d", new DateTime(2025, 2, 27, 7, 44, 12, 974, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b84dfb06-6e8e-4363-9c6c-fd58854e8c62", new DateTime(2025, 2, 27, 7, 44, 12, 931, DateTimeKind.Utc).AddTicks(4680), "AQAAAAIAAYagAAAAELcz698YnbApsmkfXBihEPLDYpyiMbLpkVEGDln6JwWLWJ43fYhW5MsHRXYvhzd7qA==", "2453c03b-a9b1-42a0-bcb9-979f3d463970", new DateTime(2025, 2, 27, 7, 44, 12, 931, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cdff2049-a069-42ee-832f-875088f84363", new DateTime(2025, 2, 27, 7, 44, 12, 889, DateTimeKind.Utc).AddTicks(346), "AQAAAAIAAYagAAAAEG72UqLYY2lBPymLgJZTCuAxu+RCcly1hiP5wcG0V7kE2XHCnouNYqtWnGfaF/rE6A==", "f3beab11-313e-42ff-b436-c7a7a779a218", new DateTime(2025, 2, 27, 7, 44, 12, 889, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "30ecc0b2-96d8-4b54-8cb4-81c9797bc2fb", new DateTime(2025, 2, 27, 7, 44, 12, 840, DateTimeKind.Utc).AddTicks(1130), "AQAAAAIAAYagAAAAEEeOiBugV6DZ3MsKsDUanO+hlorsHqTbYcP/kJ5pZLo9NPZS89lbX9Ylrf5mBYoR0g==", "fe0e5749-57ea-49cb-b677-0039d4bd45b3", new DateTime(2025, 2, 27, 7, 44, 12, 840, DateTimeKind.Utc).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5eeb5923-ee5a-4995-93d4-e6b9b1cde7b1", new DateTime(2025, 2, 27, 7, 44, 12, 791, DateTimeKind.Utc).AddTicks(6183), "AQAAAAIAAYagAAAAEOJNbNkcTQgEvXQGCwm6P5EIoePh1z66zndovSwPyB4uoCUETlTEmzCBhrfWMe1/mA==", "56ed2cc0-f5fb-4506-98a7-b4da755e3ae5", new DateTime(2025, 2, 27, 7, 44, 12, 791, DateTimeKind.Utc).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "cf7c44b1-6e78-43d8-80fc-dfbb10f799eb", new DateTime(2025, 2, 27, 7, 44, 12, 739, DateTimeKind.Utc).AddTicks(7935), "AQAAAAIAAYagAAAAEN+FMY2yramfKrJAYF9JUDEt1zj2nxOTetWw0bok0NfUkj9/ZtpobNEckLQjyQ1cCg==", "91e3d7af-30bb-4d47-a4a2-3a48a7c2bb3c", new DateTime(2025, 2, 27, 7, 44, 12, 739, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(1978), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2559), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2563), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2565), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2567), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2568) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2569), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2571), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2573), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2575), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2577), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2579), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2581), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2583), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2584), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2586), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2588), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2590), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2592), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 15, 44, 13, 20, DateTimeKind.Local).AddTicks(3249), new DateTime(2025, 2, 27, 15, 44, 13, 21, DateTimeKind.Local).AddTicks(8758) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4711), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4787), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4815), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4873), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4918), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4967), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4998), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5045), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5088), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5113), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5158), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5194), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5233), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5268), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5309), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5337), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5386), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5413), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 25, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5452), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5481), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5482) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5524), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5568), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5606), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5641), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5642) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5683), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5724), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5724) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5762), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5805), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5850), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5890), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5924), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5962), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6007), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6043), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 19, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6082), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6083) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6121), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6146), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6146) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6200), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6241), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6285), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6344), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6400), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6401) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6437), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6494), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6541), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6575), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6613), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6658), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6684), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6722), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6754), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6792), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6821), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6855), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6895), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6932), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6977), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7011), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7055), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7091), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7131), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7167), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7202), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7235), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7279), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7303), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7342), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7384), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7426), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7458), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7484), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7516), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7516) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7546), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7584), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7585) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7619), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7645), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7684), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7711), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7743), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7774), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7797), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7841), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7874), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7911), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7952), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7987), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8014), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8055), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8094), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8121), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8158), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8190), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8227), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8252), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8278), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8311), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8344), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8377), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8407), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8408) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3480), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3739), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3740), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3742), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3743), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3743) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3744), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4323), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4674), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4677), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4754), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4756), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4758), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4773), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4775), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4803), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4806), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4807), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4854), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4856), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4863), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4865), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4902), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4904), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4904) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4906), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4908), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4909), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4911), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4954), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4955), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4955) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4957), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4958), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4960), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4987), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4989), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4990), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4992), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5031), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5032), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5033), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5036), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5036) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5037), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5039), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5069), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5071), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5072), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5073), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5075), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5104), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5105), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5106), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5139), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5140), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5142), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5143), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5145), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5151), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5180), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5182), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5182) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5183), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5184), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5185) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5186), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5187), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5216), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5218), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5219), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5225), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5227), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5256), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5258), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5259), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5261), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5261) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5298), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5300), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5301), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5303), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5325), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5326), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5327), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5329), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5331), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5372), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5374), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5375), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5377), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5378), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5380), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5402), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5404), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5405), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5405) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5406), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5443), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5444), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5446), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5468), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5469), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5470), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5472), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5473), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5475), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5512), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5513), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5514), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5516), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5518), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5553), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5554), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5554) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5555), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5557), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5594), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5595), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5597), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5600), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5625), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5626), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5628), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5628) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5629), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5629) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5630), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5669), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5671), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5672), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5674), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5675), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5677), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5712), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5715), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5716), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5718), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5751), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5752), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5753), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5755), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5756), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5791), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5792), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5795), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5795) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5796), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5797), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5799), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5832), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5833), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5835), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5840), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5842), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5844), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5879), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5880), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5882), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5883), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5885), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5911), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5914), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5915), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5917), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5918), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5950), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5952), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5953), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5955), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5956), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5994), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5995), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5996), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5997) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5998), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(5999), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6001), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6001) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6028), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6030), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6035), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6036) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6037), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6069), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6071), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6075), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6076), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6111), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6136), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6138), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6138) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6139), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6140), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6174), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6174) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6177), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6185), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6186) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6188), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6190), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6192), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6222), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6222) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6224), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6226), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6228), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6231), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6233), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6266), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6267) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6268), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6271), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6325), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6326) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6328), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6328) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6330), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6333), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6335), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6336) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6375), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6383), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6384) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6386), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6386) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6388), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6388) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6390), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6392), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6423), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6425), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6428), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6474), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6476), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6479), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6481), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6483), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6484) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6526), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6528), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6529), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6531), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6565), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6567), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6568), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6603), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6603) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6604), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6606), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6607), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6646), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6647), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6648), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6650), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6651), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6672), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6673), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6674), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6676), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6677), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6702), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6702) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6704), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6711), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6713), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6715), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6716), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6744), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6745), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6746), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6747), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6749), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6776), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6777), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6783), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6785), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6808), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6810), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6811), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6812), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6814), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6815), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6838), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6840), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6841), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6843), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6848), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6877), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6879), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6881), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6882), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6883), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6889), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6921), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6922), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6923), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6925), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6926), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6961), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6965), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6966), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6967), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6969), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6971), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6999), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7000), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7001), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7003), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7005), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7042), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7043), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7045), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7046), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7047), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7049), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7077), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7077) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7078), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7080), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7081), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7082), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7083) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7084), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7118), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7120), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7121), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7123), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7124), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7126), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7155), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7157), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7158), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7160), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7161), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7194), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7195), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7226), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7227), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7229), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7269), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7271), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7272), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7273), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7293), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7294), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7296), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7297), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7331), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7332), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7333), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7335), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7336), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7372), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7373), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7374), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7376), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7377), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7379), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7410), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7412), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7413), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7415), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7416), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7448), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7450), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7451), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7452), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7474), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7475), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7477), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7478), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7504), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7505), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7507), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7508), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7509), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7536), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7537), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7538), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7540), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7571), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7573), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7574), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7575), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7577), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7577) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7579), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7601), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7603), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7604), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7606), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7607), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7608), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7637), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7638), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7639), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7672), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7674), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7674) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7675), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7677), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7678), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7702), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7703), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7705), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7705) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7733), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7734) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7735), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7736), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7737), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7763), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7763) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7764), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7764) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7766), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7767), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7768), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7769) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7786), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7788), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7789), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7790), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7823), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7831), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7834), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7835), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7861), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7862), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7864), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7865), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7867), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7868), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7897), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7904), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7905), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7939), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7940), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7942), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7943), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7945), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7946), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7976), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7978), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7979), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7979) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7980), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8006), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8008), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8009), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8040), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8041), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8046), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8046) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8047), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8049), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8084), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8086), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8086) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8087), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8109), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8110), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8111), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8113), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8114), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8143), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8145), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8146), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8147), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8181), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8182), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8183), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8185), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8185) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8212), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8213), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8215), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8216), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8241), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8243), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8244), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8246), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8266), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8269), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8271), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8272), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8302), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8304), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8305), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8333), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8334), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8336), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8337), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8339), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8363), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8366), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8367), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8369), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8370), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8394) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8395), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8397), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8398), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8400), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8401), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8432), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8434), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8434) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8436), new DateTime(2025, 2, 27, 7, 44, 13, 22, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4111), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4553), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4555), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4556), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4557), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4558), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(2818), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(2904), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(2910), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4722), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4727), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4737), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4738) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4741), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4746), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4792), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4796), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4820), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4824), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4829), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4833), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4837), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4879), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4883), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4888), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4892), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4893) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4896), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4922), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4926), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4930), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4934), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4947), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4971), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4972) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4975), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4980), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5002), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5006), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5010), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5014), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5024), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5050), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5054), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5058), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5062), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5093), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5097), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5117), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5122), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5126), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5130), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5163), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5166), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5171), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5175), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5198), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5202), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5206), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5210), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5238), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5241), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5245), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5249), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5273), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5277), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5281), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5285), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5293), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5313), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5317), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5342), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5347), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5351), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5368), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5391), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5396), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5417), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5417) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5420), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5424), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5425) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5437), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5456), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5459), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5463), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5485), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5486) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5489), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5493), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5497), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5528), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5532), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5537), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5541), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5545), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5546) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5572), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5577), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5581), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5584), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5614), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5619), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5646), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5654), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5654) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5658), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5662), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5688), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5691), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5692) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5695), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5699), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5703), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5728), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5732), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5736), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5737) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5740), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5744), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5767), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5771), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5775), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5778), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5809), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5813), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5817), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5821), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5826), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5854), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5858), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5862), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5866), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5870), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5894), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5898), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5902), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5928), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5932), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5936), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5940), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5944), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5967), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5976), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5980), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5983), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5987), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6011), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6016), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6020), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6024), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6047), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6051), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6056), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6060), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6063), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6087), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6091), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6095), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6099), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6126), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6130), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6150), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6151) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6157), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6158) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6163), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6207), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6213), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6247), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6253), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6259), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6292), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6297), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6297) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6302), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6308), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6314), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6350), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6355), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6360), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6365), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6366) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6407), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6408) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6414), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6443), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6450), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6455), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6501), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6507), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6507) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6513), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6519), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6545), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6549), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6554), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6579), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6584), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6588), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6589) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6592), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6596), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6596) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6618), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6621), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6625), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6629), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6629) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6632), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6662), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6666), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6688), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6692), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6692) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6696), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6726), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6730), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6734), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6738), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6738) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6759), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6763), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6763) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6767), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6770), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6771) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6796), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6800), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6825), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6829), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6859), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6863), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6868), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6872), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6899), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6903), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6907), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6911), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6915), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6937), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6941), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6945), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6948), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6981), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6986), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6990), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6993), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7015), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7019), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7022), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7026), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7030), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7059), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7063), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7067), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7071), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7095), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7099), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7109), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7113), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7135), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7136) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7139), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7143), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7147), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7151), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7171), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7180), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7184), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7188), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7188) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7207), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7211), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7215), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7219), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7246), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7250), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7254), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7259), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7263), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7283), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7287), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7307), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7319), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7323), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7347), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7357), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7358) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7361), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7365), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7388), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7392), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7396), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7400), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7404), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7430), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7434), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7438), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7442), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7463), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7467), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7488), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7492), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7520), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7524), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7524) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7527), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7531), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7550), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7554), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7558), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7588), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7592), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7596), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7623), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7627), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7631), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7649), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7653), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7657), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7662), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7666), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7666) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7693), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7697), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7715), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7719), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7723), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7727), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7747), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7751), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7778), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7781), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7782) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7801), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7805), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7809), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7813), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7817), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7846), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7850), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7853), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7879), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7883), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7887), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7891), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7892) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7916), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7920), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7924), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7928), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7932), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7956), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7960), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7965), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7965) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7991), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7996), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8000), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8018), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8022), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8027), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8031), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8060), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8064), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8068), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8072), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8098), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8102), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8125), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8129), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8132), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8137), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8162), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8166), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8170), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8174), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8195), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8199), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 31, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8203), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8203) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8206), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 22, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8231), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8235), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8236) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8256), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8257) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8260), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8283), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8283) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8286), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8296), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8315), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8319), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8323), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8327), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8348), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 24, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8352), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8381), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8382) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8385), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8386) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8412), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8412) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 8, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8416), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8420), new DateTime(2025, 2, 27, 15, 44, 13, 22, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4965), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5229), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5231), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5232), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5234), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5235), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5237), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5238), new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5238) });
        }
    }
}
