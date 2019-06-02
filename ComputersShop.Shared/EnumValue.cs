using System;

namespace ComputersShop.Shared
{
	public class EnumValue<T>
		where T : Enum
	{
		public T Value { get; }

		public EnumValue(T value)
		{
			if (!Enum.IsDefined(typeof(T), value))
			{
				throw new ArgumentException($"\"{value}\" is not value of {typeof(T)} enum", nameof(value));
			}

			Value = value;
		}
	}
}
