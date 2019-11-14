using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Lara
{
    /// <summary>
    /// Provides a easy way of building/filling entities with random information.
    /// </summary>
    public static class EntityBuilder
    {
        /// <summary>
        /// Initializes the Entity Builder class with the type to be returned.
        /// </summary>
        /// <typeparam name="T">The type of the object(s) to be builded and returned.</typeparam>
        public static IEntityBuilderFill<T> Fill<T>()
            where T : new()
        {
            return new EntityBuilderFill<T>();
        }
    }

    public interface IEntityBuilderFill<T>
    {
        /// <summary>
        /// Adds a rule to override the default random function that is applied on the field.
        /// </summary>
        /// <param name="property">The property to have the rule applied. Example: x => x.Name</param>
        /// <param name="func">A delegate to the function that will be called to fill the property. Example: () => Randomizer.Person.Name()</param>
        IEntityBuilderFill<T> WithRule(Expression<Func<T, object>> property, Func<object> func);

        /// <summary>
        /// Adds a rule to override the default random function that is applied on the field.
        /// </summary>
        /// <param name="property">The property to have the rule applied. Example: x => x.Name</param>
        /// <param name="func">The value that will be filled in the property. Example: "John"</param>
        IEntityBuilderFill<T> WithRule(Expression<Func<T, object>> property, object value);

        /// <summary>
        /// Ignores a property on the entity. The property will be kept with its default value.
        /// </summary>
        /// <param name="property">The property to be ignored. Example: x => x.Age</param>
        IEntityBuilderFill<T> Except(Expression<Func<T, object>> property);

        /// <summary>
        /// Fills the entity with random information.
        /// </summary>
        /// <returns>An object of type T</returns>
        T Build();

        /// <summary>
        /// Fills a List of Entities with random information.
        /// </summary>
        /// <param name="quantity">The number of entities to be created and returned.</param>
        /// <returns>A List of objects of type T</returns>
        List<T> BuildList(int quantity);
    }

    internal class EntityBuilderFill<T> : IEntityBuilderFill<T>
        where T : new()
    {
        private Dictionary<string, Func<object>> Rules;
        private List<string> Exceptions;

        public EntityBuilderFill()
        {
            Exceptions = new List<string>();
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
                    if (!PropertyMustBeIgnored(property))
                    {
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
            AddException(GetPropertyName(property));
            return this;
        }

        private void AddException(string propertyName)
        {
            Exceptions.Add(propertyName);
        }

        private void AddRule(string propertyName, Func<object> func)
        {
            Rules.Add(propertyName, func);
        }

        private string GetPropertyName<TSource, TProperty>(Expression<Func<TSource, TProperty>> exp)
        {
            if (!(exp.Body is MemberExpression body))
            {
                UnaryExpression ubody = (UnaryExpression)exp.Body;
                body = ubody.Operand as MemberExpression;
            }

            return body.Member.Name;
        }

        private bool PropertyMustBeIgnored(PropertyInfo propertyInfo)
        {
            bool isInExceptionList = Exceptions.Any(e => e == propertyInfo.Name);
            return isInExceptionList;
        }

        private bool PropertyHasRule(PropertyInfo propertyInfo)
        {
            var propertyHasRule = Rules.Any(r => r.Key == propertyInfo.Name);
            return propertyHasRule;
        }

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

        private object GetRandomValue(PropertyInfo propertyInfo)
        {
            var typeName = propertyInfo.PropertyType.ToString().ToLower();
            object value = typeName switch
            {
                string type when type.Contains("int32") => TestHelper.RandomInt(),
                string type when type.Contains("int64") => TestHelper.RandomInt(),
                string type when type.Contains("double") => TestHelper.RandomDouble(),
                string type when type.Contains("byte") => TestHelper.RandomByte(),
                string type when type.Contains("datetime") => TestHelper.RandomDate(),
                string type when type.Contains("string") => TestHelper.RandomString(),
                string type when type.Contains("bool") => Convert.ToBoolean(TestHelper.RandomInt(0, 1)),
                _ => TestHelper.RandomString()
            };

            return value;
        }
    }

    //#ToDo: replace by real random methods
    internal static class TestHelper
    {
        public static int RandomInt(int min = 0, int max = 100000) => 1;
        public static double RandomDouble() => 1;
        public static byte RandomByte() => 1;
        public static DateTime RandomDate() => DateTime.MaxValue;
        public static string RandomString() => "aaaaa";
    }

}
