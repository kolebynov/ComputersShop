using System.Collections.Generic;
using ComputersShop.Domain.Data;
using ComputersShop.Shared;

namespace ComputersShop.Domain.Models.Abstractions
{
	public interface IComponent
	{
		EnumValue<ComponentType> Type { get; }

		IReadOnlyList<ComponentPropertyValuePair> Properties { get; }

		IReadOnlyList<ComponentFilter> Compatibilities { get; }
	}
}
