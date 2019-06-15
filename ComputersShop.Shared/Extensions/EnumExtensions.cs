using System;

namespace ComputersShop.Shared.Extensions
{
	public static class EnumExtensions
	{
		public static EnumValue<T> ToEnumValue<T>(this T value)
			where T : Enum
			=> new EnumValue<T>(value);
	}
}
