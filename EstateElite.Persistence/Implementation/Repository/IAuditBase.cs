namespace EstateElite.Persistence.Implementation.Repository;
public interface IAuditBase
{
	public string CreatedBy { get; set; }
	public string ModifiedBy { get; set; }
	public DateTime DateCreated { get; set; }
	public DateTime? LastModified { get; set; }
}
