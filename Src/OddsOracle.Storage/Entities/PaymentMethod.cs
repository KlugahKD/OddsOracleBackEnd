namespace OddsOracle.Storage.Entities;

public class PaymentMethod: BaseEntity
{
    public string? Name { get; set; }
    public string? Details { get; set; }
    public string? Type { get; set; }
    public string? UserId { get; set; }
    public User? User { get; set; }
    public string? TransactionId { get; set; }
    public string? SubscriptionId { get; set; }
    public string? TipsId { get; set; }
    public Tip? Tips { get; set; }
    public string? PaymentStatus { get; set; }
}