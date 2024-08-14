using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Entities
{
	public interface IAuditBase
	{
		public string CreatedBy { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime DateCreated { get; set; }
		public DateTime? LastModified { get; set; }
	}
}
