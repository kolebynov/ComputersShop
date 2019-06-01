using System;

namespace ComputersShop.Shared.Extensions
{
	public static class EnumExtensions
	{
		public static EnumValue<T> ToEnumValue<T>(T value)
			where T : Enum
			=> new EnumValue<T>(value);
	}
}
