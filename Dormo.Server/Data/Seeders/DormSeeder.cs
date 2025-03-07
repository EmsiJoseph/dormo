using Dormo.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Dormo.Server.Data.Seeders;

public static class DormSeeder
{
    public static void Seed(ModelBuilder modelBuilder, List<string> ownerIds, List<string> tenantIds)
    {
        var random = new Random(123);
        var dorms = new List<Dorm>();
        var dormTags = new List<DormTag>();
        var rooms = new List<Room>();
        var dormImages = new List<DormImage>();
        var dormReviews = new List<DormReview>();

        string[] cities = { "Manila", "Quezon City", "Makati", "Pasig", "Taguig", "Parañaque", "Pasay", "Mandaluyong" };
        string[] barangays =
        {
            "San Antonio", "Poblacion", "Guadalupe Nuevo", "San Lorenzo", "San Isidro", "Pinagkaisahan", "Palanan",
            "Pio del Pilar", "Valenzuela", "Singkamas"
        };
        string[] streets =
        {
            "Rizal Avenue", "EDSA", "Ortigas Avenue", "Shaw Boulevard", "Taft Avenue", "Buendia Avenue", "Ayala Avenue",
            "Marcos Highway", "Commonwealth Avenue", "Katipunan Avenue"
        };
        string[] dormPrefixes =
        {
            "Green", "Blue", "Red", "Orange", "Purple", "Golden", "Silver", "Crystal", "Royal", "Grand", "Premium",
            "Elite", "Superior", "Elegant", "Central"
        };
        string[] dormTypes =
        {
            "Dormitory", "Residences", "Hall", "Place", "House", "Suites", "Living Spaces", "Quarters", "Lodgings",
            "Dwellings"
        };
        string[] dormFeatures =
        {
            "Cozy", "Spacious", "Modern", "Stylish", "Contemporary", "Classic", "Luxurious", "Comfortable",
            "Student-friendly", "Professional"
        };
        string[] descriptions =
        {
            "A comfortable living space designed for students and young professionals.",
            "Modern accommodations with convenient access to universities and business districts.",
            "Premium living experience with top-notch amenities and security features.",
            "Affordable lodgings with essential amenities for a comfortable stay.",
            "Luxurious residences offering the best in comfort and convenience.",
            "Student-friendly dormitory with study areas and high-speed internet.",
            "Contemporary living spaces designed for the modern lifestyle.",
            "Secure and well-maintained accommodations for peace of mind.",
            "Budget-friendly options without compromising on quality and comfort.",
            "Strategically located residences for easy access to key city establishments."
        };
        string[] nearbyLandmarks =
        {
            "Near University of the Philippines", "Close to Ateneo de Manila University",
            "Walking distance to De La Salle University", "Near University of Santo Tomas",
            "Close to University of the East", "Near Far Eastern University",
            "Walking distance to Manila Central University", "Near AMA University",
            "Close to Polytechnic University of the Philippines", "Near Technological University of the Philippines"
        };
        int[] imageWidths = { 800, 1024, 1200 };
        int[] imageHeights = { 600, 768, 900 };
        int[] validCategoryIds = { 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 17, 18, 19, 20, 21 };

        string[] reviewTexts =
        {
            "Great place to stay, very clean and close to campus!",
            "The staff is friendly, but the Wi-Fi could be faster.",
            "Loved the quiet environment, perfect for studying.",
            "Rooms are spacious, but parking is limited.",
            "Affordable and convenient, highly recommend!",
            "The common room is a nice touch, but it gets noisy sometimes.",
            "Excellent security and amenities, worth the price.",
            "Good location, but the kitchen needs more equipment.",
            "Comfortable stay, the air conditioning was a lifesaver.",
            "Friendly neighbors and a cozy vibe, I’d stay again."
        };

        int roomId = 1;
        int imageId = 1;
        int reviewId = 1;

        for (int i = 1; i <= 100; i++)
        {
            string dormName =
                $"{dormPrefixes[random.Next(dormPrefixes.Length)]} {dormTypes[random.Next(dormTypes.Length)]}";
            string city = cities[random.Next(cities.Length)];
            string barangay = barangays[random.Next(barangays.Length)];
            string street = streets[random.Next(streets.Length)];
            int streetNumber = random.Next(1, 999);
            string fullAddress = $"{streetNumber} {street}, {barangay}, {city}, Metro Manila, Philippines";
            decimal rating = Math.Round((decimal)(3.0 + random.NextDouble() * 2.0), 1);
            decimal latitude = 14.5995m + (decimal)(random.NextDouble() - 0.5);
            decimal longitude = 120.9842m + (decimal)(random.NextDouble() - 0.5);
            int categoryId = validCategoryIds[random.Next(validCategoryIds.Length)];
            string ownerId = ownerIds[random.Next(ownerIds.Count)];
            decimal securityDeposit = Math.Round(1000 + (random.Next(-1000, 1000) / 100m) * 100, 0);

            var dorm = new Dorm
            {
                Id = i,
                Name = dormName,
                Description =
                    $"{dormFeatures[random.Next(dormFeatures.Length)]} {descriptions[random.Next(descriptions.Length)]} {nearbyLandmarks[random.Next(nearbyLandmarks.Length)]}",
                Address = fullAddress,
                Rating = rating,
                IsVerified = random.Next(0, 10) >= 2,
                OwnerId = ownerId,
                SecurityDeposit = securityDeposit,
                CategoryId = categoryId,
                Latitude = latitude,
                Longitude = longitude,
                IsAvailable = random.Next(0, 10) <= 7,
                CreatedAt = DateTime.Now.AddDays(-random.Next(1, 365)),
                UpdatedAt = DateTime.Now
            };
            dorms.Add(dorm);

            int roomCount = random.Next(2, 6);
            for (int j = 0; j < roomCount; j++)
            {
                decimal basePrice;
                switch (categoryId)
                {
                    case 1:
                    case 4: basePrice = random.Next(5000, 12000); break;
                    case 2:
                    case 5: basePrice = random.Next(8000, 15000); break;
                    case 6: basePrice = random.Next(15000, 25000); break;
                    case 7: basePrice = random.Next(20000, 35000); break;
                    default: basePrice = random.Next(5000, 15000); break;
                }

                decimal price = Math.Round(basePrice + (random.Next(-1000, 1000) / 100m) * 100, 0);

                var room = new Room
                {
                    Id = roomId++,
                    RoomNumber = $"Room {100 + j}-{i}",
                    Description = $"A {RoomDescriptions[random.Next(RoomDescriptions.Length)]} room in {dormName}.",
                    DormId = i,
                    Capacity = random.Next(1, 5),
                    PricePerMonth = price,
                    IsAvailable = random.Next(0, 10) <= 8,
                    CreatedAt = DateTime.Now.AddDays(-random.Next(1, 365)),
                    UpdatedAt = DateTime.Now
                };
                rooms.Add(room);
            }

            int amenityCount = random.Next(2, 6);
            var assignedAmenities = new HashSet<int>();
            for (int j = 0; j < amenityCount; j++)
            {
                int amenityId = random.Next(9, 17);
                if (assignedAmenities.Add(amenityId))
                {
                    dormTags.Add(new DormTag { DormId = i, TagId = amenityId });
                }
            }

            int tagCount = random.Next(1, 4);
            var assignedTags = new HashSet<int>();
            for (int j = 0; j < tagCount; j++)
            {
                int tagId = random.Next(1, 9);
                if (assignedTags.Add(tagId))
                {
                    dormTags.Add(new DormTag { DormId = i, TagId = tagId });
                }
            }

            int imageCount = random.Next(3, 7);
            for (int j = 0; j < imageCount; j++)
            {
                int width = imageWidths[random.Next(imageWidths.Length)];
                int height = imageHeights[random.Next(imageHeights.Length)];
                int randomNumber = i * 100 + j + random.Next(1000);
                string imageUrl = $"https://loremflickr.com/{width}/{height}/house/all?lock={randomNumber}";
                string caption = j switch
                {
                    0 => "Main View",
                    1 => "Exterior",
                    2 => "Interior",
                    3 => "Bedroom",
                    4 => "Bathroom",
                    _ => "Additional View"
                };

                dormImages.Add(new DormImage
                {
                    Id = imageId++,
                    DormId = i,
                    Url = imageUrl,
                    Caption = caption,
                    IsPrimary = j == 0
                });
            }

            if (random.NextDouble() < 0.3 && reviewId <= 30)
            {
                var review = new DormReview
                {
                    Id = reviewId++,
                    DormId = i,
                    TenantId = tenantIds[random.Next(tenantIds.Count)],
                    Rating = Math.Round((decimal)(2.5 + random.NextDouble() * 2.5), 1),
                    ReviewText = reviewTexts[random.Next(reviewTexts.Length)],
                    CreatedAt = DateTime.Now.AddDays(-random.Next(1, 90)),
                    UpdatedAt = DateTime.Now
                };
                dormReviews.Add(review);
            }
        }

        foreach (var dorm in dorms.Where(d => d.Id <= 20)) dorm.IsVerified = true;
        foreach (var dorm in dorms.Where(d => d.Id > 20 && d.Id <= 30))
        {
            dorm.IsVerified = true;
            dorm.Rating = Math.Min(5.0m, dorm.Rating + 0.5m);
        }

        modelBuilder.Entity<Dorm>().HasData(dorms);
        modelBuilder.Entity<Room>().HasData(rooms);
        modelBuilder.Entity<DormImage>().HasData(dormImages);
        modelBuilder.Entity<DormTag>()
            .HasData(dormTags.Select((dt, idx) =>
                new { dt.DormId, dt.TagId, Id = idx + 1, IsActive = true, IsDeleted = false }).ToArray());
        modelBuilder.Entity<DormReview>().HasData(dormReviews);
    }

    private static readonly string[] RoomDescriptions =
    {
        "comfortable and well-lit", "cozy and quiet", "spacious and airy", "modern and stylish", "charming and homey",
        "functional and practical", "newly renovated", "fully furnished", "bright and cheerful", "clean and minimalist"
    };
}