namespace Finance.Models;

public class RevenueValues
{
    public Guid Id { get; set; }
    public int RevenueId { get; set; }
    public decimal Value { get; set; }
    public bool Received { get; set; }
    public required Revenue Revenue { get; set; }
    public DateTime DateRecept { get; set; }
    public DateTime DateReceived { get; set; }
}
