using System;
using System.Collections.Generic;
using ComputersShop.Domain.Models;
using ComputersShop.Shared;
using ComputersShop.Shared.Extensions;

namespace ComputersShop.Domain.Data
{
	public class ComponentFilter
	{
		public EnumValue<FilterType> Type { get; }

		public ComparisonFilter ComparisonFilter { get; }

		public FilterGroup FilterGroup { get; }

		public bool IsNegate { get; private set; }

		public ComponentFilter(ComparisonFilter comparisonFilter)
		{
			ComparisonFilter = comparisonFilter ?? throw new ArgumentNullException(nameof(comparisonFilter));
			Type = FilterType.Comparison.ToEnumValue();
		}

		public ComponentFilter(FilterGroup filterGroup)
		{
			FilterGroup = filterGroup ?? throw new ArgumentNullException(nameof(filterGroup));
			Type = FilterType.FilterGroup.ToEnumValue();
		}

		public ComponentFilter Negate()
		{
			IsNegate = !IsNegate;
			return this;
		}
	}
}
