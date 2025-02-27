namespace Dormo.Server.Data.Requests;

public class UserRegisterRequest
{
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? ConfirmPassword { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PreferredFirstName { get; set; }
    public DateOnly? Dob { get; set; }
    public string? ContactInfo { get; set; }
    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }
    public bool EmailSubscription { get; set; }
}