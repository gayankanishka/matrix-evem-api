namespace Matrix.EveM.Domain.Common;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTimeOffset AddDate { get; set; }
    public string AddUserId { get; set; }
    public DateTimeOffset? UpdateDate { get; set; }
    public string? UpdateUserId { get; set; }
}
