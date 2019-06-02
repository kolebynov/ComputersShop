using System.Collections.Generic;
using System.Threading.Tasks;
using ComputersShop.Domain.Models;
using ComputersShop.Domain.Models.Abstractions;
using ComputersShop.Shared;

namespace ComputersShop.ComputerBuilder.Abstractions
{
	public interface IComputerBuilder
	{
		Task<Computer> Build();

		Task<IReadOnlyList<IComponent>> GetCompatibleComponents(EnumValue<ComponentType> componentType, int limit, int skip);

		Task WithComponent(IComponent component);
	}
}
