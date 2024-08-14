using EstateElite.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata;

namespace EstateElite.Domain.Entities
{
	public class User : IdentityUser 
	{ 
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; } 
		public string PhoneNumber { get; set; }
		public UserRole Role { get; set; }
		public string Address { get; set; }
		public Guid Id { get; set; }
		public bool IsDeleted { get; set; }
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime? LastModified { get; set; }

		// Navigation properties
		public ICollection<Property> PropertiesOwned { get; set; } = new HashSet<Property>();
		public ICollection<MaintenanceRequest> AssignedMaintenanceRequests { get; set; } = new HashSet<MaintenanceRequest>();
		public ICollection<Application> Applications { get; set; } = new HashSet<Application>();
		public ICollection<Document> Documents { get; set; } = new HashSet<Document>();
		public ICollection<Lease> Leases { get; set; } = new HashSet<Lease>();
		public ICollection<RentPayment> RentPayments { get; set; } = new HashSet<RentPayment>();
		public ICollection<Notification> Notifications { get; set; } = new HashSet<Notification>();

	}
}
