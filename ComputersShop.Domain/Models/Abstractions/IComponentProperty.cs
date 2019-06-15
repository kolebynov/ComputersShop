using System;

namespace ComputersShop.Domain.Models.Abstractions
{
	public interface IComponentProperty
	{
		Guid Id { get; }

		string Name { get; }

		PropertyValueType ValueType { get; }

		IPropertyValue CreateValue(string stringValue);
	}
}