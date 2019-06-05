using System;
using ComputersShop.Domain.Models.Abstractions;

namespace ComputersShop.Catalog.Models.Abstractions
{
	public interface ICatalogComponent : IComponent
	{
		Uri ImageUri { get; }
	}
}
