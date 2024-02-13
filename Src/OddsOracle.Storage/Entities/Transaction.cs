namespace OddsOracle.Storage.Entities;

public class Transaction: BaseEntity
{
    public string? UserId { get; set; }
    public User? User { get; set; }
    public string? TransactionType { get; set; }
    public string? TransactionStatus { get; set; }
    public decimal Amount { get; set; }
    public string? TipId { get; set; }
    public Tip? Tip { get; set; }
    public string? SubscriptionId { get; set; }
    public Subscription? Subscription { get; set; }
}