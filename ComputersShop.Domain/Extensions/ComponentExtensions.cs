using System;
using ComputersShop.Domain.Models.Abstractions;
using ComputersShop.Domain.Objects;

namespace ComputersShop.Domain.Extensions
{
	public static class ComponentExtensions
	{
		public static CompatibilityResult IsCompatibleWith(this IComponent firstComponent, IComponent secondComponent)
		{
			if (firstComponent == null)
			{
				throw new ArgumentNullException(nameof(firstComponent));
			}

			if (secondComponent == null)
			{
				throw new ArgumentNullException(nameof(secondComponent));
			}

			return new CompatibilityResult();
		}
	}
}
