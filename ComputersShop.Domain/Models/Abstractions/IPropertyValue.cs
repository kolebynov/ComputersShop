namespace ComputersShop.Domain.Models.Abstractions
{
	public interface IPropertyValue
	{
		PropertyValueType Type { get; }

		string StringValue { get; }

		int IntegerValue { get; }

		decimal DecimalValue { get; }
	}
}