using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ComputersShop.ComputerBuilder.Abstractions;
using ComputersShop.Domain.Exceptions;
using ComputersShop.Domain.Models;
using ComputersShop.Domain.Models.Abstractions;
using ComputersShop.Shared;

namespace ComputersShop.ComputerBuilder
{
	public class ComputerBuilder : IComputerBuilder
	{
		private readonly List<IComponent> _components = new List<IComponent>();
		private readonly ICompatibilityHelper _compatibilityHelper;

		public ComputerBuilder(ICompatibilityHelper compatibilityHelper)
		{
			_compatibilityHelper = compatibilityHelper ?? throw new ArgumentNullException(nameof(compatibilityHelper));
		}

		public Task<Computer> Build()
		{
			return Task.FromResult(new Computer());
		}

		public Task<IReadOnlyList<IComponent>> GetCompatibleComponents(EnumValue<ComponentType> componentType, int limit, int skip)
		{
			if (componentType == null)
			{
				throw new ArgumentNullException(nameof(componentType));
			}

			return _compatibilityHelper.GetCompatibleComponents(_components, componentType, limit, skip);
		}

		public Task WithComponent(IComponent component)
		{
			if (component == null)
			{
				throw new ArgumentNullException(nameof(component));
			}

			CheckCompatibility(component);

			_components.Add(component);
			return Task.CompletedTask;
		}

		private void CheckCompatibility(IComponent component)
		{
			var result = _compatibilityHelper.IsComponentsCompatible(_components, component);
			if (!result.IsCompatible)
			{
				throw new NotCompatibleException(c, component, result.CompatibilityReason);
			}
		}
	}
}
