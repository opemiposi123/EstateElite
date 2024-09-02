using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Entities
{
	public class RentalAgreement : BaseEntity
	{
		public Guid UnitId { get; set; } 
		public Guid TenantId { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public decimal MonthlyRent { get; set; }
		public decimal SecurityDeposit { get; set; }
		public string TermsAndConditions { get; set; }
		public string AgreementDocument { get; set; } 

		// Navigation properties
		public Unit Unit { get; set; }
		public User Tenant { get; set; }
		public ICollection<RentPayment> RentPayments { get; set; } = new HashSet<RentPayment>();
	}
}
