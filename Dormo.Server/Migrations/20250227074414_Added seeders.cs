using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dormo.Server.Migrations
{
    /// <inheritdoc />
    public partial class Addedseeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "IconUrl",
                table: "Amenities");

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Tags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Amenities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(609), "", new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(686) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1097), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXdpZmkiPjxwYXRoIGQ9Ik0xMiAyMGguMDEiLz48cGF0aCBkPSJNMiA4LjgyYTE1IDE1IDAgMCAxIDIwIDAiLz48cGF0aCBkPSJNNSAxMi44NTlhMTAgMTAgMCAwIDEgMTQgMCIvPjxwYXRoIGQ9Ik04LjUgMTYuNDI5YTUgNSAwIDAgMSA3IDAiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1177), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLW5vdGVib29rIj48cGF0aCBkPSJNMiA2aDQiLz48cGF0aCBkPSJNMiAxMGg0Ii8+PHBhdGggZD0iTTIgMTRoNCIvPjxwYXRoIGQ9Ik0yIDE4aDQiLz48cmVjdCB3aWR0aD0iMTYiIGhlaWdodD0iMjAiIHg9IjQiIHk9IjIiIHJ4PSIyIi8+PHBhdGggZD0iTTE2IDJ2MjAiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1190), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXdhc2hpbmctbWFjaGluZSI+PHBhdGggZD0iTTMgNmgzIi8+PHBhdGggZD0iTTE3IDZoLjAxIi8+PHJlY3Qgd2lkdGg9IjE4IiBoZWlnaHQ9IjIwIiB4PSIzIiB5PSIyIiByeD0iMiIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iMTMiIHI9IjUiLz48cGF0aCBkPSJNMTIgMThhMi41IDIuNSAwIDAgMCAwLTUgMi41IDIuNSAwIDAgMSAwLTUiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1191), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNjdHYiPjxwYXRoIGQ9Ik0xNi43NSAxMmgzLjYzMmExIDEgMCAwIDEgLjg5NCAxLjQ0N2wtMi4wMzQgNC4wNjlhMSAxIDAgMCAxLTEuNzA4LjEzNGwtMi4xMjQtMi45NyIvPjxwYXRoIGQ9Ik0xNy4xMDYgOS4wNTNhMSAxIDAgMCAxIC40NDcgMS4zNDFsLTMuMTA2IDYuMjExYTEgMSAwIDAgMS0xLjM0Mi40NDdMMy42MSAxMi4zYTIuOTIgMi45MiAwIDAgMS0xLjMtMy45MUwzLjY5IDUuNmEyLjkyIDIuOTIgMCAwIDEgMy45Mi0xLjN6Ii8+PHBhdGggZD0iTTIgMTloMy43NmEyIDIgMCAwIDAgMS44LTEuMUw5IDE1Ii8+PHBhdGggZD0iTTIgMjF2LTQiLz48cGF0aCBkPSJNNyA5aC4wMSIvPjwvc3ZnPg==", new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1193), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWFybWNoYWlyIj48cGF0aCBkPSJNMTkgOVY2YTIgMiAwIDAgMC0yLTJIN2EyIDIgMCAwIDAtMiAydjMiLz48cGF0aCBkPSJNMyAxNmEyIDIgMCAwIDAgMiAyaDE0YTIgMiAwIDAgMCAyLTJ2LTVhMiAyIDAgMCAwLTQgMHYxLjVhLjUuNSAwIDAgMS0uNS41aC05YS41LjUgMCAwIDEtLjUtLjVWMTFhMiAyIDAgMCAwLTQgMHoiLz48cGF0aCBkPSJNNSAxOHYyIi8+PHBhdGggZD0iTTE5IDE4djIiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1194), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNvb2tpbmctcG90Ij48cGF0aCBkPSJNMiAxMmgyMCIvPjxwYXRoIGQ9Ik0yMCAxMnY4YTIgMiAwIDAgMS0yIDJINmEyIDIgMCAwIDEtMi0ydi04Ii8+PHBhdGggZD0ibTQgOCAxNi00Ii8+PHBhdGggZD0ibTguODYgNi43OC0uNDUtMS44MWEyIDIgMCAwIDEgMS40NS0yLjQzbDEuOTQtLjQ4YTIgMiAwIDAgMSAyLjQzIDEuNDZsLjQ1IDEuOCIvPjwvc3ZnPg==", new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1196), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNpcmNsZS1wYXJraW5nIj48Y2lyY2xlIGN4PSIxMiIgY3k9IjEyIiByPSIxMCIvPjxwYXRoIGQ9Ik05IDE3VjdoNGEzIDMgMCAwIDEgMCA2SDkiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 7, 44, 12, 736, DateTimeKind.Utc).AddTicks(1196) });

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
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4965), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXNjaG9vbCI+PHBhdGggZD0iTTE0IDIydi00YTIgMiAwIDEgMC00IDB2NCIvPjxwYXRoIGQ9Im0xOCAxMCAzLjQ0NyAxLjcyNGExIDEgMCAwIDEgLjU1My44OTRWMjBhMiAyIDAgMCAxLTIgMkg0YTIgMiAwIDAgMS0yLTJ2LTcuMzgyYTEgMSAwIDAgMSAuNTUzLS44OTRMNiAxMCIvPjxwYXRoIGQ9Ik0xOCA1djE3Ii8+PHBhdGggZD0ibTQgNiA3LjEwNi0zLjU1M2EyIDIgMCAwIDEgMS43ODggMEwyMCA2Ii8+PHBhdGggZD0iTTYgNXYxNyIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iOSIgcj0iMiIvPjwvc3ZnPg==", new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5229), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNhdCI+PHBhdGggZD0iTTEyIDVjLjY3IDAgMS4zNS4wOSAyIC4yNiAxLjc4LTIgNS4wMy0yLjg0IDYuNDItMi4yNiAxLjQuNTgtLjQyIDctLjQyIDcgLjU3IDEuMDcgMSAyLjI0IDEgMy40NEMyMSAxNy45IDE2Ljk3IDIxIDEyIDIxcy05LTMtOS03LjU2YzAtMS4yNS41LTIuNCAxLTMuNDQgMCAwLTEuODktNi40Mi0uNS03IDEuMzktLjU4IDQuNzIuMjMgNi41IDIuMjNBOS4wNCA5LjA0IDAgMCAxIDEyIDVaIi8+PHBhdGggZD0iTTggMTR2LjUiLz48cGF0aCBkPSJNMTYgMTR2LjUiLz48cGF0aCBkPSJNMTEuMjUgMTYuMjVoMS41TDEyIDE3bC0uNzUtLjc1WiIvPjwvc3ZnPg==", new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5231), "data:image/svg +xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXZlbnVzIj48cGF0aCBkPSJNMTIgMTV2NyIvPjxwYXRoIGQ9Ik05IDE5aDYiLz48Y2lyY2xlIGN4PSIxMiIgY3k9IjkiIHI9IjYiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5232), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLW1hcnMiPjxwYXRoIGQ9Ik0xNiAzaDV2NSIvPjxwYXRoIGQ9Im0yMSAzLTYuNzUgNi43NSIvPjxjaXJjbGUgY3g9IjEwIiBjeT0iMTQiIHI9IjYiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5234), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWdyYWR1YXRpb24tY2FwIj48cGF0aCBkPSJNMjEuNDIgMTAuOTIyYTEgMSAwIDAgMC0uMDE5LTEuODM4TDEyLjgzIDUuMThhMiAyIDAgMCAwLTEuNjYgMEwyLjYgOS4wOGExIDEgMCAwIDAgMCAxLjgzMmw4LjU3IDMuOTA4YTIgMiAwIDAgMCAxLjY2IDB6Ii8+PHBhdGggZD0iTTIyIDEwdjYiLz48cGF0aCBkPSJNNiAxMi41VjE2YTYgMyAwIDAgMCAxMiAwdi0zLjUiLz48L3N2Zz4=", new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5235), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLW1hcC1waW4tcGx1cyI+PHBhdGggZD0iTTE5LjkxNCAxMS4xMDVBNy4yOTggNy4yOTggMCAwIDAgMjAgMTBhOCA4IDAgMCAwLTE2IDBjMCA0Ljk5MyA1LjUzOSAxMC4xOTMgNy4zOTkgMTEuNzk5YTEgMSAwIDAgMCAxLjIwMiAwIDMyIDMyIDAgMCAwIC44MjQtLjczOCIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iMTAiIHI9IjMiLz48cGF0aCBkPSJNMTYgMThoNiIvPjxwYXRoIGQ9Ik0xOSAxNXY2Ii8+PC9zdmc+", new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5237), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXBoaWxpcHBpbmUtcGVzbyI+PHBhdGggZD0iTTIwIDExSDQiLz48cGF0aCBkPSJNMjAgN0g0Ii8+PHBhdGggZD0iTTcgMjFWNGExIDEgMCAwIDEgMS0xaDRhMSAxIDAgMCAxIDAgMTJINyIvPjwvc3ZnPg==", new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Icon", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5238), "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWdlbSI+PHBhdGggZD0iTTYgM2gxMmw0IDYtMTAgMTNMMiA5WiIvPjxwYXRoIGQ9Ik0xMSAzIDggOWw0IDEzIDQtMTMtMy02Ii8+PHBhdGggZD0iTTIgOWgyMCIvPjwvc3ZnPg==", new DateTime(2025, 2, 27, 7, 44, 12, 737, DateTimeKind.Utc).AddTicks(5238) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Amenities");

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Tags",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IconUrl",
                table: "Amenities",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 961, DateTimeKind.Utc).AddTicks(9788), null, new DateTime(2025, 2, 27, 6, 35, 26, 961, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(238), null, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(240), null, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(241), null, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(243), null, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(244), null, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(245), null, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "Amenities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(246), null, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(246) });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "44d8f9db-6bbe-4897-91f8-9edc8d3064e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3bca67ff-ff20-4969-b7df-6a6e40058e6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "962b5b44-dd1b-408d-a170-b348294208b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "13f4f3f7-0b01-4c7b-98c7-7286e14258d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "8dbee69b-15ac-41b6-b7dd-15c0514bfc1a", new DateTime(2025, 2, 27, 6, 35, 27, 202, DateTimeKind.Utc).AddTicks(4443), "AQAAAAIAAYagAAAAEH/gHBqhLiSsfhoC12TWzwqdxnyJ8ddKryHXUwzEq7r/reQfqTW5n52/aaODeNZrwQ==", "20ce7cc1-bb50-445a-ac69-41c74573f57c", new DateTime(2025, 2, 27, 6, 35, 27, 202, DateTimeKind.Utc).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb5",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "3bdf0d9b-7494-4710-af67-c5ab99f34d41", new DateTime(2025, 2, 27, 6, 35, 27, 159, DateTimeKind.Utc).AddTicks(8637), "AQAAAAIAAYagAAAAEF/jIQX5Dd9sX9/Opu9g69Ir+jPjqNBqPg5E5XDuGairumvmnL9xa91uqg/9G0pGFA==", "6eee067b-7959-4c14-82b4-e1a831b978bc", new DateTime(2025, 2, 27, 6, 35, 27, 159, DateTimeKind.Utc).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "e2a56183-5bdc-443b-b901-12f6e012850f", new DateTime(2025, 2, 27, 6, 35, 27, 116, DateTimeKind.Utc).AddTicks(6308), "AQAAAAIAAYagAAAAEOn9WCeU/P8uuN/uMJy4fheOWA0/ELQIM00a2AtGYqhmSLEvL6zyF94OcXJpFElMjA==", "a03337c2-ebcb-44ce-979b-d41b721382ab", new DateTime(2025, 2, 27, 6, 35, 27, 116, DateTimeKind.Utc).AddTicks(6314) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb7",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "f6fbeac1-3d9d-431c-8552-753f050441a1", new DateTime(2025, 2, 27, 6, 35, 27, 68, DateTimeKind.Utc).AddTicks(3424), "AQAAAAIAAYagAAAAEHaRdfHSXOhMy6NpTwKMw7ciWLPh1AVOtRBr/5SdKTecXk1JuMiQjpnudsjpBRVm0w==", "290498c5-463d-4092-a233-e47d5d794904", new DateTime(2025, 2, 27, 6, 35, 27, 68, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb8",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "90603680-bbdd-458d-b1f0-b16e3c8ba00a", new DateTime(2025, 2, 27, 6, 35, 27, 16, DateTimeKind.Utc).AddTicks(7158), "AQAAAAIAAYagAAAAEFbITBoGsmu3X+5tEFDkh+zQlTM2jvRGM5yZlvI/zGqtmP3qVKMEl6uuSeLccLM0gQ==", "c69f1e13-d589-4de7-8b5d-fe1f03349a03", new DateTime(2025, 2, 27, 6, 35, 27, 16, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp", "UpdatedAt" },
                values: new object[] { "bb166ca4-8ebb-4161-be3c-3528e4a6036e", new DateTime(2025, 2, 27, 6, 35, 26, 966, DateTimeKind.Utc).AddTicks(1513), "AQAAAAIAAYagAAAAECV3kxIUtZ1NvzfFxXkxYuI6GPBTRc7P4aa7dFrmdp5bllbBBLz966V6rWWd3Y5P0w==", "e520ac5b-de3b-4c91-bb24-ad611d3502b9", new DateTime(2025, 2, 27, 6, 35, 26, 966, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(72), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(568), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(570), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(572), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(574), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(576), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(576) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(578), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(578) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(579), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(584), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(586), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(588), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(590), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(592), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(594), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(596), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(598), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(599), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 14, 35, 27, 253, DateTimeKind.Local).AddTicks(9593), new DateTime(2025, 2, 27, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1932), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2049), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2049) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2088), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2145), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2219), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2289), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2340), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2421), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2478), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2510), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2553), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2597), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2642), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2687), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2687) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2725), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2777), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2847), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2888), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2936), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2999), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3046), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3087), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3131), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3132) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3164), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3215), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3270), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3336), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3405), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3487), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3539), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3572), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3618), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3668), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3701), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3745), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3797), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3797) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3843), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3898), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3951), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3994), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4044), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4083), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4116), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4156), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4190), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4217), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4218) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4259), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4299), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4338), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4389), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4450), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4502), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4555), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4601), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4650), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4694), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4735), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4775), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4817), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4860), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4902), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4903) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4940), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4980), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5014), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5060), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5086), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5123), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5166), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5206), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5245), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5272), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5299), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5337), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5378), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5410), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5442), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5443) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5483), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5512), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5513) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5547), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5548) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5576), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5605), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5643), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5685), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5685) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5718), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5767), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5798), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5831), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5871), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5910), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5942), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5977), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6016), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6050), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6080), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6108), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6136), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6178), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6205), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                table: "Dorms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6242), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1257), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1504), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1506), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1507), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1508), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "Habits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1509), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1416), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1861), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1875), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2004), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2006), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2009), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2011), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2013), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2076), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2078), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2080), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2132), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2134), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2136), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2137), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2195), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2197), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2201), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2204), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2208), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2210), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2261), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2264), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2266), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2269), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2271), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2322), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2324), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2328), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2330), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2388), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2388) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2390), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2393), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2406), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2409), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2411), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2460), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2462), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2466), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2468), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2470), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2494), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2496), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2502), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2538), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2540), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2542), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2543), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2545), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2546), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2582), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2583), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2585), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2587), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2588), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2590), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2629), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2631), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2632), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2634), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2636), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2671), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2673), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2673) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2674), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2675) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2676), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2713), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2715), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2717), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2718), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2755), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2758), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2761), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2761) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2764), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2767), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2820), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2823), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2823) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2825), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2826) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2828), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2830), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2838), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2838) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2872), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2874), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2876), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2878), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2923), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2925), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2927), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2976), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2978), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2981), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2983), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2986), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2988), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3028), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3030), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3032), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3033), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3033) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3035), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3075), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3077), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3078), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3080), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3118), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3119), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3121), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3123), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3124), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3151), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3152), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3154), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3155), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3157), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3200), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3201), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3203), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3204), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3206), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3254), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3257), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3260), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3262), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3316), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3319), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3322), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3324), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3326), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3375), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3377), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3387), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3389), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3392), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3395), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3453), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3456), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3459), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3461), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3463), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3467), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3526), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3527), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3529), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3531), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3532), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3559), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3560), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3562), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3563), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3565), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3605), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3607), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3608), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3610), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3611), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3652), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3654), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3655), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3657), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3659), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3661), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3690), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3692), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3693), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3695), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3733), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3735), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3736), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3738), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3783), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3785), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3786) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3788), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3825), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3828), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3828) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3831), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3834), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3876), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3878), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3880), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3882), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3886), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3888), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3925), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3927), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3930), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3933), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3936), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3939), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3980), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3982), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3982) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3984), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4029), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4031), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4034), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4034) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4035), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4036) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4037), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4068), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4070), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4071), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4073), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4075), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4076), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4106), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4108), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4108) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4109), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4139), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4140), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4142), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4144), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4144) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4145), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4146) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4179), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4179) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4180), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4182), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4183), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4208), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4209), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4211), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4248), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4248) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4249), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4251), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4252), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4286), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4288), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4289), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4291), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4292), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4321), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4323), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4324), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4328), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4369), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4371), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4374), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4376), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4378), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4380), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4432), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4432) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4435), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4435) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4438), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4440), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4442), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4486), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4486) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4489), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4491), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4494), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4535), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4537), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4539), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4542), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4542) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4544), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4544) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4546), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4584), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4586), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4588), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4590), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4592), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4634), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4637), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4639), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4640), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4642), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4644), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4681), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4683), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4685), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4686), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4688), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4720), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4722), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4723), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4723) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4725), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4725) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4726), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4728), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4762), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4764), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4765), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4767), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4769), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4803), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4804) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4805), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4806), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4808), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4809), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4811), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4846), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4847), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4849), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4850), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4852), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4854), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4884), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4885), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4886) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4887), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4888), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4890), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4892), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4928), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4929), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4931), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4933), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4934), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4935) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4964), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4966), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4966) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4971), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4973) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5004), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5006), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5007), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5049), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5051), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5051) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5052), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5054), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5054) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5075), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5076), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5078), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5079), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5110), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5112), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5114), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5114) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5116), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5117), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5147), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5149), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5150), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5152), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5158), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5160), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5194), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5196), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5197), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5199), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5200), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5229), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5234), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5237), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5239), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5261), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5263), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5265), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5266), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5287), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5289), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5290), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5291) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5292), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5293), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5326), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5328), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5329), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5331), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5358), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5365), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5366), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5368), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5369) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5370), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5372), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5372) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5396), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5398), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5398) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5399), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5401), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5401) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5402), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5403) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5404), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5429), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5430), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5435), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5471), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5472), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5474), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5474) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5476), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5476) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5477), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5498), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5499), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5501), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5536), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5538), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5538) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5540), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5541), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5564), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5565), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5567), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5568), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5570), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5593), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5595), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5597), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5598), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5632), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5634), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5636), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5637), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5637) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5670), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5672), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5673), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5675), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5676), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5678), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5709), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5711), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5713), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5752), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5754), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5756), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5758), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5759), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5761), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5787), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5789), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5790), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5792), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5823), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5824), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5826), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5858), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5860), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5861), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5863), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5864), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5900), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5902), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5903), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5929), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5931), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5932), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5934), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5936), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5966), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5968), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5969), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5971), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6005), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6006), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6008), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6010), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6039), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6041), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6043), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6043) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6044), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6065), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6070), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6072), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6073) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6074), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6096), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6097), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6099), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6100), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6102), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6102) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6127), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6129), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6130), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6166), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6168), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6168) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6170), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6171), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6173), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6192), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6193), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6195), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6197), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6199), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6227), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6227) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6229), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6231), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6231) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6232), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6234), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6236), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6264), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6265) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6266), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6268), new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6268) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1837), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1987), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1989), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1990), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1991), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "Interests",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1992), new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9769), new DateTime(2025, 2, 27, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9787) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 6, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9844), new DateTime(2025, 2, 27, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9851), new DateTime(2025, 2, 27, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1948), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1953), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1962), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1967), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1975), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2054), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2059), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2093), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2097), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2102), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2106), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2110), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2151), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2156), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2165), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2178), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2185), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2225), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2231), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2238), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2243), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2250), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2296), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2303), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2311), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2346), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2353), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2360), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2371), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2377), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2429), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2435), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2442), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2449), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2482), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2486), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2515), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2520), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2524), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2528), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2558), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2562), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2567), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2571), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2601), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2606), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2610), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2614), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2647), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2651), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2655), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2664), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2692), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2696), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2700), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2704), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2708), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2735), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2742), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2790), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2797), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2798) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2803), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2812), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2813) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2854), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2861), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2895), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2895) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2901), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2907), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2914), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2914) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2954), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2960), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2967), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3004), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3005) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3008), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3012), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3017), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3017) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3050), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3054), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3055) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3058), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3063), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3067), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3091), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3096), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3100), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3104), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3135), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3140), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3144), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3168), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3172), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3176), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3181), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3185), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3220), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3226), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3233), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3240), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3247), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3277), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3282), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3290), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3301), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3307), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3343), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3349), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3355), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3362), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3412), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3419), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3427), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3434), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3435) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3441), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3442) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3492), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3493) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3497), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3502), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3511), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3512) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3515), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3543), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3548), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3552), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3577), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3581), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3590), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3594), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3598), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3623), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3628), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3633), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3637), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3641), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3672), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3677), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3681), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3685), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3706), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3710), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3714), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3718), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3727), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3727) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3750), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3754), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3756) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3763), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3769), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3803), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3804) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3810), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3849), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3856), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3863), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3905), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3905) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3910), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3958), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3958) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3964), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3970), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3999), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4003), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4004) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4008), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4012), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4016), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4017) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4049), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4049) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4053), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4057), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4061), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4087), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4088) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4092), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4121), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4125), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4129), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4161), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4165), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4169), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4174), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4194), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4195) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4198), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4202), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4222), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4226), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4233), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4238), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4242), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4263), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4264) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4268), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4272), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4276), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4280), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4303), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4313), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4345), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4352), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4358), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4359) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4397), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4398) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4404), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4410), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4411) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4422), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4457), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4457) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4463), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4464) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4469), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4476), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4510), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4516), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4563), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4569), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4607), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4611), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4616), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4620), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4655), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4659), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4663), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4667), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4675), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4699), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4704), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4704) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4708), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4712), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4739), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4743), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4752), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4756), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4780), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4784), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4788), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4792), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4796), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4826), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4830), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4835), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4838), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4865), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4869), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4874), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4878), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4906), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4911), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4915), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4919), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4923), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4945), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4949), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4953), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4957), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4984), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4989), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4993), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4997), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5020), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5024), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5029), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5033), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5037), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5064), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5068), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5090), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5095), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5099), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5127), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5132), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5136), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5140), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5171), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5174), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5179), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5183), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5187), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5210), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5214), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5218), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5222), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5250), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5255), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5276), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5281), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5309), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5313), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5317), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5321), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5341), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5346), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5350), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5382), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5387), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5391), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5391) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5414), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5415) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5419), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5419) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5423), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5447), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5451), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5456), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5456) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5460), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5464), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5464) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5488), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5492), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5517), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5521), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5522) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5525), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5529), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5551), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5556), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5580), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5581) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5588), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5610), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5614), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5615) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5618), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5622), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5626), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5648), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5649) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5652), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5657), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5657) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5690), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5691) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5695), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5699), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5703), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5703) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5723), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5727), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 2, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5731), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5735), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5744), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5745) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5771), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5775), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5776) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5780), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5803), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5807), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5816), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5836), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5840), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5844), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5849), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5875), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5880), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5884), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5891), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 1, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5914), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5918), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5947), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5951), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5955), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5959), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5981), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5986), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5990), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5994), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6020), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6025), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6029), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6033), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6054), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6058), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6085), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6086) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6089), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6112), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6116), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6120), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6121) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 6, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6148), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6152), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6153) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 4, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6157), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6160), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6183), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6187), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 11, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6209), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6214), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 5, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6247), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 12, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6251), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6255), new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6256) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2247), null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2580), null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2594), null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2596), null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2597), null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2598), null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2599), null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "IconUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2601), null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2601) });
        }
    }
}
