namespace EstateElite.Domain.Entities
{
	public  class PurchaseAgreement : BaseEntity
	{
		public Guid PropertyId { get; set; }
		public Guid BuyerId { get; set; } 
		public decimal PurchasePrice { get; set; }
		public DateTime AgreementDate { get; set; }
		public string TermsAndConditions { get; set; } 
		public string TermsAndConditionsDocument { get; set; }
		public string AgreementDocument { get; set; } 

		public Property Property { get; set; }
		public User Buyer { get; set; }
	}
}
