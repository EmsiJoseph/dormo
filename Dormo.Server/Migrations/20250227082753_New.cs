using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dormo.Server.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7550), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7550) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7559), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(7559) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 27, 51, 373, DateTimeKind.Local).AddTicks(7665), new DateTime(2025, 2, 27, 16, 27, 51, 375, DateTimeKind.Local).AddTicks(9687) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1928), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(1930) });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2647), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2736), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2737) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2807), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2891), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 21, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2944), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3042), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3122), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3187), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 6, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3263), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3368), new DateTime(2025, 2, 27, 16, 27, 51, 377, DateTimeKind.Local).AddTicks(3370) });

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
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 376, DateTimeKind.Utc).AddTicks(9898), new DateTime(2025, 2, 27, 8, 27, 51, 376, DateTimeKind.Utc).AddTicks(9900), "https://loremflickr.com/800/768/house/all?lock=263" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1015), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1017), "https://loremflickr.com/1024/900/house/all?lock=255" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1034), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1035), "https://loremflickr.com/800/768/house/all?lock=925" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1228), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1229), "https://loremflickr.com/1024/768/house/all?lock=741" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1232), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1232), "https://loremflickr.com/1024/768/house/all?lock=848" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1237), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1237), "https://loremflickr.com/800/768/house/all?lock=787" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1239), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1240), "https://loremflickr.com/1024/768/house/all?lock=419" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1242), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1242), "https://loremflickr.com/1024/900/house/all?lock=441" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1349), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1349), "https://loremflickr.com/1200/600/house/all?lock=642" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1353), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1354), "https://loremflickr.com/1024/768/house/all?lock=414" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1356), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1356), "https://loremflickr.com/1200/600/house/all?lock=563" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1459), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1459), "https://loremflickr.com/1024/600/house/all?lock=561" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1462), "https://loremflickr.com/1024/600/house/all?lock=568" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1464), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1464), "https://loremflickr.com/800/768/house/all?lock=1301" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1466), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1467), "https://loremflickr.com/1024/600/house/all?lock=555" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1562), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1563), "https://loremflickr.com/1024/600/house/all?lock=1238" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1565), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1565), "https://loremflickr.com/1024/900/house/all?lock=640" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1570), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1570), "https://loremflickr.com/800/768/house/all?lock=1099" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1572), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1572), "https://loremflickr.com/1024/600/house/all?lock=581" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1575), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1575), "https://loremflickr.com/800/768/house/all?lock=1193" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1577), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1578), "https://loremflickr.com/1024/900/house/all?lock=1018" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1641), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1642), "https://loremflickr.com/1024/768/house/all?lock=1549" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1644), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1644), "https://loremflickr.com/1200/900/house/all?lock=1284" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1646), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1647), "https://loremflickr.com/800/768/house/all?lock=630" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1649), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1649), "https://loremflickr.com/1024/600/house/all?lock=749" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1661), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1661), "https://loremflickr.com/1024/600/house/all?lock=702" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1709), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1709), "https://loremflickr.com/1200/900/house/all?lock=1184" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1711), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1712), "https://loremflickr.com/800/768/house/all?lock=1146" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1714), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1714), "https://loremflickr.com/1200/600/house/all?lock=1251" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1716), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1717), "https://loremflickr.com/800/600/house/all?lock=1334" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1773), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1773), "https://loremflickr.com/1200/600/house/all?lock=1342" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1775), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1776), "https://loremflickr.com/800/900/house/all?lock=1032" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1785), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1785), "https://loremflickr.com/1200/600/house/all?lock=1179" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1788), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1789), "https://loremflickr.com/1024/600/house/all?lock=1448" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1791), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1791), "https://loremflickr.com/800/768/house/all?lock=1665" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1793), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1794), "https://loremflickr.com/1200/768/house/all?lock=861" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1853), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1853), "https://loremflickr.com/1024/600/house/all?lock=1156" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1855), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1856), "https://loremflickr.com/800/600/house/all?lock=1297" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1858), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1858), "https://loremflickr.com/1200/600/house/all?lock=1396" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1860), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1860), "https://loremflickr.com/1200/600/house/all?lock=1603" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1862), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1863), "https://loremflickr.com/1024/768/house/all?lock=1392" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1910), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1911), "https://loremflickr.com/1200/900/house/all?lock=1312" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1913), "https://loremflickr.com/1200/600/house/all?lock=1720" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1915), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1916), "https://loremflickr.com/1200/900/house/all?lock=1801" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1975), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1975), "https://loremflickr.com/800/900/house/all?lock=1477" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1977), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1978), "https://loremflickr.com/800/600/house/all?lock=2066" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1980), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1980), "https://loremflickr.com/1200/900/house/all?lock=1966" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1982), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1982), "https://loremflickr.com/1200/768/house/all?lock=1489" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1984), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1985), "https://loremflickr.com/1024/768/house/all?lock=1865" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1987), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(1987), "https://loremflickr.com/1200/768/house/all?lock=1395" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2048), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2048), "https://loremflickr.com/1200/600/house/all?lock=1349" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2050), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2051), "https://loremflickr.com/800/900/house/all?lock=2125" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2053), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2053), "https://loremflickr.com/800/768/house/all?lock=1675" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2055), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2056), "https://loremflickr.com/1024/768/house/all?lock=1639" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2058), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2058), "https://loremflickr.com/800/900/house/all?lock=2100" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2060), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2061), "https://loremflickr.com/1200/768/house/all?lock=1712" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2116), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2117), "https://loremflickr.com/1200/600/house/all?lock=1764" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2119), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2119), "https://loremflickr.com/1024/900/house/all?lock=1307" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2121), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2121), "https://loremflickr.com/800/768/house/all?lock=1662" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2123), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2124), "https://loremflickr.com/1200/900/house/all?lock=1807" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2126), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2126), "https://loremflickr.com/1024/768/house/all?lock=1723" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2188), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2188), "https://loremflickr.com/1024/900/house/all?lock=2004" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2190), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2191), "https://loremflickr.com/800/768/house/all?lock=2277" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2193), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2193), "https://loremflickr.com/800/600/house/all?lock=1468" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2195), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2196), "https://loremflickr.com/800/900/house/all?lock=1505" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2294), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2295), "https://loremflickr.com/1024/900/house/all?lock=1592" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2297), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2297), "https://loremflickr.com/800/900/house/all?lock=1834" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2299), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2300), "https://loremflickr.com/1200/900/house/all?lock=1794" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2316), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2317), "https://loremflickr.com/800/600/house/all?lock=1599" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2359), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2359), "https://loremflickr.com/1024/900/house/all?lock=2517" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2361), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2361), "https://loremflickr.com/1200/900/house/all?lock=2138" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2363), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2364), "https://loremflickr.com/800/900/house/all?lock=2284" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2366), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2366), "https://loremflickr.com/800/600/house/all?lock=1716" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2368), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2369), "https://loremflickr.com/800/600/house/all?lock=1676" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2458), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2458), "https://loremflickr.com/1200/768/house/all?lock=2210" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2461), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2461), "https://loremflickr.com/1024/900/house/all?lock=2387" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2463), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2463), "https://loremflickr.com/1200/768/house/all?lock=2191" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2466), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2466), "https://loremflickr.com/1200/600/house/all?lock=2545" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2468), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2468), "https://loremflickr.com/1024/768/house/all?lock=2019" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2470), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2471), "https://loremflickr.com/800/768/house/all?lock=1817" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2511), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2512), "https://loremflickr.com/1024/768/house/all?lock=1978" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2514), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2514), "https://loremflickr.com/1200/768/house/all?lock=2093" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2516), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2516), "https://loremflickr.com/1200/600/house/all?lock=2061" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2519), "https://loremflickr.com/1200/768/house/all?lock=2416" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2579), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2579), "https://loremflickr.com/1024/600/house/all?lock=2072" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2582), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2582), "https://loremflickr.com/1024/600/house/all?lock=2306" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2584), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2585), "https://loremflickr.com/1024/768/house/all?lock=2668" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2625), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2626), "https://loremflickr.com/1024/900/house/all?lock=2864" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2628), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2628), "https://loremflickr.com/1200/900/house/all?lock=2775" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2630), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2631), "https://loremflickr.com/1200/600/house/all?lock=2652" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2633), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2633), "https://loremflickr.com/1200/600/house/all?lock=2603" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2635), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2635), "https://loremflickr.com/1200/768/house/all?lock=2813" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2637), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2638), "https://loremflickr.com/800/600/house/all?lock=2768" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2712), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2713), "https://loremflickr.com/1024/600/house/all?lock=3001" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2715), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2715), "https://loremflickr.com/1024/768/house/all?lock=2376" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2717), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2718), "https://loremflickr.com/1024/900/house/all?lock=2718" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2720), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2720), "https://loremflickr.com/800/600/house/all?lock=2811" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2722), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2722), "https://loremflickr.com/1024/768/house/all?lock=2441" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2787), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2787), "https://loremflickr.com/800/600/house/all?lock=2886" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2789), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2790), "https://loremflickr.com/1024/900/house/all?lock=3073" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2792), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2792), "https://loremflickr.com/1200/600/house/all?lock=2276" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2794), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2794), "https://loremflickr.com/1024/900/house/all?lock=2806" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2869), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2870), "https://loremflickr.com/1200/900/house/all?lock=3033" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2872), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2872), "https://loremflickr.com/1200/600/house/all?lock=2676" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2874), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2874), "https://loremflickr.com/1024/900/house/all?lock=3078" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2876), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2877), "https://loremflickr.com/1200/768/house/all?lock=2396" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2879), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2879), "https://loremflickr.com/800/768/house/all?lock=2390" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2924), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2924), "https://loremflickr.com/800/768/house/all?lock=2929" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2926), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2927), "https://loremflickr.com/800/768/house/all?lock=3351" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2929), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2929), "https://loremflickr.com/800/900/house/all?lock=2682" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2931), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2932), "https://loremflickr.com/1200/900/house/all?lock=3219" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2934), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(2934), "https://loremflickr.com/800/600/house/all?lock=2537" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3019), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3019), "https://loremflickr.com/1024/600/house/all?lock=3298" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3021), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3022), "https://loremflickr.com/1024/768/house/all?lock=3132" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3024), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3024), "https://loremflickr.com/800/600/house/all?lock=3342" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3026), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3027), "https://loremflickr.com/1200/900/house/all?lock=3260" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3029), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3029), "https://loremflickr.com/800/600/house/all?lock=3413" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3031), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3032), "https://loremflickr.com/800/900/house/all?lock=3348" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3084), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3084), "https://loremflickr.com/1200/600/house/all?lock=2710" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3086), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3086), "https://loremflickr.com/1024/600/house/all?lock=2933" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3088), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3089), "https://loremflickr.com/1200/768/house/all?lock=2674" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3110), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3110), "https://loremflickr.com/1200/900/house/all?lock=3049" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3167), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3168), "https://loremflickr.com/800/600/house/all?lock=3070" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3170), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3170), "https://loremflickr.com/1024/600/house/all?lock=3280" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3172), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3173), "https://loremflickr.com/1024/768/house/all?lock=3595" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3175), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3175), "https://loremflickr.com/1200/900/house/all?lock=3027" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3177), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3177), "https://loremflickr.com/800/768/house/all?lock=2745" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3227), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3228), "https://loremflickr.com/1024/600/house/all?lock=3383" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3238), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3238), "https://loremflickr.com/1024/768/house/all?lock=3745" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3244), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3245), "https://loremflickr.com/1024/600/house/all?lock=3212" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3247), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3247), "https://loremflickr.com/1200/600/house/all?lock=3383" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3249), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3249), "https://loremflickr.com/1200/768/house/all?lock=2978" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3251), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3252), "https://loremflickr.com/1200/600/house/all?lock=3064" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3311), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3311), "https://loremflickr.com/1200/768/house/all?lock=3817" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3313), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3313), "https://loremflickr.com/1024/900/house/all?lock=2914" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3315), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3316), "https://loremflickr.com/1024/768/house/all?lock=3875" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3318), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3318), "https://loremflickr.com/1024/768/house/all?lock=3257" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3320), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3321), "https://loremflickr.com/800/768/house/all?lock=3149" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3341), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3342), "https://loremflickr.com/800/768/house/all?lock=3095" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3422), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3422), "https://loremflickr.com/800/768/house/all?lock=3325" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3424), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3425), "https://loremflickr.com/1024/600/house/all?lock=3217" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3427), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3427), "https://loremflickr.com/1200/768/house/all?lock=3805" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3429), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3430), "https://loremflickr.com/800/900/house/all?lock=3378" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3432), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3432), "https://loremflickr.com/1024/900/house/all?lock=3672" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3475), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3475), "https://loremflickr.com/800/900/house/all?lock=4089" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3492), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3492), "https://loremflickr.com/800/600/house/all?lock=3156" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3495), "https://loremflickr.com/800/900/house/all?lock=3856" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3497), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3497), "https://loremflickr.com/1024/900/house/all?lock=3345" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3499), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3499), "https://loremflickr.com/800/600/house/all?lock=3121" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3559), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3560), "https://loremflickr.com/1024/600/house/all?lock=3953" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3562), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3562), "https://loremflickr.com/1200/768/house/all?lock=3896" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3564), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3565), "https://loremflickr.com/800/900/house/all?lock=3487" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3567), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3567), "https://loremflickr.com/800/900/house/all?lock=3443" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3569), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3569), "https://loremflickr.com/1200/768/house/all?lock=3275" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3654), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3654), "https://loremflickr.com/800/600/house/all?lock=3528" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3656), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3656), "https://loremflickr.com/800/600/house/all?lock=3854" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3658), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3659), "https://loremflickr.com/1200/768/house/all?lock=3906" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3661), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3661), "https://loremflickr.com/1024/600/house/all?lock=3665" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3663), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3664), "https://loremflickr.com/1200/900/house/all?lock=3928" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3666), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3666), "https://loremflickr.com/1024/900/house/all?lock=3522" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3712), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3713), "https://loremflickr.com/800/768/house/all?lock=4155" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3715), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3715), "https://loremflickr.com/1200/600/house/all?lock=3697" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3730), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3730), "https://loremflickr.com/1024/600/house/all?lock=4063" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3733), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3733), "https://loremflickr.com/1200/768/house/all?lock=4181" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3793), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3794), "https://loremflickr.com/1200/900/house/all?lock=3683" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3796), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3796), "https://loremflickr.com/800/600/house/all?lock=4018" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3798), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3799), "https://loremflickr.com/1024/900/house/all?lock=4178" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3801), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3802), "https://loremflickr.com/800/900/house/all?lock=4020" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3873), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3873), "https://loremflickr.com/1200/768/house/all?lock=4394" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3875), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3876), "https://loremflickr.com/800/900/house/all?lock=4344" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3877), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3878), "https://loremflickr.com/1024/900/house/all?lock=4424" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3922), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3923), "https://loremflickr.com/1024/600/house/all?lock=3712" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3925), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3925), "https://loremflickr.com/800/900/house/all?lock=4575" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3927), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3928), "https://loremflickr.com/1024/900/house/all?lock=4241" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3930), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3930), "https://loremflickr.com/1200/768/house/all?lock=3930" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3977), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3978), "https://loremflickr.com/1024/768/house/all?lock=4310" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3991), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3991), "https://loremflickr.com/800/900/house/all?lock=4047" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3993), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3994), "https://loremflickr.com/800/900/house/all?lock=4197" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3996), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3996), "https://loremflickr.com/1200/768/house/all?lock=4408" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3998), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(3998), "https://loremflickr.com/800/900/house/all?lock=4516" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4001), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4001), "https://loremflickr.com/1024/600/house/all?lock=3962" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4037), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4037), "https://loremflickr.com/1200/768/house/all?lock=4270" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4039), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4039), "https://loremflickr.com/1200/900/house/all?lock=4367" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4041), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4042), "https://loremflickr.com/1200/600/house/all?lock=4899" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4044), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4044), "https://loremflickr.com/1200/768/house/all?lock=4258" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4046), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4046), "https://loremflickr.com/1200/768/house/all?lock=4466" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4049), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4049), "https://loremflickr.com/1024/600/house/all?lock=4003" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4086), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4087), "https://loremflickr.com/800/900/house/all?lock=4329" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4089), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4089), "https://loremflickr.com/800/768/house/all?lock=4317" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4101), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4101), "https://loremflickr.com/1200/600/house/all?lock=4209" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4167), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4168), "https://loremflickr.com/1024/768/house/all?lock=4956" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4170), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4170), "https://loremflickr.com/800/600/house/all?lock=4392" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4172), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4173), "https://loremflickr.com/800/600/house/all?lock=4830" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4175), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4175), "https://loremflickr.com/1200/900/house/all?lock=5013" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4177), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4177), "https://loremflickr.com/800/768/house/all?lock=4506" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4242), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4242), "https://loremflickr.com/1024/900/house/all?lock=4529" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4244), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4245), "https://loremflickr.com/1024/900/house/all?lock=4616" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4247), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4247), "https://loremflickr.com/1200/900/house/all?lock=4664" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4249), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4250), "https://loremflickr.com/800/600/house/all?lock=4934" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4251), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4252), "https://loremflickr.com/1024/768/house/all?lock=5165" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4254), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4255), "https://loremflickr.com/1024/768/house/all?lock=5003" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4294), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4295), "https://loremflickr.com/1024/600/house/all?lock=5198" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4297), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4297), "https://loremflickr.com/800/900/house/all?lock=4876" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4299), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4300), "https://loremflickr.com/800/768/house/all?lock=4862" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4360), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4360), "https://loremflickr.com/800/600/house/all?lock=4426" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4362), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4363), "https://loremflickr.com/800/600/house/all?lock=4636" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4365), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4365), "https://loremflickr.com/800/768/house/all?lock=5307" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4367), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4368), "https://loremflickr.com/1024/768/house/all?lock=4431" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4369), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4370), "https://loremflickr.com/1200/900/house/all?lock=5383" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4417), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4417), "https://loremflickr.com/800/600/house/all?lock=5192" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4419), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4419), "https://loremflickr.com/800/600/house/all?lock=5151" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4421), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4422), "https://loremflickr.com/800/900/house/all?lock=5381" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4424), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4424), "https://loremflickr.com/1200/900/house/all?lock=4859" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4479), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4479), "https://loremflickr.com/1024/768/house/all?lock=4799" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4481), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4482), "https://loremflickr.com/1024/768/house/all?lock=5225" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4484), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4484), "https://loremflickr.com/800/900/house/all?lock=5156" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4538), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4539), "https://loremflickr.com/800/900/house/all?lock=4984" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4541), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4541), "https://loremflickr.com/800/768/house/all?lock=5366" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4543), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4544), "https://loremflickr.com/1024/768/house/all?lock=4984" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4546), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4546), "https://loremflickr.com/1200/768/house/all?lock=5604" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4622), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4622), "https://loremflickr.com/800/768/house/all?lock=4819" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4624), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4625), "https://loremflickr.com/800/768/house/all?lock=5352" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4627), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4627), "https://loremflickr.com/1200/900/house/all?lock=5425" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4629), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4630), "https://loremflickr.com/1200/768/house/all?lock=4924" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4632), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4632), "https://loremflickr.com/1200/768/house/all?lock=4968" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4669), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4669), "https://loremflickr.com/800/900/house/all?lock=5217" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4671), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4672), "https://loremflickr.com/1024/768/house/all?lock=5739" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4674), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4674), "https://loremflickr.com/800/600/house/all?lock=5280" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4676), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4677), "https://loremflickr.com/1200/600/house/all?lock=5034" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4679), "https://loremflickr.com/1200/900/house/all?lock=4979" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4732), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4733), "https://loremflickr.com/1200/768/house/all?lock=5238" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4735), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4735), "https://loremflickr.com/1024/900/house/all?lock=5337" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4737), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4737), "https://loremflickr.com/1200/900/house/all?lock=5292" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4739), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4740), "https://loremflickr.com/1200/900/house/all?lock=5759" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4742), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4742), "https://loremflickr.com/800/600/house/all?lock=5949" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4744), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4745), "https://loremflickr.com/1200/900/house/all?lock=5961" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4795), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4795), "https://loremflickr.com/1024/600/house/all?lock=5214" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4797), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4797), "https://loremflickr.com/1200/600/house/all?lock=5563" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4799), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4800), "https://loremflickr.com/800/768/house/all?lock=5452" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4802), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4802), "https://loremflickr.com/1024/768/house/all?lock=5448" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4804), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4805), "https://loremflickr.com/800/900/house/all?lock=5428" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4868), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4868), "https://loremflickr.com/1200/600/house/all?lock=6180" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4870), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4871), "https://loremflickr.com/1024/600/house/all?lock=5534" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4873), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4873), "https://loremflickr.com/800/900/house/all?lock=5613" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4875), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4876), "https://loremflickr.com/1024/600/house/all?lock=5701" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4918), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4918), "https://loremflickr.com/1024/900/house/all?lock=5774" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4920), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4921), "https://loremflickr.com/1024/768/house/all?lock=6279" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4923), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4923), "https://loremflickr.com/1024/900/house/all?lock=5563" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4925), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4926), "https://loremflickr.com/1024/768/house/all?lock=5612" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4928), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4928), "https://loremflickr.com/800/768/house/all?lock=5526" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4930), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4931), "https://loremflickr.com/800/768/house/all?lock=5691" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4987), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4988), "https://loremflickr.com/800/900/house/all?lock=6258" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4990), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4990), "https://loremflickr.com/800/600/house/all?lock=6296" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4992), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4993), "https://loremflickr.com/800/900/house/all?lock=5470" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4995), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4995), "https://loremflickr.com/1200/600/house/all?lock=5764" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4997), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(4997), "https://loremflickr.com/800/600/house/all?lock=5445" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5049), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5050), "https://loremflickr.com/1024/900/house/all?lock=6270" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5069), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5069), "https://loremflickr.com/1200/900/house/all?lock=6481" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5071), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5072), "https://loremflickr.com/1024/600/house/all?lock=6311" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5074), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5074), "https://loremflickr.com/800/900/house/all?lock=6349" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5076), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5077), "https://loremflickr.com/800/900/house/all?lock=6192" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5079), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5079), "https://loremflickr.com/1200/600/house/all?lock=5944" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5139), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5139), "https://loremflickr.com/1024/600/house/all?lock=6065" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5141), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5142), "https://loremflickr.com/1024/900/house/all?lock=6563" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5144), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5144), "https://loremflickr.com/1200/900/house/all?lock=6560" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5146), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5146), "https://loremflickr.com/1200/900/house/all?lock=6383" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5149), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5149), "https://loremflickr.com/1024/768/house/all?lock=5639" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5217), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5217), "https://loremflickr.com/800/600/house/all?lock=6184" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5219), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5220), "https://loremflickr.com/1024/900/house/all?lock=6264" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5222), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5222), "https://loremflickr.com/1024/600/house/all?lock=6236" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5224), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5224), "https://loremflickr.com/1024/600/house/all?lock=6037" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5226), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5227), "https://loremflickr.com/1200/600/house/all?lock=6672" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5229), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5229), "https://loremflickr.com/800/900/house/all?lock=6503" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5282), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5283), "https://loremflickr.com/800/768/house/all?lock=6136" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5284), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5285), "https://loremflickr.com/1024/900/house/all?lock=5804" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5287), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5287), "https://loremflickr.com/1200/900/house/all?lock=5975" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5289), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5290), "https://loremflickr.com/800/600/house/all?lock=6334" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5292), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5292), "https://loremflickr.com/1024/768/house/all?lock=6627" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5362), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5363), "https://loremflickr.com/1024/768/house/all?lock=6053" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5365), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5365), "https://loremflickr.com/800/768/house/all?lock=6066" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5367), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5368), "https://loremflickr.com/800/900/house/all?lock=6551" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5370), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5370), "https://loremflickr.com/1200/900/house/all?lock=5986" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5372), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5372), "https://loremflickr.com/1200/900/house/all?lock=6162" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5374), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5375), "https://loremflickr.com/1200/768/house/all?lock=5919" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5428), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5428), "https://loremflickr.com/1200/900/house/all?lock=6992" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5430), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5430), "https://loremflickr.com/1024/768/house/all?lock=6844" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5433), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5433), "https://loremflickr.com/1024/768/house/all?lock=6458" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5435), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5435), "https://loremflickr.com/1200/900/house/all?lock=6460" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5447), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5447), "https://loremflickr.com/1024/600/house/all?lock=6207" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5450), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5450), "https://loremflickr.com/800/768/house/all?lock=6897" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5500), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5500), "https://loremflickr.com/800/768/house/all?lock=6721" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5502), "https://loremflickr.com/1200/900/house/all?lock=6135" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5504), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5505), "https://loremflickr.com/800/600/house/all?lock=6572" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5507), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5507), "https://loremflickr.com/1024/900/house/all?lock=7047" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5509), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5510), "https://loremflickr.com/800/900/house/all?lock=7084" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5512), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5512), "https://loremflickr.com/1200/900/house/all?lock=6232" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5570), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5570), "https://loremflickr.com/800/900/house/all?lock=7081" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5572), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5573), "https://loremflickr.com/1200/900/house/all?lock=6568" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5575), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5575), "https://loremflickr.com/1024/768/house/all?lock=6821" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5578), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5578), "https://loremflickr.com/800/900/house/all?lock=6350" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5580), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5580), "https://loremflickr.com/1024/768/house/all?lock=6592" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5633), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5634), "https://loremflickr.com/1024/768/house/all?lock=6908" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5636), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5636), "https://loremflickr.com/800/768/house/all?lock=7260" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5638), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5639), "https://loremflickr.com/800/600/house/all?lock=6794" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5701), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5702), "https://loremflickr.com/1024/900/house/all?lock=6929" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5704), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5704), "https://loremflickr.com/1024/768/house/all?lock=6598" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5706), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5707), "https://loremflickr.com/1200/900/house/all?lock=7031" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5775), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5775), "https://loremflickr.com/800/900/house/all?lock=6851" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5777), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5778), "https://loremflickr.com/1024/900/house/all?lock=6805" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5780), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5780), "https://loremflickr.com/1024/900/house/all?lock=6555" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5782), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5783), "https://loremflickr.com/1024/768/house/all?lock=7146" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5837), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5837), "https://loremflickr.com/800/600/house/all?lock=7200" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5839), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5840), "https://loremflickr.com/1200/768/house/all?lock=7023" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5842), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5842), "https://loremflickr.com/800/768/house/all?lock=6975" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5844), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5845), "https://loremflickr.com/1024/900/house/all?lock=7181" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5906), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5906), "https://loremflickr.com/1200/600/house/all?lock=7079" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5909), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5909), "https://loremflickr.com/800/768/house/all?lock=7364" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5911), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5911), "https://loremflickr.com/800/900/house/all?lock=7580" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5914), "https://loremflickr.com/800/768/house/all?lock=6841" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5916), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5916), "https://loremflickr.com/1200/900/house/all?lock=6816" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5968), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5969), "https://loremflickr.com/1024/768/house/all?lock=7365" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5971), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5971), "https://loremflickr.com/1024/600/house/all?lock=7309" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5973), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5974), "https://loremflickr.com/800/600/house/all?lock=7340" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5976), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5976), "https://loremflickr.com/800/768/house/all?lock=7680" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5978), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5978), "https://loremflickr.com/800/600/house/all?lock=7002" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5981), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(5981), "https://loremflickr.com/1024/900/house/all?lock=7284" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6049), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6049), "https://loremflickr.com/800/768/house/all?lock=7180" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6051), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6052), "https://loremflickr.com/1200/600/house/all?lock=7558" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6054), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6054), "https://loremflickr.com/1200/768/house/all?lock=7187" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6056), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6057), "https://loremflickr.com/1200/600/house/all?lock=7101" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6058), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6059), "https://loremflickr.com/1024/768/house/all?lock=7537" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6108), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6109), "https://loremflickr.com/1200/768/house/all?lock=7129" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6111), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6111), "https://loremflickr.com/1200/900/house/all?lock=7234" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6113), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6113), "https://loremflickr.com/1024/600/house/all?lock=7839" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6115), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6116), "https://loremflickr.com/1200/600/house/all?lock=8001" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6166), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6167), "https://loremflickr.com/1200/768/house/all?lock=7893" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6169), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6169), "https://loremflickr.com/1200/900/house/all?lock=7836" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6171), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6171), "https://loremflickr.com/1024/768/house/all?lock=8046" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6174), "https://loremflickr.com/1024/600/house/all?lock=7850" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6212), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6213), "https://loremflickr.com/1200/600/house/all?lock=7654" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6215), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6215), "https://loremflickr.com/800/600/house/all?lock=7253" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6217), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6217), "https://loremflickr.com/800/900/house/all?lock=8160" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6219), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6220), "https://loremflickr.com/1200/900/house/all?lock=7965" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6222), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6222), "https://loremflickr.com/800/900/house/all?lock=7805" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6267), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6267), "https://loremflickr.com/800/600/house/all?lock=7619" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6285), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6286), "https://loremflickr.com/800/768/house/all?lock=7507" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6288), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6289), "https://loremflickr.com/1200/900/house/all?lock=8168" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6291), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6291), "https://loremflickr.com/1200/768/house/all?lock=7995" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6342), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6342), "https://loremflickr.com/1200/768/house/all?lock=8126" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6344), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6344), "https://loremflickr.com/1024/768/house/all?lock=7916" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6346), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6347), "https://loremflickr.com/1024/900/house/all?lock=7885" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6349), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6349), "https://loremflickr.com/1024/768/house/all?lock=7817" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6351), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6352), "https://loremflickr.com/1200/600/house/all?lock=7634" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6354), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6354), "https://loremflickr.com/800/600/house/all?lock=7674" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6412), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6412), "https://loremflickr.com/1024/600/house/all?lock=7860" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6414), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6415), "https://loremflickr.com/1024/600/house/all?lock=8265" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6417), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6417), "https://loremflickr.com/1200/768/house/all?lock=8420" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6419), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6420), "https://loremflickr.com/800/900/house/all?lock=8337" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6421), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6422), "https://loremflickr.com/800/600/house/all?lock=8394" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6424), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6424), "https://loremflickr.com/1024/768/house/all?lock=7599" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6466), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6467), "https://loremflickr.com/800/900/house/all?lock=8148" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6469), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6469), "https://loremflickr.com/1024/768/house/all?lock=7739" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6471), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6471), "https://loremflickr.com/1200/768/house/all?lock=8322" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6536), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6536), "https://loremflickr.com/1200/900/house/all?lock=7948" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6538), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6538), "https://loremflickr.com/800/600/house/all?lock=8313" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6540), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6541), "https://loremflickr.com/1024/768/house/all?lock=8263" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6543), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6543), "https://loremflickr.com/800/768/house/all?lock=8578" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6545), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6546), "https://loremflickr.com/1200/600/house/all?lock=8145" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6579), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6579), "https://loremflickr.com/800/600/house/all?lock=8259" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6581), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6582), "https://loremflickr.com/800/600/house/all?lock=7828" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6584), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6584), "https://loremflickr.com/800/900/house/all?lock=7944" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6642), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6642), "https://loremflickr.com/1024/900/house/all?lock=8682" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6644), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6644), "https://loremflickr.com/800/900/house/all?lock=8482" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6646), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6647), "https://loremflickr.com/1024/600/house/all?lock=8832" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6649), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6649), "https://loremflickr.com/1024/600/house/all?lock=8247" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6692), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6692), "https://loremflickr.com/800/600/house/all?lock=8685" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6694), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6694), "https://loremflickr.com/800/768/house/all?lock=8887" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6696), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6697), "https://loremflickr.com/1024/900/house/all?lock=8137" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6699), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6699), "https://loremflickr.com/1200/900/house/all?lock=8151" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6701), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6701), "https://loremflickr.com/800/600/house/all?lock=8185" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6732), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6732), "https://loremflickr.com/1200/900/house/all?lock=8577" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6734), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6734), "https://loremflickr.com/1024/768/house/all?lock=9033" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6736), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6737), "https://loremflickr.com/1024/768/house/all?lock=8212" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6739), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6739), "https://loremflickr.com/1200/600/house/all?lock=8292" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6816), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6816), "https://loremflickr.com/1200/768/house/all?lock=8698" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6818), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6818), "https://loremflickr.com/1024/600/house/all?lock=8672" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6820), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6821), "https://loremflickr.com/800/900/house/all?lock=8593" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6823), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6823), "https://loremflickr.com/1200/768/house/all?lock=8620" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6867), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6867), "https://loremflickr.com/1200/600/house/all?lock=8435" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6869), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6870), "https://loremflickr.com/1024/900/house/all?lock=8351" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6872), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6872), "https://loremflickr.com/1200/600/house/all?lock=8972" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6874), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6874), "https://loremflickr.com/1024/600/house/all?lock=8391" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6886), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6886), "https://loremflickr.com/1024/900/house/all?lock=9126" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6889), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6889), "https://loremflickr.com/800/600/house/all?lock=8331" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6940), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6941), "https://loremflickr.com/1200/600/house/all?lock=8415" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6943), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6943), "https://loremflickr.com/1200/900/house/all?lock=8959" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6945), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(6945), "https://loremflickr.com/1024/768/house/all?lock=8770" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7000), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7001), "https://loremflickr.com/1024/600/house/all?lock=8794" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7012), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7013), "https://loremflickr.com/800/768/house/all?lock=9397" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7015), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7015), "https://loremflickr.com/1024/600/house/all?lock=8519" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7017), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7017), "https://loremflickr.com/1024/768/house/all?lock=9066" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7019), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7020), "https://loremflickr.com/800/900/house/all?lock=9393" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7022), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7022), "https://loremflickr.com/1200/900/house/all?lock=9064" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7067), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7067), "https://loremflickr.com/800/900/house/all?lock=8723" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7069), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7070), "https://loremflickr.com/800/600/house/all?lock=9354" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7072), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7072), "https://loremflickr.com/1024/600/house/all?lock=9338" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7074), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7075), "https://loremflickr.com/800/600/house/all?lock=9445" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7119), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7120), "https://loremflickr.com/800/600/house/all?lock=9060" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7122), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7122), "https://loremflickr.com/800/768/house/all?lock=9184" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7137), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7137), "https://loremflickr.com/1024/768/house/all?lock=9170" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7193), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7193), "https://loremflickr.com/800/600/house/all?lock=8862" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7195), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7195), "https://loremflickr.com/800/768/house/all?lock=9264" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7197), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7198), "https://loremflickr.com/1024/768/house/all?lock=9450" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7200), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7200), "https://loremflickr.com/800/768/house/all?lock=9530" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7203), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7203), "https://loremflickr.com/1024/900/house/all?lock=9340" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7272), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7272), "https://loremflickr.com/1024/600/house/all?lock=8927" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7274), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7275), "https://loremflickr.com/800/900/house/all?lock=9286" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7277), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7277), "https://loremflickr.com/1200/600/house/all?lock=9289" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7319), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7320), "https://loremflickr.com/1024/900/house/all?lock=9923" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7322), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7322), "https://loremflickr.com/800/768/house/all?lock=9908" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7324), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7325), "https://loremflickr.com/1024/600/house/all?lock=9972" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7335), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7336), "https://loremflickr.com/800/900/house/all?lock=9754" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7338), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7338), "https://loremflickr.com/1024/600/house/all?lock=9533" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7390), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7390), "https://loremflickr.com/800/900/house/all?lock=9443" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7393), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7393), "https://loremflickr.com/800/768/house/all?lock=9808" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7395), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7395), "https://loremflickr.com/1200/900/house/all?lock=9841" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7398), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7398), "https://loremflickr.com/1024/768/house/all?lock=9858" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7448), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7448), "https://loremflickr.com/800/768/house/all?lock=9247" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7450), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7451), "https://loremflickr.com/800/768/house/all?lock=9735" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7463), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7464), "https://loremflickr.com/800/768/house/all?lock=9758" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7466), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7466), "https://loremflickr.com/800/900/house/all?lock=10178" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7516), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7516), "https://loremflickr.com/1200/900/house/all?lock=9363" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7518), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7518), "https://loremflickr.com/1024/900/house/all?lock=9636" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7520), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7521), "https://loremflickr.com/1024/768/house/all?lock=9612" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7523), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7523), "https://loremflickr.com/1200/900/house/all?lock=9608" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7559), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7559), "https://loremflickr.com/1024/900/house/all?lock=9878" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7561), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7562), "https://loremflickr.com/800/768/house/all?lock=9494" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7564), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7564), "https://loremflickr.com/1200/900/house/all?lock=10298" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7567), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7567), "https://loremflickr.com/1024/768/house/all?lock=10369" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7624), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7624), "https://loremflickr.com/800/768/house/all?lock=10182" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7626), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7627), "https://loremflickr.com/1200/900/house/all?lock=9908" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7629), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7629), "https://loremflickr.com/800/600/house/all?lock=10418" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7631), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7632), "https://loremflickr.com/1024/900/house/all?lock=9762" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7634), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7634), "https://loremflickr.com/1200/900/house/all?lock=9761" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7675), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7676), "https://loremflickr.com/1024/900/house/all?lock=9708" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7678), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7678), "https://loremflickr.com/1024/600/house/all?lock=10461" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7680), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7680), "https://loremflickr.com/800/900/house/all?lock=10015" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7739), "https://loremflickr.com/800/900/house/all?lock=9827" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7741), "https://loremflickr.com/1200/600/house/all?lock=9938" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7743), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7743), "https://loremflickr.com/800/900/house/all?lock=10577" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7745), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7746), "https://loremflickr.com/1200/768/house/all?lock=9832" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7748), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7748), "https://loremflickr.com/1200/900/house/all?lock=9722" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7780), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7780), "https://loremflickr.com/800/768/house/all?lock=10383" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7782), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7783), "https://loremflickr.com/800/900/house/all?lock=9811" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7785), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7785), "https://loremflickr.com/800/900/house/all?lock=9976" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7787), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7788), "https://loremflickr.com/1200/900/house/all?lock=10002" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7790), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7790), "https://loremflickr.com/800/600/house/all?lock=10633" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7838), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7838), "https://loremflickr.com/1024/900/house/all?lock=10504" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7840), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7841), "https://loremflickr.com/1200/600/house/all?lock=10283" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7843), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7843), "https://loremflickr.com/1024/900/house/all?lock=10833" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7845), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7846), "https://loremflickr.com/800/900/house/all?lock=9964" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7848), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7848), "https://loremflickr.com/1024/900/house/all?lock=10558" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7850), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7851), "https://loremflickr.com/1024/600/house/all?lock=10001" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7900), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7901), "https://loremflickr.com/1024/768/house/all?lock=10087" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7903), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7903), "https://loremflickr.com/1200/600/house/all?lock=10433" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7905), new DateTime(2025, 2, 27, 8, 27, 51, 377, DateTimeKind.Utc).AddTicks(7905), "https://loremflickr.com/800/900/house/all?lock=10066" });

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9809), new DateTime(2025, 2, 27, 8, 27, 51, 51, DateTimeKind.Utc).AddTicks(9810) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(5758), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(5759), "https://loremflickr.com/800/768?random=263" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6090), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6090), "https://loremflickr.com/1024/900?random=255" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6093), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6094), "https://loremflickr.com/800/768?random=925" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6192), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6192), "https://loremflickr.com/1024/768?random=741" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6193), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6194), "https://loremflickr.com/1024/768?random=848" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6196), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6196), "https://loremflickr.com/800/768?random=787" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6198), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6198), "https://loremflickr.com/1024/768?random=419" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6199), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6199), "https://loremflickr.com/1024/900?random=441" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6227), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6228), "https://loremflickr.com/1200/600?random=642" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6229), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6230), "https://loremflickr.com/1024/768?random=414" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6231), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6231), "https://loremflickr.com/1200/600?random=563" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6283), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6283), "https://loremflickr.com/1024/600?random=561" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6284), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6285), "https://loremflickr.com/1024/600?random=568" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6286), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6286), "https://loremflickr.com/800/768?random=1301" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6288), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6288), "https://loremflickr.com/1024/600?random=555" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6326), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6326), "https://loremflickr.com/1024/600?random=1238" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6327), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6328), "https://loremflickr.com/1024/900?random=640" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6330), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6330), "https://loremflickr.com/800/768?random=1099" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6331), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6331), "https://loremflickr.com/1024/600?random=581" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6333), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6333), "https://loremflickr.com/800/768?random=1193" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6334), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6334), "https://loremflickr.com/1024/900?random=1018" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6375), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6375), "https://loremflickr.com/1024/768?random=1549" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6376), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6377), "https://loremflickr.com/1200/900?random=1284" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6378), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6378), "https://loremflickr.com/800/768?random=630" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6379), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6380), "https://loremflickr.com/1024/600?random=749" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6381), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6381), "https://loremflickr.com/1024/600?random=702" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6408), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6408), "https://loremflickr.com/1200/900?random=1184" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6410), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6410), "https://loremflickr.com/800/768?random=1146" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6411), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6411), "https://loremflickr.com/1200/600?random=1251" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6413), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6413), "https://loremflickr.com/800/600?random=1334" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6451), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6452), "https://loremflickr.com/1200/600?random=1342" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6453), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6453), "https://loremflickr.com/800/900?random=1032" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6454), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6454), "https://loremflickr.com/1200/600?random=1179" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6456), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6457), "https://loremflickr.com/1024/600?random=1448" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6458), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6458), "https://loremflickr.com/800/768?random=1665" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6460), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6460), "https://loremflickr.com/1200/768?random=861" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6490), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6490), "https://loremflickr.com/1024/600?random=1156" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6491), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6491), "https://loremflickr.com/800/600?random=1297" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6497), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6497), "https://loremflickr.com/1200/600?random=1396" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6499), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6499), "https://loremflickr.com/1200/600?random=1603" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6500), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6501), "https://loremflickr.com/1024/768?random=1392" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6522), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6522), "https://loremflickr.com/1200/900?random=1312" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6524), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6524), "https://loremflickr.com/1200/600?random=1720" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6525), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6525), "https://loremflickr.com/1200/900?random=1801" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6558), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6558), "https://loremflickr.com/800/900?random=1477" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6564), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6566), "https://loremflickr.com/800/600?random=2066" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6567), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6567), "https://loremflickr.com/1200/900?random=1966" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6568), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6569), "https://loremflickr.com/1200/768?random=1489" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6570), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6570), "https://loremflickr.com/1024/768?random=1865" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6571), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6572), "https://loremflickr.com/1200/768?random=1395" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6600), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6601), "https://loremflickr.com/1200/600?random=1349" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6602), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6602), "https://loremflickr.com/800/900?random=2125" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6603), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6604), "https://loremflickr.com/800/768?random=1675" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6605), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6605), "https://loremflickr.com/1024/768?random=1639" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6606), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6606), "https://loremflickr.com/800/900?random=2100" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6608), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6608), "https://loremflickr.com/1200/768?random=1712" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6642), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6642), "https://loremflickr.com/1200/600?random=1764" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6643), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6644), "https://loremflickr.com/1024/900?random=1307" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6645), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6645), "https://loremflickr.com/800/768?random=1662" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6646), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6646), "https://loremflickr.com/1200/900?random=1807" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6647), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6648), "https://loremflickr.com/1024/768?random=1723" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6677), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6677), "https://loremflickr.com/1024/900?random=2004" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6678), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6678), "https://loremflickr.com/800/768?random=2277" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6679), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6680), "https://loremflickr.com/800/600?random=1468" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6681), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6681), "https://loremflickr.com/800/900?random=1505" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6720), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6720), "https://loremflickr.com/1024/900?random=1592" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6721), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6722), "https://loremflickr.com/800/900?random=1834" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6723), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6723), "https://loremflickr.com/1200/900?random=1794" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6724), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6724), "https://loremflickr.com/800/600?random=1599" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6747), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6747), "https://loremflickr.com/1024/900?random=2517" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6748), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6748), "https://loremflickr.com/1200/900?random=2138" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6749), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6749), "https://loremflickr.com/800/900?random=2284" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6750), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6751), "https://loremflickr.com/800/600?random=1716" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6752), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6752), "https://loremflickr.com/800/600?random=1676" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6788), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6788), "https://loremflickr.com/1200/768?random=2210" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6789), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6789), "https://loremflickr.com/1024/900?random=2387" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6790), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6791), "https://loremflickr.com/1200/768?random=2191" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6792), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6792), "https://loremflickr.com/1200/600?random=2545" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6793), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6793), "https://loremflickr.com/1024/768?random=2019" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6795), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6795), "https://loremflickr.com/800/768?random=1817" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6815), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6816), "https://loremflickr.com/1024/768?random=1978" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6817), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6817), "https://loremflickr.com/1200/768?random=2093" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6818), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6818), "https://loremflickr.com/1200/600?random=2061" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6819), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6820), "https://loremflickr.com/1200/768?random=2416" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6854), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6854), "https://loremflickr.com/1024/600?random=2072" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6855), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6855), "https://loremflickr.com/1024/600?random=2306" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6856), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6856), "https://loremflickr.com/1024/768?random=2668" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6878), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6879), "https://loremflickr.com/1024/900?random=2864" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6880), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6880), "https://loremflickr.com/1200/900?random=2775" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6881), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6881), "https://loremflickr.com/1200/600?random=2652" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6882), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6883), "https://loremflickr.com/1200/600?random=2603" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6884), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6884), "https://loremflickr.com/1200/768?random=2813" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6885), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6886), "https://loremflickr.com/800/600?random=2768" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6922), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6922), "https://loremflickr.com/1024/600?random=3001" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6924), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6924), "https://loremflickr.com/1024/768?random=2376" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6925), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6925), "https://loremflickr.com/1024/900?random=2718" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6926), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6927), "https://loremflickr.com/800/600?random=2811" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6928), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6928), "https://loremflickr.com/1024/768?random=2441" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6971), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6971), "https://loremflickr.com/800/600?random=2886" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6973), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6973), "https://loremflickr.com/1024/900?random=3073" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6974), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6974), "https://loremflickr.com/1200/600?random=2276" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6975), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(6976), "https://loremflickr.com/1024/900?random=2806" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7009), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7009), "https://loremflickr.com/1200/900?random=3033" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7010), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7010), "https://loremflickr.com/1200/600?random=2676" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7011), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7012), "https://loremflickr.com/1024/900?random=3078" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7013), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7013), "https://loremflickr.com/1200/768?random=2396" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7014), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7015), "https://loremflickr.com/800/768?random=2390" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7039), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7039), "https://loremflickr.com/800/768?random=2929" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7045), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7046), "https://loremflickr.com/800/768?random=3351" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7047), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7048), "https://loremflickr.com/800/900?random=2682" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7049), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7049), "https://loremflickr.com/1200/900?random=3219" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7050), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7050), "https://loremflickr.com/800/600?random=2537" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7084), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7084), "https://loremflickr.com/1024/600?random=3298" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7085), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7085), "https://loremflickr.com/1024/768?random=3132" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7086), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7086), "https://loremflickr.com/800/600?random=3342" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7087), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7088), "https://loremflickr.com/1200/900?random=3260" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7089), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7089), "https://loremflickr.com/800/600?random=3413" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7091), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7091), "https://loremflickr.com/800/900?random=3348" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7125), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7125), "https://loremflickr.com/1200/600?random=2710" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7126), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7126), "https://loremflickr.com/1024/600?random=2933" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7128), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7128), "https://loremflickr.com/1200/768?random=2674" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7129), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7129), "https://loremflickr.com/1200/900?random=3049" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7161), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7161), "https://loremflickr.com/800/600?random=3070" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7162), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7163), "https://loremflickr.com/1024/600?random=3280" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7164), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7164), "https://loremflickr.com/1024/768?random=3595" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7165), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7165), "https://loremflickr.com/1200/900?random=3027" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7167), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7167), "https://loremflickr.com/800/768?random=2745" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7201), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7201), "https://loremflickr.com/1024/600?random=3383" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7202), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7202), "https://loremflickr.com/1024/768?random=3745" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7205), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7205), "https://loremflickr.com/1024/600?random=3212" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7206), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7206), "https://loremflickr.com/1200/600?random=3383" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7207), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7208), "https://loremflickr.com/1200/768?random=2978" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7209), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7209), "https://loremflickr.com/1200/600?random=3064" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7246), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7246), "https://loremflickr.com/1200/768?random=3817" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7247), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7247), "https://loremflickr.com/1024/900?random=2914" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7248), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7249), "https://loremflickr.com/1024/768?random=3875" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7250), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7250), "https://loremflickr.com/1024/768?random=3257" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7251), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7251), "https://loremflickr.com/800/768?random=3149" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7253), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7253), "https://loremflickr.com/800/768?random=3095" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7287), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7287), "https://loremflickr.com/800/768?random=3325" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7289), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7289), "https://loremflickr.com/1024/600?random=3217" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7290), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7290), "https://loremflickr.com/1200/768?random=3805" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7291), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7292), "https://loremflickr.com/800/900?random=3378" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7293), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7293), "https://loremflickr.com/1024/900?random=3672" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7321), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7321), "https://loremflickr.com/800/900?random=4089" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7322), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7323), "https://loremflickr.com/800/600?random=3156" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7324), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7324), "https://loremflickr.com/800/900?random=3856" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7325), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7325), "https://loremflickr.com/1024/900?random=3345" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7326), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7327), "https://loremflickr.com/800/600?random=3121" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7471), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7471), "https://loremflickr.com/1024/600?random=3953" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7473), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7473), "https://loremflickr.com/1200/768?random=3896" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7474), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7475), "https://loremflickr.com/800/900?random=3487" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7476), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7476), "https://loremflickr.com/800/900?random=3443" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7478), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7478), "https://loremflickr.com/1200/768?random=3275" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7528), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7528), "https://loremflickr.com/800/600?random=3528" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7529), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7529), "https://loremflickr.com/800/600?random=3854" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7531), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7531), "https://loremflickr.com/1200/768?random=3906" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7532), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7532), "https://loremflickr.com/1024/600?random=3665" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7533), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7534), "https://loremflickr.com/1200/900?random=3928" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7535), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7535), "https://loremflickr.com/1024/900?random=3522" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7568), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7568), "https://loremflickr.com/800/768?random=4155" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7569), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7570), "https://loremflickr.com/1200/600?random=3697" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7571), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7571), "https://loremflickr.com/1024/600?random=4063" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7572), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7572), "https://loremflickr.com/1200/768?random=4181" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7604), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7605), "https://loremflickr.com/1200/900?random=3683" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7606), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7606), "https://loremflickr.com/800/600?random=4018" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7608), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7608), "https://loremflickr.com/1024/900?random=4178" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7609), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7609), "https://loremflickr.com/800/900?random=4020" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7646), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7646), "https://loremflickr.com/1200/768?random=4394" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7648), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7648), "https://loremflickr.com/800/900?random=4344" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7649), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7649), "https://loremflickr.com/1024/900?random=4424" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7670), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7670), "https://loremflickr.com/1024/600?random=3712" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7671), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7672), "https://loremflickr.com/800/900?random=4575" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7673), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7673), "https://loremflickr.com/1024/900?random=4241" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7674), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7674), "https://loremflickr.com/1200/768?random=3930" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7708), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7708), "https://loremflickr.com/1024/768?random=4310" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7709), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7709), "https://loremflickr.com/800/900?random=4047" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7711), "https://loremflickr.com/800/900?random=4197" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7712), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7712), "https://loremflickr.com/1200/768?random=4408" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7713), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7714), "https://loremflickr.com/800/900?random=4516" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7715), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7715), "https://loremflickr.com/1024/600?random=3962" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7734), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7735), "https://loremflickr.com/1200/768?random=4270" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7736), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7736), "https://loremflickr.com/1200/900?random=4367" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7737), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7737), "https://loremflickr.com/1200/600?random=4899" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7738), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7739), "https://loremflickr.com/1200/768?random=4258" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7740), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7740), "https://loremflickr.com/1200/768?random=4466" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7741), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7741), "https://loremflickr.com/1024/600?random=4003" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7769), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7769), "https://loremflickr.com/800/900?random=4329" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7770), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7770), "https://loremflickr.com/800/768?random=4317" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7771), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7772), "https://loremflickr.com/1200/600?random=4209" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7805), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7805), "https://loremflickr.com/1024/768?random=4956" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7806), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7807), "https://loremflickr.com/800/600?random=4392" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7808), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7808), "https://loremflickr.com/800/600?random=4830" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7809), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7809), "https://loremflickr.com/1200/900?random=5013" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7810), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7811), "https://loremflickr.com/800/768?random=4506" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7844), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7844), "https://loremflickr.com/1024/900?random=4529" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7845), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7846), "https://loremflickr.com/1024/900?random=4616" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7847), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7847), "https://loremflickr.com/1200/900?random=4664" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7848), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7848), "https://loremflickr.com/800/600?random=4934" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7849), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7850), "https://loremflickr.com/1024/768?random=5165" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7851), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7851), "https://loremflickr.com/1024/768?random=5003" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7873), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7873), "https://loremflickr.com/1024/600?random=5198" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7874), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7874), "https://loremflickr.com/800/900?random=4876" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7875), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7876), "https://loremflickr.com/800/768?random=4862" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7907), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7907), "https://loremflickr.com/800/600?random=4426" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7908), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7909), "https://loremflickr.com/800/600?random=4636" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7910), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7910), "https://loremflickr.com/800/768?random=5307" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7911), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7911), "https://loremflickr.com/1024/768?random=4431" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7912), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7913), "https://loremflickr.com/1200/900?random=5383" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7940), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7940), "https://loremflickr.com/800/600?random=5192" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7941), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7942), "https://loremflickr.com/800/600?random=5151" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7943), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7943), "https://loremflickr.com/800/900?random=5381" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7944), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7944), "https://loremflickr.com/1200/900?random=4859" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7972), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7972), "https://loremflickr.com/1024/768?random=4799" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7974), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7974), "https://loremflickr.com/1024/768?random=5225" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7975), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(7975), "https://loremflickr.com/800/900?random=5156" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8007), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8007), "https://loremflickr.com/800/900?random=4984" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8008), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8008), "https://loremflickr.com/800/768?random=5366" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8009), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8009), "https://loremflickr.com/1024/768?random=4984" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8010), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8011), "https://loremflickr.com/1200/768?random=5604" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8046), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8046), "https://loremflickr.com/800/768?random=4819" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8047), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8048), "https://loremflickr.com/800/768?random=5352" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8049), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8049), "https://loremflickr.com/1200/900?random=5425" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8050), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8050), "https://loremflickr.com/1200/768?random=4924" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8051), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8052), "https://loremflickr.com/1200/768?random=4968" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8071), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8072), "https://loremflickr.com/800/900?random=5217" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8073), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8073), "https://loremflickr.com/1024/768?random=5739" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8074), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8074), "https://loremflickr.com/800/600?random=5280" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8075), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8076), "https://loremflickr.com/1200/600?random=5034" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8077), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8077), "https://loremflickr.com/1200/900?random=4979" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8106), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8106), "https://loremflickr.com/1200/768?random=5238" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8107), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8108), "https://loremflickr.com/1024/900?random=5337" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8109), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8109), "https://loremflickr.com/1200/900?random=5292" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8110), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8110), "https://loremflickr.com/1200/900?random=5759" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8111), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8112), "https://loremflickr.com/800/600?random=5949" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8113), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8113), "https://loremflickr.com/1200/900?random=5961" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8141), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8141), "https://loremflickr.com/1024/600?random=5214" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8142), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8142), "https://loremflickr.com/1200/600?random=5563" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8143), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8144), "https://loremflickr.com/800/768?random=5452" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8145), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8145), "https://loremflickr.com/1024/768?random=5448" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8146), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8146), "https://loremflickr.com/800/900?random=5428" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8181), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8181), "https://loremflickr.com/1200/600?random=6180" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8182), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8182), "https://loremflickr.com/1024/600?random=5534" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8183), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8184), "https://loremflickr.com/800/900?random=5613" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8185), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8185), "https://loremflickr.com/1024/600?random=5701" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8208), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8208), "https://loremflickr.com/1024/900?random=5774" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8209), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8209), "https://loremflickr.com/1024/768?random=6279" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8210), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8210), "https://loremflickr.com/1024/900?random=5563" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8211), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8212), "https://loremflickr.com/1024/768?random=5612" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8213), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8213), "https://loremflickr.com/800/768?random=5526" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8214), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8215), "https://loremflickr.com/800/768?random=5691" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8240), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8242), "https://loremflickr.com/800/900?random=6258" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8243), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8244), "https://loremflickr.com/800/600?random=6296" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8245), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8245), "https://loremflickr.com/800/900?random=5470" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8246), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8246), "https://loremflickr.com/1200/600?random=5764" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8247), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8247), "https://loremflickr.com/800/600?random=5445" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8275), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8275), "https://loremflickr.com/1024/900?random=6270" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8282), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8283), "https://loremflickr.com/1200/900?random=6481" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8284), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8284), "https://loremflickr.com/1024/600?random=6311" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8285), "https://loremflickr.com/800/900?random=6349" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8286), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8287), "https://loremflickr.com/800/900?random=6192" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8288), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8288), "https://loremflickr.com/1200/600?random=5944" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8320), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8320), "https://loremflickr.com/1024/600?random=6065" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8321), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8321), "https://loremflickr.com/1024/900?random=6563" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8322), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8323), "https://loremflickr.com/1200/900?random=6560" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8324), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8324), "https://loremflickr.com/1200/900?random=6383" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8325), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8325), "https://loremflickr.com/1024/768?random=5639" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8359), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8359), "https://loremflickr.com/800/600?random=6184" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8361), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8361), "https://loremflickr.com/1024/900?random=6264" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8362), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8362), "https://loremflickr.com/1024/600?random=6236" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8363), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8364), "https://loremflickr.com/1024/600?random=6037" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8365), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8365), "https://loremflickr.com/1200/600?random=6672" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8366), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8367), "https://loremflickr.com/800/900?random=6503" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8394), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8394), "https://loremflickr.com/800/768?random=6136" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8395), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8396), "https://loremflickr.com/1024/900?random=5804" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8397), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8397), "https://loremflickr.com/1200/900?random=5975" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8398), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8398), "https://loremflickr.com/800/600?random=6334" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8399), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8400), "https://loremflickr.com/1024/768?random=6627" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8436), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8436), "https://loremflickr.com/1024/768?random=6053" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8437), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8437), "https://loremflickr.com/800/768?random=6066" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8438), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8438), "https://loremflickr.com/800/900?random=6551" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8439), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8440), "https://loremflickr.com/1200/900?random=5986" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8441), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8441), "https://loremflickr.com/1200/900?random=6162" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8442), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8443), "https://loremflickr.com/1200/768?random=5919" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8471), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8471), "https://loremflickr.com/1200/900?random=6992" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8472), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8473), "https://loremflickr.com/1024/768?random=6844" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8474), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8474), "https://loremflickr.com/1024/768?random=6458" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8475), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8475), "https://loremflickr.com/1200/900?random=6460" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8476), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8476), "https://loremflickr.com/1024/600?random=6207" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8478), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8478), "https://loremflickr.com/800/768?random=6897" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8511), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8511), "https://loremflickr.com/800/768?random=6721" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8512), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8512), "https://loremflickr.com/1200/900?random=6135" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8513), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8514), "https://loremflickr.com/800/600?random=6572" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8515), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8515), "https://loremflickr.com/1024/900?random=7047" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8516), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8516), "https://loremflickr.com/800/900?random=7084" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8518), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8518), "https://loremflickr.com/1200/900?random=6232" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8548), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8548), "https://loremflickr.com/800/900?random=7081" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8549), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8549), "https://loremflickr.com/1200/900?random=6568" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8550), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8551), "https://loremflickr.com/1024/768?random=6821" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8552), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8552), "https://loremflickr.com/800/900?random=6350" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8553), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8553), "https://loremflickr.com/1024/768?random=6592" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8587), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8587), "https://loremflickr.com/1024/768?random=6908" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8588), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8589), "https://loremflickr.com/800/768?random=7260" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8590), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8590), "https://loremflickr.com/800/600?random=6794" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8619), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8619), "https://loremflickr.com/1024/900?random=6929" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8620), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8621), "https://loremflickr.com/1024/768?random=6598" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8622), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8622), "https://loremflickr.com/1200/900?random=7031" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8662), "https://loremflickr.com/800/900?random=6851" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8663), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8663), "https://loremflickr.com/1024/900?random=6805" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8664), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8664), "https://loremflickr.com/1024/900?random=6555" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8666), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8666), "https://loremflickr.com/1024/768?random=7146" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8686), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8686), "https://loremflickr.com/800/600?random=7200" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8687), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8687), "https://loremflickr.com/1200/768?random=7023" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8689), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8689), "https://loremflickr.com/800/768?random=6975" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8690), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8690), "https://loremflickr.com/1024/900?random=7181" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8720), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8720), "https://loremflickr.com/1200/600?random=7079" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8721), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8722), "https://loremflickr.com/800/768?random=7364" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8723), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8723), "https://loremflickr.com/800/900?random=7580" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8724), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8724), "https://loremflickr.com/800/768?random=6841" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8725), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8726), "https://loremflickr.com/1200/900?random=6816" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8759), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8759), "https://loremflickr.com/1024/768?random=7365" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8760), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8761), "https://loremflickr.com/1024/600?random=7309" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8762), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8762), "https://loremflickr.com/800/600?random=7340" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8763), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8763), "https://loremflickr.com/800/768?random=7680" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8764), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8765), "https://loremflickr.com/800/600?random=7002" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8766), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8766), "https://loremflickr.com/1024/900?random=7284" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8798), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8798), "https://loremflickr.com/800/768?random=7180" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8799), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8799), "https://loremflickr.com/1200/600?random=7558" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8800), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8801), "https://loremflickr.com/1200/768?random=7187" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8802), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8802), "https://loremflickr.com/1200/600?random=7101" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8810), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8810), "https://loremflickr.com/1024/768?random=7537" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8838), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8838), "https://loremflickr.com/1200/768?random=7129" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8839), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8839), "https://loremflickr.com/1200/900?random=7234" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8841), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8841), "https://loremflickr.com/1024/600?random=7839" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8842), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8842), "https://loremflickr.com/1200/600?random=8001" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8864), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8864), "https://loremflickr.com/1200/768?random=7893" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8865), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8865), "https://loremflickr.com/1200/900?random=7836" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8866), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8866), "https://loremflickr.com/1024/768?random=8046" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8867), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8868), "https://loremflickr.com/1024/600?random=7850" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8892), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8892), "https://loremflickr.com/1200/600?random=7654" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8893), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8894), "https://loremflickr.com/800/600?random=7253" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8895), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8895), "https://loremflickr.com/800/900?random=8160" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8896), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8896), "https://loremflickr.com/1200/900?random=7965" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8897), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8898), "https://loremflickr.com/800/900?random=7805" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8924), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8924), "https://loremflickr.com/800/600?random=7619" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8925), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8925), "https://loremflickr.com/800/768?random=7507" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8926), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8927), "https://loremflickr.com/1200/900?random=8168" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8928), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8928), "https://loremflickr.com/1200/768?random=7995" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8957), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8957), "https://loremflickr.com/1200/768?random=8126" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8958), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8959), "https://loremflickr.com/1024/768?random=7916" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8960), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8960), "https://loremflickr.com/1024/900?random=7885" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8961), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8962), "https://loremflickr.com/1024/768?random=7817" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8963), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8963), "https://loremflickr.com/1200/600?random=7634" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8964), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8965), "https://loremflickr.com/800/600?random=7674" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8987), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8987), "https://loremflickr.com/1024/600?random=7860" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8988), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8988), "https://loremflickr.com/1024/600?random=8265" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8989), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8990), "https://loremflickr.com/1200/768?random=8420" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8991), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8991), "https://loremflickr.com/800/900?random=8337" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8996), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8996), "https://loremflickr.com/800/600?random=8394" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8997), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(8998), "https://loremflickr.com/1024/768?random=7599" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9021), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9022), "https://loremflickr.com/800/900?random=8148" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9023), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9023), "https://loremflickr.com/1024/768?random=7739" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9024), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9024), "https://loremflickr.com/1200/768?random=8322" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9057), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9057), "https://loremflickr.com/1200/900?random=7948" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9058), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9058), "https://loremflickr.com/800/600?random=8313" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9059), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9060), "https://loremflickr.com/1024/768?random=8263" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9061), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9061), "https://loremflickr.com/800/768?random=8578" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9065), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9066), "https://loremflickr.com/1200/600?random=8145" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9086), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9087), "https://loremflickr.com/800/600?random=8259" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9088), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9088), "https://loremflickr.com/800/600?random=7828" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9089), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9089), "https://loremflickr.com/800/900?random=7944" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9118), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9118), "https://loremflickr.com/1024/900?random=8682" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9119), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9119), "https://loremflickr.com/800/900?random=8482" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9120), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9121), "https://loremflickr.com/1024/600?random=8832" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9122), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9122), "https://loremflickr.com/1024/600?random=8247" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9149), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9149), "https://loremflickr.com/800/600?random=8685" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9150), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9150), "https://loremflickr.com/800/768?random=8887" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9151), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9152), "https://loremflickr.com/1024/900?random=8137" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9153), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9153), "https://loremflickr.com/1200/900?random=8151" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9154), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9154), "https://loremflickr.com/800/600?random=8185" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9173), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9173), "https://loremflickr.com/1200/900?random=8577" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9174), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9174), "https://loremflickr.com/1024/768?random=9033" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9175), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9176), "https://loremflickr.com/1024/768?random=8212" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9177), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9177), "https://loremflickr.com/1200/600?random=8292" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9216), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9216), "https://loremflickr.com/1200/768?random=8698" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9217), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9218), "https://loremflickr.com/1024/600?random=8672" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9219), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9219), "https://loremflickr.com/800/900?random=8593" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9220), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9220), "https://loremflickr.com/1200/768?random=8620" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9245), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9246), "https://loremflickr.com/1200/600?random=8435" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9247), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9247), "https://loremflickr.com/1024/900?random=8351" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9248), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9248), "https://loremflickr.com/1200/600?random=8972" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9250), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9250), "https://loremflickr.com/1024/600?random=8391" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9251), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9251), "https://loremflickr.com/1024/900?random=9126" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9253), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9253), "https://loremflickr.com/800/600?random=8331" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9287), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9287), "https://loremflickr.com/1200/600?random=8415" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9288), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9288), "https://loremflickr.com/1200/900?random=8959" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9289), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9290), "https://loremflickr.com/1024/768?random=8770" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9322), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9322), "https://loremflickr.com/1024/600?random=8794" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9323), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9323), "https://loremflickr.com/800/768?random=9397" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9324), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9325), "https://loremflickr.com/1024/600?random=8519" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9326), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9326), "https://loremflickr.com/1024/768?random=9066" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9327), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9328), "https://loremflickr.com/800/900?random=9393" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9329), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9329), "https://loremflickr.com/1200/900?random=9064" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9357), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9357), "https://loremflickr.com/800/900?random=8723" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9358), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9359), "https://loremflickr.com/800/600?random=9354" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9360), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9360), "https://loremflickr.com/1024/600?random=9338" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9361), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9361), "https://loremflickr.com/800/600?random=9445" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9387), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9387), "https://loremflickr.com/800/600?random=9060" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9388), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9388), "https://loremflickr.com/800/768?random=9184" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9389), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9389), "https://loremflickr.com/1024/768?random=9170" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9424), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9425), "https://loremflickr.com/800/600?random=8862" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9426), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9426), "https://loremflickr.com/800/768?random=9264" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9427), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9427), "https://loremflickr.com/1024/768?random=9450" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9428), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9428), "https://loremflickr.com/800/768?random=9530" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9430), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9430), "https://loremflickr.com/1024/900?random=9340" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9465), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9465), "https://loremflickr.com/1024/600?random=8927" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9466), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9467), "https://loremflickr.com/800/900?random=9286" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9468), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9468), "https://loremflickr.com/1200/600?random=9289" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9489), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9489), "https://loremflickr.com/1024/900?random=9923" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9491), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9491), "https://loremflickr.com/800/768?random=9908" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9492), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9492), "https://loremflickr.com/1024/600?random=9972" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9493), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9493), "https://loremflickr.com/800/900?random=9754" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9494), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9495), "https://loremflickr.com/1024/600?random=9533" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9528), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9528), "https://loremflickr.com/800/900?random=9443" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9529), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9530), "https://loremflickr.com/800/768?random=9808" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9531), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9531), "https://loremflickr.com/1200/900?random=9841" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9532), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9532), "https://loremflickr.com/1024/768?random=9858" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9561), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9561), "https://loremflickr.com/800/768?random=9247" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9562), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9563), "https://loremflickr.com/800/768?random=9735" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9564), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9564), "https://loremflickr.com/800/768?random=9758" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9565), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9566), "https://loremflickr.com/800/900?random=10178" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9595), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9596), "https://loremflickr.com/1200/900?random=9363" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9597), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9598), "https://loremflickr.com/1024/900?random=9636" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9599), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9599), "https://loremflickr.com/1024/768?random=9612" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9600), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9600), "https://loremflickr.com/1200/900?random=9608" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9621), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9621), "https://loremflickr.com/1024/900?random=9878" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9622), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9622), "https://loremflickr.com/800/768?random=9494" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9623), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9624), "https://loremflickr.com/1200/900?random=10298" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9625), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9625), "https://loremflickr.com/1024/768?random=10369" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9646), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9647), "https://loremflickr.com/800/768?random=10182" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9648), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9648), "https://loremflickr.com/1200/900?random=9908" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9649), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9650), "https://loremflickr.com/800/600?random=10418" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9651), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9651), "https://loremflickr.com/1024/900?random=9762" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9652), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9652), "https://loremflickr.com/1200/900?random=9761" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9682), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9683), "https://loremflickr.com/1024/900?random=9708" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9684), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9684), "https://loremflickr.com/1024/600?random=10461" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9685), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9685), "https://loremflickr.com/800/900?random=10015" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9712), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9712), "https://loremflickr.com/800/900?random=9827" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9713), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9713), "https://loremflickr.com/1200/600?random=9938" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9715), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9715), "https://loremflickr.com/800/900?random=10577" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9716), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9716), "https://loremflickr.com/1200/768?random=9832" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9717), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9718), "https://loremflickr.com/1200/900?random=9722" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9740), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9741), "https://loremflickr.com/800/768?random=10383" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9742), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9742), "https://loremflickr.com/800/900?random=9811" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9743), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9744), "https://loremflickr.com/800/900?random=9976" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9745), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9745), "https://loremflickr.com/1200/900?random=10002" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9746), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9747), "https://loremflickr.com/800/600?random=10633" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9769), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9770), "https://loremflickr.com/1024/900?random=10504" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9771), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9771), "https://loremflickr.com/1200/600?random=10283" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9773), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9773), "https://loremflickr.com/1024/900?random=10833" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9774), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9774), "https://loremflickr.com/800/900?random=9964" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9776), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9776), "https://loremflickr.com/1024/900?random=10558" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9777), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9777), "https://loremflickr.com/1024/600?random=10001" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9810), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9810), "https://loremflickr.com/1024/768?random=10087" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9811), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9812), "https://loremflickr.com/1200/600?random=10433" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedAt", "UpdatedAt", "Url" },
                values: new object[] { new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9813), new DateTime(2025, 2, 27, 8, 5, 35, 2, DateTimeKind.Utc).AddTicks(9813), "https://loremflickr.com/800/900?random=10066" });

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
    }
}
