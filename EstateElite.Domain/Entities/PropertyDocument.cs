using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EstateElite.Domain.Entities
{
	public  class PropertyDocument : BaseEntity
	{
		public string DocumentName { get; set; }
		public byte[] DocumentContent { get; set; }
		public Guid OwnerId { get; set; } // Foreign Key to User
		public DateTime DateUploaded { get; set; }

		// Navigation properties
		public User Owner { get; set; }
	}
}
