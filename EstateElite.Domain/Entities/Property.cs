namespace EstateElite.Domain.Entities
{
	public class Property : BaseEntity
	{
		public Guid OwnerId { get; set; } // Foreign Key to User
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
		public string Description { get; set; }
		public int NumberOfUnits { get; set; }
		public DateTime DateAdded { get; set; }
	}
}
