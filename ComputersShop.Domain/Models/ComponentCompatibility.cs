using ComputersShop.Domain.Models.Abstractions;

namespace ComputersShop.Domain.Models
{
	public class ComponentCompatibility
	{
		IComponentFilter CompatibilityFilter { get; }

		int Count { get; }
	}
}
