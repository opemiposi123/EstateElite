using EstateElite.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Entities
{
	public class RentPayment : BaseEntity
	{
		public Guid PaymentId { get; set; }
		public Guid LeaseId { get; set; } // Foreign Key to Lease
		public DateTime PaymentDate { get; set; }
		public decimal Amount { get; set; }
		public PaymentMethod PaymentMethod { get; set; } 
		public GeneralStatus Status { get; set; } 
	}
}
