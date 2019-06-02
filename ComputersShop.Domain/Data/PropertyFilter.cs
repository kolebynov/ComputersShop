using ComputersShop.Domain.Models;
using ComputersShop.Shared;

namespace ComputersShop.Domain.Data
{
	public class PropertyFilter
	{
		public ComponentPropertyValuePair PropertyValuePair { get; }

		public EnumValue<ComparisonType> ComparisonType { get; }
	}
}
