namespace Matrix.EveM.Domain.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTimeOffset AddDate { get; set; }
    public DateTimeOffset? UpdateDate { get; set; }
    
    // TODO: add properties to track adduser and update user after implementing authentication
}
