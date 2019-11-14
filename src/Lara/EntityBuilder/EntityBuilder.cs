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

        IEntityBuilderFill<T> WithRule(Expression<Func<T, string>> property, EntityBuilderStringRule rule);

        IEntityBuilderFill<T> WithRule(Expression<Func<T, int>> property, EntityBuilderIntRule rule);
    }

    public enum EntityBuilderStringRule
    {
        FirstName = 1,
        LastName = 2,
        FullName = 3
    }

    public enum EntityBuilderIntRule
    {
        OnlyPositives = 1,
        OnlyNegatives = 2,
        PersonAge = 3
    }

    internal class EntityBuilderFill<T> : IEntityBuilderFill<T>
        where T : new()
    {
        private List<EntityRule> Rules;

        public T Build()
        {
            var entity = new T();
            typeof(T)
                .GetProperties()
                .ToList()
                .ForEach(property =>
                {
                    object value = GetValueForProperty(property);
                    property.SetValue(entity, value);
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

        public IEntityBuilderFill<T> WithRule(Expression<Func<T, string>> property, EntityBuilderStringRule rule)
        {
            var propertyName = GetPropertyName(property);
            AddRule(EntityRule.FieldTypeEnum.String, propertyName, rule);
            return this;
        }

        public IEntityBuilderFill<T> WithRule(Expression<Func<T, int>> property, EntityBuilderIntRule rule)
        {
            var propertyName = GetPropertyName(property);
            AddRule(EntityRule.FieldTypeEnum.Int, propertyName, rule);
            return this;
        }

        private void AddRule(EntityRule.FieldTypeEnum fieldType, string propertyName, object rule)
        {
            if (Rules == null)
                Rules = new List<EntityRule>();

            Rules.Add(new EntityRule
            {
                FieldType = fieldType,
                PropertyName = propertyName,
                RuleValue = rule
            });
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

        private static object GetValueForProperty(PropertyInfo propertyInfo)
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

        private class EntityRule
        {
            internal enum FieldTypeEnum
            {
                String = 1,
                Int = 2
            }

            internal FieldTypeEnum FieldType { get; set; }

            public string PropertyName { get; set; }

            public object RuleValue { get; set; }
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
