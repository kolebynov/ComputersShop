using ComputersShop.Domain.Models.Abstractions;

namespace ComputersShop.Domain.Models
{
	public class ComponentProperty
	{
		public PropertyInfo Info { get; }

		public IPropertyValue Value { get; }
	}
}
