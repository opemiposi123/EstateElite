using EstateElite.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Entities
{
	public class MaintenanceRequest : BaseEntity
	{
		public Guid UnitID { get; set; } // Foreign Key to Unit
		public Guid TenantId { get; set; } // Foreign Key to User
		public string Description { get; set; }
		public DateTime RequestDate { get; set; }
		public MaintenanceStatus Status { get; set; } // Open, InProgress, Closed
		public MaintenancePriority Priority { get; set; } // Low, Medium, High
		public int AssignedTo { get; set; } // Foreign Key to User (PropertyManager)
		public User User { get; set; } // Foreign Key to User (PropertyManager)
	}
}
