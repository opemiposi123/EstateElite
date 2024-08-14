using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Entities
{
	public class RentPayment : BaseEntity
	{
		public int PaymentID { get; set; }
		public int LeaseID { get; set; } // Foreign Key to Lease
		public DateTime PaymentDate { get; set; }
		public decimal Amount { get; set; }
		public string PaymentMethod { get; set; } // CreditCard, BankTransfer, Cash
		public string Status { get; set; } // Pending, Completed, Failed

	}
}
