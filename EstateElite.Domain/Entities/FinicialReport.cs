namespace EstateElite.Domain.Entities
{
	public class FinicialReport : BaseEntity
	{
		public Guid ReportId { get; set; }
		public Guid PropertyId { get; set; } 
		public DateTime ReportDate { get; set; }
		public decimal TotalIncome { get; set; }
		public decimal TotalExpenses { get; set; }
		public decimal ProfitLoss { get; set; }
	}
}
