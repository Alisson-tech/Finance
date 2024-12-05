namespace Finance.Models;

public class Expenses : BaseEntity
{
    public Guid Id { get; set; }
    public Guid TypeId { get; set; }
    public required string Name { get; set; }
    public required ExpensiveType Type { get; set; } 
    public List<ExpensesValues> ExpensesValues { get; set; } = [];
}
