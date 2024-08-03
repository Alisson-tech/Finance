namespace Finance.Models;

public abstract class BaseEntity
{
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
    public DateTime? DateDeleted { get; set; }
}
