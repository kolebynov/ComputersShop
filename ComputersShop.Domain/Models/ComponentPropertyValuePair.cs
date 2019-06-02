using ComputersShop.Domain.Models.Abstractions;

namespace ComputersShop.Domain.Models
{
	public class ComponentPropertyValuePair
	{
		public ComponentProperty Property { get; }

		public IPropertyValue Value { get; }
	}
}
