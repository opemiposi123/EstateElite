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
		public Guid UnitID { get; set; } 
		public Guid TenantId { get; set; } 
		public string Description { get; set; }
		public DateTime RequestDate { get; set; }
		public MaintenanceStatus Status { get; set; } 
		public MaintenancePriority Priority { get; set; } 
		public int AssignedTo { get; set; } 
		public User User { get; set; } 
	}
}
