using Lara.Stringifier;
using System;
using System.Linq.Expressions;

namespace Lara
{
    /// <summary>
    /// Helps the developer during debuging by providing an easy way of stringify
    /// the properties of an object instance thru a fluent API.
    /// </summary>
    public static class StringifierFluentExtension
    {
        /// <summary>
        /// Adds a property to be stringified.
        /// </summary>
        public static FluentPropertyValue<TSource> StringifyThisProperty<TSource, TProperty>(this TSource obj, Expression<Func<TSource, TProperty>> propertyLambda)
        {
            string propertyName = GetName(propertyLambda);
            return new FluentPropertyValue<TSource>(obj, propertyName);
        }

        /// <summary>
        /// Adds a property to be stringified.
        /// </summary>
        public static FluentPropertyValue<TSource> AndThisProperty<TSource, TProperty>(this FluentPropertyValue<TSource> fluentPropertuValue, Expression<Func<TSource, TProperty>> propertyLambda)
        {
            string propertyName = GetName(propertyLambda);
            return new FluentPropertyValue<TSource>(fluentPropertuValue, propertyName);
        }

        /// <summary>
        /// Adds a property to be ignored in the stringifier.
        /// </summary>
        public static FluentIgnorePropertyValue<TSource> StringifyPropertiesExcept<TSource, TProperty>(this TSource obj, Expression<Func<TSource, TProperty>> propertyLambda)
        {
            string propertyName = GetName(propertyLambda);
            return new FluentIgnorePropertyValue<TSource>(obj, propertyName);
        }

        /// <summary>
        /// Adds a property to be ignored in the stringifier.
        /// </summary>
        public static FluentIgnorePropertyValue<TSource> AndExceptThisProperty<TSource, TProperty>(this FluentIgnorePropertyValue<TSource> fluentPropertuValue, Expression<Func<TSource, TProperty>> propertyLambda)
        {
            string propertyName = GetName(propertyLambda);
            return new FluentIgnorePropertyValue<TSource>(fluentPropertuValue, propertyName);
        }

        private static string GetName<TSource, TProperty>(Expression<Func<TSource, TProperty>> exp)
        {
            if (!(exp.Body is MemberExpression body))
            {
                UnaryExpression ubody = (UnaryExpression)exp.Body;
                body = ubody.Operand as MemberExpression;
            }

            return body.Member.Name;
        }
    }
}
