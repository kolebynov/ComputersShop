using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ComputersShop.ComputerBuilder.Objects;
using ComputersShop.Domain.Models;
using ComputersShop.Domain.Models.Abstractions;
using ComputersShop.Shared;

namespace ComputersShop.ComputerBuilder.Abstractions
{
	public interface ICompatibilityHelper
	{
		CompatibilityResult IsComponentsCompatible(IEnumerable<IComponent> components, IComponent checkedComponent);

		Task<IReadOnlyList<IComponent>> GetCompatibleComponents(IEnumerable<IComponent> components,
			EnumValue<ComponentType> componentType, int limit, int skip);
	}
}
