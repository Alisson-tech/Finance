namespace Finance.Models;

public class Revenue : BaseEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required RevenueType Type { get; set; }
    public List<RevenueValues> RevenueValues { get; set; } = [];
}

