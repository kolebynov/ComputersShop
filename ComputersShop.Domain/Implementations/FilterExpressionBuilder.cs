using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ComputersShop.Domain.Abstractions;
using ComputersShop.Domain.Data;
using ComputersShop.Domain.Models.Abstractions;

namespace ComputersShop.Domain.Implementations
{
	public class FilterExpressionBuilder : IFilterExpressionBuilder
	{
		public Expression<Func<IComponent, bool>> BuildFilterExpression(ComponentFilter componentFilter)
		{
			var componentParameter = Expression.Parameter(typeof(IComponent));
			var filterExpression = BuildExpressionInternal(componentFilter, componentParameter);

			return Expression.Lambda<Func<IComponent, bool>>(filterExpression, componentParameter);
		}

		private Expression BuildExpressionInternal(ComponentFilter componentFilter,
			ParameterExpression componentParameter)
		{
			Expression expression;

			switch (componentFilter.Type.Value)
			{
				case FilterType.FilterGroup:
					expression = BuildFilterGroupExpression(componentFilter.FilterGroup, componentParameter);
					break;
				case FilterType.Comparison:
					expression = BuildComparisonExpression(componentFilter.ComparisonFilter, componentParameter);
					break;
				default:
					throw new InvalidOperationException($"Unknown filter type \"{componentFilter.Type}\"");
			}

			if (componentFilter.IsNegate)
			{
				expression = Expression.Negate(expression);
			}

			return expression;
		}

		private Expression BuildFilterGroupExpression(FilterGroup filterGroup, ParameterExpression componentParameter)
		{
			var binaryExpressionFunc = filterGroup.LogicalOperation == LogicalOperation.And 
				? (Func<Expression, Expression, BinaryExpression>)Expression.AndAlso 
				: Expression.OrElse;

			if (filterGroup.InnerFilters.Count == 0)
			{
				throw new ArgumentException("Inner filters count must be more than 0", nameof(filterGroup));
			}

			if (filterGroup.InnerFilters.Count == 1)
			{
				return BuildExpressionInternal(filterGroup.InnerFilters[0], componentParameter);
			}

			return filterGroup.InnerFilters
				.Skip(2)
				.Aggregate(
					binaryExpressionFunc(
						BuildExpressionInternal(filterGroup.InnerFilters[0], componentParameter),
						BuildExpressionInternal(filterGroup.InnerFilters[1], componentParameter)),
					(expr, componentFilter) => binaryExpressionFunc(expr, BuildExpressionInternal(componentFilter, componentParameter)));
		}

		private Expression BuildComparisonExpression(ComparisonFilter filter, ParameterExpression componentParameter)
		{
			return 
		}
	}
}
