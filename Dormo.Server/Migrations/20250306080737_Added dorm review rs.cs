using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dormo.Server.Migrations
{
    /// <inheritdoc />
    public partial class Addeddormreviewrs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DormReviews_Dorms_DormId1",
                table: "DormReviews");

            migrationBuilder.DropIndex(
                name: "IX_DormReviews_DormId1",
                table: "DormReviews");

            migrationBuilder.DropColumn(
                name: "DormId1",
                table: "DormReviews");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b69b3143-680f-4e63-8d91-409ecdd04011");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a3788a6b-3b6f-4a6e-b9be-48d2148ca555");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "68580476-a9ec-4ad1-b2f0-f5d0250a1cad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "ff99bd3d-7444-4175-baed-20377d660e4d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "43fa0b98-6fe2-4dff-8a61-58e99d5cdc1d", new DateTime(2025, 3, 6, 8, 7, 36, 219, DateTimeKind.Utc).AddTicks(9334), "AQAAAAIAAYagAAAAEH83D77AzXy58+9EUAaK9UDUglU229SaV5MHq5p0iLJXJiY7ldtwdvojhWxh7HbaKg==", "debec12c-6052-48f6-80ab-40c6cce08b35", new DateTime(2025, 3, 6, 8, 7, 36, 219, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e68d40d6-ae3a-4134-982e-8e6a9e212420", new DateTime(2025, 3, 6, 8, 7, 36, 176, DateTimeKind.Utc).AddTicks(1642), "AQAAAAIAAYagAAAAEEQyyMNiA4al9GVctfuspTsvn0AJZc3UOTc1Mhr2onm3s0S03D0FHhvFqmLMLiVmvQ==", "13253b87-0b56-4805-a7fe-d5508ad5c8fa", new DateTime(2025, 3, 6, 8, 7, 36, 176, DateTimeKind.Utc).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "dadf9be4-e92f-4a9f-8e80-dd5da417bb54", new DateTime(2025, 3, 6, 8, 7, 36, 133, DateTimeKind.Utc).AddTicks(6983), "AQAAAAIAAYagAAAAEF9upezZmga5D05vDjEXZK9zbFIPoMtOtx6kEZTLB+sf6RNeLKMOyPpT4FSdTCTrkg==", "0f666f9c-a1af-4c43-8375-62b68c2af20e", new DateTime(2025, 3, 6, 8, 7, 36, 133, DateTimeKind.Utc).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1f3b0c71-0c98-4707-a5ba-67ee60df2e31", new DateTime(2025, 3, 6, 8, 7, 36, 91, DateTimeKind.Utc).AddTicks(2466), "AQAAAAIAAYagAAAAEFSeA+H8fntEZBea3n94KWivgsMod1P9Mdnp6reUF8PeQqDHrJ+CRuh8c2CVi69Thg==", "07b33fac-16b2-4fc1-b092-0337cde45baf", new DateTime(2025, 3, 6, 8, 7, 36, 91, DateTimeKind.Utc).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9eb5f1de-6415-44c0-838d-7f558a92c637", new DateTime(2025, 3, 6, 8, 7, 36, 46, DateTimeKind.Utc).AddTicks(9281), "AQAAAAIAAYagAAAAEB2VlWtxCa/FJNmXkTSu9rd+rHxfc+q8rCFo56h+oyNibxMzCqTOjncVIKFMihADNA==", "f519bfe1-4248-4dff-80c8-54e316b9bf62", new DateTime(2025, 3, 6, 8, 7, 36, 46, DateTimeKind.Utc).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6d653803-d244-4734-b508-5f118f32d8b5", new DateTime(2025, 3, 6, 8, 7, 36, 3, DateTimeKind.Utc).AddTicks(7803), "AQAAAAIAAYagAAAAEDCUH0Uv/cASo+XDRzs9j106oI26B9gpsWBxYmLdp5TdUPbIbJ2nxVx8n4A7uQV+pg==", "b44dc12f-f89d-4663-a886-75472552b639", new DateTime(2025, 3, 6, 8, 7, 36, 3, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-001",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "c0608608-583d-470c-8885-51255ba5eea7", new DateTime(2025, 3, 6, 8, 7, 36, 260, DateTimeKind.Utc).AddTicks(7505), "AQAAAAIAAYagAAAAEGAc1/2mC5u1XdLIo3Rd3nRSCUBk7ghCNPU+hqffGbKkN/8bUp5m0XLcX/v5SQHK+w==", "aca54ff4-3a13-4189-9a1b-f71464b17c4e", new DateTime(2025, 3, 6, 8, 7, 36, 260, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-002",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "301317bf-628e-4e32-a06c-293dcff50c5e", new DateTime(2025, 3, 6, 8, 7, 36, 302, DateTimeKind.Utc).AddTicks(6780), "AQAAAAIAAYagAAAAENqFCR82x40t5TODi1l7mFFrHSSINv6O22HXvh/X3sv8GjkCdWN42zdzpZRD+9iFWA==", "3261ebf2-ade3-4440-bdce-f50b632db8bc", new DateTime(2025, 3, 6, 8, 7, 36, 302, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-003",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e40736c9-7cc7-4c57-b3d0-3814b0d34c8e", new DateTime(2025, 3, 6, 8, 7, 36, 344, DateTimeKind.Utc).AddTicks(663), "AQAAAAIAAYagAAAAEG3DBDpghjcB7asaR9DfwCHvRaFqnO1VKJJxVi3vhcmPWTkTKt8pL6gxysNb22OKQQ==", "33918c8c-6b9c-442c-adad-d2545ff78ae0", new DateTime(2025, 3, 6, 8, 7, 36, 344, DateTimeKind.Utc).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-004",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "129b2122-99ba-409a-8517-3860a4512550", new DateTime(2025, 3, 6, 8, 7, 36, 386, DateTimeKind.Utc).AddTicks(4670), "AQAAAAIAAYagAAAAEAJLMG1p1zUOBnZYSlZCRSmYMdOZKznekBcAobQQRE7jEQt+KzeyjnYU7KrcHCLT9Q==", "1e1f09c0-d1ba-4365-aa7a-749e1fce67ea", new DateTime(2025, 3, 6, 8, 7, 36, 386, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-005",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5516fc49-2e83-4eb7-868e-d3222837ab14", new DateTime(2025, 3, 6, 8, 7, 36, 428, DateTimeKind.Utc).AddTicks(1161), "AQAAAAIAAYagAAAAEOeTZqSEbV8LA4deMncwJyn7nvbu6HYOBX+gWeFIXMiSj2Xus3V5PIlqlwSz0iAHXA==", "a7dc7717-6f14-4828-a75f-fbd0deaf515a", new DateTime(2025, 3, 6, 8, 7, 36, 428, DateTimeKind.Utc).AddTicks(1166) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-006",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "7c2c3010-4dca-4bac-a615-96bd82400fe1", new DateTime(2025, 3, 6, 8, 7, 36, 470, DateTimeKind.Utc).AddTicks(3487), "AQAAAAIAAYagAAAAEN4W8srDO5/3VrbH5XzdOUKBYCIbJOnkSEbCXC4HjMiB8nLY0+6+Gf51+3Bf4AfBVQ==", "7239ace3-7ee6-4354-8cb8-218eeac59736", new DateTime(2025, 3, 6, 8, 7, 36, 470, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-007",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1a1bd68a-a907-4f97-b6d8-efd3204dd52f", new DateTime(2025, 3, 6, 8, 7, 36, 513, DateTimeKind.Utc).AddTicks(8591), "AQAAAAIAAYagAAAAEK7+Pf0XGfdGMzYcaLx4s/lywYDFYX2BJqVPgxG+ELHl/6qU8rcwXdZ4DvrFRi+gQw==", "6769eff9-b775-49f6-929d-b007fc795b81", new DateTime(2025, 3, 6, 8, 7, 36, 513, DateTimeKind.Utc).AddTicks(8608) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-008",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d4014a95-5676-4f03-b28d-043eb48e5afe", new DateTime(2025, 3, 6, 8, 7, 36, 560, DateTimeKind.Utc).AddTicks(9571), "AQAAAAIAAYagAAAAEDcuqvDQIpbWbIHvwl3Tnqa8W5D4upUCQXNA83jDKe1DQLQ7I2x2NO/RdlO2Nnug6Q==", "ef90ed20-98d2-4d14-b8ba-5b6fdfaa0e5a", new DateTime(2025, 3, 6, 8, 7, 36, 560, DateTimeKind.Utc).AddTicks(9577) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-009",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "19c33808-0f37-48b7-84ac-28f5cdebfb63", new DateTime(2025, 3, 6, 8, 7, 36, 604, DateTimeKind.Utc).AddTicks(3852), "AQAAAAIAAYagAAAAEK7n+Ox0vBQcLcH/9WGVZaNM9vy7Py4fe8oIVhfIWoH98vXoxX9y3anDOVxXyoS1VQ==", "159aa957-90bc-4f60-b5d2-e68cb13cc97f", new DateTime(2025, 3, 6, 8, 7, 36, 604, DateTimeKind.Utc).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-010",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "81f8f742-f545-4d8b-81fd-7b1a90642456", new DateTime(2025, 3, 6, 8, 7, 36, 647, DateTimeKind.Utc).AddTicks(3640), "AQAAAAIAAYagAAAAEB1cP3vjjyKaiDjyhnWmJKmwVdjsP17OwdC6If7j0acOP4l5e1BLZyOXfGTG4iZldw==", "07884ec8-4e8c-4b2f-a2f4-ef70716a20f7", new DateTime(2025, 3, 6, 8, 7, 36, 647, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(7746), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8470), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8474), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8476), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8478), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8480), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8482), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8484), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8488) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8490), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8491), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8493), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8513), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8515), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8515) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8518), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8520), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8528), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8529), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8531), new DateTime(2025, 3, 6, 8, 7, 36, 689, DateTimeKind.Utc).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1429), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1543), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1643), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2007), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2077), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2277), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2355), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2478), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2978), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3046), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3122), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3122) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3150), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3207), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3486), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3534), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3581), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3647), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3757), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3933), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4040), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4072), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4322), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4497), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4498) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4611), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4721), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4759), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4831), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5030), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5065), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 3, 16, 7, 36, 692, DateTimeKind.Local).AddTicks(7203), new DateTime(2025, 3, 6, 16, 7, 36, 693, DateTimeKind.Local).AddTicks(7387) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1469), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1554), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1603), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1652), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1702), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1746), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1795), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1825), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1871), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1905), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1946), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1975), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2014), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2047), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2047) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2086), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2133), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2172), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2202), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2238), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2284), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2324), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2366), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2407), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 3, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2453), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2485), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2528), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2565), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2592), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2631), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2632) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2670), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 8, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2709), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2753), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2787), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2824), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2858), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2858) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2885), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2916), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2916) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2953), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2986), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3026), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3026) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3053), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3091), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3129), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3158), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3186), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3213), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3254), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3285), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3315), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3344), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3376), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3408), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3453), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3493), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3541), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3589), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3623), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3655), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3688), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3716), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3764), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3801), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3832), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3869), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3909), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3944), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3979), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4020), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4021) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4047), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4084), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4118), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4157), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4192), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4223), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4251), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4252) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4295), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4334), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4368), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4392), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4436), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4466), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4505), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4555), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4590), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4624), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4657), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4692), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4692) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4728), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4772), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4809), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4843), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4880), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4909), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4941), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4965), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4998), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5036), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5071), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5095), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(914), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(1166), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(1167) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(1168), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(1169), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(1170), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(1170) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(1171), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(500), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(921), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(924), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(926), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(927) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(934), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(938), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(938) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1530), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1532), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1534), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1534) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1536), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1538), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1540), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1591), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1593), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1594), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1635), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1636), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1639), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1640), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1682), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1684), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1685), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1687), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1693), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1729), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1731), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1733), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1734), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1736), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1737), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1779), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1780), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1782), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1784), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1786), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1787), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1811), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1813), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1815), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1815) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1816), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1817) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1856), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1858), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1859), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1861), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1862), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1864), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1893), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1895), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1896), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1898), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1935), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1937), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1939), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1960), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1961), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1963), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1964), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1966), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1967), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1998), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1999), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2001), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2002), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2004), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2033), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2036), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2037), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2039), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2039) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2070), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2072), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2073), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2075), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2115), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2116), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2118), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2157), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2159), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2161), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2162), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2164), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2165), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2188), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2190), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2191), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2224), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2225), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2227), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2228), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2230), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2268), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2270), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2271), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2273), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2274), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2309), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2310), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2312), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2313), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2315), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2316), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2346), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2348), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2349), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2351), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2352), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2391), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2392), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2394), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2394) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2395), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2397), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2399), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2438), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2439), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2441), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2442), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2444), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2445), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2470), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2471), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2473), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2474), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2476), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2514), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2515), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2517), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2520), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2545), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2547), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2553), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2555), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2556), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2558), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2582), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2583), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2585), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2610), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2612), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2613), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2613) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2615), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2615) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2620), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2622), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2659), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2659) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2660), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2662), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2663), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2699), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2701), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2702), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2736), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2736) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2737), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2739), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2741), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2742), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2776), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2778), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2779), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2805), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2805) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2807), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2808), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2810), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2811), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2843), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2845), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2846), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2848), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2849), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2851), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2874), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2875), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2877), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2878), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2903), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2904), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2905) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2906), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2906) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2907), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2909), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2909) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2936), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2938), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2944), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2973), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2974), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2975) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2976), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3007), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3009), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3010), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3011) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3012), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3012) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3017), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3019), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3039), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3041), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3041) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3042), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3043) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3044), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3073), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3075), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3076), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3077), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3079), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3116), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3119), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3143), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3145), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3147), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3148), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3175), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3177), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3178), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3199), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3200), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3202), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3203), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3205), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3240), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3241), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3243), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3244), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3245), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3247), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3275), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3277), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3278), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3305), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3307), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3308), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3331), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3333), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3334), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3336), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3336) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3337), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3359), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3360), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3362), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3363), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3368), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3394), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3395), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3397), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3398), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3400), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3401), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3435), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3440), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3442), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3443), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3445), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3446), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3476), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3477), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3479), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3479) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3480), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3482), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3483), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3525), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3528), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3529), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3532), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3573), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3574), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3576), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3577), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3579), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3613), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3614), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3615), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3641), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3643), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3645), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3675), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3676), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3678), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3680), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3681), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3705), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3706), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3708), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3709), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3749), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3751), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3753), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3753) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3754), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3755), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3788), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3790), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3791), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3793), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3793) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3794), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3820), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3822), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3822) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3823), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3825), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3855), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3857), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3858), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3860), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3861), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3862), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3897), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3898), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3900), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3901), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3926), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3927), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3929), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3929) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3930), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3965), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3966), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3968), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3969), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3971), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3972), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(3972) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4000), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4001), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4003), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4004), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4010), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4011) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4013), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4035), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4036), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4038), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4062), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4063) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4064), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4066), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4067), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4069), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4070), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4103), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4105), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4106), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4108), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4109), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4111), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4111) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4139), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4140), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4142), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4143), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4145), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4149), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4180), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4182), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4183), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4185), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4209), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4211), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4212), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4239), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4241), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4242), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4244), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4282), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4284), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4284) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4285), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4287), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4288), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4313), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4315), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4316), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4318), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4319), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4353), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4354), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4356), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4357), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4359), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4360), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4380), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4382), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4383), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4385), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4386), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4426), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4427), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4429), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4453), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4455), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4456), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4457), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4459), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4490), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4492), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4493), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4495), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4535), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4536), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4538), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4538) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4540), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4541), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4547), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4575), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4576), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4578), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4578) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4579), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4580), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4582), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4604), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4604) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4605), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4607), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4608), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4642), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4644), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4645), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4647), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4648), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4650), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4678), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4681), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4716), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4716) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4718), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4719), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4754), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4756), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4757), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4799), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4800), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4801) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4802), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4822), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4824), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4825), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4827), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4828), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4829) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4870), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4872), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4873), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4898), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4898) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4900), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4901), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4928), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4930), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4932), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4933), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4934), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4954), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4956), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4956) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4957), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4983), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4986), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4987), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4988), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4990), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4991), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5024), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5026), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5026) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5027), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5049), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5051), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5058), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5060), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5061), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5063), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5084), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5085), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5087), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5088), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5120), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5122), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5123), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5131), new DateTime(2025, 3, 6, 8, 7, 36, 694, DateTimeKind.Utc).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3417), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3728), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3730), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3732), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3733), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3734), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 4, 16, 7, 36, 693, DateTimeKind.Local).AddTicks(9707), new DateTime(2025, 3, 6, 16, 7, 36, 693, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 16, 7, 36, 693, DateTimeKind.Local).AddTicks(9731), new DateTime(2025, 3, 6, 16, 7, 36, 693, DateTimeKind.Local).AddTicks(9731) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1488), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1493), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1514), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1514) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1574), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1579), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1584), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1607), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1618), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1657), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1661), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1665), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1669), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1673), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1707), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1711), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1718), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1722), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1750), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1755), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 21, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1759), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1763), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1767), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1800), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1804), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1830), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1834), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1843), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1847), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1851), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1876), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1880), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1886), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1914), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1918), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1923), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1927), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1950), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1954), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1979), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1983), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1992), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2018), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2022), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2026), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2055), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2059), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2064), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2091), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2095), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2099), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2103), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2107), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2138), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2143), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2146), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2151), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2176), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2181), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2207), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2210), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2214), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2218), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2242), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2247), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2251), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2255), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2288), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2292), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2296), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2300), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2304), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2328), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2333), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2333) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2336), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2371), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2375), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2379), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2383), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2411), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2415), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2423), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2427), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2431), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2458), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2461), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2465), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2495), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2499), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2503), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2507), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2532), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2535), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2536) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2539), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2569), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2573), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2577), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2596), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2600), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2604), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2635), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2639), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2643), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2647), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2648) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2651), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2674), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2683), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2687), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2688) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2691), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2713), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2717), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2720), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2724), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2725) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2728), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2758), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2762), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2765), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2769), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2791), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2795), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2799), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2828), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2832), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2835), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2862), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2866), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2893), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2896), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2920), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2923), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2927), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2931), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2931) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2957), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2961), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2965), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2966) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2990), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2994), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2998), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3002), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3029), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3033), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3034) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3058), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3058) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3062), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3062) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3066), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3095), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3099), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3103), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3106), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3110), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3133), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3137), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3167), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3171), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3190), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3193), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3217), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3221), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3225), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3228), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3258), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3262), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3265), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3269), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3289), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3294), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3324), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3348), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3352), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3380), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3384), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3388), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3412), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3416), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3420), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3424), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3428), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3458), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3458) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3461), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3466), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3470), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3497), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3500), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3504), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3508), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3517), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3518) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3545), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3549), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3560), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3564), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3568), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3593), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3597), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3597) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3601), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3627), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3631), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3634), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3659), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3663), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3692), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3696), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3700), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3721), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3725), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3729), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3732), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3737), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3768), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3769) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3772), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3773) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3776), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3780), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3809), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3813), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3836), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3837) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3840), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3844), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 17, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3848), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3878), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3879) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3882), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3886), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3890), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3913), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3914) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3918), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3921), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3949), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3953), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3957), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3961), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3983), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3988), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3991), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3995), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4024), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4028), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4051), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4055), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4089), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4089) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4092), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4096), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4122), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4126), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4130), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4133), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4161), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4165), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4169), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4174), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 14, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4196), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4200), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4204), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4228), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4232), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4255), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4259), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4264), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4268), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 27, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4299), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4303), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4307), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4308) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4338), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4338) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4342), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4345), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4372), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4376), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4396), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4405), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4409), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4413), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4417), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4440), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4444), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4448), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4475), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 18, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4479), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4483), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4509), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4513), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4516), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4520), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4524), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4559), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4563), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4567), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4594), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4598), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4628), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4632), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4636), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4661), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4665), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4669), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 9, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4696), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4700), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4703), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4707), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4711), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4712) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4732), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4736), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4740), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4744), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4748), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4776), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 3, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4780), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 25, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4784), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4788), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4792), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4813), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4817), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4847), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4851), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4854), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4858), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4862), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4884), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4888), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4892), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4918), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4922), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4945), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4949), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4969), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4973), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5002), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5006), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5010), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5014), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5018), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5041), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5045), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5075), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5079), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5100), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5104), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5108), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 15, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5111), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5115), new DateTime(2025, 3, 6, 16, 7, 36, 694, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(7698), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8032), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8034), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8035), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8037), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8038), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8039), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8041), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8043), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8125), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8127), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8128), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8128) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8130), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8131), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8131) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8132), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8134), new DateTime(2025, 3, 6, 8, 7, 36, 690, DateTimeKind.Utc).AddTicks(8134) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DormId1",
                table: "DormReviews",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6ce516b3-6043-4a9a-896c-d57e3566fcbf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6e3354fd-2e54-48c3-a282-bc9c26132d82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "1bb9227d-3c81-421d-8215-9e156d472a3e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "acc452dc-d7c1-4dc8-b9a0-fc83a6b2019e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9a2709dc-dbc2-41e0-aa39-21a28093325c", new DateTime(2025, 3, 6, 7, 50, 32, 205, DateTimeKind.Utc).AddTicks(5025), "AQAAAAIAAYagAAAAECx7g83vRT+1lpWQIzLCkc1TmL8NE4RwlP2wR91C0b3/hlwNBojtY2rNIxnu6X6XPQ==", "823772f9-cbb0-42a9-9ad2-8f22fb2d04e9", new DateTime(2025, 3, 6, 7, 50, 32, 205, DateTimeKind.Utc).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8a356dff-fa7e-4753-afec-8c06a2977359", new DateTime(2025, 3, 6, 7, 50, 32, 165, DateTimeKind.Utc).AddTicks(192), "AQAAAAIAAYagAAAAEKsSCaZroRG9TTwBRMhGxULDOqWWT4+VGketPyE5be7FCGKblqrOAZ+QPVT1GEGHBQ==", "863d7671-5685-45e4-baae-6dadd053e1e7", new DateTime(2025, 3, 6, 7, 50, 32, 165, DateTimeKind.Utc).AddTicks(197) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3ad5008e-41e0-477b-9b1f-a602e0ad9d8f", new DateTime(2025, 3, 6, 7, 50, 32, 123, DateTimeKind.Utc).AddTicks(4676), "AQAAAAIAAYagAAAAEN48CoGacdoxM46KISOkos3MUgmlAVihrFlOUkJdshk+O8iFvK93TzppGGVwHyrQJQ==", "7e09da0c-5e55-49df-8cd9-8c076c58ba84", new DateTime(2025, 3, 6, 7, 50, 32, 123, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8f9c44fa-dd5b-4de7-a929-82760da3f1a1", new DateTime(2025, 3, 6, 7, 50, 32, 82, DateTimeKind.Utc).AddTicks(8488), "AQAAAAIAAYagAAAAEHwACfaZmgAp8f0rmVsyDRFkIHsWSNrqcj1LtriQ+OIHOoIePn6f7GufLYhYjgoXKw==", "6965cb0f-b2ba-49f4-a84d-fb3c23ebb095", new DateTime(2025, 3, 6, 7, 50, 32, 82, DateTimeKind.Utc).AddTicks(8496) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "5e021bf0-49c6-4212-93cf-0b298e7624d9", new DateTime(2025, 3, 6, 7, 50, 32, 41, DateTimeKind.Utc).AddTicks(406), "AQAAAAIAAYagAAAAEPcMb5kPlHOF53XDGuy+hrkaTRidyGVeNp5VPQzSS0RlcURbe2FwRndp/Z3rAi6KlQ==", "5168ae8f-be02-4936-aec5-757819f6b0b3", new DateTime(2025, 3, 6, 7, 50, 32, 41, DateTimeKind.Utc).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "d7d825ea-5016-4f14-9ef8-dce41e48597f", new DateTime(2025, 3, 6, 7, 50, 31, 997, DateTimeKind.Utc).AddTicks(4736), "AQAAAAIAAYagAAAAEANbV3ex3eXKnup04cd2T4yZkCzOYdHtAnGLEEYfGzj4yQHfwWEnJloupsdqFOLKEw==", "dad6ce31-4120-4c4b-8860-9620b8ecb30c", new DateTime(2025, 3, 6, 7, 50, 31, 997, DateTimeKind.Utc).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-001",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "0fbfa90b-e38b-4a1a-a9fb-1eda1d246f71", new DateTime(2025, 3, 6, 7, 50, 32, 248, DateTimeKind.Utc).AddTicks(9207), "AQAAAAIAAYagAAAAEGGoJOHglCI3qbEJJvZFsk4dtF6l0SQP0dytROlHgSPPzsbHh8MPfLzLi3Ojy0mRvA==", "39008df7-87c7-4464-ad8b-51ba10344338", new DateTime(2025, 3, 6, 7, 50, 32, 248, DateTimeKind.Utc).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-002",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "68331edb-1b7d-4ffe-bc20-3017e92d392a", new DateTime(2025, 3, 6, 7, 50, 32, 290, DateTimeKind.Utc).AddTicks(1645), "AQAAAAIAAYagAAAAEAwSqWKsQ8jxZt5EIZFFBXrdy82FjsgYl3y+gdBt0qe2F6yQ2IldbLRPrIjr10xSfQ==", "efaf9fc3-ddeb-4080-9001-6a665e9d0680", new DateTime(2025, 3, 6, 7, 50, 32, 290, DateTimeKind.Utc).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-003",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "b7f78425-1d68-4735-b369-8a75ea6d7812", new DateTime(2025, 3, 6, 7, 50, 32, 330, DateTimeKind.Utc).AddTicks(5926), "AQAAAAIAAYagAAAAENA5TQZFwx8ocLrchgTEHRArdDeqwkErR0JfEdd5SvZg24gDa5S1Kow3tMtMnV2Dng==", "3c7a0a54-0168-451c-8fcc-83d2d9120467", new DateTime(2025, 3, 6, 7, 50, 32, 330, DateTimeKind.Utc).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-004",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "1b1676a1-5c36-4b9d-a130-d0e5c3b0399e", new DateTime(2025, 3, 6, 7, 50, 32, 371, DateTimeKind.Utc).AddTicks(5367), "AQAAAAIAAYagAAAAEEbDWoj1ELhS30qjqMtYDWVokJvVs4LE0bJdspyW3fCD99ub4mPhFtMh8vTWUqZB9g==", "471a6bd1-6ac7-41a7-b357-4ee3573bbd51", new DateTime(2025, 3, 6, 7, 50, 32, 371, DateTimeKind.Utc).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-005",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "6b7caaae-3a38-4fe3-a201-ce4647683a2b", new DateTime(2025, 3, 6, 7, 50, 32, 412, DateTimeKind.Utc).AddTicks(2801), "AQAAAAIAAYagAAAAEOoOCf4ExRALdtAl373Ws7PW+LLGHXJvCCaef6HkLrUzY9SVOOr8EaMnqiWsfovAbg==", "efb7612f-b08d-4c1a-a01e-2eb0f771be39", new DateTime(2025, 3, 6, 7, 50, 32, 412, DateTimeKind.Utc).AddTicks(2807) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-006",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "51568341-3d3b-40a8-b394-78cac5b8966c", new DateTime(2025, 3, 6, 7, 50, 32, 463, DateTimeKind.Utc).AddTicks(1315), "AQAAAAIAAYagAAAAEGkQaLSQOH5SpCFXPw+e+3yoxsxa3lIPuS3yUBtOBDXdpawF9hjpgH53Zx8RR++wRg==", "d8d51c7f-e1fc-4ac9-829e-f070e1a0dfa0", new DateTime(2025, 3, 6, 7, 50, 32, 463, DateTimeKind.Utc).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-007",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e292489c-c0a7-459e-aca3-0b6afdb6eb6d", new DateTime(2025, 3, 6, 7, 50, 32, 506, DateTimeKind.Utc).AddTicks(3915), "AQAAAAIAAYagAAAAEOUPY2KPQzKiBrhhr0uHTKTnJhtz+kgHC1IeubE30ajQiZbFHiz5ZcVKeZu0m0U+Zw==", "c8c69766-ead3-460c-8e41-a000789ed7f3", new DateTime(2025, 3, 6, 7, 50, 32, 506, DateTimeKind.Utc).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-008",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "9fad6de1-6a6b-4717-b699-56996c2c901a", new DateTime(2025, 3, 6, 7, 50, 32, 547, DateTimeKind.Utc).AddTicks(91), "AQAAAAIAAYagAAAAEBpEB1NbU0HeuJmisL5EpQLVgGa4Law8xMRRa06WVF2oMkDYpJ5RfqFr+fptC3N3SA==", "27389e4c-272a-439b-8baa-57953518ab29", new DateTime(2025, 3, 6, 7, 50, 32, 547, DateTimeKind.Utc).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-009",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f798b7a8-9380-4176-b127-479abb197fb2", new DateTime(2025, 3, 6, 7, 50, 32, 590, DateTimeKind.Utc).AddTicks(244), "AQAAAAIAAYagAAAAEHE0mKPTjKL056hEEgW67Y1JLQ47+Pmrmi73UZWO5sJ5jt0Rq8xJYBpPMGcubmsqww==", "1c2c670b-649a-48dc-8082-9bd18600c6a7", new DateTime(2025, 3, 6, 7, 50, 32, 590, DateTimeKind.Utc).AddTicks(249) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "tenant-010",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e30c07c9-ad23-4841-ad2d-63012b4f6b22", new DateTime(2025, 3, 6, 7, 50, 32, 631, DateTimeKind.Utc).AddTicks(3904), "AQAAAAIAAYagAAAAEEcLLfq1D7VhI99US9T4phO+tL8sZKOVJ015hIt29DAcTVzDta5SD65U29Cn+F/22Q==", "af002323-4e6e-4726-836b-41aabca9665b", new DateTime(2025, 3, 6, 7, 50, 32, 631, DateTimeKind.Utc).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(6842), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7625), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7626) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7630), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7634), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7634) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7636), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7643), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7645), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7646) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7648), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7651), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7653), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7653) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7655), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7655) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7657), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7659), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7663), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7665), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7665) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7678), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7678) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7679), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7681), new DateTime(2025, 3, 6, 7, 50, 32, 673, DateTimeKind.Utc).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 15, 50, 32, 677, DateTimeKind.Local).AddTicks(8783), null, new DateTime(2025, 3, 6, 15, 50, 32, 677, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2717), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2951), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3500), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3501) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3605), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3897), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3898) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4017), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4018) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4211), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4991), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5097), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5208), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5271), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5464), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5478) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6056), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6147), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6224), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6337), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6494), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6495) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6752), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6866), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6909), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7215), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7416), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7613), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7772), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7836), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7937), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8192), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "DormReviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "DormId1", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8222), null, new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8222) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 3, 15, 50, 32, 676, DateTimeKind.Local).AddTicks(5953), new DateTime(2025, 3, 6, 15, 50, 32, 677, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2526), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2742), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2865), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2964), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2965) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3046), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3133), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3198), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3249), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3306), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3356), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3414), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3462), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3510), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3568), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3568) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3615), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3676), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3745), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3746) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3785), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3846), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3909), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3977), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3978) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4034), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4099), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4165), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4221), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4273), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4338), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4394), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4459), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4520), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4521) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 8, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4576), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4646), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4698), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4701) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4765), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4812), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4860), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4909), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4953), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5014), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5069), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5106), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5159), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5238), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5280), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5365), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5508), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5636), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5716), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5761), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5815), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5815) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5858), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5927), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5988), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6070), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6159), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6159) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6241), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6294), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6348), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6390), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6439), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6503), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6571), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6619), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6673), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6725), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6759), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6805), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6843), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6874), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6916), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6953), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7001), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7048), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7086), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7116), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7169), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7229), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7268), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7303), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7346), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7387), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7425), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7512), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7572), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7572) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7623), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7673), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7673) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7723), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7783), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7846), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7905), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7945), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8010), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8055), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8093), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8124), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8153), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8199), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8229), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8260), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(524), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(791), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(792), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(794), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(794) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(795), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(796), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(7969), new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(8297), new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(8301), new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(8303), new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(8303) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(8312), new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(8315), new DateTime(2025, 3, 6, 7, 50, 32, 677, DateTimeKind.Utc).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2684), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2691), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2693), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2698), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2701), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2704), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2845), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2847), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2850), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2936), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2940), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2944), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2944) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2947), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3025), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3027), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3029), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3032), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3034), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3086), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3088), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3090), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3092), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3094), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3176), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3179), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3181), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3184), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3186), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3188), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3233), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3237), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3237) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3239), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3287), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3289), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3291), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3293), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3295), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3297), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3340), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3342), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3344), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3346), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3398), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3401), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3404), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3441), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3443), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3445), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3448), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3450), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3452), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3488), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3490), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3493), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3495), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3497), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3549), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3553), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3555), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3558), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3596), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3598), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3600), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3602), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3663), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3665), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3667), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3711), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3713), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3716), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3718), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3720), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3734), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3770), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3773), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3776), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3776) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3817), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3819), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3821), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3824), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3824) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3826), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3885), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3887), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3889), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3891), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3893), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3956), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3957) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3959), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3961), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3962) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3964), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3966), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3968), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(3969) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4004), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4007), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4010), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4012), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4014), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4014) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4073), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4075), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4079), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4082), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4084), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4086), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4086) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4143), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4145), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4148), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4151), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4153), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4155), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4156) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4198), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4201), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4201) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4203), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4206), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4208), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4254), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4254) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4256), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4256) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4258), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4261), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4263), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4315), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4316) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4318), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4322), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4324), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4326), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4329), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4364), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4367), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4369), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4423), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4425), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4429), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4429) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4432), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4433) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4435), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4437), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4503), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4505), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4506) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4507), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4509), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4560), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4563), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4565), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4630), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4632), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4634), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4636), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4638), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4682), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4685), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4687), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4746), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4749), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4751), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4754), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4756), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4792), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4794), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4796), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4799), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4802), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4804), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4842), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4844), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4847), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4849), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4881), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4883), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4885), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4885) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4887), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4889), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4938), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4940), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4942), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4985), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4987), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4989), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5048), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5048) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5050), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5052), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5057), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5059), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5061), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5087), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5090), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5092), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5094), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5140), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5143), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5145), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5145) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5147), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5148) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5150), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5199), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5202), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5205), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5262), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5264), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5266), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5268), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5339), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5343), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5345), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5432), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5439), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5439) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5452), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5454), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5454) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5456), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5603), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5606), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5608), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5609) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5611), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5611) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5613), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5697), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5700), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5703), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5744), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5747), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5749), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5787), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5790), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5792), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5794), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5796), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5839), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5841), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5843), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5845), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5847), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5887), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5892), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5898), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5898) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5900), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5966), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5968), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5971), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5973), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5975), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5977), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6024), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6027), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6027) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6040), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6043), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6047), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6050), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6112), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6114), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6115) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6116), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6123), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6123) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6137), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6195), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6195) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6197), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6199), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6202), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6204), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6280), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6282), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6285), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6329), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6329) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6331), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6332) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6334), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6370), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6372), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6373) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6374), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6375) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6376), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6379), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6379) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6416), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6416) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6426), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6428), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6430), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6482), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6482) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6484), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6485) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6486), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6487) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6489), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6489) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6491), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6551), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6553), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6556), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6558), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6560), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6600), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6605), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6607), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6609), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6657), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6659), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6659) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6661), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6662), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6663) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6664), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6664) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6666), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6703), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6704), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6704) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6706), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6707), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6708) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6709), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6744), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6746), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6747), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6749), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6783), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6785), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6786), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6788), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6789), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6791), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6828), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6829), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6831), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6832), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6834), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6836), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6836) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6860), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6862), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6863), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6898), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6900), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6901), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6903), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6905), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6906), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6937), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6939), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6940), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6942), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6944), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6945), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6985), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6986), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6988), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6989), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6991), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6992), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7027), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7029), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7031), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7032), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7068), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7070), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7071), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7103), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7105), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7106), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7108), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7153), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7155), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7157), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7159), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7160), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7204), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7208), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7210), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7211), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7213), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7251), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7253), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7255), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7257), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7258), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7260), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7289), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7291), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7293), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7294), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7296), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7335), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7337), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7338), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7373), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7374), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7376), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7378), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7380), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7409), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7410), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7412), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7414), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7414) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7486), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7489), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7491), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7494), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7497), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7499), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7543), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7546), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7548), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7551), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7553), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7555), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7603), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7605), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7607), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7610), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7649), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7652), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7654), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7658), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7658) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7660), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7662), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7663) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7709), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7709) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7711), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7712) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7713), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7714) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7762), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7764), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7765) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7767), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7767) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7828), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7828) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7830), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7833), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7883), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7885), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7888), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7925), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7927), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7927) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7929), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7931), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7932) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7933), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7986), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7988), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7991), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8040), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8042), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8045), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8079), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8080), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8082), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8083), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8085), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8113), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8114) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8115), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8117), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8138), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8140), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8142), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8143), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8145), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8146), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8186), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8188), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8189), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8212), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8212) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8213), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8214) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8215), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8215) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8217), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8218), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8219), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8242), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8243), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8244) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8245), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8246), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8288), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8290), new DateTime(2025, 3, 6, 7, 50, 32, 678, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2582), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2808), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2809), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2810), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2812), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2813), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 4, 15, 50, 32, 677, DateTimeKind.Local).AddTicks(7168), new DateTime(2025, 3, 6, 15, 50, 32, 677, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 15, 50, 32, 677, DateTimeKind.Local).AddTicks(7195), new DateTime(2025, 3, 6, 15, 50, 32, 677, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2580), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2591), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2625), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2625) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2788), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 31, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2823), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2831), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2872), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2873) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2880), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2972), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2997), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3003), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 31, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3008), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3013), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3053), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3058), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3070), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3076), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3139), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3146), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 21, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3152), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3159), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3164), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3165) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3203), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 21, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3209), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3209) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3259), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3264), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3270), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3275), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3280), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3313), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3318), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3330), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3362), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3367), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3373), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3379), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3420), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3426), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3468), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3475), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3480), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3516), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3522), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3523) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3528), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3573), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3580), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3587), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3630), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3636), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3641), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3647), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3653), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3683), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3691), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3696), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3702), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3751), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3758), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3758) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3791), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3796), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3802), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3808), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3854), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3863), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3868), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3874), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3916), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3922), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3927), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3933), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3938), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3939) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3983), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3988), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3995), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4040), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4046), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4052), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 3, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4058), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4106), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4113), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4120), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4126), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4132), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4133) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4170), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4185), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4191), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4226), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4232), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4237), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4243), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4244) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4279), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4297), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4306), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4344), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4350), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4356), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4401), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4402) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4407), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4413), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4465), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4470), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4475), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4481), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4486), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4526), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4533), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4534) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4540), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4546), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4582), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4588), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4594), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4611), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4617), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4653), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4659), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4665), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4671), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4672) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4724), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4730), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4736), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4771), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4776), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4781), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4824), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4829), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4866), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4871), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4915), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4920), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4925), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4930), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4958), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4963), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4968), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(4969) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5021), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5028), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5034), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5039), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5075), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5079), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5118), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5124), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5130), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5166), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5172), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5178), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5183), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5190), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5191) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5246), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5252), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5286), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5321), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5394), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5406), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5538), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5551), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5558), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5559) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5564), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5658), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5659) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5664), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5670), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5723), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5729), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5772), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5777), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5822), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5827), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5864), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5870), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5876), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5933), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5939), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5944), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5950), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5955), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5994), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6001), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6002) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6007), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6015), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6076), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6083), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6090), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6096), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6101), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6165), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6170), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6176), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6181), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6182) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6187), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6248), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6254), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6269), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6299), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6305), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6306) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6311), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6312) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6354), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6360), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6361) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6397), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6403), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6408), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6445), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6451), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6456), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6465), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6470), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6509), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6514), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6515) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6520), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6528), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6529) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6579), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6584), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6585) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6623), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6628), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6632), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 17, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6637), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6683), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6688), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6692), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6696), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6730), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6734), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6735) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6739), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6764), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6769), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6773), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6777), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6810), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6814), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6818), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6823), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6847), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6852), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6885), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6889), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6921), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6925), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6929), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6963), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6968), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6972), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6977), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7006), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7010), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7015), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7019), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 14, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7053), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7058), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7062), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7091), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7095), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7120), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7125), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7137), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7142), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 27, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7179), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7192), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7198), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7235), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7236) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7239), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7244), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7279), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7285), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7308), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7308) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7312), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7316), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7321), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7325), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7351), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7351) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7362), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7363) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7367), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7392), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7392) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 18, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7396), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7397) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7400), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7429), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7433), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7445), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7446) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7453), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7460), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7520), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7525), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7531), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7578), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7584), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7629), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7635), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7641), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7685), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7690), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7696), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 9, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7729), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7735), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7739), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7745), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7752), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7796), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7802), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7808), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7814), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 7, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7819), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7819) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7851), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 3, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7857), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 25, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7863), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7868), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7874), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7911), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7916), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7952), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7957), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7962), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7968), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7973), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8018), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8023), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8029), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8062), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8068), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8098), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8102), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8128), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8132), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8157), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8158) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8161), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8162) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 12, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8166), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8166) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8170), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 28, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8174), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8203), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8207), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8233), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8237), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8237) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8264), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8268), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8272), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 15, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8276), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8280), new DateTime(2025, 3, 6, 15, 50, 32, 678, DateTimeKind.Local).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6492), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6816), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6818), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6820), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6821), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6822), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6823), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6825), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6826), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6903), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6904), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6906), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6906) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6907), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6908), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6910), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6911), new DateTime(2025, 3, 6, 7, 50, 32, 674, DateTimeKind.Utc).AddTicks(6912) });

            migrationBuilder.CreateIndex(
                name: "IX_DormReviews_DormId1",
                table: "DormReviews",
                column: "DormId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DormReviews_Dorms_DormId1",
                table: "DormReviews",
                column: "DormId1",
                principalTable: "Dorms",
                principalColumn: "Id");
        }
    }
}
