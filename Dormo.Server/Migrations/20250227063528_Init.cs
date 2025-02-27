using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dormo.Server.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PreferredFirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactInfo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Dob = table.Column<DateOnly>(type: "date", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(10,7)", nullable: true),
                    Longitude = table.Column<decimal>(type: "decimal(10,7)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    EmailSubscription = table.Column<bool>(type: "bit", nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Habits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DormmatePreferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PrefersSameGender = table.Column<bool>(type: "bit", nullable: false),
                    PrefersQuietEnvironment = table.Column<bool>(type: "bit", nullable: false),
                    PreferredSleepTime = table.Column<int>(type: "int", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DormmatePreferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DormmatePreferences_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dorms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    AmenityId = table.Column<int>(type: "int", nullable: true),
                    TagId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dorms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dorms_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dorms_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dorms_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dorms_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DormmatePreferenceHabits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreferenceId = table.Column<int>(type: "int", nullable: false),
                    HabitId = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DormmatePreferenceHabits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DormmatePreferenceHabits_DormmatePreferences_PreferenceId",
                        column: x => x.PreferenceId,
                        principalTable: "DormmatePreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DormmatePreferenceHabits_Habits_HabitId",
                        column: x => x.HabitId,
                        principalTable: "Habits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DormmatePreferenceInterests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreferenceId = table.Column<int>(type: "int", nullable: false),
                    InterestId = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DormmatePreferenceInterests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DormmatePreferenceInterests_DormmatePreferences_PreferenceId",
                        column: x => x.PreferenceId,
                        principalTable: "DormmatePreferences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DormmatePreferenceInterests_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DormAmenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DormId = table.Column<int>(type: "int", nullable: false),
                    AmenityId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DormAmenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DormAmenities_Amenities_AmenityId",
                        column: x => x.AmenityId,
                        principalTable: "Amenities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DormAmenities_Dorms_DormId",
                        column: x => x.DormId,
                        principalTable: "Dorms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DormReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DormId = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    ReviewText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DormReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DormReviews_AspNetUsers_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DormReviews_Dorms_DormId",
                        column: x => x.DormId,
                        principalTable: "Dorms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DormTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DormId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DormTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DormTags_Dorms_DormId",
                        column: x => x.DormId,
                        principalTable: "Dorms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DormTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DormId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Dorms_DormId",
                        column: x => x.DormId,
                        principalTable: "Dorms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DormId = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    PricePerMonth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Dorms_DormId",
                        column: x => x.DormId,
                        principalTable: "Dorms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    MoveInDate = table.Column<DateOnly>(type: "date", nullable: false),
                    MoveOutDate = table.Column<DateOnly>(type: "date", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BookedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Schedule = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ScheduledAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visits_AspNetUsers_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Visits_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IconUrl", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 27, 6, 35, 26, 961, DateTimeKind.Utc).AddTicks(9788), null, "Cooling system for comfortable room temperature", null, true, false, "Air Conditioning", new DateTime(2025, 2, 27, 6, 35, 26, 961, DateTimeKind.Utc).AddTicks(9872) },
                    { 2, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(238), null, "High-speed wireless internet connection", null, true, false, "Wi-Fi", new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(239) },
                    { 3, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(240), null, "Dedicated space for studying", null, true, false, "Study Area", new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(240) },
                    { 4, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(241), null, "On-site laundry facilities", null, true, false, "Laundry", new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(242) },
                    { 5, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(243), null, "24/7 security personnel and CCTV", null, true, false, "Security", new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(243) },
                    { 6, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(244), null, "Shared space for socializing", null, true, false, "Common Room", new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(244) },
                    { 7, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(245), null, "Shared cooking facilities", null, true, false, "Kitchen", new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(245) },
                    { 8, new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(246), null, "Secure parking space", null, true, false, "Parking", new DateTime(2025, 2, 27, 6, 35, 26, 962, DateTimeKind.Utc).AddTicks(246) }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "44d8f9db-6bbe-4897-91f8-9edc8d3064e8", "Admin", "ADMIN" },
                    { "2", "3bca67ff-ff20-4969-b7df-6a6e40058e6c", "Owner", "OWNER" },
                    { "3", "962b5b44-dd1b-408d-a170-b348294208b0", "Member", "MEMBER" },
                    { "4", "13f4f3f7-0b01-4c7b-98c7-7286e14258d5", "Tenant", "TENANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactInfo", "CreatedAt", "Dob", "Email", "EmailConfirmed", "EmailSubscription", "FirstName", "IsActive", "IsDeleted", "IsVerified", "LastName", "Latitude", "LockoutEnabled", "LockoutEnd", "Longitude", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferredFirstName", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb0", 0, "8dbee69b-15ac-41b6-b7dd-15c0514bfc1a", null, new DateTime(2025, 2, 27, 6, 35, 27, 202, DateTimeKind.Utc).AddTicks(4443), new DateOnly(1, 1, 1), "admin@dormo.com", true, false, "System", true, false, false, "Administrator", null, false, null, null, "ADMIN@DORMO.COM", "ADMIN@DORMO.COM", "AQAAAAIAAYagAAAAEH/gHBqhLiSsfhoC12TWzwqdxnyJ8ddKryHXUwzEq7r/reQfqTW5n52/aaODeNZrwQ==", "+639190000000", true, null, null, "20ce7cc1-bb50-445a-ac69-41c74573f57c", false, new DateTime(2025, 2, 27, 6, 35, 27, 202, DateTimeKind.Utc).AddTicks(4449), "admin@dormo.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb5", 0, "3bdf0d9b-7494-4710-af67-c5ab99f34d41", null, new DateTime(2025, 2, 27, 6, 35, 27, 159, DateTimeKind.Utc).AddTicks(8637), new DateOnly(1, 1, 1), "housing@university.edu", true, false, "University", true, false, false, "Housing", null, false, null, null, "HOUSING@UNIVERSITY.EDU", "HOUSING@UNIVERSITY.EDU", "AQAAAAIAAYagAAAAEF/jIQX5Dd9sX9/Opu9g69Ir+jPjqNBqPg5E5XDuGairumvmnL9xa91uqg/9G0pGFA==", "+639211234567", true, null, null, "6eee067b-7959-4c14-82b4-e1a831b978bc", false, new DateTime(2025, 2, 27, 6, 35, 27, 159, DateTimeKind.Utc).AddTicks(8649), "housing@university.edu" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb6", 0, "e2a56183-5bdc-443b-b901-12f6e012850f", null, new DateTime(2025, 2, 27, 6, 35, 27, 116, DateTimeKind.Utc).AddTicks(6308), new DateOnly(1, 1, 1), "antonio.reyes@example.com", true, false, "Antonio", true, false, false, "Reyes", null, false, null, null, "ANTONIO.REYES@EXAMPLE.COM", "ANTONIO.REYES@EXAMPLE.COM", "AQAAAAIAAYagAAAAEOn9WCeU/P8uuN/uMJy4fheOWA0/ELQIM00a2AtGYqhmSLEvL6zyF94OcXJpFElMjA==", "+639207654321", true, null, null, "a03337c2-ebcb-44ce-979b-d41b721382ab", false, new DateTime(2025, 2, 27, 6, 35, 27, 116, DateTimeKind.Utc).AddTicks(6314), "antonio.reyes@example.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, "f6fbeac1-3d9d-431c-8552-753f050441a1", null, new DateTime(2025, 2, 27, 6, 35, 27, 68, DateTimeKind.Utc).AddTicks(3424), new DateOnly(1, 1, 1), "megadevelopers@example.com", true, false, "Mega", true, false, false, "Developers", null, false, null, null, "MEGADEVELOPERS@EXAMPLE.COM", "MEGADEVELOPERS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHaRdfHSXOhMy6NpTwKMw7ciWLPh1AVOtRBr/5SdKTecXk1JuMiQjpnudsjpBRVm0w==", "+639191234567", true, null, null, "290498c5-463d-4092-a233-e47d5d794904", false, new DateTime(2025, 2, 27, 6, 35, 27, 68, DateTimeKind.Utc).AddTicks(3431), "megadevelopers@example.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, "90603680-bbdd-458d-b1f0-b16e3c8ba00a", null, new DateTime(2025, 2, 27, 6, 35, 27, 16, DateTimeKind.Utc).AddTicks(7158), new DateOnly(1, 1, 1), "maria.santos@example.com", true, false, "Maria", true, false, false, "Santos", null, false, null, null, "MARIA.SANTOS@EXAMPLE.COM", "MARIA.SANTOS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFbITBoGsmu3X+5tEFDkh+zQlTM2jvRGM5yZlvI/zGqtmP3qVKMEl6uuSeLccLM0gQ==", "+639187654321", true, null, null, "c69f1e13-d589-4de7-8b5d-fe1f03349a03", false, new DateTime(2025, 2, 27, 6, 35, 27, 16, DateTimeKind.Utc).AddTicks(7162), "maria.santos@example.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "bb166ca4-8ebb-4161-be3c-3528e4a6036e", null, new DateTime(2025, 2, 27, 6, 35, 26, 966, DateTimeKind.Utc).AddTicks(1513), new DateOnly(1, 1, 1), "pmcrealty@example.com", true, false, "PMC", true, false, false, "Realty", null, false, null, null, "PMCREALTY@EXAMPLE.COM", "PMCREALTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAECV3kxIUtZ1NvzfFxXkxYuI6GPBTRc7P4aa7dFrmdp5bllbBBLz966V6rWWd3Y5P0w==", "+639171234567", true, null, null, "e520ac5b-de3b-4c91-bb24-ad611d3502b9", false, new DateTime(2025, 2, 27, 6, 35, 26, 966, DateTimeKind.Utc).AddTicks(1517), "pmcrealty@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Icon", "IsActive", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(72), null, "Single room accommodation", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlIj48cGF0aCBkPSJNMTUgMjF2LThhMSAxIDAgMCAwLTEtMWgtNGExIDEgMCAwIDAtMSAxdjgiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PC9zdmc+", true, false, "Studio Type", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(73) },
                    { 2, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(568), null, "Multiple room accommodation", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXJzIj48cGF0aCBkPSJNMTYgMjF2LTJhNCA0IDAgMCAwLTQtNEg2YTQgNCAwIDAgMC00IDR2MiIvPjxjaXJjbGUgY3g9IjkiIGN5PSI3IiByPSI0Ii8+PHBhdGggZD0iTTIyIDIxdi0yYTQgNCAwIDAgMC0zLTMuODciLz48cGF0aCBkPSJNMTYgMy4xM2E0IDQgMCAwIDEgMCA3Ljc1Ii8+PC9zdmc+", true, false, "Apartment Type", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(568) },
                    { 8, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(578), null, "Dorms near schools or universities", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVuaXZlcnNpdHkiPjxjaXJjbGUgY3g9IjEyIiBjeT0iMTAiIHI9IjEiLz48cGF0aCBkPSJNMjIgMjBWOGgtNGwtNi00LTYgNEgydjEyYTIgMiAwIDAgMCAyIDJoMTZhMiAyIDAgMCAwIDItMiIvPjxwYXRoIGQ9Ik02IDE3di4wMSIvPjxwYXRoIGQ9Ik02IDEzdi4wMSIvPjxwYXRoIGQ9Ik0xOCAxN3YuMDEiLz48cGF0aCBkPSJNMTggMTN2LjAxIi8+PHBhdGggZD0iTTE0IDIydi01YTIgMiAwIDAgMC0yLTJhMiAyIDAgMCAwLTIgMnY1Ii8+PC9zdmc+", true, false, "Near Schools/Uni", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(578) },
                    { 9, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(579), null, "Dorms located in the city", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik02IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=", true, false, "City Dorms", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(580) },
                    { 10, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(581), null, "Dorms located in suburban areas", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik02IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=", true, false, "Suburban Dorms", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(582) },
                    { 11, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(584), null, "Dorms connected to campuses", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXNjaG9vbCI+PHBhdGggZD0iTTE0IDIydi00YTIgMiAwIDEgMC00IDB2NCIvPjxwYXRoIGQ9Im0xOCAxMCAzLjQ0NyAxLjcyNGExIDEgMCAwIDEgLjU1My44OTRWMjBhMiAyIDAgMCAxLTIgMkg0YTIgMiAwIDAgMS0yLTJ2LTcuMzgyYTEgMSAwIDAgMSAuNTUzLS44OTRMNiAxMCIvPjxwYXRoIGQ9Ik0xOCA1djE3Ii8+PHBhdGggZD0ibTQgNiA3LjEwNi0zLjU1M2EyIDIgMCAwIDEgMS43ODggMEwyMCA2Ii8+PHBhdGggZD0iTTYgNXYxNyIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iOSIgcj0iMiIvPjwvc3ZnPg==", true, false, "Campus-Connected", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(585) },
                    { 12, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(586), null, "Dorms offering bed spaces", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJlZCI+PHBhdGggZD0iTTIgNHYxNiIvPjxwYXRoIGQ9Ik0yIDhoMThhMiAyIDAgMCAxIDIgMnYxMCIvPjxwYXRoIGQ9Ik0yIDE3aDIwIi8+PHBhdGggZD0iTTYgOHY5Ii8+PC9zdmc+", true, false, "Bed Spaces", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(587) },
                    { 13, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(588), null, "Dorms offering private rooms", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXIiPjxwYXRoIGQ9Ik0xOSAyMXYtMmE0IDQgMCAwIDAtNC00SDlhNCA0IDAgMCAwLTQgNHYyIi8+PGNpcmNsZSBjeD0iMTIiIGN5PSI3IiByPSI0Ii8+PC9zdmc+", true, false, "Private Room", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(589) },
                    { 14, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(590), null, "Dorms offering co-living spaces", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXJzIj48cGF0aCBkPSJNMTYgMjF2LTJhNCA0IDAgMCAwLTQtNEg2YTQgNCAwIDAgMC00IDR2MiIvPjxjaXJjbGUgY3g9IjkiIGN5PSI3IiByPSI0Ii8+PHBhdGggZD0iTTIyIDIxdi0yYTQgNCAwIDAgMC0zLTMuODciLz48cGF0aCBkPSJNMTYgMy4xM2E0IDQgMCAwIDEgMCA3Ljc1Ii8+PC9zdmc+", true, false, "Co-Living Spaces", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(590) },
                    { 17, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(592), null, "Dorms with condominium-style accommodations", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik02IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=", true, false, "Condo Dorms", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(592) },
                    { 18, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(594), null, "Dorms with review centers", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJvb2stb3Blbi10ZXh0Ij48cGF0aCBkPSJNMTIgN3YxNCIvPjxwYXRoIGQ9Ik0xNiAxMmgyIi8+PHBhdGggZD0iTTE2IDhoMiIvPjxwYXRoIGQ9Ik0zIDE4YTEgMSAwIDAgMS0xLTFWNGExIDEgMCAwIDEgMS0xaDVhNCA0IDAgMCAxIDQgNCA0IDQgMCAwIDEgNC00aDVhMSAxIDAgMCAxIDEgMXYxM2ExIDEgMCAwIDEtMSAxaC02YTMgMyAwIDAgMC0zIDMgMyAzIDAgMCAwLTMtM3oiLz48cGF0aCBkPSJNNiAxMmgyIi8+PHBhdGggZD0iTTYgOGgyIi8+PC9zdmc+", true, false, "Review Centers & Dorms", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(594) },
                    { 19, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(596), null, "Boarding houses", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlIj48cGF0aCBkPSJNMTUgMjF2LThhMSAxIDAgMCAwLTEtMWgtNGExIDEgMCAwIDAtMSAxdjgiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PC9zdmc+", true, false, "Boarding Houses", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(596) },
                    { 20, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(598), null, "Dorms for short term stays", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXJnbGFzcyI+PHBhdGggZD0iTTUgMjJoMTQiLz48cGF0aCBkPSJNNSAyaDE0Ii8+PHBhdGggZD0iTTE3IDIydi00LjE3MmEyIDIgMCAwIDAtLjU4Ni0xLjQxNEwxMiAxMmwtNC40MTQgNC40MTRBMiAyIDAgMCAwIDcgMTcuODI4VjIyIi8+PHBhdGggZD0iTTcgMnY0LjE3MmEyIDIgMCAwIDAgLjU4NiAxLjQxNEwxMiAxMmw0LjQxNC00LjQxNEEyIDIgMCAwIDAgMTcgNi4xNzJWMiIvPjwvc3ZnPg==", true, false, "Short Term Stays", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(598) },
                    { 21, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(599), null, "Dorms with historical significance", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNhbGVuZGFyIj48cGF0aCBkPSJNOCAydjQiLz48cGF0aCBkPSJNMTYgMnY0Ii8+PHJlY3Qgd2lkdGg9IjE4IiBoZWlnaHQ9IjE4IiB4PSIzIiB5PSI0IiByeD0iMiIvPjxwYXRoIGQ9Ik0zIDEwaDE4Ii8+PC9zdmc+", true, false, "Historical Dorms", null, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(599) }
                });

            migrationBuilder.InsertData(
                table: "Habits",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1257), null, "Wakes up early in the morning", true, false, "Early Bird", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1258) },
                    { 2, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1504), null, "Stays up late at night", true, false, "Night Owl", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1505) },
                    { 3, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1506), null, "Keeps everything clean and organized", true, false, "Neat Freak", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1506) },
                    { 4, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1507), null, "Enjoys socializing and having friends over", true, false, "Social Butterfly", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1507) },
                    { 5, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1508), null, "Prefers quiet environment", true, false, "Quiet Person", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1508) },
                    { 6, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1509), null, "Spends most time studying", true, false, "Studious", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1509) }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IconUrl", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1837), null, "Enjoys playing video games", null, true, false, "Gaming", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1837) },
                    { 2, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1987), null, "Enjoys reading books", null, true, false, "Reading", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1987) },
                    { 3, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1989), null, "Interested in music and instruments", null, true, false, "Music", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1989) },
                    { 4, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1990), null, "Enjoys sports activities", null, true, false, "Sports", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1990) },
                    { 5, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1991), null, "Enjoys cooking and culinary arts", null, true, false, "Cooking", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1991) },
                    { 6, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1992), null, "Interested in various forms of art", null, true, false, "Art", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(1992) }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IconUrl", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2247), null, "Located close to educational institutions", null, true, false, "Near Campus", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2248) },
                    { 2, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2580), null, "Allows pets in the premises", null, true, false, "Pet Friendly", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2580) },
                    { 3, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2594), null, "Exclusive for female residents", null, true, false, "Female Only", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2595) },
                    { 4, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2596), null, "Exclusive for male residents", null, true, false, "Male Only", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2596) },
                    { 5, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2597), null, "Suitable for students", null, true, false, "Student Friendly", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2598) },
                    { 6, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2598), null, "Recently constructed property", null, true, false, "Newly Built", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2599) },
                    { 7, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2599), null, "Affordable accommodation", null, true, false, "Budget Friendly", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2600) },
                    { 8, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2601), null, "High-end accommodation", null, true, false, "Luxury", new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(2601) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "8e445865-a24d-4543-a6c6-9443d048cdb0" },
                    { "2", "8e445865-a24d-4543-a6c6-9443d048cdb5" },
                    { "2", "8e445865-a24d-4543-a6c6-9443d048cdb6" },
                    { "2", "8e445865-a24d-4543-a6c6-9443d048cdb7" },
                    { "2", "8e445865-a24d-4543-a6c6-9443d048cdb8" },
                    { "2", "8e445865-a24d-4543-a6c6-9443d048cdb9" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Icon", "IsActive", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 4, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(570), null, "Studio for one person", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlIj48cGF0aCBkPSJNMTUgMjF2LThhMSAxIDAgMCAwLTEtMWgtNGExIDEgMCAwIDAtMSAxdjgiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PC9zdmc+", true, false, "Single Studio", 1, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(571) },
                    { 5, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(572), null, "Studio for two persons", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlIj48cGF0aCBkPSJNMTUgMjF2LThhMSAxIDAgMCAwLTEtMWgtNGExIDEgMCAwIDAtMSAxdjgiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PC9zdmc+", true, false, "Double Studio", 1, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(573) },
                    { 6, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(574), null, "Two bedroom apartment", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXJzIj48cGF0aCBkPSJNMTYgMjF2LTJhNCA0IDAgMCAwLTQtNEg2YTQgNCAwIDAgMC00IDR2MiIvPjxjaXJjbGUgY3g9IjkiIGN5PSI3IiByPSI0Ii8+PHBhdGggZD0iTTIyIDIxdi0yYTQgNCAwIDAgMC0zLTMuODciLz48cGF0aCBkPSJNMTYgMy4xM2E0IDQgMCAwIDEgMCA3Ljc1Ii8+PC9zdmc+", true, false, "2-Bedroom", 2, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(574) },
                    { 7, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(576), null, "Three bedroom apartment", "h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXJzIj48cGF0aCBkPSJNMTYgMjF2LTJhNCA0IDAgMCAwLTQtNEg2YTQgNCAwIDAgMC00IDR2MiIvPjxjaXJjbGUgY3g9IjkiIGN5PSI3IiByPSI0Ii8+PHBhdGggZD0iTTIyIDIxdi0yYTQgNCAwIDAgMC0zLTMuODciLz48cGF0aCBkPSJNMTYgMy4xM2E0IDQgMCAwIDEgMCA3Ljc1Ii8+PC9zdmc+", true, false, "3-Bedroom", 2, new DateTime(2025, 2, 27, 6, 35, 26, 963, DateTimeKind.Utc).AddTicks(576) }
                });

            migrationBuilder.InsertData(
                table: "Dorms",
                columns: new[] { "Id", "Address", "AmenityId", "CategoryId", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsAvailable", "IsDeleted", "IsVerified", "Latitude", "Longitude", "Name", "OwnerId", "Rating", "TagId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "49 Marcos Highway, Valenzuela, Parañaque, Metro Manila, Philippines", null, 13, new DateTime(2024, 8, 4, 14, 35, 27, 253, DateTimeKind.Local).AddTicks(9593), null, "Contemporary Modern accommodations with convenient access to universities and business districts. Close to University of the East", true, false, false, false, 14.248859419545792m, 120.678903904071219m, "Central Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.0m, null, new DateTime(2025, 2, 27, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(5027) },
                    { 2, "363 EDSA, San Antonio, Parañaque, Metro Manila, Philippines", null, 1, new DateTime(2024, 10, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1932), null, "Comfortable Modern accommodations with convenient access to universities and business districts. Close to Polytechnic University of the Philippines", true, false, false, true, 14.727845477221695m, 120.53856429709865m, "Central Residences", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1935) },
                    { 3, "195 Marcos Highway, Pinagkaisahan, Quezon City, Metro Manila, Philippines", null, 11, new DateTime(2025, 1, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2049), null, "Stylish Secure and well-maintained accommodations for peace of mind. Near Far Eastern University", true, true, false, true, 14.192326556923253m, 120.9125739744817717m, "Green Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.0m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2049) },
                    { 4, "176 Taft Avenue, Pinagkaisahan, Manila, Metro Manila, Philippines", null, 12, new DateTime(2024, 11, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2088), null, "Contemporary Budget-friendly options without compromising on quality and comfort. Close to University of the East", true, true, false, true, 14.26975429623679m, 120.518915560281051m, "Purple Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2089) },
                    { 6, "417 Buendia Avenue, Pio del Pilar, Taguig, Metro Manila, Philippines", null, 14, new DateTime(2024, 4, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2219), null, "Student-friendly Contemporary living spaces designed for the modern lifestyle. Walking distance to De La Salle University", true, true, false, true, 14.818258727292884m, 121.444023321066714m, "Silver Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.8m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2220) },
                    { 7, "598 EDSA, Guadalupe Nuevo, Pasig, Metro Manila, Philippines", null, 17, new DateTime(2024, 7, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2289), null, "Professional Student-friendly dormitory with study areas and high-speed internet. Near Technological University of the Philippines", true, false, false, true, 14.6137438684190828m, 120.579732298598221m, "Blue Place", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2290) },
                    { 8, "399 Shaw Boulevard, Valenzuela, Makati, Metro Manila, Philippines", null, 8, new DateTime(2025, 1, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2340), null, "Stylish Luxurious residences offering the best in comfort and convenience. Close to University of the East", true, true, false, true, 15.087367999816252m, 120.732483524181826m, "Green Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2341) },
                    { 9, "189 Shaw Boulevard, San Isidro, Quezon City, Metro Manila, Philippines", null, 18, new DateTime(2024, 12, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2421), null, "Contemporary Budget-friendly options without compromising on quality and comfort. Near University of the Philippines", true, true, false, true, 14.59513767458109076m, 120.9907734137345913m, "Royal Hall", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.4m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2422) },
                    { 10, "720 Marcos Highway, San Lorenzo, Makati, Metro Manila, Philippines", null, 21, new DateTime(2024, 3, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2478), null, "Contemporary Modern accommodations with convenient access to universities and business districts. Close to University of the East", true, true, false, true, 15.030752844133998m, 120.786469726201086m, "Royal House", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.5m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2478) },
                    { 11, "715 Ortigas Avenue, Palanan, Quezon City, Metro Manila, Philippines", null, 1, new DateTime(2024, 10, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2510), null, "Student-friendly Premium living experience with top-notch amenities and security features. Near AMA University", true, true, false, false, 14.5837350028847507m, 121.203713917676878m, "Crystal Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.8m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2510) },
                    { 12, "240 Buendia Avenue, Poblacion, Pasig, Metro Manila, Philippines", null, 14, new DateTime(2024, 7, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2553), null, "Comfortable Modern accommodations with convenient access to universities and business districts. Near Far Eastern University", true, true, false, true, 14.6667627066109621m, 121.156679415159896m, "Green Residences", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2554) },
                    { 13, "525 Ortigas Avenue, Pio del Pilar, Pasay, Metro Manila, Philippines", null, 17, new DateTime(2024, 3, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2597), null, "Classic Affordable lodgings with essential amenities for a comfortable stay. Near Far Eastern University", true, true, false, true, 14.979116749416858m, 121.280708263236148m, "Purple Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2597) },
                    { 14, "323 Shaw Boulevard, Valenzuela, Makati, Metro Manila, Philippines", null, 17, new DateTime(2024, 8, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2642), null, "Spacious Strategically located residences for easy access to key city establishments. Close to University of the East", true, true, false, true, 14.764694521502217m, 121.266784505520102m, "Green Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2643) },
                    { 16, "563 Ortigas Avenue, Poblacion, Mandaluyong, Metro Manila, Philippines", null, 18, new DateTime(2024, 7, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2725), null, "Classic Strategically located residences for easy access to key city establishments. Close to Polytechnic University of the Philippines", true, true, false, true, 14.839039029886731m, 120.867318689238615m, "Red Residences", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.5m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2726) },
                    { 17, "15 Taft Avenue, San Lorenzo, Makati, Metro Manila, Philippines", null, 2, new DateTime(2024, 7, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2777), null, "Contemporary A comfortable living space designed for students and young professionals. Close to Ateneo de Manila University", true, false, false, true, 14.991916554453045m, 121.184757243405169m, "Silver House", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2778) },
                    { 18, "974 Marcos Highway, Pinagkaisahan, Mandaluyong, Metro Manila, Philippines", null, 10, new DateTime(2024, 10, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2847), null, "Stylish Student-friendly dormitory with study areas and high-speed internet. Close to Ateneo de Manila University", true, false, false, true, 14.949289868038981m, 120.536068856443031m, "Elite Residences", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2848) },
                    { 19, "690 Katipunan Avenue, Guadalupe Nuevo, Manila, Metro Manila, Philippines", null, 8, new DateTime(2025, 1, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2888), null, "Cozy Secure and well-maintained accommodations for peace of mind. Near University of the Philippines", true, true, false, true, 14.360876457876235m, 121.159903077891703m, "Red Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.1m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2889) },
                    { 20, "991 Ortigas Avenue, Singkamas, Taguig, Metro Manila, Philippines", null, 11, new DateTime(2024, 9, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2936), null, "Spacious Secure and well-maintained accommodations for peace of mind. Walking distance to De La Salle University", true, true, false, true, 14.281661859321483m, 120.66875894625958m, "Orange Hall", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2937) },
                    { 21, "100 Taft Avenue, San Isidro, Makati, Metro Manila, Philippines", null, 12, new DateTime(2024, 9, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2999), null, "Comfortable Student-friendly dormitory with study areas and high-speed internet. Close to University of the East", true, true, false, true, 14.6580497694828314m, 121.450733860176119m, "Royal House", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3000) },
                    { 22, "699 Shaw Boulevard, San Isidro, Makati, Metro Manila, Philippines", null, 12, new DateTime(2024, 4, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3046), null, "Modern Contemporary living spaces designed for the modern lifestyle. Near AMA University", true, true, false, false, 14.29192662014087m, 121.333892177423133m, "Central Residences", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.1m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3046) },
                    { 23, "80 Katipunan Avenue, Guadalupe Nuevo, Pasig, Metro Manila, Philippines", null, 1, new DateTime(2024, 8, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3087), null, "Luxurious Modern accommodations with convenient access to universities and business districts. Near University of the Philippines", true, false, false, false, 15.071857435604724m, 121.0141240944580753m, "Green House", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.8m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3087) },
                    { 25, "214 Ortigas Avenue, Valenzuela, Pasig, Metro Manila, Philippines", null, 2, new DateTime(2024, 6, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3164), null, "Comfortable Luxurious residences offering the best in comfort and convenience. Near Far Eastern University", true, true, false, true, 14.3571211058803m, 121.420048300315369m, "Orange Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.5m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3164) },
                    { 26, "261 Shaw Boulevard, San Lorenzo, Mandaluyong, Metro Manila, Philippines", null, 20, new DateTime(2024, 11, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3215), null, "Modern Contemporary living spaces designed for the modern lifestyle. Walking distance to De La Salle University", true, false, false, true, 14.446624295470828m, 120.620374882825545m, "Orange Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3215) },
                    { 27, "302 Katipunan Avenue, Singkamas, Manila, Metro Manila, Philippines", null, 19, new DateTime(2024, 7, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3270), null, "Modern Modern accommodations with convenient access to universities and business districts. Near AMA University", true, true, false, true, 14.196876423933253m, 121.148890758411163m, "Red House", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.1m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3271) },
                    { 28, "760 Commonwealth Avenue, Singkamas, Manila, Metro Manila, Philippines", null, 1, new DateTime(2024, 11, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3336), null, "Spacious Premium living experience with top-notch amenities and security features. Near Far Eastern University", true, false, false, true, 14.206905441863185m, 121.148257298872647m, "Silver Suites", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3337) },
                    { 29, "428 Ortigas Avenue, San Antonio, Quezon City, Metro Manila, Philippines", null, 20, new DateTime(2024, 7, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3405), null, "Stylish Modern accommodations with convenient access to universities and business districts. Close to Polytechnic University of the Philippines", true, true, false, true, 14.6636404118221906m, 120.97760051901219439m, "Crystal Hall", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3405) },
                    { 30, "698 Taft Avenue, San Isidro, Parañaque, Metro Manila, Philippines", null, 21, new DateTime(2024, 5, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3487), null, "Modern Modern accommodations with convenient access to universities and business districts. Near Far Eastern University", true, true, false, true, 14.228237970780925m, 120.496778020809487m, "Green Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3487) },
                    { 31, "45 Taft Avenue, San Lorenzo, Mandaluyong, Metro Manila, Philippines", null, 18, new DateTime(2024, 7, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3539), null, "Stylish Budget-friendly options without compromising on quality and comfort. Near Far Eastern University", true, true, false, true, 14.481050225141249m, 120.749729457137701m, "Orange Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3539) },
                    { 32, "304 Ortigas Avenue, Valenzuela, Quezon City, Metro Manila, Philippines", null, 14, new DateTime(2024, 7, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3572), null, "Modern Budget-friendly options without compromising on quality and comfort. Walking distance to De La Salle University", true, false, false, true, 14.6877949133349094m, 120.819070378642748m, "Premium Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3573) },
                    { 33, "985 Buendia Avenue, San Antonio, Quezon City, Metro Manila, Philippines", null, 20, new DateTime(2024, 8, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3618), null, "Stylish Premium living experience with top-notch amenities and security features. Close to University of the East", true, true, false, true, 14.828740050413292m, 121.325112792291917m, "Silver Place", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3618) },
                    { 34, "574 Ayala Avenue, Singkamas, Pasig, Metro Manila, Philippines", null, 14, new DateTime(2025, 1, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3668), null, "Contemporary Luxurious residences offering the best in comfort and convenience. Near AMA University", true, true, false, true, 15.010980576690045m, 120.844288095702272m, "Green Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.1m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3668) },
                    { 36, "94 Marcos Highway, Singkamas, Quezon City, Metro Manila, Philippines", null, 19, new DateTime(2024, 12, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3745), null, "Spacious Modern accommodations with convenient access to universities and business districts. Close to Ateneo de Manila University", true, true, false, true, 14.947791406337308m, 121.0188921018952001m, "Grand Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.8m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3745) },
                    { 37, "5 Shaw Boulevard, Pinagkaisahan, Pasig, Metro Manila, Philippines", null, 11, new DateTime(2025, 2, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3797), null, "Classic A comfortable living space designed for students and young professionals. Near Technological University of the Philippines", true, true, false, true, 14.252413179785438m, 121.156786408756946m, "Blue House", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.0m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3797) },
                    { 39, "992 Ayala Avenue, Pinagkaisahan, Mandaluyong, Metro Manila, Philippines", null, 12, new DateTime(2024, 3, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3898), null, "Spacious Strategically located residences for easy access to key city establishments. Near University of Santo Tomas", true, false, false, false, 15.044114047158795m, 120.85067147143561m, "Royal Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3899) },
                    { 40, "851 Katipunan Avenue, San Antonio, Mandaluyong, Metro Manila, Philippines", null, 18, new DateTime(2024, 9, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3951), null, "Luxurious Secure and well-maintained accommodations for peace of mind. Near Technological University of the Philippines", true, true, false, false, 14.405317566954446m, 120.796376886160009m, "Orange Suites", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.1m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3952) },
                    { 41, "483 Katipunan Avenue, San Lorenzo, Taguig, Metro Manila, Philippines", null, 10, new DateTime(2025, 2, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3994), null, "Contemporary Premium living experience with top-notch amenities and security features. Walking distance to De La Salle University", true, true, false, true, 15.058539185642749m, 120.830134440077252m, "Central Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3994) },
                    { 42, "625 Taft Avenue, Palanan, Makati, Metro Manila, Philippines", null, 9, new DateTime(2024, 12, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4044), null, "Luxurious Contemporary living spaces designed for the modern lifestyle. Walking distance to De La Salle University", true, true, false, true, 14.801783228608911m, 120.567773511374916m, "Crystal House", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4045) },
                    { 43, "708 Ayala Avenue, Singkamas, Parañaque, Metro Manila, Philippines", null, 1, new DateTime(2024, 7, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4083), null, "Contemporary Contemporary living spaces designed for the modern lifestyle. Walking distance to Manila Central University", true, true, false, false, 14.999359162466535m, 120.744313487606921m, "Royal Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.4m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4083) },
                    { 45, "771 Rizal Avenue, Poblacion, Mandaluyong, Metro Manila, Philippines", null, 2, new DateTime(2024, 5, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4156), null, "Professional Premium living experience with top-notch amenities and security features. Close to Ateneo de Manila University", true, true, false, true, 15.006244398598906m, 121.336510362668852m, "Golden Place", "8e445865-a24d-4543-a6c6-9443d048cdb8", 5.0m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4157) },
                    { 46, "471 Buendia Avenue, Singkamas, Mandaluyong, Metro Manila, Philippines", null, 10, new DateTime(2024, 12, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4190), null, "Contemporary Budget-friendly options without compromising on quality and comfort. Near AMA University", true, true, false, false, 14.394000355745899m, 120.867991260134332m, "Purple Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4190) },
                    { 47, "31 Marcos Highway, Guadalupe Nuevo, Parañaque, Metro Manila, Philippines", null, 19, new DateTime(2024, 12, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4217), null, "Classic Strategically located residences for easy access to key city establishments. Near University of the Philippines", true, true, false, false, 14.459700117975567m, 121.265671745009288m, "Superior Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.4m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4218) },
                    { 48, "185 Shaw Boulevard, Singkamas, Pasig, Metro Manila, Philippines", null, 12, new DateTime(2024, 3, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4259), null, "Classic Budget-friendly options without compromising on quality and comfort. Close to Ateneo de Manila University", true, true, false, true, 14.6174621873041439m, 121.336138376599894m, "Blue Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4259) },
                    { 49, "188 Commonwealth Avenue, Singkamas, Quezon City, Metro Manila, Philippines", null, 20, new DateTime(2024, 5, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4299), null, "Spacious Budget-friendly options without compromising on quality and comfort. Walking distance to Manila Central University", true, false, false, true, 15.004441951346091m, 120.664856593377076m, "Premium Place", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.8m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4299) },
                    { 50, "988 Rizal Avenue, San Isidro, Mandaluyong, Metro Manila, Philippines", null, 1, new DateTime(2024, 5, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4338), null, "Professional Secure and well-maintained accommodations for peace of mind. Close to Polytechnic University of the Philippines", true, true, false, false, 14.5383182491244833m, 120.9272890090032895m, "Orange House", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4339) },
                    { 51, "708 Ayala Avenue, Pinagkaisahan, Manila, Metro Manila, Philippines", null, 9, new DateTime(2024, 8, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4389), null, "Stylish Budget-friendly options without compromising on quality and comfort. Near Far Eastern University", true, true, false, true, 14.6631020710522318m, 120.815915500602366m, "Elite Hall", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4390) },
                    { 52, "913 Ortigas Avenue, San Isidro, Pasig, Metro Manila, Philippines", null, 21, new DateTime(2024, 3, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4450), null, "Stylish Contemporary living spaces designed for the modern lifestyle. Near University of Santo Tomas", true, true, false, true, 15.020901435472724m, 120.771690695383163m, "Premium Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4451) },
                    { 54, "234 Marcos Highway, Poblacion, Manila, Metro Manila, Philippines", null, 10, new DateTime(2024, 7, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4555), null, "Spacious Luxurious residences offering the best in comfort and convenience. Close to University of the East", true, true, false, true, 14.5264200178919919m, 120.758761620445252m, "Superior Residences", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4556) },
                    { 55, "961 Taft Avenue, Pinagkaisahan, Mandaluyong, Metro Manila, Philippines", null, 2, new DateTime(2025, 1, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4601), null, "Contemporary Modern accommodations with convenient access to universities and business districts. Near AMA University", true, true, false, true, 14.797032048773734m, 121.0249159861832466m, "Golden Suites", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4602) },
                    { 56, "807 Ayala Avenue, San Antonio, Manila, Metro Manila, Philippines", null, 12, new DateTime(2024, 10, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4650), null, "Professional Budget-friendly options without compromising on quality and comfort. Walking distance to Manila Central University", true, true, false, false, 14.914423654224222m, 120.539694675438616m, "Elegant Place", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4651) },
                    { 57, "347 Commonwealth Avenue, San Antonio, Taguig, Metro Manila, Philippines", null, 18, new DateTime(2024, 3, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4694), null, "Spacious Luxurious residences offering the best in comfort and convenience. Close to University of the East", true, true, false, true, 14.895434542918547m, 121.209014922420687m, "Elegant Suites", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.1m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4695) },
                    { 58, "750 EDSA, San Antonio, Manila, Metro Manila, Philippines", null, 20, new DateTime(2024, 9, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4735), null, "Professional Luxurious residences offering the best in comfort and convenience. Near AMA University", true, false, false, true, 14.337791712588766m, 120.806976725200367m, "Crystal Hall", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4735) },
                    { 59, "271 EDSA, Valenzuela, Pasig, Metro Manila, Philippines", null, 19, new DateTime(2025, 2, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4775), null, "Spacious Student-friendly dormitory with study areas and high-speed internet. Close to Polytechnic University of the Philippines", true, true, false, false, 14.460625712451118m, 121.165566424859206m, "Premium Suites", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4776) },
                    { 60, "787 Shaw Boulevard, San Isidro, Quezon City, Metro Manila, Philippines", null, 11, new DateTime(2024, 4, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4817), null, "Classic Modern accommodations with convenient access to universities and business districts. Near AMA University", true, true, false, true, 14.6763251370530693m, 121.092311496366612m, "Elite Suites", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4818) },
                    { 62, "64 Marcos Highway, Valenzuela, Mandaluyong, Metro Manila, Philippines", null, 9, new DateTime(2024, 11, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4902), null, "Comfortable Budget-friendly options without compromising on quality and comfort. Near University of the Philippines", true, true, false, true, 14.5553889434933145m, 120.570113452359807m, "Grand Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.8m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4903) },
                    { 63, "386 Shaw Boulevard, Singkamas, Pasay, Metro Manila, Philippines", null, 13, new DateTime(2024, 10, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4940), null, "Comfortable Budget-friendly options without compromising on quality and comfort. Near University of Santo Tomas", true, true, false, true, 15.079891485607434m, 120.865768720276267m, "Central Place", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4941) },
                    { 66, "211 Marcos Highway, Poblacion, Quezon City, Metro Manila, Philippines", null, 18, new DateTime(2024, 5, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5060), null, "Professional Premium living experience with top-notch amenities and security features. Near University of Santo Tomas", true, true, false, true, 14.271811780123185m, 121.382055953265846m, "Central Suites", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5060) },
                    { 67, "399 Katipunan Avenue, San Isidro, Pasig, Metro Manila, Philippines", null, 20, new DateTime(2024, 6, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5086), null, "Luxurious Secure and well-maintained accommodations for peace of mind. Near University of the Philippines", true, true, false, false, 14.5736067120219146m, 121.265897957674832m, "Red Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5087) },
                    { 68, "683 Taft Avenue, Valenzuela, Mandaluyong, Metro Manila, Philippines", null, 13, new DateTime(2025, 1, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5123), null, "Professional Affordable lodgings with essential amenities for a comfortable stay. Walking distance to De La Salle University", true, true, false, false, 15.007407450063111m, 120.83432229827704m, "Orange Suites", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5123) },
                    { 69, "300 Katipunan Avenue, San Isidro, Quezon City, Metro Manila, Philippines", null, 19, new DateTime(2024, 7, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5166), null, "Classic Student-friendly dormitory with study areas and high-speed internet. Near Far Eastern University", true, false, false, true, 14.740342062253897m, 121.210506855085449m, "Orange Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5166) },
                    { 70, "12 Marcos Highway, Valenzuela, Parañaque, Metro Manila, Philippines", null, 10, new DateTime(2024, 10, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5206), null, "Comfortable Premium living experience with top-notch amenities and security features. Walking distance to De La Salle University", true, true, false, true, 14.199104455334882m, 120.631507358750751m, "Silver Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.8m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5207) },
                    { 72, "84 Katipunan Avenue, Palanan, Pasay, Metro Manila, Philippines", null, 20, new DateTime(2024, 11, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5272), null, "Professional Budget-friendly options without compromising on quality and comfort. Near University of the Philippines", true, false, false, true, 14.5840171992129261m, 120.707517865851949m, "Blue Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.5m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5273) },
                    { 73, "940 EDSA, Pinagkaisahan, Pasig, Metro Manila, Philippines", null, 19, new DateTime(2024, 9, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5299), null, "Student-friendly Strategically located residences for easy access to key city establishments. Near Far Eastern University", true, true, false, true, 14.196359362021489m, 120.727666341515755m, "Orange Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5300) },
                    { 74, "135 Rizal Avenue, Pinagkaisahan, Mandaluyong, Metro Manila, Philippines", null, 12, new DateTime(2024, 11, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5337), null, "Stylish Contemporary living spaces designed for the modern lifestyle. Close to Polytechnic University of the Philippines", true, true, false, true, 14.230661244181526m, 120.837685540651477m, "Blue Suites", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5337) },
                    { 75, "201 Ortigas Avenue, Pio del Pilar, Makati, Metro Manila, Philippines", null, 21, new DateTime(2024, 9, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5378), null, "Spacious Strategically located residences for easy access to key city establishments. Near Far Eastern University", true, true, false, true, 14.266912920001621m, 121.0286095011541664m, "Central Residences", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5379) },
                    { 76, "677 Ayala Avenue, Valenzuela, Mandaluyong, Metro Manila, Philippines", null, 14, new DateTime(2024, 9, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5410), null, "Spacious Contemporary living spaces designed for the modern lifestyle. Near University of Santo Tomas", true, false, false, false, 14.5565615261127528m, 120.762521868869626m, "Silver Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5411) },
                    { 77, "547 Katipunan Avenue, Poblacion, Makati, Metro Manila, Philippines", null, 10, new DateTime(2024, 6, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5442), null, "Spacious Contemporary living spaces designed for the modern lifestyle. Near University of Santo Tomas", true, true, false, false, 15.070350332626538m, 120.498856735590965m, "Orange Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.4m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5443) },
                    { 78, "340 Ortigas Avenue, San Isidro, Quezon City, Metro Manila, Philippines", null, 2, new DateTime(2024, 10, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5483), null, "Luxurious Luxurious residences offering the best in comfort and convenience. Near Far Eastern University", true, true, false, true, 14.654205521815785m, 121.432709196261181m, "Elite Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.5m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5484) },
                    { 79, "947 Commonwealth Avenue, Guadalupe Nuevo, Taguig, Metro Manila, Philippines", null, 12, new DateTime(2024, 4, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5512), null, "Stylish Luxurious residences offering the best in comfort and convenience. Close to Polytechnic University of the Philippines", true, true, false, true, 14.936135559721214m, 121.379250335626607m, "Green Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.0m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5513) },
                    { 80, "283 Ayala Avenue, Poblacion, Parañaque, Metro Manila, Philippines", null, 18, new DateTime(2024, 10, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5547), null, "Modern Premium living experience with top-notch amenities and security features. Near Far Eastern University", true, true, false, true, 14.448520590702547m, 120.581009116702904m, "Purple Suites", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.0m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5548) },
                    { 81, "157 Ayala Avenue, Poblacion, Pasay, Metro Manila, Philippines", null, 10, new DateTime(2025, 1, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5576), null, "Professional Premium living experience with top-notch amenities and security features. Walking distance to Manila Central University", true, true, false, true, 14.492387158036645m, 120.515862116773269m, "Green House", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5577) },
                    { 82, "421 Taft Avenue, San Antonio, Parañaque, Metro Manila, Philippines", null, 2, new DateTime(2024, 11, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5605), null, "Contemporary Contemporary living spaces designed for the modern lifestyle. Near University of the Philippines", true, true, false, true, 14.318909739700802m, 120.87054948683267m, "Royal Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5605) },
                    { 85, "535 Buendia Avenue, San Isidro, Manila, Metro Manila, Philippines", null, 9, new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5718), null, "Contemporary Strategically located residences for easy access to key city establishments. Close to Ateneo de Manila University", true, true, false, false, 14.6766520494377017m, 121.344219279113048m, "Elite Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5719) },
                    { 86, "417 Marcos Highway, Palanan, Taguig, Metro Manila, Philippines", null, 1, new DateTime(2024, 12, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5767), null, "Comfortable Strategically located residences for easy access to key city establishments. Walking distance to De La Salle University", true, true, false, true, 14.6308256958179761m, 120.9195373839684471m, "Blue Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5768) },
                    { 91, "462 EDSA, San Isidro, Mandaluyong, Metro Manila, Philippines", null, 17, new DateTime(2024, 10, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5942), null, "Comfortable Budget-friendly options without compromising on quality and comfort. Near University of the Philippines", true, true, false, true, 14.457929246283336m, 120.9724086368688422m, "Superior House", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.8m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5943) },
                    { 92, "820 EDSA, San Lorenzo, Taguig, Metro Manila, Philippines", null, 2, new DateTime(2024, 9, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5977), null, "Student-friendly A comfortable living space designed for students and young professionals. Close to Polytechnic University of the Philippines", true, true, false, true, 14.884329349156855m, 121.231005506640489m, "Purple Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.8m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5977) },
                    { 93, "720 Taft Avenue, Pinagkaisahan, Pasay, Metro Manila, Philippines", null, 20, new DateTime(2024, 8, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6016), null, "Comfortable Affordable lodgings with essential amenities for a comfortable stay. Near University of Santo Tomas", true, true, false, false, 14.6282610597576765m, 121.181174764902599m, "Elegant Hall", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.1m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6016) },
                    { 94, "80 Marcos Highway, Pinagkaisahan, Pasay, Metro Manila, Philippines", null, 14, new DateTime(2024, 9, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6050), null, "Spacious Student-friendly dormitory with study areas and high-speed internet. Close to Ateneo de Manila University", true, true, false, true, 14.480540874580406m, 121.198301922099526m, "Purple Hall", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6051) },
                    { 98, "475 Shaw Boulevard, Valenzuela, Pasig, Metro Manila, Philippines", null, 21, new DateTime(2024, 5, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6178), null, "Classic Premium living experience with top-notch amenities and security features. Near Far Eastern University", true, true, false, true, 14.7834406935889m, 121.356780113761397m, "Central Place", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6179) }
                });

            migrationBuilder.InsertData(
                table: "DormAmenities",
                columns: new[] { "Id", "AmenityId", "DeletedAt", "DormId", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 1, 2, null, 1, true, false },
                    { 2, 4, null, 1, true, false },
                    { 3, 7, null, 1, true, false },
                    { 4, 8, null, 1, true, false },
                    { 5, 5, null, 2, true, false },
                    { 6, 3, null, 2, true, false },
                    { 7, 7, null, 3, true, false },
                    { 8, 2, null, 3, true, false },
                    { 9, 3, null, 3, true, false },
                    { 10, 2, null, 4, true, false },
                    { 11, 1, null, 4, true, false },
                    { 12, 3, null, 4, true, false },
                    { 13, 8, null, 4, true, false },
                    { 17, 7, null, 6, true, false },
                    { 18, 5, null, 6, true, false },
                    { 19, 8, null, 7, true, false },
                    { 20, 1, null, 7, true, false },
                    { 21, 2, null, 8, true, false },
                    { 22, 5, null, 8, true, false },
                    { 23, 2, null, 9, true, false },
                    { 24, 3, null, 9, true, false },
                    { 25, 8, null, 9, true, false },
                    { 26, 5, null, 9, true, false },
                    { 27, 7, null, 10, true, false },
                    { 28, 3, null, 10, true, false },
                    { 29, 6, null, 10, true, false },
                    { 30, 2, null, 11, true, false },
                    { 31, 5, null, 11, true, false },
                    { 32, 3, null, 11, true, false },
                    { 33, 6, null, 11, true, false },
                    { 34, 8, null, 11, true, false },
                    { 35, 2, null, 12, true, false },
                    { 36, 4, null, 12, true, false },
                    { 37, 4, null, 13, true, false },
                    { 38, 7, null, 13, true, false },
                    { 39, 8, null, 14, true, false },
                    { 40, 1, null, 14, true, false },
                    { 41, 7, null, 14, true, false },
                    { 42, 2, null, 14, true, false },
                    { 45, 1, null, 16, true, false },
                    { 46, 8, null, 16, true, false },
                    { 47, 6, null, 16, true, false },
                    { 48, 7, null, 16, true, false },
                    { 49, 6, null, 17, true, false },
                    { 50, 1, null, 17, true, false },
                    { 51, 1, null, 18, true, false },
                    { 52, 2, null, 18, true, false },
                    { 53, 8, null, 18, true, false },
                    { 54, 3, null, 18, true, false },
                    { 55, 2, null, 19, true, false },
                    { 56, 1, null, 19, true, false },
                    { 57, 6, null, 20, true, false },
                    { 58, 8, null, 20, true, false },
                    { 59, 2, null, 21, true, false },
                    { 60, 7, null, 21, true, false },
                    { 61, 8, null, 21, true, false },
                    { 62, 4, null, 21, true, false },
                    { 63, 6, null, 21, true, false },
                    { 64, 4, null, 22, true, false },
                    { 65, 2, null, 22, true, false },
                    { 66, 8, null, 22, true, false },
                    { 67, 2, null, 23, true, false },
                    { 68, 8, null, 23, true, false },
                    { 69, 1, null, 23, true, false },
                    { 70, 6, null, 23, true, false },
                    { 72, 5, null, 25, true, false },
                    { 73, 2, null, 25, true, false },
                    { 74, 7, null, 25, true, false },
                    { 75, 3, null, 26, true, false },
                    { 76, 6, null, 26, true, false },
                    { 77, 3, null, 27, true, false },
                    { 78, 6, null, 27, true, false },
                    { 79, 1, null, 27, true, false },
                    { 80, 4, null, 28, true, false },
                    { 81, 5, null, 28, true, false },
                    { 82, 3, null, 28, true, false },
                    { 83, 5, null, 29, true, false },
                    { 84, 8, null, 29, true, false },
                    { 85, 3, null, 29, true, false },
                    { 86, 2, null, 29, true, false },
                    { 87, 7, null, 30, true, false },
                    { 88, 4, null, 30, true, false },
                    { 89, 2, null, 30, true, false },
                    { 90, 1, null, 30, true, false },
                    { 91, 7, null, 31, true, false },
                    { 92, 2, null, 31, true, false },
                    { 93, 6, null, 32, true, false },
                    { 94, 3, null, 32, true, false },
                    { 95, 4, null, 32, true, false },
                    { 96, 7, null, 33, true, false },
                    { 97, 3, null, 33, true, false },
                    { 98, 4, null, 33, true, false },
                    { 99, 2, null, 34, true, false },
                    { 100, 3, null, 34, true, false },
                    { 103, 1, null, 36, true, false },
                    { 104, 4, null, 36, true, false },
                    { 105, 2, null, 36, true, false },
                    { 106, 7, null, 36, true, false },
                    { 107, 8, null, 37, true, false },
                    { 108, 2, null, 37, true, false },
                    { 112, 2, null, 39, true, false },
                    { 113, 5, null, 39, true, false },
                    { 114, 3, null, 39, true, false },
                    { 115, 6, null, 40, true, false },
                    { 116, 5, null, 40, true, false },
                    { 117, 1, null, 41, true, false },
                    { 118, 4, null, 41, true, false },
                    { 119, 5, null, 41, true, false },
                    { 120, 8, null, 41, true, false },
                    { 121, 3, null, 41, true, false },
                    { 122, 7, null, 42, true, false },
                    { 123, 4, null, 42, true, false },
                    { 124, 6, null, 42, true, false },
                    { 125, 5, null, 42, true, false },
                    { 126, 8, null, 43, true, false },
                    { 127, 1, null, 43, true, false },
                    { 132, 2, null, 45, true, false },
                    { 133, 8, null, 45, true, false },
                    { 134, 2, null, 46, true, false },
                    { 135, 5, null, 46, true, false },
                    { 136, 4, null, 46, true, false },
                    { 137, 1, null, 47, true, false },
                    { 138, 3, null, 47, true, false },
                    { 139, 7, null, 48, true, false },
                    { 140, 5, null, 48, true, false },
                    { 141, 4, null, 48, true, false },
                    { 142, 4, null, 49, true, false },
                    { 143, 2, null, 49, true, false },
                    { 144, 4, null, 50, true, false },
                    { 145, 1, null, 50, true, false },
                    { 146, 6, null, 50, true, false },
                    { 147, 3, null, 51, true, false },
                    { 148, 6, null, 52, true, false },
                    { 149, 2, null, 52, true, false },
                    { 155, 5, null, 54, true, false },
                    { 156, 2, null, 54, true, false },
                    { 157, 1, null, 54, true, false },
                    { 158, 3, null, 54, true, false },
                    { 159, 7, null, 54, true, false },
                    { 160, 2, null, 55, true, false },
                    { 161, 4, null, 55, true, false },
                    { 162, 5, null, 56, true, false },
                    { 163, 7, null, 56, true, false },
                    { 164, 3, null, 56, true, false },
                    { 165, 6, null, 57, true, false },
                    { 166, 2, null, 57, true, false },
                    { 167, 7, null, 57, true, false },
                    { 168, 4, null, 57, true, false },
                    { 169, 5, null, 58, true, false },
                    { 170, 7, null, 58, true, false },
                    { 171, 5, null, 59, true, false },
                    { 172, 2, null, 59, true, false },
                    { 173, 6, null, 60, true, false },
                    { 174, 4, null, 60, true, false },
                    { 175, 2, null, 60, true, false },
                    { 176, 7, null, 60, true, false },
                    { 180, 1, null, 62, true, false },
                    { 181, 6, null, 62, true, false },
                    { 182, 1, null, 63, true, false },
                    { 183, 6, null, 63, true, false },
                    { 184, 5, null, 63, true, false },
                    { 185, 4, null, 63, true, false },
                    { 192, 8, null, 66, true, false },
                    { 193, 2, null, 66, true, false },
                    { 194, 6, null, 66, true, false },
                    { 195, 7, null, 67, true, false },
                    { 196, 8, null, 67, true, false },
                    { 197, 3, null, 67, true, false },
                    { 198, 6, null, 68, true, false },
                    { 199, 4, null, 68, true, false },
                    { 200, 2, null, 69, true, false },
                    { 201, 5, null, 69, true, false },
                    { 202, 4, null, 70, true, false },
                    { 203, 6, null, 70, true, false },
                    { 207, 3, null, 72, true, false },
                    { 208, 4, null, 72, true, false },
                    { 209, 4, null, 73, true, false },
                    { 210, 5, null, 73, true, false },
                    { 211, 6, null, 74, true, false },
                    { 212, 4, null, 74, true, false },
                    { 213, 3, null, 74, true, false },
                    { 214, 2, null, 75, true, false },
                    { 215, 5, null, 75, true, false },
                    { 216, 6, null, 76, true, false },
                    { 217, 4, null, 76, true, false },
                    { 218, 6, null, 77, true, false },
                    { 219, 8, null, 77, true, false },
                    { 220, 3, null, 77, true, false },
                    { 221, 5, null, 78, true, false },
                    { 222, 4, null, 78, true, false },
                    { 223, 6, null, 79, true, false },
                    { 224, 5, null, 79, true, false },
                    { 225, 7, null, 79, true, false },
                    { 226, 3, null, 80, true, false },
                    { 227, 6, null, 80, true, false },
                    { 228, 1, null, 80, true, false },
                    { 229, 6, null, 81, true, false },
                    { 230, 8, null, 81, true, false },
                    { 231, 5, null, 82, true, false },
                    { 232, 3, null, 82, true, false },
                    { 233, 8, null, 82, true, false },
                    { 241, 2, null, 85, true, false },
                    { 242, 5, null, 85, true, false },
                    { 243, 6, null, 85, true, false },
                    { 244, 4, null, 85, true, false },
                    { 245, 7, null, 85, true, false },
                    { 246, 7, null, 86, true, false },
                    { 247, 3, null, 86, true, false },
                    { 248, 8, null, 86, true, false },
                    { 263, 4, null, 91, true, false },
                    { 264, 1, null, 91, true, false },
                    { 265, 2, null, 91, true, false },
                    { 266, 8, null, 92, true, false },
                    { 267, 2, null, 92, true, false },
                    { 268, 4, null, 92, true, false },
                    { 269, 2, null, 93, true, false },
                    { 270, 7, null, 93, true, false },
                    { 271, 3, null, 93, true, false },
                    { 272, 5, null, 94, true, false },
                    { 273, 8, null, 94, true, false },
                    { 274, 4, null, 94, true, false },
                    { 275, 7, null, 94, true, false },
                    { 283, 6, null, 98, true, false },
                    { 284, 8, null, 98, true, false }
                });

            migrationBuilder.InsertData(
                table: "DormTags",
                columns: new[] { "Id", "DeletedAt", "DormId", "IsActive", "IsDeleted", "TagId" },
                values: new object[,]
                {
                    { 1, null, 1, true, false, 2 },
                    { 2, null, 1, true, false, 7 },
                    { 3, null, 2, true, false, 7 },
                    { 4, null, 3, true, false, 7 },
                    { 5, null, 4, true, false, 1 },
                    { 6, null, 4, true, false, 7 },
                    { 7, null, 4, true, false, 4 },
                    { 9, null, 6, true, false, 1 },
                    { 10, null, 7, true, false, 1 },
                    { 11, null, 7, true, false, 7 },
                    { 12, null, 7, true, false, 2 },
                    { 13, null, 8, true, false, 2 },
                    { 14, null, 9, true, false, 8 },
                    { 15, null, 10, true, false, 2 },
                    { 16, null, 10, true, false, 6 },
                    { 17, null, 11, true, false, 7 },
                    { 18, null, 12, true, false, 1 },
                    { 19, null, 13, true, false, 3 },
                    { 20, null, 13, true, false, 1 },
                    { 21, null, 13, true, false, 5 },
                    { 22, null, 14, true, false, 8 },
                    { 24, null, 16, true, false, 1 },
                    { 25, null, 16, true, false, 5 },
                    { 26, null, 17, true, false, 2 },
                    { 27, null, 18, true, false, 7 },
                    { 28, null, 19, true, false, 3 },
                    { 29, null, 19, true, false, 4 },
                    { 30, null, 20, true, false, 1 },
                    { 31, null, 21, true, false, 6 },
                    { 32, null, 21, true, false, 1 },
                    { 33, null, 21, true, false, 2 },
                    { 34, null, 22, true, false, 5 },
                    { 35, null, 22, true, false, 3 },
                    { 36, null, 23, true, false, 1 },
                    { 37, null, 23, true, false, 5 },
                    { 38, null, 23, true, false, 4 },
                    { 42, null, 25, true, false, 1 },
                    { 43, null, 25, true, false, 4 },
                    { 44, null, 26, true, false, 4 },
                    { 45, null, 27, true, false, 1 },
                    { 46, null, 27, true, false, 3 },
                    { 47, null, 28, true, false, 1 },
                    { 48, null, 28, true, false, 8 },
                    { 49, null, 28, true, false, 5 },
                    { 50, null, 29, true, false, 8 },
                    { 51, null, 30, true, false, 1 },
                    { 52, null, 30, true, false, 2 },
                    { 53, null, 30, true, false, 6 },
                    { 54, null, 31, true, false, 2 },
                    { 55, null, 31, true, false, 1 },
                    { 56, null, 32, true, false, 8 },
                    { 57, null, 33, true, false, 5 },
                    { 58, null, 33, true, false, 7 },
                    { 59, null, 34, true, false, 1 },
                    { 62, null, 36, true, false, 1 },
                    { 63, null, 36, true, false, 6 },
                    { 64, null, 37, true, false, 4 },
                    { 65, null, 37, true, false, 6 },
                    { 69, null, 39, true, false, 2 },
                    { 70, null, 39, true, false, 7 },
                    { 71, null, 40, true, false, 6 },
                    { 72, null, 40, true, false, 5 },
                    { 73, null, 41, true, false, 1 },
                    { 74, null, 42, true, false, 7 },
                    { 75, null, 43, true, false, 8 },
                    { 76, null, 43, true, false, 1 },
                    { 77, null, 43, true, false, 4 },
                    { 80, null, 45, true, false, 1 },
                    { 81, null, 46, true, false, 6 },
                    { 82, null, 47, true, false, 7 },
                    { 83, null, 48, true, false, 6 },
                    { 84, null, 49, true, false, 7 },
                    { 85, null, 49, true, false, 1 },
                    { 86, null, 50, true, false, 7 },
                    { 87, null, 50, true, false, 4 },
                    { 88, null, 51, true, false, 1 },
                    { 89, null, 51, true, false, 3 },
                    { 90, null, 51, true, false, 4 },
                    { 91, null, 52, true, false, 1 },
                    { 93, null, 54, true, false, 3 },
                    { 94, null, 54, true, false, 1 },
                    { 95, null, 54, true, false, 2 },
                    { 96, null, 55, true, false, 8 },
                    { 97, null, 56, true, false, 4 },
                    { 98, null, 57, true, false, 2 },
                    { 99, null, 57, true, false, 6 },
                    { 100, null, 58, true, false, 8 },
                    { 101, null, 58, true, false, 4 },
                    { 102, null, 59, true, false, 2 },
                    { 103, null, 59, true, false, 5 },
                    { 104, null, 59, true, false, 8 },
                    { 105, null, 60, true, false, 6 },
                    { 107, null, 62, true, false, 8 },
                    { 108, null, 63, true, false, 7 },
                    { 112, null, 66, true, false, 5 },
                    { 113, null, 67, true, false, 2 },
                    { 114, null, 67, true, false, 4 },
                    { 115, null, 68, true, false, 7 },
                    { 116, null, 68, true, false, 5 },
                    { 117, null, 68, true, false, 6 },
                    { 118, null, 69, true, false, 8 },
                    { 119, null, 69, true, false, 6 },
                    { 120, null, 70, true, false, 6 },
                    { 121, null, 70, true, false, 2 },
                    { 122, null, 70, true, false, 4 },
                    { 125, null, 72, true, false, 4 },
                    { 126, null, 72, true, false, 5 },
                    { 127, null, 72, true, false, 2 },
                    { 128, null, 73, true, false, 3 },
                    { 129, null, 74, true, false, 2 },
                    { 130, null, 74, true, false, 1 },
                    { 131, null, 74, true, false, 5 },
                    { 132, null, 75, true, false, 3 },
                    { 133, null, 76, true, false, 4 },
                    { 134, null, 76, true, false, 5 },
                    { 135, null, 77, true, false, 5 },
                    { 136, null, 77, true, false, 4 },
                    { 137, null, 78, true, false, 4 },
                    { 138, null, 79, true, false, 1 },
                    { 139, null, 79, true, false, 4 },
                    { 140, null, 80, true, false, 6 },
                    { 141, null, 80, true, false, 1 },
                    { 142, null, 80, true, false, 2 },
                    { 143, null, 81, true, false, 1 },
                    { 144, null, 82, true, false, 5 },
                    { 148, null, 85, true, false, 3 },
                    { 149, null, 86, true, false, 8 },
                    { 150, null, 86, true, false, 4 },
                    { 151, null, 86, true, false, 3 },
                    { 159, null, 91, true, false, 1 },
                    { 160, null, 91, true, false, 2 },
                    { 161, null, 92, true, false, 3 },
                    { 162, null, 92, true, false, 5 },
                    { 163, null, 93, true, false, 4 },
                    { 164, null, 94, true, false, 4 },
                    { 170, null, 98, true, false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Dorms",
                columns: new[] { "Id", "Address", "AmenityId", "CategoryId", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsAvailable", "IsDeleted", "IsVerified", "Latitude", "Longitude", "Name", "OwnerId", "Rating", "TagId", "UpdatedAt" },
                values: new object[,]
                {
                    { 5, "157 Taft Avenue, Pio del Pilar, Pasay, Metro Manila, Philippines", null, 7, new DateTime(2024, 4, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2145), null, "Stylish Secure and well-maintained accommodations for peace of mind. Near Technological University of the Philippines", true, true, false, true, 14.937631803012514m, 121.459498964406968m, "Elite Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.5m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2146) },
                    { 15, "968 Taft Avenue, Poblacion, Manila, Metro Manila, Philippines", null, 7, new DateTime(2024, 12, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2687), null, "Classic Premium living experience with top-notch amenities and security features. Near University of Santo Tomas", true, false, false, true, 14.60902223432693733m, 120.784614352817654m, "Silver Residences", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2687) },
                    { 24, "591 Ayala Avenue, Palanan, Mandaluyong, Metro Manila, Philippines", null, 7, new DateTime(2024, 10, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3131), null, "Professional A comfortable living space designed for students and young professionals. Near AMA University", true, false, false, true, 14.438508073480338m, 120.9502570097463471m, "Green Residences", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3132) },
                    { 35, "953 Rizal Avenue, San Lorenzo, Mandaluyong, Metro Manila, Philippines", null, 4, new DateTime(2024, 5, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3701), null, "Comfortable Premium living experience with top-notch amenities and security features. Near Far Eastern University", true, true, false, true, 14.247222296951209m, 120.764637784865702m, "Superior Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3702) },
                    { 38, "412 Ortigas Avenue, Pio del Pilar, Parañaque, Metro Manila, Philippines", null, 7, new DateTime(2025, 2, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3843), null, "Modern Contemporary living spaces designed for the modern lifestyle. Walking distance to De La Salle University", true, true, false, true, 14.115394521035205m, 121.40452925827444m, "Golden Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3843) },
                    { 44, "826 Rizal Avenue, Valenzuela, Pasay, Metro Manila, Philippines", null, 4, new DateTime(2024, 7, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4116), null, "Cozy Student-friendly dormitory with study areas and high-speed internet. Walking distance to De La Salle University", true, false, false, true, 14.261896349088473m, 121.0674183428961869m, "Grand Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4117) },
                    { 53, "709 Ayala Avenue, Guadalupe Nuevo, Taguig, Metro Manila, Philippines", null, 6, new DateTime(2024, 9, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4502), null, "Luxurious Student-friendly dormitory with study areas and high-speed internet. Close to Polytechnic University of the Philippines", true, true, false, true, 14.742923772250965m, 121.46674455951161m, "Red Hall", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4503) },
                    { 61, "564 Ortigas Avenue, Singkamas, Taguig, Metro Manila, Philippines", null, 7, new DateTime(2024, 7, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4860), null, "Student-friendly Student-friendly dormitory with study areas and high-speed internet. Near Technological University of the Philippines", true, true, false, true, 14.6834495479985837m, 120.846405015198423m, "Central Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4861) },
                    { 64, "139 Ayala Avenue, San Lorenzo, Pasay, Metro Manila, Philippines", null, 6, new DateTime(2024, 11, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4980), null, "Modern Modern accommodations with convenient access to universities and business districts. Near Technological University of the Philippines", true, true, false, true, 14.703787387153268m, 120.98781255533230143m, "Red Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4980) },
                    { 65, "381 Rizal Avenue, Pinagkaisahan, Parañaque, Metro Manila, Philippines", null, 5, new DateTime(2024, 6, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5014), null, "Student-friendly Contemporary living spaces designed for the modern lifestyle. Near University of Santo Tomas", true, false, false, true, 14.498129662766415m, 121.0480602811674868m, "Orange Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.5m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5015) },
                    { 71, "248 Katipunan Avenue, San Lorenzo, Parañaque, Metro Manila, Philippines", null, 6, new DateTime(2024, 3, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5245), null, "Luxurious Budget-friendly options without compromising on quality and comfort. Near University of Santo Tomas", true, false, false, false, 14.6807390863808054m, 121.118662912862405m, "Elegant Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.9m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5246) },
                    { 83, "395 Buendia Avenue, Guadalupe Nuevo, Pasay, Metro Manila, Philippines", null, 5, new DateTime(2025, 1, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5643), null, "Classic Affordable lodgings with essential amenities for a comfortable stay. Near Technological University of the Philippines", true, true, false, true, 14.977281572229127m, 120.589957980191036m, "Blue Place", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.8m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5644) },
                    { 84, "87 Ayala Avenue, San Antonio, Pasay, Metro Manila, Philippines", null, 6, new DateTime(2024, 4, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5685), null, "Cozy Modern accommodations with convenient access to universities and business districts. Near University of Santo Tomas", true, true, false, true, 15.057913448165363m, 121.0727009800961711m, "Superior Residences", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.5m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5685) },
                    { 87, "669 Marcos Highway, San Antonio, Pasay, Metro Manila, Philippines", null, 4, new DateTime(2024, 5, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5798), null, "Spacious Strategically located residences for easy access to key city establishments. Near AMA University", true, true, false, true, 14.485811700281832m, 121.317877497614956m, "Red Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.2m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5799) },
                    { 88, "705 Ayala Avenue, San Antonio, Manila, Metro Manila, Philippines", null, 7, new DateTime(2024, 12, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5831), null, "Modern Affordable lodgings with essential amenities for a comfortable stay. Near Technological University of the Philippines", true, true, false, true, 14.909632848476122m, 121.0442903185829941m, "Golden Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.1m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5832) },
                    { 89, "704 Commonwealth Avenue, San Antonio, Taguig, Metro Manila, Philippines", null, 5, new DateTime(2024, 4, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5871), null, "Comfortable Modern accommodations with convenient access to universities and business districts. Walking distance to De La Salle University", true, true, false, true, 14.984001263911138m, 121.003908177316798m, "Blue Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb8", 5.0m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5871) },
                    { 90, "274 EDSA, Palanan, Quezon City, Metro Manila, Philippines", null, 7, new DateTime(2024, 10, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5910), null, "Cozy Contemporary living spaces designed for the modern lifestyle. Walking distance to Manila Central University", true, true, false, true, 14.704051493471745m, 121.363640236780532m, "Grand Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.7m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5910) },
                    { 95, "282 Taft Avenue, San Lorenzo, Makati, Metro Manila, Philippines", null, 4, new DateTime(2024, 12, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6080), null, "Modern Modern accommodations with convenient access to universities and business districts. Near Technological University of the Philippines", true, true, false, false, 14.733459408213366m, 120.9183866194429745m, "Blue Place", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6081) },
                    { 96, "175 Taft Avenue, Valenzuela, Mandaluyong, Metro Manila, Philippines", null, 6, new DateTime(2024, 4, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6108), null, "Stylish Contemporary living spaces designed for the modern lifestyle. Walking distance to De La Salle University", true, true, false, true, 14.941696255848834m, 120.564757002257815m, "Premium Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.3m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6108) },
                    { 97, "204 Commonwealth Avenue, Pio del Pilar, Taguig, Metro Manila, Philippines", null, 5, new DateTime(2024, 10, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6136), null, "Contemporary A comfortable living space designed for students and young professionals. Near Technological University of the Philippines", true, true, false, true, 14.137094234122706m, 120.98257581044918661m, "Premium Suites", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.4m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6136) },
                    { 99, "734 Commonwealth Avenue, Guadalupe Nuevo, Pasig, Metro Manila, Philippines", null, 7, new DateTime(2024, 12, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6205), null, "Luxurious Contemporary living spaces designed for the modern lifestyle. Near Technological University of the Philippines", true, true, false, true, 14.953734065792632m, 121.463340215077968m, "Central Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.0m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6206) },
                    { 100, "620 Buendia Avenue, Pio del Pilar, Manila, Metro Manila, Philippines", null, 5, new DateTime(2024, 5, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6242), null, "Stylish A comfortable living space designed for students and young professionals. Near University of Santo Tomas", true, true, false, true, 14.499476807367046m, 121.187667945895841m, "Silver Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.6m, null, new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6242) }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Caption", "CreatedAt", "DeletedAt", "DormId", "IsActive", "IsDeleted", "IsPrimary", "Order", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { 1, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1416), null, 1, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1416), "https://loremflickr.com/800/768?random=263" },
                    { 2, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1861), null, 1, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1861), "https://loremflickr.com/1024/900?random=255" },
                    { 3, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1875), null, 1, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(1875), "https://loremflickr.com/800/768?random=925" },
                    { 4, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2004), null, 2, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2004), "https://loremflickr.com/1024/768?random=741" },
                    { 5, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2006), null, 2, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2006), "https://loremflickr.com/1024/768?random=848" },
                    { 6, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2009), null, 2, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2009), "https://loremflickr.com/800/768?random=787" },
                    { 7, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2011), null, 2, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2012), "https://loremflickr.com/1024/768?random=419" },
                    { 8, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2013), null, 2, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2013), "https://loremflickr.com/1024/900?random=441" },
                    { 9, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2076), null, 3, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2076), "https://loremflickr.com/1200/600?random=642" },
                    { 10, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2078), null, 3, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2079), "https://loremflickr.com/1024/768?random=414" },
                    { 11, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2080), null, 3, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2080), "https://loremflickr.com/1200/600?random=563" },
                    { 12, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2132), null, 4, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2132), "https://loremflickr.com/1024/600?random=561" },
                    { 13, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2134), null, 4, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2134), "https://loremflickr.com/1024/600?random=568" },
                    { 14, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2136), null, 4, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2136), "https://loremflickr.com/800/768?random=1301" },
                    { 15, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2137), null, 4, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2138), "https://loremflickr.com/1024/600?random=555" },
                    { 22, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2261), null, 6, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2261), "https://loremflickr.com/1024/768?random=1549" },
                    { 23, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2264), null, 6, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2264), "https://loremflickr.com/1200/900?random=1284" },
                    { 24, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2266), null, 6, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2267), "https://loremflickr.com/800/768?random=630" },
                    { 25, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2269), null, 6, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2269), "https://loremflickr.com/1024/600?random=749" },
                    { 26, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2271), null, 6, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2272), "https://loremflickr.com/1024/600?random=702" },
                    { 27, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2322), null, 7, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2322), "https://loremflickr.com/1200/900?random=1184" },
                    { 28, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2324), null, 7, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2325), "https://loremflickr.com/800/768?random=1146" },
                    { 29, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2328), null, 7, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2328), "https://loremflickr.com/1200/600?random=1251" },
                    { 30, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2330), null, 7, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2330), "https://loremflickr.com/800/600?random=1334" },
                    { 31, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2388), null, 8, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2388), "https://loremflickr.com/1200/600?random=1342" },
                    { 32, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2390), null, 8, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2391), "https://loremflickr.com/800/900?random=1032" },
                    { 33, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2393), null, 8, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2393), "https://loremflickr.com/1200/600?random=1179" },
                    { 34, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2406), null, 8, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2406), "https://loremflickr.com/1024/600?random=1448" },
                    { 35, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2409), null, 8, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2409), "https://loremflickr.com/800/768?random=1665" },
                    { 36, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2411), null, 8, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2412), "https://loremflickr.com/1200/768?random=861" },
                    { 37, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2460), null, 9, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2460), "https://loremflickr.com/1024/600?random=1156" },
                    { 38, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2462), null, 9, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2462), "https://loremflickr.com/800/600?random=1297" },
                    { 39, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2466), null, 9, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2467), "https://loremflickr.com/1200/600?random=1396" },
                    { 40, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2468), null, 9, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2469), "https://loremflickr.com/1200/600?random=1603" },
                    { 41, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2470), null, 9, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2471), "https://loremflickr.com/1024/768?random=1392" },
                    { 42, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2494), null, 10, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2494), "https://loremflickr.com/1200/900?random=1312" },
                    { 43, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2496), null, 10, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2496), "https://loremflickr.com/1200/600?random=1720" },
                    { 44, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2502), null, 10, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2503), "https://loremflickr.com/1200/900?random=1801" },
                    { 45, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2538), null, 11, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2539), "https://loremflickr.com/800/900?random=1477" },
                    { 46, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2540), null, 11, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2540), "https://loremflickr.com/800/600?random=2066" },
                    { 47, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2542), null, 11, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2542), "https://loremflickr.com/1200/900?random=1966" },
                    { 48, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2543), null, 11, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2543), "https://loremflickr.com/1200/768?random=1489" },
                    { 49, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2545), null, 11, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2545), "https://loremflickr.com/1024/768?random=1865" },
                    { 50, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2546), null, 11, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2547), "https://loremflickr.com/1200/768?random=1395" },
                    { 51, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2582), null, 12, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2582), "https://loremflickr.com/1200/600?random=1349" },
                    { 52, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2583), null, 12, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2583), "https://loremflickr.com/800/900?random=2125" },
                    { 53, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2585), null, 12, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2585), "https://loremflickr.com/800/768?random=1675" },
                    { 54, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2587), null, 12, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2587), "https://loremflickr.com/1024/768?random=1639" },
                    { 55, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2588), null, 12, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2589), "https://loremflickr.com/800/900?random=2100" },
                    { 56, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2590), null, 12, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2590), "https://loremflickr.com/1200/768?random=1712" },
                    { 57, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2629), null, 13, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2629), "https://loremflickr.com/1200/600?random=1764" },
                    { 58, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2631), null, 13, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2631), "https://loremflickr.com/1024/900?random=1307" },
                    { 59, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2632), null, 13, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2633), "https://loremflickr.com/800/768?random=1662" },
                    { 60, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2634), null, 13, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2634), "https://loremflickr.com/1200/900?random=1807" },
                    { 61, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2636), null, 13, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2636), "https://loremflickr.com/1024/768?random=1723" },
                    { 62, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2671), null, 14, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2671), "https://loremflickr.com/1024/900?random=2004" },
                    { 63, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2673), null, 14, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2673), "https://loremflickr.com/800/768?random=2277" },
                    { 64, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2674), null, 14, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2675), "https://loremflickr.com/800/600?random=1468" },
                    { 65, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2676), null, 14, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2676), "https://loremflickr.com/800/900?random=1505" },
                    { 70, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2755), null, 16, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2756), "https://loremflickr.com/1024/900?random=2517" },
                    { 71, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2758), null, 16, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2759), "https://loremflickr.com/1200/900?random=2138" },
                    { 72, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2761), null, 16, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2761), "https://loremflickr.com/800/900?random=2284" },
                    { 73, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2764), null, 16, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2764), "https://loremflickr.com/800/600?random=1716" },
                    { 74, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2767), null, 16, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2767), "https://loremflickr.com/800/600?random=1676" },
                    { 75, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2820), null, 17, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2820), "https://loremflickr.com/1200/768?random=2210" },
                    { 76, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2823), null, 17, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2823), "https://loremflickr.com/1024/900?random=2387" },
                    { 77, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2825), null, 17, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2826), "https://loremflickr.com/1200/768?random=2191" },
                    { 78, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2828), null, 17, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2828), "https://loremflickr.com/1200/600?random=2545" },
                    { 79, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2830), null, 17, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2830), "https://loremflickr.com/1024/768?random=2019" },
                    { 80, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2838), null, 17, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2838), "https://loremflickr.com/800/768?random=1817" },
                    { 81, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2872), null, 18, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2872), "https://loremflickr.com/1024/768?random=1978" },
                    { 82, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2874), null, 18, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2874), "https://loremflickr.com/1200/768?random=2093" },
                    { 83, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2876), null, 18, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2876), "https://loremflickr.com/1200/600?random=2061" },
                    { 84, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2878), null, 18, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2879), "https://loremflickr.com/1200/768?random=2416" },
                    { 85, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2923), null, 19, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2923), "https://loremflickr.com/1024/600?random=2072" },
                    { 86, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2925), null, 19, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2925), "https://loremflickr.com/1024/600?random=2306" },
                    { 87, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2927), null, 19, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2928), "https://loremflickr.com/1024/768?random=2668" },
                    { 88, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2976), null, 20, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2976), "https://loremflickr.com/1024/900?random=2864" },
                    { 89, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2978), null, 20, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2978), "https://loremflickr.com/1200/900?random=2775" },
                    { 90, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2981), null, 20, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2981), "https://loremflickr.com/1200/600?random=2652" },
                    { 91, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2983), null, 20, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2984), "https://loremflickr.com/1200/600?random=2603" },
                    { 92, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2986), null, 20, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2986), "https://loremflickr.com/1200/768?random=2813" },
                    { 93, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2988), null, 20, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2989), "https://loremflickr.com/800/600?random=2768" },
                    { 94, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3028), null, 21, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3029), "https://loremflickr.com/1024/600?random=3001" },
                    { 95, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3030), null, 21, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3030), "https://loremflickr.com/1024/768?random=2376" },
                    { 96, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3032), null, 21, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3032), "https://loremflickr.com/1024/900?random=2718" },
                    { 97, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3033), null, 21, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3033), "https://loremflickr.com/800/600?random=2811" },
                    { 98, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3035), null, 21, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3035), "https://loremflickr.com/1024/768?random=2441" },
                    { 99, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3075), null, 22, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3076), "https://loremflickr.com/800/600?random=2886" },
                    { 100, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3077), null, 22, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3077), "https://loremflickr.com/1024/900?random=3073" },
                    { 101, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3078), null, 22, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3079), "https://loremflickr.com/1200/600?random=2276" },
                    { 102, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3080), null, 22, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3080), "https://loremflickr.com/1024/900?random=2806" },
                    { 103, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3118), null, 23, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3118), "https://loremflickr.com/1200/900?random=3033" },
                    { 104, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3119), null, 23, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3120), "https://loremflickr.com/1200/600?random=2676" },
                    { 105, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3121), null, 23, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3121), "https://loremflickr.com/1024/900?random=3078" },
                    { 106, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3123), null, 23, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3123), "https://loremflickr.com/1200/768?random=2396" },
                    { 107, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3124), null, 23, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3125), "https://loremflickr.com/800/768?random=2390" },
                    { 113, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3200), null, 25, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3200), "https://loremflickr.com/1024/600?random=3298" },
                    { 114, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3201), null, 25, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3202), "https://loremflickr.com/1024/768?random=3132" },
                    { 115, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3203), null, 25, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3203), "https://loremflickr.com/800/600?random=3342" },
                    { 116, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3204), null, 25, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3205), "https://loremflickr.com/1200/900?random=3260" },
                    { 117, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3206), null, 25, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3206), "https://loremflickr.com/800/600?random=3413" },
                    { 118, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3208), null, 25, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3208), "https://loremflickr.com/800/900?random=3348" },
                    { 119, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3254), null, 26, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3255), "https://loremflickr.com/1200/600?random=2710" },
                    { 120, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3257), null, 26, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3258), "https://loremflickr.com/1024/600?random=2933" },
                    { 121, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3260), null, 26, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3260), "https://loremflickr.com/1200/768?random=2674" },
                    { 122, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3262), null, 26, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3262), "https://loremflickr.com/1200/900?random=3049" },
                    { 123, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3316), null, 27, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3317), "https://loremflickr.com/800/600?random=3070" },
                    { 124, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3319), null, 27, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3319), "https://loremflickr.com/1024/600?random=3280" },
                    { 125, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3322), null, 27, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3322), "https://loremflickr.com/1024/768?random=3595" },
                    { 126, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3324), null, 27, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3324), "https://loremflickr.com/1200/900?random=3027" },
                    { 127, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3326), null, 27, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3326), "https://loremflickr.com/800/768?random=2745" },
                    { 128, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3375), null, 28, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3375), "https://loremflickr.com/1024/600?random=3383" },
                    { 129, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3377), null, 28, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3378), "https://loremflickr.com/1024/768?random=3745" },
                    { 130, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3387), null, 28, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3387), "https://loremflickr.com/1024/600?random=3212" },
                    { 131, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3389), null, 28, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3389), "https://loremflickr.com/1200/600?random=3383" },
                    { 132, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3392), null, 28, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3393), "https://loremflickr.com/1200/768?random=2978" },
                    { 133, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3395), null, 28, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3395), "https://loremflickr.com/1200/600?random=3064" },
                    { 134, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3453), null, 29, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3454), "https://loremflickr.com/1200/768?random=3817" },
                    { 135, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3456), null, 29, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3456), "https://loremflickr.com/1024/900?random=2914" },
                    { 136, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3459), null, 29, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3459), "https://loremflickr.com/1024/768?random=3875" },
                    { 137, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3461), null, 29, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3461), "https://loremflickr.com/1024/768?random=3257" },
                    { 138, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3463), null, 29, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3464), "https://loremflickr.com/800/768?random=3149" },
                    { 139, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3467), null, 29, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3467), "https://loremflickr.com/800/768?random=3095" },
                    { 140, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3526), null, 30, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3526), "https://loremflickr.com/800/768?random=3325" },
                    { 141, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3527), null, 30, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3528), "https://loremflickr.com/1024/600?random=3217" },
                    { 142, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3529), null, 30, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3529), "https://loremflickr.com/1200/768?random=3805" },
                    { 143, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3531), null, 30, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3531), "https://loremflickr.com/800/900?random=3378" },
                    { 144, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3532), null, 30, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3533), "https://loremflickr.com/1024/900?random=3672" },
                    { 145, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3559), null, 31, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3559), "https://loremflickr.com/800/900?random=4089" },
                    { 146, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3560), null, 31, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3561), "https://loremflickr.com/800/600?random=3156" },
                    { 147, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3562), null, 31, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3562), "https://loremflickr.com/800/900?random=3856" },
                    { 148, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3563), null, 31, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3564), "https://loremflickr.com/1024/900?random=3345" },
                    { 149, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3565), null, 31, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3565), "https://loremflickr.com/800/600?random=3121" },
                    { 150, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3605), null, 32, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3605), "https://loremflickr.com/1024/600?random=3953" },
                    { 151, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3607), null, 32, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3607), "https://loremflickr.com/1200/768?random=3896" },
                    { 152, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3608), null, 32, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3608), "https://loremflickr.com/800/900?random=3487" },
                    { 153, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3610), null, 32, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3610), "https://loremflickr.com/800/900?random=3443" },
                    { 154, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3611), null, 32, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3612), "https://loremflickr.com/1200/768?random=3275" },
                    { 155, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3652), null, 33, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3652), "https://loremflickr.com/800/600?random=3528" },
                    { 156, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3654), null, 33, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3654), "https://loremflickr.com/800/600?random=3854" },
                    { 157, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3655), null, 33, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3656), "https://loremflickr.com/1200/768?random=3906" },
                    { 158, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3657), null, 33, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3658), "https://loremflickr.com/1024/600?random=3665" },
                    { 159, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3659), null, 33, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3659), "https://loremflickr.com/1200/900?random=3928" },
                    { 160, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3661), null, 33, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3661), "https://loremflickr.com/1024/900?random=3522" },
                    { 161, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3690), null, 34, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3690), "https://loremflickr.com/800/768?random=4155" },
                    { 162, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3692), null, 34, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3692), "https://loremflickr.com/1200/600?random=3697" },
                    { 163, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3693), null, 34, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3694), "https://loremflickr.com/1024/600?random=4063" },
                    { 164, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3695), null, 34, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3695), "https://loremflickr.com/1200/768?random=4181" },
                    { 169, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3783), null, 36, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3783), "https://loremflickr.com/1200/768?random=4394" },
                    { 170, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3785), null, 36, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3786), "https://loremflickr.com/800/900?random=4344" },
                    { 171, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3788), null, 36, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3788), "https://loremflickr.com/1024/900?random=4424" },
                    { 172, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3825), null, 37, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3826), "https://loremflickr.com/1024/600?random=3712" },
                    { 173, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3828), null, 37, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3828), "https://loremflickr.com/800/900?random=4575" },
                    { 174, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3831), null, 37, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3832), "https://loremflickr.com/1024/900?random=4241" },
                    { 175, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3834), null, 37, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3834), "https://loremflickr.com/1200/768?random=3930" },
                    { 182, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3925), null, 39, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3926), "https://loremflickr.com/1200/768?random=4270" },
                    { 183, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3927), null, 39, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3928), "https://loremflickr.com/1200/900?random=4367" },
                    { 184, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3930), null, 39, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3931), "https://loremflickr.com/1200/600?random=4899" },
                    { 185, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3933), null, 39, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3933), "https://loremflickr.com/1200/768?random=4258" },
                    { 186, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3936), null, 39, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3937), "https://loremflickr.com/1200/768?random=4466" },
                    { 187, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3939), null, 39, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3940), "https://loremflickr.com/1024/600?random=4003" },
                    { 188, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3980), null, 40, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3980), "https://loremflickr.com/800/900?random=4329" },
                    { 189, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3982), null, 40, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3982), "https://loremflickr.com/800/768?random=4317" },
                    { 190, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3984), null, 40, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3985), "https://loremflickr.com/1200/600?random=4209" },
                    { 191, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4029), null, 41, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4030), "https://loremflickr.com/1024/768?random=4956" },
                    { 192, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4031), null, 41, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4031), "https://loremflickr.com/800/600?random=4392" },
                    { 193, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4034), null, 41, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4034), "https://loremflickr.com/800/600?random=4830" },
                    { 194, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4035), null, 41, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4036), "https://loremflickr.com/1200/900?random=5013" },
                    { 195, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4037), null, 41, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4037), "https://loremflickr.com/800/768?random=4506" },
                    { 196, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4068), null, 42, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4068), "https://loremflickr.com/1024/900?random=4529" },
                    { 197, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4070), null, 42, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4070), "https://loremflickr.com/1024/900?random=4616" },
                    { 198, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4071), null, 42, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4072), "https://loremflickr.com/1200/900?random=4664" },
                    { 199, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4073), null, 42, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4073), "https://loremflickr.com/800/600?random=4934" },
                    { 200, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4075), null, 42, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4075), "https://loremflickr.com/1024/768?random=5165" },
                    { 201, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4076), null, 42, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4077), "https://loremflickr.com/1024/768?random=5003" },
                    { 202, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4106), null, 43, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4106), "https://loremflickr.com/1024/600?random=5198" },
                    { 203, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4108), null, 43, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4108), "https://loremflickr.com/800/900?random=4876" },
                    { 204, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4109), null, 43, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4110), "https://loremflickr.com/800/768?random=4862" },
                    { 210, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4179), null, 45, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4179), "https://loremflickr.com/800/600?random=5192" },
                    { 211, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4180), null, 45, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4180), "https://loremflickr.com/800/600?random=5151" },
                    { 212, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4182), null, 45, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4182), "https://loremflickr.com/800/900?random=5381" },
                    { 213, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4183), null, 45, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4184), "https://loremflickr.com/1200/900?random=4859" },
                    { 214, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4208), null, 46, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4208), "https://loremflickr.com/1024/768?random=4799" },
                    { 215, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4209), null, 46, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4210), "https://loremflickr.com/1024/768?random=5225" },
                    { 216, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4211), null, 46, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4211), "https://loremflickr.com/800/900?random=5156" },
                    { 217, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4248), null, 47, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4248), "https://loremflickr.com/800/900?random=4984" },
                    { 218, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4249), null, 47, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4250), "https://loremflickr.com/800/768?random=5366" },
                    { 219, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4251), null, 47, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4251), "https://loremflickr.com/1024/768?random=4984" },
                    { 220, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4252), null, 47, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4253), "https://loremflickr.com/1200/768?random=5604" },
                    { 221, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4286), null, 48, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4286), "https://loremflickr.com/800/768?random=4819" },
                    { 222, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4288), null, 48, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4288), "https://loremflickr.com/800/768?random=5352" },
                    { 223, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4289), null, 48, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4289), "https://loremflickr.com/1200/900?random=5425" },
                    { 224, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4291), null, 48, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4291), "https://loremflickr.com/1200/768?random=4924" },
                    { 225, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4292), null, 48, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4293), "https://loremflickr.com/1200/768?random=4968" },
                    { 226, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4320), null, 49, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4320), "https://loremflickr.com/800/900?random=5217" },
                    { 227, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4321), null, 49, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4322), "https://loremflickr.com/1024/768?random=5739" },
                    { 228, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4323), null, 49, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4323), "https://loremflickr.com/800/600?random=5280" },
                    { 229, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4324), null, 49, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4325), "https://loremflickr.com/1200/600?random=5034" },
                    { 230, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4328), null, 49, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4328), "https://loremflickr.com/1200/900?random=4979" },
                    { 231, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4369), null, 50, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4369), "https://loremflickr.com/1200/768?random=5238" },
                    { 232, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4371), null, 50, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4372), "https://loremflickr.com/1024/900?random=5337" },
                    { 233, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4374), null, 50, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4374), "https://loremflickr.com/1200/900?random=5292" },
                    { 234, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4376), null, 50, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4376), "https://loremflickr.com/1200/900?random=5759" },
                    { 235, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4378), null, 50, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4378), "https://loremflickr.com/800/600?random=5949" },
                    { 236, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4380), null, 50, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4380), "https://loremflickr.com/1200/900?random=5961" },
                    { 237, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4432), null, 51, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4432), "https://loremflickr.com/1024/600?random=5214" },
                    { 238, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4435), null, 51, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4435), "https://loremflickr.com/1200/600?random=5563" },
                    { 239, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4438), null, 51, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4438), "https://loremflickr.com/800/768?random=5452" },
                    { 240, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4440), null, 51, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4440), "https://loremflickr.com/1024/768?random=5448" },
                    { 241, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4442), null, 51, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4442), "https://loremflickr.com/800/900?random=5428" },
                    { 242, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4486), null, 52, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4486), "https://loremflickr.com/1200/600?random=6180" },
                    { 243, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4489), null, 52, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4489), "https://loremflickr.com/1024/600?random=5534" },
                    { 244, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4491), null, 52, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4492), "https://loremflickr.com/800/900?random=5613" },
                    { 245, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4494), null, 52, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4494), "https://loremflickr.com/1024/600?random=5701" },
                    { 252, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4584), null, 54, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4584), "https://loremflickr.com/800/900?random=6258" },
                    { 253, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4586), null, 54, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4586), "https://loremflickr.com/800/600?random=6296" },
                    { 254, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4588), null, 54, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4589), "https://loremflickr.com/800/900?random=5470" },
                    { 255, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4590), null, 54, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4591), "https://loremflickr.com/1200/600?random=5764" },
                    { 256, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4592), null, 54, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4592), "https://loremflickr.com/800/600?random=5445" },
                    { 257, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4634), null, 55, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4634), "https://loremflickr.com/1024/900?random=6270" },
                    { 258, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4637), null, 55, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4637), "https://loremflickr.com/1200/900?random=6481" },
                    { 259, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4639), null, 55, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4639), "https://loremflickr.com/1024/600?random=6311" },
                    { 260, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4640), null, 55, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4641), "https://loremflickr.com/800/900?random=6349" },
                    { 261, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4642), null, 55, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4642), "https://loremflickr.com/800/900?random=6192" },
                    { 262, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4644), null, 55, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4644), "https://loremflickr.com/1200/600?random=5944" },
                    { 263, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4681), null, 56, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4682), "https://loremflickr.com/1024/600?random=6065" },
                    { 264, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4683), null, 56, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4683), "https://loremflickr.com/1024/900?random=6563" },
                    { 265, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4685), null, 56, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4685), "https://loremflickr.com/1200/900?random=6560" },
                    { 266, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4686), null, 56, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4686), "https://loremflickr.com/1200/900?random=6383" },
                    { 267, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4688), null, 56, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4688), "https://loremflickr.com/1024/768?random=5639" },
                    { 268, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4720), null, 57, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4720), "https://loremflickr.com/800/600?random=6184" },
                    { 269, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4722), null, 57, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4722), "https://loremflickr.com/1024/900?random=6264" },
                    { 270, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4723), null, 57, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4723), "https://loremflickr.com/1024/600?random=6236" },
                    { 271, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4725), null, 57, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4725), "https://loremflickr.com/1024/600?random=6037" },
                    { 272, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4726), null, 57, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4727), "https://loremflickr.com/1200/600?random=6672" },
                    { 273, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4728), null, 57, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4728), "https://loremflickr.com/800/900?random=6503" },
                    { 274, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4762), null, 58, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4762), "https://loremflickr.com/800/768?random=6136" },
                    { 275, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4764), null, 58, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4764), "https://loremflickr.com/1024/900?random=5804" },
                    { 276, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4765), null, 58, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4765), "https://loremflickr.com/1200/900?random=5975" },
                    { 277, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4767), null, 58, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4767), "https://loremflickr.com/800/600?random=6334" },
                    { 278, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4769), null, 58, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4769), "https://loremflickr.com/1024/768?random=6627" },
                    { 279, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4803), null, 59, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4804), "https://loremflickr.com/1024/768?random=6053" },
                    { 280, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4805), null, 59, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4805), "https://loremflickr.com/800/768?random=6066" },
                    { 281, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4806), null, 59, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4807), "https://loremflickr.com/800/900?random=6551" },
                    { 282, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4808), null, 59, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4808), "https://loremflickr.com/1200/900?random=5986" },
                    { 283, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4809), null, 59, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4810), "https://loremflickr.com/1200/900?random=6162" },
                    { 284, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4811), null, 59, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4812), "https://loremflickr.com/1200/768?random=5919" },
                    { 285, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4846), null, 60, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4846), "https://loremflickr.com/1200/900?random=6992" },
                    { 286, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4847), null, 60, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4848), "https://loremflickr.com/1024/768?random=6844" },
                    { 287, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4849), null, 60, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4849), "https://loremflickr.com/1024/768?random=6458" },
                    { 288, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4850), null, 60, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4851), "https://loremflickr.com/1200/900?random=6460" },
                    { 289, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4852), null, 60, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4852), "https://loremflickr.com/1024/600?random=6207" },
                    { 290, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4854), null, 60, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4854), "https://loremflickr.com/800/768?random=6897" },
                    { 297, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4928), null, 62, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4928), "https://loremflickr.com/800/900?random=7081" },
                    { 298, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4929), null, 62, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4930), "https://loremflickr.com/1200/900?random=6568" },
                    { 299, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4931), null, 62, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4931), "https://loremflickr.com/1024/768?random=6821" },
                    { 300, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4933), null, 62, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4933), "https://loremflickr.com/800/900?random=6350" },
                    { 301, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4934), null, 62, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4935), "https://loremflickr.com/1024/768?random=6592" },
                    { 302, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4964), null, 63, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4964), "https://loremflickr.com/1024/768?random=6908" },
                    { 303, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4966), null, 63, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4966), "https://loremflickr.com/800/768?random=7260" },
                    { 304, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4971), null, 63, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4973), "https://loremflickr.com/800/600?random=6794" },
                    { 312, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5075), null, 66, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5075), "https://loremflickr.com/800/600?random=7200" },
                    { 313, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5076), null, 66, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5077), "https://loremflickr.com/1200/768?random=7023" },
                    { 314, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5078), null, 66, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5078), "https://loremflickr.com/800/768?random=6975" },
                    { 315, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5079), null, 66, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5080), "https://loremflickr.com/1024/900?random=7181" },
                    { 316, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5110), null, 67, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5111), "https://loremflickr.com/1200/600?random=7079" },
                    { 317, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5112), null, 67, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5112), "https://loremflickr.com/800/768?random=7364" },
                    { 318, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5114), null, 67, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5114), "https://loremflickr.com/800/900?random=7580" },
                    { 319, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5116), null, 67, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5116), "https://loremflickr.com/800/768?random=6841" },
                    { 320, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5117), null, 67, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5117), "https://loremflickr.com/1200/900?random=6816" },
                    { 321, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5147), null, 68, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5147), "https://loremflickr.com/1024/768?random=7365" },
                    { 322, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5149), null, 68, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5149), "https://loremflickr.com/1024/600?random=7309" },
                    { 323, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5150), null, 68, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5150), "https://loremflickr.com/800/600?random=7340" },
                    { 324, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5152), null, 68, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5152), "https://loremflickr.com/800/768?random=7680" },
                    { 325, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5158), null, 68, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5159), "https://loremflickr.com/800/600?random=7002" },
                    { 326, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5160), null, 68, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5161), "https://loremflickr.com/1024/900?random=7284" },
                    { 327, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5194), null, 69, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5194), "https://loremflickr.com/800/768?random=7180" },
                    { 328, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5196), null, 69, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5196), "https://loremflickr.com/1200/600?random=7558" },
                    { 329, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5197), null, 69, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5198), "https://loremflickr.com/1200/768?random=7187" },
                    { 330, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5199), null, 69, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5199), "https://loremflickr.com/1200/600?random=7101" },
                    { 331, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5200), null, 69, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5201), "https://loremflickr.com/1024/768?random=7537" },
                    { 332, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5229), null, 70, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5229), "https://loremflickr.com/1200/768?random=7129" },
                    { 333, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5234), null, 70, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5235), "https://loremflickr.com/1200/900?random=7234" },
                    { 334, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5237), null, 70, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5237), "https://loremflickr.com/1024/600?random=7839" },
                    { 335, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5239), null, 70, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5239), "https://loremflickr.com/1200/600?random=8001" },
                    { 340, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5287), null, 72, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5288), "https://loremflickr.com/1200/600?random=7654" },
                    { 341, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5289), null, 72, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5289), "https://loremflickr.com/800/600?random=7253" },
                    { 342, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5290), null, 72, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5291), "https://loremflickr.com/800/900?random=8160" },
                    { 343, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5292), null, 72, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5292), "https://loremflickr.com/1200/900?random=7965" },
                    { 344, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5293), null, 72, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5294), "https://loremflickr.com/800/900?random=7805" },
                    { 345, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5326), null, 73, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5326), "https://loremflickr.com/800/600?random=7619" },
                    { 346, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5328), null, 73, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5328), "https://loremflickr.com/800/768?random=7507" },
                    { 347, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5329), null, 73, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5329), "https://loremflickr.com/1200/900?random=8168" },
                    { 348, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5331), null, 73, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5331), "https://loremflickr.com/1200/768?random=7995" },
                    { 349, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5358), null, 74, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5358), "https://loremflickr.com/1200/768?random=8126" },
                    { 350, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5365), null, 74, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5365), "https://loremflickr.com/1024/768?random=7916" },
                    { 351, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5366), null, 74, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5367), "https://loremflickr.com/1024/900?random=7885" },
                    { 352, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5368), null, 74, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5369), "https://loremflickr.com/1024/768?random=7817" },
                    { 353, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5370), null, 74, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5370), "https://loremflickr.com/1200/600?random=7634" },
                    { 354, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5372), null, 74, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5372), "https://loremflickr.com/800/600?random=7674" },
                    { 355, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5396), null, 75, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5397), "https://loremflickr.com/1024/600?random=7860" },
                    { 356, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5398), null, 75, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5398), "https://loremflickr.com/1024/600?random=8265" },
                    { 357, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5399), null, 75, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5400), "https://loremflickr.com/1200/768?random=8420" },
                    { 358, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5401), null, 75, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5401), "https://loremflickr.com/800/900?random=8337" },
                    { 359, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5402), null, 75, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5403), "https://loremflickr.com/800/600?random=8394" },
                    { 360, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5404), null, 75, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5404), "https://loremflickr.com/1024/768?random=7599" },
                    { 361, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5429), null, 76, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5429), "https://loremflickr.com/800/900?random=8148" },
                    { 362, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5430), null, 76, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5430), "https://loremflickr.com/1024/768?random=7739" },
                    { 363, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5435), null, 76, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5436), "https://loremflickr.com/1200/768?random=8322" },
                    { 364, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5471), null, 77, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5471), "https://loremflickr.com/1200/900?random=7948" },
                    { 365, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5472), null, 77, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5473), "https://loremflickr.com/800/600?random=8313" },
                    { 366, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5474), null, 77, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5474), "https://loremflickr.com/1024/768?random=8263" },
                    { 367, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5476), null, 77, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5476), "https://loremflickr.com/800/768?random=8578" },
                    { 368, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5477), null, 77, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5477), "https://loremflickr.com/1200/600?random=8145" },
                    { 369, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5498), null, 78, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5498), "https://loremflickr.com/800/600?random=8259" },
                    { 370, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5499), null, 78, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5500), "https://loremflickr.com/800/600?random=7828" },
                    { 371, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5501), null, 78, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5502), "https://loremflickr.com/800/900?random=7944" },
                    { 372, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5536), null, 79, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5536), "https://loremflickr.com/1024/900?random=8682" },
                    { 373, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5538), null, 79, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5538), "https://loremflickr.com/800/900?random=8482" },
                    { 374, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5540), null, 79, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5540), "https://loremflickr.com/1024/600?random=8832" },
                    { 375, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5541), null, 79, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5541), "https://loremflickr.com/1024/600?random=8247" },
                    { 376, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5564), null, 80, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5564), "https://loremflickr.com/800/600?random=8685" },
                    { 377, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5565), null, 80, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5566), "https://loremflickr.com/800/768?random=8887" },
                    { 378, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5567), null, 80, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5567), "https://loremflickr.com/1024/900?random=8137" },
                    { 379, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5568), null, 80, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5569), "https://loremflickr.com/1200/900?random=8151" },
                    { 380, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5570), null, 80, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5570), "https://loremflickr.com/800/600?random=8185" },
                    { 381, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5593), null, 81, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5594), "https://loremflickr.com/1200/900?random=8577" },
                    { 382, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5595), null, 81, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5595), "https://loremflickr.com/1024/768?random=9033" },
                    { 383, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5597), null, 81, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5597), "https://loremflickr.com/1024/768?random=8212" },
                    { 384, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5598), null, 81, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5599), "https://loremflickr.com/1200/600?random=8292" },
                    { 385, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5632), null, 82, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5633), "https://loremflickr.com/1200/768?random=8698" },
                    { 386, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5634), null, 82, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5634), "https://loremflickr.com/1024/600?random=8672" },
                    { 387, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5636), null, 82, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5636), "https://loremflickr.com/800/900?random=8593" },
                    { 388, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5637), null, 82, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5637), "https://loremflickr.com/1200/768?random=8620" },
                    { 398, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5752), null, 85, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5753), "https://loremflickr.com/1024/600?random=8794" },
                    { 399, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5754), null, 85, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5754), "https://loremflickr.com/800/768?random=9397" },
                    { 400, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5756), null, 85, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5756), "https://loremflickr.com/1024/600?random=8519" },
                    { 401, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5758), null, 85, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5758), "https://loremflickr.com/1024/768?random=9066" },
                    { 402, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5759), null, 85, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5759), "https://loremflickr.com/800/900?random=9393" },
                    { 403, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5761), null, 85, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5761), "https://loremflickr.com/1200/900?random=9064" },
                    { 404, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5787), null, 86, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5787), "https://loremflickr.com/800/900?random=8723" },
                    { 405, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5789), null, 86, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5789), "https://loremflickr.com/800/600?random=9354" },
                    { 406, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5790), null, 86, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5790), "https://loremflickr.com/1024/600?random=9338" },
                    { 407, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5792), null, 86, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5792), "https://loremflickr.com/800/600?random=9445" },
                    { 424, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5966), null, 91, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5966), "https://loremflickr.com/800/900?random=9443" },
                    { 425, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5968), null, 91, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5968), "https://loremflickr.com/800/768?random=9808" },
                    { 426, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5969), null, 91, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5969), "https://loremflickr.com/1200/900?random=9841" },
                    { 427, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5971), null, 91, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5971), "https://loremflickr.com/1024/768?random=9858" },
                    { 428, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6005), null, 92, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6005), "https://loremflickr.com/800/768?random=9247" },
                    { 429, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6006), null, 92, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6007), "https://loremflickr.com/800/768?random=9735" },
                    { 430, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6008), null, 92, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6008), "https://loremflickr.com/800/768?random=9758" },
                    { 431, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6010), null, 92, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6010), "https://loremflickr.com/800/900?random=10178" },
                    { 432, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6039), null, 93, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6039), "https://loremflickr.com/1200/900?random=9363" },
                    { 433, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6041), null, 93, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6041), "https://loremflickr.com/1024/900?random=9636" },
                    { 434, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6043), null, 93, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6043), "https://loremflickr.com/1024/768?random=9612" },
                    { 435, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6044), null, 93, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6044), "https://loremflickr.com/1200/900?random=9608" },
                    { 436, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6065), null, 94, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6065), "https://loremflickr.com/1024/900?random=9878" },
                    { 437, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6070), null, 94, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6071), "https://loremflickr.com/800/768?random=9494" },
                    { 438, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6072), null, 94, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6073), "https://loremflickr.com/1200/900?random=10298" },
                    { 439, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6074), null, 94, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6074), "https://loremflickr.com/1024/768?random=10369" },
                    { 453, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6192), null, 98, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6192), "https://loremflickr.com/800/768?random=10383" },
                    { 454, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6193), null, 98, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6194), "https://loremflickr.com/800/900?random=9811" },
                    { 455, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6195), null, 98, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6196), "https://loremflickr.com/800/900?random=9976" },
                    { 456, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6197), null, 98, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6197), "https://loremflickr.com/1200/900?random=10002" },
                    { 457, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6199), null, 98, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6199), "https://loremflickr.com/800/600?random=10633" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "DeletedAt", "Description", "DormId", "IsActive", "IsAvailable", "IsDeleted", "PricePerMonth", "RoomNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 26, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9769), null, "A cozy and quiet room in Central Dwellings.", 1, true, true, false, 5949m, "Room 100-1", new DateTime(2025, 2, 27, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9787) },
                    { 2, 4, new DateTime(2025, 1, 6, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9844), null, "A newly renovated room in Central Dwellings.", 1, true, true, false, 12821m, "Room 101-1", new DateTime(2025, 2, 27, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9845) },
                    { 3, 1, new DateTime(2025, 1, 23, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9851), null, "A fully furnished room in Central Dwellings.", 1, true, true, false, 11663m, "Room 102-1", new DateTime(2025, 2, 27, 14, 35, 27, 255, DateTimeKind.Local).AddTicks(9852) },
                    { 4, 3, new DateTime(2024, 11, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1948), null, "A spacious and airy room in Central Residences.", 2, true, true, false, 5485m, "Room 100-2", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1949) },
                    { 5, 3, new DateTime(2024, 9, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1953), null, "A modern and stylish room in Central Residences.", 2, true, true, false, 9394m, "Room 101-2", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1954) },
                    { 6, 1, new DateTime(2024, 3, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1962), null, "A spacious and airy room in Central Residences.", 2, true, true, false, 8769m, "Room 102-2", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1963) },
                    { 7, 2, new DateTime(2024, 11, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1967), null, "A modern and stylish room in Central Residences.", 2, true, true, false, 5527m, "Room 103-2", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1968) },
                    { 8, 2, new DateTime(2024, 8, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1975), null, "A newly renovated room in Central Residences.", 2, true, true, false, 7387m, "Room 104-2", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(1976) },
                    { 9, 2, new DateTime(2024, 6, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2054), null, "A spacious and airy room in Green Quarters.", 3, true, true, false, 12142m, "Room 100-3", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2055) },
                    { 10, 3, new DateTime(2024, 8, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2059), null, "A charming and homey room in Green Quarters.", 3, true, true, false, 11328m, "Room 101-3", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2060) },
                    { 11, 3, new DateTime(2024, 6, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2093), null, "A cozy and quiet room in Purple Lodgings.", 4, true, true, false, 5440m, "Room 100-4", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2093) },
                    { 12, 2, new DateTime(2024, 4, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2097), null, "A comfortable and well-lit room in Purple Lodgings.", 4, true, true, false, 14490m, "Room 101-4", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2098) },
                    { 13, 2, new DateTime(2024, 7, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2102), null, "A functional and practical room in Purple Lodgings.", 4, true, true, false, 8565m, "Room 102-4", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2102) },
                    { 14, 2, new DateTime(2025, 2, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2106), null, "A cozy and quiet room in Purple Lodgings.", 4, true, true, false, 10450m, "Room 103-4", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2106) },
                    { 15, 3, new DateTime(2024, 7, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2110), null, "A fully furnished room in Purple Lodgings.", 4, true, true, false, 7548m, "Room 104-4", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2111) },
                    { 21, 4, new DateTime(2025, 2, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2225), null, "A charming and homey room in Silver Lodgings.", 6, true, true, false, 12614m, "Room 100-6", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2226) },
                    { 22, 3, new DateTime(2024, 8, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2231), null, "A functional and practical room in Silver Lodgings.", 6, true, true, false, 13461m, "Room 101-6", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2232) },
                    { 23, 3, new DateTime(2025, 1, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2238), null, "A bright and cheerful room in Silver Lodgings.", 6, true, true, false, 12104m, "Room 102-6", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2239) },
                    { 24, 2, new DateTime(2024, 12, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2243), null, "A newly renovated room in Silver Lodgings.", 6, true, true, false, 9228m, "Room 103-6", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2244) },
                    { 25, 3, new DateTime(2024, 4, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2250), null, "A functional and practical room in Silver Lodgings.", 6, true, true, false, 6769m, "Room 104-6", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2251) },
                    { 26, 4, new DateTime(2024, 9, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2296), null, "A fully furnished room in Blue Place.", 7, true, true, false, 6636m, "Room 100-7", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2297) },
                    { 27, 2, new DateTime(2024, 7, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2303), null, "A fully furnished room in Blue Place.", 7, true, true, false, 11344m, "Room 101-7", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2304) },
                    { 28, 4, new DateTime(2024, 9, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2311), null, "A functional and practical room in Blue Place.", 7, true, true, false, 12246m, "Room 102-7", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2312) },
                    { 29, 1, new DateTime(2024, 12, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2346), null, "A charming and homey room in Green Quarters.", 8, true, true, false, 13195m, "Room 100-8", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2347) },
                    { 30, 1, new DateTime(2025, 2, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2353), null, "A functional and practical room in Green Quarters.", 8, true, true, false, 7545m, "Room 101-8", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2353) },
                    { 31, 4, new DateTime(2025, 1, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2360), null, "A spacious and airy room in Green Quarters.", 8, true, true, false, 5010m, "Room 102-8", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2361) },
                    { 32, 3, new DateTime(2024, 12, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2371), null, "A modern and stylish room in Green Quarters.", 8, true, true, false, 10917m, "Room 103-8", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2371) },
                    { 33, 1, new DateTime(2025, 1, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2377), null, "A bright and cheerful room in Green Quarters.", 8, true, true, false, 4873m, "Room 104-8", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2378) },
                    { 34, 1, new DateTime(2024, 4, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2429), null, "A bright and cheerful room in Royal Hall.", 9, true, true, false, 11161m, "Room 100-9", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2430) },
                    { 35, 4, new DateTime(2025, 1, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2435), null, "A comfortable and well-lit room in Royal Hall.", 9, true, false, false, 14748m, "Room 101-9", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2436) },
                    { 36, 3, new DateTime(2024, 4, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2442), null, "A clean and minimalist room in Royal Hall.", 9, true, true, false, 8012m, "Room 102-9", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2443) },
                    { 37, 2, new DateTime(2024, 10, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2449), null, "A newly renovated room in Royal Hall.", 9, true, true, false, 12452m, "Room 103-9", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2450) },
                    { 38, 1, new DateTime(2024, 11, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2482), null, "A comfortable and well-lit room in Royal House.", 10, true, true, false, 8420m, "Room 100-10", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2483) },
                    { 39, 4, new DateTime(2024, 12, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2486), null, "A charming and homey room in Royal House.", 10, true, true, false, 8566m, "Room 101-10", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2487) },
                    { 40, 2, new DateTime(2024, 11, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2515), null, "A newly renovated room in Crystal Lodgings.", 11, true, true, false, 5979m, "Room 100-11", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2515) },
                    { 41, 4, new DateTime(2024, 10, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2520), null, "A comfortable and well-lit room in Crystal Lodgings.", 11, true, true, false, 10317m, "Room 101-11", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2520) },
                    { 42, 3, new DateTime(2025, 2, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2524), null, "A comfortable and well-lit room in Crystal Lodgings.", 11, true, true, false, 8840m, "Room 102-11", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2524) },
                    { 43, 3, new DateTime(2024, 11, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2528), null, "A functional and practical room in Crystal Lodgings.", 11, true, true, false, 12457m, "Room 103-11", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2529) },
                    { 44, 1, new DateTime(2025, 2, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2558), null, "A modern and stylish room in Green Residences.", 12, true, false, false, 11731m, "Room 100-12", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2558) },
                    { 45, 4, new DateTime(2024, 5, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2562), null, "A newly renovated room in Green Residences.", 12, true, true, false, 12674m, "Room 101-12", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2563) },
                    { 46, 3, new DateTime(2024, 7, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2567), null, "A comfortable and well-lit room in Green Residences.", 12, true, true, false, 13238m, "Room 102-12", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2567) },
                    { 47, 1, new DateTime(2024, 8, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2571), null, "A spacious and airy room in Green Residences.", 12, true, true, false, 11265m, "Room 103-12", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2571) },
                    { 48, 2, new DateTime(2024, 12, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2601), null, "A fully furnished room in Purple Living Spaces.", 13, true, true, false, 8079m, "Room 100-13", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2602) },
                    { 49, 2, new DateTime(2024, 10, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2606), null, "A functional and practical room in Purple Living Spaces.", 13, true, true, false, 8983m, "Room 101-13", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2606) },
                    { 50, 1, new DateTime(2024, 9, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2610), null, "A functional and practical room in Purple Living Spaces.", 13, true, true, false, 8573m, "Room 102-13", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2610) },
                    { 51, 3, new DateTime(2025, 2, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2614), null, "A clean and minimalist room in Purple Living Spaces.", 13, true, true, false, 5899m, "Room 103-13", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2614) },
                    { 52, 1, new DateTime(2024, 11, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2647), null, "A comfortable and well-lit room in Green Dormitory.", 14, true, true, false, 13201m, "Room 100-14", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2647) },
                    { 53, 3, new DateTime(2024, 7, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2651), null, "A functional and practical room in Green Dormitory.", 14, true, true, false, 11973m, "Room 101-14", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2651) },
                    { 54, 1, new DateTime(2024, 3, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2655), null, "A fully furnished room in Green Dormitory.", 14, true, true, false, 12555m, "Room 102-14", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2655) },
                    { 55, 2, new DateTime(2024, 7, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2664), null, "A spacious and airy room in Green Dormitory.", 14, true, true, false, 4588m, "Room 103-14", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2664) },
                    { 61, 4, new DateTime(2024, 8, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2735), null, "A comfortable and well-lit room in Red Residences.", 16, true, true, false, 13997m, "Room 100-16", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2735) },
                    { 62, 4, new DateTime(2024, 6, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2742), null, "A functional and practical room in Red Residences.", 16, true, true, false, 13213m, "Room 101-16", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2743) },
                    { 63, 4, new DateTime(2024, 8, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2790), null, "A modern and stylish room in Silver House.", 17, true, false, false, 11168m, "Room 100-17", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2791) },
                    { 64, 1, new DateTime(2024, 8, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2797), null, "A functional and practical room in Silver House.", 17, true, true, false, 9721m, "Room 101-17", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2798) },
                    { 65, 4, new DateTime(2024, 10, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2803), null, "A fully furnished room in Silver House.", 17, true, true, false, 13301m, "Room 102-17", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2804) },
                    { 66, 3, new DateTime(2024, 5, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2812), null, "A cozy and quiet room in Silver House.", 17, true, true, false, 9504m, "Room 103-17", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2813) },
                    { 67, 1, new DateTime(2024, 6, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2854), null, "A cozy and quiet room in Elite Residences.", 18, true, true, false, 4762m, "Room 100-18", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2855) },
                    { 68, 2, new DateTime(2025, 2, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2861), null, "A charming and homey room in Elite Residences.", 18, true, true, false, 13145m, "Room 101-18", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2862) },
                    { 69, 1, new DateTime(2024, 8, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2895), null, "A clean and minimalist room in Red Dormitory.", 19, true, true, false, 13581m, "Room 100-19", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2895) },
                    { 70, 4, new DateTime(2024, 6, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2901), null, "A charming and homey room in Red Dormitory.", 19, true, true, false, 13740m, "Room 101-19", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2902) },
                    { 71, 3, new DateTime(2024, 9, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2907), null, "A bright and cheerful room in Red Dormitory.", 19, true, true, false, 6251m, "Room 102-19", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2908) },
                    { 72, 3, new DateTime(2024, 8, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2914), null, "A clean and minimalist room in Red Dormitory.", 19, true, false, false, 5896m, "Room 103-19", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2914) },
                    { 73, 4, new DateTime(2024, 10, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2954), null, "A comfortable and well-lit room in Orange Hall.", 20, true, true, false, 10368m, "Room 100-20", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2955) },
                    { 74, 3, new DateTime(2024, 5, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2960), null, "A charming and homey room in Orange Hall.", 20, true, true, false, 11652m, "Room 101-20", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2961) },
                    { 75, 1, new DateTime(2024, 6, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2967), null, "A functional and practical room in Orange Hall.", 20, true, true, false, 5214m, "Room 102-20", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2969) },
                    { 76, 3, new DateTime(2024, 6, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3004), null, "A functional and practical room in Royal House.", 21, true, true, false, 10254m, "Room 100-21", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3005) },
                    { 77, 4, new DateTime(2024, 4, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3008), null, "A modern and stylish room in Royal House.", 21, true, true, false, 5484m, "Room 101-21", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3009) },
                    { 78, 1, new DateTime(2024, 8, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3012), null, "A modern and stylish room in Royal House.", 21, true, true, false, 14705m, "Room 102-21", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3013) },
                    { 79, 4, new DateTime(2024, 10, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3017), null, "A modern and stylish room in Royal House.", 21, true, true, false, 11136m, "Room 103-21", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3017) },
                    { 80, 3, new DateTime(2025, 1, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3050), null, "A clean and minimalist room in Central Residences.", 22, true, false, false, 6840m, "Room 100-22", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3051) },
                    { 81, 3, new DateTime(2024, 6, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3054), null, "A comfortable and well-lit room in Central Residences.", 22, true, true, false, 13120m, "Room 101-22", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3055) },
                    { 82, 1, new DateTime(2024, 6, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3058), null, "A functional and practical room in Central Residences.", 22, true, true, false, 9996m, "Room 102-22", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3059) },
                    { 83, 1, new DateTime(2025, 2, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3063), null, "A fully furnished room in Central Residences.", 22, true, false, false, 8591m, "Room 103-22", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3064) },
                    { 84, 1, new DateTime(2025, 2, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3067), null, "A fully furnished room in Central Residences.", 22, true, true, false, 6488m, "Room 104-22", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3068) },
                    { 85, 2, new DateTime(2025, 1, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3091), null, "A fully furnished room in Green House.", 23, true, true, false, 12422m, "Room 100-23", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3092) },
                    { 86, 1, new DateTime(2024, 3, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3096), null, "A modern and stylish room in Green House.", 23, true, true, false, 11060m, "Room 101-23", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3096) },
                    { 87, 1, new DateTime(2025, 2, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3100), null, "A modern and stylish room in Green House.", 23, true, false, false, 10958m, "Room 102-23", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3100) },
                    { 88, 2, new DateTime(2024, 10, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3104), null, "A clean and minimalist room in Green House.", 23, true, true, false, 12520m, "Room 103-23", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3104) },
                    { 92, 4, new DateTime(2024, 8, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3168), null, "A comfortable and well-lit room in Orange Dwellings.", 25, true, true, false, 11201m, "Room 100-25", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3169) },
                    { 93, 3, new DateTime(2024, 11, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3172), null, "A charming and homey room in Orange Dwellings.", 25, true, true, false, 10716m, "Room 101-25", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3173) },
                    { 94, 4, new DateTime(2024, 3, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3176), null, "A clean and minimalist room in Orange Dwellings.", 25, true, true, false, 13652m, "Room 102-25", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3177) },
                    { 95, 2, new DateTime(2024, 12, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3181), null, "A comfortable and well-lit room in Orange Dwellings.", 25, true, true, false, 14850m, "Room 103-25", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3181) },
                    { 96, 1, new DateTime(2025, 1, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3185), null, "A functional and practical room in Orange Dwellings.", 25, true, true, false, 12962m, "Room 104-25", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3185) },
                    { 97, 4, new DateTime(2024, 10, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3220), null, "A bright and cheerful room in Orange Living Spaces.", 26, true, true, false, 10755m, "Room 100-26", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3220) },
                    { 98, 4, new DateTime(2025, 1, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3226), null, "A spacious and airy room in Orange Living Spaces.", 26, true, true, false, 7318m, "Room 101-26", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3227) },
                    { 99, 1, new DateTime(2024, 6, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3233), null, "A comfortable and well-lit room in Orange Living Spaces.", 26, true, true, false, 14520m, "Room 102-26", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3234) },
                    { 100, 3, new DateTime(2025, 2, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3240), null, "A bright and cheerful room in Orange Living Spaces.", 26, true, true, false, 4557m, "Room 103-26", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3240) },
                    { 101, 3, new DateTime(2024, 7, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3247), null, "A spacious and airy room in Orange Living Spaces.", 26, true, true, false, 9711m, "Room 104-26", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3247) },
                    { 102, 3, new DateTime(2024, 4, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3277), null, "A cozy and quiet room in Red House.", 27, true, true, false, 10331m, "Room 100-27", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3278) },
                    { 103, 2, new DateTime(2024, 12, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3282), null, "A comfortable and well-lit room in Red House.", 27, true, true, false, 10640m, "Room 101-27", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3283) },
                    { 104, 4, new DateTime(2024, 8, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3290), null, "A modern and stylish room in Red House.", 27, true, true, false, 14434m, "Room 102-27", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3290) },
                    { 105, 2, new DateTime(2024, 11, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3301), null, "A charming and homey room in Red House.", 27, true, false, false, 10342m, "Room 103-27", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3302) },
                    { 106, 4, new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3307), null, "A bright and cheerful room in Red House.", 27, true, true, false, 12404m, "Room 104-27", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3308) },
                    { 107, 4, new DateTime(2025, 1, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3343), null, "A charming and homey room in Silver Suites.", 28, true, false, false, 10663m, "Room 100-28", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3343) },
                    { 108, 2, new DateTime(2025, 1, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3349), null, "A modern and stylish room in Silver Suites.", 28, true, true, false, 7995m, "Room 101-28", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3350) },
                    { 109, 2, new DateTime(2024, 8, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3355), null, "A clean and minimalist room in Silver Suites.", 28, true, true, false, 5099m, "Room 102-28", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3356) },
                    { 110, 4, new DateTime(2025, 2, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3362), null, "A modern and stylish room in Silver Suites.", 28, true, true, false, 7597m, "Room 103-28", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3362) },
                    { 111, 3, new DateTime(2024, 12, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3412), null, "A comfortable and well-lit room in Crystal Hall.", 29, true, true, false, 12557m, "Room 100-29", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3413) },
                    { 112, 1, new DateTime(2024, 3, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3419), null, "A fully furnished room in Crystal Hall.", 29, true, true, false, 8956m, "Room 101-29", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3420) },
                    { 113, 4, new DateTime(2024, 11, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3427), null, "A fully furnished room in Crystal Hall.", 29, true, true, false, 7573m, "Room 102-29", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3428) },
                    { 114, 1, new DateTime(2025, 2, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3434), null, "A bright and cheerful room in Crystal Hall.", 29, true, true, false, 11665m, "Room 103-29", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3435) },
                    { 115, 1, new DateTime(2024, 10, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3441), null, "A fully furnished room in Crystal Hall.", 29, true, true, false, 9952m, "Room 104-29", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3442) },
                    { 116, 4, new DateTime(2025, 1, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3492), null, "A charming and homey room in Green Dormitory.", 30, true, false, false, 13860m, "Room 100-30", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3493) },
                    { 117, 1, new DateTime(2024, 4, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3497), null, "A spacious and airy room in Green Dormitory.", 30, true, true, false, 12365m, "Room 101-30", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3498) },
                    { 118, 2, new DateTime(2024, 4, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3502), null, "A newly renovated room in Green Dormitory.", 30, true, true, false, 11773m, "Room 102-30", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3503) },
                    { 119, 1, new DateTime(2024, 4, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3511), null, "A cozy and quiet room in Green Dormitory.", 30, true, true, false, 5561m, "Room 103-30", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3512) },
                    { 120, 3, new DateTime(2024, 4, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3515), null, "A newly renovated room in Green Dormitory.", 30, true, true, false, 5132m, "Room 104-30", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3516) },
                    { 121, 4, new DateTime(2024, 4, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3543), null, "A fully furnished room in Orange Living Spaces.", 31, true, true, false, 10741m, "Room 100-31", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3544) },
                    { 122, 3, new DateTime(2025, 2, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3548), null, "A comfortable and well-lit room in Orange Living Spaces.", 31, true, true, false, 8911m, "Room 101-31", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3548) },
                    { 123, 3, new DateTime(2025, 1, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3552), null, "A fully furnished room in Orange Living Spaces.", 31, true, true, false, 9824m, "Room 102-31", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3553) },
                    { 124, 3, new DateTime(2024, 8, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3577), null, "A charming and homey room in Premium Dwellings.", 32, true, false, false, 13163m, "Room 100-32", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3578) },
                    { 125, 3, new DateTime(2024, 7, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3581), null, "A functional and practical room in Premium Dwellings.", 32, true, true, false, 10828m, "Room 101-32", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3582) },
                    { 126, 4, new DateTime(2024, 6, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3590), null, "A clean and minimalist room in Premium Dwellings.", 32, true, true, false, 11958m, "Room 102-32", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3590) },
                    { 127, 2, new DateTime(2024, 11, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3594), null, "A bright and cheerful room in Premium Dwellings.", 32, true, true, false, 4948m, "Room 103-32", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3594) },
                    { 128, 4, new DateTime(2024, 6, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3598), null, "A functional and practical room in Premium Dwellings.", 32, true, true, false, 11365m, "Room 104-32", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3598) },
                    { 129, 3, new DateTime(2024, 4, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3623), null, "A functional and practical room in Silver Place.", 33, true, true, false, 10100m, "Room 100-33", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3624) },
                    { 130, 3, new DateTime(2024, 3, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3628), null, "A bright and cheerful room in Silver Place.", 33, true, true, false, 14291m, "Room 101-33", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3629) },
                    { 131, 2, new DateTime(2024, 3, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3633), null, "A bright and cheerful room in Silver Place.", 33, true, true, false, 11177m, "Room 102-33", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3633) },
                    { 132, 3, new DateTime(2024, 8, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3637), null, "A modern and stylish room in Silver Place.", 33, true, true, false, 9656m, "Room 103-33", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3637) },
                    { 133, 2, new DateTime(2024, 11, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3641), null, "A clean and minimalist room in Silver Place.", 33, true, true, false, 13224m, "Room 104-33", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3641) },
                    { 134, 4, new DateTime(2024, 6, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3672), null, "A newly renovated room in Green Living Spaces.", 34, true, true, false, 6602m, "Room 100-34", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3673) },
                    { 135, 4, new DateTime(2024, 3, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3677), null, "A fully furnished room in Green Living Spaces.", 34, true, false, false, 9239m, "Room 101-34", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3677) },
                    { 136, 2, new DateTime(2025, 1, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3681), null, "A newly renovated room in Green Living Spaces.", 34, true, true, false, 10512m, "Room 102-34", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3682) },
                    { 137, 3, new DateTime(2024, 12, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3685), null, "A functional and practical room in Green Living Spaces.", 34, true, true, false, 8698m, "Room 103-34", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3686) },
                    { 143, 3, new DateTime(2024, 8, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3750), null, "A fully furnished room in Grand Dormitory.", 36, true, true, false, 7862m, "Room 100-36", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3751) },
                    { 144, 4, new DateTime(2025, 1, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3754), null, "A spacious and airy room in Grand Dormitory.", 36, true, true, false, 11777m, "Room 101-36", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3756) },
                    { 145, 1, new DateTime(2024, 11, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3763), null, "A cozy and quiet room in Grand Dormitory.", 36, true, true, false, 8889m, "Room 102-36", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3764) },
                    { 146, 1, new DateTime(2025, 1, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3769), null, "A cozy and quiet room in Grand Dormitory.", 36, true, true, false, 13926m, "Room 103-36", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3770) },
                    { 147, 2, new DateTime(2024, 9, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3803), null, "A charming and homey room in Blue House.", 37, true, true, false, 11211m, "Room 100-37", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3804) },
                    { 148, 2, new DateTime(2024, 11, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3810), null, "A fully furnished room in Blue House.", 37, true, false, false, 6913m, "Room 101-37", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3811) },
                    { 152, 2, new DateTime(2024, 9, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3905), null, "A comfortable and well-lit room in Royal Living Spaces.", 39, true, true, false, 14219m, "Room 100-39", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3905) },
                    { 153, 4, new DateTime(2025, 2, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3910), null, "A comfortable and well-lit room in Royal Living Spaces.", 39, true, false, false, 12178m, "Room 101-39", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3911) },
                    { 154, 4, new DateTime(2024, 9, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3958), null, "A functional and practical room in Orange Suites.", 40, true, true, false, 8528m, "Room 100-40", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3958) },
                    { 155, 3, new DateTime(2024, 5, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3964), null, "A functional and practical room in Orange Suites.", 40, true, true, false, 10129m, "Room 101-40", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3965) },
                    { 156, 3, new DateTime(2024, 11, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3970), null, "A spacious and airy room in Orange Suites.", 40, true, false, false, 10446m, "Room 102-40", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3971) },
                    { 157, 4, new DateTime(2025, 2, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3999), null, "A bright and cheerful room in Central Living Spaces.", 41, true, true, false, 5447m, "Room 100-41", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3999) },
                    { 158, 2, new DateTime(2025, 2, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4003), null, "A newly renovated room in Central Living Spaces.", 41, true, true, false, 12964m, "Room 101-41", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4004) },
                    { 159, 2, new DateTime(2024, 8, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4008), null, "A fully furnished room in Central Living Spaces.", 41, true, true, false, 6793m, "Room 102-41", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4008) },
                    { 160, 3, new DateTime(2024, 8, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4012), null, "A modern and stylish room in Central Living Spaces.", 41, true, true, false, 5426m, "Room 103-41", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4013) },
                    { 161, 3, new DateTime(2024, 8, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4016), null, "A modern and stylish room in Central Living Spaces.", 41, true, true, false, 6158m, "Room 104-41", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4017) },
                    { 162, 3, new DateTime(2024, 10, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4049), null, "A clean and minimalist room in Crystal House.", 42, true, true, false, 9376m, "Room 100-42", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4049) },
                    { 163, 4, new DateTime(2024, 7, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4053), null, "A modern and stylish room in Crystal House.", 42, true, false, false, 14780m, "Room 101-42", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4053) },
                    { 164, 1, new DateTime(2024, 4, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4057), null, "A clean and minimalist room in Crystal House.", 42, true, true, false, 15403m, "Room 102-42", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4057) },
                    { 165, 4, new DateTime(2024, 6, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4061), null, "A functional and practical room in Crystal House.", 42, true, true, false, 6175m, "Room 103-42", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4061) },
                    { 166, 2, new DateTime(2024, 7, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4087), null, "A newly renovated room in Royal Lodgings.", 43, true, true, false, 9945m, "Room 100-43", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4088) },
                    { 167, 4, new DateTime(2024, 10, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4092), null, "A cozy and quiet room in Royal Lodgings.", 43, true, true, false, 5972m, "Room 101-43", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4092) },
                    { 171, 2, new DateTime(2024, 2, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4161), null, "A clean and minimalist room in Golden Place.", 45, true, true, false, 10905m, "Room 100-45", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4161) },
                    { 172, 1, new DateTime(2024, 3, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4165), null, "A charming and homey room in Golden Place.", 45, true, true, false, 10010m, "Room 101-45", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4166) },
                    { 173, 4, new DateTime(2024, 9, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4169), null, "A bright and cheerful room in Golden Place.", 45, true, true, false, 12260m, "Room 102-45", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4170) },
                    { 174, 4, new DateTime(2024, 12, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4174), null, "A bright and cheerful room in Golden Place.", 45, true, true, false, 12018m, "Room 103-45", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4174) },
                    { 175, 1, new DateTime(2024, 4, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4194), null, "A newly renovated room in Purple Lodgings.", 46, true, true, false, 6371m, "Room 100-46", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4195) },
                    { 176, 1, new DateTime(2024, 5, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4198), null, "A newly renovated room in Purple Lodgings.", 46, true, false, false, 6765m, "Room 101-46", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4199) },
                    { 177, 3, new DateTime(2024, 12, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4202), null, "A modern and stylish room in Purple Lodgings.", 46, true, true, false, 11042m, "Room 102-46", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4203) },
                    { 178, 3, new DateTime(2024, 3, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4222), null, "A fully furnished room in Superior Dwellings.", 47, true, true, false, 10502m, "Room 100-47", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4222) },
                    { 179, 1, new DateTime(2024, 12, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4226), null, "A charming and homey room in Superior Dwellings.", 47, true, true, false, 15035m, "Room 101-47", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4226) },
                    { 180, 4, new DateTime(2024, 9, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4233), null, "A comfortable and well-lit room in Superior Dwellings.", 47, true, false, false, 11342m, "Room 102-47", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4234) },
                    { 181, 2, new DateTime(2024, 12, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4238), null, "A charming and homey room in Superior Dwellings.", 47, true, true, false, 12948m, "Room 103-47", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4238) },
                    { 182, 2, new DateTime(2024, 10, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4242), null, "A modern and stylish room in Superior Dwellings.", 47, true, true, false, 11542m, "Room 104-47", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4242) },
                    { 183, 3, new DateTime(2025, 1, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4263), null, "A cozy and quiet room in Blue Living Spaces.", 48, true, true, false, 12837m, "Room 100-48", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4264) },
                    { 184, 4, new DateTime(2024, 12, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4268), null, "A fully furnished room in Blue Living Spaces.", 48, true, true, false, 13995m, "Room 101-48", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4268) },
                    { 185, 4, new DateTime(2024, 10, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4272), null, "A clean and minimalist room in Blue Living Spaces.", 48, true, true, false, 15106m, "Room 102-48", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4272) },
                    { 186, 3, new DateTime(2024, 11, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4276), null, "A charming and homey room in Blue Living Spaces.", 48, true, true, false, 10338m, "Room 103-48", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4276) },
                    { 187, 4, new DateTime(2024, 10, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4280), null, "A spacious and airy room in Blue Living Spaces.", 48, true, true, false, 9328m, "Room 104-48", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4280) },
                    { 188, 2, new DateTime(2024, 12, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4303), null, "A cozy and quiet room in Premium Place.", 49, true, true, false, 11175m, "Room 100-49", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4304) },
                    { 189, 4, new DateTime(2024, 12, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4313), null, "A fully furnished room in Premium Place.", 49, true, true, false, 12797m, "Room 101-49", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4313) },
                    { 190, 2, new DateTime(2024, 6, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4345), null, "A spacious and airy room in Orange House.", 50, true, true, false, 6194m, "Room 100-50", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4346) },
                    { 191, 2, new DateTime(2024, 7, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4352), null, "A comfortable and well-lit room in Orange House.", 50, true, true, false, 7257m, "Room 101-50", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4353) },
                    { 192, 1, new DateTime(2024, 6, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4358), null, "A charming and homey room in Orange House.", 50, true, true, false, 9931m, "Room 102-50", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4359) },
                    { 193, 2, new DateTime(2024, 7, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4397), null, "A fully furnished room in Elite Hall.", 51, true, true, false, 12266m, "Room 100-51", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4398) },
                    { 194, 4, new DateTime(2024, 10, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4404), null, "A modern and stylish room in Elite Hall.", 51, true, true, false, 6096m, "Room 101-51", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4405) },
                    { 195, 2, new DateTime(2025, 1, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4410), null, "A modern and stylish room in Elite Hall.", 51, true, true, false, 6174m, "Room 102-51", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4411) },
                    { 196, 3, new DateTime(2024, 12, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4422), null, "A fully furnished room in Elite Hall.", 51, true, true, false, 13145m, "Room 103-51", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4423) },
                    { 197, 3, new DateTime(2024, 12, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4457), null, "A bright and cheerful room in Premium Dormitory.", 52, true, true, false, 14787m, "Room 100-52", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4457) },
                    { 198, 1, new DateTime(2025, 1, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4463), null, "A modern and stylish room in Premium Dormitory.", 52, true, true, false, 11861m, "Room 101-52", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4464) },
                    { 199, 1, new DateTime(2024, 3, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4469), null, "A comfortable and well-lit room in Premium Dormitory.", 52, true, true, false, 11216m, "Room 102-52", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4470) },
                    { 200, 3, new DateTime(2024, 11, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4476), null, "A spacious and airy room in Premium Dormitory.", 52, true, true, false, 11966m, "Room 103-52", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4477) },
                    { 203, 4, new DateTime(2024, 8, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4563), null, "A spacious and airy room in Superior Residences.", 54, true, true, false, 12677m, "Room 100-54", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4563) },
                    { 204, 4, new DateTime(2024, 7, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4569), null, "A fully furnished room in Superior Residences.", 54, true, true, false, 6893m, "Room 101-54", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4570) },
                    { 205, 4, new DateTime(2025, 1, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4607), null, "A comfortable and well-lit room in Golden Suites.", 55, true, true, false, 10890m, "Room 100-55", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4607) },
                    { 206, 3, new DateTime(2024, 4, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4611), null, "A cozy and quiet room in Golden Suites.", 55, true, true, false, 10304m, "Room 101-55", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4612) },
                    { 207, 2, new DateTime(2024, 11, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4616), null, "A clean and minimalist room in Golden Suites.", 55, true, true, false, 10549m, "Room 102-55", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4616) },
                    { 208, 3, new DateTime(2025, 2, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4620), null, "A fully furnished room in Golden Suites.", 55, true, true, false, 10381m, "Room 103-55", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4621) },
                    { 209, 2, new DateTime(2024, 3, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4655), null, "A comfortable and well-lit room in Elegant Place.", 56, true, false, false, 9043m, "Room 100-56", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4655) },
                    { 210, 4, new DateTime(2025, 1, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4659), null, "A clean and minimalist room in Elegant Place.", 56, true, false, false, 9811m, "Room 101-56", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4659) },
                    { 211, 1, new DateTime(2024, 8, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4663), null, "A comfortable and well-lit room in Elegant Place.", 56, true, true, false, 11013m, "Room 102-56", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4664) },
                    { 212, 4, new DateTime(2025, 1, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4667), null, "A modern and stylish room in Elegant Place.", 56, true, false, false, 12158m, "Room 103-56", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4668) },
                    { 213, 4, new DateTime(2024, 11, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4675), null, "A cozy and quiet room in Elegant Place.", 56, true, true, false, 14996m, "Room 104-56", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4676) },
                    { 214, 4, new DateTime(2025, 1, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4699), null, "A newly renovated room in Elegant Suites.", 57, true, false, false, 8608m, "Room 100-57", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4700) },
                    { 215, 4, new DateTime(2024, 4, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4704), null, "A clean and minimalist room in Elegant Suites.", 57, true, true, false, 4790m, "Room 101-57", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4704) },
                    { 216, 3, new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4708), null, "A comfortable and well-lit room in Elegant Suites.", 57, true, true, false, 12002m, "Room 102-57", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4708) },
                    { 217, 2, new DateTime(2024, 12, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4712), null, "A functional and practical room in Elegant Suites.", 57, true, true, false, 13936m, "Room 103-57", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4713) },
                    { 218, 3, new DateTime(2024, 4, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4739), null, "A fully furnished room in Crystal Hall.", 58, true, true, false, 10219m, "Room 100-58", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4740) },
                    { 219, 4, new DateTime(2024, 8, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4743), null, "A spacious and airy room in Crystal Hall.", 58, true, true, false, 6135m, "Room 101-58", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4744) },
                    { 220, 3, new DateTime(2024, 9, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4752), null, "A charming and homey room in Crystal Hall.", 58, true, true, false, 7547m, "Room 102-58", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4752) },
                    { 221, 3, new DateTime(2024, 6, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4756), null, "A clean and minimalist room in Crystal Hall.", 58, true, true, false, 13623m, "Room 103-58", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4757) },
                    { 222, 4, new DateTime(2024, 5, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4780), null, "A bright and cheerful room in Premium Suites.", 59, true, true, false, 8925m, "Room 100-59", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4780) },
                    { 223, 4, new DateTime(2024, 6, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4784), null, "A newly renovated room in Premium Suites.", 59, true, true, false, 12431m, "Room 101-59", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4785) },
                    { 224, 2, new DateTime(2024, 11, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4788), null, "A spacious and airy room in Premium Suites.", 59, true, true, false, 6691m, "Room 102-59", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4789) },
                    { 225, 2, new DateTime(2024, 11, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4792), null, "A spacious and airy room in Premium Suites.", 59, true, true, false, 5858m, "Room 103-59", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4793) },
                    { 226, 4, new DateTime(2025, 2, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4796), null, "A charming and homey room in Premium Suites.", 59, true, true, false, 11894m, "Room 104-59", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4797) },
                    { 227, 4, new DateTime(2024, 6, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4826), null, "A newly renovated room in Elite Suites.", 60, true, true, false, 13359m, "Room 100-60", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4827) },
                    { 228, 1, new DateTime(2024, 9, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4830), null, "A comfortable and well-lit room in Elite Suites.", 60, true, true, false, 5133m, "Room 101-60", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4831) },
                    { 229, 1, new DateTime(2024, 10, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4835), null, "A cozy and quiet room in Elite Suites.", 60, true, true, false, 7860m, "Room 102-60", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4835) },
                    { 230, 2, new DateTime(2025, 1, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4838), null, "A spacious and airy room in Elite Suites.", 60, true, true, false, 11517m, "Room 103-60", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4839) },
                    { 235, 4, new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4906), null, "A clean and minimalist room in Grand Lodgings.", 62, true, true, false, 13701m, "Room 100-62", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4907) },
                    { 236, 2, new DateTime(2024, 5, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4911), null, "A newly renovated room in Grand Lodgings.", 62, true, true, false, 13834m, "Room 101-62", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4911) },
                    { 237, 2, new DateTime(2024, 4, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4915), null, "A modern and stylish room in Grand Lodgings.", 62, true, true, false, 9884m, "Room 102-62", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4915) },
                    { 238, 3, new DateTime(2024, 10, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4919), null, "A bright and cheerful room in Grand Lodgings.", 62, true, true, false, 14119m, "Room 103-62", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4919) },
                    { 239, 3, new DateTime(2024, 5, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4923), null, "A newly renovated room in Grand Lodgings.", 62, true, true, false, 14738m, "Room 104-62", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4923) },
                    { 240, 1, new DateTime(2024, 8, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4945), null, "A clean and minimalist room in Central Place.", 63, true, true, false, 12255m, "Room 100-63", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4945) },
                    { 241, 3, new DateTime(2024, 6, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4949), null, "A newly renovated room in Central Place.", 63, true, true, false, 9065m, "Room 101-63", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4949) },
                    { 242, 2, new DateTime(2024, 6, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4953), null, "A cozy and quiet room in Central Place.", 63, true, true, false, 9821m, "Room 102-63", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4954) },
                    { 243, 1, new DateTime(2024, 6, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4957), null, "A functional and practical room in Central Place.", 63, true, true, false, 12760m, "Room 103-63", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4958) },
                    { 253, 3, new DateTime(2024, 6, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5064), null, "A newly renovated room in Central Suites.", 66, true, true, false, 13972m, "Room 100-66", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5065) },
                    { 254, 4, new DateTime(2024, 4, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5068), null, "A charming and homey room in Central Suites.", 66, true, true, false, 9067m, "Room 101-66", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5069) },
                    { 255, 3, new DateTime(2024, 6, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5090), null, "A charming and homey room in Red Dormitory.", 67, true, false, false, 10016m, "Room 100-67", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5091) },
                    { 256, 3, new DateTime(2024, 3, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5095), null, "A cozy and quiet room in Red Dormitory.", 67, true, true, false, 10804m, "Room 101-67", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5095) },
                    { 257, 4, new DateTime(2024, 8, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5099), null, "A bright and cheerful room in Red Dormitory.", 67, true, true, false, 8498m, "Room 102-67", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5099) },
                    { 258, 4, new DateTime(2024, 4, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5127), null, "A fully furnished room in Orange Suites.", 68, true, true, false, 6752m, "Room 100-68", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5128) },
                    { 259, 4, new DateTime(2025, 1, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5132), null, "A cozy and quiet room in Orange Suites.", 68, true, true, false, 7606m, "Room 101-68", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5132) },
                    { 260, 4, new DateTime(2024, 10, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5136), null, "A clean and minimalist room in Orange Suites.", 68, true, true, false, 9681m, "Room 102-68", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5137) },
                    { 261, 4, new DateTime(2025, 1, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5140), null, "A fully furnished room in Orange Suites.", 68, true, true, false, 7011m, "Room 103-68", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5141) },
                    { 262, 3, new DateTime(2025, 1, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5171), null, "A functional and practical room in Orange Lodgings.", 69, true, true, false, 6910m, "Room 100-69", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5171) },
                    { 263, 1, new DateTime(2024, 5, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5174), null, "A modern and stylish room in Orange Lodgings.", 69, true, false, false, 6340m, "Room 101-69", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5175) },
                    { 264, 2, new DateTime(2024, 4, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5179), null, "A fully furnished room in Orange Lodgings.", 69, true, true, false, 8500m, "Room 102-69", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5180) },
                    { 265, 2, new DateTime(2024, 6, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5183), null, "A functional and practical room in Orange Lodgings.", 69, true, true, false, 10097m, "Room 103-69", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5184) },
                    { 266, 1, new DateTime(2024, 3, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5187), null, "A newly renovated room in Orange Lodgings.", 69, true, true, false, 12261m, "Room 104-69", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5188) },
                    { 267, 1, new DateTime(2024, 7, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5210), null, "A newly renovated room in Silver Dwellings.", 70, true, true, false, 7598m, "Room 100-70", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5211) },
                    { 268, 2, new DateTime(2024, 12, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5214), null, "A fully furnished room in Silver Dwellings.", 70, true, true, false, 5884m, "Room 101-70", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5215) },
                    { 269, 4, new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5218), null, "A bright and cheerful room in Silver Dwellings.", 70, true, true, false, 11648m, "Room 102-70", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5219) },
                    { 270, 3, new DateTime(2024, 11, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5222), null, "A bright and cheerful room in Silver Dwellings.", 70, true, true, false, 11236m, "Room 103-70", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5223) },
                    { 273, 3, new DateTime(2024, 7, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5276), null, "A comfortable and well-lit room in Blue Living Spaces.", 72, true, true, false, 15799m, "Room 100-72", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5277) },
                    { 274, 2, new DateTime(2024, 7, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5281), null, "A clean and minimalist room in Blue Living Spaces.", 72, true, true, false, 11863m, "Room 101-72", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5281) },
                    { 275, 2, new DateTime(2024, 7, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5309), null, "A newly renovated room in Orange Living Spaces.", 73, true, true, false, 11096m, "Room 100-73", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5309) },
                    { 276, 1, new DateTime(2024, 6, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5313), null, "A bright and cheerful room in Orange Living Spaces.", 73, true, true, false, 6232m, "Room 101-73", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5314) },
                    { 277, 4, new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5317), null, "A modern and stylish room in Orange Living Spaces.", 73, true, true, false, 13486m, "Room 102-73", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5318) },
                    { 278, 3, new DateTime(2024, 12, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5321), null, "A comfortable and well-lit room in Orange Living Spaces.", 73, true, true, false, 4539m, "Room 103-73", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5322) },
                    { 279, 3, new DateTime(2024, 3, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5341), null, "A cozy and quiet room in Blue Suites.", 74, true, true, false, 6657m, "Room 100-74", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5342) },
                    { 280, 1, new DateTime(2024, 10, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5346), null, "A bright and cheerful room in Blue Suites.", 74, true, true, false, 9713m, "Room 101-74", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5346) },
                    { 281, 2, new DateTime(2024, 11, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5350), null, "A newly renovated room in Blue Suites.", 74, true, true, false, 8770m, "Room 102-74", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5350) },
                    { 282, 4, new DateTime(2024, 10, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5382), null, "A charming and homey room in Central Residences.", 75, true, false, false, 6460m, "Room 100-75", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5383) },
                    { 283, 4, new DateTime(2024, 7, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5387), null, "A cozy and quiet room in Central Residences.", 75, true, true, false, 7432m, "Room 101-75", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5387) },
                    { 284, 4, new DateTime(2024, 10, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5391), null, "A charming and homey room in Central Residences.", 75, true, true, false, 5945m, "Room 102-75", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5391) },
                    { 285, 1, new DateTime(2025, 2, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5414), null, "A comfortable and well-lit room in Silver Quarters.", 76, true, true, false, 12694m, "Room 100-76", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5415) },
                    { 286, 1, new DateTime(2024, 12, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5419), null, "A fully furnished room in Silver Quarters.", 76, true, false, false, 8455m, "Room 101-76", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5419) },
                    { 287, 2, new DateTime(2024, 9, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5423), null, "A fully furnished room in Silver Quarters.", 76, true, true, false, 11214m, "Room 102-76", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5423) },
                    { 288, 4, new DateTime(2024, 7, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5447), null, "A cozy and quiet room in Orange Dormitory.", 77, true, true, false, 13774m, "Room 100-77", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5448) },
                    { 289, 2, new DateTime(2024, 10, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5451), null, "A charming and homey room in Orange Dormitory.", 77, true, true, false, 10602m, "Room 101-77", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5452) },
                    { 290, 4, new DateTime(2024, 10, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5456), null, "A comfortable and well-lit room in Orange Dormitory.", 77, true, true, false, 13615m, "Room 102-77", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5456) },
                    { 291, 1, new DateTime(2024, 6, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5460), null, "A cozy and quiet room in Orange Dormitory.", 77, true, true, false, 8689m, "Room 103-77", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5460) },
                    { 292, 4, new DateTime(2024, 10, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5464), null, "A charming and homey room in Orange Dormitory.", 77, true, true, false, 8984m, "Room 104-77", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5464) },
                    { 293, 4, new DateTime(2024, 10, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5488), null, "A newly renovated room in Elite Living Spaces.", 78, true, true, false, 14265m, "Room 100-78", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5489) },
                    { 294, 4, new DateTime(2025, 2, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5492), null, "A functional and practical room in Elite Living Spaces.", 78, true, false, false, 9420m, "Room 101-78", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5493) },
                    { 295, 1, new DateTime(2025, 2, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5517), null, "A clean and minimalist room in Green Dwellings.", 79, true, true, false, 8507m, "Room 100-79", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5517) },
                    { 296, 2, new DateTime(2024, 8, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5521), null, "A newly renovated room in Green Dwellings.", 79, true, true, false, 7894m, "Room 101-79", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5522) },
                    { 297, 3, new DateTime(2024, 4, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5525), null, "A cozy and quiet room in Green Dwellings.", 79, true, true, false, 4441m, "Room 102-79", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5526) },
                    { 298, 3, new DateTime(2024, 6, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5529), null, "A fully furnished room in Green Dwellings.", 79, true, false, false, 8494m, "Room 103-79", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5530) },
                    { 299, 1, new DateTime(2024, 12, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5551), null, "A comfortable and well-lit room in Purple Suites.", 80, true, true, false, 6302m, "Room 100-80", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5552) },
                    { 300, 2, new DateTime(2024, 6, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5556), null, "A newly renovated room in Purple Suites.", 80, true, true, false, 8637m, "Room 101-80", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5556) },
                    { 301, 4, new DateTime(2024, 5, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5580), null, "A bright and cheerful room in Green House.", 81, true, true, false, 11596m, "Room 100-81", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5581) },
                    { 302, 3, new DateTime(2024, 3, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5588), null, "A charming and homey room in Green House.", 81, true, true, false, 11016m, "Room 101-81", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5589) },
                    { 303, 1, new DateTime(2024, 12, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5610), null, "A newly renovated room in Royal Dwellings.", 82, true, false, false, 14087m, "Room 100-82", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5610) },
                    { 304, 4, new DateTime(2024, 9, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5614), null, "A charming and homey room in Royal Dwellings.", 82, true, true, false, 11367m, "Room 101-82", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5615) },
                    { 305, 2, new DateTime(2025, 1, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5618), null, "A comfortable and well-lit room in Royal Dwellings.", 82, true, false, false, 13146m, "Room 102-82", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5619) },
                    { 306, 3, new DateTime(2024, 5, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5622), null, "A spacious and airy room in Royal Dwellings.", 82, true, true, false, 8950m, "Room 103-82", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5623) },
                    { 307, 1, new DateTime(2024, 9, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5626), null, "A charming and homey room in Royal Dwellings.", 82, true, true, false, 8675m, "Room 104-82", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5627) },
                    { 315, 2, new DateTime(2024, 8, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5723), null, "A comfortable and well-lit room in Elite Dormitory.", 85, true, true, false, 14889m, "Room 100-85", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5723) },
                    { 316, 2, new DateTime(2024, 8, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5727), null, "A charming and homey room in Elite Dormitory.", 85, true, true, false, 8638m, "Room 101-85", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5727) },
                    { 317, 3, new DateTime(2024, 2, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5731), null, "A fully furnished room in Elite Dormitory.", 85, true, true, false, 8048m, "Room 102-85", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5732) },
                    { 318, 1, new DateTime(2024, 3, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5735), null, "A clean and minimalist room in Elite Dormitory.", 85, true, false, false, 11454m, "Room 103-85", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5735) },
                    { 319, 3, new DateTime(2025, 1, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5744), null, "A clean and minimalist room in Elite Dormitory.", 85, true, true, false, 9929m, "Room 104-85", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5745) },
                    { 320, 1, new DateTime(2024, 9, 7, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5771), null, "A functional and practical room in Blue Dwellings.", 86, true, true, false, 8555m, "Room 100-86", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5772) },
                    { 321, 3, new DateTime(2024, 11, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5775), null, "A charming and homey room in Blue Dwellings.", 86, true, true, false, 12304m, "Room 101-86", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5776) },
                    { 322, 2, new DateTime(2024, 10, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5780), null, "A newly renovated room in Blue Dwellings.", 86, true, true, false, 9930m, "Room 102-86", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5780) },
                    { 336, 2, new DateTime(2024, 12, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5947), null, "A charming and homey room in Superior House.", 91, true, true, false, 13231m, "Room 100-91", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5947) },
                    { 337, 4, new DateTime(2024, 12, 14, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5951), null, "A comfortable and well-lit room in Superior House.", 91, true, true, false, 11280m, "Room 101-91", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5952) },
                    { 338, 3, new DateTime(2024, 10, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5955), null, "A modern and stylish room in Superior House.", 91, true, true, false, 7068m, "Room 102-91", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5955) },
                    { 339, 1, new DateTime(2024, 10, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5959), null, "A newly renovated room in Superior House.", 91, true, false, false, 10261m, "Room 103-91", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5960) },
                    { 340, 4, new DateTime(2024, 12, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5981), null, "A functional and practical room in Purple Living Spaces.", 92, true, true, false, 14774m, "Room 100-92", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5982) },
                    { 341, 3, new DateTime(2024, 4, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5986), null, "A newly renovated room in Purple Living Spaces.", 92, true, true, false, 8369m, "Room 101-92", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5986) },
                    { 342, 3, new DateTime(2024, 5, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5990), null, "A modern and stylish room in Purple Living Spaces.", 92, true, true, false, 14688m, "Room 102-92", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5990) },
                    { 343, 2, new DateTime(2024, 12, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5994), null, "A newly renovated room in Purple Living Spaces.", 92, true, true, false, 12572m, "Room 103-92", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5994) },
                    { 344, 3, new DateTime(2024, 11, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6020), null, "A spacious and airy room in Elegant Hall.", 93, true, true, false, 5270m, "Room 100-93", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6021) },
                    { 345, 2, new DateTime(2024, 9, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6025), null, "A fully furnished room in Elegant Hall.", 93, true, true, false, 7577m, "Room 101-93", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6026) },
                    { 346, 2, new DateTime(2024, 5, 31, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6029), null, "A comfortable and well-lit room in Elegant Hall.", 93, true, true, false, 5385m, "Room 102-93", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6030) },
                    { 347, 4, new DateTime(2025, 2, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6033), null, "A functional and practical room in Elegant Hall.", 93, true, true, false, 9129m, "Room 103-93", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6034) },
                    { 348, 4, new DateTime(2024, 12, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6054), null, "A bright and cheerful room in Purple Hall.", 94, true, true, false, 11511m, "Room 100-94", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6055) },
                    { 349, 2, new DateTime(2024, 5, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6058), null, "A functional and practical room in Purple Hall.", 94, true, true, false, 6098m, "Room 101-94", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6059) },
                    { 359, 1, new DateTime(2024, 3, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6183), null, "A fully furnished room in Central Place.", 98, true, true, false, 5152m, "Room 100-98", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6183) },
                    { 360, 2, new DateTime(2024, 11, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6187), null, "A cozy and quiet room in Central Place.", 98, true, true, false, 14527m, "Room 101-98", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6187) }
                });

            migrationBuilder.InsertData(
                table: "DormAmenities",
                columns: new[] { "Id", "AmenityId", "DeletedAt", "DormId", "IsActive", "IsDeleted" },
                values: new object[,]
                {
                    { 14, 2, null, 5, true, false },
                    { 15, 5, null, 5, true, false },
                    { 16, 1, null, 5, true, false },
                    { 43, 2, null, 15, true, false },
                    { 44, 7, null, 15, true, false },
                    { 71, 8, null, 24, true, false },
                    { 101, 2, null, 35, true, false },
                    { 102, 7, null, 35, true, false },
                    { 109, 1, null, 38, true, false },
                    { 110, 8, null, 38, true, false },
                    { 111, 5, null, 38, true, false },
                    { 128, 5, null, 44, true, false },
                    { 129, 8, null, 44, true, false },
                    { 130, 2, null, 44, true, false },
                    { 131, 7, null, 44, true, false },
                    { 150, 1, null, 53, true, false },
                    { 151, 2, null, 53, true, false },
                    { 152, 7, null, 53, true, false },
                    { 153, 6, null, 53, true, false },
                    { 154, 4, null, 53, true, false },
                    { 177, 2, null, 61, true, false },
                    { 178, 3, null, 61, true, false },
                    { 179, 5, null, 61, true, false },
                    { 186, 7, null, 64, true, false },
                    { 187, 8, null, 64, true, false },
                    { 188, 5, null, 64, true, false },
                    { 189, 6, null, 64, true, false },
                    { 190, 7, null, 65, true, false },
                    { 191, 4, null, 65, true, false },
                    { 204, 8, null, 71, true, false },
                    { 205, 3, null, 71, true, false },
                    { 206, 6, null, 71, true, false },
                    { 234, 1, null, 83, true, false },
                    { 235, 7, null, 83, true, false },
                    { 236, 5, null, 83, true, false },
                    { 237, 6, null, 83, true, false },
                    { 238, 6, null, 84, true, false },
                    { 239, 8, null, 84, true, false },
                    { 240, 5, null, 84, true, false },
                    { 249, 8, null, 87, true, false },
                    { 250, 3, null, 87, true, false },
                    { 251, 6, null, 88, true, false },
                    { 252, 2, null, 88, true, false },
                    { 253, 7, null, 88, true, false },
                    { 254, 1, null, 88, true, false },
                    { 255, 1, null, 89, true, false },
                    { 256, 3, null, 89, true, false },
                    { 257, 6, null, 89, true, false },
                    { 258, 4, null, 89, true, false },
                    { 259, 2, null, 90, true, false },
                    { 260, 8, null, 90, true, false },
                    { 261, 7, null, 90, true, false },
                    { 262, 4, null, 90, true, false },
                    { 276, 8, null, 95, true, false },
                    { 277, 3, null, 95, true, false },
                    { 278, 6, null, 95, true, false },
                    { 279, 4, null, 96, true, false },
                    { 280, 6, null, 96, true, false },
                    { 281, 3, null, 97, true, false },
                    { 282, 7, null, 97, true, false },
                    { 285, 3, null, 99, true, false },
                    { 286, 8, null, 99, true, false },
                    { 287, 4, null, 99, true, false },
                    { 288, 1, null, 99, true, false },
                    { 289, 7, null, 99, true, false },
                    { 290, 8, null, 100, true, false },
                    { 291, 2, null, 100, true, false },
                    { 292, 6, null, 100, true, false },
                    { 293, 7, null, 100, true, false }
                });

            migrationBuilder.InsertData(
                table: "DormTags",
                columns: new[] { "Id", "DeletedAt", "DormId", "IsActive", "IsDeleted", "TagId" },
                values: new object[,]
                {
                    { 8, null, 5, true, false, 8 },
                    { 23, null, 15, true, false, 4 },
                    { 39, null, 24, true, false, 4 },
                    { 40, null, 24, true, false, 5 },
                    { 41, null, 24, true, false, 3 },
                    { 60, null, 35, true, false, 3 },
                    { 61, null, 35, true, false, 1 },
                    { 66, null, 38, true, false, 4 },
                    { 67, null, 38, true, false, 2 },
                    { 68, null, 38, true, false, 7 },
                    { 78, null, 44, true, false, 4 },
                    { 79, null, 44, true, false, 8 },
                    { 92, null, 53, true, false, 8 },
                    { 106, null, 61, true, false, 7 },
                    { 109, null, 64, true, false, 5 },
                    { 110, null, 65, true, false, 1 },
                    { 111, null, 65, true, false, 8 },
                    { 123, null, 71, true, false, 2 },
                    { 124, null, 71, true, false, 7 },
                    { 145, null, 83, true, false, 7 },
                    { 146, null, 84, true, false, 8 },
                    { 147, null, 84, true, false, 2 },
                    { 152, null, 87, true, false, 8 },
                    { 153, null, 87, true, false, 5 },
                    { 154, null, 88, true, false, 5 },
                    { 155, null, 88, true, false, 3 },
                    { 156, null, 88, true, false, 7 },
                    { 157, null, 89, true, false, 6 },
                    { 158, null, 90, true, false, 7 },
                    { 165, null, 95, true, false, 2 },
                    { 166, null, 96, true, false, 4 },
                    { 167, null, 96, true, false, 5 },
                    { 168, null, 97, true, false, 4 },
                    { 169, null, 97, true, false, 8 },
                    { 171, null, 99, true, false, 7 },
                    { 172, null, 99, true, false, 5 },
                    { 173, null, 100, true, false, 4 },
                    { 174, null, 100, true, false, 2 },
                    { 175, null, 100, true, false, 5 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Caption", "CreatedAt", "DeletedAt", "DormId", "IsActive", "IsDeleted", "IsPrimary", "Order", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { 16, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2195), null, 5, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2195), "https://loremflickr.com/1024/600?random=1238" },
                    { 17, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2197), null, 5, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2198), "https://loremflickr.com/1024/900?random=640" },
                    { 18, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2201), null, 5, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2202), "https://loremflickr.com/800/768?random=1099" },
                    { 19, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2204), null, 5, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2205), "https://loremflickr.com/1024/600?random=581" },
                    { 20, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2208), null, 5, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2208), "https://loremflickr.com/800/768?random=1193" },
                    { 21, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2210), null, 5, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2210), "https://loremflickr.com/1024/900?random=1018" },
                    { 66, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2713), null, 15, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2714), "https://loremflickr.com/1024/900?random=1592" },
                    { 67, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2715), null, 15, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2715), "https://loremflickr.com/800/900?random=1834" },
                    { 68, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2717), null, 15, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2717), "https://loremflickr.com/1200/900?random=1794" },
                    { 69, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2718), null, 15, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(2718), "https://loremflickr.com/800/600?random=1599" },
                    { 108, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3151), null, 24, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3151), "https://loremflickr.com/800/768?random=2929" },
                    { 109, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3152), null, 24, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3153), "https://loremflickr.com/800/768?random=3351" },
                    { 110, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3154), null, 24, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3154), "https://loremflickr.com/800/900?random=2682" },
                    { 111, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3155), null, 24, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3155), "https://loremflickr.com/1200/900?random=3219" },
                    { 112, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3157), null, 24, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3157), "https://loremflickr.com/800/600?random=2537" },
                    { 165, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3733), null, 35, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3733), "https://loremflickr.com/1200/900?random=3683" },
                    { 166, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3735), null, 35, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3735), "https://loremflickr.com/800/600?random=4018" },
                    { 167, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3736), null, 35, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3737), "https://loremflickr.com/1024/900?random=4178" },
                    { 168, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3738), null, 35, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3738), "https://loremflickr.com/800/900?random=4020" },
                    { 176, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3876), null, 38, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3876), "https://loremflickr.com/1024/768?random=4310" },
                    { 177, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3878), null, 38, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3878), "https://loremflickr.com/800/900?random=4047" },
                    { 178, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3880), null, 38, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3881), "https://loremflickr.com/800/900?random=4197" },
                    { 179, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3882), null, 38, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3883), "https://loremflickr.com/1200/768?random=4408" },
                    { 180, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3886), null, 38, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3886), "https://loremflickr.com/800/900?random=4516" },
                    { 181, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3888), null, 38, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(3888), "https://loremflickr.com/1024/600?random=3962" },
                    { 205, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4139), null, 44, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4139), "https://loremflickr.com/800/600?random=4426" },
                    { 206, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4140), null, 44, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4141), "https://loremflickr.com/800/600?random=4636" },
                    { 207, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4142), null, 44, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4142), "https://loremflickr.com/800/768?random=5307" },
                    { 208, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4144), null, 44, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4144), "https://loremflickr.com/1024/768?random=4431" },
                    { 209, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4145), null, 44, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4146), "https://loremflickr.com/1200/900?random=5383" },
                    { 246, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4535), null, 53, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4535), "https://loremflickr.com/1024/900?random=5774" },
                    { 247, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4537), null, 53, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4537), "https://loremflickr.com/1024/768?random=6279" },
                    { 248, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4539), null, 53, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4540), "https://loremflickr.com/1024/900?random=5563" },
                    { 249, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4542), null, 53, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4542), "https://loremflickr.com/1024/768?random=5612" },
                    { 250, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4544), null, 53, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4544), "https://loremflickr.com/800/768?random=5526" },
                    { 251, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4546), null, 53, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4547), "https://loremflickr.com/800/768?random=5691" },
                    { 291, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4884), null, 61, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4884), "https://loremflickr.com/800/768?random=6721" },
                    { 292, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4885), null, 61, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4886), "https://loremflickr.com/1200/900?random=6135" },
                    { 293, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4887), null, 61, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4887), "https://loremflickr.com/800/600?random=6572" },
                    { 294, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4888), null, 61, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4889), "https://loremflickr.com/1024/900?random=7047" },
                    { 295, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4890), null, 61, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4890), "https://loremflickr.com/800/900?random=7084" },
                    { 296, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4892), null, 61, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(4892), "https://loremflickr.com/1200/900?random=6232" },
                    { 305, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5004), null, 64, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5005), "https://loremflickr.com/1024/900?random=6929" },
                    { 306, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5006), null, 64, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5006), "https://loremflickr.com/1024/768?random=6598" },
                    { 307, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5007), null, 64, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5008), "https://loremflickr.com/1200/900?random=7031" },
                    { 308, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5049), null, 65, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5049), "https://loremflickr.com/800/900?random=6851" },
                    { 309, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5051), null, 65, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5051), "https://loremflickr.com/1024/900?random=6805" },
                    { 310, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5052), null, 65, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5053), "https://loremflickr.com/1024/900?random=6555" },
                    { 311, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5054), null, 65, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5054), "https://loremflickr.com/1024/768?random=7146" },
                    { 336, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5261), null, 71, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5262), "https://loremflickr.com/1200/768?random=7893" },
                    { 337, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5263), null, 71, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5263), "https://loremflickr.com/1200/900?random=7836" },
                    { 338, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5265), null, 71, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5265), "https://loremflickr.com/1024/768?random=8046" },
                    { 339, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5266), null, 71, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5266), "https://loremflickr.com/1024/600?random=7850" },
                    { 389, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5670), null, 83, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5670), "https://loremflickr.com/1200/600?random=8435" },
                    { 390, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5672), null, 83, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5672), "https://loremflickr.com/1024/900?random=8351" },
                    { 391, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5673), null, 83, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5673), "https://loremflickr.com/1200/600?random=8972" },
                    { 392, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5675), null, 83, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5675), "https://loremflickr.com/1024/600?random=8391" },
                    { 393, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5676), null, 83, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5677), "https://loremflickr.com/1024/900?random=9126" },
                    { 394, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5678), null, 83, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5678), "https://loremflickr.com/800/600?random=8331" },
                    { 395, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5709), null, 84, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5710), "https://loremflickr.com/1200/600?random=8415" },
                    { 396, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5711), null, 84, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5711), "https://loremflickr.com/1200/900?random=8959" },
                    { 397, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5713), null, 84, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5713), "https://loremflickr.com/1024/768?random=8770" },
                    { 408, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5823), null, 87, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5823), "https://loremflickr.com/800/600?random=9060" },
                    { 409, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5824), null, 87, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5825), "https://loremflickr.com/800/768?random=9184" },
                    { 410, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5826), null, 87, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5826), "https://loremflickr.com/1024/768?random=9170" },
                    { 411, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5858), null, 88, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5858), "https://loremflickr.com/800/600?random=8862" },
                    { 412, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5860), null, 88, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5860), "https://loremflickr.com/800/768?random=9264" },
                    { 413, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5861), null, 88, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5861), "https://loremflickr.com/1024/768?random=9450" },
                    { 414, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5863), null, 88, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5863), "https://loremflickr.com/800/768?random=9530" },
                    { 415, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5864), null, 88, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5865), "https://loremflickr.com/1024/900?random=9340" },
                    { 416, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5900), null, 89, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5900), "https://loremflickr.com/1024/600?random=8927" },
                    { 417, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5902), null, 89, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5902), "https://loremflickr.com/800/900?random=9286" },
                    { 418, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5903), null, 89, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5903), "https://loremflickr.com/1200/600?random=9289" },
                    { 419, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5929), null, 90, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5929), "https://loremflickr.com/1024/900?random=9923" },
                    { 420, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5931), null, 90, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5931), "https://loremflickr.com/800/768?random=9908" },
                    { 421, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5932), null, 90, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5933), "https://loremflickr.com/1024/600?random=9972" },
                    { 422, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5934), null, 90, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5934), "https://loremflickr.com/800/900?random=9754" },
                    { 423, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5936), null, 90, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(5936), "https://loremflickr.com/1024/600?random=9533" },
                    { 440, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6096), null, 95, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6096), "https://loremflickr.com/800/768?random=10182" },
                    { 441, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6097), null, 95, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6098), "https://loremflickr.com/1200/900?random=9908" },
                    { 442, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6099), null, 95, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6099), "https://loremflickr.com/800/600?random=10418" },
                    { 443, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6100), null, 95, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6101), "https://loremflickr.com/1024/900?random=9762" },
                    { 444, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6102), null, 95, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6102), "https://loremflickr.com/1200/900?random=9761" },
                    { 445, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6127), null, 96, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6128), "https://loremflickr.com/1024/900?random=9708" },
                    { 446, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6129), null, 96, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6129), "https://loremflickr.com/1024/600?random=10461" },
                    { 447, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6130), null, 96, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6131), "https://loremflickr.com/800/900?random=10015" },
                    { 448, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6166), null, 97, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6167), "https://loremflickr.com/800/900?random=9827" },
                    { 449, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6168), null, 97, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6168), "https://loremflickr.com/1200/600?random=9938" },
                    { 450, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6170), null, 97, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6170), "https://loremflickr.com/800/900?random=10577" },
                    { 451, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6171), null, 97, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6171), "https://loremflickr.com/1200/768?random=9832" },
                    { 452, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6173), null, 97, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6173), "https://loremflickr.com/1200/900?random=9722" },
                    { 458, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6227), null, 99, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6227), "https://loremflickr.com/1024/900?random=10504" },
                    { 459, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6229), null, 99, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6229), "https://loremflickr.com/1200/600?random=10283" },
                    { 460, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6231), null, 99, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6231), "https://loremflickr.com/1024/900?random=10833" },
                    { 461, "Bedroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6232), null, 99, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6232), "https://loremflickr.com/800/900?random=9964" },
                    { 462, "Bathroom", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6234), null, 99, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6234), "https://loremflickr.com/1024/900?random=10558" },
                    { 463, "Additional View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6236), null, 99, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6236), "https://loremflickr.com/1024/600?random=10001" },
                    { 464, "Main View", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6264), null, 100, true, false, true, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6265), "https://loremflickr.com/1024/768?random=10087" },
                    { 465, "Exterior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6266), null, 100, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6266), "https://loremflickr.com/1200/600?random=10433" },
                    { 466, "Interior", new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6268), null, 100, true, false, false, 0, new DateTime(2025, 2, 27, 6, 35, 27, 256, DateTimeKind.Utc).AddTicks(6268), "https://loremflickr.com/800/900?random=10066" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "DeletedAt", "Description", "DormId", "IsActive", "IsAvailable", "IsDeleted", "PricePerMonth", "RoomNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 16, 1, new DateTime(2025, 2, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2151), null, "A cozy and quiet room in Elite Dwellings.", 5, true, true, false, 24480m, "Room 100-5", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2152) },
                    { 17, 1, new DateTime(2024, 10, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2156), null, "A comfortable and well-lit room in Elite Dwellings.", 5, true, true, false, 22153m, "Room 101-5", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2158) },
                    { 18, 2, new DateTime(2025, 1, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2165), null, "A modern and stylish room in Elite Dwellings.", 5, true, true, false, 30990m, "Room 102-5", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2166) },
                    { 19, 4, new DateTime(2024, 7, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2178), null, "A modern and stylish room in Elite Dwellings.", 5, true, true, false, 26683m, "Room 103-5", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2179) },
                    { 20, 4, new DateTime(2025, 2, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2185), null, "A newly renovated room in Elite Dwellings.", 5, true, true, false, 25695m, "Room 104-5", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2186) },
                    { 56, 4, new DateTime(2024, 3, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2692), null, "A bright and cheerful room in Silver Residences.", 15, true, true, false, 19708m, "Room 100-15", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2692) },
                    { 57, 4, new DateTime(2025, 2, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2696), null, "A newly renovated room in Silver Residences.", 15, true, true, false, 34807m, "Room 101-15", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2697) },
                    { 58, 1, new DateTime(2024, 8, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2700), null, "A charming and homey room in Silver Residences.", 15, true, true, false, 21416m, "Room 102-15", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2701) },
                    { 59, 2, new DateTime(2024, 9, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2704), null, "A modern and stylish room in Silver Residences.", 15, true, true, false, 33738m, "Room 103-15", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2705) },
                    { 60, 1, new DateTime(2024, 3, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2708), null, "A modern and stylish room in Silver Residences.", 15, true, true, false, 20261m, "Room 104-15", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(2709) },
                    { 89, 1, new DateTime(2024, 7, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3135), null, "A spacious and airy room in Green Residences.", 24, true, true, false, 31160m, "Room 100-24", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3136) },
                    { 90, 4, new DateTime(2024, 11, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3140), null, "A newly renovated room in Green Residences.", 24, true, true, false, 27549m, "Room 101-24", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3141) },
                    { 91, 1, new DateTime(2024, 7, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3144), null, "A newly renovated room in Green Residences.", 24, true, true, false, 22206m, "Room 102-24", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3145) },
                    { 138, 3, new DateTime(2024, 11, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3706), null, "A fully furnished room in Superior Living Spaces.", 35, true, true, false, 7339m, "Room 100-35", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3706) },
                    { 139, 2, new DateTime(2024, 9, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3710), null, "A bright and cheerful room in Superior Living Spaces.", 35, true, true, false, 6980m, "Room 101-35", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3711) },
                    { 140, 3, new DateTime(2024, 4, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3714), null, "A bright and cheerful room in Superior Living Spaces.", 35, true, true, false, 8464m, "Room 102-35", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3715) },
                    { 141, 2, new DateTime(2024, 3, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3718), null, "A cozy and quiet room in Superior Living Spaces.", 35, true, true, false, 6966m, "Room 103-35", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3719) },
                    { 142, 1, new DateTime(2024, 6, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3727), null, "A clean and minimalist room in Superior Living Spaces.", 35, true, true, false, 12770m, "Room 104-35", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3727) },
                    { 149, 2, new DateTime(2025, 2, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3849), null, "A bright and cheerful room in Golden Dwellings.", 38, true, true, false, 29483m, "Room 100-38", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3850) },
                    { 150, 2, new DateTime(2024, 5, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3856), null, "A newly renovated room in Golden Dwellings.", 38, true, false, false, 28634m, "Room 101-38", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3857) },
                    { 151, 1, new DateTime(2024, 10, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3863), null, "A modern and stylish room in Golden Dwellings.", 38, true, true, false, 30686m, "Room 102-38", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(3864) },
                    { 168, 1, new DateTime(2025, 1, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4121), null, "A clean and minimalist room in Grand Quarters.", 44, true, true, false, 8216m, "Room 100-44", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4121) },
                    { 169, 4, new DateTime(2024, 9, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4125), null, "A charming and homey room in Grand Quarters.", 44, true, true, false, 4762m, "Room 101-44", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4126) },
                    { 170, 3, new DateTime(2024, 8, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4129), null, "A comfortable and well-lit room in Grand Quarters.", 44, true, true, false, 4444m, "Room 102-44", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4130) },
                    { 201, 3, new DateTime(2024, 6, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4510), null, "A modern and stylish room in Red Hall.", 53, true, true, false, 17188m, "Room 100-53", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4510) },
                    { 202, 3, new DateTime(2024, 12, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4516), null, "A functional and practical room in Red Hall.", 53, true, true, false, 16062m, "Room 101-53", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4517) },
                    { 231, 4, new DateTime(2025, 2, 15, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4865), null, "A bright and cheerful room in Central Dormitory.", 61, true, true, false, 24800m, "Room 100-61", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4865) },
                    { 232, 1, new DateTime(2024, 10, 11, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4869), null, "A newly renovated room in Central Dormitory.", 61, true, true, false, 26785m, "Room 101-61", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4870) },
                    { 233, 4, new DateTime(2024, 8, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4874), null, "A fully furnished room in Central Dormitory.", 61, true, true, false, 27257m, "Room 102-61", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4874) },
                    { 234, 2, new DateTime(2024, 5, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4878), null, "A functional and practical room in Central Dormitory.", 61, true, true, false, 26435m, "Room 103-61", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4879) },
                    { 244, 3, new DateTime(2024, 4, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4984), null, "A bright and cheerful room in Red Quarters.", 64, true, true, false, 17570m, "Room 100-64", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4985) },
                    { 245, 4, new DateTime(2024, 3, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4989), null, "A bright and cheerful room in Red Quarters.", 64, true, false, false, 18288m, "Room 101-64", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4989) },
                    { 246, 3, new DateTime(2024, 10, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4993), null, "A functional and practical room in Red Quarters.", 64, true, true, false, 17102m, "Room 102-64", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4993) },
                    { 247, 4, new DateTime(2025, 2, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4997), null, "A bright and cheerful room in Red Quarters.", 64, true, false, false, 22431m, "Room 103-64", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(4997) },
                    { 248, 2, new DateTime(2024, 9, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5020), null, "A functional and practical room in Orange Dormitory.", 65, true, true, false, 8714m, "Room 100-65", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5021) },
                    { 249, 4, new DateTime(2024, 4, 3, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5024), null, "A fully furnished room in Orange Dormitory.", 65, true, true, false, 14069m, "Room 101-65", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5025) },
                    { 250, 1, new DateTime(2024, 4, 10, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5029), null, "A charming and homey room in Orange Dormitory.", 65, true, true, false, 10087m, "Room 102-65", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5029) },
                    { 251, 2, new DateTime(2025, 1, 20, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5033), null, "A newly renovated room in Orange Dormitory.", 65, true, true, false, 10494m, "Room 103-65", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5033) },
                    { 252, 2, new DateTime(2024, 8, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5037), null, "A newly renovated room in Orange Dormitory.", 65, true, true, false, 9236m, "Room 104-65", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5038) },
                    { 271, 4, new DateTime(2024, 11, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5250), null, "A comfortable and well-lit room in Elegant Dwellings.", 71, true, true, false, 16348m, "Room 100-71", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5250) },
                    { 272, 3, new DateTime(2024, 7, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5255), null, "A clean and minimalist room in Elegant Dwellings.", 71, true, true, false, 15266m, "Room 101-71", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5255) },
                    { 308, 3, new DateTime(2024, 6, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5648), null, "A fully furnished room in Blue Place.", 83, true, true, false, 12690m, "Room 100-83", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5649) },
                    { 309, 2, new DateTime(2025, 1, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5652), null, "A functional and practical room in Blue Place.", 83, true, true, false, 12762m, "Room 101-83", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5653) },
                    { 310, 2, new DateTime(2024, 11, 28, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5657), null, "A fully furnished room in Blue Place.", 83, true, true, false, 10742m, "Room 102-83", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5657) },
                    { 311, 2, new DateTime(2024, 9, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5690), null, "A spacious and airy room in Superior Residences.", 84, true, true, false, 15835m, "Room 100-84", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5691) },
                    { 312, 3, new DateTime(2025, 2, 9, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5695), null, "A comfortable and well-lit room in Superior Residences.", 84, true, true, false, 22334m, "Room 101-84", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5695) },
                    { 313, 2, new DateTime(2024, 6, 29, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5699), null, "A functional and practical room in Superior Residences.", 84, true, false, false, 22188m, "Room 102-84", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5699) },
                    { 314, 1, new DateTime(2024, 4, 2, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5703), null, "A modern and stylish room in Superior Residences.", 84, true, true, false, 17522m, "Room 103-84", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5703) },
                    { 323, 1, new DateTime(2024, 12, 17, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5803), null, "A fully furnished room in Red Quarters.", 87, true, true, false, 9359m, "Room 100-87", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5803) },
                    { 324, 3, new DateTime(2024, 8, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5807), null, "A bright and cheerful room in Red Quarters.", 87, true, true, false, 6565m, "Room 101-87", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5807) },
                    { 325, 2, new DateTime(2025, 1, 1, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5816), null, "A cozy and quiet room in Red Quarters.", 87, true, true, false, 10803m, "Room 102-87", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5816) },
                    { 326, 2, new DateTime(2024, 8, 23, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5836), null, "A modern and stylish room in Golden Dormitory.", 88, true, true, false, 32904m, "Room 100-88", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5836) },
                    { 327, 4, new DateTime(2025, 1, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5840), null, "A spacious and airy room in Golden Dormitory.", 88, true, true, false, 27641m, "Room 101-88", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5841) },
                    { 328, 4, new DateTime(2024, 9, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5844), null, "A functional and practical room in Golden Dormitory.", 88, true, true, false, 29769m, "Room 102-88", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5845) },
                    { 329, 1, new DateTime(2024, 9, 18, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5849), null, "A fully furnished room in Golden Dormitory.", 88, true, true, false, 20383m, "Room 103-88", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5849) },
                    { 330, 3, new DateTime(2024, 8, 22, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5875), null, "A newly renovated room in Blue Dwellings.", 89, true, true, false, 10194m, "Room 100-89", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5876) },
                    { 331, 4, new DateTime(2024, 10, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5880), null, "A fully furnished room in Blue Dwellings.", 89, true, true, false, 11953m, "Room 101-89", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5880) },
                    { 332, 2, new DateTime(2024, 3, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5884), null, "A cozy and quiet room in Blue Dwellings.", 89, true, false, false, 15226m, "Room 102-89", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5884) },
                    { 333, 4, new DateTime(2024, 11, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5891), null, "A comfortable and well-lit room in Blue Dwellings.", 89, true, true, false, 7711m, "Room 103-89", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5892) },
                    { 334, 3, new DateTime(2025, 1, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5914), null, "A clean and minimalist room in Grand Dwellings.", 90, true, true, false, 22714m, "Room 100-90", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5915) },
                    { 335, 4, new DateTime(2024, 9, 26, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5918), null, "A clean and minimalist room in Grand Dwellings.", 90, true, true, false, 22756m, "Room 101-90", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(5919) },
                    { 350, 1, new DateTime(2024, 4, 16, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6085), null, "A cozy and quiet room in Blue Place.", 95, true, true, false, 7837m, "Room 100-95", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6086) },
                    { 351, 3, new DateTime(2024, 12, 24, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6089), null, "A charming and homey room in Blue Place.", 95, true, true, false, 6776m, "Room 101-95", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6090) },
                    { 352, 4, new DateTime(2024, 11, 4, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6112), null, "A bright and cheerful room in Premium Lodgings.", 96, true, true, false, 20345m, "Room 100-96", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6113) },
                    { 353, 4, new DateTime(2024, 7, 30, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6116), null, "A clean and minimalist room in Premium Lodgings.", 96, true, true, false, 16206m, "Room 101-96", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6117) },
                    { 354, 3, new DateTime(2024, 9, 21, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6120), null, "A bright and cheerful room in Premium Lodgings.", 96, true, true, false, 15960m, "Room 102-96", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6121) },
                    { 355, 2, new DateTime(2024, 6, 13, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6148), null, "A cozy and quiet room in Premium Suites.", 97, true, true, false, 9731m, "Room 100-97", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6148) },
                    { 356, 4, new DateTime(2024, 9, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6152), null, "A comfortable and well-lit room in Premium Suites.", 97, true, true, false, 7832m, "Room 101-97", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6153) },
                    { 357, 1, new DateTime(2024, 4, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6157), null, "A comfortable and well-lit room in Premium Suites.", 97, true, true, false, 9535m, "Room 102-97", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6157) },
                    { 358, 1, new DateTime(2024, 7, 12, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6160), null, "A bright and cheerful room in Premium Suites.", 97, true, true, false, 10128m, "Room 103-97", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6161) },
                    { 361, 3, new DateTime(2024, 11, 5, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6209), null, "A cozy and quiet room in Central Lodgings.", 99, true, true, false, 25122m, "Room 100-99", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6210) },
                    { 362, 4, new DateTime(2024, 10, 19, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6214), null, "A fully furnished room in Central Lodgings.", 99, true, true, false, 32340m, "Room 101-99", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6214) },
                    { 363, 2, new DateTime(2024, 5, 25, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6247), null, "A cozy and quiet room in Silver Dwellings.", 100, true, true, false, 15436m, "Room 100-100", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6247) },
                    { 364, 4, new DateTime(2024, 12, 8, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6251), null, "A functional and practical room in Silver Dwellings.", 100, true, true, false, 13132m, "Room 101-100", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6252) },
                    { 365, 2, new DateTime(2024, 8, 6, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6255), null, "A bright and cheerful room in Silver Dwellings.", 100, true, true, false, 13854m, "Room 102-100", new DateTime(2025, 2, 27, 14, 35, 27, 256, DateTimeKind.Local).AddTicks(6256) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_TenantId",
                table: "Bookings",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Id",
                table: "Categories",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_DormAmenities_AmenityId",
                table: "DormAmenities",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_DormAmenities_DormId",
                table: "DormAmenities",
                column: "DormId");

            migrationBuilder.CreateIndex(
                name: "IX_DormmatePreferenceHabits_HabitId",
                table: "DormmatePreferenceHabits",
                column: "HabitId");

            migrationBuilder.CreateIndex(
                name: "IX_DormmatePreferenceHabits_PreferenceId_HabitId",
                table: "DormmatePreferenceHabits",
                columns: new[] { "PreferenceId", "HabitId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DormmatePreferenceInterests_InterestId",
                table: "DormmatePreferenceInterests",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_DormmatePreferenceInterests_PreferenceId_InterestId",
                table: "DormmatePreferenceInterests",
                columns: new[] { "PreferenceId", "InterestId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DormmatePreferences_UserId",
                table: "DormmatePreferences",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DormReviews_DormId",
                table: "DormReviews",
                column: "DormId");

            migrationBuilder.CreateIndex(
                name: "IX_DormReviews_TenantId",
                table: "DormReviews",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Dorms_AmenityId",
                table: "Dorms",
                column: "AmenityId");

            migrationBuilder.CreateIndex(
                name: "IX_Dorms_CategoryId",
                table: "Dorms",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dorms_OwnerId",
                table: "Dorms",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Dorms_TagId",
                table: "Dorms",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_DormTags_DormId",
                table: "DormTags",
                column: "DormId");

            migrationBuilder.CreateIndex(
                name: "IX_DormTags_TagId",
                table: "DormTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_DormId",
                table: "Images",
                column: "DormId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_DormId",
                table: "Rooms",
                column: "DormId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_RoomId",
                table: "Visits",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_VisitorId",
                table: "Visits",
                column: "VisitorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "DormAmenities");

            migrationBuilder.DropTable(
                name: "DormmatePreferenceHabits");

            migrationBuilder.DropTable(
                name: "DormmatePreferenceInterests");

            migrationBuilder.DropTable(
                name: "DormReviews");

            migrationBuilder.DropTable(
                name: "DormTags");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Habits");

            migrationBuilder.DropTable(
                name: "DormmatePreferences");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Dorms");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Tags");
        }
    }
}
