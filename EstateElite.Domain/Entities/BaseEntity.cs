namespace EstateElite.Domain.Entities
{
	public class BaseEntity : IAuditBase, ISoftDeletable
	{
		public Guid Id { get; set; }
		public bool IsDeleted { get; set; }
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime? LastModified { get; set; }
	}
}
