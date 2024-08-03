namespace Finance.Models;

public class Revenue
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public RevenueType Type { get; set; }
    public List<RevenueValues> RevenueValues { get; set; } = [];
}

public enum RevenueType
{
    Salary,
    MealVoucher,
    Gift,
    Other
}
