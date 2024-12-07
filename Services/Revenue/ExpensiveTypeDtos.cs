using Finance.Models;

namespace Finance.Service.Revenue;

public class ExpensiveTypeDto
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public List<Expenses> Expenses { get; set; } = [];
}

public class ExpensiveFilterDto
{
    public int? Id { get; set; }
    string Name { get; set; } = string.Empty;
}
