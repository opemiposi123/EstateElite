using EstateElite.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Entities
{
	public  class Application : BaseEntity
	{
		public Guid UnitId { get; set; } // Foreign Key to Unit
		public Guid ApplicantId { get; set; } // Foreign Key to User
		public User Applicant { get; set; }
		public DateTime ApplicationDate { get; set; }
		public ApplicationStatus ApplicationStatus { get; set; } // Pending, Approved, Rejected
		public string Comments { get; set; }
	}
}
