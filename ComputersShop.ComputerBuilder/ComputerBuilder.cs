using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ComputersShop.ComputerBuilder.Abstractions;
using ComputersShop.Domain.Data;
using ComputersShop.Domain.Data.Abstractions;
using ComputersShop.Domain.Exceptions;
using ComputersShop.Domain.Extensions;
using ComputersShop.Domain.Models;
using ComputersShop.Domain.Models.Abstractions;
using ComputersShop.Shared;

namespace ComputersShop.ComputerBuilder
{
	public class ComputerBuilder : IComputerBuilder
	{
		private readonly IComponentRepository _componentRepository;
		private readonly List<IComponent> _components = new List<IComponent>();

		public ComputerBuilder(IComponentRepository componentRepository)
		{
			_componentRepository = componentRepository ?? throw new ArgumentNullException(nameof(componentRepository));
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

			return _componentRepository.GetComponents(BuildCompatibilityFilter(componentType.Value), limit, skip);
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
			foreach (var c in _components)
			{
				var result = c.IsCompatibleWith(component);
				if (!result.IsCompatible)
				{
					throw new NotCompatibleException(c, component, result.CompatibilityReason);
				}
			}
		}

		private ComponentFilter BuildCompatibilityFilter(ComponentType componentType)
		{

		}
	}
}
