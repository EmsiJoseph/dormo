using Dormo.Server.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Data.Seeders;

public static class UserSeeder
{
    public static (List<string> OwnerIds, List<string> TenantIds) Seed(ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<ApplicationUser>();
        var ownerIds = new List<string>();
        var tenantIds = new List<string>();
        var users = new List<ApplicationUser>();
        var userRoles = new List<IdentityUserRole<string>>();

        // Owner 1 - Property Management Company
        var owner1Id = "8e445865-a24d-4543-a6c6-9443d048cdb9";
        var owner1 = new ApplicationUser
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
        userRoles.Add(new IdentityUserRole<string> { UserId = owner1Id, RoleId = "2" });

        // Owner 2 - Individual Owner
        var owner2Id = "8e445865-a24d-4543-a6c6-9443d048cdb8";
        var owner2 = new ApplicationUser
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
        userRoles.Add(new IdentityUserRole<string> { UserId = owner2Id, RoleId = "2" });

        // Owner 3 - Real Estate Developer
        var owner3Id = "8e445865-a24d-4543-a6c6-9443d048cdb7";
        var owner3 = new ApplicationUser
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
        userRoles.Add(new IdentityUserRole<string> { UserId = owner3Id, RoleId = "2" });

        // Owner 4 - Small Property Owner
        var owner4Id = "8e445865-a24d-4543-a6c6-9443d048cdb6";
        var owner4 = new ApplicationUser
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
        userRoles.Add(new IdentityUserRole<string> { UserId = owner4Id, RoleId = "2" });

        // Owner 5 - University Housing Department
        var owner5Id = "8e445865-a24d-4543-a6c6-9443d048cdb5";
        var owner5 = new ApplicationUser
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
        userRoles.Add(new IdentityUserRole<string> { UserId = owner5Id, RoleId = "2" });

        // Admin User
        var adminId = "8e445865-a24d-4543-a6c6-9443d048cdb0";
        var admin = new ApplicationUser
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
        userRoles.Add(new IdentityUserRole<string> { UserId = adminId, RoleId = "1" });

        // Tenant 1
        var tenant1Id = "tenant-001";
        var tenant1 = new ApplicationUser
        {
            Id = tenant1Id,
            UserName = "john.doe@example.com",
            NormalizedUserName = "JOHN.DOE@EXAMPLE.COM",
            Email = "john.doe@example.com",
            NormalizedEmail = "JOHN.DOE@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "John",
            LastName = "Doe",
            PhoneNumber = "+639221234567",
            PhoneNumberConfirmed = true,
        };
        tenant1.PasswordHash = hasher.HashPassword(tenant1, "Tenant123*");
        users.Add(tenant1);
        tenantIds.Add(tenant1Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = tenant1Id, RoleId = "4" });

        // Tenant 2
        var tenant2Id = "tenant-002";
        var tenant2 = new ApplicationUser
        {
            Id = tenant2Id,
            UserName = "jane.smith@example.com",
            NormalizedUserName = "JANE.SMITH@EXAMPLE.COM",
            Email = "jane.smith@example.com",
            NormalizedEmail = "JANE.SMITH@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Jane",
            LastName = "Smith",
            PhoneNumber = "+639231234567",
            PhoneNumberConfirmed = true,
        };
        tenant2.PasswordHash = hasher.HashPassword(tenant2, "Tenant123*");
        users.Add(tenant2);
        tenantIds.Add(tenant2Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = tenant2Id, RoleId = "4" });

        // Tenant 3
        var tenant3Id = "tenant-003";
        var tenant3 = new ApplicationUser
        {
            Id = tenant3Id,
            UserName = "peter.parker@example.com",
            NormalizedUserName = "PETER.PARKER@EXAMPLE.COM",
            Email = "peter.parker@example.com",
            NormalizedEmail = "PETER.PARKER@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Peter",
            LastName = "Parker",
            PhoneNumber = "+639241234567",
            PhoneNumberConfirmed = true,
        };
        tenant3.PasswordHash = hasher.HashPassword(tenant3, "Tenant123*");
        users.Add(tenant3);
        tenantIds.Add(tenant3Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = tenant3Id, RoleId = "4" });

        // Tenant 4
        var tenant4Id = "tenant-004";
        var tenant4 = new ApplicationUser
        {
            Id = tenant4Id,
            UserName = "mary.jane@example.com",
            NormalizedUserName = "MARY.JANE@EXAMPLE.COM",
            Email = "mary.jane@example.com",
            NormalizedEmail = "MARY.JANE@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Mary",
            LastName = "Jane",
            PhoneNumber = "+639251234567",
            PhoneNumberConfirmed = true,
        };
        tenant4.PasswordHash = hasher.HashPassword(tenant4, "Tenant123*");
        users.Add(tenant4);
        tenantIds.Add(tenant4Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = tenant4Id, RoleId = "4" });

        // Tenant 5
        var tenant5Id = "tenant-005";
        var tenant5 = new ApplicationUser
        {
            Id = tenant5Id,
            UserName = "bruce.wayne@example.com",
            NormalizedUserName = "BRUCE.WAYNE@EXAMPLE.COM",
            Email = "bruce.wayne@example.com",
            NormalizedEmail = "BRUCE.WAYNE@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Bruce",
            LastName = "Wayne",
            PhoneNumber = "+639261234567",
            PhoneNumberConfirmed = true,
        };
        tenant5.PasswordHash = hasher.HashPassword(tenant5, "Tenant123*");
        users.Add(tenant5);
        tenantIds.Add(tenant5Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = tenant5Id, RoleId = "4" });

        // Tenant 6
        var tenant6Id = "tenant-006";
        var tenant6 = new ApplicationUser
        {
            Id = tenant6Id,
            UserName = "clark.kent@example.com",
            NormalizedUserName = "CLARK.KENT@EXAMPLE.COM",
            Email = "clark.kent@example.com",
            NormalizedEmail = "CLARK.KENT@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Clark",
            LastName = "Kent",
            PhoneNumber = "+639271234567",
            PhoneNumberConfirmed = true,
        };
        tenant6.PasswordHash = hasher.HashPassword(tenant6, "Tenant123*");
        users.Add(tenant6);
        tenantIds.Add(tenant6Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = tenant6Id, RoleId = "4" });

        // Tenant 7
        var tenant7Id = "tenant-007";
        var tenant7 = new ApplicationUser
        {
            Id = tenant7Id,
            UserName = "diana.prince@example.com",
            NormalizedUserName = "DIANA.PRINCE@EXAMPLE.COM",
            Email = "diana.prince@example.com",
            NormalizedEmail = "DIANA.PRINCE@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Diana",
            LastName = "Prince",
            PhoneNumber = "+639281234567",
            PhoneNumberConfirmed = true,
        };
        tenant7.PasswordHash = hasher.HashPassword(tenant7, "Tenant123*");
        users.Add(tenant7);
        tenantIds.Add(tenant7Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = tenant7Id, RoleId = "4" });

        // Tenant 8
        var tenant8Id = "tenant-008";
        var tenant8 = new ApplicationUser
        {
            Id = tenant8Id,
            UserName = "tony.stark@example.com",
            NormalizedUserName = "TONY.STARK@EXAMPLE.COM",
            Email = "tony.stark@example.com",
            NormalizedEmail = "TONY.STARK@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Tony",
            LastName = "Stark",
            PhoneNumber = "+639291234567",
            PhoneNumberConfirmed = true,
        };
        tenant8.PasswordHash = hasher.HashPassword(tenant8, "Tenant123*");
        users.Add(tenant8);
        tenantIds.Add(tenant8Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = tenant8Id, RoleId = "4" });

        // Tenant 9
        var tenant9Id = "tenant-009";
        var tenant9 = new ApplicationUser
        {
            Id = tenant9Id,
            UserName = "steve.rogers@example.com",
            NormalizedUserName = "STEVE.ROGERS@EXAMPLE.COM",
            Email = "steve.rogers@example.com",
            NormalizedEmail = "STEVE.ROGERS@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Steve",
            LastName = "Rogers",
            PhoneNumber = "+639301234567",
            PhoneNumberConfirmed = true,
        };
        tenant9.PasswordHash = hasher.HashPassword(tenant9, "Tenant123*");
        users.Add(tenant9);
        tenantIds.Add(tenant9Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = tenant9Id, RoleId = "4" });

        // Tenant 10
        var tenant10Id = "tenant-010";
        var tenant10 = new ApplicationUser
        {
            Id = tenant10Id,
            UserName = "natasha.romanoff@example.com",
            NormalizedUserName = "NATASHA.ROMANOFF@EXAMPLE.COM",
            Email = "natasha.romanoff@example.com",
            NormalizedEmail = "NATASHA.ROMANOFF@EXAMPLE.COM",
            EmailConfirmed = true,
            FirstName = "Natasha",
            LastName = "Romanoff",
            PhoneNumber = "+639311234567",
            PhoneNumberConfirmed = true,
        };
        tenant10.PasswordHash = hasher.HashPassword(tenant10, "Tenant123*");
        users.Add(tenant10);
        tenantIds.Add(tenant10Id);
        userRoles.Add(new IdentityUserRole<string> { UserId = tenant10Id, RoleId = "4" });

        modelBuilder.Entity<ApplicationUser>().HasData(users);
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

        return (ownerIds, tenantIds);
    }
}