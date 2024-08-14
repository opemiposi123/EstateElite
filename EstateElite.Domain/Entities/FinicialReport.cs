using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Entities
{
	public class FinicialReport : BaseEntity
	{
		public int ReportID { get; set; }
		public int PropertyID { get; set; } // Foreign Key to Property
		public DateTime ReportDate { get; set; }
		public decimal TotalIncome { get; set; }
		public decimal TotalExpenses { get; set; }
		public decimal ProfitLoss { get; set; }
	}
}
