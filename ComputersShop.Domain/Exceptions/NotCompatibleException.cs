using System;
using System.Collections.Generic;
using System.Text;
using ComputersShop.Domain.Models;
using ComputersShop.Domain.Models.Abstractions;

namespace ComputersShop.Domain.Exceptions
{
	public class NotCompatibleException : Exception
	{
		public IComponent Component { get; }

		public IComponent NotCompatibleComponent { get; }

		public ComponentCompatibility CompatibilityReason { get; }

		public NotCompatibleException(IComponent component, IComponent notCompatibleComponent, ComponentCompatibility compatibilityReason)
		{
			Component = component ?? throw new ArgumentNullException(nameof(component));
			NotCompatibleComponent = notCompatibleComponent ?? throw new ArgumentNullException(nameof(notCompatibleComponent));
			CompatibilityReason = compatibilityReason ?? throw new ArgumentNullException(nameof(compatibilityReason));
		}
	}
}
