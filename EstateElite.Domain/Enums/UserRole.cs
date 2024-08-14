using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateElite.Domain.Enums
{
	public enum UserRole
	{
		PropertyOwner = 1,
		PropertyManager,
		SuperAdmin,
		Tenant,
		NominalUser,
	}
}
