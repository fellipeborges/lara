using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Lara
{
    internal class EntityBuilderFill<T> : IEntityBuilderFill<T>
        where T : new()
    {
        private readonly Dictionary<string, Func<object>> Rules;
        private readonly List<string> IgnoreList;

        public EntityBuilderFill()
        {
            IgnoreList = new List<string>();
            Rules = new Dictionary<string, Func<object>>();
        }

        public T Build()
        {
            var entity = new T();
            typeof(T)
                .GetProperties()
                .ToList()
                .ForEach(property =>
                {
                    SetValueToProperty(property, entity);
                });

            return entity;
        }

        public List<T> BuildList(int quantity)
        {
            return Enumerable
                .Range(1, quantity)
                .Select(i => Build())
                .ToList();
        }

        public IEntityBuilderFill<T> WithRule(Expression<Func<T, object>> property, Func<object> func)
        {
            AddRule(GetPropertyName(property), func);
            return this;
        }

        public IEntityBuilderFill<T> WithRule(Expression<Func<T, object>> property, object value)
        {
            AddRule(GetPropertyName(property), () => { return value; });
            return this;
        }

        public IEntityBuilderFill<T> Except(Expression<Func<T, object>> property)
        {
            AddToIgnoreList(GetPropertyName(property));
            return this;
        }

        /// <summary>
        /// Adds a property to the local list of properties that must be ignored later when building the entity.
        /// </summary>
        private void AddToIgnoreList(string propertyName)
        {
            IgnoreList.Add(propertyName);
        }

        /// <summary>
        /// Adds a Rule to the local list of rules that must be applied later when building the entity.
        /// </summary>
        private void AddRule(string propertyName, Func<object> func)
        {
            Rules.Add(propertyName, func);
        }

        /// <summary>
        /// Sets a value to a property.
        /// Before setting the value checks if the property must be ignored and if it has a configured rule or should be filled with random information.
        /// </summary>
        private void SetValueToProperty(PropertyInfo property, T entity)
        {
            if (PropertyMustBeIgnored(property))
            {
                return;
            }

            object value;
            if (PropertyHasRule(property))
            {
                value = GetRuleValue(property);
            }
            else
            {
                value = GetRandomValue(property);
            }

            property.SetValue(entity, value);
        }

        /// <summary>
        /// Returns a value that is configured in a Rule.
        /// </summary>
        private object GetRuleValue(PropertyInfo propertyInfo)
        {
            var rule = Rules.FirstOrDefault(r => r.Key == propertyInfo.Name).Value;
            if (rule != null)
            {
                object evaluatedValue = rule();
                return evaluatedValue;
            }

            return null;
        }

        /// <summary>
        /// Returns a value randomized based on its type.
        /// </summary>
        private object GetRandomValue(PropertyInfo propertyInfo)
        {
            //#ToDo: replace by real random methods
            var typeName = propertyInfo.PropertyType.ToString().ToLower();
            object value = typeName switch
            {
                string type when type.Contains("int32") => 1,
                string type when type.Contains("int64") => 1,
                string type when type.Contains("double") => (double)1,
                string type when type.Contains("byte") => (byte)1,
                string type when type.Contains("datetime") => DateTime.MaxValue,
                string type when type.Contains("string") => "ABC",
                string type when type.Contains("bool") => true,
                _ => null
            };

            return value;
        }

        /// <summary>
        /// Returns the property name (string) based on the given expression.
        /// </summary>
        private string GetPropertyName<TSource, TProperty>(Expression<Func<TSource, TProperty>> exp)
        {
            if (!(exp.Body is MemberExpression body))
            {
                UnaryExpression ubody = (UnaryExpression)exp.Body;
                body = ubody.Operand as MemberExpression;
            }

            return body.Member.Name;
        }

        /// <summary>
        /// Checks if a property must be ignored by checking if it's added in the "IgnoreList" collection.
        /// </summary>
        private bool PropertyMustBeIgnored(PropertyInfo propertyInfo)
        {
            bool isInIgnoreList = IgnoreList.Any(e => e == propertyInfo.Name);
            return isInIgnoreList;
        }

        /// <summary>
        /// Checks if a property has a configured Rule by checking if there is a record in the "Rules" collection.
        /// </summary>
        private bool PropertyHasRule(PropertyInfo propertyInfo)
        {
            var propertyHasRule = Rules.Any(r => r.Key == propertyInfo.Name);
            return propertyHasRule;
        }
    }
}
