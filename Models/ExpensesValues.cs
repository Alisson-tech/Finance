namespace Finance.Models;

public class ExpensesValues
{
    public Guid Id { get; set; }
    public int ExpensesId { get; set; }
    public decimal Value { get; set; }
    public bool Paid { get; set; }
    public required Expenses Expenses { get; set; }
    public DateTime DatePaid { get; set; }
    public DateTime DateExpired { get; set; }
}

