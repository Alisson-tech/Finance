namespace Finance.Models;

public class Expenses
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public ExpenseType Type { get; set; }
    public List<ExpensesValues> ExpensesValues { get; set; } = [];
}

public enum ExpenseType
{
    Food,
    Rent,
    Utilities,
    Other
}