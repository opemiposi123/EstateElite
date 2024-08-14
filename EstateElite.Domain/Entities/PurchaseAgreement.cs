namespace EstateElite.Domain.Entities
{
	public  class PurchaseAgreement : BaseEntity
	{
		public Guid PropertyId { get; set; } // Foreign Key to Property
		public Guid BuyerId { get; set; } // Foreign Key to User
		public decimal PurchasePrice { get; set; }
		public DateTime AgreementDate { get; set; }
		public string TermsAndConditions { get; set; } 
		public string TermsAndConditionsDocument { get; set; }
		public string AgreementDocument { get; set; } // Path or URL to the document

		// Navigation properties
		public Property Property { get; set; }
		public User Buyer { get; set; }
	}
}
