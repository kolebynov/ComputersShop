using System.Collections.Generic;

namespace ComputersShop.Domain.Models.Abstractions
{
	public interface ICompatibilityCollection : IEnumerable<ComponentCompatibility>
	{
		bool IsComponentCompatible(IComponent component);
	}
}
