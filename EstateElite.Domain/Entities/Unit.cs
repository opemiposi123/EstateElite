using EstateElite.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Entities
{
	public class Unit : BaseEntity
	{
		public Guid PropertyId { get; set; } 
		public string UnitNumber { get; set; }
		public string Floor { get; set; }
		public int NumberOfBedrooms { get; set; }
		public int NumberOfBathrooms { get; set; }
		public double SquareFeet { get; set; }
		public decimal RentAmount { get; set; }
		public UnitStatus Status { get; set; } 
		public DateTime DateAvailable { get; set; }
	}
}
