﻿namespace Finance.Models;

public class ExpensesValues : BaseEntity
{
    public int Id { get; set; }
    public int ExpensesId { get; set; }
    public decimal Value { get; set; }
    public bool Paid { get; set; }
    public required Expenses Expenses { get; set; }
    public DateTime DatePaid { get; set; }
}

