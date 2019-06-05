using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ComputersShop.Domain.Data;

namespace ComputersShop.Catalog.Abstractions
{
	public interface IComponentCatalog
	{
		Task<IReadOnlyList<IComponentCatalog>> GetComponents(ComponentFilter filter, int limit, int skip);
	}
}
