namespace ComputersShop.Domain.Models.Abstractions
{
	public interface ICompatibilityFilter
	{
		bool ApplyFilter(IComponent component);
	}
}
