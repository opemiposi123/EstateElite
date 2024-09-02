namespace EstateElite.Persistence.Implementation.Repository;

public interface ISoftDeletable
{
    public bool IsDeleted { get; set; }
}