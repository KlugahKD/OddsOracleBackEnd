namespace OddsOracle.Storage.Entities;

public class Subscription: BaseEntity
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? SubscriptionType { get; set; }
}