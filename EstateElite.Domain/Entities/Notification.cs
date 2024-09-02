using EstateElite.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Entities
{
	public class Notification : BaseEntity
	{
		public Guid UserId { get; set; } 
		public string Message { get; set; }
		public NotificationType NotificationType { get; set; } 
		public DateTime DateSent { get; set; }
		public string Status { get; set; }
		public User User { get; set; }
	}
}
