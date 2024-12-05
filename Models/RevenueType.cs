namespace Finance.Models;

public class RevenueType : BaseEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public List<Revenue> Revenues { get; set; } = [];
}
