namespace Dormo.Server.Constants;

public static class BusinessRulesConstants
{
    public static class Room
    {
        public const decimal MinPrice = 1000;
        public const decimal MaxPrice = 100000;
        public const int MinCapacity = 1;
        public const int MaxCapacity = 8;
        public const int NumberMaxLength = 10;
    }

    public static class Dorm
    {
        public const int NameMinLength = 3;
        public const int NameMaxLength = 100;
        public const int DescriptionMinLength = 10;
        public const int DescriptionMaxLength = 1000;
        public const int AddressMaxLength = 200;
        public const double MinRating = 0;
        public const double MaxRating = 5;
        public const int MinRooms = 1;
        public const int MaxRooms = 50;
        public const int MinImages = 3;
        public const int MaxImages = 10;
        public const int MaxListingsPerHour = 5;
    }

    public static class Coordinates
    {
        public const double MinLatitude = -90;
        public const double MaxLatitude = 90;
        public const double MinLongitude = -180;
        public const double MaxLongitude = 180;
    }
}