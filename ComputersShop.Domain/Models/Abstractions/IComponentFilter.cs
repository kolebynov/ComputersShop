namespace ComputersShop.Domain.Models.Abstractions
{
	public interface IComponentFilter
	{
		bool ApplyFilter(IComponent component);
	}
}
