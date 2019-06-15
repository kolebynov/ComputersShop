using System;
using System.Linq.Expressions;
using ComputersShop.Domain.Data;
using ComputersShop.Domain.Models.Abstractions;

namespace ComputersShop.Domain.Abstractions
{
	public interface IFilterExpressionBuilder
	{
		Expression<Func<IComponent, bool>> BuildFilterExpression(ComponentFilter componentFilter);
	}
}