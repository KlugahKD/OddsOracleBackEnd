namespace OddsOracle.Storage.Entities;

public class User: BaseEntity
{
    public string? Username { get; set; }
    public string? PhoneNumber { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? PasswordSalt { get; set; }
    public string? PasswordHash { get; set; }
    public decimal Balance { get; set; }
    public string? SubscriptionStatus { get; set; }
    public string? SubscriptionType { get; set; }
    public DateTime? SubscriptionStartDate { get; set; }
    public DateTime? SubscriptionEndDate { get; set; }
    public ICollection<UserRole>? UserRoles { get; set; }
}