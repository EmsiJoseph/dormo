using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dormo.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedDormReviewsinDormentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    SecurityDeposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                name: "DormReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DormId = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: false),
                    ReviewText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DormId1 = table.Column<int>(type: "int", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_DormReviews_Dorms_DormId1",
                        column: x => x.DormId1,
                        principalTable: "Dorms",
                        principalColumn: "Id");
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
                        onDelete: ReferentialAction.Restrict);
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "be5a5f28-9281-4945-a248-0421f9e09a50", "Admin", "ADMIN" },
                    { "2", "6770c7b8-1de4-44d8-a30a-95c7c53253bb", "Owner", "OWNER" },
                    { "3", "5857cd12-6357-4831-8c03-813774e971dc", "Member", "MEMBER" },
                    { "4", "054bdca8-0752-4b51-b09a-eecded8acb49", "Tenant", "TENANT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContactInfo", "CreatedAt", "Dob", "Email", "EmailConfirmed", "EmailSubscription", "FirstName", "IsActive", "IsDeleted", "IsVerified", "LastName", "Latitude", "LockoutEnabled", "LockoutEnd", "Longitude", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PreferredFirstName", "ProfileImageUrl", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb0", 0, "fa75644c-bae8-4d42-a89e-e9281afdffc6", null, new DateTime(2025, 3, 6, 7, 41, 6, 542, DateTimeKind.Utc).AddTicks(5896), new DateOnly(1, 1, 1), "admin@dormo.com", true, false, "System", true, false, false, "Administrator", null, false, null, null, "ADMIN@DORMO.COM", "ADMIN@DORMO.COM", "AQAAAAIAAYagAAAAEFflrfqAewfnrFDIiNMUHImcBUSgieE+29jHUVfmESvC4e+aMWVW2KihIGic8RWqBA==", "+639190000000", true, null, null, "6f51fc47-36d0-45ed-821a-f2c5b0cf0da6", false, new DateTime(2025, 3, 6, 7, 41, 6, 542, DateTimeKind.Utc).AddTicks(5906), "admin@dormo.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb5", 0, "e0501f49-7a44-431e-9804-86664f1d5455", null, new DateTime(2025, 3, 6, 7, 41, 6, 484, DateTimeKind.Utc).AddTicks(7582), new DateOnly(1, 1, 1), "housing@university.edu", true, false, "University", true, false, false, "Housing", null, false, null, null, "HOUSING@UNIVERSITY.EDU", "HOUSING@UNIVERSITY.EDU", "AQAAAAIAAYagAAAAEPFH2zF536vJm/GOfw81j+uQAVFP7CmwH4BtuSOPipM/9e5d+hsYhN54O2BWx+6kKw==", "+639211234567", true, null, null, "550ba98a-07ae-4578-abec-4a3373800fc0", false, new DateTime(2025, 3, 6, 7, 41, 6, 484, DateTimeKind.Utc).AddTicks(7587), "housing@university.edu" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb6", 0, "05cf006a-8e5d-49f9-be60-9056bd5649b2", null, new DateTime(2025, 3, 6, 7, 41, 6, 433, DateTimeKind.Utc).AddTicks(3719), new DateOnly(1, 1, 1), "antonio.reyes@example.com", true, false, "Antonio", true, false, false, "Reyes", null, false, null, null, "ANTONIO.REYES@EXAMPLE.COM", "ANTONIO.REYES@EXAMPLE.COM", "AQAAAAIAAYagAAAAECHFkhiCxatgmshsFVmuXeOyLHvFaIduodkzfb7tZ63NL8IFI7C4aij8pvSlhv7G+A==", "+639207654321", true, null, null, "7b822511-fcdf-4c91-bb01-fad50a0cb655", false, new DateTime(2025, 3, 6, 7, 41, 6, 433, DateTimeKind.Utc).AddTicks(3726), "antonio.reyes@example.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb7", 0, "aedad90e-e1ea-4a7e-aa49-03c11ccb4cd3", null, new DateTime(2025, 3, 6, 7, 41, 6, 364, DateTimeKind.Utc).AddTicks(9245), new DateOnly(1, 1, 1), "megadevelopers@example.com", true, false, "Mega", true, false, false, "Developers", null, false, null, null, "MEGADEVELOPERS@EXAMPLE.COM", "MEGADEVELOPERS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEJJun/gppglv821AuJF0Kcw7KKMjqju3ovGQL8Y4g0kcdfYX7m/AUF0pQj/QsZHpKA==", "+639191234567", true, null, null, "1850481c-6ed9-4920-b697-bf6c6788f3f9", false, new DateTime(2025, 3, 6, 7, 41, 6, 364, DateTimeKind.Utc).AddTicks(9250), "megadevelopers@example.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb8", 0, "21682892-47a0-4a0d-86c1-6b42fa552fe1", null, new DateTime(2025, 3, 6, 7, 41, 6, 292, DateTimeKind.Utc).AddTicks(1575), new DateOnly(1, 1, 1), "maria.santos@example.com", true, false, "Maria", true, false, false, "Santos", null, false, null, null, "MARIA.SANTOS@EXAMPLE.COM", "MARIA.SANTOS@EXAMPLE.COM", "AQAAAAIAAYagAAAAEPH3YtOCFYZ3KSqYH8mZSv4tNh7NK3R2clDUi3zmubxjLryQPqw4ha8VqUqyLRtY0Q==", "+639187654321", true, null, null, "3d027dfb-54f2-482d-b5d3-e3288c7fa060", false, new DateTime(2025, 3, 6, 7, 41, 6, 292, DateTimeKind.Utc).AddTicks(1580), "maria.santos@example.com" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "a40c01d7-3107-450b-89cc-c3ee9c92af90", null, new DateTime(2025, 3, 6, 7, 41, 6, 224, DateTimeKind.Utc).AddTicks(713), new DateOnly(1, 1, 1), "pmcrealty@example.com", true, false, "PMC", true, false, false, "Realty", null, false, null, null, "PMCREALTY@EXAMPLE.COM", "PMCREALTY@EXAMPLE.COM", "AQAAAAIAAYagAAAAEKt+ist/7UqnOTto0ExBhbUWA0uSN2KusWJ6/cGwY5dSuVNJnDDqolTEEiOL2HKCmw==", "+639171234567", true, null, null, "f8c025c7-942f-4c3c-af37-bddcd8b6b955", false, new DateTime(2025, 3, 6, 7, 41, 6, 224, DateTimeKind.Utc).AddTicks(718), "pmcrealty@example.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Icon", "IsActive", "IsDeleted", "Name", "ParentId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(3220), null, "Single room accommodation", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlIj48cGF0aCBkPSJNMTUgMjF2LThhMSAxIDAgMCAwLTEtMWgtNGExIDEgMCAwIDAtMSAxdjgiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PC9zdmc+", true, false, "Studio Type", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(3314) },
                    { 2, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4046), null, "Multiple room accommodation", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXJzIj48cGF0aCBkPSJNMTYgMjF2LTJhNCA0IDAgMCAwLTQtNEg2YTQgNCAwIDAgMC00IDR2MiIvPjxjaXJjbGUgY3g9IjkiIGN5PSI3IiByPSI0Ii8+PHBhdGggZD0iTTIyIDIxdi0yYTQgNCAwIDAgMC0zLTMuODciLz48cGF0aCBkPSJNMTYgMy4xM2E0IDQgMCAwIDEgMCA3Ljc1Ii8+PC9zdmc+", true, false, "Apartment Type", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4047) },
                    { 8, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4063), null, "Dorms near schools or universities", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVuaXZlcnNpdHkiPjxjaXJjbGUgY3g9IjEyIiBjeT0iMTAiIHI9IjEiLz48cGF0aCBkPSJNMjIgMjBWOGgtNGwtNi00LTYgNEgydjEyYTIgMiAwIDAgMCAyIDJoMTZhMiAyIDAgMCAwIDItMiIvPjxwYXRoIGQ9Ik02IDE3di4wMSIvPjxwYXRoIGQ9Ik02IDEzdi4wMSIvPjxwYXRoIGQ9Ik0xOCAxN3YuMDEiLz48cGF0aCBkPSJNMTggMTN2LjAxIi8+PHBhdGggZD0iTTE0IDIydi01YTIgMiAwIDAgMC0yLTJhMiAyIDAgMCAwLTIgMnY1Ii8+PC9zdmc+", true, false, "Near Schools/Uni", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4064) },
                    { 9, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4065), null, "Dorms located in the city", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik02IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=", true, false, "City Dorms", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4066) },
                    { 10, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4068), null, "Dorms located in suburban areas", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI4IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik02IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=", true, false, "Suburban Dorms", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4068) },
                    { 11, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4070), null, "Dorms connected to campuses", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXNjaG9vbCI+PHBhdGggZD0iTTE0IDIydi00YTIgMiAwIDEgMC00IDB2NCIvPjxwYXRoIGQ9Im0xOCAxMCAzLjQ0NyAxLjcyNGExIDEgMCAwIDEgLjU1My44OTRWMjBhMiAyIDAgMCAxLTIgMkg0YTIgMiAwIDAgMS0yLTJ2LTcuMzgyYTEgMSAwIDAgMSAuNTUzLS44OTRMNiAxMCIvPjxwYXRoIGQ9Ik0xOCA1djE3Ii8+PHBhdGggZD0ibTQgNiA3LjEwNi0zLjU1M2EyIDIgMCAwIDEgMS43ODggMEwyMCA2Ii8+PHBhdGggZD0iTTYgNXYxNyIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iOSIgcj0iMiIvPjwvc3ZnPg==", true, false, "Campus-Connected", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4070) },
                    { 12, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4071), null, "Dorms offering bed spaces", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJlZCI+PHBhdGggZD0iTTIgNHYxNiIvPjxwYXRoIGQ9Ik0yIDhoMThhMiAyIDAgMCAxIDIgMnYxMCIvPjxwYXRoIGQ9Ik0yIDE3aDIwIi8+PHBhdGggZD0iTTYgOHY5Ii8+PC9zdmc+", true, false, "Bed Spaces", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4072) },
                    { 13, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4077), null, "Dorms offering private rooms", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXIiPjxwYXRoIGQ9Ik0xOSAyMXYtMmE0IDQgMCAwIDAtNC00SDlhNCA0IDAgMCAwLTQgNHYyIi8+PGNpcmNsZSBjeD0iMTIiIGN5PSI3IiByPSI0Ii8+PC9zdmc+", true, false, "Private Room", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4078) },
                    { 14, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4080), null, "Dorms offering co-living spaces", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXJzIj48cGF0aCBkPSJNMTYgMjF2LTJhNCA0IDAgMCAwLTQtNEg2YTQgNCAwIDAgMC00IDR2MiIvPjxjaXJjbGUgY3g9IjkiIGN5PSI3IiByPSI0Ii8+PHBhdGggZD0iTTIyIDIxdi0yYTQgNCAwIDAgMC0zLTMuODciLz48cGF0aCBkPSJNMTYgMy4xM2E0IDQgMCAwIDEgMCA3Ljc1Ii8+PC9zdmc+", true, false, "Co-Living Spaces", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4080) },
                    { 17, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4084), null, "Dorms with condominium-style accommodations", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJ1aWxkaW5nLTIiPjxwYXRoIGQ9Ik06IDIyVjRhMiAyIDAgMCAxIDItMmg4YTIgMiAwIDAgMSAyIDJ2MThaIi8+PHBhdGggZD0iTTYgMTJINGEyIDIgMCAwIDAtMiAydjZhMiAyIDAgMCAwIDIgMmgyIi8+PHBhdGggZD0iTTE4IDloMmEyIDIgMCAwIDEgMiAydjlhMiAyIDAgMCAxLTIgMmgtMiIvPjxwYXRoIGQ9Ik0xMCA2aDQiLz48cGF0aCBkPSJNMTAgMTBoNCIvPjxwYXRoIGQ9Ik0xMCAxNGg0Ii8+PHBhdGggZD0iTTEwIDE4aDQiLz48L3N2Zz4=", true, false, "Condo Dorms", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4086) },
                    { 18, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4087), null, "Dorms with review centers", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWJvb2stb3Blbi10ZXh0Ij48cGF0aCBkPSJNMTIgN3YxNCIvPjxwYXRoIGQ9Ik0xNiAxMmgyIi8+PHBhdGggZD0iTTE2IDhoMiIvPjxwYXRoIGQ9Ik0zIDE4YTEgMSAwIDAgMS0xLTFWNGExIDEgMCAwIDEgMS0xaDVhNCA0IDAgMCAxIDQgNCA0IDQgMCAwIDEgNC00aDVhMSAxIDAgMCAxIDEgMXYxM2ExIDEgMCAwIDEtMSAxaC02YTMgMyAwIDAgMC0zIDMgMyAzIDAgMCAwLTMtM3oiLz48cGF0aCBkPSJNNiAxMmgyIi8+PHBhdGggZD0iTTYgOGgyIi8+PC9zdmc+", true, false, "Review Centers & Dorms", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4088) },
                    { 19, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4099), null, "Boarding houses", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlIj48cGF0aCBkPSJNMTUgMjF2LThhMSAxIDAgMCAwLTEtMWgtNGExIDEgMCAwIDAtMSAxdjgiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PC9zdmc+", true, false, "Boarding Houses", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4099) },
                    { 20, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4101), null, "Dorms for short term stays", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXJnbGFzcyI+PHBhdGggZD0iTTUgMjJoMTQiLz48cGF0aCBkPSJNNSAyaDE0Ii8+PHBhdGggZD0iTTE3IDIydi00LjE3MmEyIDIgMCAwIDAtLjU4Ni0xLjQxNEwxMiAxMmwtNC40MTQgNC40MTRBMiAyIDAgMCAwIDcgMTcuODI4VjIyIi8+PHBhdGggZD0iTTcgMnY0LjE3MmEyIDIgMCAwIDAgLjU4NiAxLjQxNEwxMiAxMmw0LjQxNC00LjQxNEEyIDIgMCAwIDAgMTcgNi4xNzJWMiIvPjwvc3ZnPg==", true, false, "Short Term Stays", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4101) },
                    { 21, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4103), null, "Dorms with historical significance", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNhbGVuZGFyIj48cGF0aCBkPSJNOCAydjQiLz48cGF0aCBkPSJNMTYgMnY0Ii8+PHJlY3Qgd2lkdGg9IjE4IiBoZWlnaHQ9IjE4IiB4PSIzIiB5PSI0IiByeD0iMiIvPjxwYXRoIGQ9Ik0zIDEwaDE4Ii8+PC9zdmc+", true, false, "Historical Dorms", null, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4103) }
                });

            migrationBuilder.InsertData(
                table: "Habits",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(6734), null, "Wakes up early in the morning", true, false, "Early Bird", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(6734) },
                    { 2, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(7006), null, "Stays up late at night", true, false, "Night Owl", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(7006) },
                    { 3, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(7008), null, "Keeps everything clean and organized", true, false, "Neat Freak", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(7008) },
                    { 4, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(7009), null, "Enjoys socializing and having friends over", true, false, "Social Butterfly", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(7010) },
                    { 5, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(7011), null, "Prefers quiet environment", true, false, "Quiet Person", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(7011) },
                    { 6, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(7012), null, "Spends most time studying", true, false, "Studious", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(7012) }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "IconUrl", "IsActive", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8663), null, "Enjoys playing video games", null, true, false, "Gaming", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8664) },
                    { 2, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8895), null, "Enjoys reading books", null, true, false, "Reading", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8895) },
                    { 3, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8896), null, "Interested in music and instruments", null, true, false, "Music", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8897) },
                    { 4, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8898), null, "Enjoys sports activities", null, true, false, "Sports", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8898) },
                    { 5, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8899), null, "Enjoys cooking and culinary arts", null, true, false, "Cooking", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8899) },
                    { 6, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8900), null, "Interested in various forms of art", null, true, false, "Art", new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(8900) }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Icon", "IsActive", "IsDeleted", "Name", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3296), null, "Located close to educational institutions", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXNjaG9vbCI+PHBhdGggZD0iTTE0IDIydi00YTIgMiAwIDEgMC00IDB2NCIvPjxwYXRoIGQ9Im0xOCAxMCAzLjQ0NyAxLjcyNGExIDEgMCAwIDEgLjU1My44OTRWMjBhMiAyIDAgMCAxLTIgMkg0YTIgMiAwIDAgMS0yLTJ2LTcuMzgyYTEgMSAwIDAgMSAuNTUzLS44OTRMNiAxMCIvPjxwYXRoIGQ9Ik0xOCA1djE3Ii8+PHBhdGggZD0ibTQgNiA3LjEwNi0zLjU1M2EyIDIgMCAwIDEgMS43ODggMEwyMCA2Ii8+PHBhdGggZD0iTTYgNXYxNyIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iOSIgcj0iMiIvPjwvc3ZnPg==", true, false, "Near Campus", "Tag", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3298) },
                    { 2, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3686), null, "Allows pets in the premises", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNhdCI+PHBhdGggZD0iTTEyIDVjLjY3IDAgMS4zNS4wOSAyIC4yNiAxLjc4LTIgNS4wMy0yLjg0IDYuNDItMi4yNiAxLjQuNTgtLjQyIDctLjQyIDcgLjU3IDEuMDcgMSAyLjI0IDEgMy40NEMyMSAxNy45IDE2Ljk3IDIxIDEyIDIxcy05LTMtOS03LjU2YzAtMS4yNS41LTIuNCAxLTMuNDQgMCAwLTEuODktNi40Mi0uNS03IDEuMzktLjU4IDQuNzIuMjMgNi41IDIuMjNBOS4wNCA5LjA0IDAgMCAxIDEyIDVaIi8+PHBhdGggZD0iTTggMTR2LjUiLz48cGF0aCBkPSJNMjAgMTR2LjUiLz48cGF0aCBkPSJNMTEuMjUgMTYuMjVoMS41TDEyIDE3bC0uNzUtLjc1WiIvPjwvc3ZnPg==", true, false, "Pet Friendly", "Tag", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3687) },
                    { 3, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3689), null, "Exclusive for female residents", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXZlbnVzIj48cGF0aCBkPSJNMTIgMTV2NyIvPjxwYXRoIGQ9Ik05IDE5aDYiLz48Y2lyY2xlIGN4PSIxMiIgY3k9IjkiIHI9IjYiLz48L3N2Zz4=", true, false, "Female Only", "Tag", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3689) },
                    { 4, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3690), null, "Exclusive for male residents", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLW1hcnMiPjxwYXRoIGQ9Ik0xNiAzaDV2NSIvPjxwYXRoIGQ9Im0yMSAzLTYuNzUgNi43NSIvPjxjaXJjbGUgY3g9IjEwIiBjeT0iMTQiIHI9IjYiLz48L3N2Zz4=", true, false, "Male Only", "Tag", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3691) },
                    { 5, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3692), null, "Suitable for students", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWdyYWR1YXRpb24tY2FwIj48cGF0aCBkPSJNMjEuNDIgMTAuOTIyYTEgMSAwIDAgMC0uMDE5LTEuODM4TDEyLjgzIDUuMThhMiAyIDAgMCAwLTEuNjYgMEwyLjYgOS4wOGExIDEgMCAwIDAgMCAxLjgzMmw4LjU3IDMuOTA4YTIgMiAwIDAgMCAxLjY2IDB6Ii8+PHBhdGggZD0iTTIyIDEwdjYiLz48cGF0aCBkPSJNNiAxMi41VjE2YTYgMyAwIDAgMCAxMiAwdi0zLjUiLz48L3N2Zz4=", true, false, "Student Friendly", "Tag", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3692) },
                    { 6, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3693), null, "Recently constructed property", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLW1hcC1waW4tcGx1cyI+PHBhdGggZD0iTTE5LjkxNCAxMS4xMDVBNy4yOTggNy4yOTggMCAwIDAgMjAgMTBhOCA4IDAgMCAwLTE2IDBjMCA0Ljk5MyA1LjUzOSAxMC4xOTMgNy4zOTkgMTEuNzk5YTEgMSAwIDAgMCAxLjIwMiAwIDMyIDMyIDAgMCAwIC44MjQtLjczOCIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iMTAiIHI9IjMiLz48cGF0aCBkPSJNMTYgMThoNiIvPjxwYXRoIGQ9Ik0xOSAxNXY2Ii8+PC9zdmc+", true, false, "Newly Built", "Tag", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3693) },
                    { 7, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3694), null, "Affordable accommodation", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXBoaWxpcHBpbmUtcGVzbyI+PHBhdGggZD0iTTIwIDExSDQiLz48cGF0aCBkPSJNMjAgN0g0Ii8+PHBhdGggZD0iTTcgMjFWNGExIDEgMCAwIDEgMS0xaDRhMSAxIDAgMCAxIDAgMTJINyIvPjwvc3ZnPg==", true, false, "Budget Friendly", "Tag", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3695) },
                    { 8, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3696), null, "High-end accommodation", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWdlbSI+PHBhdGggZD0iTTYgM2gxMmw0IDYtMTAgMTNMMiA5WiIvPjxwYXRoIGQ9Ik0xMSAzIDggOWw0IDEzIDQtMTMtMy02Ii8+PHBhdGggZD0iTTIgOWgyMCIvPjwvc3ZnPg==", true, false, "Luxury", "Tag", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3696) },
                    { 9, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3697), null, "Cooling system for comfortable room temperature", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWFpci12ZW50Ij48cGF0aCBkPSJNNiAxMkg0YTIgMiAwIDAgMS0yLTJWNWEyIDIgMCAwIDEgMi0yaDE2YTIgMiAwIDAgMSAyIDJ2NWEyIDIgMCAwIDEtMiAyaC0yIi8+PHBhdGggZD0iTTYgOGgxMiIvPjxwYXRoIGQ9Ik0xOC4zIDE3LjdhMi41IDIuNSAwIDAgMS0zLjE2IDMuODMgMi41MyAyLjUzIDAgMCAxLTEuMTQtMlYxMiIvPjxwYXRoIGQ9Ik02LjYgMTUuNkEyIDIgMCAxIDAgMTAgMTd2LTUiLz48L3N2Zz4=", true, false, "Air Conditioning", "Amenity", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3698) },
                    { 10, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3788), null, "High-speed wireless internet connection", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXdpZmkiPjxwYXRoIGQ9Ik0xMiAyMGguMDEiLz48cGF0aCBkPSJNMiA4LjgyYTE1IDE1IDAgMCAxIDIwIDAiLz48cGF0aCBkPSJNNSAxMi44NTlhMTAgMTAgMCAwIDEgMTQgMCIvPjxwYXRoIGQ9Ik04LjUgMTYuNDI5YTUgNSAwIDAgMSA3IDAiLz48L3N2Zz4=", true, false, "Wi-Fi", "Amenity", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3789) },
                    { 11, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3790), null, "Dedicated space for studying", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLW5vdGVib29rIj48cGF0aCBkPSJNMiA2aDQiLz48cGF0aCBkPSJNMiAxMGg0Ii8+PHBhdGggZD0iTTIgMTRoNCIvPjxwYXRoIGQ9Ik0yIDE4aDQiLz48cmVjdCB3aWR0aD0iMTYiIGhlaWdodD0iMjAiIHg9IjQiIHk9IjIiIHJ4PSIyIi8+PHBhdGggZD0iTTE2IDJ2MjAiLz48L3N2Zz4=", true, false, "Study Area", "Amenity", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3791) },
                    { 12, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3792), null, "On-site laundry facilities", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXdhc2hpbmctbWFjaGluZSI+PHBhdGggZD0iTTMgNmgzIi8+PHBhdGggZD0iTTE3IDZoLjAxIi8+PHJlY3Qgd2lkdGg9IjE4IiBoZWlnaHQ9IjIwIiB4PSIzIiB5PSIyIiByeD0iMiIvPjxjaXJjbGUgY3g9IjEyIiBjeT0iMTMiIHI9IjUiLz48cGF0aCBkPSJNMTIgMThhMi41IDIuNSAwIDAgMCAwLTUgMi41IDIuNSAwIDAgMSAwLTUiLz48L3N2Zz4=", true, false, "Laundry", "Amenity", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3792) },
                    { 13, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3794), null, "24/7 security personnel and CCTV", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNjdHYiPjxwYXRoIGQ9Ik0xNi43NSAxMmgzLjYzMmExIDEgMCAwIDEgLjg5NCAxLjQ0N2wtMi4wMzQgNC4wNjlhMSAxIDAgMCAxLTEuNzA4LjEzNGwtMi4xMjQtMi45NyIvPjxwYXRoIGQ9Ik0xNy4xMDYgOS4wNTNhMSAxIDAgMCAxIC40NDcgMS4zNDFsLTMuMTA2IDYuMjExYTEgMSAwIDAgMS0xLjM0Mi40NDdMMy42MSAxMi4zYTIuOTIgMi45MiAwIDAgMS0xLjMtMy45MUwzLjY5IDUuNmEyLjkyIDIuOTIgMCAwIDEgMy45Mi0xLjN6Ii8+PHBhdGggZD0iTTIgMTloMy43NmEyIDIgMCAwIDAgMS44LTEuMUw5IDE1Ii8+PHBhdGggZD0iTTIgMjF2LTQiLz48cGF0aCBkPSJNNyA5aC4wMSIvPjwvc3ZnPg==", true, false, "Security", "Amenity", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3794) },
                    { 14, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3795), null, "Shared space for socializing", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWFybWNoYWlyIj48cGF0aCBkPSJNMTkgOVY2YTIgMiAwIDAgMC0yLTJIN2EyIDIgMCAwIDAtMiAydjMiLz48cGF0aCBkPSJNMyAxNmEyIDIgMCAwIDAgMiAyaDE0YTIgMiAwIDAgMCAyLTJ2LTVhMiAyIDAgMCAwLTQgMHYxLjVhLjUuNSAwIDAgMS0uNS41aC05YS41LjUgMCAwIDEtLjUtLjVWMTFhMiAyIDAgMCAwLTQgMHoiLz48cGF0aCBkPSJNNSAxOHYyIi8+PHBhdGggZD0iTTE5IDE4djIiLz48L3N2Zz4=", true, false, "Common Room", "Amenity", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3796) },
                    { 15, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3797), null, "Shared cooking facilities", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNvb2tpbmctcG90Ij48cGF0aCBkPSJNMiAxMmgyMCIvPjxwYXRoIGQ9Ik0yMCAxMnY4YTIgMiAwIDAgMS0yIDJINmEyIDIgMCAwIDEtMi0ydi04Ii8+PHBhdGggZD0ibTQgOCAxNi00Ii8+PHBhdGggZD0ibTguODYgNi43OC0uNDUtMS44MWEyIDIgMCAwIDEgMS40NS0yLjQzbDEuOTQtLjQ4YTIgMiAwIDAgMSAyLjQzIDEuNDZsLjQ1IDEuOCIvPjwvc3ZnPg==", true, false, "Kitchen", "Amenity", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3797) },
                    { 16, new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3798), null, "Secure parking space", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWNpcmNsZS1wYXJraW5nIj48Y2lyY2xlIGN4PSIxMiIgY3k9IjEyIiByPSIxMCIvPjxwYXRoIGQ9Ik05IDE3VjdoNGEzIDMgMCAwIDEgMCA2SDkiLz48L3N2Zz4=", true, false, "Parking", "Amenity", new DateTime(2025, 3, 6, 7, 41, 6, 598, DateTimeKind.Utc).AddTicks(3799) }
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
                    { 4, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4051), null, "Studio for one person", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlIj48cGF0aCBkPSJNMTUgMjF2LThhMSAxIDAgMCAwLTEtMWgtNGExIDEgMCAwIDAtMSAxdjgiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PC9zdmc+", true, false, "Single Studio", 1, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4051) },
                    { 5, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4057), null, "Studio for two persons", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLWhvdXNlIj48cGF0aCBkPSJNMTUgMjF2LThhMSAxIDAgMCAwLTEtMWgtNGExIDEgMCAwIDAtMSAxdjgiLz48cGF0aCBkPSJNMyAxMGEyIDIgMCAwIDEgLjcwOS0xLjUyOGw3LTUuOTk5YTIgMiAwIDAgMSAyLjU4MiAwbDcgNS45OTlBMiAyIDAgMCAxIDIxIDEwdjlhMiAyIDAgMCAxLTIgMkg1YTIgMiAwIDAgMS0yLTJ6Ii8+PC9zdmc+", true, false, "Double Studio", 1, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4058) },
                    { 6, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4059), null, "Two bedroom apartment", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXJzIj48cGF0aCBkPSJNMTYgMjF2LTJhNCA0IDAgMCAwLTQtNEg2YTQgNCAwIDAgMC00IDR2MiIvPjxjaXJjbGUgY3g9IjkiIGN5PSI3IiByPSI0Ii8+PHBhdGggZD0iTTIyIDIxdi0yYTQgNCAwIDAgMC0zLTMuODciLz48cGF0aCBkPSJNMTYgMy4xM2E0IDQgMCAwIDEgMCA3Ljc1Ii8+PC9zdmc+", true, false, "2-Bedroom", 2, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4060) },
                    { 7, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4061), null, "Three bedroom apartment", "data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIyNCIgaGVpZ2h0PSIyNCIgdmlld0JveD0iMCAwIDI0IDI0IiBmaWxsPSJub25lIiBzdHJva2U9ImN1cnJlbnRDb2xvciIgc3Ryb2tlLXdpZHRoPSIyIiBzdHJva2UtbGluZWNhcD0icm91bmQiIHN0cm9rZS1saW5lam9pbj0icm91bmQiIGNsYXNzPSJsdWNpZGUgbHVjaWRlLXVzZXJzIj48cGF0aCBkPSJNMTYgMjF2LTJhNCA0IDAgMCAwLTQtNEg2YTQgNCAwIDAgMC00IDR2MiIvPjxjaXJjbGUgY3g9IjkiIGN5PSI3IiByPSI0Ii8+PHBhdGggZD0iTTIyIDIxdi0yYTQgNCAwIDAgMC0zLTMuODciLz48cGF0aCBkPSJNMTYgMy4xM2E0IDQgMCAwIDEgMCA3Ljc1Ii8+PC9zdmc+", true, false, "3-Bedroom", 2, new DateTime(2025, 3, 6, 7, 41, 6, 597, DateTimeKind.Utc).AddTicks(4062) }
                });

            migrationBuilder.InsertData(
                table: "Dorms",
                columns: new[] { "Id", "Address", "CategoryId", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsAvailable", "IsDeleted", "IsVerified", "Latitude", "Longitude", "Name", "OwnerId", "Rating", "SecurityDeposit", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "49 Marcos Highway, Valenzuela, Parañaque, Metro Manila, Philippines", 13, new DateTime(2024, 12, 3, 15, 41, 6, 601, DateTimeKind.Local).AddTicks(1505), null, "Spacious Luxurious residences offering the best in comfort and convenience. Near University of the Philippines", true, true, false, true, 14.248859419545792m, 120.678903904071219m, "Central Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.0m, 990m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(2926) },
                    { 3, "93 Rizal Avenue, Poblacion, Pasay, Metro Manila, Philippines", 8, new DateTime(2024, 6, 25, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7220), null, "Contemporary Modern accommodations with convenient access to universities and business districts. Close to Ateneo de Manila University", true, true, false, true, 14.6448168826854401m, 120.748660954472637m, "Orange Suites", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.9m, 1116m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7221) },
                    { 4, "403 Commonwealth Avenue, San Isidro, Manila, Metro Manila, Philippines", 19, new DateTime(2024, 10, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7263), null, "Spacious Student-friendly dormitory with study areas and high-speed internet. Close to University of the East", true, false, false, true, 14.43674036735354m, 120.752549260682403m, "Green Suites", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.5m, 824m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7264) },
                    { 5, "753 EDSA, San Lorenzo, Pasig, Metro Manila, Philippines", 9, new DateTime(2024, 6, 5, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7298), null, "Student-friendly Strategically located residences for easy access to key city establishments. Near University of Santo Tomas", true, true, false, true, 14.85546881553343m, 121.238206522593092m, "Golden Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.9m, 532m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7299) },
                    { 6, "78 Rizal Avenue, Pinagkaisahan, Taguig, Metro Manila, Philippines", 12, new DateTime(2024, 10, 5, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7361), null, "Contemporary Budget-friendly options without compromising on quality and comfort. Walking distance to Manila Central University", true, true, false, true, 14.60672275837660891m, 121.173231894639615m, "Red Suites", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.6m, 1027m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7362) },
                    { 8, "206 Commonwealth Avenue, San Antonio, Parañaque, Metro Manila, Philippines", 10, new DateTime(2024, 12, 7, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7451), null, "Contemporary Secure and well-maintained accommodations for peace of mind. Near University of Santo Tomas", true, true, false, true, 14.835081091947659m, 121.18302010887322m, "Elegant Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.5m, 1092m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7452) },
                    { 11, "222 Ayala Avenue, Poblacion, Taguig, Metro Manila, Philippines", 21, new DateTime(2024, 12, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7595), null, "Professional Budget-friendly options without compromising on quality and comfort. Near AMA University", true, false, false, true, 14.76675361052307m, 120.796538169343927m, "Grand Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.9m, 1439m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7596) },
                    { 12, "794 Rizal Avenue, Singkamas, Pasay, Metro Manila, Philippines", 21, new DateTime(2024, 10, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7635), null, "Student-friendly Contemporary living spaces designed for the modern lifestyle. Walking distance to Manila Central University", true, true, false, true, 14.209486942778335m, 120.564207788296793m, "Elegant Hall", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.8m, 1775m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7636) },
                    { 13, "367 EDSA, Singkamas, Mandaluyong, Metro Manila, Philippines", 9, new DateTime(2024, 7, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7847), null, "Student-friendly Budget-friendly options without compromising on quality and comfort. Walking distance to Manila Central University", true, true, false, true, 14.736073491914465m, 121.0833858772929692m, "Red Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.9m, 1837m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7849) },
                    { 14, "448 Buendia Avenue, Singkamas, Parañaque, Metro Manila, Philippines", 1, new DateTime(2024, 6, 1, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7903), null, "Stylish Affordable lodgings with essential amenities for a comfortable stay. Close to Polytechnic University of the Philippines", true, true, false, true, 14.5193077341633885m, 120.485074055549909m, "Grand Place", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.8m, 1632m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7904) },
                    { 17, "497 Katipunan Avenue, San Antonio, Parañaque, Metro Manila, Philippines", 20, new DateTime(2024, 8, 14, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8040), null, "Contemporary Contemporary living spaces designed for the modern lifestyle. Near University of Santo Tomas", true, false, false, true, 14.288756774349723m, 121.325209492446207m, "Superior Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.0m, 1131m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8041) },
                    { 20, "634 Rizal Avenue, San Isidro, Makati, Metro Manila, Philippines", 2, new DateTime(2024, 3, 15, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8147), null, "Stylish Secure and well-maintained accommodations for peace of mind. Walking distance to De La Salle University", true, true, false, true, 14.271707112038604m, 121.115808830127683m, "Red Suites", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.1m, 1121m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8148) },
                    { 21, "221 Commonwealth Avenue, Pio del Pilar, Mandaluyong, Metro Manila, Philippines", 12, new DateTime(2024, 9, 26, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8182), null, "Student-friendly Modern accommodations with convenient access to universities and business districts. Near University of Santo Tomas", true, true, false, true, 15.036221722565927m, 120.561363359651884m, "Superior Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.8m, 869m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8183) },
                    { 22, "506 Marcos Highway, Poblacion, Manila, Metro Manila, Philippines", 13, new DateTime(2024, 8, 28, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8227), null, "Comfortable Contemporary living spaces designed for the modern lifestyle. Close to Ateneo de Manila University", true, true, false, true, 15.001445752046046m, 121.0756878843312561m, "Superior Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.9m, 792m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8228) },
                    { 23, "375 Taft Avenue, San Antonio, Parañaque, Metro Manila, Philippines", 11, new DateTime(2024, 4, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8265), null, "Spacious Premium living experience with top-notch amenities and security features. Walking distance to Manila Central University", true, true, false, true, 15.050830261747972m, 120.8935273069752973m, "Elite Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.9m, 746m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8265) },
                    { 24, "707 Ayala Avenue, Guadalupe Nuevo, Manila, Metro Manila, Philippines", 12, new DateTime(2024, 6, 17, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8311), null, "Comfortable Strategically located residences for easy access to key city establishments. Near University of Santo Tomas", true, true, false, true, 14.6559328215813417m, 120.97679679880579782m, "Red Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.7m, 1762m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8312) },
                    { 26, "79 Marcos Highway, Pinagkaisahan, Pasay, Metro Manila, Philippines", 8, new DateTime(2024, 5, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8393), null, "Luxurious Affordable lodgings with essential amenities for a comfortable stay. Walking distance to Manila Central University", true, true, false, true, 14.476923594415851m, 121.455725007845613m, "Royal Residences", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.3m, 1597m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8394) },
                    { 27, "495 Rizal Avenue, Pinagkaisahan, Taguig, Metro Manila, Philippines", 1, new DateTime(2024, 3, 9, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8432), null, "Stylish Secure and well-maintained accommodations for peace of mind. Near University of the Philippines", true, true, false, true, 14.33142788950723m, 121.10945526509865m, "Green Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.3m, 277m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8433) },
                    { 28, "284 Katipunan Avenue, San Isidro, Pasig, Metro Manila, Philippines", 20, new DateTime(2025, 2, 10, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8478), null, "Stylish Affordable lodgings with essential amenities for a comfortable stay. Near AMA University", true, true, false, true, 14.258920609082757m, 121.288594211063345m, "Royal Residences", "8e445865-a24d-4543-a6c6-9443d048cdb7", 5.0m, 611m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8479) },
                    { 29, "359 EDSA, Singkamas, Pasay, Metro Manila, Philippines", 19, new DateTime(2024, 9, 7, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8515), null, "Cozy Strategically located residences for easy access to key city establishments. Near University of Santo Tomas", true, true, false, true, 14.449801331072255m, 120.750297657972061m, "Golden House", "8e445865-a24d-4543-a6c6-9443d048cdb9", 5.0m, 284m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8515) },
                    { 30, "912 Taft Avenue, Pinagkaisahan, Manila, Metro Manila, Philippines", 19, new DateTime(2024, 8, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8557), null, "Luxurious Strategically located residences for easy access to key city establishments. Near AMA University", true, true, false, true, 14.493316013072532m, 120.683785365224437m, "Orange House", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.3m, 659m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8558) },
                    { 31, "120 Ortigas Avenue, Palanan, Makati, Metro Manila, Philippines", 2, new DateTime(2024, 3, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8598), null, "Contemporary Contemporary living spaces designed for the modern lifestyle. Near University of Santo Tomas", true, true, false, false, 14.289581310546995m, 120.486104385165267m, "Golden Place", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.1m, 997m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8599) },
                    { 32, "870 Marcos Highway, Valenzuela, Pasig, Metro Manila, Philippines", 2, new DateTime(2024, 11, 7, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8627), null, "Spacious Contemporary living spaces designed for the modern lifestyle. Near AMA University", true, true, false, false, 14.5168753822303262m, 120.716705697865275m, "Grand Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.7m, 29m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8627) },
                    { 33, "85 Commonwealth Avenue, Pinagkaisahan, Parañaque, Metro Manila, Philippines", 14, new DateTime(2025, 1, 31, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8662), null, "Cozy Contemporary living spaces designed for the modern lifestyle. Near University of the Philippines", true, false, false, true, 14.911607414385354m, 120.679373220799851m, "Crystal House", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.1m, 187m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8663) },
                    { 34, "164 Ayala Avenue, Pinagkaisahan, Mandaluyong, Metro Manila, Philippines", 20, new DateTime(2024, 9, 23, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8696), null, "Comfortable A comfortable living space designed for students and young professionals. Walking distance to De La Salle University", true, true, false, true, 14.720459385121688m, 121.359073571505246m, "Royal House", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.3m, 954m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8697) },
                    { 35, "913 Taft Avenue, Pio del Pilar, Taguig, Metro Manila, Philippines", 19, new DateTime(2024, 4, 26, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8732), null, "Student-friendly Student-friendly dormitory with study areas and high-speed internet. Close to Ateneo de Manila University", true, true, false, true, 14.6974475158257166m, 120.9945239778011683m, "Grand Hall", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.1m, 703m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8733) },
                    { 36, "24 Katipunan Avenue, Palanan, Taguig, Metro Manila, Philippines", 17, new DateTime(2024, 9, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8786), null, "Professional Contemporary living spaces designed for the modern lifestyle. Close to Ateneo de Manila University", true, true, false, true, 14.453580011301711m, 121.333737953198672m, "Elite Residences", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.4m, 1860m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8787) },
                    { 37, "672 EDSA, Guadalupe Nuevo, Quezon City, Metro Manila, Philippines", 21, new DateTime(2024, 5, 14, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8812), null, "Student-friendly Luxurious residences offering the best in comfort and convenience. Close to Ateneo de Manila University", true, true, false, true, 14.343009392367447m, 120.99049088538991796m, "Central Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.4m, 1582m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8813) },
                    { 39, "5 Shaw Boulevard, Pinagkaisahan, Pasig, Metro Manila, Philippines", 11, new DateTime(2025, 2, 1, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8891), null, "Cozy Strategically located residences for easy access to key city establishments. Near Far Eastern University", true, true, false, true, 14.252413179785438m, 121.156786408756946m, "Blue House", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.0m, 1017m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8892) },
                    { 40, "424 Buendia Avenue, San Antonio, Taguig, Metro Manila, Philippines", 17, new DateTime(2025, 1, 26, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8939), null, "Stylish A comfortable living space designed for students and young professionals. Near Far Eastern University", true, true, false, true, 14.481807233932571m, 121.393567762929466m, "Superior House", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.4m, 984m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8939) },
                    { 44, "458 EDSA, Singkamas, Pasay, Metro Manila, Philippines", 12, new DateTime(2024, 8, 16, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9099), null, "Comfortable Secure and well-maintained accommodations for peace of mind. Near AMA University", true, true, false, true, 14.23164553200274m, 120.9113738582417247m, "Royal Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.7m, 774m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9100) },
                    { 45, "385 Ortigas Avenue, Singkamas, Quezon City, Metro Manila, Philippines", 21, new DateTime(2024, 4, 13, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9143), null, "Cozy Luxurious residences offering the best in comfort and convenience. Near University of the Philippines", true, true, false, true, 15.080668357180976m, 120.51966175036368m, "Blue Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.9m, 1947m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9144) },
                    { 48, "227 Ortigas Avenue, Valenzuela, Manila, Metro Manila, Philippines", 18, new DateTime(2024, 12, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9241), null, "Stylish Student-friendly dormitory with study areas and high-speed internet. Near Far Eastern University", true, true, false, false, 14.326094079391376m, 121.432734024389709m, "Premium Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.4m, 1509m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9242) },
                    { 49, "847 Taft Avenue, Singkamas, Mandaluyong, Metro Manila, Philippines", 11, new DateTime(2025, 2, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9284), null, "Modern Affordable lodgings with essential amenities for a comfortable stay. Close to University of the East", true, true, false, true, 14.5547887177352276m, 120.7529937758252m, "Grand Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.5m, 1408m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9285) },
                    { 50, "882 Marcos Highway, Guadalupe Nuevo, Mandaluyong, Metro Manila, Philippines", 14, new DateTime(2024, 7, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9316), null, "Modern Luxurious residences offering the best in comfort and convenience. Near Far Eastern University", true, true, false, true, 14.260510712460154m, 121.452217896622428m, "Golden Residences", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.4m, 1521m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9317) },
                    { 52, "690 Shaw Boulevard, Guadalupe Nuevo, Pasig, Metro Manila, Philippines", 2, new DateTime(2024, 12, 29, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9388), null, "Luxurious Secure and well-maintained accommodations for peace of mind. Close to University of the East", true, true, false, true, 14.5266525463215786m, 120.618117178555353m, "Silver Residences", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.4m, 964m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9389) },
                    { 53, "157 Ayala Avenue, San Antonio, Makati, Metro Manila, Philippines", 9, new DateTime(2024, 5, 4, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9433), null, "Comfortable Affordable lodgings with essential amenities for a comfortable stay. Close to University of the East", true, true, false, false, 14.406740380117316m, 121.439633831063767m, "Green Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.5m, 131m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9433) },
                    { 54, "669 Ayala Avenue, Valenzuela, Mandaluyong, Metro Manila, Philippines", 8, new DateTime(2024, 8, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9468), null, "Spacious Secure and well-maintained accommodations for peace of mind. Near University of the Philippines", true, true, false, false, 14.725992660784392m, 121.282753891386163m, "Crystal Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.4m, 846m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9469) },
                    { 55, "162 Rizal Avenue, Valenzuela, Quezon City, Metro Manila, Philippines", 2, new DateTime(2024, 3, 14, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9521), null, "Contemporary Secure and well-maintained accommodations for peace of mind. Close to University of the East", true, true, false, true, 14.768335108479874m, 120.9437220482254038m, "Royal House", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.6m, 1974m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9521) },
                    { 56, "621 Katipunan Avenue, Pinagkaisahan, Taguig, Metro Manila, Philippines", 17, new DateTime(2024, 4, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9562), null, "Cozy Premium living experience with top-notch amenities and security features. Walking distance to Manila Central University", true, true, false, false, 14.172717629023463m, 120.777685740802011m, "Elite Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.3m, 587m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9563) },
                    { 57, "975 Commonwealth Avenue, Guadalupe Nuevo, Pasay, Metro Manila, Philippines", 8, new DateTime(2025, 1, 14, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9600), null, "Comfortable Affordable lodgings with essential amenities for a comfortable stay. Near University of the Philippines", true, true, false, true, 14.5077613403016056m, 120.771792788826485m, "Crystal Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.5m, 1565m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9601) },
                    { 58, "88 Katipunan Avenue, Valenzuela, Mandaluyong, Metro Manila, Philippines", 1, new DateTime(2025, 1, 10, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9636), null, "Comfortable Luxurious residences offering the best in comfort and convenience. Near University of Santo Tomas", true, false, false, true, 14.460637706023239m, 120.513836007281782m, "Royal Hall", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.3m, 1125m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9637) },
                    { 59, "955 Shaw Boulevard, San Antonio, Manila, Metro Manila, Philippines", 13, new DateTime(2024, 8, 11, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9684), null, "Classic Secure and well-maintained accommodations for peace of mind. Near University of Santo Tomas", true, false, false, true, 14.5609242452482806m, 121.329138375449245m, "Central Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.8m, 138m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9684) },
                    { 60, "584 Ayala Avenue, San Isidro, Pasay, Metro Manila, Philippines", 8, new DateTime(2024, 12, 15, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9718), null, "Professional Premium living experience with top-notch amenities and security features. Near Technological University of the Philippines", true, true, false, true, 14.89410727367299m, 121.227436821490916m, "Elite Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.4m, 64m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9719) },
                    { 61, "151 Commonwealth Avenue, Valenzuela, Pasay, Metro Manila, Philippines", 13, new DateTime(2024, 4, 25, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9765), null, "Comfortable Premium living experience with top-notch amenities and security features. Near University of Santo Tomas", true, true, false, true, 14.765181345698275m, 121.372007205267161m, "Superior Place", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.6m, 227m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9766) },
                    { 62, "760 EDSA, Pinagkaisahan, Pasig, Metro Manila, Philippines", 11, new DateTime(2024, 9, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9801), null, "Luxurious Strategically located residences for easy access to key city establishments. Near University of the Philippines", true, true, false, true, 14.169450952227205m, 121.375457646908638m, "Grand Suites", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.9m, 58m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9802) },
                    { 63, "486 Taft Avenue, Pio del Pilar, Mandaluyong, Metro Manila, Philippines", 8, new DateTime(2024, 10, 1, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9828), null, "Cozy Student-friendly dormitory with study areas and high-speed internet. Near Technological University of the Philippines", true, true, false, true, 14.303250977387536m, 120.678187249487074m, "Royal House", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.4m, 1988m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9828) },
                    { 64, "957 Marcos Highway, Singkamas, Mandaluyong, Metro Manila, Philippines", 21, new DateTime(2024, 8, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9880), null, "Cozy Budget-friendly options without compromising on quality and comfort. Close to University of the East", true, true, false, false, 14.734103521150818m, 121.37495082256028m, "Central Hall", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.3m, 1469m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9881) },
                    { 65, "446 Shaw Boulevard, Poblacion, Mandaluyong, Metro Manila, Philippines", 19, new DateTime(2025, 1, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9928), null, "Stylish Student-friendly dormitory with study areas and high-speed internet. Near Technological University of the Philippines", true, true, false, true, 15.061131423310205m, 120.794744652543284m, "Grand Place", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.8m, 669m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9929) },
                    { 67, "71 Buendia Avenue, Palanan, Manila, Metro Manila, Philippines", 12, new DateTime(2024, 7, 2, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(11), null, "Student-friendly Contemporary living spaces designed for the modern lifestyle. Near University of Santo Tomas", true, false, false, true, 14.835549532301747m, 120.882829662766415m, "Grand Hall", "8e445865-a24d-4543-a6c6-9443d048cdb9", 3.8m, 1766m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(11) },
                    { 68, "211 Marcos Highway, Poblacion, Quezon City, Metro Manila, Philippines", 18, new DateTime(2025, 3, 2, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(51), null, "Modern Affordable lodgings with essential amenities for a comfortable stay. Near University of Santo Tomas", true, false, false, false, 14.271811780123185m, 121.382055953265846m, "Central Suites", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.9m, 1921m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(52) },
                    { 69, "832 Rizal Avenue, San Isidro, Mandaluyong, Metro Manila, Philippines", 10, new DateTime(2024, 8, 19, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(104), null, "Stylish Strategically located residences for easy access to key city establishments. Close to Ateneo de Manila University", true, true, false, true, 14.795725691445277m, 121.0430814912172414m, "Elite Suites", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.7m, 1919m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(105) },
                    { 70, "104 Commonwealth Avenue, Pio del Pilar, Parañaque, Metro Manila, Philippines", 10, new DateTime(2024, 8, 12, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(144), null, "Classic Secure and well-maintained accommodations for peace of mind. Near AMA University", true, true, false, true, 14.129083562179275m, 121.111531103956015m, "Purple Residences", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.3m, 1522m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(145) },
                    { 71, "389 Ortigas Avenue, Pio del Pilar, Manila, Metro Manila, Philippines", 11, new DateTime(2024, 9, 2, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(186), null, "Luxurious Secure and well-maintained accommodations for peace of mind. Walking distance to De La Salle University", true, true, false, true, 14.707497577920555m, 120.493606212256014m, "Elite House", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.7m, 1729m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(187) },
                    { 72, "227 Taft Avenue, Pio del Pilar, Pasay, Metro Manila, Philippines", 19, new DateTime(2024, 7, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(226), null, "Stylish Secure and well-maintained accommodations for peace of mind. Near University of the Philippines", true, true, false, true, 14.814396033385254m, 120.734437573520391m, "Grand Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.4m, 1522m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(227) },
                    { 74, "305 Ayala Avenue, Palanan, Quezon City, Metro Manila, Philippines", 1, new DateTime(2024, 6, 10, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(307), null, "Professional Secure and well-maintained accommodations for peace of mind. Near AMA University", true, true, false, true, 14.37338226253627m, 120.565541969818502m, "Crystal Suites", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.9m, 1757m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(307) },
                    { 75, "319 Ortigas Avenue, San Antonio, Makati, Metro Manila, Philippines", 20, new DateTime(2024, 4, 15, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(351), null, "Student-friendly Affordable lodgings with essential amenities for a comfortable stay. Walking distance to Manila Central University", true, true, false, false, 14.6918329929785491m, 120.69104433225861m, "Orange Hall", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.2m, 1732m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(352) },
                    { 77, "677 Ayala Avenue, Valenzuela, Mandaluyong, Metro Manila, Philippines", 14, new DateTime(2024, 10, 29, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(442), null, "Luxurious Affordable lodgings with essential amenities for a comfortable stay. Close to Ateneo de Manila University", true, true, false, true, 14.5565615261127528m, 120.762521868869626m, "Silver Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.2m, 244m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(443) },
                    { 78, "790 Commonwealth Avenue, Pio del Pilar, Parañaque, Metro Manila, Philippines", 10, new DateTime(2024, 4, 27, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(488), null, "Luxurious Luxurious residences offering the best in comfort and convenience. Near University of Santo Tomas", true, true, false, true, 14.238135535323357m, 121.241360864657332m, "Golden Residences", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.9m, 1050m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(489) },
                    { 79, "463 Ayala Avenue, San Antonio, Manila, Metro Manila, Philippines", 8, new DateTime(2025, 1, 29, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(532), null, "Comfortable Contemporary living spaces designed for the modern lifestyle. Close to Polytechnic University of the Philippines", true, true, false, false, 14.712002110475908m, 120.9232581703926708m, "Royal Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.2m, 1660m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(533) },
                    { 80, "712 Marcos Highway, Guadalupe Nuevo, Mandaluyong, Metro Manila, Philippines", 12, new DateTime(2024, 10, 3, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(575), null, "Student-friendly Secure and well-maintained accommodations for peace of mind. Close to University of the East", true, true, false, false, 15.072214503283014m, 121.150291047537555m, "Premium Suites", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.3m, 1192m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(576) },
                    { 82, "588 EDSA, Poblacion, Mandaluyong, Metro Manila, Philippines", 10, new DateTime(2024, 6, 26, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(659), null, "Modern Affordable lodgings with essential amenities for a comfortable stay. Near University of the Philippines", true, true, false, true, 14.825286361715657m, 120.568821529599941m, "Grand Residences", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.9m, 720m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(660) },
                    { 83, "326 Shaw Boulevard, Palanan, Taguig, Metro Manila, Philippines", 10, new DateTime(2024, 3, 25, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(701), null, "Contemporary Affordable lodgings with essential amenities for a comfortable stay. Near University of the Philippines", true, true, false, true, 14.129670936617149m, 121.0117580997241466m, "Elite House", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.9m, 1112m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(702) },
                    { 84, "972 Marcos Highway, Pio del Pilar, Makati, Metro Manila, Philippines", 10, new DateTime(2025, 2, 1, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(762), null, "Professional Affordable lodgings with essential amenities for a comfortable stay. Walking distance to Manila Central University", true, true, false, true, 14.11898057814477m, 120.620099261169089m, "Grand Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.9m, 101m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(763) },
                    { 85, "906 Ayala Avenue, San Antonio, Pasig, Metro Manila, Philippines", 12, new DateTime(2024, 5, 4, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(817), null, "Spacious A comfortable living space designed for students and young professionals. Close to Polytechnic University of the Philippines", true, true, false, true, 14.80056045934421m, 121.374783862499606m, "Red Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.9m, 1805m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(818) },
                    { 86, "273 Commonwealth Avenue, San Isidro, Parañaque, Metro Manila, Philippines", 2, new DateTime(2024, 7, 7, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(894), null, "Contemporary Budget-friendly options without compromising on quality and comfort. Near University of Santo Tomas", true, true, false, false, 15.019895911634153m, 120.9676110981241851m, "Orange Suites", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.6m, 166m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(895) },
                    { 91, "751 Ayala Avenue, San Lorenzo, Mandaluyong, Metro Manila, Philippines", 18, new DateTime(2024, 9, 9, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1107), null, "Contemporary Modern accommodations with convenient access to universities and business districts. Close to University of the East", true, true, false, true, 14.280252837648966m, 121.0136384875006222m, "Grand Residences", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.0m, 1783m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1107) },
                    { 92, "612 Ortigas Avenue, Pio del Pilar, Parañaque, Metro Manila, Philippines", 18, new DateTime(2024, 4, 22, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1147), null, "Comfortable A comfortable living space designed for students and young professionals. Near Far Eastern University", true, true, false, true, 14.478341298343074m, 120.647179998236047m, "Elite House", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.0m, 1569m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1148) },
                    { 95, "336 Shaw Boulevard, San Lorenzo, Manila, Metro Manila, Philippines", 13, new DateTime(2024, 8, 12, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1255), null, "Classic Premium living experience with top-notch amenities and security features. Close to Ateneo de Manila University", true, true, false, true, 14.381917792027079m, 121.112399503118265m, "Golden Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.9m, 225m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1256) },
                    { 96, "838 Ayala Avenue, Guadalupe Nuevo, Mandaluyong, Metro Manila, Philippines", 20, new DateTime(2024, 12, 2, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1289), null, "Spacious Contemporary living spaces designed for the modern lifestyle. Close to Polytechnic University of the Philippines", true, true, false, false, 14.771219445694107m, 121.350880838105586m, "Elegant Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.5m, 999m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1290) },
                    { 98, "238 EDSA, Valenzuela, Quezon City, Metro Manila, Philippines", 14, new DateTime(2024, 10, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1363), null, "Professional Contemporary living spaces designed for the modern lifestyle. Near University of the Philippines", true, true, false, true, 14.811238778609661m, 121.35981918835883m, "Blue Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.6m, 258m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1364) },
                    { 100, "352 Rizal Avenue, San Lorenzo, Pasay, Metro Manila, Philippines", 9, new DateTime(2024, 12, 27, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1453), null, "Spacious Affordable lodgings with essential amenities for a comfortable stay. Walking distance to De La Salle University", true, false, false, true, 14.6673658301792414m, 121.288711895777896m, "Premium Residences", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.2m, 1660m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1454) }
                });

            migrationBuilder.InsertData(
                table: "DormTags",
                columns: new[] { "Id", "DeletedAt", "DormId", "IsActive", "IsDeleted", "TagId" },
                values: new object[,]
                {
                    { 1, null, 1, true, false, 15 },
                    { 2, null, 1, true, false, 9 },
                    { 3, null, 1, true, false, 13 },
                    { 4, null, 1, true, false, 16 },
                    { 5, null, 1, true, false, 4 },
                    { 9, null, 3, true, false, 10 },
                    { 10, null, 3, true, false, 15 },
                    { 11, null, 3, true, false, 1 },
                    { 12, null, 3, true, false, 3 },
                    { 13, null, 3, true, false, 5 },
                    { 14, null, 4, true, false, 9 },
                    { 15, null, 4, true, false, 10 },
                    { 16, null, 4, true, false, 6 },
                    { 17, null, 5, true, false, 15 },
                    { 18, null, 5, true, false, 9 },
                    { 19, null, 5, true, false, 11 },
                    { 20, null, 5, true, false, 5 },
                    { 21, null, 6, true, false, 13 },
                    { 22, null, 6, true, false, 14 },
                    { 23, null, 6, true, false, 12 },
                    { 24, null, 6, true, false, 6 },
                    { 25, null, 6, true, false, 7 },
                    { 26, null, 6, true, false, 5 },
                    { 33, null, 8, true, false, 11 },
                    { 34, null, 8, true, false, 13 },
                    { 35, null, 8, true, false, 10 },
                    { 36, null, 8, true, false, 1 },
                    { 48, null, 11, true, false, 11 },
                    { 49, null, 11, true, false, 13 },
                    { 50, null, 11, true, false, 1 },
                    { 51, null, 11, true, false, 6 },
                    { 52, null, 12, true, false, 12 },
                    { 53, null, 12, true, false, 15 },
                    { 54, null, 12, true, false, 13 },
                    { 55, null, 12, true, false, 9 },
                    { 56, null, 12, true, false, 2 },
                    { 57, null, 12, true, false, 6 },
                    { 58, null, 13, true, false, 15 },
                    { 59, null, 13, true, false, 12 },
                    { 60, null, 13, true, false, 1 },
                    { 61, null, 14, true, false, 9 },
                    { 62, null, 14, true, false, 10 },
                    { 63, null, 14, true, false, 11 },
                    { 64, null, 14, true, false, 6 },
                    { 65, null, 14, true, false, 8 },
                    { 75, null, 17, true, false, 10 },
                    { 76, null, 17, true, false, 13 },
                    { 77, null, 17, true, false, 15 },
                    { 78, null, 17, true, false, 6 },
                    { 89, null, 20, true, false, 14 },
                    { 90, null, 20, true, false, 12 },
                    { 91, null, 20, true, false, 8 },
                    { 92, null, 20, true, false, 7 },
                    { 93, null, 20, true, false, 1 },
                    { 94, null, 21, true, false, 15 },
                    { 95, null, 21, true, false, 14 },
                    { 96, null, 21, true, false, 10 },
                    { 97, null, 21, true, false, 9 },
                    { 98, null, 21, true, false, 8 },
                    { 99, null, 21, true, false, 4 },
                    { 100, null, 22, true, false, 9 },
                    { 101, null, 22, true, false, 15 },
                    { 102, null, 22, true, false, 16 },
                    { 103, null, 22, true, false, 13 },
                    { 104, null, 22, true, false, 6 },
                    { 105, null, 23, true, false, 11 },
                    { 106, null, 23, true, false, 9 },
                    { 107, null, 23, true, false, 8 },
                    { 108, null, 23, true, false, 3 },
                    { 109, null, 24, true, false, 11 },
                    { 110, null, 24, true, false, 13 },
                    { 111, null, 24, true, false, 15 },
                    { 112, null, 24, true, false, 12 },
                    { 113, null, 24, true, false, 1 },
                    { 119, null, 26, true, false, 16 },
                    { 120, null, 26, true, false, 14 },
                    { 121, null, 26, true, false, 10 },
                    { 122, null, 26, true, false, 8 },
                    { 123, null, 26, true, false, 5 },
                    { 124, null, 26, true, false, 3 },
                    { 125, null, 27, true, false, 15 },
                    { 126, null, 27, true, false, 12 },
                    { 127, null, 27, true, false, 10 },
                    { 128, null, 27, true, false, 9 },
                    { 129, null, 27, true, false, 8 },
                    { 130, null, 27, true, false, 6 },
                    { 131, null, 28, true, false, 16 },
                    { 132, null, 28, true, false, 1 },
                    { 133, null, 28, true, false, 6 },
                    { 134, null, 29, true, false, 15 },
                    { 135, null, 29, true, false, 12 },
                    { 136, null, 29, true, false, 9 },
                    { 137, null, 29, true, false, 13 },
                    { 138, null, 29, true, false, 5 },
                    { 139, null, 29, true, false, 8 },
                    { 140, null, 30, true, false, 12 },
                    { 141, null, 30, true, false, 14 },
                    { 142, null, 30, true, false, 1 },
                    { 143, null, 30, true, false, 5 },
                    { 144, null, 30, true, false, 4 },
                    { 145, null, 31, true, false, 15 },
                    { 146, null, 31, true, false, 11 },
                    { 147, null, 31, true, false, 1 },
                    { 148, null, 32, true, false, 11 },
                    { 149, null, 32, true, false, 15 },
                    { 150, null, 32, true, false, 9 },
                    { 151, null, 32, true, false, 8 },
                    { 152, null, 32, true, false, 5 },
                    { 153, null, 33, true, false, 15 },
                    { 154, null, 33, true, false, 10 },
                    { 155, null, 33, true, false, 5 },
                    { 156, null, 34, true, false, 16 },
                    { 157, null, 34, true, false, 12 },
                    { 158, null, 34, true, false, 14 },
                    { 159, null, 34, true, false, 9 },
                    { 160, null, 34, true, false, 1 },
                    { 161, null, 35, true, false, 11 },
                    { 162, null, 35, true, false, 13 },
                    { 163, null, 35, true, false, 12 },
                    { 164, null, 35, true, false, 9 },
                    { 165, null, 35, true, false, 7 },
                    { 166, null, 35, true, false, 5 },
                    { 167, null, 35, true, false, 3 },
                    { 168, null, 36, true, false, 14 },
                    { 169, null, 36, true, false, 15 },
                    { 170, null, 36, true, false, 2 },
                    { 171, null, 36, true, false, 3 },
                    { 172, null, 36, true, false, 5 },
                    { 173, null, 37, true, false, 16 },
                    { 174, null, 37, true, false, 9 },
                    { 175, null, 37, true, false, 14 },
                    { 176, null, 37, true, false, 2 },
                    { 181, null, 39, true, false, 14 },
                    { 182, null, 39, true, false, 13 },
                    { 183, null, 39, true, false, 2 },
                    { 184, null, 39, true, false, 3 },
                    { 185, null, 40, true, false, 15 },
                    { 186, null, 40, true, false, 16 },
                    { 187, null, 40, true, false, 11 },
                    { 188, null, 40, true, false, 13 },
                    { 189, null, 40, true, false, 8 },
                    { 201, null, 44, true, false, 14 },
                    { 202, null, 44, true, false, 10 },
                    { 203, null, 44, true, false, 16 },
                    { 204, null, 44, true, false, 11 },
                    { 205, null, 44, true, false, 2 },
                    { 206, null, 45, true, false, 13 },
                    { 207, null, 45, true, false, 9 },
                    { 208, null, 45, true, false, 1 },
                    { 209, null, 45, true, false, 5 },
                    { 210, null, 45, true, false, 2 },
                    { 222, null, 48, true, false, 16 },
                    { 223, null, 48, true, false, 9 },
                    { 224, null, 48, true, false, 11 },
                    { 225, null, 48, true, false, 7 },
                    { 226, null, 49, true, false, 13 },
                    { 227, null, 49, true, false, 11 },
                    { 228, null, 49, true, false, 14 },
                    { 229, null, 49, true, false, 2 },
                    { 230, null, 49, true, false, 6 },
                    { 231, null, 49, true, false, 4 },
                    { 232, null, 50, true, false, 12 },
                    { 233, null, 50, true, false, 13 },
                    { 234, null, 50, true, false, 6 },
                    { 235, null, 50, true, false, 5 },
                    { 236, null, 50, true, false, 7 },
                    { 242, null, 52, true, false, 14 },
                    { 243, null, 52, true, false, 16 },
                    { 244, null, 52, true, false, 15 },
                    { 245, null, 52, true, false, 11 },
                    { 246, null, 52, true, false, 9 },
                    { 247, null, 52, true, false, 6 },
                    { 248, null, 53, true, false, 13 },
                    { 249, null, 53, true, false, 11 },
                    { 250, null, 53, true, false, 3 },
                    { 251, null, 53, true, false, 2 },
                    { 252, null, 54, true, false, 14 },
                    { 253, null, 54, true, false, 6 },
                    { 254, null, 55, true, false, 11 },
                    { 255, null, 55, true, false, 12 },
                    { 256, null, 55, true, false, 14 },
                    { 257, null, 55, true, false, 4 },
                    { 258, null, 56, true, false, 13 },
                    { 259, null, 56, true, false, 9 },
                    { 260, null, 56, true, false, 16 },
                    { 261, null, 56, true, false, 12 },
                    { 262, null, 56, true, false, 7 },
                    { 263, null, 57, true, false, 9 },
                    { 264, null, 57, true, false, 12 },
                    { 265, null, 57, true, false, 16 },
                    { 266, null, 57, true, false, 6 },
                    { 267, null, 58, true, false, 9 },
                    { 268, null, 58, true, false, 15 },
                    { 269, null, 58, true, false, 11 },
                    { 270, null, 58, true, false, 6 },
                    { 271, null, 58, true, false, 7 },
                    { 272, null, 59, true, false, 13 },
                    { 273, null, 59, true, false, 12 },
                    { 274, null, 59, true, false, 3 },
                    { 275, null, 60, true, false, 10 },
                    { 276, null, 60, true, false, 9 },
                    { 277, null, 60, true, false, 13 },
                    { 278, null, 60, true, false, 7 },
                    { 279, null, 60, true, false, 6 },
                    { 280, null, 61, true, false, 15 },
                    { 281, null, 61, true, false, 12 },
                    { 282, null, 61, true, false, 14 },
                    { 283, null, 61, true, false, 10 },
                    { 284, null, 61, true, false, 2 },
                    { 285, null, 62, true, false, 13 },
                    { 286, null, 62, true, false, 9 },
                    { 287, null, 62, true, false, 4 },
                    { 288, null, 62, true, false, 2 },
                    { 289, null, 62, true, false, 7 },
                    { 290, null, 63, true, false, 16 },
                    { 291, null, 63, true, false, 9 },
                    { 292, null, 63, true, false, 13 },
                    { 293, null, 63, true, false, 12 },
                    { 294, null, 63, true, false, 15 },
                    { 295, null, 63, true, false, 4 },
                    { 296, null, 63, true, false, 1 },
                    { 297, null, 64, true, false, 12 },
                    { 298, null, 64, true, false, 15 },
                    { 299, null, 64, true, false, 13 },
                    { 300, null, 64, true, false, 9 },
                    { 301, null, 64, true, false, 11 },
                    { 302, null, 64, true, false, 6 },
                    { 303, null, 65, true, false, 9 },
                    { 304, null, 65, true, false, 14 },
                    { 305, null, 65, true, false, 13 },
                    { 306, null, 65, true, false, 12 },
                    { 307, null, 65, true, false, 7 },
                    { 314, null, 67, true, false, 15 },
                    { 315, null, 67, true, false, 12 },
                    { 316, null, 67, true, false, 1 },
                    { 317, null, 67, true, false, 8 },
                    { 318, null, 68, true, false, 10 },
                    { 319, null, 68, true, false, 9 },
                    { 320, null, 68, true, false, 12 },
                    { 321, null, 68, true, false, 4 },
                    { 322, null, 68, true, false, 3 },
                    { 323, null, 69, true, false, 14 },
                    { 324, null, 69, true, false, 10 },
                    { 325, null, 69, true, false, 7 },
                    { 326, null, 70, true, false, 11 },
                    { 327, null, 70, true, false, 12 },
                    { 328, null, 70, true, false, 14 },
                    { 329, null, 70, true, false, 15 },
                    { 330, null, 70, true, false, 5 },
                    { 331, null, 71, true, false, 9 },
                    { 332, null, 71, true, false, 10 },
                    { 333, null, 71, true, false, 12 },
                    { 334, null, 71, true, false, 7 },
                    { 335, null, 71, true, false, 2 },
                    { 336, null, 72, true, false, 16 },
                    { 337, null, 72, true, false, 15 },
                    { 338, null, 72, true, false, 6 },
                    { 339, null, 72, true, false, 3 },
                    { 340, null, 72, true, false, 8 },
                    { 346, null, 74, true, false, 12 },
                    { 347, null, 74, true, false, 15 },
                    { 348, null, 74, true, false, 2 },
                    { 349, null, 75, true, false, 12 },
                    { 350, null, 75, true, false, 10 },
                    { 351, null, 75, true, false, 14 },
                    { 352, null, 75, true, false, 11 },
                    { 353, null, 75, true, false, 3 },
                    { 360, null, 77, true, false, 14 },
                    { 361, null, 77, true, false, 13 },
                    { 362, null, 77, true, false, 2 },
                    { 363, null, 77, true, false, 1 },
                    { 364, null, 77, true, false, 3 },
                    { 365, null, 78, true, false, 14 },
                    { 366, null, 78, true, false, 10 },
                    { 367, null, 78, true, false, 9 },
                    { 368, null, 78, true, false, 5 },
                    { 369, null, 79, true, false, 15 },
                    { 370, null, 79, true, false, 11 },
                    { 371, null, 79, true, false, 12 },
                    { 372, null, 79, true, false, 6 },
                    { 373, null, 79, true, false, 8 },
                    { 374, null, 80, true, false, 14 },
                    { 375, null, 80, true, false, 12 },
                    { 376, null, 80, true, false, 10 },
                    { 377, null, 80, true, false, 2 },
                    { 386, null, 82, true, false, 16 },
                    { 387, null, 82, true, false, 10 },
                    { 388, null, 82, true, false, 12 },
                    { 389, null, 82, true, false, 6 },
                    { 390, null, 82, true, false, 1 },
                    { 391, null, 83, true, false, 9 },
                    { 392, null, 83, true, false, 11 },
                    { 393, null, 83, true, false, 15 },
                    { 394, null, 83, true, false, 5 },
                    { 395, null, 83, true, false, 1 },
                    { 396, null, 83, true, false, 6 },
                    { 397, null, 84, true, false, 10 },
                    { 398, null, 84, true, false, 11 },
                    { 399, null, 84, true, false, 14 },
                    { 400, null, 84, true, false, 6 },
                    { 401, null, 84, true, false, 7 },
                    { 402, null, 85, true, false, 12 },
                    { 403, null, 85, true, false, 14 },
                    { 404, null, 85, true, false, 13 },
                    { 405, null, 85, true, false, 2 },
                    { 406, null, 85, true, false, 7 },
                    { 407, null, 86, true, false, 16 },
                    { 408, null, 86, true, false, 11 },
                    { 409, null, 86, true, false, 9 },
                    { 410, null, 86, true, false, 10 },
                    { 411, null, 86, true, false, 6 },
                    { 412, null, 86, true, false, 1 },
                    { 432, null, 91, true, false, 11 },
                    { 433, null, 91, true, false, 13 },
                    { 434, null, 91, true, false, 5 },
                    { 435, null, 91, true, false, 2 },
                    { 436, null, 92, true, false, 10 },
                    { 437, null, 92, true, false, 15 },
                    { 438, null, 92, true, false, 13 },
                    { 439, null, 92, true, false, 3 },
                    { 440, null, 92, true, false, 7 },
                    { 449, null, 95, true, false, 14 },
                    { 450, null, 95, true, false, 16 },
                    { 451, null, 95, true, false, 3 },
                    { 452, null, 95, true, false, 6 },
                    { 453, null, 96, true, false, 12 },
                    { 454, null, 96, true, false, 16 },
                    { 455, null, 96, true, false, 3 },
                    { 456, null, 96, true, false, 4 },
                    { 463, null, 98, true, false, 13 },
                    { 464, null, 98, true, false, 9 },
                    { 465, null, 98, true, false, 3 },
                    { 466, null, 98, true, false, 8 },
                    { 473, null, 100, true, false, 12 },
                    { 474, null, 100, true, false, 10 },
                    { 475, null, 100, true, false, 1 },
                    { 476, null, 100, true, false, 7 },
                    { 477, null, 100, true, false, 2 }
                });

            migrationBuilder.InsertData(
                table: "Dorms",
                columns: new[] { "Id", "Address", "CategoryId", "CreatedAt", "DeletedAt", "Description", "IsActive", "IsAvailable", "IsDeleted", "IsVerified", "Latitude", "Longitude", "Name", "OwnerId", "Rating", "SecurityDeposit", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, "55 Ayala Avenue, Poblacion, Makati, Metro Manila, Philippines", 4, new DateTime(2024, 11, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7129), null, "Professional Affordable lodgings with essential amenities for a comfortable stay. Close to Polytechnic University of the Philippines", true, true, false, true, 14.156894916218424m, 121.22097171940765m, "Green Residences", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.1m, 1970m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7131) },
                    { 7, "948 Buendia Avenue, Pinagkaisahan, Taguig, Metro Manila, Philippines", 6, new DateTime(2025, 1, 29, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7402), null, "Stylish A comfortable living space designed for students and young professionals. Close to Ateneo de Manila University", true, true, false, true, 15.009341792615988m, 121.168158487438019m, "Red Residences", "8e445865-a24d-4543-a6c6-9443d048cdb7", 4.9m, 56m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7402) },
                    { 9, "97 Commonwealth Avenue, San Lorenzo, Manila, Metro Manila, Philippines", 5, new DateTime(2025, 2, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7490), null, "Classic Premium living experience with top-notch amenities and security features. Close to Ateneo de Manila University", true, false, false, true, 14.173004141566113m, 121.187105080608514m, "Silver Hall", "8e445865-a24d-4543-a6c6-9443d048cdb8", 4.3m, 1221m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7490) },
                    { 10, "353 Ayala Avenue, San Isidro, Pasay, Metro Manila, Philippines", 4, new DateTime(2024, 12, 7, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7549), null, "Classic A comfortable living space designed for students and young professionals. Near Technological University of the Philippines", true, true, false, true, 14.433714096113208m, 121.208674068137106m, "Premium Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.6m, 1953m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7550) },
                    { 15, "125 Rizal Avenue, San Antonio, Quezon City, Metro Manila, Philippines", 4, new DateTime(2024, 11, 16, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7949), null, "Contemporary Strategically located residences for easy access to key city establishments. Walking distance to Manila Central University", true, true, false, true, 14.202212585638609m, 120.9001958881400506m, "Golden Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.6m, 257m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7950) },
                    { 16, "982 Buendia Avenue, San Lorenzo, Pasig, Metro Manila, Philippines", 7, new DateTime(2024, 12, 31, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7985), null, "Modern Modern accommodations with convenient access to universities and business districts. Near University of Santo Tomas", true, true, false, true, 14.263254592725893m, 121.291594998058395m, "Red Residences", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.2m, 1473m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7986) },
                    { 18, "841 EDSA, Pio del Pilar, Pasig, Metro Manila, Philippines", 4, new DateTime(2024, 3, 16, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8075), null, "Comfortable Modern accommodations with convenient access to universities and business districts. Near Technological University of the Philippines", true, true, false, true, 14.6603682979647388m, 120.799841013586727m, "Elite Suites", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.9m, 225m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8075) },
                    { 19, "259 EDSA, Singkamas, Makati, Metro Manila, Philippines", 4, new DateTime(2024, 7, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8107), null, "Modern Strategically located residences for easy access to key city establishments. Walking distance to Manila Central University", true, true, false, true, 14.5787538245577616m, 121.09748374157347m, "Elegant Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.9m, 160m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8108) },
                    { 25, "815 Commonwealth Avenue, Pio del Pilar, Makati, Metro Manila, Philippines", 6, new DateTime(2024, 3, 30, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8356), null, "Student-friendly Premium living experience with top-notch amenities and security features. Walking distance to De La Salle University", true, true, false, true, 14.349767003313763m, 120.617309149585063m, "Orange Living Spaces", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.5m, 928m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8357) },
                    { 38, "847 Commonwealth Avenue, San Antonio, Parañaque, Metro Manila, Philippines", 4, new DateTime(2024, 9, 17, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8855), null, "Professional Luxurious residences offering the best in comfort and convenience. Close to Ateneo de Manila University", true, true, false, true, 14.932996611022156m, 120.784147240063896m, "Orange Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.1m, 387m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8856) },
                    { 41, "157 Ortigas Avenue, San Antonio, Mandaluyong, Metro Manila, Philippines", 5, new DateTime(2024, 9, 17, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8987), null, "Comfortable Student-friendly dormitory with study areas and high-speed internet. Near University of Santo Tomas", true, false, false, true, 14.388432837680417m, 121.114696884989784m, "Green Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.2m, 1818m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8988) },
                    { 42, "452 Ortigas Avenue, San Lorenzo, Pasay, Metro Manila, Philippines", 5, new DateTime(2024, 3, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9030), null, "Classic Affordable lodgings with essential amenities for a comfortable stay. Near Technological University of the Philippines", true, true, false, true, 15.029685114466671m, 120.530010238013887m, "Red Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.6m, 1387m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9031) },
                    { 43, "563 Taft Avenue, San Antonio, Mandaluyong, Metro Manila, Philippines", 4, new DateTime(2024, 11, 19, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9069), null, "Classic Luxurious residences offering the best in comfort and convenience. Close to Polytechnic University of the Philippines", true, true, false, false, 14.422955596958965m, 120.867748808928369m, "Superior Suites", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.9m, 1001m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9069) },
                    { 46, "536 Shaw Boulevard, Palanan, Manila, Metro Manila, Philippines", 5, new DateTime(2025, 2, 24, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9173), null, "Stylish Strategically located residences for easy access to key city establishments. Near Far Eastern University", true, true, false, false, 14.701791154955649m, 121.453501833756874m, "Green Dormitory", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.1m, 1048m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9173) },
                    { 47, "988 Commonwealth Avenue, Valenzuela, Taguig, Metro Manila, Philippines", 6, new DateTime(2024, 12, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9212), null, "Cozy Modern accommodations with convenient access to universities and business districts. Close to Ateneo de Manila University", true, false, false, false, 14.5321248413103748m, 121.12459903350193m, "Green Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb5", 4.6m, 1650m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9213) },
                    { 51, "760 Commonwealth Avenue, San Isidro, Taguig, Metro Manila, Philippines", 5, new DateTime(2024, 10, 19, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9356), null, "Spacious Secure and well-maintained accommodations for peace of mind. Close to University of the East", true, false, false, true, 14.79631064584144m, 120.587941135962187m, "Red Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.1m, 611m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9357) },
                    { 66, "139 Ayala Avenue, San Lorenzo, Pasay, Metro Manila, Philippines", 6, new DateTime(2024, 9, 4, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9969), null, "Spacious Strategically located residences for easy access to key city establishments. Near Far Eastern University", true, true, false, true, 14.703787387153268m, 120.98781255533230143m, "Red Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.6m, 505m, new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9970) },
                    { 73, "8 Buendia Avenue, Poblacion, Quezon City, Metro Manila, Philippines", 4, new DateTime(2024, 10, 22, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(265), null, "Classic Secure and well-maintained accommodations for peace of mind. Walking distance to Manila Central University", true, false, false, true, 14.320325791927439m, 120.732534739472873m, "Superior Dwellings", "8e445865-a24d-4543-a6c6-9443d048cdb9", 4.6m, 1944m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(266) },
                    { 76, "91 Katipunan Avenue, San Isidro, Taguig, Metro Manila, Philippines", 6, new DateTime(2025, 1, 4, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(400), null, "Modern Secure and well-maintained accommodations for peace of mind. Walking distance to De La Salle University", true, true, false, true, 14.379550117652887m, 120.811142487772062m, "Crystal Suites", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.5m, 266m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(400) },
                    { 81, "61 Ortigas Avenue, San Lorenzo, Parañaque, Metro Manila, Philippines", 4, new DateTime(2024, 10, 13, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(615), null, "Stylish Contemporary living spaces designed for the modern lifestyle. Close to Ateneo de Manila University", true, false, false, true, 14.734483467233825m, 120.542509524347218m, "Elite Place", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.8m, 242m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(616) },
                    { 87, "923 Marcos Highway, Valenzuela, Makati, Metro Manila, Philippines", 6, new DateTime(2024, 6, 10, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(947), null, "Modern A comfortable living space designed for students and young professionals. Near AMA University", true, true, false, true, 14.445629113038131m, 120.880850364341517m, "Purple Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.9m, 246m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(948) },
                    { 88, "155 EDSA, San Isidro, Quezon City, Metro Manila, Philippines", 6, new DateTime(2024, 12, 15, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(979), null, "Classic A comfortable living space designed for students and young professionals. Close to Ateneo de Manila University", true, true, false, false, 14.975764903171111m, 121.43046584367187m, "Elegant Hall", "8e445865-a24d-4543-a6c6-9443d048cdb8", 3.9m, 1919m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(980) },
                    { 89, "840 Commonwealth Avenue, Guadalupe Nuevo, Parañaque, Metro Manila, Philippines", 6, new DateTime(2024, 9, 18, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1016), null, "Cozy Modern accommodations with convenient access to universities and business districts. Near University of the Philippines", true, true, false, true, 15.026014448098147m, 121.0743912998362404m, "Silver Quarters", "8e445865-a24d-4543-a6c6-9443d048cdb5", 3.1m, 1327m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1017) },
                    { 90, "745 Ortigas Avenue, San Antonio, Taguig, Metro Manila, Philippines", 4, new DateTime(2025, 2, 20, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1060), null, "Cozy Premium living experience with top-notch amenities and security features. Close to Polytechnic University of the Philippines", true, true, false, true, 14.297469590405919m, 121.165819949490586m, "Green Hall", "8e445865-a24d-4543-a6c6-9443d048cdb7", 3.9m, 2m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1061) },
                    { 93, "534 Taft Avenue, Poblacion, Manila, Metro Manila, Philippines", 4, new DateTime(2024, 6, 16, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1178), null, "Professional Premium living experience with top-notch amenities and security features. Close to Polytechnic University of the Philippines", true, true, false, true, 14.455994013851739m, 121.0403289384756838m, "Red House", "8e445865-a24d-4543-a6c6-9443d048cdb6", 3.6m, 1950m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1178) },
                    { 94, "991 Shaw Boulevard, Pinagkaisahan, Pasig, Metro Manila, Philippines", 6, new DateTime(2024, 6, 26, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1224), null, "Comfortable A comfortable living space designed for students and young professionals. Walking distance to Manila Central University", true, true, false, true, 14.4052392268934m, 120.757438752630185m, "Elite Place", "8e445865-a24d-4543-a6c6-9443d048cdb5", 5.0m, 1038m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1225) },
                    { 97, "204 Commonwealth Avenue, Pio del Pilar, Taguig, Metro Manila, Philippines", 5, new DateTime(2024, 6, 12, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1324), null, "Cozy Strategically located residences for easy access to key city establishments. Near University of Santo Tomas", true, true, false, true, 14.137094234122706m, 120.98257581044918661m, "Premium Suites", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.4m, 996m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1325) },
                    { 99, "734 Commonwealth Avenue, Guadalupe Nuevo, Pasig, Metro Manila, Philippines", 7, new DateTime(2025, 1, 14, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1402), null, "Luxurious Strategically located residences for easy access to key city establishments. Walking distance to De La Salle University", true, true, false, true, 14.953734065792632m, 121.463340215077968m, "Central Lodgings", "8e445865-a24d-4543-a6c6-9443d048cdb6", 4.0m, 1255m, new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1403) }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Caption", "CreatedAt", "DeletedAt", "DormId", "IsActive", "IsDeleted", "IsPrimary", "Order", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { 1, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(6713), null, 1, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(6713), "https://loremflickr.com/1200/900/house/all?lock=593" },
                    { 2, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7062), null, 1, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7062), "https://loremflickr.com/800/900/house/all?lock=214" },
                    { 3, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7065), null, 1, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7065), "https://loremflickr.com/800/768/house/all?lock=265" },
                    { 4, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7067), null, 1, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7067), "https://loremflickr.com/1024/900/house/all?lock=257" },
                    { 5, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7078), null, 1, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7078), "https://loremflickr.com/800/768/house/all?lock=927" },
                    { 6, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7081), null, 1, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7081), "https://loremflickr.com/1200/600/house/all?lock=846" },
                    { 13, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7248), null, 3, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7248), "https://loremflickr.com/800/900/house/all?lock=451" },
                    { 14, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7249), null, 3, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7250), "https://loremflickr.com/800/600/house/all?lock=1124" },
                    { 15, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7251), null, 3, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7251), "https://loremflickr.com/800/768/house/all?lock=760" },
                    { 16, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7253), null, 3, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7253), "https://loremflickr.com/800/900/house/all?lock=473" },
                    { 17, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7280), null, 4, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7281), "https://loremflickr.com/1024/768/house/all?lock=602" },
                    { 18, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7283), null, 4, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7283), "https://loremflickr.com/800/600/house/all?lock=1290" },
                    { 19, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7285), null, 4, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7285), "https://loremflickr.com/1200/600/house/all?lock=1169" },
                    { 20, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7286), null, 4, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7287), "https://loremflickr.com/1024/768/house/all?lock=940" },
                    { 21, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7288), null, 4, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7288), "https://loremflickr.com/800/600/house/all?lock=921" },
                    { 22, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7289), null, 4, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7290), "https://loremflickr.com/800/600/house/all?lock=690" },
                    { 23, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7349), null, 5, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7349), "https://loremflickr.com/800/900/house/all?lock=1465" },
                    { 24, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7350), null, 5, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7350), "https://loremflickr.com/1024/600/house/all?lock=1239" },
                    { 25, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7352), null, 5, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7352), "https://loremflickr.com/1024/900/house/all?lock=641" },
                    { 26, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7384), null, 6, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7384), "https://loremflickr.com/800/768/house/all?lock=1395" },
                    { 27, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7386), null, 6, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7386), "https://loremflickr.com/1024/600/house/all?lock=833" },
                    { 28, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7388), null, 6, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7388), "https://loremflickr.com/800/600/house/all?lock=1086" },
                    { 29, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7389), null, 6, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7390), "https://loremflickr.com/1024/900/house/all?lock=1495" },
                    { 30, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7391), null, 6, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7391), "https://loremflickr.com/1200/900/house/all?lock=1466" },
                    { 31, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7392), null, 6, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7393), "https://loremflickr.com/1024/900/house/all?lock=1415" },
                    { 37, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7478), null, 8, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7478), "https://loremflickr.com/1024/600/house/all?lock=1620" },
                    { 38, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7480), null, 8, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7480), "https://loremflickr.com/1024/600/house/all?lock=1453" },
                    { 39, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7481), null, 8, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7482), "https://loremflickr.com/800/600/house/all?lock=1467" },
                    { 51, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7622), null, 11, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7622), "https://loremflickr.com/800/900/house/all?lock=2038" },
                    { 52, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7624), null, 11, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7624), "https://loremflickr.com/1024/768/house/all?lock=1349" },
                    { 53, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7625), null, 11, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7626), "https://loremflickr.com/800/900/house/all?lock=1270" },
                    { 54, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7627), null, 11, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7627), "https://loremflickr.com/1024/768/house/all?lock=1768" },
                    { 55, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7813), null, 12, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7813), "https://loremflickr.com/1200/600/house/all?lock=1337" },
                    { 56, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7822), null, 12, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7823), "https://loremflickr.com/1200/768/house/all?lock=1494" },
                    { 57, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7824), null, 12, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7825), "https://loremflickr.com/800/768/house/all?lock=1357" },
                    { 58, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7826), null, 12, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7827), "https://loremflickr.com/1024/600/house/all?lock=1313" },
                    { 59, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7828), null, 12, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7828), "https://loremflickr.com/1200/900/house/all?lock=1423" },
                    { 60, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7884), null, 13, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7884), "https://loremflickr.com/1024/600/house/all?lock=1318" },
                    { 61, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7885), null, 13, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7886), "https://loremflickr.com/800/768/house/all?lock=2078" },
                    { 62, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7887), null, 13, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7887), "https://loremflickr.com/1200/600/house/all?lock=1328" },
                    { 63, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7888), null, 13, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7889), "https://loremflickr.com/1024/768/house/all?lock=2296" },
                    { 64, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7890), null, 13, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7890), "https://loremflickr.com/800/768/house/all?lock=1941" },
                    { 65, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7892), null, 13, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7892), "https://loremflickr.com/1200/600/house/all?lock=1527" },
                    { 66, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7938), null, 14, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7938), "https://loremflickr.com/1200/600/house/all?lock=1618" },
                    { 67, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7939), null, 14, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7940), "https://loremflickr.com/1200/768/house/all?lock=1875" },
                    { 68, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7941), null, 14, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7941), "https://loremflickr.com/1200/768/house/all?lock=1442" },
                    { 80, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8057), null, 17, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8057), "https://loremflickr.com/800/600/house/all?lock=2473" },
                    { 81, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8059), null, 17, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8059), "https://loremflickr.com/1200/768/house/all?lock=2211" },
                    { 82, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8060), null, 17, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8061), "https://loremflickr.com/1024/900/house/all?lock=2388" },
                    { 89, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8169), null, 20, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8169), "https://loremflickr.com/1024/600/house/all?lock=2332" },
                    { 90, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8171), null, 20, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8171), "https://loremflickr.com/1200/600/house/all?lock=2675" },
                    { 91, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8172), null, 20, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8173), "https://loremflickr.com/1200/600/house/all?lock=2020" },
                    { 92, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8174), null, 20, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8174), "https://loremflickr.com/1200/768/house/all?lock=2804" },
                    { 93, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8204), null, 21, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8204), "https://loremflickr.com/1200/900/house/all?lock=2464" },
                    { 94, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8206), null, 21, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8206), "https://loremflickr.com/800/768/house/all?lock=2677" },
                    { 95, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8207), null, 21, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8207), "https://loremflickr.com/1200/600/house/all?lock=2410" },
                    { 96, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8209), null, 21, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8209), "https://loremflickr.com/1200/600/house/all?lock=2471" },
                    { 97, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8210), null, 21, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8211), "https://loremflickr.com/1200/600/house/all?lock=2957" },
                    { 98, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8212), null, 21, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8212), "https://loremflickr.com/1200/768/house/all?lock=2742" },
                    { 99, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8249), null, 22, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8249), "https://loremflickr.com/800/768/house/all?lock=2438" },
                    { 100, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8250), null, 22, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8250), "https://loremflickr.com/1200/768/house/all?lock=2532" },
                    { 101, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8252), null, 22, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8252), "https://loremflickr.com/1024/600/house/all?lock=2884" },
                    { 102, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8253), null, 22, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8254), "https://loremflickr.com/1200/768/house/all?lock=2800" },
                    { 103, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8255), null, 22, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8255), "https://loremflickr.com/1200/600/house/all?lock=3181" },
                    { 104, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8257), null, 22, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8257), "https://loremflickr.com/800/600/house/all?lock=3188" },
                    { 105, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8295), null, 23, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8295), "https://loremflickr.com/1200/600/house/all?lock=3260" },
                    { 106, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8296), null, 23, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8297), "https://loremflickr.com/1200/900/house/all?lock=2630" },
                    { 107, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8298), null, 23, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8298), "https://loremflickr.com/1024/768/house/all?lock=3145" },
                    { 108, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8341), null, 24, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8341), "https://loremflickr.com/1024/600/house/all?lock=3003" },
                    { 109, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8342), null, 24, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8343), "https://loremflickr.com/1024/600/house/all?lock=3301" },
                    { 110, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8344), null, 24, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8344), "https://loremflickr.com/1200/900/house/all?lock=2796" },
                    { 111, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8345), null, 24, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8346), "https://loremflickr.com/1024/600/house/all?lock=3049" },
                    { 112, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8347), null, 24, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8347), "https://loremflickr.com/800/768/house/all?lock=2933" },
                    { 113, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8349), null, 24, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8349), "https://loremflickr.com/800/768/house/all?lock=3355" },
                    { 120, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8419), null, 26, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8420), "https://loremflickr.com/800/600/house/all?lock=3368" },
                    { 121, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8421), null, 26, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8421), "https://loremflickr.com/800/600/house/all?lock=3542" },
                    { 122, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8423), null, 26, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8423), "https://loremflickr.com/1024/600/house/all?lock=2837" },
                    { 123, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8424), null, 26, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8424), "https://loremflickr.com/800/900/house/all?lock=2656" },
                    { 124, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8462), null, 27, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8462), "https://loremflickr.com/1024/900/house/all?lock=2872" },
                    { 125, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8463), null, 27, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8464), "https://loremflickr.com/1024/600/house/all?lock=3612" },
                    { 126, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8465), null, 27, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8465), "https://loremflickr.com/1024/768/house/all?lock=2702" },
                    { 127, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8467), null, 27, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8467), "https://loremflickr.com/1024/768/house/all?lock=2909" },
                    { 128, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8468), null, 27, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8468), "https://loremflickr.com/1200/768/house/all?lock=3089" },
                    { 129, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8470), null, 27, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8470), "https://loremflickr.com/1200/768/house/all?lock=3279" },
                    { 130, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8498), null, 28, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8498), "https://loremflickr.com/1200/600/house/all?lock=3007" },
                    { 131, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8500), null, 28, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8500), "https://loremflickr.com/1024/900/house/all?lock=3772" },
                    { 132, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8507), null, 28, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8507), "https://loremflickr.com/800/768/house/all?lock=3650" },
                    { 133, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8533), null, 29, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8533), "https://loremflickr.com/800/768/house/all?lock=3715" },
                    { 134, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8535), null, 29, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8535), "https://loremflickr.com/800/768/house/all?lock=3768" },
                    { 135, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8536), null, 29, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8536), "https://loremflickr.com/1024/600/house/all?lock=3804" },
                    { 136, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8538), null, 29, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8538), "https://loremflickr.com/800/600/house/all?lock=3381" },
                    { 137, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8539), null, 29, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8540), "https://loremflickr.com/800/600/house/all?lock=2909" },
                    { 138, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8577), null, 30, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8577), "https://loremflickr.com/1024/900/house/all?lock=3250" },
                    { 139, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8579), null, 30, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8579), "https://loremflickr.com/800/768/house/all?lock=3257" },
                    { 140, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8580), null, 30, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8580), "https://loremflickr.com/1200/900/house/all?lock=3889" },
                    { 141, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8582), null, 30, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8582), "https://loremflickr.com/1024/900/house/all?lock=3662" },
                    { 142, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8583), null, 30, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8583), "https://loremflickr.com/1200/600/house/all?lock=3532" },
                    { 143, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8585), null, 30, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8585), "https://loremflickr.com/1024/900/house/all?lock=3670" },
                    { 144, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8613), null, 31, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8613), "https://loremflickr.com/1200/900/house/all?lock=3231" },
                    { 145, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8614), null, 31, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8615), "https://loremflickr.com/1024/768/house/all?lock=3355" },
                    { 146, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8616), null, 31, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8616), "https://loremflickr.com/1200/600/house/all?lock=3490" },
                    { 147, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8618), null, 31, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8618), "https://loremflickr.com/800/600/house/all?lock=3392" },
                    { 148, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8619), null, 31, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8619), "https://loremflickr.com/1200/600/house/all?lock=3665" },
                    { 149, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8648), null, 32, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8648), "https://loremflickr.com/800/768/house/all?lock=3630" },
                    { 150, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8650), null, 32, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8650), "https://loremflickr.com/1024/600/house/all?lock=3944" },
                    { 151, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8652), null, 32, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8652), "https://loremflickr.com/1200/768/house/all?lock=4085" },
                    { 152, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8653), null, 32, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8653), "https://loremflickr.com/1024/900/house/all?lock=3287" },
                    { 153, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8655), null, 32, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8655), "https://loremflickr.com/1200/768/house/all?lock=3242" },
                    { 154, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8683), null, 33, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8683), "https://loremflickr.com/1024/900/house/all?lock=3878" },
                    { 155, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8684), null, 33, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8685), "https://loremflickr.com/800/900/house/all?lock=3536" },
                    { 156, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8686), null, 33, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8686), "https://loremflickr.com/1200/900/house/all?lock=3951" },
                    { 157, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8688), null, 33, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8688), "https://loremflickr.com/1200/900/house/all?lock=4118" },
                    { 158, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8689), null, 33, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8690), "https://loremflickr.com/1024/900/house/all?lock=4295" },
                    { 159, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8717), null, 34, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8718), "https://loremflickr.com/800/900/house/all?lock=3791" },
                    { 160, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8719), null, 34, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8719), "https://loremflickr.com/800/768/house/all?lock=3766" },
                    { 161, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8720), null, 34, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8721), "https://loremflickr.com/800/600/house/all?lock=3982" },
                    { 162, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8722), null, 34, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8722), "https://loremflickr.com/1200/768/house/all?lock=4132" },
                    { 163, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8723), null, 34, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8724), "https://loremflickr.com/1200/900/house/all?lock=3869" },
                    { 164, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8725), null, 34, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8725), "https://loremflickr.com/1024/600/house/all?lock=3823" },
                    { 165, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8770), null, 35, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8770), "https://loremflickr.com/800/600/house/all?lock=4184" },
                    { 166, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8771), null, 35, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8771), "https://loremflickr.com/1024/900/house/all?lock=4129" },
                    { 167, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8773), null, 35, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8773), "https://loremflickr.com/1024/768/house/all?lock=4413" },
                    { 168, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8774), null, 35, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8775), "https://loremflickr.com/1024/900/house/all?lock=3567" },
                    { 169, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8776), null, 35, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8776), "https://loremflickr.com/1024/768/house/all?lock=4264" },
                    { 170, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8777), null, 35, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8778), "https://loremflickr.com/800/600/house/all?lock=3598" },
                    { 171, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8802), null, 36, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8802), "https://loremflickr.com/1024/900/house/all?lock=4157" },
                    { 172, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8803), null, 36, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8804), "https://loremflickr.com/1200/900/house/all?lock=4253" },
                    { 173, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8805), null, 36, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8805), "https://loremflickr.com/1200/768/house/all?lock=3670" },
                    { 174, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8839), null, 37, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8840), "https://loremflickr.com/1024/768/house/all?lock=3703" },
                    { 175, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8841), null, 37, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8841), "https://loremflickr.com/800/900/house/all?lock=4403" },
                    { 176, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8843), null, 37, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8843), "https://loremflickr.com/800/600/house/all?lock=3757" },
                    { 177, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8844), null, 37, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8844), "https://loremflickr.com/1024/768/house/all?lock=4543" },
                    { 178, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8846), null, 37, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8846), "https://loremflickr.com/1200/600/house/all?lock=4588" },
                    { 179, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8847), null, 37, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8847), "https://loremflickr.com/1024/768/house/all?lock=3753" },
                    { 183, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8924), null, 39, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8924), "https://loremflickr.com/1024/900/house/all?lock=4190" },
                    { 184, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8925), null, 39, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8926), "https://loremflickr.com/1024/900/house/all?lock=3916" },
                    { 185, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8927), null, 39, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8927), "https://loremflickr.com/1200/600/house/all?lock=4070" },
                    { 186, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8929), null, 39, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8929), "https://loremflickr.com/800/900/house/all?lock=4141" },
                    { 187, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8930), null, 39, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8930), "https://loremflickr.com/1024/768/house/all?lock=3954" },
                    { 188, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8932), null, 39, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8932), "https://loremflickr.com/800/768/house/all?lock=4479" },
                    { 189, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8975), null, 40, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8975), "https://loremflickr.com/800/900/house/all?lock=4922" },
                    { 190, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8976), null, 40, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8977), "https://loremflickr.com/800/900/house/all?lock=4750" },
                    { 191, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8978), null, 40, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8978), "https://loremflickr.com/800/768/house/all?lock=4416" },
                    { 192, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8980), null, 40, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8980), "https://loremflickr.com/1024/900/house/all?lock=4607" },
                    { 208, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9130), null, 44, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9131), "https://loremflickr.com/1024/768/house/all?lock=4525" },
                    { 209, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9132), null, 44, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9132), "https://loremflickr.com/1200/768/house/all?lock=4537" },
                    { 210, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9134), null, 44, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9134), "https://loremflickr.com/1024/900/house/all?lock=5062" },
                    { 211, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9135), null, 44, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9135), "https://loremflickr.com/1024/600/house/all?lock=5020" },
                    { 212, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9159), null, 45, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9159), "https://loremflickr.com/1200/768/house/all?lock=4753" },
                    { 213, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9160), null, 45, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9161), "https://loremflickr.com/1024/900/house/all?lock=5460" },
                    { 214, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9162), null, 45, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9162), "https://loremflickr.com/800/900/house/all?lock=4635" },
                    { 215, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9164), null, 45, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9164), "https://loremflickr.com/800/600/house/all?lock=4934" },
                    { 216, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9165), null, 45, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9165), "https://loremflickr.com/1200/600/house/all?lock=4964" },
                    { 225, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9266), null, 48, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9267), "https://loremflickr.com/1200/900/house/all?lock=5356" },
                    { 226, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9268), null, 48, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9268), "https://loremflickr.com/1200/900/house/all?lock=5795" },
                    { 227, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9269), null, 48, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9270), "https://loremflickr.com/1024/768/house/all?lock=4833" },
                    { 228, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9271), null, 48, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9271), "https://loremflickr.com/1200/600/house/all?lock=5405" },
                    { 229, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9302), null, 49, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9302), "https://loremflickr.com/1024/600/house/all?lock=5335" },
                    { 230, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9303), null, 49, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9303), "https://loremflickr.com/1024/900/house/all?lock=5492" },
                    { 231, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9305), null, 49, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9305), "https://loremflickr.com/1024/768/house/all?lock=5784" },
                    { 232, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9306), null, 49, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9306), "https://loremflickr.com/800/900/house/all?lock=5644" },
                    { 233, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9308), null, 49, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9308), "https://loremflickr.com/1200/900/house/all?lock=5730" },
                    { 234, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9309), null, 49, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9310), "https://loremflickr.com/800/600/house/all?lock=5528" },
                    { 235, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9337), null, 50, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9337), "https://loremflickr.com/800/900/house/all?lock=5551" },
                    { 236, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9338), null, 50, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9339), "https://loremflickr.com/800/900/house/all?lock=5386" },
                    { 237, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9340), null, 50, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9340), "https://loremflickr.com/800/900/house/all?lock=5893" },
                    { 238, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9341), null, 50, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9342), "https://loremflickr.com/800/900/house/all?lock=5907" },
                    { 239, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9343), null, 50, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9343), "https://loremflickr.com/800/900/house/all?lock=5335" },
                    { 246, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9415), null, 52, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9416), "https://loremflickr.com/1024/600/house/all?lock=5590" },
                    { 247, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9417), null, 52, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9417), "https://loremflickr.com/1024/768/house/all?lock=6038" },
                    { 248, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9418), null, 52, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9419), "https://loremflickr.com/1024/600/house/all?lock=5955" },
                    { 249, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9420), null, 52, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9420), "https://loremflickr.com/1024/900/house/all?lock=6020" },
                    { 250, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9453), null, 53, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9453), "https://loremflickr.com/800/900/house/all?lock=5303" },
                    { 251, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9454), null, 53, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9455), "https://loremflickr.com/1024/768/house/all?lock=5511" },
                    { 252, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9456), null, 53, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9456), "https://loremflickr.com/1200/600/house/all?lock=6223" },
                    { 253, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9457), null, 53, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9458), "https://loremflickr.com/800/900/house/all?lock=5867" },
                    { 254, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9459), null, 53, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9459), "https://loremflickr.com/800/768/house/all?lock=5604" },
                    { 255, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9461), null, 53, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9461), "https://loremflickr.com/800/600/house/all?lock=6241" },
                    { 256, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9496), null, 54, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9496), "https://loremflickr.com/800/600/house/all?lock=6041" },
                    { 257, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9497), null, 54, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9498), "https://loremflickr.com/1024/900/house/all?lock=6350" },
                    { 258, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9509), null, 54, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9509), "https://loremflickr.com/1024/768/house/all?lock=5567" },
                    { 259, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9510), null, 54, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9510), "https://loremflickr.com/800/900/house/all?lock=5708" },
                    { 260, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9512), null, 54, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9512), "https://loremflickr.com/1024/900/house/all?lock=6147" },
                    { 261, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9513), null, 54, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9514), "https://loremflickr.com/800/768/house/all?lock=5917" },
                    { 262, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9549), null, 55, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9549), "https://loremflickr.com/1024/600/house/all?lock=6143" },
                    { 263, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9550), null, 55, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9551), "https://loremflickr.com/800/900/house/all?lock=5683" },
                    { 264, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9552), null, 55, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9552), "https://loremflickr.com/800/900/house/all?lock=6265" },
                    { 265, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9554), null, 55, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9554), "https://loremflickr.com/1024/600/house/all?lock=5696" },
                    { 266, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9582), null, 56, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9582), "https://loremflickr.com/1024/600/house/all?lock=6190" },
                    { 267, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9584), null, 56, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9584), "https://loremflickr.com/1024/600/house/all?lock=5662" },
                    { 268, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9585), null, 56, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9585), "https://loremflickr.com/1200/600/house/all?lock=5739" },
                    { 269, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9587), null, 56, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9587), "https://loremflickr.com/800/768/house/all?lock=5719" },
                    { 270, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9621), null, 57, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9622), "https://loremflickr.com/1200/900/house/all?lock=5755" },
                    { 271, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9623), null, 57, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9623), "https://loremflickr.com/1024/600/house/all?lock=6698" },
                    { 272, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9624), null, 57, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9625), "https://loremflickr.com/1200/768/house/all?lock=5871" },
                    { 273, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9626), null, 57, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9626), "https://loremflickr.com/1200/600/house/all?lock=6571" },
                    { 274, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9628), null, 57, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9628), "https://loremflickr.com/1024/600/house/all?lock=5715" },
                    { 275, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9629), null, 57, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9629), "https://loremflickr.com/800/900/house/all?lock=6698" },
                    { 276, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9668), null, 58, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9668), "https://loremflickr.com/1024/768/house/all?lock=6609" },
                    { 277, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9670), null, 58, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9670), "https://loremflickr.com/800/900/house/all?lock=6412" },
                    { 278, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9671), null, 58, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9671), "https://loremflickr.com/1024/600/house/all?lock=6495" },
                    { 279, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9703), null, 59, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9703), "https://loremflickr.com/800/900/house/all?lock=6008" },
                    { 280, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9704), null, 59, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9705), "https://loremflickr.com/1200/900/house/all?lock=6403" },
                    { 281, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9706), null, 59, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9707), "https://loremflickr.com/800/600/house/all?lock=5946" },
                    { 282, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9708), null, 59, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9708), "https://loremflickr.com/800/900/house/all?lock=6358" },
                    { 283, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9710), null, 59, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9710), "https://loremflickr.com/800/600/house/all?lock=6802" },
                    { 284, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9711), null, 59, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9711), "https://loremflickr.com/800/900/house/all?lock=6393" },
                    { 285, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9744), null, 60, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9745), "https://loremflickr.com/1024/900/house/all?lock=6120" },
                    { 286, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9746), null, 60, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9746), "https://loremflickr.com/800/900/house/all?lock=6362" },
                    { 287, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9748), null, 60, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9748), "https://loremflickr.com/1200/900/house/all?lock=6300" },
                    { 288, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9749), null, 60, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9749), "https://loremflickr.com/800/768/house/all?lock=6821" },
                    { 289, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9751), null, 60, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9751), "https://loremflickr.com/800/768/house/all?lock=6009" },
                    { 290, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9786), null, 61, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9786), "https://loremflickr.com/1024/900/house/all?lock=6934" },
                    { 291, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9788), null, 61, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9788), "https://loremflickr.com/800/900/house/all?lock=6824" },
                    { 292, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9789), null, 61, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9790), "https://loremflickr.com/800/900/house/all?lock=6676" },
                    { 293, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9791), null, 61, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9791), "https://loremflickr.com/800/900/house/all?lock=6685" },
                    { 294, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9793), null, 61, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9793), "https://loremflickr.com/800/768/house/all?lock=6468" },
                    { 295, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9795), null, 61, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9795), "https://loremflickr.com/1200/768/house/all?lock=6681" },
                    { 296, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9817), null, 62, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9817), "https://loremflickr.com/1024/900/house/all?lock=7031" },
                    { 297, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9818), null, 62, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9819), "https://loremflickr.com/1200/900/house/all?lock=6746" },
                    { 298, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9820), null, 62, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9820), "https://loremflickr.com/1024/900/house/all?lock=6753" },
                    { 299, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9864), null, 63, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9865), "https://loremflickr.com/1024/600/house/all?lock=6604" },
                    { 300, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9866), null, 63, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9866), "https://loremflickr.com/1024/600/house/all?lock=7075" },
                    { 301, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9868), null, 63, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9868), "https://loremflickr.com/1200/600/house/all?lock=6877" },
                    { 302, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9869), null, 63, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9869), "https://loremflickr.com/1024/900/house/all?lock=7117" },
                    { 303, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9871), null, 63, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9871), "https://loremflickr.com/800/600/house/all?lock=6550" },
                    { 304, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9872), null, 63, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9872), "https://loremflickr.com/1024/768/house/all?lock=7150" },
                    { 305, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9906), null, 64, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9907), "https://loremflickr.com/1200/600/house/all?lock=6450" },
                    { 306, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9908), null, 64, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9908), "https://loremflickr.com/1200/600/house/all?lock=7306" },
                    { 307, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9909), null, 64, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9910), "https://loremflickr.com/1024/600/house/all?lock=7107" },
                    { 308, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9911), null, 64, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9911), "https://loremflickr.com/1200/900/house/all?lock=7319" },
                    { 309, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9912), null, 64, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9913), "https://loremflickr.com/1024/768/house/all?lock=6803" },
                    { 310, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9959), null, 65, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9959), "https://loremflickr.com/1024/768/house/all?lock=7108" },
                    { 311, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9961), null, 65, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9961), "https://loremflickr.com/800/768/house/all?lock=7460" },
                    { 312, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9962), null, 65, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9962), "https://loremflickr.com/800/600/house/all?lock=6994" },
                    { 319, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(40), null, 67, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(40), "https://loremflickr.com/800/900/house/all?lock=7051" },
                    { 320, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(41), null, 67, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(42), "https://loremflickr.com/1024/900/house/all?lock=7005" },
                    { 321, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(43), null, 67, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(43), "https://loremflickr.com/1024/900/house/all?lock=6755" },
                    { 322, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(45), null, 67, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(45), "https://loremflickr.com/1024/768/house/all?lock=7346" },
                    { 323, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(89), null, 68, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(89), "https://loremflickr.com/1200/900/house/all?lock=7464" },
                    { 324, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(90), null, 68, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(91), "https://loremflickr.com/1200/600/house/all?lock=6977" },
                    { 325, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(92), null, 68, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(92), "https://loremflickr.com/1024/900/house/all?lock=7088" },
                    { 326, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(94), null, 68, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(94), "https://loremflickr.com/1024/600/house/all?lock=7274" },
                    { 327, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(95), null, 68, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(96), "https://loremflickr.com/1024/900/house/all?lock=7509" },
                    { 328, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(97), null, 68, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(97), "https://loremflickr.com/1024/900/house/all?lock=6940" },
                    { 329, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(132), null, 69, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(132), "https://loremflickr.com/1200/600/house/all?lock=7253" },
                    { 330, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(133), null, 69, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(134), "https://loremflickr.com/800/900/house/all?lock=7637" },
                    { 331, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(135), null, 69, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(135), "https://loremflickr.com/800/768/house/all?lock=7643" },
                    { 332, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(137), null, 69, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(137), "https://loremflickr.com/1200/900/house/all?lock=6959" },
                    { 333, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(172), null, 70, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(173), "https://loremflickr.com/800/900/house/all?lock=7642" },
                    { 334, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(174), null, 70, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(174), "https://loremflickr.com/1200/600/house/all?lock=7579" },
                    { 335, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(175), null, 70, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(176), "https://loremflickr.com/1024/768/house/all?lock=7234" },
                    { 336, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(177), null, 70, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(177), "https://loremflickr.com/800/600/house/all?lock=7658" },
                    { 337, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(179), null, 70, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(179), "https://loremflickr.com/1024/600/house/all?lock=7987" },
                    { 338, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(216), null, 71, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(216), "https://loremflickr.com/1200/768/house/all?lock=7433" },
                    { 339, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(218), null, 71, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(218), "https://loremflickr.com/1200/600/house/all?lock=7639" },
                    { 340, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(219), null, 71, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(219), "https://loremflickr.com/1024/600/house/all?lock=7428" },
                    { 341, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(254), null, 72, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(255), "https://loremflickr.com/1024/768/house/all?lock=7834" },
                    { 342, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(256), null, 72, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(257), "https://loremflickr.com/800/900/house/all?lock=7852" },
                    { 343, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(258), null, 72, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(258), "https://loremflickr.com/1200/768/house/all?lock=7298" },
                    { 350, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(336), null, 74, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(336), "https://loremflickr.com/1200/768/house/all?lock=7746" },
                    { 351, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(337), null, 74, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(338), "https://loremflickr.com/1200/600/house/all?lock=7707" },
                    { 352, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(339), null, 74, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(340), "https://loremflickr.com/800/600/house/all?lock=7450" },
                    { 353, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(341), null, 74, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(341), "https://loremflickr.com/1200/900/house/all?lock=7611" },
                    { 354, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(343), null, 74, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(343), "https://loremflickr.com/800/768/house/all?lock=7904" },
                    { 355, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(386), null, 75, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(386), "https://loremflickr.com/1024/768/house/all?lock=8271" },
                    { 356, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(387), null, 75, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(388), "https://loremflickr.com/800/600/house/all?lock=8005" },
                    { 357, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(389), null, 75, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(389), "https://loremflickr.com/1200/900/house/all?lock=7962" },
                    { 358, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(390), null, 75, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(391), "https://loremflickr.com/1200/768/house/all?lock=7928" },
                    { 359, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(392), null, 75, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(392), "https://loremflickr.com/1024/768/house/all?lock=8279" },
                    { 366, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(478), null, 77, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(478), "https://loremflickr.com/1200/768/house/all?lock=8400" },
                    { 367, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(480), null, 77, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(480), "https://loremflickr.com/1200/600/house/all?lock=8160" },
                    { 368, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(481), null, 77, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(482), "https://loremflickr.com/800/600/house/all?lock=8306" },
                    { 369, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(513), null, 78, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(513), "https://loremflickr.com/1024/768/house/all?lock=7858" },
                    { 370, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(514), null, 78, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(515), "https://loremflickr.com/1024/900/house/all?lock=8579" },
                    { 371, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(516), null, 78, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(516), "https://loremflickr.com/800/768/house/all?lock=8564" },
                    { 372, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(518), null, 78, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(518), "https://loremflickr.com/1024/600/house/all?lock=8230" },
                    { 373, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(519), null, 78, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(519), "https://loremflickr.com/800/768/house/all?lock=8032" },
                    { 374, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(562), null, 79, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(562), "https://loremflickr.com/1024/600/house/all?lock=8861" },
                    { 375, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(563), null, 79, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(564), "https://loremflickr.com/800/768/house/all?lock=7940" },
                    { 376, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(565), null, 79, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(565), "https://loremflickr.com/800/900/house/all?lock=8508" },
                    { 377, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(566), null, 79, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(567), "https://loremflickr.com/800/768/house/all?lock=8471" },
                    { 378, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(568), null, 79, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(568), "https://loremflickr.com/800/600/house/all?lock=8042" },
                    { 379, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(600), null, 80, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(600), "https://loremflickr.com/800/768/house/all?lock=8216" },
                    { 380, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(601), null, 80, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(601), "https://loremflickr.com/1024/768/house/all?lock=8632" },
                    { 381, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(602), null, 80, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(603), "https://loremflickr.com/800/900/house/all?lock=8705" },
                    { 385, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(683), null, 82, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(683), "https://loremflickr.com/1200/600/house/all?lock=8457" },
                    { 386, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(685), null, 82, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(685), "https://loremflickr.com/800/600/house/all?lock=8779" },
                    { 387, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(688), null, 82, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(688), "https://loremflickr.com/1200/900/house/all?lock=8229" },
                    { 388, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(690), null, 82, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(690), "https://loremflickr.com/1200/768/house/all?lock=8264" },
                    { 389, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(742), null, 83, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(742), "https://loremflickr.com/1200/768/house/all?lock=8561" },
                    { 390, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(745), null, 83, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(745), "https://loremflickr.com/1200/600/house/all?lock=8651" },
                    { 391, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(747), null, 83, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(748), "https://loremflickr.com/1024/900/house/all?lock=8640" },
                    { 392, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(750), null, 83, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(750), "https://loremflickr.com/1024/600/house/all?lock=9118" },
                    { 393, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(752), null, 83, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(752), "https://loremflickr.com/800/900/house/all?lock=8848" },
                    { 394, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(800), null, 84, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(800), "https://loremflickr.com/1200/768/house/all?lock=8447" },
                    { 395, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(803), null, 84, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(803), "https://loremflickr.com/1200/768/house/all?lock=8921" },
                    { 396, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(806), null, 84, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(806), "https://loremflickr.com/800/900/house/all?lock=9068" },
                    { 397, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(877), null, 85, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(877), "https://loremflickr.com/1024/900/house/all?lock=9161" },
                    { 398, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(880), null, 85, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(880), "https://loremflickr.com/1024/900/house/all?lock=8666" },
                    { 399, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(882), null, 85, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(882), "https://loremflickr.com/1200/900/house/all?lock=8993" },
                    { 400, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(884), null, 85, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(885), "https://loremflickr.com/1024/900/house/all?lock=9122" },
                    { 401, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(886), null, 85, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(886), "https://loremflickr.com/1200/600/house/all?lock=9443" },
                    { 402, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(926), null, 86, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(926), "https://loremflickr.com/800/600/house/all?lock=9073" },
                    { 403, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(927), null, 86, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(927), "https://loremflickr.com/1200/900/house/all?lock=9018" },
                    { 404, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(929), null, 86, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(929), "https://loremflickr.com/1024/900/house/all?lock=8916" },
                    { 405, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(930), null, 86, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(930), "https://loremflickr.com/1024/900/house/all?lock=9237" },
                    { 406, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(932), null, 86, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(932), "https://loremflickr.com/800/600/house/all?lock=8943" },
                    { 428, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1131), null, 91, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1132), "https://loremflickr.com/1024/768/house/all?lock=9508" },
                    { 429, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1133), null, 91, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1133), "https://loremflickr.com/800/600/house/all?lock=9929" },
                    { 430, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1135), null, 91, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1135), "https://loremflickr.com/800/600/house/all?lock=9124" },
                    { 431, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1137), null, 91, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1137), "https://loremflickr.com/800/600/house/all?lock=9832" },
                    { 432, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1138), null, 91, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1138), "https://loremflickr.com/1024/600/house/all?lock=9603" },
                    { 433, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1140), null, 91, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1140), "https://loremflickr.com/1200/900/house/all?lock=9863" },
                    { 434, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1167), null, 92, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1167), "https://loremflickr.com/1024/900/house/all?lock=9354" },
                    { 435, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1169), null, 92, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1169), "https://loremflickr.com/1024/900/house/all?lock=9829" },
                    { 436, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1170), null, 92, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1171), "https://loremflickr.com/1024/768/house/all?lock=9478" },
                    { 448, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1279), null, 95, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1279), "https://loremflickr.com/1024/600/house/all?lock=10010" },
                    { 449, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1281), null, 95, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1281), "https://loremflickr.com/1200/900/house/all?lock=10360" },
                    { 450, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1282), null, 95, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1282), "https://loremflickr.com/1024/600/house/all?lock=9693" },
                    { 451, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1309), null, 96, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1309), "https://loremflickr.com/1024/768/house/all?lock=10021" },
                    { 452, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1310), null, 96, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1310), "https://loremflickr.com/1024/900/house/all?lock=10202" },
                    { 453, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1312), null, 96, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1312), "https://loremflickr.com/1024/768/house/all?lock=9623" },
                    { 454, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1313), null, 96, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1314), "https://loremflickr.com/1024/900/house/all?lock=9711" },
                    { 455, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1315), null, 96, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1315), "https://loremflickr.com/1024/600/house/all?lock=10464" },
                    { 456, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1317), null, 96, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1317), "https://loremflickr.com/800/900/house/all?lock=10018" },
                    { 460, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1392), null, 98, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1392), "https://loremflickr.com/800/900/house/all?lock=9974" },
                    { 461, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1393), null, 98, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1394), "https://loremflickr.com/1200/900/house/all?lock=10000" },
                    { 462, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1395), null, 98, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1395), "https://loremflickr.com/800/600/house/all?lock=10631" },
                    { 469, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1478), null, 100, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1478), "https://loremflickr.com/1024/600/house/all?lock=10385" },
                    { 470, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1479), null, 100, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1480), "https://loremflickr.com/1200/768/house/all?lock=10409" },
                    { 471, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1481), null, 100, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1481), "https://loremflickr.com/800/768/house/all?lock=10604" },
                    { 472, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1482), null, 100, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1483), "https://loremflickr.com/1200/600/house/all?lock=10797" },
                    { 473, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1484), null, 100, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1484), "https://loremflickr.com/1200/600/house/all?lock=10988" },
                    { 474, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1485), null, 100, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1486), "https://loremflickr.com/800/600/house/all?lock=10719" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "DeletedAt", "Description", "DormId", "IsActive", "IsAvailable", "IsDeleted", "PricePerMonth", "RoomNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 6, 4, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(5737), null, "A comfortable and well-lit room in Central Dwellings.", 1, true, true, false, 13726m, "Room 100-1", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(5746) },
                    { 2, 3, new DateTime(2024, 8, 1, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(5771), null, "A bright and cheerful room in Central Dwellings.", 1, true, true, false, 11747m, "Room 101-1", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(5771) },
                    { 7, 3, new DateTime(2024, 9, 29, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7226), null, "A fully furnished room in Orange Suites.", 3, true, true, false, 9597m, "Room 100-3", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7227) },
                    { 8, 2, new DateTime(2024, 12, 23, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7231), null, "A functional and practical room in Orange Suites.", 3, true, true, false, 12392m, "Room 101-3", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7232) },
                    { 9, 2, new DateTime(2024, 8, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7268), null, "A bright and cheerful room in Green Suites.", 4, true, true, false, 7638m, "Room 100-4", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7269) },
                    { 10, 3, new DateTime(2025, 1, 26, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7274), null, "A newly renovated room in Green Suites.", 4, true, true, false, 8160m, "Room 101-4", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7275) },
                    { 11, 4, new DateTime(2024, 11, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7315), null, "A bright and cheerful room in Golden Lodgings.", 5, true, true, false, 12117m, "Room 100-5", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7316) },
                    { 12, 1, new DateTime(2024, 9, 10, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7321), null, "A fully furnished room in Golden Lodgings.", 5, true, true, false, 6244m, "Room 101-5", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7322) },
                    { 13, 2, new DateTime(2024, 10, 13, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7325), null, "A spacious and airy room in Golden Lodgings.", 5, true, true, false, 4318m, "Room 102-5", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7326) },
                    { 14, 1, new DateTime(2025, 1, 15, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7335), null, "A charming and homey room in Golden Lodgings.", 5, true, true, false, 7995m, "Room 103-5", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7336) },
                    { 15, 3, new DateTime(2024, 12, 20, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7340), null, "A functional and practical room in Golden Lodgings.", 5, true, true, false, 9119m, "Room 104-5", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7341) },
                    { 16, 1, new DateTime(2024, 6, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7366), null, "A fully furnished room in Red Suites.", 6, true, true, false, 13106m, "Room 100-6", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7367) },
                    { 17, 4, new DateTime(2024, 6, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7370), null, "A charming and homey room in Red Suites.", 6, true, false, false, 6968m, "Room 101-6", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7371) },
                    { 18, 2, new DateTime(2024, 5, 11, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7376), null, "A fully furnished room in Red Suites.", 6, true, true, false, 10074m, "Room 102-6", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7376) },
                    { 21, 4, new DateTime(2024, 10, 11, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7457), null, "A spacious and airy room in Elegant Dormitory.", 8, true, true, false, 5730m, "Room 100-8", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7458) },
                    { 22, 2, new DateTime(2024, 10, 15, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7461), null, "A spacious and airy room in Elegant Dormitory.", 8, true, true, false, 10380m, "Room 101-8", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7462) },
                    { 23, 3, new DateTime(2024, 3, 29, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7466), null, "A fully furnished room in Elegant Dormitory.", 8, true, true, false, 9602m, "Room 102-8", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7467) },
                    { 24, 1, new DateTime(2024, 12, 11, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7470), null, "A charming and homey room in Elegant Dormitory.", 8, true, true, false, 13195m, "Room 103-8", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7471) },
                    { 32, 2, new DateTime(2025, 3, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7600), null, "A modern and stylish room in Grand Lodgings.", 11, true, true, false, 7832m, "Room 100-11", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7601) },
                    { 33, 4, new DateTime(2025, 1, 16, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7605), null, "A spacious and airy room in Grand Lodgings.", 11, true, true, false, 6694m, "Room 101-11", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7606) },
                    { 34, 2, new DateTime(2024, 10, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7611), null, "A cozy and quiet room in Grand Lodgings.", 11, true, true, false, 8993m, "Room 102-11", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7612) },
                    { 35, 2, new DateTime(2024, 5, 24, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7616), null, "A fully furnished room in Grand Lodgings.", 11, true, true, false, 12974m, "Room 103-11", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7617) },
                    { 36, 1, new DateTime(2024, 10, 4, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7640), null, "A spacious and airy room in Elegant Hall.", 12, true, true, false, 13333m, "Room 100-12", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7641) },
                    { 37, 2, new DateTime(2024, 7, 4, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7645), null, "A spacious and airy room in Elegant Hall.", 12, true, true, false, 6686m, "Room 101-12", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7645) },
                    { 38, 1, new DateTime(2024, 11, 25, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7649), null, "A fully furnished room in Elegant Hall.", 12, true, true, false, 11944m, "Room 102-12", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7650) },
                    { 39, 3, new DateTime(2024, 10, 14, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7654), null, "A functional and practical room in Elegant Hall.", 12, true, true, false, 8936m, "Room 103-12", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7655) },
                    { 40, 3, new DateTime(2024, 7, 15, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7658), null, "A comfortable and well-lit room in Elegant Hall.", 12, true, false, false, 6887m, "Room 104-12", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7659) },
                    { 41, 4, new DateTime(2024, 5, 20, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7857), null, "A functional and practical room in Red Dormitory.", 13, true, true, false, 11949m, "Room 100-13", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7858) },
                    { 42, 2, new DateTime(2024, 5, 10, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7863), null, "A functional and practical room in Red Dormitory.", 13, true, true, false, 12773m, "Room 101-13", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7864) },
                    { 43, 2, new DateTime(2024, 6, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7868), null, "A functional and practical room in Red Dormitory.", 13, true, true, false, 10793m, "Room 102-13", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7869) },
                    { 44, 2, new DateTime(2024, 8, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7873), null, "A cozy and quiet room in Red Dormitory.", 13, true, true, false, 7905m, "Room 103-13", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7874) },
                    { 45, 2, new DateTime(2024, 9, 1, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7877), null, "A modern and stylish room in Red Dormitory.", 13, true, true, false, 7904m, "Room 104-13", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7878) },
                    { 46, 2, new DateTime(2024, 8, 31, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7909), null, "A charming and homey room in Grand Place.", 14, true, true, false, 7219m, "Room 100-14", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7909) },
                    { 47, 1, new DateTime(2024, 4, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7919), null, "A modern and stylish room in Grand Place.", 14, true, true, false, 10523m, "Room 101-14", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7920) },
                    { 48, 3, new DateTime(2024, 12, 5, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7924), null, "A spacious and airy room in Grand Place.", 14, true, true, false, 7394m, "Room 102-14", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7924) },
                    { 49, 3, new DateTime(2024, 5, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7928), null, "A functional and practical room in Grand Place.", 14, true, true, false, 9941m, "Room 103-14", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7929) },
                    { 58, 3, new DateTime(2024, 7, 10, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8046), null, "A spacious and airy room in Superior Lodgings.", 17, true, true, false, 10926m, "Room 100-17", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8047) },
                    { 59, 1, new DateTime(2024, 12, 31, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8051), null, "A bright and cheerful room in Superior Lodgings.", 17, true, true, false, 14082m, "Room 101-17", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8051) },
                    { 66, 1, new DateTime(2024, 8, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8152), null, "A cozy and quiet room in Red Suites.", 20, true, true, false, 14233m, "Room 100-20", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8153) },
                    { 67, 2, new DateTime(2024, 10, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8157), null, "A spacious and airy room in Red Suites.", 20, true, true, false, 9578m, "Room 101-20", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8158) },
                    { 68, 1, new DateTime(2024, 9, 17, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8162), null, "A fully furnished room in Red Suites.", 20, true, true, false, 11245m, "Room 102-20", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8163) },
                    { 69, 3, new DateTime(2024, 3, 19, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8187), null, "A comfortable and well-lit room in Superior Lodgings.", 21, true, true, false, 9030m, "Room 100-21", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8188) },
                    { 70, 3, new DateTime(2024, 6, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8192), null, "A fully furnished room in Superior Lodgings.", 21, true, true, false, 10832m, "Room 101-21", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8193) },
                    { 71, 2, new DateTime(2024, 8, 13, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8196), null, "A newly renovated room in Superior Lodgings.", 21, true, true, false, 5310m, "Room 102-21", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8197) },
                    { 72, 2, new DateTime(2024, 10, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8232), null, "A cozy and quiet room in Superior Living Spaces.", 22, true, true, false, 9285m, "Room 100-22", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8233) },
                    { 73, 4, new DateTime(2024, 5, 10, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8236), null, "A cozy and quiet room in Superior Living Spaces.", 22, true, true, false, 12058m, "Room 101-22", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8237) },
                    { 74, 1, new DateTime(2024, 4, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8241), null, "A fully furnished room in Superior Living Spaces.", 22, true, true, false, 7654m, "Room 102-22", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8242) },
                    { 75, 3, new DateTime(2025, 2, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8269), null, "A charming and homey room in Elite Dormitory.", 23, true, true, false, 5254m, "Room 100-23", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8270) },
                    { 76, 4, new DateTime(2024, 4, 19, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8274), null, "A spacious and airy room in Elite Dormitory.", 23, true, true, false, 9271m, "Room 101-23", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8275) },
                    { 77, 2, new DateTime(2024, 12, 24, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8279), null, "A comfortable and well-lit room in Elite Dormitory.", 23, true, true, false, 14782m, "Room 102-23", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8279) },
                    { 78, 3, new DateTime(2024, 4, 4, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8283), null, "A bright and cheerful room in Elite Dormitory.", 23, true, true, false, 4506m, "Room 103-23", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8284) },
                    { 79, 2, new DateTime(2024, 4, 8, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8288), null, "A modern and stylish room in Elite Dormitory.", 23, true, true, false, 15291m, "Room 104-23", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8288) },
                    { 80, 1, new DateTime(2025, 2, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8316), null, "A comfortable and well-lit room in Red Dwellings.", 24, true, true, false, 14340m, "Room 100-24", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8317) },
                    { 81, 3, new DateTime(2024, 8, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8321), null, "A clean and minimalist room in Red Dwellings.", 24, true, true, false, 4732m, "Room 101-24", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8321) },
                    { 82, 2, new DateTime(2024, 4, 9, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8325), null, "A charming and homey room in Red Dwellings.", 24, true, true, false, 8043m, "Room 102-24", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8326) },
                    { 83, 4, new DateTime(2024, 10, 5, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8329), null, "A modern and stylish room in Red Dwellings.", 24, true, true, false, 6381m, "Room 103-24", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8330) },
                    { 84, 1, new DateTime(2024, 7, 11, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8334), null, "A spacious and airy room in Red Dwellings.", 24, true, true, false, 12506m, "Room 104-24", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8335) },
                    { 87, 1, new DateTime(2025, 2, 28, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8398), null, "A spacious and airy room in Royal Residences.", 26, true, false, false, 14263m, "Room 100-26", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8399) },
                    { 88, 3, new DateTime(2024, 10, 31, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8402), null, "A spacious and airy room in Royal Residences.", 26, true, false, false, 12475m, "Room 101-26", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8403) },
                    { 89, 2, new DateTime(2024, 3, 30, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8407), null, "A cozy and quiet room in Royal Residences.", 26, true, true, false, 7859m, "Room 102-26", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8408) },
                    { 90, 1, new DateTime(2024, 3, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8411), null, "A newly renovated room in Royal Residences.", 26, true, true, false, 4440m, "Room 103-26", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8412) },
                    { 91, 2, new DateTime(2024, 11, 4, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8437), null, "A comfortable and well-lit room in Green Lodgings.", 27, true, false, false, 5927m, "Room 100-27", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8438) },
                    { 92, 2, new DateTime(2024, 9, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8441), null, "A clean and minimalist room in Green Lodgings.", 27, true, true, false, 6479m, "Room 101-27", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8442) },
                    { 93, 2, new DateTime(2025, 1, 29, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8446), null, "A clean and minimalist room in Green Lodgings.", 27, true, true, false, 6218m, "Room 102-27", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8447) },
                    { 94, 2, new DateTime(2024, 11, 16, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8483), null, "A cozy and quiet room in Royal Residences.", 28, true, true, false, 10462m, "Room 100-28", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8484) },
                    { 95, 4, new DateTime(2024, 5, 11, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8487), null, "A charming and homey room in Royal Residences.", 28, true, false, false, 10881m, "Room 101-28", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8488) },
                    { 96, 1, new DateTime(2024, 8, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8492), null, "A modern and stylish room in Royal Residences.", 28, true, true, false, 7751m, "Room 102-28", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8493) },
                    { 97, 1, new DateTime(2024, 10, 4, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8520), null, "A cozy and quiet room in Golden House.", 29, true, true, false, 9541m, "Room 100-29", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8520) },
                    { 98, 4, new DateTime(2024, 3, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8524), null, "A modern and stylish room in Golden House.", 29, true, true, false, 10960m, "Room 101-29", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8525) },
                    { 99, 4, new DateTime(2024, 8, 17, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8561), null, "A modern and stylish room in Orange House.", 30, true, true, false, 7254m, "Room 100-30", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8562) },
                    { 100, 3, new DateTime(2024, 9, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8566), null, "A charming and homey room in Orange House.", 30, true, true, false, 14185m, "Room 101-30", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8567) },
                    { 101, 4, new DateTime(2024, 9, 11, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8570), null, "A charming and homey room in Orange House.", 30, true, true, false, 7938m, "Room 102-30", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8571) },
                    { 102, 3, new DateTime(2024, 5, 19, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8603), null, "A functional and practical room in Golden Place.", 31, true, true, false, 9105m, "Room 100-31", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8604) },
                    { 103, 2, new DateTime(2024, 4, 4, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8608), null, "A charming and homey room in Golden Place.", 31, true, false, false, 14569m, "Room 101-31", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8608) },
                    { 104, 3, new DateTime(2024, 11, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8631), null, "A bright and cheerful room in Grand Quarters.", 32, true, true, false, 8258m, "Room 100-32", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8632) },
                    { 105, 3, new DateTime(2024, 12, 20, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8636), null, "A charming and homey room in Grand Quarters.", 32, true, true, false, 12935m, "Room 101-32", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8636) },
                    { 106, 2, new DateTime(2024, 4, 28, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8641), null, "A modern and stylish room in Grand Quarters.", 32, true, true, false, 13308m, "Room 102-32", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8642) },
                    { 107, 4, new DateTime(2024, 4, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8673), null, "A clean and minimalist room in Crystal House.", 33, true, true, false, 4712m, "Room 100-33", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8674) },
                    { 108, 1, new DateTime(2024, 3, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8677), null, "A cozy and quiet room in Crystal House.", 33, true, true, false, 6845m, "Room 101-33", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8678) },
                    { 109, 4, new DateTime(2024, 6, 20, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8701), null, "A functional and practical room in Royal House.", 34, true, true, false, 11365m, "Room 100-34", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8702) },
                    { 110, 2, new DateTime(2024, 11, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8705), null, "A spacious and airy room in Royal House.", 34, true, true, false, 13263m, "Room 101-34", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8706) },
                    { 111, 3, new DateTime(2024, 11, 28, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8710), null, "A clean and minimalist room in Royal House.", 34, true, true, false, 11503m, "Room 102-34", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8710) },
                    { 112, 2, new DateTime(2024, 10, 15, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8743), null, "A clean and minimalist room in Grand Hall.", 35, true, true, false, 6783m, "Room 100-35", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8744) },
                    { 113, 4, new DateTime(2024, 3, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8747), null, "A functional and practical room in Grand Hall.", 35, true, true, false, 11684m, "Room 101-35", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8748) },
                    { 114, 3, new DateTime(2024, 12, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8752), null, "A spacious and airy room in Grand Hall.", 35, true, true, false, 8862m, "Room 102-35", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8752) },
                    { 115, 3, new DateTime(2024, 4, 28, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8756), null, "A charming and homey room in Grand Hall.", 35, true, true, false, 9636m, "Room 103-35", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8757) },
                    { 116, 1, new DateTime(2024, 8, 16, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8761), null, "A spacious and airy room in Grand Hall.", 35, true, true, false, 7221m, "Room 104-35", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8761) },
                    { 117, 3, new DateTime(2024, 12, 31, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8791), null, "A functional and practical room in Elite Residences.", 36, true, true, false, 8698m, "Room 100-36", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8791) },
                    { 118, 1, new DateTime(2024, 12, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8795), null, "A spacious and airy room in Elite Residences.", 36, true, true, false, 6317m, "Room 101-36", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8796) },
                    { 119, 2, new DateTime(2024, 9, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8823), null, "A bright and cheerful room in Central Lodgings.", 37, true, true, false, 7613m, "Room 100-37", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8823) },
                    { 120, 3, new DateTime(2024, 4, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8827), null, "A bright and cheerful room in Central Lodgings.", 37, true, true, false, 9835m, "Room 101-37", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8828) },
                    { 121, 2, new DateTime(2024, 4, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8832), null, "A cozy and quiet room in Central Lodgings.", 37, true, true, false, 7553m, "Room 102-37", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8833) },
                    { 126, 2, new DateTime(2024, 12, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8896), null, "A spacious and airy room in Blue House.", 39, true, true, false, 10945m, "Room 100-39", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8897) },
                    { 127, 4, new DateTime(2024, 12, 24, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8907), null, "A modern and stylish room in Blue House.", 39, true, true, false, 7405m, "Room 101-39", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8908) },
                    { 128, 2, new DateTime(2024, 10, 23, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8912), null, "A charming and homey room in Blue House.", 39, true, true, false, 13254m, "Room 102-39", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8912) },
                    { 129, 1, new DateTime(2024, 4, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8916), null, "A comfortable and well-lit room in Blue House.", 39, true, true, false, 8837m, "Room 103-39", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8917) },
                    { 130, 2, new DateTime(2024, 4, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8943), null, "A fully furnished room in Superior House.", 40, true, true, false, 5297m, "Room 100-40", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8944) },
                    { 131, 3, new DateTime(2024, 7, 5, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8948), null, "A charming and homey room in Superior House.", 40, true, true, false, 12509m, "Room 101-40", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8948) },
                    { 132, 2, new DateTime(2024, 10, 25, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8952), null, "A bright and cheerful room in Superior House.", 40, true, false, false, 6622m, "Room 102-40", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8953) },
                    { 133, 3, new DateTime(2025, 1, 26, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8956), null, "A bright and cheerful room in Superior House.", 40, true, true, false, 10441m, "Room 103-40", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8957) },
                    { 134, 4, new DateTime(2024, 7, 1, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8961), null, "A newly renovated room in Superior House.", 40, true, true, false, 6706m, "Room 104-40", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8962) },
                    { 145, 2, new DateTime(2024, 11, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9104), null, "A bright and cheerful room in Royal Dwellings.", 44, true, true, false, 8516m, "Room 100-44", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9104) },
                    { 146, 4, new DateTime(2024, 9, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9108), null, "A charming and homey room in Royal Dwellings.", 44, true, true, false, 10315m, "Room 101-44", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9109) },
                    { 147, 3, new DateTime(2024, 3, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9113), null, "A fully furnished room in Royal Dwellings.", 44, true, true, false, 6824m, "Room 102-44", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9113) },
                    { 148, 3, new DateTime(2024, 6, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9117), null, "A fully furnished room in Royal Dwellings.", 44, true, true, false, 11676m, "Room 103-44", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9118) },
                    { 149, 3, new DateTime(2024, 7, 28, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9147), null, "A comfortable and well-lit room in Blue Living Spaces.", 45, true, true, false, 13418m, "Room 100-45", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9148) },
                    { 150, 1, new DateTime(2025, 1, 14, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9152), null, "A bright and cheerful room in Blue Living Spaces.", 45, true, true, false, 12977m, "Room 101-45", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9153) },
                    { 156, 1, new DateTime(2024, 10, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9246), null, "A fully furnished room in Premium Dormitory.", 48, true, true, false, 9126m, "Room 100-48", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9247) },
                    { 157, 3, new DateTime(2024, 6, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9251), null, "A charming and homey room in Premium Dormitory.", 48, true, true, false, 6824m, "Room 101-48", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9252) },
                    { 158, 3, new DateTime(2024, 6, 8, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9255), null, "A clean and minimalist room in Premium Dormitory.", 48, true, true, false, 11228m, "Room 102-48", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9256) },
                    { 159, 4, new DateTime(2024, 10, 31, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9260), null, "A modern and stylish room in Premium Dormitory.", 48, true, true, false, 5703m, "Room 103-48", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9261) },
                    { 160, 4, new DateTime(2024, 11, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9289), null, "A bright and cheerful room in Grand Dormitory.", 49, true, true, false, 8107m, "Room 100-49", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9290) },
                    { 161, 1, new DateTime(2024, 7, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9293), null, "A spacious and airy room in Grand Dormitory.", 49, true, true, false, 6254m, "Room 101-49", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9294) },
                    { 162, 1, new DateTime(2024, 11, 11, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9321), null, "A charming and homey room in Golden Residences.", 50, true, true, false, 7818m, "Room 100-50", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9322) },
                    { 163, 3, new DateTime(2024, 4, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9325), null, "A bright and cheerful room in Golden Residences.", 50, true, true, false, 9337m, "Room 101-50", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9326) },
                    { 164, 2, new DateTime(2025, 2, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9330), null, "A functional and practical room in Golden Residences.", 50, true, true, false, 7586m, "Room 102-50", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9330) },
                    { 167, 3, new DateTime(2024, 10, 17, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9393), null, "A comfortable and well-lit room in Silver Residences.", 52, true, true, false, 12502m, "Room 100-52", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9394) },
                    { 168, 4, new DateTime(2024, 12, 9, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9398), null, "A clean and minimalist room in Silver Residences.", 52, true, true, false, 13893m, "Room 101-52", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9398) },
                    { 169, 3, new DateTime(2024, 11, 20, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9402), null, "A modern and stylish room in Silver Residences.", 52, true, true, false, 11040m, "Room 102-52", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9403) },
                    { 170, 2, new DateTime(2024, 3, 26, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9407), null, "A fully furnished room in Silver Residences.", 52, true, true, false, 14724m, "Room 103-52", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9408) },
                    { 171, 1, new DateTime(2024, 11, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9437), null, "A comfortable and well-lit room in Green Quarters.", 53, true, true, false, 12963m, "Room 100-53", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9438) },
                    { 172, 2, new DateTime(2024, 8, 31, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9442), null, "A comfortable and well-lit room in Green Quarters.", 53, true, true, false, 8966m, "Room 101-53", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9443) },
                    { 173, 3, new DateTime(2024, 9, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9447), null, "A cozy and quiet room in Green Quarters.", 53, true, true, false, 9131m, "Room 102-53", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9447) },
                    { 174, 3, new DateTime(2024, 11, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9473), null, "A spacious and airy room in Crystal Lodgings.", 54, true, true, false, 11966m, "Room 100-54", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9474) },
                    { 175, 1, new DateTime(2024, 12, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9478), null, "A newly renovated room in Crystal Lodgings.", 54, true, true, false, 13714m, "Room 101-54", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9478) },
                    { 176, 4, new DateTime(2024, 3, 14, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9482), null, "A charming and homey room in Crystal Lodgings.", 54, true, true, false, 5332m, "Room 102-54", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9483) },
                    { 177, 1, new DateTime(2024, 10, 7, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9486), null, "A modern and stylish room in Crystal Lodgings.", 54, true, true, false, 9084m, "Room 103-54", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9487) },
                    { 178, 1, new DateTime(2024, 8, 17, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9491), null, "A charming and homey room in Crystal Lodgings.", 54, true, true, false, 10054m, "Room 104-54", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9491) },
                    { 179, 3, new DateTime(2024, 12, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9525), null, "A modern and stylish room in Royal House.", 55, true, true, false, 14334m, "Room 100-55", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9526) },
                    { 180, 2, new DateTime(2024, 5, 16, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9530), null, "A cozy and quiet room in Royal House.", 55, true, true, false, 10538m, "Room 101-55", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9531) },
                    { 181, 3, new DateTime(2024, 5, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9535), null, "A cozy and quiet room in Royal House.", 55, true, true, false, 8179m, "Room 102-55", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9536) },
                    { 182, 3, new DateTime(2024, 5, 19, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9567), null, "A cozy and quiet room in Elite Lodgings.", 56, true, true, false, 6924m, "Room 100-56", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9567) },
                    { 183, 1, new DateTime(2024, 10, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9571), null, "A modern and stylish room in Elite Lodgings.", 56, true, true, false, 5592m, "Room 101-56", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9572) },
                    { 184, 2, new DateTime(2024, 5, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9575), null, "A functional and practical room in Elite Lodgings.", 56, true, false, false, 11647m, "Room 102-56", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9576) },
                    { 185, 2, new DateTime(2024, 5, 29, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9605), null, "A fully furnished room in Crystal Quarters.", 57, true, false, false, 5893m, "Room 100-57", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9606) },
                    { 186, 2, new DateTime(2024, 5, 15, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9609), null, "A clean and minimalist room in Crystal Quarters.", 57, true, true, false, 13863m, "Room 101-57", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9610) },
                    { 187, 2, new DateTime(2024, 6, 28, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9614), null, "A bright and cheerful room in Crystal Quarters.", 57, true, false, false, 8269m, "Room 102-57", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9615) },
                    { 188, 2, new DateTime(2024, 7, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9642), null, "A bright and cheerful room in Royal Hall.", 58, true, true, false, 10525m, "Room 100-58", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9642) },
                    { 189, 2, new DateTime(2024, 10, 1, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9646), null, "A bright and cheerful room in Royal Hall.", 58, true, true, false, 9116m, "Room 101-58", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9647) },
                    { 190, 2, new DateTime(2024, 4, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9651), null, "A comfortable and well-lit room in Royal Hall.", 58, true, true, false, 9400m, "Room 102-58", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9651) },
                    { 191, 4, new DateTime(2024, 3, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9655), null, "A clean and minimalist room in Royal Hall.", 58, true, true, false, 12383m, "Room 103-58", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9656) },
                    { 192, 1, new DateTime(2024, 8, 31, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9660), null, "A newly renovated room in Royal Hall.", 58, true, true, false, 10512m, "Room 104-58", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9661) },
                    { 193, 3, new DateTime(2024, 5, 24, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9689), null, "A fully furnished room in Central Dwellings.", 59, true, true, false, 8189m, "Room 100-59", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9689) },
                    { 194, 3, new DateTime(2025, 1, 3, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9693), null, "A cozy and quiet room in Central Dwellings.", 59, true, false, false, 8894m, "Room 101-59", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9694) },
                    { 195, 4, new DateTime(2024, 9, 26, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9698), null, "A modern and stylish room in Central Dwellings.", 59, true, true, false, 5848m, "Room 102-59", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9698) },
                    { 196, 2, new DateTime(2025, 1, 19, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9723), null, "A newly renovated room in Elite Quarters.", 60, true, false, false, 10294m, "Room 100-60", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9724) },
                    { 197, 3, new DateTime(2024, 8, 20, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9727), null, "A bright and cheerful room in Elite Quarters.", 60, true, true, false, 14969m, "Room 101-60", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9728) },
                    { 198, 2, new DateTime(2025, 3, 1, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9732), null, "A clean and minimalist room in Elite Quarters.", 60, true, true, false, 13704m, "Room 102-60", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9733) },
                    { 199, 3, new DateTime(2024, 6, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9736), null, "A functional and practical room in Elite Quarters.", 60, true, true, false, 11064m, "Room 103-60", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9737) },
                    { 200, 2, new DateTime(2024, 11, 24, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9769), null, "A spacious and airy room in Superior Place.", 61, true, true, false, 5858m, "Room 100-61", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9770) },
                    { 201, 4, new DateTime(2025, 2, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9774), null, "A charming and homey room in Superior Place.", 61, true, true, false, 11894m, "Room 101-61", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9774) },
                    { 202, 3, new DateTime(2024, 8, 25, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9778), null, "A spacious and airy room in Superior Place.", 61, true, true, false, 6723m, "Room 102-61", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9779) },
                    { 203, 2, new DateTime(2025, 1, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9806), null, "A charming and homey room in Grand Suites.", 62, true, true, false, 5911m, "Room 100-62", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9807) },
                    { 204, 3, new DateTime(2024, 11, 20, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9810), null, "A modern and stylish room in Grand Suites.", 62, true, false, false, 7677m, "Room 101-62", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9811) },
                    { 205, 4, new DateTime(2024, 3, 17, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9832), null, "A spacious and airy room in Royal House.", 63, true, true, false, 8246m, "Room 100-63", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9833) },
                    { 206, 3, new DateTime(2024, 8, 8, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9847), null, "A newly renovated room in Royal House.", 63, true, true, false, 9860m, "Room 101-63", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9847) },
                    { 207, 1, new DateTime(2024, 10, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9851), null, "A bright and cheerful room in Royal House.", 63, true, true, false, 14428m, "Room 102-63", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9852) },
                    { 208, 2, new DateTime(2024, 11, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9855), null, "A functional and practical room in Royal House.", 63, true, true, false, 10495m, "Room 103-63", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9856) },
                    { 209, 1, new DateTime(2024, 5, 16, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9884), null, "A bright and cheerful room in Central Hall.", 64, true, true, false, 13066m, "Room 100-64", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9885) },
                    { 210, 4, new DateTime(2024, 11, 14, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9889), null, "A clean and minimalist room in Central Hall.", 64, true, true, false, 13701m, "Room 101-64", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9890) },
                    { 211, 2, new DateTime(2024, 5, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9893), null, "A newly renovated room in Central Hall.", 64, true, true, false, 13834m, "Room 102-64", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9894) },
                    { 212, 2, new DateTime(2024, 4, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9897), null, "A modern and stylish room in Central Hall.", 64, true, true, false, 9884m, "Room 103-64", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9898) },
                    { 213, 1, new DateTime(2024, 8, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9934), null, "A fully furnished room in Grand Place.", 65, true, true, false, 13706m, "Room 100-65", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9935) },
                    { 214, 1, new DateTime(2024, 8, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9938), null, "A clean and minimalist room in Grand Place.", 65, true, true, false, 12255m, "Room 101-65", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9939) },
                    { 215, 3, new DateTime(2024, 6, 29, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9943), null, "A newly renovated room in Grand Place.", 65, true, true, false, 9065m, "Room 102-65", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9944) },
                    { 216, 2, new DateTime(2024, 6, 9, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9948), null, "A cozy and quiet room in Grand Place.", 65, true, true, false, 9821m, "Room 103-65", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9949) },
                    { 217, 1, new DateTime(2024, 6, 14, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9952), null, "A functional and practical room in Grand Place.", 65, true, true, false, 12760m, "Room 104-65", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9953) },
                    { 220, 2, new DateTime(2024, 9, 29, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(15), null, "A functional and practical room in Grand Hall.", 67, true, true, false, 6068m, "Room 100-67", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(16) },
                    { 221, 4, new DateTime(2024, 4, 10, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(20), null, "A fully furnished room in Grand Hall.", 67, true, true, false, 13482m, "Room 101-67", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(20) },
                    { 222, 1, new DateTime(2024, 4, 17, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(24), null, "A charming and homey room in Grand Hall.", 67, true, true, false, 7699m, "Room 102-67", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(25) },
                    { 223, 2, new DateTime(2025, 1, 27, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(29), null, "A newly renovated room in Grand Hall.", 67, true, true, false, 8594m, "Room 103-67", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(29) },
                    { 224, 2, new DateTime(2024, 8, 9, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(33), null, "A newly renovated room in Grand Hall.", 67, true, true, false, 6480m, "Room 104-67", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(34) },
                    { 225, 1, new DateTime(2024, 10, 31, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(56), null, "A functional and practical room in Central Suites.", 68, true, true, false, 6440m, "Room 100-68", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(57) },
                    { 226, 2, new DateTime(2024, 7, 30, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(61), null, "A fully furnished room in Central Suites.", 68, true, true, false, 13125m, "Room 101-68", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(61) },
                    { 227, 3, new DateTime(2024, 7, 26, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(65), null, "A clean and minimalist room in Central Suites.", 68, true, true, false, 13455m, "Room 102-68", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(66) },
                    { 228, 3, new DateTime(2024, 10, 1, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(70), null, "A spacious and airy room in Central Suites.", 68, true, true, false, 6728m, "Room 103-68", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(70) },
                    { 229, 2, new DateTime(2024, 3, 19, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(74), null, "A modern and stylish room in Central Suites.", 68, true, true, false, 8675m, "Room 104-68", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(75) },
                    { 230, 3, new DateTime(2025, 2, 2, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(109), null, "A spacious and airy room in Elite Suites.", 69, true, true, false, 5387m, "Room 100-69", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(109) },
                    { 231, 3, new DateTime(2024, 6, 14, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(113), null, "A cozy and quiet room in Elite Suites.", 69, true, true, false, 14346m, "Room 101-69", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(114) },
                    { 232, 3, new DateTime(2024, 5, 8, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(118), null, "A spacious and airy room in Elite Suites.", 69, true, false, false, 13290m, "Room 102-69", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(118) },
                    { 233, 4, new DateTime(2024, 7, 24, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(122), null, "A bright and cheerful room in Elite Suites.", 69, true, true, false, 9912m, "Room 103-69", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(123) },
                    { 234, 2, new DateTime(2024, 11, 3, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(126), null, "A modern and stylish room in Elite Suites.", 69, true, true, false, 7140m, "Room 104-69", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(127) },
                    { 235, 1, new DateTime(2025, 1, 28, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(149), null, "A comfortable and well-lit room in Purple Residences.", 70, true, true, false, 8180m, "Room 100-70", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(150) },
                    { 236, 1, new DateTime(2024, 10, 14, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(154), null, "A cozy and quiet room in Purple Residences.", 70, true, true, false, 10758m, "Room 101-70", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(155) },
                    { 237, 4, new DateTime(2024, 9, 17, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(158), null, "A spacious and airy room in Purple Residences.", 70, true, true, false, 14924m, "Room 102-70", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(159) },
                    { 238, 1, new DateTime(2024, 10, 4, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(191), null, "A functional and practical room in Elite House.", 71, true, true, false, 10731m, "Room 100-71", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(192) },
                    { 239, 1, new DateTime(2024, 11, 23, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(195), null, "A newly renovated room in Elite House.", 71, true, true, false, 14795m, "Room 101-71", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(196) },
                    { 240, 4, new DateTime(2024, 11, 22, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(200), null, "A newly renovated room in Elite House.", 71, true, true, false, 13874m, "Room 102-71", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(201) },
                    { 241, 2, new DateTime(2024, 7, 18, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(205), null, "A cozy and quiet room in Elite House.", 71, true, true, false, 12389m, "Room 103-71", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(205) },
                    { 242, 4, new DateTime(2025, 3, 1, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(209), null, "A fully furnished room in Elite House.", 71, true, true, false, 10449m, "Room 104-71", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(210) },
                    { 243, 4, new DateTime(2024, 12, 9, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(231), null, "A newly renovated room in Grand Dormitory.", 72, true, true, false, 6313m, "Room 100-72", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(232) },
                    { 244, 2, new DateTime(2024, 5, 12, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(236), null, "A clean and minimalist room in Grand Dormitory.", 72, true, true, false, 8850m, "Room 101-72", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(237) },
                    { 245, 1, new DateTime(2024, 4, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(240), null, "A functional and practical room in Grand Dormitory.", 72, true, true, false, 14319m, "Room 102-72", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(241) },
                    { 250, 3, new DateTime(2024, 3, 28, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(312), null, "A charming and homey room in Crystal Suites.", 74, true, true, false, 6897m, "Room 100-74", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(312) },
                    { 251, 4, new DateTime(2024, 5, 13, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(316), null, "A spacious and airy room in Crystal Suites.", 74, true, true, false, 9795m, "Room 101-74", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(317) },
                    { 252, 3, new DateTime(2024, 7, 3, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(320), null, "A bright and cheerful room in Crystal Suites.", 74, true, true, false, 11361m, "Room 102-74", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(321) },
                    { 253, 2, new DateTime(2024, 8, 4, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(330), null, "A newly renovated room in Crystal Suites.", 74, true, true, false, 9286m, "Room 103-74", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(331) },
                    { 254, 1, new DateTime(2024, 8, 9, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(355), null, "A charming and homey room in Orange Hall.", 75, true, true, false, 4299m, "Room 100-75", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(356) },
                    { 255, 4, new DateTime(2024, 9, 10, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(360), null, "A newly renovated room in Orange Hall.", 75, true, true, false, 9575m, "Room 101-75", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(361) },
                    { 256, 4, new DateTime(2024, 8, 30, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(364), null, "A comfortable and well-lit room in Orange Hall.", 75, true, true, false, 7264m, "Room 102-75", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(365) },
                    { 257, 4, new DateTime(2025, 1, 14, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(369), null, "A charming and homey room in Orange Hall.", 75, true, true, false, 7435m, "Room 103-75", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(370) },
                    { 262, 3, new DateTime(2024, 12, 1, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(453), null, "A cozy and quiet room in Silver Quarters.", 77, true, true, false, 6563m, "Room 100-77", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(454) },
                    { 263, 4, new DateTime(2024, 8, 4, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(458), null, "A comfortable and well-lit room in Silver Quarters.", 77, true, true, false, 14756m, "Room 101-77", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(459) },
                    { 264, 3, new DateTime(2025, 2, 19, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(462), null, "A charming and homey room in Silver Quarters.", 77, true, true, false, 12152m, "Room 102-77", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(463) },
                    { 265, 2, new DateTime(2024, 9, 9, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(467), null, "A newly renovated room in Silver Quarters.", 77, true, true, false, 11681m, "Room 103-77", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(468) },
                    { 266, 3, new DateTime(2024, 7, 9, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(471), null, "A fully furnished room in Silver Quarters.", 77, true, true, false, 5431m, "Room 104-77", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(472) },
                    { 267, 2, new DateTime(2024, 11, 27, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(493), null, "A functional and practical room in Golden Residences.", 78, true, true, false, 6378m, "Room 100-78", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(494) },
                    { 268, 3, new DateTime(2025, 1, 17, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(498), null, "A fully furnished room in Golden Residences.", 78, true, true, false, 5434m, "Room 101-78", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(498) },
                    { 269, 2, new DateTime(2024, 6, 22, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(502), null, "A fully furnished room in Golden Residences.", 78, true, true, false, 10064m, "Room 102-78", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(503) },
                    { 270, 3, new DateTime(2024, 9, 20, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(506), null, "A clean and minimalist room in Golden Residences.", 78, true, true, false, 13958m, "Room 103-78", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(507) },
                    { 271, 1, new DateTime(2024, 8, 1, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(537), null, "A clean and minimalist room in Royal Dwellings.", 79, true, true, false, 10991m, "Room 100-79", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(537) },
                    { 272, 1, new DateTime(2025, 1, 8, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(541), null, "A charming and homey room in Royal Dwellings.", 79, true, true, false, 9763m, "Room 101-79", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(542) },
                    { 273, 1, new DateTime(2025, 2, 23, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(546), null, "A charming and homey room in Royal Dwellings.", 79, true, true, false, 6177m, "Room 102-79", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(546) },
                    { 274, 1, new DateTime(2024, 7, 23, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(550), null, "A cozy and quiet room in Royal Dwellings.", 79, true, false, false, 8946m, "Room 103-79", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(551) },
                    { 275, 3, new DateTime(2024, 4, 14, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(555), null, "A clean and minimalist room in Royal Dwellings.", 79, true, true, false, 8527m, "Room 104-79", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(556) },
                    { 276, 4, new DateTime(2024, 8, 7, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(580), null, "A cozy and quiet room in Premium Suites.", 80, true, true, false, 14438m, "Room 100-80", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(581) },
                    { 277, 1, new DateTime(2024, 11, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(584), null, "A modern and stylish room in Premium Suites.", 80, true, true, false, 6632m, "Room 101-80", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(585) },
                    { 278, 3, new DateTime(2024, 9, 13, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(589), null, "A cozy and quiet room in Premium Suites.", 80, true, true, false, 11202m, "Room 102-80", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(590) },
                    { 279, 4, new DateTime(2024, 11, 18, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(593), null, "A bright and cheerful room in Premium Suites.", 80, true, true, false, 7683m, "Room 103-80", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(594) },
                    { 285, 4, new DateTime(2025, 1, 15, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(666), null, "A modern and stylish room in Grand Residences.", 82, true, false, false, 7888m, "Room 100-82", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(667) },
                    { 286, 1, new DateTime(2025, 1, 17, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(673), null, "A clean and minimalist room in Grand Residences.", 82, true, true, false, 10886m, "Room 101-82", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(674) },
                    { 287, 1, new DateTime(2024, 5, 22, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(718), null, "A charming and homey room in Elite House.", 83, true, true, false, 12283m, "Room 100-83", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(719) },
                    { 288, 2, new DateTime(2025, 1, 26, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(724), null, "A modern and stylish room in Elite House.", 83, true, true, false, 7451m, "Room 101-83", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(725) },
                    { 289, 2, new DateTime(2024, 11, 3, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(730), null, "A functional and practical room in Elite House.", 83, true, false, false, 7629m, "Room 102-83", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(731) },
                    { 290, 1, new DateTime(2024, 4, 27, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(768), null, "A cozy and quiet room in Grand Living Spaces.", 84, true, true, false, 12688m, "Room 100-84", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(769) },
                    { 291, 3, new DateTime(2024, 6, 1, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(776), null, "A comfortable and well-lit room in Grand Living Spaces.", 84, true, true, false, 6843m, "Room 101-84", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(777) },
                    { 292, 2, new DateTime(2024, 12, 29, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(784), null, "A spacious and airy room in Grand Living Spaces.", 84, true, true, false, 14761m, "Room 102-84", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(785) },
                    { 293, 4, new DateTime(2025, 1, 19, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(791), null, "A newly renovated room in Grand Living Spaces.", 84, true, true, false, 8944m, "Room 103-84", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(792) },
                    { 294, 2, new DateTime(2025, 2, 15, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(839), null, "A modern and stylish room in Red Dwellings.", 85, true, true, false, 10461m, "Room 100-85", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(840) },
                    { 295, 3, new DateTime(2024, 8, 7, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(845), null, "A functional and practical room in Red Dwellings.", 85, true, false, false, 5323m, "Room 101-85", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(846) },
                    { 296, 2, new DateTime(2025, 1, 7, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(851), null, "A spacious and airy room in Red Dwellings.", 85, true, false, false, 13388m, "Room 102-85", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(852) },
                    { 297, 4, new DateTime(2024, 8, 27, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(857), null, "A modern and stylish room in Red Dwellings.", 85, true, false, false, 5947m, "Room 103-85", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(858) },
                    { 298, 3, new DateTime(2024, 12, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(864), null, "A cozy and quiet room in Red Dwellings.", 85, true, true, false, 5905m, "Room 104-85", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(865) },
                    { 299, 4, new DateTime(2024, 5, 11, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(899), null, "A clean and minimalist room in Orange Suites.", 86, true, false, false, 11103m, "Room 100-86", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(900) },
                    { 300, 3, new DateTime(2024, 5, 20, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(904), null, "A clean and minimalist room in Orange Suites.", 86, true, true, false, 11113m, "Room 101-86", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(905) },
                    { 301, 2, new DateTime(2024, 7, 16, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(909), null, "A functional and practical room in Orange Suites.", 86, true, true, false, 10606m, "Room 102-86", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(910) },
                    { 314, 1, new DateTime(2024, 11, 20, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1111), null, "A bright and cheerful room in Grand Residences.", 91, true, true, false, 10074m, "Room 100-91", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1112) },
                    { 315, 4, new DateTime(2024, 11, 14, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1116), null, "A fully furnished room in Grand Residences.", 91, true, true, false, 8910m, "Room 101-91", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1117) },
                    { 316, 2, new DateTime(2024, 5, 23, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1121), null, "A newly renovated room in Grand Residences.", 91, true, true, false, 12082m, "Room 102-91", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1121) },
                    { 317, 4, new DateTime(2024, 7, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1125), null, "A cozy and quiet room in Grand Residences.", 91, true, true, false, 10431m, "Room 103-91", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1126) },
                    { 318, 4, new DateTime(2024, 8, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1151), null, "A functional and practical room in Elite House.", 92, true, true, false, 5969m, "Room 100-92", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1152) },
                    { 319, 1, new DateTime(2024, 6, 26, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1156), null, "A spacious and airy room in Elite House.", 92, true, true, false, 12944m, "Room 101-92", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1157) },
                    { 320, 4, new DateTime(2024, 11, 11, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1160), null, "A bright and cheerful room in Elite House.", 92, true, true, false, 12221m, "Room 102-92", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1161) },
                    { 327, 1, new DateTime(2024, 9, 8, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1259), null, "A newly renovated room in Golden Dwellings.", 95, true, true, false, 5282m, "Room 100-95", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1260) },
                    { 328, 2, new DateTime(2024, 10, 27, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1272), null, "A bright and cheerful room in Golden Dwellings.", 95, true, true, false, 13018m, "Room 101-95", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1273) },
                    { 329, 1, new DateTime(2024, 10, 11, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1294), null, "A bright and cheerful room in Elegant Living Spaces.", 96, true, true, false, 11467m, "Room 100-96", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1295) },
                    { 330, 4, new DateTime(2024, 11, 11, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1298), null, "A bright and cheerful room in Elegant Living Spaces.", 96, true, true, false, 10345m, "Room 101-96", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1299) },
                    { 331, 4, new DateTime(2024, 8, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1303), null, "A clean and minimalist room in Elegant Living Spaces.", 96, true, true, false, 6206m, "Room 102-96", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1303) },
                    { 334, 3, new DateTime(2024, 3, 11, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1368), null, "A cozy and quiet room in Blue Living Spaces.", 98, true, true, false, 8301m, "Room 100-98", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1369) },
                    { 335, 3, new DateTime(2024, 8, 22, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1373), null, "A spacious and airy room in Blue Living Spaces.", 98, true, true, false, 14905m, "Room 101-98", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1373) },
                    { 336, 2, new DateTime(2025, 1, 25, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1377), null, "A comfortable and well-lit room in Blue Living Spaces.", 98, true, true, false, 12030m, "Room 102-98", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1378) },
                    { 337, 2, new DateTime(2024, 10, 24, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1381), null, "A clean and minimalist room in Blue Living Spaces.", 98, true, true, false, 11735m, "Room 103-98", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1382) },
                    { 338, 3, new DateTime(2025, 2, 3, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1386), null, "A comfortable and well-lit room in Blue Living Spaces.", 98, true, false, false, 5078m, "Room 104-98", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1386) },
                    { 342, 4, new DateTime(2024, 5, 16, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1458), null, "A spacious and airy room in Premium Residences.", 100, true, true, false, 14631m, "Room 100-100", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1459) },
                    { 343, 4, new DateTime(2024, 12, 31, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1462), null, "A functional and practical room in Premium Residences.", 100, true, true, false, 9256m, "Room 101-100", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1463) },
                    { 344, 3, new DateTime(2024, 12, 31, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1467), null, "A bright and cheerful room in Premium Residences.", 100, true, true, false, 15161m, "Room 102-100", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1467) },
                    { 345, 2, new DateTime(2024, 4, 12, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1471), null, "A charming and homey room in Premium Residences.", 100, true, true, false, 9716m, "Room 103-100", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1472) }
                });

            migrationBuilder.InsertData(
                table: "DormTags",
                columns: new[] { "Id", "DeletedAt", "DormId", "IsActive", "IsDeleted", "TagId" },
                values: new object[,]
                {
                    { 6, null, 2, true, false, 13 },
                    { 7, null, 2, true, false, 10 },
                    { 8, null, 2, true, false, 3 },
                    { 27, null, 7, true, false, 16 },
                    { 28, null, 7, true, false, 15 },
                    { 29, null, 7, true, false, 13 },
                    { 30, null, 7, true, false, 12 },
                    { 31, null, 7, true, false, 10 },
                    { 32, null, 7, true, false, 7 },
                    { 37, null, 9, true, false, 15 },
                    { 38, null, 9, true, false, 12 },
                    { 39, null, 9, true, false, 9 },
                    { 40, null, 9, true, false, 14 },
                    { 41, null, 9, true, false, 2 },
                    { 42, null, 9, true, false, 5 },
                    { 43, null, 10, true, false, 16 },
                    { 44, null, 10, true, false, 11 },
                    { 45, null, 10, true, false, 13 },
                    { 46, null, 10, true, false, 2 },
                    { 47, null, 10, true, false, 4 },
                    { 66, null, 15, true, false, 10 },
                    { 67, null, 15, true, false, 1 },
                    { 68, null, 15, true, false, 2 },
                    { 69, null, 16, true, false, 14 },
                    { 70, null, 16, true, false, 15 },
                    { 71, null, 16, true, false, 13 },
                    { 72, null, 16, true, false, 9 },
                    { 73, null, 16, true, false, 4 },
                    { 74, null, 16, true, false, 6 },
                    { 79, null, 18, true, false, 12 },
                    { 80, null, 18, true, false, 11 },
                    { 81, null, 18, true, false, 10 },
                    { 82, null, 18, true, false, 5 },
                    { 83, null, 19, true, false, 14 },
                    { 84, null, 19, true, false, 9 },
                    { 85, null, 19, true, false, 13 },
                    { 86, null, 19, true, false, 15 },
                    { 87, null, 19, true, false, 7 },
                    { 88, null, 19, true, false, 4 },
                    { 114, null, 25, true, false, 12 },
                    { 115, null, 25, true, false, 13 },
                    { 116, null, 25, true, false, 9 },
                    { 117, null, 25, true, false, 8 },
                    { 118, null, 25, true, false, 3 },
                    { 177, null, 38, true, false, 10 },
                    { 178, null, 38, true, false, 15 },
                    { 179, null, 38, true, false, 1 },
                    { 180, null, 38, true, false, 6 },
                    { 190, null, 41, true, false, 13 },
                    { 191, null, 41, true, false, 16 },
                    { 192, null, 41, true, false, 5 },
                    { 193, null, 41, true, false, 1 },
                    { 194, null, 42, true, false, 15 },
                    { 195, null, 42, true, false, 9 },
                    { 196, null, 42, true, false, 10 },
                    { 197, null, 42, true, false, 7 },
                    { 198, null, 43, true, false, 14 },
                    { 199, null, 43, true, false, 10 },
                    { 200, null, 43, true, false, 4 },
                    { 211, null, 46, true, false, 15 },
                    { 212, null, 46, true, false, 9 },
                    { 213, null, 46, true, false, 11 },
                    { 214, null, 46, true, false, 16 },
                    { 215, null, 46, true, false, 8 },
                    { 216, null, 47, true, false, 11 },
                    { 217, null, 47, true, false, 15 },
                    { 218, null, 47, true, false, 16 },
                    { 219, null, 47, true, false, 5 },
                    { 220, null, 47, true, false, 4 },
                    { 221, null, 47, true, false, 1 },
                    { 237, null, 51, true, false, 10 },
                    { 238, null, 51, true, false, 12 },
                    { 239, null, 51, true, false, 16 },
                    { 240, null, 51, true, false, 9 },
                    { 241, null, 51, true, false, 8 },
                    { 308, null, 66, true, false, 13 },
                    { 309, null, 66, true, false, 14 },
                    { 310, null, 66, true, false, 12 },
                    { 311, null, 66, true, false, 4 },
                    { 312, null, 66, true, false, 7 },
                    { 313, null, 66, true, false, 8 },
                    { 341, null, 73, true, false, 16 },
                    { 342, null, 73, true, false, 11 },
                    { 343, null, 73, true, false, 7 },
                    { 344, null, 73, true, false, 1 },
                    { 345, null, 73, true, false, 8 },
                    { 354, null, 76, true, false, 9 },
                    { 355, null, 76, true, false, 11 },
                    { 356, null, 76, true, false, 12 },
                    { 357, null, 76, true, false, 10 },
                    { 358, null, 76, true, false, 2 },
                    { 359, null, 76, true, false, 3 },
                    { 378, null, 81, true, false, 14 },
                    { 379, null, 81, true, false, 10 },
                    { 380, null, 81, true, false, 12 },
                    { 381, null, 81, true, false, 13 },
                    { 382, null, 81, true, false, 9 },
                    { 383, null, 81, true, false, 2 },
                    { 384, null, 81, true, false, 6 },
                    { 385, null, 81, true, false, 8 },
                    { 413, null, 87, true, false, 9 },
                    { 414, null, 87, true, false, 16 },
                    { 415, null, 87, true, false, 15 },
                    { 416, null, 87, true, false, 11 },
                    { 417, null, 87, true, false, 7 },
                    { 418, null, 88, true, false, 14 },
                    { 419, null, 88, true, false, 10 },
                    { 420, null, 88, true, false, 13 },
                    { 421, null, 88, true, false, 4 },
                    { 422, null, 88, true, false, 3 },
                    { 423, null, 89, true, false, 14 },
                    { 424, null, 89, true, false, 11 },
                    { 425, null, 89, true, false, 13 },
                    { 426, null, 89, true, false, 5 },
                    { 427, null, 90, true, false, 10 },
                    { 428, null, 90, true, false, 16 },
                    { 429, null, 90, true, false, 5 },
                    { 430, null, 90, true, false, 1 },
                    { 431, null, 90, true, false, 2 },
                    { 441, null, 93, true, false, 9 },
                    { 442, null, 93, true, false, 11 },
                    { 443, null, 93, true, false, 6 },
                    { 444, null, 93, true, false, 3 },
                    { 445, null, 93, true, false, 8 },
                    { 446, null, 94, true, false, 9 },
                    { 447, null, 94, true, false, 13 },
                    { 448, null, 94, true, false, 3 },
                    { 457, null, 97, true, false, 9 },
                    { 458, null, 97, true, false, 10 },
                    { 459, null, 97, true, false, 14 },
                    { 460, null, 97, true, false, 2 },
                    { 461, null, 97, true, false, 6 },
                    { 462, null, 97, true, false, 7 },
                    { 467, null, 99, true, false, 13 },
                    { 468, null, 99, true, false, 15 },
                    { 469, null, 99, true, false, 14 },
                    { 470, null, 99, true, false, 2 },
                    { 471, null, 99, true, false, 4 },
                    { 472, null, 99, true, false, 6 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Caption", "CreatedAt", "DeletedAt", "DormId", "IsActive", "IsDeleted", "IsPrimary", "Order", "UpdatedAt", "Url" },
                values: new object[,]
                {
                    { 7, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7179), null, 2, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7179), "https://loremflickr.com/1024/768/house/all?lock=628" },
                    { 8, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7181), null, 2, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7181), "https://loremflickr.com/1024/768/house/all?lock=616" },
                    { 9, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7182), null, 2, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7183), "https://loremflickr.com/1024/600/house/all?lock=583" },
                    { 10, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7185), null, 2, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7185), "https://loremflickr.com/1024/768/house/all?lock=795" },
                    { 11, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7187), null, 2, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7187), "https://loremflickr.com/800/768/house/all?lock=1071" },
                    { 12, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7188), null, 2, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7189), "https://loremflickr.com/800/600/house/all?lock=958" },
                    { 32, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7433), null, 7, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7433), "https://loremflickr.com/1024/768/house/all?lock=1629" },
                    { 33, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7435), null, 7, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7435), "https://loremflickr.com/1200/768/house/all?lock=816" },
                    { 34, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7438), null, 7, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7438), "https://loremflickr.com/1024/900/house/all?lock=1097" },
                    { 35, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7439), null, 7, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7440), "https://loremflickr.com/1024/900/house/all?lock=1240" },
                    { 36, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7441), null, 7, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7442), "https://loremflickr.com/1024/768/house/all?lock=1586" },
                    { 40, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7535), null, 9, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7535), "https://loremflickr.com/800/900/house/all?lock=1082" },
                    { 41, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7537), null, 9, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7537), "https://loremflickr.com/800/900/house/all?lock=1871" },
                    { 42, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7538), null, 9, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7539), "https://loremflickr.com/1024/600/house/all?lock=1901" },
                    { 43, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7540), null, 9, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7540), "https://loremflickr.com/1200/600/house/all?lock=1242" },
                    { 44, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7542), null, 9, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7542), "https://loremflickr.com/800/900/house/all?lock=1439" },
                    { 45, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7572), null, 10, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7572), "https://loremflickr.com/800/900/house/all?lock=1017" },
                    { 46, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7574), null, 10, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7574), "https://loremflickr.com/800/900/house/all?lock=1097" },
                    { 47, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7575), null, 10, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7576), "https://loremflickr.com/800/900/house/all?lock=1316" },
                    { 48, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7577), null, 10, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7577), "https://loremflickr.com/800/900/house/all?lock=1461" },
                    { 49, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7579), null, 10, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7579), "https://loremflickr.com/1200/900/house/all?lock=1172" },
                    { 50, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7580), null, 10, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7581), "https://loremflickr.com/1024/900/house/all?lock=1319" },
                    { 69, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7969), null, 15, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7970), "https://loremflickr.com/1200/900/house/all?lock=1857" },
                    { 70, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7971), null, 15, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7971), "https://loremflickr.com/800/768/house/all?lock=1920" },
                    { 71, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7973), null, 15, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7973), "https://loremflickr.com/800/600/house/all?lock=1874" },
                    { 72, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7974), null, 15, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7975), "https://loremflickr.com/800/900/house/all?lock=2488" },
                    { 73, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7976), null, 15, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(7977), "https://loremflickr.com/1024/600/house/all?lock=2333" },
                    { 74, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8024), null, 16, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8025), "https://loremflickr.com/1200/900/house/all?lock=2137" },
                    { 75, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8026), null, 16, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8026), "https://loremflickr.com/800/900/house/all?lock=2283" },
                    { 76, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8028), null, 16, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8028), "https://loremflickr.com/800/600/house/all?lock=1715" },
                    { 77, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8029), null, 16, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8029), "https://loremflickr.com/800/600/house/all?lock=1675" },
                    { 78, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8030), null, 16, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8031), "https://loremflickr.com/1024/768/house/all?lock=1956" },
                    { 79, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8032), null, 16, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8032), "https://loremflickr.com/1024/768/house/all?lock=1619" },
                    { 83, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8095), null, 18, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8095), "https://loremflickr.com/800/900/house/all?lock=2088" },
                    { 84, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8097), null, 18, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8097), "https://loremflickr.com/800/900/house/all?lock=2129" },
                    { 85, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8098), null, 18, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8098), "https://loremflickr.com/1024/768/house/all?lock=1980" },
                    { 86, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8131), null, 19, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8131), "https://loremflickr.com/1200/900/house/all?lock=2497" },
                    { 87, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8132), null, 19, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8132), "https://loremflickr.com/1200/768/house/all?lock=2553" },
                    { 88, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8134), null, 19, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8134), "https://loremflickr.com/800/600/house/all?lock=2063" },
                    { 114, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8373), null, 25, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8374), "https://loremflickr.com/1024/900/house/all?lock=3267" },
                    { 115, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8375), null, 25, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8375), "https://loremflickr.com/1024/900/house/all?lock=3431" },
                    { 116, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8376), null, 25, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8377), "https://loremflickr.com/1200/600/house/all?lock=2934" },
                    { 117, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8378), null, 25, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8378), "https://loremflickr.com/1200/600/house/all?lock=3096" },
                    { 118, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8385), null, 25, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8385), "https://loremflickr.com/1200/768/house/all?lock=2676" },
                    { 119, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8387), null, 25, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8387), "https://loremflickr.com/1200/600/house/all?lock=3031" },
                    { 180, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8880), null, 38, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8880), "https://loremflickr.com/1200/768/house/all?lock=4594" },
                    { 181, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8881), null, 38, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8882), "https://loremflickr.com/800/900/house/all?lock=4544" },
                    { 182, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8883), null, 38, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(8883), "https://loremflickr.com/1024/900/house/all?lock=4624" },
                    { 193, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9016), null, 41, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9017), "https://loremflickr.com/1024/600/house/all?lock=4914" },
                    { 194, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9018), null, 41, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9018), "https://loremflickr.com/1024/600/house/all?lock=4326" },
                    { 195, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9019), null, 41, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9020), "https://loremflickr.com/1024/900/house/all?lock=4389" },
                    { 196, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9021), null, 41, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9021), "https://loremflickr.com/800/900/house/all?lock=4634" },
                    { 197, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9023), null, 41, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9023), "https://loremflickr.com/1024/900/house/all?lock=4678" },
                    { 198, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9057), null, 42, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9057), "https://loremflickr.com/800/768/house/all?lock=4218" },
                    { 199, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9058), null, 42, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9058), "https://loremflickr.com/1024/768/house/all?lock=4730" },
                    { 200, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9060), null, 42, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9060), "https://loremflickr.com/800/768/house/all?lock=4373" },
                    { 201, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9061), null, 42, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9062), "https://loremflickr.com/800/768/house/all?lock=4860" },
                    { 202, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9083), null, 43, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9083), "https://loremflickr.com/1024/900/house/all?lock=4557" },
                    { 203, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9085), null, 43, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9085), "https://loremflickr.com/1024/600/house/all?lock=4461" },
                    { 204, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9086), null, 43, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9086), "https://loremflickr.com/1024/768/house/all?lock=4398" },
                    { 205, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9088), null, 43, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9088), "https://loremflickr.com/1200/900/house/all?lock=4361" },
                    { 206, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9089), null, 43, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9089), "https://loremflickr.com/1024/900/house/all?lock=5295" },
                    { 207, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9091), null, 43, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9091), "https://loremflickr.com/1024/900/house/all?lock=5275" },
                    { 217, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9194), null, 46, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9195), "https://loremflickr.com/1200/900/house/all?lock=5136" },
                    { 218, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9196), null, 46, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9196), "https://loremflickr.com/800/900/house/all?lock=5006" },
                    { 219, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9202), null, 46, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9203), "https://loremflickr.com/1024/900/house/all?lock=4826" },
                    { 220, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9204), null, 46, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9204), "https://loremflickr.com/1200/768/house/all?lock=4730" },
                    { 221, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9230), null, 47, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9230), "https://loremflickr.com/1024/768/house/all?lock=5494" },
                    { 222, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9231), null, 47, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9232), "https://loremflickr.com/1024/900/house/all?lock=5412" },
                    { 223, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9233), null, 47, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9233), "https://loremflickr.com/800/900/house/all?lock=4932" },
                    { 224, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9234), null, 47, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9235), "https://loremflickr.com/800/600/house/all?lock=5680" },
                    { 240, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9373), null, 51, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9373), "https://loremflickr.com/800/600/house/all?lock=5547" },
                    { 241, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9375), null, 51, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9375), "https://loremflickr.com/1200/768/house/all?lock=5180" },
                    { 242, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9376), null, 51, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9377), "https://loremflickr.com/1200/600/house/all?lock=5540" },
                    { 243, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9378), null, 51, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9378), "https://loremflickr.com/1024/600/house/all?lock=5629" },
                    { 244, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9380), null, 51, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9380), "https://loremflickr.com/1200/900/house/all?lock=5995" },
                    { 245, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9381), null, 51, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9381), "https://loremflickr.com/800/600/house/all?lock=5854" },
                    { 313, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9987), null, 66, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9987), "https://loremflickr.com/800/900/house/all?lock=7366" },
                    { 314, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9994), null, 66, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9998), "https://loremflickr.com/1200/900/house/all?lock=7102" },
                    { 315, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9999), null, 66, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 602, DateTimeKind.Utc).AddTicks(9999), "https://loremflickr.com/1024/600/house/all?lock=7139" },
                    { 316, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc), null, 66, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1), "https://loremflickr.com/800/768/house/all?lock=7477" },
                    { 317, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(2), null, 66, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(2), "https://loremflickr.com/1024/768/house/all?lock=7102" },
                    { 318, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(4), null, 66, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(4), "https://loremflickr.com/800/900/house/all?lock=7531" },
                    { 344, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(291), null, 73, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(291), "https://loremflickr.com/800/600/house/all?lock=8297" },
                    { 345, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(293), null, 73, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(293), "https://loremflickr.com/1200/600/house/all?lock=7969" },
                    { 346, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(294), null, 73, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(295), "https://loremflickr.com/800/768/house/all?lock=8050" },
                    { 347, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(296), null, 73, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(296), "https://loremflickr.com/800/900/house/all?lock=7788" },
                    { 348, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(297), null, 73, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(298), "https://loremflickr.com/1024/768/house/all?lock=7389" },
                    { 349, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(299), null, 73, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(299), "https://loremflickr.com/1024/768/house/all?lock=8281" },
                    { 360, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(427), null, 76, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(427), "https://loremflickr.com/1024/600/house/all?lock=7960" },
                    { 361, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(429), null, 76, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(429), "https://loremflickr.com/1024/600/house/all?lock=8365" },
                    { 362, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(430), null, 76, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(430), "https://loremflickr.com/1200/768/house/all?lock=8520" },
                    { 363, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(432), null, 76, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(432), "https://loremflickr.com/800/900/house/all?lock=8437" },
                    { 364, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(433), null, 76, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(434), "https://loremflickr.com/800/600/house/all?lock=8494" },
                    { 365, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(435), null, 76, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(435), "https://loremflickr.com/1024/768/house/all?lock=7699" },
                    { 382, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(648), null, 81, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(648), "https://loremflickr.com/800/768/house/all?lock=8900" },
                    { 383, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(650), null, 81, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(650), "https://loremflickr.com/1200/768/house/all?lock=8549" },
                    { 384, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(651), null, 81, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(651), "https://loremflickr.com/1024/900/house/all?lock=8756" },
                    { 407, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(966), null, 87, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(966), "https://loremflickr.com/1024/768/house/all?lock=9495" },
                    { 408, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(968), null, 87, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(968), "https://loremflickr.com/800/900/house/all?lock=8897" },
                    { 409, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(969), null, 87, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(970), "https://loremflickr.com/800/600/house/all?lock=9562" },
                    { 410, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(971), null, 87, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(971), "https://loremflickr.com/1024/600/house/all?lock=9218" },
                    { 411, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1001), null, 88, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1002), "https://loremflickr.com/1024/768/house/all?lock=8825" },
                    { 412, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1003), null, 88, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1003), "https://loremflickr.com/800/900/house/all?lock=9439" },
                    { 413, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1004), null, 88, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1005), "https://loremflickr.com/800/768/house/all?lock=9779" },
                    { 414, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1006), null, 88, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1006), "https://loremflickr.com/1024/900/house/all?lock=9613" },
                    { 415, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1007), null, 88, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1008), "https://loremflickr.com/1024/600/house/all?lock=8922" },
                    { 416, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1009), null, 88, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1009), "https://loremflickr.com/1200/600/house/all?lock=9209" },
                    { 417, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1046), null, 89, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1046), "https://loremflickr.com/800/900/house/all?lock=9656" },
                    { 418, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1048), null, 89, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1048), "https://loremflickr.com/800/768/house/all?lock=9817" },
                    { 419, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1049), null, 89, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1050), "https://loremflickr.com/1200/600/house/all?lock=9206" },
                    { 420, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1051), null, 89, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1051), "https://loremflickr.com/1200/900/house/all?lock=8938" },
                    { 421, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1052), null, 89, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1053), "https://loremflickr.com/800/600/house/all?lock=9863" },
                    { 422, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1081), null, 90, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1082), "https://loremflickr.com/1200/900/house/all?lock=9871" },
                    { 423, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1083), null, 90, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1083), "https://loremflickr.com/1024/768/house/all?lock=9196" },
                    { 424, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1085), null, 90, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1085), "https://loremflickr.com/1200/900/house/all?lock=9399" },
                    { 425, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1086), null, 90, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1087), "https://loremflickr.com/800/900/house/all?lock=9645" },
                    { 426, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1088), null, 90, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1088), "https://loremflickr.com/1024/900/house/all?lock=9927" },
                    { 427, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1090), null, 90, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1090), "https://loremflickr.com/800/768/house/all?lock=9912" },
                    { 437, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1209), null, 93, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1209), "https://loremflickr.com/1200/900/house/all?lock=9366" },
                    { 438, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1212), null, 93, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1212), "https://loremflickr.com/1024/600/house/all?lock=10113" },
                    { 439, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1213), null, 93, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1214), "https://loremflickr.com/800/900/house/all?lock=9406" },
                    { 440, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1215), null, 93, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1215), "https://loremflickr.com/1024/600/house/all?lock=10089" },
                    { 441, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1217), null, 93, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1217), "https://loremflickr.com/1200/600/house/all?lock=9733" },
                    { 442, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1240), null, 94, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1240), "https://loremflickr.com/1024/768/house/all?lock=10332" },
                    { 443, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1242), null, 94, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1242), "https://loremflickr.com/1024/900/house/all?lock=9711" },
                    { 444, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1243), null, 94, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1243), "https://loremflickr.com/1024/600/house/all?lock=9922" },
                    { 445, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1245), null, 94, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1245), "https://loremflickr.com/1200/768/house/all?lock=9430" },
                    { 446, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1246), null, 94, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1247), "https://loremflickr.com/1024/600/house/all?lock=10229" },
                    { 447, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1248), null, 94, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1248), "https://loremflickr.com/1200/900/house/all?lock=10017" },
                    { 457, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1351), null, 97, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1351), "https://loremflickr.com/1024/768/house/all?lock=9803" },
                    { 458, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1353), null, 97, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1353), "https://loremflickr.com/800/900/house/all?lock=10224" },
                    { 459, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1355), null, 97, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1355), "https://loremflickr.com/1024/900/house/all?lock=10439" },
                    { 463, "Main View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1425), null, 99, true, false, true, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1426), "https://loremflickr.com/1200/600/house/all?lock=10693" },
                    { 464, "Exterior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1438), null, 99, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1439), "https://loremflickr.com/800/768/house/all?lock=10604" },
                    { 465, "Interior", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1440), null, 99, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1440), "https://loremflickr.com/1024/768/house/all?lock=9968" },
                    { 466, "Bedroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1442), null, 99, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1442), "https://loremflickr.com/800/768/house/all?lock=10881" },
                    { 467, "Bathroom", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1444), null, 99, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1444), "https://loremflickr.com/800/900/house/all?lock=10469" },
                    { 468, "Additional View", new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1445), null, 99, true, false, false, 0, new DateTime(2025, 3, 6, 7, 41, 6, 603, DateTimeKind.Utc).AddTicks(1445), "https://loremflickr.com/1024/600/house/all?lock=10304" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedAt", "DeletedAt", "Description", "DormId", "IsActive", "IsAvailable", "IsDeleted", "PricePerMonth", "RoomNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, 2, new DateTime(2024, 6, 11, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7140), null, "A newly renovated room in Green Residences.", 2, true, true, false, 8598m, "Room 100-2", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7140) },
                    { 4, 4, new DateTime(2024, 12, 5, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7146), null, "A charming and homey room in Green Residences.", 2, true, true, false, 5180m, "Room 101-2", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7146) },
                    { 5, 1, new DateTime(2024, 9, 29, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7165), null, "A cozy and quiet room in Green Residences.", 2, true, true, false, 10351m, "Room 102-2", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7166) },
                    { 6, 1, new DateTime(2024, 10, 19, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7171), null, "A charming and homey room in Green Residences.", 2, true, true, false, 10217m, "Room 103-2", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7172) },
                    { 19, 1, new DateTime(2024, 5, 9, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7407), null, "A spacious and airy room in Red Residences.", 7, true, true, false, 17967m, "Room 100-7", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7408) },
                    { 20, 3, new DateTime(2024, 8, 7, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7419), null, "A fully furnished room in Red Residences.", 7, true, false, false, 19333m, "Room 101-7", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7420) },
                    { 25, 4, new DateTime(2024, 10, 19, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7506), null, "A spacious and airy room in Silver Hall.", 9, true, true, false, 8820m, "Room 100-9", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7507) },
                    { 26, 1, new DateTime(2024, 4, 26, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7512), null, "A newly renovated room in Silver Hall.", 9, true, true, false, 9725m, "Room 101-9", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7512) },
                    { 27, 3, new DateTime(2025, 1, 18, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7516), null, "A comfortable and well-lit room in Silver Hall.", 9, true, true, false, 14614m, "Room 102-9", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7517) },
                    { 28, 3, new DateTime(2024, 9, 2, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7521), null, "A cozy and quiet room in Silver Hall.", 9, true, true, false, 10949m, "Room 103-9", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7522) },
                    { 29, 4, new DateTime(2024, 9, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7555), null, "A modern and stylish room in Premium Dwellings.", 10, true, true, false, 6625m, "Room 100-10", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7556) },
                    { 30, 3, new DateTime(2024, 9, 9, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7560), null, "A fully furnished room in Premium Dwellings.", 10, true, true, false, 10146m, "Room 101-10", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7561) },
                    { 31, 2, new DateTime(2024, 6, 16, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7564), null, "A modern and stylish room in Premium Dwellings.", 10, true, true, false, 8557m, "Room 102-10", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7565) },
                    { 50, 2, new DateTime(2024, 12, 30, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7954), null, "A modern and stylish room in Golden Lodgings.", 15, true, false, false, 8497m, "Room 100-15", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7955) },
                    { 51, 4, new DateTime(2025, 1, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7959), null, "A modern and stylish room in Golden Lodgings.", 15, true, true, false, 10453m, "Room 101-15", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7959) },
                    { 52, 3, new DateTime(2024, 5, 28, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7964), null, "A newly renovated room in Golden Lodgings.", 15, true, true, false, 12428m, "Room 102-15", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7964) },
                    { 53, 3, new DateTime(2024, 10, 17, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7997), null, "A functional and practical room in Red Residences.", 16, true, true, false, 21557m, "Room 100-16", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(7997) },
                    { 54, 4, new DateTime(2024, 7, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8001), null, "A functional and practical room in Red Residences.", 16, true, true, false, 33378m, "Room 101-16", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8002) },
                    { 55, 4, new DateTime(2025, 2, 25, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8006), null, "A cozy and quiet room in Red Residences.", 16, true, true, false, 27219m, "Room 102-16", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8007) },
                    { 56, 4, new DateTime(2024, 8, 17, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8011), null, "A functional and practical room in Red Residences.", 16, true, true, false, 31736m, "Room 103-16", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8012) },
                    { 57, 4, new DateTime(2025, 2, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8016), null, "A newly renovated room in Red Residences.", 16, true, true, false, 34658m, "Room 104-16", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8016) },
                    { 60, 3, new DateTime(2024, 8, 23, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8080), null, "A charming and homey room in Elite Suites.", 18, true, true, false, 10051m, "Room 100-18", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8080) },
                    { 61, 2, new DateTime(2025, 2, 13, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8084), null, "A bright and cheerful room in Elite Suites.", 18, true, true, false, 6022m, "Room 101-18", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8085) },
                    { 62, 1, new DateTime(2024, 5, 4, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8089), null, "A comfortable and well-lit room in Elite Suites.", 18, true, true, false, 4983m, "Room 102-18", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8089) },
                    { 63, 1, new DateTime(2024, 8, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8112), null, "A fully furnished room in Elegant Living Spaces.", 19, true, false, false, 7523m, "Room 100-19", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8112) },
                    { 64, 2, new DateTime(2025, 2, 5, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8116), null, "A bright and cheerful room in Elegant Living Spaces.", 19, true, false, false, 6014m, "Room 101-19", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8117) },
                    { 65, 1, new DateTime(2024, 5, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8121), null, "A clean and minimalist room in Elegant Living Spaces.", 19, true, true, false, 9712m, "Room 102-19", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8121) },
                    { 85, 3, new DateTime(2024, 12, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8361), null, "A charming and homey room in Orange Living Spaces.", 25, true, true, false, 23603m, "Room 100-25", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8362) },
                    { 86, 3, new DateTime(2024, 5, 8, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8366), null, "A charming and homey room in Orange Living Spaces.", 25, true, true, false, 22808m, "Room 101-25", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8367) },
                    { 122, 3, new DateTime(2024, 11, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8860), null, "A charming and homey room in Orange Dwellings.", 38, true, true, false, 7886m, "Room 100-38", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8861) },
                    { 123, 2, new DateTime(2025, 1, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8865), null, "A cozy and quiet room in Orange Dwellings.", 38, true, false, false, 10480m, "Room 101-38", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8866) },
                    { 124, 4, new DateTime(2025, 1, 21, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8869), null, "A spacious and airy room in Orange Dwellings.", 38, true, true, false, 4885m, "Room 102-38", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8870) },
                    { 125, 4, new DateTime(2024, 10, 10, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8874), null, "A cozy and quiet room in Orange Dwellings.", 38, true, true, false, 6689m, "Room 103-38", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8875) },
                    { 135, 2, new DateTime(2024, 3, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8992), null, "A clean and minimalist room in Green Dwellings.", 41, true, true, false, 10982m, "Room 100-41", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8992) },
                    { 136, 1, new DateTime(2024, 11, 30, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8996), null, "A modern and stylish room in Green Dwellings.", 41, true, true, false, 11512m, "Room 101-41", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(8997) },
                    { 137, 4, new DateTime(2025, 2, 22, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9001), null, "A comfortable and well-lit room in Green Dwellings.", 41, true, true, false, 12348m, "Room 102-41", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9001) },
                    { 138, 2, new DateTime(2024, 6, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9005), null, "A bright and cheerful room in Green Dwellings.", 41, true, true, false, 9764m, "Room 103-41", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9006) },
                    { 139, 2, new DateTime(2024, 10, 19, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9010), null, "A comfortable and well-lit room in Green Dwellings.", 41, true, true, false, 13928m, "Room 104-41", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9011) },
                    { 140, 1, new DateTime(2024, 9, 26, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9035), null, "A charming and homey room in Red Dormitory.", 42, true, true, false, 10680m, "Room 100-42", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9035) },
                    { 141, 1, new DateTime(2024, 5, 10, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9039), null, "A fully furnished room in Red Dormitory.", 42, true, true, false, 8613m, "Room 101-42", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9040) },
                    { 142, 4, new DateTime(2024, 7, 20, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9044), null, "A comfortable and well-lit room in Red Dormitory.", 42, true, true, false, 14381m, "Room 102-42", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9045) },
                    { 143, 4, new DateTime(2024, 12, 23, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9073), null, "A bright and cheerful room in Superior Suites.", 43, true, false, false, 5465m, "Room 100-43", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9074) },
                    { 144, 2, new DateTime(2024, 6, 27, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9078), null, "A charming and homey room in Superior Suites.", 43, true, true, false, 7785m, "Room 101-43", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9078) },
                    { 151, 3, new DateTime(2024, 7, 30, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9177), null, "A modern and stylish room in Green Dormitory.", 46, true, false, false, 9432m, "Room 100-46", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9178) },
                    { 152, 3, new DateTime(2024, 10, 12, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9182), null, "A newly renovated room in Green Dormitory.", 46, true, false, false, 10235m, "Room 101-46", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9183) },
                    { 153, 1, new DateTime(2024, 3, 15, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9187), null, "A cozy and quiet room in Green Dormitory.", 46, true, true, false, 11394m, "Room 102-46", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9187) },
                    { 154, 3, new DateTime(2025, 1, 5, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9217), null, "A cozy and quiet room in Green Dwellings.", 47, true, true, false, 18271m, "Room 100-47", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9218) },
                    { 155, 4, new DateTime(2024, 4, 13, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9222), null, "A clean and minimalist room in Green Dwellings.", 47, true, true, false, 20588m, "Room 101-47", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9223) },
                    { 165, 3, new DateTime(2025, 2, 1, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9361), null, "A cozy and quiet room in Red Lodgings.", 51, true, true, false, 9233m, "Room 100-51", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9362) },
                    { 166, 2, new DateTime(2024, 9, 11, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9366), null, "A bright and cheerful room in Red Lodgings.", 51, true, true, false, 12310m, "Room 101-51", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9366) },
                    { 218, 3, new DateTime(2024, 10, 5, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9974), null, "A newly renovated room in Red Quarters.", 66, true, false, false, 23618m, "Room 100-66", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9975) },
                    { 219, 4, new DateTime(2024, 12, 31, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9979), null, "A fully furnished room in Red Quarters.", 66, true, false, false, 16469m, "Room 101-66", new DateTime(2025, 3, 6, 15, 41, 6, 602, DateTimeKind.Local).AddTicks(9980) },
                    { 246, 2, new DateTime(2024, 9, 13, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(270), null, "A fully furnished room in Superior Dwellings.", 73, true, false, false, 7087m, "Room 100-73", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(271) },
                    { 247, 3, new DateTime(2024, 9, 12, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(275), null, "A bright and cheerful room in Superior Dwellings.", 73, true, true, false, 11188m, "Room 101-73", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(276) },
                    { 248, 3, new DateTime(2024, 6, 24, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(279), null, "A cozy and quiet room in Superior Dwellings.", 73, true, true, false, 11812m, "Room 102-73", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(280) },
                    { 249, 1, new DateTime(2024, 9, 10, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(284), null, "A clean and minimalist room in Superior Dwellings.", 73, true, true, false, 10897m, "Room 103-73", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(285) },
                    { 258, 4, new DateTime(2024, 7, 12, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(405), null, "A cozy and quiet room in Crystal Suites.", 76, true, true, false, 25279m, "Room 100-76", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(406) },
                    { 259, 1, new DateTime(2024, 9, 28, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(409), null, "A modern and stylish room in Crystal Suites.", 76, true, true, false, 16693m, "Room 101-76", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(410) },
                    { 260, 1, new DateTime(2025, 1, 26, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(414), null, "A charming and homey room in Crystal Suites.", 76, true, true, false, 24834m, "Room 102-76", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(415) },
                    { 261, 1, new DateTime(2024, 9, 25, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(419), null, "A newly renovated room in Crystal Suites.", 76, true, true, false, 23669m, "Room 103-76", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(420) },
                    { 280, 1, new DateTime(2024, 11, 8, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(621), null, "A fully furnished room in Elite Place.", 81, true, true, false, 6330m, "Room 100-81", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(621) },
                    { 281, 4, new DateTime(2024, 7, 11, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(625), null, "A charming and homey room in Elite Place.", 81, true, true, false, 5381m, "Room 101-81", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(626) },
                    { 282, 1, new DateTime(2024, 9, 16, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(630), null, "A modern and stylish room in Elite Place.", 81, true, true, false, 6368m, "Room 102-81", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(631) },
                    { 283, 3, new DateTime(2025, 2, 7, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(634), null, "A newly renovated room in Elite Place.", 81, true, true, false, 11270m, "Room 103-81", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(635) },
                    { 284, 4, new DateTime(2025, 1, 29, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(639), null, "A clean and minimalist room in Elite Place.", 81, true, true, false, 5604m, "Room 104-81", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(639) },
                    { 302, 3, new DateTime(2025, 3, 5, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(953), null, "A cozy and quiet room in Purple Lodgings.", 87, true, true, false, 15691m, "Room 100-87", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(954) },
                    { 303, 2, new DateTime(2025, 1, 13, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(958), null, "A cozy and quiet room in Purple Lodgings.", 87, true, true, false, 23292m, "Room 101-87", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(959) },
                    { 304, 2, new DateTime(2025, 2, 16, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(984), null, "A modern and stylish room in Elegant Hall.", 88, true, true, false, 19908m, "Room 100-88", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(985) },
                    { 305, 3, new DateTime(2024, 5, 15, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(989), null, "A newly renovated room in Elegant Hall.", 88, true, true, false, 14790m, "Room 101-88", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(990) },
                    { 306, 1, new DateTime(2024, 3, 27, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(994), null, "A modern and stylish room in Elegant Hall.", 88, true, true, false, 20230m, "Room 102-88", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(995) },
                    { 307, 2, new DateTime(2024, 11, 1, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1025), null, "A cozy and quiet room in Silver Quarters.", 89, true, true, false, 19495m, "Room 100-89", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1026) },
                    { 308, 4, new DateTime(2025, 2, 18, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1030), null, "A cozy and quiet room in Silver Quarters.", 89, true, true, false, 22494m, "Room 101-89", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1030) },
                    { 309, 4, new DateTime(2024, 12, 26, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1035), null, "A clean and minimalist room in Silver Quarters.", 89, true, true, false, 23637m, "Room 102-89", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1035) },
                    { 310, 1, new DateTime(2025, 2, 16, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1039), null, "A cozy and quiet room in Silver Quarters.", 89, true, false, false, 18127m, "Room 103-89", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1040) },
                    { 311, 3, new DateTime(2024, 11, 26, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1065), null, "A spacious and airy room in Green Hall.", 90, true, true, false, 10394m, "Room 100-90", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1066) },
                    { 312, 2, new DateTime(2025, 3, 1, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1070), null, "A bright and cheerful room in Green Hall.", 90, true, true, false, 7764m, "Room 101-90", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1071) },
                    { 313, 2, new DateTime(2024, 12, 21, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1074), null, "A modern and stylish room in Green Hall.", 90, true, true, false, 9690m, "Room 102-90", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1075) },
                    { 321, 3, new DateTime(2024, 11, 1, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1189), null, "A clean and minimalist room in Red House.", 93, true, true, false, 9094m, "Room 100-93", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1190) },
                    { 322, 3, new DateTime(2025, 2, 10, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1193), null, "A comfortable and well-lit room in Red House.", 93, true, true, false, 6359m, "Room 101-93", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1194) },
                    { 323, 3, new DateTime(2024, 11, 28, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1198), null, "A functional and practical room in Red House.", 93, true, true, false, 6622m, "Room 102-93", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1198) },
                    { 324, 2, new DateTime(2025, 1, 25, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1202), null, "A spacious and airy room in Red House.", 93, true, true, false, 8685m, "Room 103-93", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1203) },
                    { 325, 4, new DateTime(2024, 9, 17, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1229), null, "A cozy and quiet room in Elite Place.", 94, true, true, false, 16624m, "Room 100-94", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1230) },
                    { 326, 4, new DateTime(2024, 7, 15, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1234), null, "A newly renovated room in Elite Place.", 94, true, false, false, 15342m, "Room 101-94", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1234) },
                    { 332, 4, new DateTime(2025, 2, 12, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1329), null, "A modern and stylish room in Premium Suites.", 97, true, true, false, 11879m, "Room 100-97", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1330) },
                    { 333, 2, new DateTime(2024, 12, 9, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1334), null, "A fully furnished room in Premium Suites.", 97, true, true, false, 8584m, "Room 101-97", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1335) },
                    { 339, 4, new DateTime(2024, 5, 27, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1408), null, "A functional and practical room in Central Lodgings.", 99, true, true, false, 25765m, "Room 100-99", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1408) },
                    { 340, 2, new DateTime(2024, 3, 12, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1412), null, "A fully furnished room in Central Lodgings.", 99, true, true, false, 33274m, "Room 101-99", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1413) },
                    { 341, 1, new DateTime(2024, 8, 20, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1417), null, "A charming and homey room in Central Lodgings.", 99, true, true, false, 26220m, "Room 102-99", new DateTime(2025, 3, 6, 15, 41, 6, 603, DateTimeKind.Local).AddTicks(1418) }
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
                name: "IX_DormReviews_DormId1",
                table: "DormReviews",
                column: "DormId1");

            migrationBuilder.CreateIndex(
                name: "IX_DormReviews_TenantId",
                table: "DormReviews",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_Dorms_CategoryId",
                table: "Dorms",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Dorms_OwnerId",
                table: "Dorms",
                column: "OwnerId");

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
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Dorms");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
