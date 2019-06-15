using System;
using System.Collections.Generic;
using ComputersShop.Domain.Data;

namespace ComputersShop.Domain.Models.Abstractions
{
	public interface IComponent
	{
		Guid Id { get; }

		IReadOnlyList<ComponentPropertyValuePair> Properties { get; }

		ComponentFilter CompatibilityFilter { get; }
	}
}
