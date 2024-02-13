namespace OddsOracle.Storage.Entities;

public class Tip: BaseEntity
{
    public string? Sport { get; set; }
    public string? Match { get; set; }
    public string? Prediction { get; set; }
    public string? TotalOdds { get; set; }
    public decimal Price { get; set; }
    public bool IsFree { get; set; }
    public string? IsRefundable { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}