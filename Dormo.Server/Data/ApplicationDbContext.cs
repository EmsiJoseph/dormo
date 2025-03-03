using Dormo.Server.Data.Models;
using Dormo.Server.Data.Seeders;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Dormo.Server.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Amenity> Amenities { get; set; }
    public DbSet<Booking> Bookings { get; set; } // Assuming Booking is renamed from DormBooking
    public DbSet<Category> Categories { get; set; }
    public DbSet<Dorm> Dorms { get; set; }
    public DbSet<DormAmenity> DormAmenities { get; set; }
    public DbSet<DormmatePreference> DormmatePreferences { get; set; }
    public DbSet<DormmatePreferenceHabit> DormmatePreferenceHabits { get; set; }
    public DbSet<DormmatePreferenceInterest> DormmatePreferenceInterests { get; set; }
    public DbSet<DormReview> DormReviews { get; set; }
    public DbSet<DormTag> DormTags { get; set; }
    public DbSet<Habit> Habits { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Interest> Interests { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<Visit> Visits { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Dorm -> User (Owner) relationship
        builder.Entity<Dorm>()
            .HasOne(d => d.Owner)
            .WithMany()
            .HasForeignKey(d => d.OwnerId)
            .OnDelete(DeleteBehavior.Restrict);

        // Dorm -> Category relationship
        builder.Entity<Dorm>()
            .HasOne(d => d.Category)
            .WithMany()
            .HasForeignKey(d => d.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        // Room -> Dorm relationship
        builder.Entity<Room>()
            .HasOne(r => r.Dorm)
            .WithMany(d => d.Rooms)
            .HasForeignKey(r => r.DormId)
            .OnDelete(DeleteBehavior.Cascade);

        // Booking -> Room relationship 
        builder.Entity<Booking>()
            .HasOne(b => b.Room)
            .WithMany(r => r.Bookings)
            .HasForeignKey(b => b.RoomId)
            .OnDelete(DeleteBehavior.Restrict);

        // Booking -> User (Tenant) relationship
        builder.Entity<Booking>()
            .HasOne(b => b.Tenant)
            .WithMany()
            .HasForeignKey(b => b.TenantId)
            .OnDelete(DeleteBehavior.Restrict);

        // Visit -> Room relationship 
        builder.Entity<Visit>()
            .HasOne(b => b.Room)
            .WithMany(r => r.Visits)
            .HasForeignKey(b => b.RoomId)
            .OnDelete(DeleteBehavior.Restrict);

        // Visit -> User (Visitor) relationship
        builder.Entity<Visit>()
            .HasOne(b => b.Visitor)
            .WithMany()
            .HasForeignKey(b => b.VisitorId)
            .OnDelete(DeleteBehavior.Restrict);

        // DormReview -> Dorm relationship
        builder.Entity<DormReview>()
            .HasOne(dr => dr.Dorm)
            .WithMany()
            .HasForeignKey(dr => dr.DormId)
            .OnDelete(DeleteBehavior.Cascade);

        // DormReview -> User (Tenant) relationship
        builder.Entity<DormReview>()
            .HasOne(dr => dr.Tenant)
            .WithMany()
            .HasForeignKey(dr => dr.TenantId)
            .OnDelete(DeleteBehavior.Restrict);

        // DormmatePreference -> User relationship
        builder.Entity<DormmatePreference>()
            .HasOne(dp => dp.User)
            .WithOne()
            .HasForeignKey<DormmatePreference>(dp => dp.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // DormmatePreference -> Interests (many-to-many)
        builder.Entity<DormmatePreference>()
            .HasMany(dp => dp.Interests)
            .WithMany(i => i.DormmatePreferences)
            .UsingEntity<DormmatePreferenceInterest>(
                j => j.HasOne(dpi => dpi.Interest)
                    .WithMany()
                    .HasForeignKey(dpi => dpi.InterestId),
                j => j.HasOne(dpi => dpi.Preference)
                    .WithMany()
                    .HasForeignKey(dpi => dpi.PreferenceId)
            );

        // DormmatePreference -> Habits (many-to-many)
        builder.Entity<DormmatePreference>()
            .HasMany(dp => dp.Habits)
            .WithMany(h => h.DormmatePreferences)
            .UsingEntity<DormmatePreferenceHabit>(
                j => j.HasOne(dph => dph.Habit)
                    .WithMany()
                    .HasForeignKey(dph => dph.HabitId),
                j => j.HasOne(dph => dph.Preference)
                    .WithMany()
                    .HasForeignKey(dph => dph.PreferenceId)
            );

        // Category -> ParentCategory (self-referencing)
        builder.Entity<Category>()
            .HasOne(c => c.ParentCategory)
            .WithMany(c => c.ChildCategories)
            .HasForeignKey(c => c.ParentId)
            .OnDelete(DeleteBehavior.Restrict);
        
        // Category -> Dorm relationship
        builder.Entity<Category>()
            .HasMany(c => c.Dorms)
            .WithOne(d => d.Category)
            .HasForeignKey(d => d.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        // Configure many-to-many relationships explicitly for better performance
        
        // Dorm <-> Tag (many-to-many)
        builder.Entity<DormTag>()
            .HasKey(dt => dt.Id);
            
        builder.Entity<DormTag>()
            .HasOne(dt => dt.Dorm)
            .WithMany(d => d.DormTags)
            .HasForeignKey(dt => dt.DormId);
            
        builder.Entity<DormTag>()
            .HasOne(dt => dt.Tag)
            .WithMany(t => t.DormTags)
            .HasForeignKey(dt => dt.TagId);
        
        // Dorm <-> Amenity (many-to-many)
        builder.Entity<DormAmenity>()
            .HasKey(da => da.Id);
            
        builder.Entity<DormAmenity>()
            .HasOne(da => da.Dorm)
            .WithMany(d => d.DormAmenities)
            .HasForeignKey(da => da.DormId);
            
        builder.Entity<DormAmenity>()
            .HasOne(da => da.Amenity)
            .WithMany(a => a.DormAmenities)
            .HasForeignKey(da => da.AmenityId);

        // Seeders
        builder.Seed();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        // Suppress the warning about model changes
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}