using ComputersShop.Domain.Models.Abstractions;

namespace ComputersShop.Domain.Models
{
	public class ComponentCompatibility
	{
		ICompatibilityFilter CompatibilityFilter { get; }

		int Count { get; }
	}
}
