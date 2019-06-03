using ComputersShop.Domain.Data;
using ComputersShop.Domain.Models;

namespace ComputersShop.ComputerBuilder.Objects
{
	public class CompatibilityResult
	{
		public bool IsCompatible { get; }

		public ComponentFilter CompatibilityReason { get; }
	}
}
