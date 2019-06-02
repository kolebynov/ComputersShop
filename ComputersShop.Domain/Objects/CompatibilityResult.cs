using System;
using System.Collections.Generic;
using System.Text;
using ComputersShop.Domain.Models;

namespace ComputersShop.Domain.Objects
{
	public class CompatibilityResult
	{
		public bool IsCompatible { get; }

		public ComponentCompatibility CompatibilityReason { get; }
	}
}
