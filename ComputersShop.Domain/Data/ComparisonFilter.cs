﻿using ComputersShop.Domain.Models;
using ComputersShop.Shared;

namespace ComputersShop.Domain.Data
{
	public class ComparisonFilter
	{
		public ComponentPropertyValuePair PropertyValuePair { get; }

		public EnumValue<ComparisonType> ComparisonType { get; }
	}
}
