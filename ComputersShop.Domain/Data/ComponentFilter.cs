using System;
using System.Collections.Generic;
using ComputersShop.Domain.Models;
using ComputersShop.Shared;

namespace ComputersShop.Domain.Data
{
	public class ComponentFilter
	{
		public EnumValue<ComponentType> Type { get; }

		public IEnumerable<PropertyFilter> PropertyFilters { get; }

		public ComponentFilter(EnumValue<ComponentType> type, IEnumerable<PropertyFilter> propertyFilters)
		{
			Type = type ?? throw new ArgumentNullException(nameof(type));
			PropertyFilters = propertyFilters ?? throw new ArgumentNullException(nameof(propertyFilters));
		}
	}
}
