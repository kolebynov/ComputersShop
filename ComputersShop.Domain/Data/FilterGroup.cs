using ComputersShop.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputersShop.Domain.Data
{
	public class FilterGroup
	{
		public EnumValue<LogicalOperation> LogicalOperation { get; }

		public IReadOnlyList<ComponentFilter> InnerFilters { get; }
	}
}
