namespace Finance.Models;

public class ExpensiveType: BaseEntity
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public List<Expenses> Expenses { get; set; } = [];
}
