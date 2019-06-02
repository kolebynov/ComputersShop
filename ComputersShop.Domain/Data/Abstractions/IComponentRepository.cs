using System.Collections.Generic;
using System.Threading.Tasks;
using ComputersShop.Domain.Models.Abstractions;

namespace ComputersShop.Domain.Data.Abstractions
{
	public interface IComponentRepository
	{
		Task<IReadOnlyList<IComponent>> GetComponents(ComponentFilter filter, int limit, int skip);
	}
}
