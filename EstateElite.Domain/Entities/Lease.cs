using EstateElite.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Entities
{
	public class Lease : BaseEntity
	{
		public Guid UnitId { get; set; } 
		public Guid TenantId { get; set; } 
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public decimal MonthlyRent { get; set; }
		public decimal SecurityDeposit { get; set; }
		public LeaseStatus LeaseStatus { get; set; } 
		public Unit Unit { get; set; } 
		public User Tenant { get; set; } 
	}
}
